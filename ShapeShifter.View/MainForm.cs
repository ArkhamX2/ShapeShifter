using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ShapeShifter.View
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        bool drawable = false;
        private Point PreviousPoint = MousePosition;
        private Point MouseDownLocation;
        private bool _doMouseDraw;
        private Shape _selectedFigure;
        private bool _doDrawFigures;
        private Bitmap _currentBitmap;

        public Shape SelectedFigure
        {
            get { return _selectedFigure; }
            set {_selectedFigure = value; }
        }

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Canvas.Image = new Bitmap(Canvas.Width, Canvas.Height);
            SelectedFigure= _shapes[3];
            _currentBitmap = new Bitmap(Canvas.Width, Canvas.Height);
        }

        /// <summary>
        /// Генератор случайных чисел
        /// </summary>
        private static readonly Random _random = new Random();

        /// <summary>
        /// Массив всех доступных фигур
        /// </summary>
        private readonly Shape[] _shapes = new Shape[]
        {
            new ArrowShape(),
            new CircleShape(), // TODO: Зачем круг если есть настраиваемый эллипс?
            new EllipseShape(),
            new RectangleShape(),
            new SquareShape(), // TODO: Зачем квадрат если есть настраиваемый прямоугольник?
            new TrapezoidShape(),
            new TriangleShape(), // TODO: Более "правильный" треугольник  по сравнению с полигональным вариантом.
            new PolygonalShape(3),
            new PolygonalShape(4),
            new PolygonalShape(5),
            new PolygonalShape(6),
            new PolygonalShape(7),
            new PolygonalShape(8)
        };
        
        #region toolStrip
        private void toolStripMouseDraw_Click(object sender, EventArgs e)
        {
            _doMouseDraw = !_doMouseDraw;
            _doDrawFigures = false;
            _selectedFigure = null;
        }

        private void toolStripFigures_Click(object sender, EventArgs e)
        {
            _doMouseDraw = false;
            _doDrawFigures = !_doDrawFigures;
        }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedFigure = _shapes[3];
        }
        #endregion

        #region Canvas
        private void Canvas_Resize(object sender, EventArgs e)
        {
            Canvas.Invalidate();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            Point cursorPosition = new Point(MousePosition.X - this.Location.X - 8, MousePosition.Y - this.Location.Y - 30);

            //Graphics g = Graphics.FromImage(Canvas.Image);
            //g.SmoothingMode = SmoothingMode.HighQuality;

            if (_doDrawFigures)
            {
                if (e.Button == MouseButtons.Left )
                {
                    SelectedFigure = RandomShape(cursorPosition, new SizeF(200, 300));

                }
                if (e.Button == MouseButtons.Right)
                {
                    MouseDownLocation = e.Location;
                }
            }
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point cursorPosition = new Point(MousePosition.X - this.Location.X - 8, MousePosition.Y - this.Location.Y - 30);

            Graphics g = Graphics.FromImage(Canvas.Image);
            g.SmoothingMode = SmoothingMode.HighQuality;


            //Рисование мышью
            if (_doMouseDraw)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Pen blackPen = new Pen(Color.Black, 1);

                    g.DrawLine(blackPen, PreviousPoint, cursorPosition);
                    blackPen.Dispose();
                    
                    Canvas.Invalidate();
                }
            }
            
            //Рисование фигуры
            if (_doDrawFigures)
            {
                if (e.Button == MouseButtons.Left)
                {
                    SelectedFigure.Size = new SizeF(e.X - SelectedFigure.Location.X, e.Y - SelectedFigure.Location.Y);

                    Canvas.Invalidate();
                }

                if (e.Button == MouseButtons.Right)
                {
                    SelectedFigure.Location = new PointF((e.X - MouseDownLocation.X) + SelectedFigure.Location.X, (e.Y - MouseDownLocation.Y) + SelectedFigure.Location.Y);
                    MouseDownLocation = e.Location;
                    Canvas.Invalidate();

                }
            }

            PreviousPoint = cursorPosition;

        }
        
        /// <summary>
         /// Перерисовка холста
         /// </summary>
         /// <param name="sender">Отправитель</param>
         /// <param name="e">Событие перерисовки</param>
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (_doDrawFigures && SelectedFigure != null)
            {
                using (Pen pen = new Pen(SelectedFigure.OutlineColor, SelectedFigure.OutlineWidth))
                using (SolidBrush brush = new SolidBrush(SelectedFigure.Color))
                {
                    e.Graphics.FillPath(brush, SelectedFigure.GraphicsPath);
                    e.Graphics.DrawPath(pen, SelectedFigure.GraphicsPath);
                }
            }

        }
        private void toolStripButtonSaveFigure_Click(object sender, EventArgs e)
        {
            ////"D:\\Prog\\ShapeShifter\\ShapeShifter.View\\Images\\test.jpg"

            //Canvas.Image.Save(@"D:\Prog\ShapeShifter\ShapeShifter.View\Images\123.jpeg", ImageFormat.Png);

            //pictureBox1.Image = new Bitmap(@"D:\Prog\ShapeShifter\ShapeShifter.View\Images\test.png");
        }

        #endregion


        /// <summary>
        /// Нарисовать фигуру
        /// </summary>
        /// <param name="graphics">Графика</param>
        /// <param name="shape">Фигура</param>
        private void DrawShape(Graphics graphics, Shape shape)
        {
            GraphicsPath path = shape.GraphicsPath;

            using (Pen pen = new Pen(shape.OutlineColor, shape.OutlineWidth))
            using (SolidBrush brush = new SolidBrush(shape.Color))
            {
                graphics.FillPath(brush, path);
                graphics.DrawPath(pen, path);
            }
        }

        /// <summary>
        /// Нарисовать границу вокруг фигуры пунктиром
        /// </summary>
        /// <param name="graphics">Графика</param>
        /// <param name="shape">Фигура</param>
        private void DrawBoundingBox(Graphics graphics, Shape shape)
        {
            using (Pen pen = new Pen(Color.Gray, Shape.DefaultOutlineWidth))
            {
                pen.DashStyle = DashStyle.Dash;
                
                graphics.DrawRectangles(pen, new RectangleF[] { shape.BoundingBox });
            }
        }

        /// <summary>
        /// Получить случайный цвет
        /// </summary>
        /// <returns>Случайный цвет</returns>
        private Color RandomColor()
        {
            return Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
        }

        /// <summary>
        /// Получить случайную фигуру
        /// </summary>
        /// <param name="location">Позиция</param>
        /// <param name="size">Размер</param>
        /// <returns>Случайная фигура</returns>
        private Shape RandomShape(PointF location, SizeF size)
        {
            Shape shape = _shapes[_random.Next(_shapes.Length)];

            shape.Location = location;
            shape.Size = size;
            shape.Color = RandomColor();
            shape.OutlineColor = Color.Black;

            return shape;
        }

       
    }
}
