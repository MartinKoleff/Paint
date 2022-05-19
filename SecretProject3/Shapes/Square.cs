using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretProject3.Shapes
{
    public class Square : Shape
    {
        public override int Area
        {
            get
            {
                return Width * Width;
            }
        }

        public override void Paint(Graphics graphics)
        {
            var colorBorder = Selected ? Color.Red : Color.Black;
            var colorFill = Color.Blue;

            using (var brush = new SolidBrush(colorFill)) //Color.Transparent
                graphics.FillRectangle(brush, Location.X, Location.Y, Width, Height);
            using (var pen = new Pen(colorBorder))
                graphics.DrawRectangle(pen, Location.X, Location.Y, Width, Height);
        }

        public override void UpdatePosition(Point mouseMovePoint, Point mouseDownPoint)
        {
            this.Location = new Point //Bottom Left Point
            {
                X = Math.Min(mouseMovePoint.X, mouseDownPoint.X),
                //Y = Math.Min(mouseMovePoint.Y, mouseDownPoint.Y)
                Y = mouseDownPoint.Y
            };

            this.Width = Math.Abs(mouseDownPoint.X - mouseMovePoint.X);
            this.Height = this.Width;

            //this.Height = Math.Abs(mouseDownPoint.Y - mouseMovePoint.Y);
            //this.Width = this.Height;

            //Debug.WriteLine("Mouse move -> " + mouseMovePoint.X + ", " + mouseMovePoint.Y);
            //Debug.WriteLine("Mouse down -> " + mouseDownPoint.X + ", " + mouseDownPoint.Y);
            //Debug.WriteLine("Coordinates -> " + this.Location.X + ", " + this.Location.Y);
            //Debug.WriteLine(Width + ", " + Height);
        }
        public override void OpenEditor()
        {
            throw new NotImplementedException();
        }
        public override bool ContainsPoint(Point point)
        {
            Debug.WriteLine(Location.X <= point.X && point.X <= Location.X + Width &&
            Location.Y >= point.Y && point.Y <= Location.Y + Height);

            return Location.X <= point.X && point.X <= Location.X + Width &&
            Location.Y <= point.Y && point.Y <= Location.Y + Height; // Location.Y >= point.Y
        }

        public override void Move(Point mouseMovePoint, Point mouseDownPoint)
        {
            throw new NotImplementedException();
        }
    }
}
