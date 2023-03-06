using System.Drawing;

namespace ShapeShifter.Shape
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
    public class RectangleShape : BaseShape
    {
        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public RectangleShape() : base()
        {
            // PASS
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="location">Позиция</param>
        public RectangleShape(PointF location) : base(location)
        {
            // PASS
        }

        /// <summary>
        /// Тип
        /// </summary>
        public override ShapeType Type => ShapeType.Rectangle;
    }
}
