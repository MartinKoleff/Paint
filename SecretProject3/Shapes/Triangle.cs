using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicEditor.Shapes
{
    [Serializable]
    public class Triangle : Shape
    {
        public bool isCustom = false;
        private bool isMoving = false;
        private PointF[] _points;
        public PointF[] Points
        {
            get 
            {
                return _points; 
            }
            set 
            {
                _points = value;
            }
        }
        public override int Area
        {
            get { return Width * Height / 2; }
        }

        public override void Paint(Graphics graphics)
        {
            if (!isCustom && !isMoving)
            {
                Point bottomLeftPoint = new Point
                {
                    X = this.Location.X,
                    Y = this.Location.Y + Height
                };

                Point bottomRightPoint = new Point
                {
                    X = this.Location.X + Width,
                    Y = this.Location.Y + Height
                };

                Point topPoint = new Point
                {
                    X = this.Location.X + Width / 2,
                    Y = this.Location.Y
                };

                Points = new PointF[] { bottomLeftPoint, bottomRightPoint, topPoint };
            }
            using (var brush = new SolidBrush(ColorFill))
            {
                graphics.FillPolygon(brush, Points.ToArray());
                graphics.DrawPolygon(this.Selected ? Pens.Red :Pens.Black, Points);
            }
        }

        public override void UpdatePosition(Point mouseMovePoint, Point mouseDownPoint)
        {
            this.Location = new Point 
            {
                X = Math.Min(mouseMovePoint.X, mouseDownPoint.X),
                Y = Math.Min(mouseMovePoint.Y, mouseDownPoint.Y)

            };

            this.Width = Math.Abs(mouseDownPoint.X - mouseMovePoint.X);
            this.Height = Math.Abs(mouseDownPoint.Y - mouseMovePoint.Y);
        }

        public override void OpenEditor()
        {
            TriangleEditForm triangleEditForm = new TriangleEditForm();
            triangleEditForm.Triangle = this;
            triangleEditForm.ShowDialog();
        }
        public override bool ContainsPoint(Point point) 
        {

            float alpha = ((Points[1].Y - Points[2].Y) * (point.X - Points[2].X) + (Points[2].X - Points[1].X) * (point.Y - Points[2].Y)) /
                   ((Points[1].Y - Points[2].Y) * (Points[0].X - Points[2].X) + (Points[2].X - Points[1].X) * (Points[0].Y - Points[2].Y));

            float beta = ((Points[2].Y - Points[0].Y) * (point.X - Points[2].X) + (Points[0].X - Points[2].X) * (point.Y - Points[2].Y)) /
                   ((Points[1].Y - Points[2].Y) * (Points[0].X - Points[2].X) + (Points[2].X - Points[1].X) * (Points[0].Y - Points[2].Y));

            float gamma = 1.0f - alpha - beta;

            return alpha > 0.0f && beta > 0.0f && gamma > 0.0f;
        }

        public override void Move(Point mouseMovePoint, Point mouseDownPoint)
        {
            isMoving = true;
            _points[0].X += mouseMovePoint.X - mouseDownPoint.X;
            _points[0].Y += mouseMovePoint.Y - mouseDownPoint.Y;
            _points[1].X += mouseMovePoint.X - mouseDownPoint.X;
            _points[1].Y += mouseMovePoint.Y - mouseDownPoint.Y;
            _points[2].X += mouseMovePoint.X - mouseDownPoint.X;
            _points[2].Y += mouseMovePoint.Y - mouseDownPoint.Y;
        }
    }
}

