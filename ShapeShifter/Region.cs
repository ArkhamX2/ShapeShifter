using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapeShifter
{
    /// <summary>
    /// Прямоугольный регион
    /// </summary>
    public abstract class Region
    {
        /// <summary>
        /// Позиция (верхний левый угол исходного положения)
        /// </summary>
        private PointF _location;

        /// <summary>
        /// Размер
        /// </summary>
        private SizeF _size = SizeF.Empty;

        /// <summary>
        /// Поворот
        /// </summary>
        private float _angle = 0.00f;

        /// <summary>
        /// Пустой конструктор
        /// </summary>
        protected Region()
        {
            Location = new PointF();
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="location">Позиция</param>
        protected Region(PointF location)
        {
            Location = location;
        }

        /// <summary>
        /// Доступ к позиции
        /// </summary>
        public PointF Location
        {
            get => _location;
            set => _location = value;
        }

        /// <summary>
        /// Доступ к размеру
        /// </summary>
        public virtual SizeF Size
        {
            get => _size;
            set => _size = value;
        }

        /// <summary>
        /// Доступ к повороту
        /// </summary>
        public float Angle
        {
            get => _angle;
            set => _angle = value;
        }

        /// <summary>
        /// Представление в виде структуры прямоугольника
        /// </summary>
        public RectangleF Box => new RectangleF(Location, Size);

        /// <summary>
        /// Центр
        /// </summary>
        public PointF Center
        {
            get
            {
                RectangleF box = Box;

                float x = box.X + box.Width / 2;
                float y = box.Y + box.Height / 2;

                return new PointF(x, y);
            }
        }

        /// <summary>
        /// Порядок графического построения параллельных осям координат границ
        /// с учетом поворота (AABB)
        /// </summary>
        public virtual GraphicsPath AxisAlignedBoundingBox
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                PointF[] points = RotatePoints(ShapePoints);

                float left = float.MaxValue;
                float top = float.MaxValue;
                float right = float.MinValue;
                float bottom = float.MinValue;

                // Определение границ
                for (int i = 0; i < points.Length; i++)
                {
                    left = Math.Min(left, points[i].X);
                    top = Math.Min(top, points[i].Y);
                    right = Math.Max(right, points[i].X);
                    bottom = Math.Max(bottom, points[i].Y);
                }

                path.AddPolygon(new PointF[]
                {
                    new PointF(left, top),
                    new PointF(right, top),
                    new PointF(right, bottom),
                    new PointF(left, bottom)
                });

                return path;
            }
        }

        /// <summary>
        /// Порядок графического построения границ с учетом поворота (BB)
        /// </summary>
        public GraphicsPath BoundingBox
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                
                path.AddPolygon(RotatePoints(RegionPoints));

                return path;
            }
        }

        /// <summary>
        /// Порядок графического построения
        /// </summary>
        public virtual GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();

                path.AddPolygon(RotatePoints(ShapePoints));

                return path;
            }
        }

        /// <summary>
        /// Представление прямоугольного региона
        /// в виде массива точек в порядке построения
        /// </summary>
        protected virtual PointF[] RegionPoints
        {
            get
            {
                RectangleF box = Box;
                PointF[] result = new PointF[]
                {
                    new PointF(box.Left, box.Top),
                    new PointF(box.Right, box.Top),
                    new PointF(box.Right, box.Bottom),
                    new PointF(box.Left, box.Bottom)
                };

                return result;
            }
        }

        /// <summary>
        /// Представление в виде массива точек в порядке построения
        /// </summary>
        /// <returns></returns>
        protected virtual PointF[] ShapePoints
        {
            get
            {
                return RegionPoints;
            }
        }

        /// <summary>
        /// Повернуть точку относительно центра региона
        /// </summary>
        /// <param name="point">Исходное положение</param>
        /// <returns>Новая точка со смещенными координатами</returns>
        protected PointF RotatePoint(PointF point)
        {
            PointF center = Center;

            float virtualX = point.X - center.X;
            float virtualY = point.Y - center.Y;

            float resultX = (float)(center.X + Math.Cos(Angle) * virtualX - Math.Sin(Angle) * virtualY);
            float resultY = (float)(center.Y + Math.Sin(Angle) * virtualX + Math.Cos(Angle) * virtualY);

            return new PointF(resultX, resultY);
        }

        /// <summary>
        /// Повернуть точки относительно центра региона
        /// </summary>
        /// <param name="points">Точки в исходном положении</param>
        /// <returns>Новые точки со смещенными координатами</returns>
        protected PointF[] RotatePoints(PointF[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = RotatePoint(points[i]);
            }

            return points;
        }

        /// <summary>
        /// Получить позицию через центр
        /// </summary>
        /// <param name="center">Центр</param>
        /// <returns>Позиция</returns>
        public PointF LocationFromCenter(PointF center)
        {
            RectangleF box = Box;

            float x = box.X - box.Width / 2;
            float y = box.Y - box.Height / 2;

            return new PointF(x, y);
        }
    }
}
