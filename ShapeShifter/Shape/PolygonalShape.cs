﻿using System;
using System.Drawing;

namespace ShapeShifter.Shape
{
    /// <summary>
    /// Настраиваемая полигональная фигура
    /// </summary>
    public class PolygonalShape : BaseShape
    {
        /// <summary>
        /// Минимальное количество граней
        /// </summary>
        public const int SideCountMin = 3;

        /// <summary>
        /// Максимальное количество граней
        /// </summary>
        public const int SideCountMax = 64;

        /// <summary>
        /// Количество граней
        /// </summary>
        private int _sideCount = SideCountMin;

        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public PolygonalShape() : base()
        {
            // PASS.
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sideCount">Количество граней</param>
        public PolygonalShape(int sideCount) : this()
        {
            SideCount = sideCount;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="location">Позиция</param>
        public PolygonalShape(PointF location, int sideCount) : base(location)
        {
            SideCount = sideCount;
        }

        /// <summary>
        /// Тип
        /// </summary>
        public override ShapeType Type => ShapeType.Polygonal;

        /// <summary>
        /// Доступ к количеству граней
        /// </summary>
        public int SideCount
        {
            get => _sideCount;
            set
            {
                if (value < SideCountMin || value > SideCountMax)
                {
                    throw new ArgumentOutOfRangeException("Invalid SideCount");
                }

                _sideCount = value;
            }
        }

        /// <summary>
        /// Представление в виде массива точек в порядке построения
        /// </summary>
        /// <returns></returns>
        protected override PointF[] ShapePoints
        {
            get
            {
                RectangleF box = new RectangleF(Location, Size);

                // Определение координат центра
                // Промежуточные значения используются при построении
                PointF centerSide = new PointF(box.Width / 2, box.Height / 2);
                PointF center = new PointF(box.Left + centerSide.X, box.Top + centerSide.Y);

                double angle = 0.00;
                double vertex = 2 * Math.PI / SideCount;

                PointF[] result = new PointF[SideCount];

                for (int i = 0; i < SideCount; i++)
                {
                    result[i] = new PointF(
                        (float)(center.X + centerSide.X * Math.Cos(angle)),
                        (float)(center.Y + centerSide.Y * Math.Sin(angle)));

                    angle += vertex;
                }

                return result;
            }
        }
    }
}
