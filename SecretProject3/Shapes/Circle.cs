using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicEditor.Shapes
{
    [Serializable]
    public class Circle : Shape
    {
        public float Radius { get; set; }
        private Point _centerPoint;
        public override void Paint(Graphics graphics)
        {
            this.ColorBorder = Selected ? Color.Red : Color.Black;
            this.ColorFill = Color.Blue;

            using (var brush = new SolidBrush(this.ColorFill))
                graphics.FillEllipse(brush, _centerPoint.X, _centerPoint.Y, 2 * Radius, 2 * Radius);
            using (var pen = new Pen(this.ColorBorder))
                graphics.DrawEllipse(pen, _centerPoint.X, _centerPoint.Y, 2 * Radius, 2 * Radius);
            //graphics.DrawEllipse(pen, Location.X - Radius, Location.Y - Radius, 2 * Radius, 2 * Radius);

        }
        public override int Area
        {
            get
            {
                return (int)(Math.PI * Math.Pow(Radius, 2));
            }
        }
        public override void UpdatePosition(Point mouseMovePoint, Point mouseDownPoint)
        {
            float a = Math.Abs(mouseMovePoint.X - mouseDownPoint.X);
            float b = Math.Abs(mouseMovePoint.Y - mouseDownPoint.Y);

            Radius = (float) Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) / 2;

            //_centerPoint = mouseDownPoint;
            _centerPoint = new Point
            {
                X = (int)(Location.X - Radius),
                Y = (int)(Location.Y - Radius)
            };

            //Debug.WriteLine("Mouse move -> " + mouseMovePoint.X + ", " + mouseMovePoint.Y);
            //Debug.WriteLine("Mouse down -> " + mouseDownPoint.X + ", " + mouseDownPoint.Y);
            //Debug.WriteLine("Coordinates -> " + this.Location.X + ", " + this.Location.Y);
            //Debug.WriteLine(Radius);
            //Debug.WriteLine("Center Point -> "+ _centerPoint.X + ", " + _centerPoint.Y);
        }

        public override void OpenEditor()
        {
            CircleEditForm circleEditForm = new CircleEditForm();
            circleEditForm.Circle = this;
            circleEditForm.ShowDialog();
        }

        public override bool ContainsPoint(Point point) 
        {
            return Math.Pow((point.X - this.Location.X), 2) + Math.Pow((point.Y - this.Location.Y), 2)  <= Math.Pow(this.Radius, 2);
        }

        public override void Move(Point mouseMovePoint, Point mouseDownPoint) //TO FIX
        {
            _centerPoint.X += mouseMovePoint.X - mouseDownPoint.X;
            _centerPoint.Y += mouseMovePoint.Y - mouseDownPoint.Y;
        }
    }
}
//_centerPoint = new Point
//{
//    X = (int)(mouseDownPoint.X - Radius),
//    Y = (int)(mouseDownPoint.Y - Radius)
//};

//return Location.X <= point.X && point.X <= Location.X + Radius &&  //TO FIX... (Works like square...)
//Location.Y <= point.Y && point.Y <= Location.Y + Radius;

//return (point.X - this.Location.X) ^ 2 + (point.Y - this.Location.Y) ^ 2 <= this.Radius ^ 2;


//-----------------------------------------------------------------
//float a = Math.Abs(mouseMovePoint.X - mouseDownPoint.X);
//float b = Math.Abs(mouseMovePoint.Y - mouseDownPoint.Y);

//float newRadius = (float)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) / 2;

////_centerPoint.X = (int)(Location.X - newRadius);
////_centerPoint.Y = (int)(Location.Y - newRadius);
//if (mouseMovePoint.X > mouseDownPoint.X)
//{
//    _centerPoint.X += (int) Math.Round(newRadius);
//}
//else
//{
//    _centerPoint.X -= (int)Math.Round(newRadius);
//}
//if (mouseMovePoint.Y > mouseDownPoint.Y)
//{
//    _centerPoint.Y += (int)Math.Round(newRadius);
//}
//else
//{
//    _centerPoint.Y -= (int)Math.Round(newRadius);
//}
