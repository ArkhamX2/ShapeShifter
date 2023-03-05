using System.Drawing;

namespace ShapeShifter.Shape
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class TriangleShape : BaseShape
    {
        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public TriangleShape()
        {
            // PASS
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="location">Позиция</param>
        public TriangleShape(PointF location) : base(location)
        {
            // PASS
        }

        /// <summary>
        /// Тип
        /// </summary>
        public override ShapeType Type => ShapeType.Triangle;

        /// <summary>
        /// Представление в виде массива точек в порядке построения
        /// </summary>
        /// <returns></returns>
        protected override PointF[] ShapePoints
        {
            get
            {
                RectangleF box = new RectangleF(Location, Size);

                PointF[] result = new PointF[]
                {
                    new PointF(box.Left, box.Top),
                    new PointF(box.Right, box.Top + box.Height / 2),
                    new PointF(box.Left, box.Bottom)
                };

                return result;
            }
        }
    }
}
