﻿using System.Drawing;

namespace ShapeShifter.Shape
{
    /// <summary>
    /// Стрелка
    /// </summary>
    public class ArrowShape : BaseShape
    {
        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public ArrowShape() : base()
        {
            // PASS
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="location">Позиция</param>
        public ArrowShape(PointF location) : base(location)
        {
            // PASS
        }

        /// <summary>
        /// Тип
        /// </summary>
        public override ShapeType Type => ShapeType.Arrow;

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
                    new PointF(box.Left + box.Width / 2, box.Top),
                    new PointF(box.Right, box.Top + box.Height / 2),
                    new PointF(box.Left + box.Width / 2, box.Bottom),
                    new PointF(box.Left + box.Width / 2, box.Bottom - box.Height / 3),
                    new PointF(box.Left, box.Bottom - box.Height / 3),
                    new PointF(box.Left, box.Top + box.Height / 3),
                    new PointF(box.Left + box.Width / 2, box.Top + box.Height / 3)
                };

                return result;
            }
        }
    }
}
