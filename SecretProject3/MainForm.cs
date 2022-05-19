using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecretProject3.Shapes;

namespace SecretProject3
{
    public partial class MainForm : Form 
    {
        private static List<Shape> _shapes = new List<Shape>();
        private bool toDelete = false;
        private bool isBrush = false;
        private bool isEraser = false;

        public static List<Shape> Shapes
        {
            get
            {
                return _shapes;
            }
             set
            {
                _shapes = value;
            }
        }

        private Point _mouseDownLocation;
        private Shape _selectedShape;
        private Shapes.Rectangle _selectionRectangle;
        public MainForm()
        {
            InitializeComponent();

            typeof(PictureBox).InvokeMember("DoubleBuffered",
                             BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                             null, this, new object[] { true });
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (Shape s in _shapes)
                s.Paint(e.Graphics);

            if (_selectedShape != null && !toDelete)  // && _shapes.Count > 0
                _selectedShape.Paint(e.Graphics);

            if (_selectionRectangle != null && !toDelete)
                _selectionRectangle.Paint(e.Graphics);

            toDelete = false;
        }

        /**Choosing Shape Type*/
        private void rectangleButton_Click(object sender, EventArgs e)
        {
            isBrush = false;
            isEraser = false;
            _selectedShape = new Shapes.Rectangle();
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            isBrush = false;
            isEraser = false;
            _selectedShape = new Shapes.Square();
        }
        private void circleButton_Click(object sender, EventArgs e)
        {
            isBrush = false;
            isEraser = false;
            _selectedShape = new Shapes.Circle();
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            isBrush = false;
            isEraser = false;
            _selectedShape = new Shapes.Triangle();
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (_mouseDownLocation == null || isBrush || isEraser)
                return;

            if (e.Button == MouseButtons.Right)
            {
                _selectionRectangle = null;
            }
            else if (e.Button == MouseButtons.Left)
            {
                //Add Shape to List
                _shapes.Add(_selectedShape);
                _selectedShape.Selected = true;
            }
            Invalidate();
        }

        /**Updating coordinates and size of the shape*/
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                if (isBrush)
                {
                    using (var brush = new SolidBrush(Color.Blue)) //PICK COLOR...
                        CreateGraphics().FillEllipse(brush, e.X, e.Y, 5, 5); //EDIT BRUSH SIZE...

                    return;
                }else if (isEraser)
                {
                    
                    using (var brush = new SolidBrush(Color.White)) //PICK COLOR...
                        CreateGraphics().FillEllipse(brush, e.X, e.Y, 5, 5); //EDIT BRUSH SIZE...

                    return;
                }
                _selectedShape.UpdatePosition(e.Location, _mouseDownLocation);
                _selectedShape.Paint(this.CreateGraphics());
            }
            else if (e.Button == MouseButtons.Right)
            {
                _selectionRectangle.UpdatePosition(e.Location, _mouseDownLocation);
                _selectionRectangle.Paint(this.CreateGraphics());

                foreach (Shape innerShape in _shapes)
                {
                    if (_selectionRectangle.ContainsInside(innerShape))
                    {
                        innerShape.Selected = true;
                    }
                    else
                    {
                        innerShape.Selected = false;
                    }
                }
                //Invalidate();
            }
            else if (e.Button == MouseButtons.Middle)
            {
                if (_shapes.Where(shape => shape.Selected).Count() == 1) //If only one shape is selected -> then you can move it
                {
                    _selectedShape.Move(e.Location, _mouseDownLocation);
                    _mouseDownLocation = e.Location;
                    Invalidate();
                    return;
                }
            }
            if (!isBrush && !isEraser)
            {
                Invalidate();
            }
        }
        /**First time clicking*/
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right && e.Button != MouseButtons.Middle || isBrush || isEraser)
                return;

            _mouseDownLocation = e.Location;
            if (e.Button == MouseButtons.Middle)
            {
                if (_shapes.Where(shape => shape.Selected).Count() == 1) //If only one shape is selected -> then you can move it
                {
                    _selectedShape = _shapes.Where(shape => shape.Selected).First(); //InvalidCastException //.Cast<Shape>() //.Select(shape => (Shape) shape)
                    return;
                }
            }
            DeselectShapes();
            if (e.Button == MouseButtons.Right)
            {
                foreach (Shape shape in _shapes)
                {
                    shape.Selected = shape.ContainsPoint(e.Location);
                }

                _selectionRectangle = new Shapes.Rectangle();
                _selectionRectangle.ColorFill = Color.Transparent;
                _selectionRectangle.Location = _mouseDownLocation;
            }
            else if (e.Button == MouseButtons.Left)
            {
                _selectedShape = (Shape)Activator.CreateInstance(_selectedShape.GetType());
                //Debug.WriteLine(_selectedShape.GetType());

                _selectedShape.ColorFill = Color.Blue; //EDIT COLOR HERE...

                _selectedShape.Location = _mouseDownLocation;
            }
            Invalidate();
        }
   

        /**Edit Shape*/
        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e) //DOUBLE RIGHT CLICK
        {
            foreach (Shape s in _shapes)
            {
                if (s.Selected)
                {
                    s.OpenEditor();
                    break;
                }
                Invalidate();
            }
        }
        private void deleteSelectedShapesButton_Click(object sender, EventArgs e)
        {
            _shapes = _shapes
                .Where(shape => !shape.Selected)
                .ToList();

            _selectedShape = (Shape)Activator.CreateInstance(_selectedShape.GetType());
            toDelete = true;
            Invalidate();
        }
        private void brushButton_Click(object sender, EventArgs e)
        {
            isBrush = true;
            _selectedShape = null;
        }
        private void eraserButton_Click(object sender, EventArgs e)
        {
            isBrush = false;
            isEraser = true;
            _selectedShape = null;
        }

        /**Delete all shapes / Clear window*/
        private void buttonReset_Click(object sender, EventArgs e)
        {
            _shapes.Clear();

            _selectedShape = (Shape)Activator.CreateInstance(_selectedShape.GetType());
            toDelete = true;
            Invalidate();
        }
        /**Select all shapes*/
        private void SelectShapes()
        {
            foreach (Shape s in _shapes)
                s.Selected = true;

            Invalidate();
        }

        /**Deselect all shapes*/
        private void DeselectShapes()
        {
            foreach (Shape s in _shapes)
                s.Selected = false;

            Invalidate();
        }

        /**Total area of all shapes*/
        private int CalculateShapesArea()
        {
            int area = 0;
            for (int i = 0; i < _shapes.Count; i++)
                area += _shapes[i].Area;

            return area;
        }

        /**Serialization*/
        private void FormScene_Load(object sender, EventArgs e)
        {
            if (!File.Exists("data"))
                return;
            IFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream("data", FileMode.Open))
                _shapes = (List<Shape>)formatter.Deserialize(fs);
        }

        private void FormScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream("data", FileMode.Create))
                formatter.Serialize(fs, _shapes);
        }

    }
}

