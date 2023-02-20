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
        #region Fields
        /// <summary>
        /// Точка на экране, где последний раз был курсор
        /// </summary>
        private Point PreviousPoint = MousePosition;

        /// <summary>
        /// Точка на экране, где последний раз произошёл клик мышью
        /// </summary>
        private Point MouseDownLocation;

        /// <summary>
        /// Заливки для холста
        /// </summary>
        private Bitmap _voidBitmap; 
        private Bitmap _whitePlaneBitmap;

        //Выбранные инструменты
        private Shape _selectedShape;
        private Color _selectedColor;
        private Pen _selectedPen;
        private int _selectedPenWidth;

        //Режимы рисования
        private bool _doMouseDraw;
        private bool _doDrawShapes;
        #endregion

        #region Properties
        
        public Bitmap VoidBitmap
        {
            get 
            {
                _voidBitmap = new Bitmap(Canvas.Width, Canvas.Height);
                return _voidBitmap;
            }
        }

        public Bitmap WhitePlaneBitmap
        {
            get 
            {
                _whitePlaneBitmap = new Bitmap(Canvas.Width, Canvas.Height);
                Graphics g = Graphics.FromImage(_whitePlaneBitmap);
                g.Clear(Color.White);
                return _whitePlaneBitmap;
            }
        }

        /// <summary>
        /// Доступ к выбранной кисти
        /// </summary>
        public Pen SelectedPen
        {
            get { return _selectedPen; }
            set { _selectedPen = value; }
        }
        
        /// <summary>
        /// Доступ к толщине выбранной кисти
        /// </summary>
        public int SelectedPenWidth
        {
            get { return _selectedPenWidth; }
            set { _selectedPenWidth = value; }
        }

        /// <summary>
        /// Доступ к выбранному цвету
        /// </summary>
        public Color SelectedColor
        {
            get { return _selectedColor; }
            set { _selectedColor = value; }
        }

        /// <summary>
        /// Доступ к выбранной фигуре
        /// </summary>
        public Shape SelectedShape
        {
            get { return _selectedShape; }
            set {_selectedShape = value; }
        }

        #endregion

        #region Initialization
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Canvas.Image = WhitePlaneBitmap;

            SelectedShape= _shapes[3];
            SelectedColor = Color.Red;
            SelectedPenWidth = int.Parse(comboBoxPenWidth.Text);
            SelectedPen = new Pen(SelectedColor,SelectedPenWidth);
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
        #endregion

        #region Tools
        #region PenSelect
        private void buttonDefaultPen_Click(object sender, EventArgs e)
        {
            SetShape();

            SelectedPen = new Pen(SelectedColor, SelectedPenWidth);

            _doMouseDraw = true;
            _doDrawShapes= false;

            //SelectedPen.SetLineCap(LineCap.RoundAnchor, LineCap.RoundAnchor, DashCap.Round);
        }

        private void comboBoxPenWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPenWidth = int.Parse(comboBoxPenWidth.Text);

            SelectedPen.Width = SelectedPenWidth;

            _doMouseDraw= true;
            _doDrawShapes = false;

            //SelectedPen.SetLineCap(LineCap.RoundAnchor, LineCap.RoundAnchor, DashCap.Round);

        }
        #endregion

        #region ColorSelect

        private void buttonRed_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Red;
            SelectedPen.Color = SelectedColor;
            if (SelectedShape != null)
            {
                SelectedShape.Color = SelectedColor;
                Canvas.Invalidate();
            }
            buttonCurrentColor.BackColor = SelectedColor;
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Orange;
            SelectedPen.Color = SelectedColor;
            if (SelectedShape != null)
            {
                SelectedShape.Color = SelectedColor;
                Canvas.Invalidate();
            }
            buttonCurrentColor.BackColor = SelectedColor;
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Yellow;
            SelectedPen.Color = SelectedColor;
            if (SelectedShape != null)
            {
                SelectedShape.Color = SelectedColor;
                Canvas.Invalidate();
            }
            buttonCurrentColor.BackColor = SelectedColor;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Green;
            SelectedPen.Color = SelectedColor;
            if (SelectedShape != null)
            {
                SelectedShape.Color = SelectedColor;
                Canvas.Invalidate();
            }
            buttonCurrentColor.BackColor = SelectedColor;
        }

        private void buttonLightBlue_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.LightBlue;
            SelectedPen.Color = SelectedColor;
            if (SelectedShape != null)
            {
                SelectedShape.Color = SelectedColor;
                Canvas.Invalidate();
            }
            buttonCurrentColor.BackColor = SelectedColor;
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Blue;
            SelectedPen.Color = SelectedColor;
            if (SelectedShape != null)
            {
                SelectedShape.Color = SelectedColor;
                Canvas.Invalidate();
            }
            buttonCurrentColor.BackColor = SelectedColor;
        }

        private void buttonPurple_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Purple;
            SelectedPen.Color = SelectedColor;
            if (SelectedShape != null)
            {
                SelectedShape.Color = SelectedColor;
                Canvas.Invalidate();
            }
            buttonCurrentColor.BackColor = SelectedColor;
        }

        private void buttonBrown_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Brown;
            SelectedPen.Color = SelectedColor;
            if (SelectedShape != null)
            {
                SelectedShape.Color = SelectedColor;
                Canvas.Invalidate();
            }
            buttonCurrentColor.BackColor = SelectedColor;
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Black;
            SelectedPen.Color = SelectedColor;
            if (SelectedShape != null)
            {
                SelectedShape.Color = SelectedColor;
                Canvas.Invalidate();
            }
            buttonCurrentColor.BackColor = SelectedColor;
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.White;
            SelectedPen.Color = SelectedColor;
            if (SelectedShape != null)
            {
                SelectedShape.Color = SelectedColor;
                Canvas.Invalidate();
            }

            buttonCurrentColor.BackColor = SelectedColor;
        }

        private void buttonSetColor_Click(object sender, EventArgs e)
        {
            try
            {
                int red = int.Parse(textBoxRed.Text);
                int green = int.Parse(textBoxGreen.Text);
                int blue = int.Parse(textBoxBlue.Text);
                SelectedColor = Color.FromArgb(red, green, blue);
                buttonCurrentColor.BackColor = SelectedColor;
            }
            catch 
            {
                MessageBox.Show("Неверно указаны значения цветов RGB","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        #endregion

        #region ShapeSelect

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            SetShape();
            _doDrawShapes = true;
            _doMouseDraw = false;
            SelectedShape = _shapes[4];
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            SetShape();
            _doDrawShapes = true;
            _doMouseDraw = false;
            SelectedShape = _shapes[1];
        }

        private void buttonTrapezoid_Click(object sender, EventArgs e)
        {
            SetShape();
            _doDrawShapes = true;
            _doMouseDraw = false;
            SelectedShape = _shapes[5];
        }

        private void buttonArrow_Click(object sender, EventArgs e)
        {
            SetShape();
            _doDrawShapes = true;
            _doMouseDraw = false;
            SelectedShape = _shapes[0];
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            SetShape();
            _doDrawShapes = true;
            _doMouseDraw = false;
            SelectedShape = _shapes[3];
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            SetShape();
            _doDrawShapes = true;
            _doMouseDraw = false;
            SelectedShape = _shapes[2];
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            SetShape();
            _doDrawShapes = true;
            _doMouseDraw = false;
            SelectedShape = _shapes[6];
        }

        private void buttonSegment_Click(object sender, EventArgs e)
        {
            SetShape();
            _doDrawShapes = true;
            _doMouseDraw = false;
            SelectedShape = _shapes[7];
        }
        #endregion

        #region Other
        private void buttonClearCanvas_Click(object sender, EventArgs e)
        {
            Canvas.Image = WhitePlaneBitmap;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG| " +
                "All files(*.*)|*.*";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Canvas.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть картинку","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSavePicture_Click(object sender, EventArgs e)
        {
            if(SelectedShape!= null)
            {
                SetShape();
            }

            if(Canvas.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Сохранить картинку как...";
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.CheckPathExists= true;
                saveFileDialog.Filter = "Image Files(*.BMP)|*.BMP" +
                    "|Image Files(*.JPG)|*.JPG|" +
                    "Image Files(*.GIF)|*.GIF|" +
                    "Image Files(*.PNG)|*.PNG|" +
                    "All files(*.*)|*.*";
                saveFileDialog.ShowHelp = true;

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Canvas.Image.Save(saveFileDialog.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение","Ошибка",
                            MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion

        #endregion

        #region CanvasEvents

        private void Canvas_Resize(object sender, EventArgs e)
        {
            Canvas.Invalidate();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            //Позиция курсора корректируется для корректного отображения изображения.
            //Вычисляются его координаты относительно окна приложения
            Point cursorPosition = new Point(
                MousePosition.X - this.Location.X - 8, 
                MousePosition.Y - this.Location.Y - 30);

            if (_doDrawShapes && SelectedShape != null)
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
            //Позиция курсора корректируется для корректного отображения изображения.
            //Вычисляются его координаты относительно окна приложения
            Point cursorPosition = new Point(
                MousePosition.X - this.Location.X - 8, 
                MousePosition.Y - this.Location.Y - 30);

            Graphics g = Graphics.FromImage(Canvas.Image);
            g.SmoothingMode = SmoothingMode.HighQuality;

            //Рисование мышью
            if (_doMouseDraw)
            {
                if (e.Button == MouseButtons.Left)
                {
                    g.DrawLine(SelectedPen,PreviousPoint, cursorPosition );
                    Canvas.Invalidate();
                }
            }
            
            //Рисование фигуры
            if (_doDrawShapes && SelectedShape!=null)
            {
                //Изменение размера фигуры (Растягивание)
                if (e.Button == MouseButtons.Left)
                {
                    SelectedShape.Size = new SizeF(
                        e.X - SelectedShape.Location.X, 
                        e.Y - SelectedShape.Location.Y);

                    Canvas.Invalidate();
                }

                //Изменение положения фигуры на экране
                if (e.Button == MouseButtons.Right)
                {
                    SelectedShape.Location = new PointF(
                        e.X - MouseDownLocation.X + SelectedShape.Location.X, 
                        e.Y - MouseDownLocation.Y + SelectedShape.Location.Y);

                    MouseDownLocation = e.Location;

                    Canvas.Invalidate();

                }
            }

            PreviousPoint = cursorPosition;
        }
        

        /// <summary>
        /// Перерисовка холста. Осуществляется при любом обращении к Canvas
        /// </summary>
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            //Перерисовывает текущую фигуру
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
        /// Метод создает отпечаток фигуры на полотне,
        /// то есть сохраняет и применяет изменения на рисунке, 
        /// позволяя работать с ним дальше - 
        /// добавлять новые объекты(фигуры) или рисовать линии мышью.
        /// 
        /// Если фигура не выбрана, ничего не происходит
        /// </summary>
        private void SetShape()
        {
            if (SelectedShape != null)
            {
                DrawSelectedShape();

                SelectedShape = null;
            }
            Canvas.Invalidate();
        }
        private void DrawSelectedShape()
        {
            Graphics g = Graphics.FromImage(Canvas.Image);
            g.SmoothingMode = SmoothingMode.HighQuality;

            using (Pen pen = new Pen(SelectedShape.OutlineColor, SelectedShape.OutlineWidth))
            using (SolidBrush brush = new SolidBrush(SelectedShape.Color))
            {
                g.FillPath(brush, SelectedShape.GraphicsPath);
                g.DrawPath(pen, SelectedShape.GraphicsPath);
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

    }
}
