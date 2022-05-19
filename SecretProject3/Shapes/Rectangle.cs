using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretProject3.Shapes
{
    [Serializable]
    public class Rectangle : Shape
    {
        public override int Area
        {
            get
            {
                return Height * Width;
            }
        }
        public override void Paint(Graphics graphics)
        {
            var colorBorder = Selected ? Color.Red : Color.Black;
            //var colorFill = Color.Blue;

            using (var brush = new SolidBrush(ColorFill))
                graphics.FillRectangle(brush, Location.X, Location.Y, Width, Height);
            using (var pen = new Pen(colorBorder))
                graphics.DrawRectangle(pen, Location.X, Location.Y, Width, Height);

            //Bottom left point -> this.Location.X, this.Location.Y
            //Bottom right point -> this.Location.X + Width, this.Location.Y
            //Center Top Point -> this.Location.X + Width/2, this.Location.Y + Height

        }

        public override void UpdatePosition(Point mouseMovePoint, Point mouseDownPoint)
        {
            this.Location = new Point //Bottom Left Point
            {
                X = Math.Min(mouseMovePoint.X, mouseDownPoint.X),
                Y = Math.Min(mouseMovePoint.Y, mouseDownPoint.Y) 
            };


            //new function updateSize()!!!!! (for each shape)
            this.Width = Math.Abs(mouseDownPoint.X - mouseMovePoint.X);
            this.Height = Math.Abs(mouseDownPoint.Y - mouseMovePoint.Y);
        }

        public override void OpenEditor()
        {
            RectangleEditForm rectangleEditForm = new RectangleEditForm();
            rectangleEditForm.Rectangle = this;
            rectangleEditForm.ShowDialog();
        }

        public override bool ContainsPoint(Point point)
        {
            return Location.X <= point.X && point.X <= Location.X + Width &&
                Location.Y <= point.Y && point.Y <= Location.Y + Height; //Location.Y >= point.Y
        }

        public virtual bool ContainsInside(Shape innerShape)
        {
            if (innerShape is Circle)
            {
                Shapes.Square squareAroundCircle = new Square();
                squareAroundCircle.Location = new Point
                {
                    X = (int)(innerShape.Location.X - ((Circle)innerShape).Radius),
                    Y = (int)(innerShape.Location.Y - ((Circle)innerShape).Radius)
                };
                squareAroundCircle.Width = (int)(2 * ((Circle)innerShape).Radius);
                squareAroundCircle.Height = squareAroundCircle.Width;

                innerShape = squareAroundCircle;
            }
            else if (innerShape is Triangle) 
            {
                Shapes.Rectangle rectangleAroundtTriangle = new Shapes.Rectangle();
                rectangleAroundtTriangle.Location = new Point
                {
                    X = (int)((Triangle)innerShape).Points[0].X,
                    Y = (int)(((Triangle)innerShape).Points[0].Y - Math.Abs(((Triangle)innerShape).Points[2].Y - ((Triangle)innerShape).Points[0].Y)) //Height
                };
                rectangleAroundtTriangle.Width = (int)Math.Abs(((Triangle)innerShape).Points[0].X - ((Triangle)innerShape).Points[1].X);
                rectangleAroundtTriangle.Height = (int)Math.Abs(((Triangle)innerShape).Points[2].Y - ((Triangle)innerShape).Points[1].Y);

                innerShape = rectangleAroundtTriangle;
            }
            if (innerShape is Rectangle || innerShape is Square) {
                Point bottomRightPoint = new Point()
                {
                    X = this.Location.X + this.Width,
                    Y = this.Location.Y + this.Height
                };

                Point innerRectangleBottomRightPoint = new Point()
                {
                    X = innerShape.Location.X + innerShape.Width,
                    Y = innerShape.Location.Y + innerShape.Height
                };


                if (this.Height >= innerShape.Height && this.Width >= innerShape.Width
                    && this.Location.X <= innerShape.Location.X
                    && this.Location.Y <= innerShape.Location.Y
                    && bottomRightPoint.X >= innerRectangleBottomRightPoint.X
                    && bottomRightPoint.Y >= innerRectangleBottomRightPoint.Y)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public override void Move(Point mouseMovePoint, Point mouseDownPoint)
        {
           
            int differenceX = mouseMovePoint.X - mouseDownPoint.X;
            int differenceY = mouseMovePoint.Y - mouseDownPoint.Y;

            //int tempX = this.Location.X;
            //int tempY = this.Location.Y;

            Point newPoint = new Point
            {
                X = this.Location.X + differenceX,
                Y = this.Location.Y + differenceY
            };

            this.Location = newPoint;
        }
    }
}
