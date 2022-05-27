using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using VectorGraphicEditor.Shapes;

namespace VectorGraphicEditor
{
    public partial class MainForm : Form 
    {
        private static List<Shape> _shapes = new List<Shape>();
        private bool toDelete = false;
        private bool isBrush = false;
        private bool isEraser = false;

        private Point _mouseDownLocation;
        private Shape _selectedShape;
        private Shapes.Rectangle _selectionRectangle = new Shapes.Rectangle();
        public MainForm()
        {
            InitializeComponent();

            foreach (Control control in panelMenu.Controls)
            {
                if (control is PictureBox)
                {
                    control.MouseHover += (o, e) => control.BackColor = Color.FromArgb(47, 49, 54);
                    control.MouseEnter += (o, e) => control.BackColor = Color.FromArgb(47, 49, 54);
                    control.MouseLeave += (o, e) => control.BackColor = Color.Transparent;
                }
            }
            panelMenu.BackColor = Color.FromArgb(32, 34, 37);
            buttonCustomColor.BackColor = this.BackColor;
            SetStyle(ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer, true);
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

        private void pictureBoxRectangle_Click(object sender, EventArgs e)
        {
            isBrush = false;
            isEraser = false;
            _selectedShape = new Shapes.Rectangle();
        }

        private void pictureBoxSquare_Click(object sender, EventArgs e)
        {
            isBrush = false;
            isEraser = false;
            _selectedShape = new Shapes.Square();
        }

        private void pictureBoxTriangle_Click(object sender, EventArgs e)
        {
            isBrush = false;
            isEraser = false;
            _selectedShape = new Shapes.Triangle();
        }

        private void pictureBoxCircle_Click(object sender, EventArgs e)
        {
            isBrush = false;
            isEraser = false;
            _selectedShape = new Shapes.Circle();
        }

        private void pictureBoxEraser_Click(object sender, EventArgs e)
        {
            isBrush = false;
            isEraser = true;
            _selectedShape = null;
        }

        private void pictureBoxLine_Click(object sender, EventArgs e)
        {
            isEraser = false;
            isBrush = true;
            _selectedShape = null;
        }


        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _selectionRectangle = null;
                Invalidate();
            }

            if (_mouseDownLocation == null || isBrush || isEraser)
                return;

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
                        _selectedShape = innerShape;
                    }
                    else
                    {
                        innerShape.Selected = false;
                    }
                }
                Invalidate();
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
            _mouseDownLocation = e.Location;
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right && e.Button != MouseButtons.Middle)
                return;

            if (e.Button == MouseButtons.Middle)
            {
                if (_shapes.Where(shape => shape.Selected).Count() == 1) //If only one shape is selected -> then you can move it
                {
                    _selectedShape = _shapes.Where(shape => shape.Selected).First();
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
                try //if brush / eraser
                {
                    _selectedShape = (Shape)Activator.CreateInstance(_selectedShape.GetType());
                    //Debug.WriteLine(_selectedShape.GetType());

                    _selectedShape.ColorFill = Color.Blue; //EDIT COLOR HERE...

                    _selectedShape.Location = _mouseDownLocation;
                }catch (Exception ex)
                {
                    if (isEraser)
                        return;
                    isBrush = true;
                }
            }
            Invalidate();
        }
   

        /**Edit Shape*/
        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Right)
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
        }
        private void deleteSelectedShapesButton_Click(object sender, EventArgs e)
        {
            _shapes = _shapes
                .Where(shape => !shape.Selected)
                .ToList();

            try
            {
                _selectedShape = (Shape)Activator.CreateInstance(_selectedShape.GetType());
                toDelete = true;
            }catch(Exception ex)  {}
            Invalidate();
        }
        /**Delete all shapes / Clear window*/
        private void buttonReset_Click(object sender, EventArgs e)
        {
            _shapes.Clear();
            try
            {
                _selectedShape = (Shape)Activator.CreateInstance(_selectedShape.GetType());
                toDelete = true;
            }catch (Exception ex)
            {

            }
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
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists("data"))
                return;
            IFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream("data", FileMode.Open))
                _shapes = (List<Shape>)formatter.Deserialize(fs);
        }
        private void buttonCustomColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                buttonCustomColor.BackColor = dlg.Color;
                this.BackColor = dlg.Color;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream("data", FileMode.Create))
                formatter.Serialize(fs, _shapes);
        }

        private void pictureBoxRectangle_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBoxRectangle.ClientRectangle, Color.FromArgb(109, 213, 250), ButtonBorderStyle.Solid);
        }

        private void pictureBoxSquare_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBoxRectangle.ClientRectangle, Color.FromArgb(255, 192, 72), ButtonBorderStyle.Solid);
        }

        private void pictureBoxTriangle_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBoxRectangle.ClientRectangle, Color.FromArgb(0, 228, 153), ButtonBorderStyle.Solid);
        }

        private void pictureBoxCircle_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBoxRectangle.ClientRectangle, Color.FromArgb(224, 35, 13), ButtonBorderStyle.Solid);
        }

        private void pictureBoxEraser_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBoxRectangle.ClientRectangle, Color.FromArgb(30, 129, 206), ButtonBorderStyle.Solid);
        }

        private void pictureBoxLine_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBoxRectangle.ClientRectangle, Color.FromArgb(255, 118, 183), ButtonBorderStyle.Solid);
        }
    }
}

//if (isBrush || isEraser)
//{
//    return;
//}