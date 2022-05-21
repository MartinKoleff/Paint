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
    public partial class TriangleCustomPointsEditForm : Form
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

                Point1XTextBox.Text = _triangle.Points[0].X.ToString();
                Point1YTextBox.Text = _triangle.Points[0].Y.ToString();
                Point2XTextBox.Text = _triangle.Points[1].X.ToString();
                Point2YTextBox.Text = _triangle.Points[1].Y.ToString();
                Point3XTextBox.Text = _triangle.Points[2].X.ToString();
                Point3YTextBox.Text = _triangle.Points[2].Y.ToString();
            }
        }
        public TriangleCustomPointsEditForm()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            Point point1 = new Point
            {
                X = Int32.Parse(Point1XTextBox.Text),
                Y = Int32.Parse(Point1YTextBox.Text)
            };

            Point point2 = new Point
            {
                X = Int32.Parse(Point2XTextBox.Text),
                Y = Int32.Parse(Point2YTextBox.Text)
            };

            Point point3 = new Point
            {
                X = Int32.Parse(Point3XTextBox.Text),
                Y = Int32.Parse(Point3YTextBox.Text)
            };

            //Triangle.Width = //Calculate with 3 random points...
            //Triangle.Height = //Calculate with 3 random points...

            Triangle.Points = new PointF[] { point1, point2, point3 };
            Triangle.isCustom = true;
            this.Close();
        }
    }
}
