using VectorGraphicEditor.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorGraphicEditor
{
    public partial class TriangleEditForm : Form
    {
        private Triangle _triangle;
        public Triangle Triangle
        {
            get
            {
                return _triangle;
            }

            set
            {
                _triangle = value;
                textBoxWidth.Text = _triangle.Width.ToString();
                textBoxHeight.Text = _triangle.Height.ToString();
                buttonColor.BackColor = _triangle.Color;
            }
        }
        public TriangleEditForm()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle.Width = int.Parse(textBoxWidth.Text);
                Triangle.Height = int.Parse(textBoxHeight.Text);
                Triangle.ColorFill = buttonColor.BackColor; //TO TEST...
            }
            catch
            {
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                buttonColor.BackColor = cd.Color;
        }

        private void customPointsButton_Click(object sender, EventArgs e)
        {
            this.Close();

            TriangleCustomPointsEditForm triangleCustomPointsEditForm = new TriangleCustomPointsEditForm();
            triangleCustomPointsEditForm.Triangle = _triangle;
            triangleCustomPointsEditForm.ShowDialog();
        }
    }
}
////To refactor on new Form...
//Point point1 = new Point
//{
//    X = Int32.Parse(Point1XTextBox.Text),
//    Y = Int32.Parse(Point1YTextBox.Text)
//};

//Point point2 = new Point
//{
//    X = Int32.Parse(Point2XTextBox.Text),
//    Y = Int32.Parse(Point2YTextBox.Text)
//};

//Point point3 = new Point
//{
//    X = Int32.Parse(Point3XTextBox.Text),
//    Y = Int32.Parse(Point3YTextBox.Text)
//};

//Triangle.Width = //Calculate with 3 random points...
//Triangle.Height = //Calculate with 3 random points...

//Triangle.Points = new PointF[] { point1, point2, point3 };
