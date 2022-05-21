using VectorGraphicEditor.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicEditor.Shapes
{
    [Serializable]
    public abstract class Shape
    {
        public Point Location { get; set; }

        private int _height;
        public int Height
        {
            get => _height;

            set
            {
                if (value < 0)
                    throw new InvalidValueException("Negative values are not allowed!");

                _height = value;
            }
        }
        private int _width;
        public int Width
        {
            get => _width;

            set
            {
                if (value < 0)
                    throw new InvalidValueException("Negative values are not allowed!");

                _width = value;
            }
        }
        public Color Color { get; set; }
        [NonSerialized]
        private bool _selected;

        public bool Selected
        {
            get => _selected;
            set => _selected = value;
        }
        public Color ColorFill;
        public Color ColorBorder;
        public abstract int Area { get; }
        public abstract void Paint(Graphics graphics);
        public abstract void UpdatePosition(Point mouseMovePoint, Point mouseDownPoint);
        public abstract void OpenEditor();
        public abstract bool ContainsPoint(Point point);

        public abstract void Move(Point mouseMovePoint, Point mouseDownPoint);
    }
}
