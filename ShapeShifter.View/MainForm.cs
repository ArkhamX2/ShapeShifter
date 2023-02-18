using System;
using System.Collections.Generic;
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
        private Point PreviousPoint = MousePosition;
        private Point MouseDownLocation;

        private Shape _selectedFigure;
        private Color _selectedColor;
        private Pen _selectedPen;
        private int _selectedPenWidth;


        private bool _doMouseDraw;
        private bool _doDrawFigures;

        private Bitmap _currentBitmap;
        private List<Shape> _drawnShapes;

        public Pen SelectedPen
        {
            get { return _selectedPen; }
            set { _selectedPen = value; }
        }
        
        public int SelectedPenWidth
        {
            get { return _selectedPenWidth; }
            set { _selectedPenWidth = value; }
        }

        public Color SelectedColor
        {
            get { return _selectedColor; }
            set { _selectedColor = value; }
        }

        public Shape SelectedFigure
        {
            get { return _selectedFigure; }
            set {_selectedFigure = value; }
        }


        public List<Shape> Drawn
        {
            get { return _drawnShapes; }
            set { _drawnShapes = value; }
        }

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Canvas.Image = new Bitmap(Canvas.Width, Canvas.Height);
            SelectedFigure= _shapes[3];
            SelectedColor = Color.Red;
            SelectedPenWidth = int.Parse(comboBoxPenWidth.Text);
            SelectedPen = new Pen(SelectedColor,SelectedPenWidth);
            Drawn = new List<Shape>();  
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

        #region PenSelect
        private void buttonDefaultPen_Click(object sender, EventArgs e)
        {
            SelectedPen = new Pen(SelectedColor, SelectedPenWidth);

            //SelectedPen.SetLineCap(LineCap.RoundAnchor, LineCap.RoundAnchor, DashCap.Round);
        }

        private void comboBoxPenWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPenWidth = int.Parse(comboBoxPenWidth.Text);

            SelectedPen.Width = SelectedPenWidth;

            //SelectedPen.SetLineCap(LineCap.RoundAnchor, LineCap.RoundAnchor, DashCap.Round);
            
        }
        #endregion

        #region ColorSelect

        private void buttonRed_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Red;
            SelectedPen.Color = SelectedColor;
            SelectedFigure.Color = SelectedColor;
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Orange;
            SelectedPen.Color = SelectedColor;
            SelectedFigure.Color = SelectedColor;
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Yellow;
            SelectedPen.Color = SelectedColor;
            SelectedFigure.Color = SelectedColor;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Green;
            SelectedPen.Color = SelectedColor;
            SelectedFigure.Color = SelectedColor;
        }

        private void buttonLightBlue_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.LightBlue;
            SelectedPen.Color = SelectedColor;
            SelectedFigure.Color = SelectedColor;
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Blue;
            SelectedPen.Color = SelectedColor;
            SelectedFigure.Color = SelectedColor;
        }

        private void buttonPurple_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Purple;
            SelectedPen.Color = SelectedColor;
            SelectedFigure.Color = SelectedColor;
        }

        private void buttonBrown_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Brown;
            SelectedPen.Color = SelectedColor;
            SelectedFigure.Color = SelectedColor;
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Black;
            SelectedPen.Color = SelectedColor;
            SelectedFigure.Color = SelectedColor;
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.White;
            SelectedPen.Color = SelectedColor;
            SelectedFigure.Color = SelectedColor;
        }
        #endregion

        private void toolStripButtonSaveFigureToList_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(Canvas.Image);
            g.SmoothingMode= SmoothingMode.HighQuality;
            if (SelectedFigure != null)
            {
                using (Pen pen = new Pen(SelectedFigure.OutlineColor, SelectedFigure.OutlineWidth))
                using (SolidBrush brush = new SolidBrush(SelectedFigure.Color))
                {
                
                    g.FillPath(brush, SelectedFigure.GraphicsPath);
                    g.DrawPath(pen, SelectedFigure.GraphicsPath);
                }
            }
            
                

            Canvas.Invalidate();
        }
        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            Canvas.Image = new Bitmap(Canvas.Width, Canvas.Height);
        }
        private void toolStripSave_Click(object sender, EventArgs e)
        {
            Canvas.Image.Save(@"D:\Prog\ShapeShifter\ShapeShifter.View\Images\MyPainting.png", ImageFormat.Png);
        }

        #region Canvas
        private void Canvas_Resize(object sender, EventArgs e)
        {
            Canvas.Invalidate();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            Point cursorPosition = new Point(MousePosition.X - this.Location.X - 8, MousePosition.Y - this.Location.Y - 30);

            if (_doDrawFigures)
            {
                if (e.Button == MouseButtons.Left )
                {

                    SelectedFigure.Location = cursorPosition;
                    SelectedFigure.Size = new SizeF(200, 300);
                    SelectedFigure.Color = SelectedColor;
                    SelectedFigure.OutlineColor = Color.Black;  

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
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(SelectedPen,PreviousPoint, cursorPosition );
                Canvas.Invalidate();
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

        #endregion

        #region DrawMethods
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
        #endregion

        #region Random
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
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
