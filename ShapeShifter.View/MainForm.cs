using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapeShifter.Shape;

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
        private BaseShape _selectedShape;
        private Color _selectedColor;
        private Pen _selectedPen;
        private int _selectedPenWidth;
        private SizeF _selectedShapeCurrentSize;

        //Режимы рисования
        private bool _doMouseDraw;
        private bool _doDrawShapes;
        private bool _doRotateShapes;
        private bool _doResizeShapes;
        private bool _doResizeShapesEqually;

        #endregion

        #region Properties
        
        /// <summary>
        /// Пустой холст
        /// </summary>
        public Bitmap VoidBitmap
        {
            get
            {
                _voidBitmap = new Bitmap(Canvas.Width, Canvas.Height);
                return _voidBitmap;
            }
        }

        /// <summary>
        /// Белый холст
        /// </summary>
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
        public BaseShape SelectedShape
        {
            get { return _selectedShape; }
            set { _selectedShape = value; }
        }

        /// <summary>
        /// Доступ к размеру выбранной фигуры
        /// </summary>
        public SizeF SelectedShapeSize
        {
            get { return _selectedShapeCurrentSize; }
            set { _selectedShapeCurrentSize = value; }
        }

        #endregion

        #region Initialization
        public MainForm()
        {
            InitializeComponent();
            SetDefaultPaintProps();
        }

        /// <summary>
        /// Установка значений по умолчанию:
        /// Белый холст
        /// Фигура - квадрат
        /// Цвет - красный
        /// Толщина кисти - 5
        /// </summary>
        private void SetDefaultPaintProps()
        {
            Canvas.Image = WhitePlaneBitmap;

            SelectedShape = ShapeSelector.GetShape(ShapeType.Rectangle);
            SelectedShapeSize = new SizeF(200,300);

            SelectedColor = Color.Red;

            SelectedPenWidth = int.Parse(comboBoxPenWidth.Text);
            SelectedPen = new Pen(SelectedColor, SelectedPenWidth);
            SelectedPen.SetLineCap(LineCap.Custom, LineCap.Custom, DashCap.Flat);
        }

        #endregion

        #region Tools
        #region PenSelect
        private void buttonDefaultPen_Click(object sender, EventArgs e)
        {
            SetShape();

            SelectedPen = new Pen(SelectedColor, SelectedPenWidth);
            SelectedPen.SetLineCap(LineCap.Custom, LineCap.Custom, DashCap.Round);

            SwitchToMousePaintMode();
        }

        private void comboBoxPenWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPen.Width = int.Parse(comboBoxPenWidth.Text);

            SwitchToMousePaintMode();
        }

        /// <summary>
        /// Метод запрещает рисовать фигурами и разрешает рисовать мышью
        /// </summary>
        private void SwitchToMousePaintMode()
        {
            _doMouseDraw = true;
            _doDrawShapes = false;
        }
        #endregion

        #region ColorSelect

        private void buttonRed_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Red;
            IndicateColor(SelectedColor);
            SetPenColor(SelectedColor);
            PaintSelectedShape(SelectedColor);
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Orange;
            IndicateColor(SelectedColor);
            SetPenColor(SelectedColor);
            PaintSelectedShape(SelectedColor);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Yellow;
            IndicateColor(SelectedColor);
            SetPenColor(SelectedColor);
            PaintSelectedShape(SelectedColor);
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Green;
            IndicateColor(SelectedColor);
            SetPenColor(SelectedColor);
            PaintSelectedShape(SelectedColor);
        }

        private void buttonLightBlue_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.LightBlue;
            IndicateColor(SelectedColor);
            SetPenColor(SelectedColor);
            PaintSelectedShape(SelectedColor);
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Blue;
            IndicateColor(SelectedColor);
            SetPenColor(SelectedColor);
            PaintSelectedShape(SelectedColor);
        }

        private void buttonPurple_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Purple;
            IndicateColor(SelectedColor);
            SetPenColor(SelectedColor);
            PaintSelectedShape(SelectedColor);
        }

        private void buttonBrown_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Brown;
            IndicateColor(SelectedColor);
            SetPenColor(SelectedColor);
            PaintSelectedShape(SelectedColor);
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Black;
            IndicateColor(SelectedColor);
            SetPenColor(SelectedColor);
            PaintSelectedShape(SelectedColor);
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.White;
            IndicateColor(SelectedColor);
            SetPenColor(SelectedColor);
            PaintSelectedShape(SelectedColor);

        }

        /// <summary>
        /// Установить цвет с помощью схемы RGB
        /// </summary>
        private void buttonSetColor_Click(object sender, EventArgs e)
        {
            try
            {
                int red = int.Parse(textBoxRed.Text);
                int green = int.Parse(textBoxGreen.Text);
                int blue = int.Parse(textBoxBlue.Text);

                SelectedColor = Color.FromArgb(red, green, blue);
                IndicateColor(SelectedColor);
            }
            catch
            {
                MessageBox.Show("Неверно указаны значения цветов RGB", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Установить цвет с помощью палитры
        /// </summary>
        private void buttonSetColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog() 
            { 
                AllowFullOpen = true,
                ShowHelp= true,
                Color = SelectedColor
            };

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SelectedColor = colorDialog.Color;
                    IndicateColor(SelectedColor);
                    PaintSelectedShape(SelectedColor);
                }
                catch
                {
                    MessageBox.Show("Не удалось выбрать цвет", "Ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        /// <summary>
        /// Отображает выбранный цвет на интерфейсе
        /// </summary>
        private void IndicateColor(Color color)
        {
            buttonCurrentColor.BackColor = color;
        }

        private void PaintSelectedShape(Color color)
        {
            if (SelectedShape != null)
            {
                SelectedShape.Color = color;
                Canvas.Invalidate();
            }
        }
        private void SetPenColor(Color color)
        {
            SelectedPen.Color = color;
        }

        #endregion

        #region ShapeSelect

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            SetShape();
            SwitchToShapePaintMode();
            InitializeShape(ShapeSelector.GetShape(ShapeType.Rectangle));
            SelectedShape.Size = new SizeF(200, 200);
            _doResizeShapesEqually = true;

        }
        private void buttonCircle_Click(object sender, EventArgs e)
        {
            SetShape();
            SwitchToShapePaintMode();

            // Полигональный круг из максимального количества граней
            InitializeShape(ShapeSelector.GetPolygonalShape(PolygonalShape.SideCountMax));
            SelectedShape.Size = new SizeF(200, 200);
            _doResizeShapesEqually = true;
        }

        private void buttonTrapezoid_Click(object sender, EventArgs e)
        {
            SetShape();
            SwitchToShapePaintMode();
            InitializeShape(ShapeSelector.GetShape(ShapeType.Trapezoid));
        }

        private void buttonArrow_Click(object sender, EventArgs e)
        {
            SetShape();
            SwitchToShapePaintMode();
            InitializeShape(ShapeSelector.GetShape(ShapeType.Arrow));
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            SetShape();
            SwitchToShapePaintMode();
            InitializeShape(ShapeSelector.GetShape(ShapeType.Rectangle));
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            SetShape();
            SwitchToShapePaintMode();

            // Полигональный круг из максимального количества граней
            InitializeShape(ShapeSelector.GetPolygonalShape(PolygonalShape.SideCountMax));
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            SetShape();
            SwitchToShapePaintMode();
            InitializeShape(ShapeSelector.GetShape(ShapeType.Triangle));
        }

        private void buttonSegment_Click(object sender, EventArgs e)
        {
            SetShape();
            SwitchToShapePaintMode();
            InitializeShape(ShapeSelector.GetPolygonalShape());
        }

        /// <summary>
        /// Указывает для выбранной фигуры значения по умолчанию:
        /// </summary>
        private void InitializeShape(BaseShape shape)
        {
            SelectedShape = shape;

            SelectedShape.Size = new SizeF(200, 300);
            SelectedShape.Angle = 0;

            SelectedShapeSize = SelectedShape.Size;

            SelectedShape.Color = SelectedColor;
            SelectedShape.OutlineColor = Color.Black;

            _doResizeShapes = false;
            _doRotateShapes = false;
            _doResizeShapesEqually= false;
        }

        private void SwitchToShapePaintMode()
        {
            _doDrawShapes = true;
            _doMouseDraw = false;
        }

        #endregion

        #region Other

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            _doRotateShapes = true;
            _doResizeShapes = false;
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            _doRotateShapes = false;
            _doResizeShapes = true;
        }

        private void buttonClearCanvas_Click(object sender, EventArgs e)
        {
            Canvas.Image = WhitePlaneBitmap;
            SelectedShape = ShapeSelector.GetShape(ShapeType.Rectangle);
            SelectedShapeSize = new SizeF(200, 300);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() 
            {
                Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG| " +
                "All files(*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Canvas.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть картинку", "Ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSavePicture_Click(object sender, EventArgs e)
        {
            if (SelectedShape != null)
            {
                SetShape();
            }

            if (Canvas.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog() 
                {
                    Title = "Сохранить картинку как...",
                    OverwritePrompt= true,
                    CheckPathExists=true,
                    ShowHelp = true,
                    Filter = "Image Files(*.BMP)|*.BMP" +
                    "|Image Files(*.JPG)|*.JPG|" +
                    "Image Files(*.GIF)|*.GIF|" +
                    "Image Files(*.PNG)|*.PNG|" +
                    "All files(*.*)|*.*"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Canvas.Image.Save(saveFileDialog.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Point cursorPosition = GetCurrentCursorPosition();

            ////Ставит точки на холсте на месте кликов
            //Graphics g = GetSmoothGraphicsFromCanvas();
            //g.DrawEllipse(SelectedPen, cursorPosition.X, cursorPosition.Y, 10, 10);

            if (_doDrawShapes && SelectedShape != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    MouseDownLocation = e.Location;
                    SelectedShapeSize = SelectedShape.Size;
                }
                if (e.Button == MouseButtons.Right)
                {
                    MouseDownLocation = e.Location;
                }
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point cursorPosition = GetCurrentCursorPosition();
            Graphics g = GetSmoothGraphicsFromCanvas();

            //Рисование мышью
            if (_doMouseDraw)
            {
                if (e.Button == MouseButtons.Left)
                {
                    g.DrawLine(SelectedPen, PreviousPoint, cursorPosition);
                }
            }

            //Рисование фигуры
            if (_doDrawShapes && SelectedShape != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    //Изменение размера фигуры (Растягивание)
                    if (_doResizeShapes)
                    {
                        if (_doResizeShapesEqually)
                        {
                            SelectedShape.Size = new SizeF(GetCurrentSize(e).Width, GetCurrentSize(e).Width);
                        }
                        else
                        {
                            SelectedShape.Size = GetCurrentSize(e);
                        }
                    }

                    //Изменение поворота фигуры (Вращение)
                    if (_doRotateShapes)
                    {
                        float angleRad = GetAngleFromCursorPosition(ref cursorPosition);
                        SelectedShape.Angle = GetAngleDegree(angleRad,ref cursorPosition);
                    }
                }

                //Изменение положения фигуры на экране (Перетаскивание)
                if (e.Button == MouseButtons.Right)
                {
                    SelectedShape.Location = GetCurrentShapePosition(e);
                    MouseDownLocation = e.Location;

                }

            }
            Canvas.Invalidate();
            PreviousPoint = cursorPosition;
        }

        private Point GetCurrentCursorPosition()
        {
            //Позиция курсора корректируется для корректного отображения изображения.
            //Вычисляются его координаты относительно окна приложения

            int x = MousePosition.X - this.Location.X - 8;
            int y = MousePosition.Y - this.Location.Y - 30;

            return new Point(x, y);
        }

        private Graphics GetSmoothGraphicsFromCanvas()
        {
            Graphics g = Graphics.FromImage(Canvas.Image);
            g.SmoothingMode = SmoothingMode.HighQuality;
            return g;
        }

        private SizeF GetCurrentSize(MouseEventArgs e)
        {
            //Размером фигуры становится удалённость курсора относительно её центра
            float x = e.X  - MouseDownLocation.X;
            float y = e.Y - MouseDownLocation.Y;

            float xRotated = x *(float)Math.Cos(SelectedShape.Angle) + y *(float)Math.Sin(SelectedShape.Angle) + SelectedShapeSize.Width;
            float yRotated =(-1)*x*(float)Math.Sin(SelectedShape.Angle) +  y *(float)Math.Cos(SelectedShape.Angle) + SelectedShapeSize.Height;

            return new SizeF(xRotated, yRotated);
        }

        private PointF GetCurrentShapePosition(MouseEventArgs e)
        {
            //К текущей позиции фигуры необходимо прибавить изменение в координатах курсора
            float x = e.X - MouseDownLocation.X + SelectedShape.Location.X;
            float y = e.Y - MouseDownLocation.Y + SelectedShape.Location.Y;

            return new PointF(x, y);
        }

        /// <summary>
        /// </summary>
        /// <param name="cursorPosition"></param>
        /// <returns>Угол между центром выбранной фигуры и курсором</returns>
        private float GetAngleFromCursorPosition(ref Point cursorPosition)
        {
            //Для нахождения угла мы пользуемся прямоугольным треугольником,
            //гипотенуза которого - прямая от курсора до центра выбранной фигуры

            float oppositeSide = SelectedShape.Center.Y - cursorPosition.Y;
            float adjacentSide = SelectedShape.Center.X - cursorPosition.X;

            float tangent = oppositeSide / adjacentSide;

            float angle = (float)Math.Atan(tangent);

            return angle;
        }

        private float GetAngleDegree(float angle, ref Point cursorPosition)
        {
            //Центр фигуры ниже и правее
            if (SelectedShape.Center.Y <= cursorPosition.Y && SelectedShape.Center.X >= cursorPosition.X)
            {
                return angle + 1.57f * 2f;
            }
            
            //Центр фигуры выше и правее
            if (SelectedShape.Center.Y >= cursorPosition.Y && SelectedShape.Center.X >= cursorPosition.X)
            {
                return angle + 1.57f * 2f;
            }
            
            return angle;
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

                DrawBoundingBox(e.Graphics, SelectedShape);

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

        /// <summary>
        /// Нарисовать выбранную фигуру
        /// </summary>
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
        private void DrawBoundingBox(Graphics graphics, BaseShape shape)
        {
            using (Pen pen = new Pen(Color.Gray, BaseShape.DefaultOutlineWidth))
            {
                pen.DashStyle = DashStyle.Dash;

                graphics.DrawPath(pen, shape.BoundingBox);
            }
        }

        /// <summary>
        /// Нарисовать параллельную осям координат границу вокруг фигуры пунктиром
        /// </summary>
        /// <param name="graphics">Графика</param>
        /// <param name="shape">Фигура</param>
        private void DrawAxisAlignedBoundingBox(Graphics graphics, BaseShape shape)
        {
            using (Pen pen = new Pen(Color.Gray, BaseShape.DefaultOutlineWidth))
            {
                pen.DashStyle = DashStyle.Dash;

                graphics.DrawPath(pen, shape.AxisAlignedBoundingBox);
            }
        }

        #endregion
    }
}
