using System;
using System.Collections.Generic;
using System.Drawing;

namespace ShapeShifter
{
    /// <summary>
    /// Класс для получения новых фигур
    /// </summary>
    public static class ShapeSelector
    {
        /// <summary>
        /// Доступ к списку фигур
        /// </summary>
        public static List<Shape> ShapeList => new List<Shape>()
        {
            new ArrowShape(),
            new RectangleShape(),
            new SquareShape(), // TODO: Зачем квадрат если есть настраиваемый прямоугольник?
            new TrapezoidShape(),
            new TriangleShape(), // TODO: Заменить полигоном или сделать настраиваемым?
            new PolygonalShape()
        };

        /// <summary>
        /// Получить новую фигуру
        /// </summary>
        /// <param name="type">Тип фигуры</param>
        /// <returns>Фигура</returns>
        /// <exception cref="ArgumentException"></exception>
        public static Shape GetShape(ShapeType type)
        {
            foreach (Shape shape in ShapeList)
            {
                if (shape.Type != type)
                {
                    continue;
                }

                return shape;
            }

            throw new ArgumentException("Невозможно создать фигуру указанного типа.");
        }

        /// <summary>
        /// Получить новую фигуру
        /// </summary>
        /// <param name="type">Тип фигуры</param>
        /// <param name="location">Позиция</param>
        /// <returns>Фигура</returns>
        public static Shape GetShape(ShapeType type, PointF location)
        {
            Shape shape = GetShape(type);

            shape.Location = location;

            return shape;
        }

        /// <summary>
        /// Получить новую фигуру
        /// </summary>
        /// <param name="type">Тип фигуры</param>
        /// <param name="location">Позиция</param>
        /// <param name="size">Размер</param>
        /// <returns>Фигура</returns>
        public static Shape GetShape(ShapeType type, PointF location, SizeF size)
        {
            Shape shape = GetShape(type, location);

            shape.Size = size;

            return shape;
        }

        /// <summary>
        /// Получить новую настраиваемую полигональную фигуру
        /// </summary>
        /// <returns>Настраиваемая полигональная фигура</returns>
        public static PolygonalShape GetPolygonalShape()
        {
            return GetShape(ShapeType.Polygonal) as PolygonalShape;
        }

        /// <summary>
        /// Получить новую настраиваемую полигональную фигуру
        /// </summary>
        /// <param name="sideCount">Количество граней</param>
        /// <returns>Настраиваемая полигональная фигура</returns>
        public static PolygonalShape GetPolygonalShape(int sideCount)
        {
            PolygonalShape shape = GetPolygonalShape();

            shape.SideCount = sideCount;

            return shape;
        }

        /// <summary>
        /// Получить новую настраиваемую полигональную фигуру
        /// </summary>
        /// <param name="sideCount">Количество граней</param>
        /// <param name="location">Позиция</param>
        /// <returns>Настраиваемая полигональная фигура</returns>
        public static PolygonalShape GetPolygonalShape(int sideCount, PointF location)
        {
            PolygonalShape shape = GetPolygonalShape(sideCount);

            shape.Location = location;

            return shape;
        }

        /// <summary>
        /// Получить новую настраиваемую полигональную фигуру
        /// </summary>
        /// <param name="sideCount">Количество граней</param>
        /// <param name="location">Позиция</param>
        /// <param name="size">Размер</param>
        /// <returns>Настраиваемая полигональная фигура</returns>
        public static PolygonalShape GetPolygonalShape(int sideCount, PointF location, SizeF size)
        {
            PolygonalShape shape = GetPolygonalShape(sideCount, location);

            shape.Size = size;

            return shape;
        }
    }
}
