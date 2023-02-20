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

        private Shape _selectedShape;
        private Color _selectedColor;
        private Pen _selectedPen;
        private int _selectedPenWidth;


        private bool _doMouseDraw;
        private bool _doDrawShapes;

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

        public Shape SelectedShape
        {
            get { return _selectedShape; }
            set {_selectedShape = value; }
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
            SelectedShape= _shapes[3];
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
            SelectedShape.Color = SelectedColor;
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Orange;
            SelectedPen.Color = SelectedColor;
            SelectedShape.Color = SelectedColor;
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Yellow;
            SelectedPen.Color = SelectedColor;
            SelectedShape.Color = SelectedColor;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Green;
            SelectedPen.Color = SelectedColor;
            SelectedShape.Color = SelectedColor;
        }

        private void buttonLightBlue_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.LightBlue;
            SelectedPen.Color = SelectedColor;
            SelectedShape.Color = SelectedColor;
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Blue;
            SelectedPen.Color = SelectedColor;
            SelectedShape.Color = SelectedColor;
        }

        private void buttonPurple_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Purple;
            SelectedPen.Color = SelectedColor;
            SelectedShape.Color = SelectedColor;
        }

        private void buttonBrown_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Brown;
            SelectedPen.Color = SelectedColor;
            SelectedShape.Color = SelectedColor;
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Black;
            SelectedPen.Color = SelectedColor;
            SelectedShape.Color = SelectedColor;
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.White;
            SelectedPen.Color = SelectedColor;
            SelectedShape.Color = SelectedColor;
        }
        #endregion

        #region ShapeSelect

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            SelectedShape = _shapes[4];
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            SelectedShape = _shapes[1];
        }

        private void buttonTrapezoid_Click(object sender, EventArgs e)
        {
            SelectedShape = _shapes[5];
        }

        private void buttonArrow_Click(object sender, EventArgs e)
        {
            SelectedShape = _shapes[0];
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            SelectedShape = _shapes[3];
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            SelectedShape = _shapes[2];
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            SelectedShape = _shapes[6];
        }

        private void buttonSegment_Click(object sender, EventArgs e)
        {
            SelectedShape = _shapes[7];
        }
        #endregion

        private void toolStripButtonSaveFigureToList_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(Canvas.Image);
            g.SmoothingMode= SmoothingMode.HighQuality;
            if (SelectedShape != null)
            {
                using (Pen pen = new Pen(SelectedShape.OutlineColor, SelectedShape.OutlineWidth))
                using (SolidBrush brush = new SolidBrush(SelectedShape.Color))
                {
                
                    g.FillPath(brush, SelectedShape.GraphicsPath);
                    g.DrawPath(pen, SelectedShape.GraphicsPath);
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

            if (_doDrawShapes)
            {
                if (e.Button == MouseButtons.Left )
                {

                    SelectedShape.Location = cursorPosition;
                    SelectedShape.Size = new SizeF(200, 300);
                    SelectedShape.Color = SelectedColor;
                    SelectedShape.OutlineColor = Color.Black;  

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
            if (_doDrawShapes)
            {
                if (e.Button == MouseButtons.Left)
                {
                    SelectedShape.Size = new SizeF(e.X - SelectedShape.Location.X, e.Y - SelectedShape.Location.Y);

                    Canvas.Invalidate();
                }

                if (e.Button == MouseButtons.Right)
                {
                    SelectedShape.Location = new PointF((e.X - MouseDownLocation.X) + SelectedShape.Location.X, (e.Y - MouseDownLocation.Y) + SelectedShape.Location.Y);
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
            if (_doDrawShapes && SelectedShape != null)
            {
                using (Pen pen = new Pen(SelectedShape.OutlineColor, SelectedShape.OutlineWidth))
                using (SolidBrush brush = new SolidBrush(SelectedShape.Color))
                {
                    e.Graphics.FillPath(brush, SelectedShape.GraphicsPath);
                    e.Graphics.DrawPath(pen, SelectedShape.GraphicsPath);
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
