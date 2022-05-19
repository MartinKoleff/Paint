using SecretProject3.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretProject3.Exceptions
{
    public delegate bool WherePreidacte(Shape shape);
    static class RectangleExtensions
    {
        public static List<Shape> Where(this List<Shape> shapes, WherePreidacte wherePreidacte)
        {
            List<Shape> resultShapes = new List<Shape>();

            foreach (var s in shapes)
                if (wherePreidacte(s))
                    resultShapes.Add(s);
            return resultShapes;
        }
    }
}
