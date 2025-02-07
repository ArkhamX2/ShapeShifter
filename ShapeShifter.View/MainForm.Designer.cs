﻿namespace ShapeShifter.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumberOfEdges = new System.Windows.Forms.TextBox();
            this.buttonResize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSetColorPicker = new System.Windows.Forms.Button();
            this.labelCurrentColor = new System.Windows.Forms.Label();
            this.buttonCurrentColor = new System.Windows.Forms.Button();
            this.buttonSetColor = new System.Windows.Forms.Button();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelSetColorRGB = new System.Windows.Forms.Label();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.labelShape = new System.Windows.Forms.Label();
            this.buttonSegment = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonArrow = new System.Windows.Forms.Button();
            this.buttonTrapezoid = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.labelPenColor = new System.Windows.Forms.Label();
            this.buttonSavePicture = new System.Windows.Forms.Button();
            this.buttonClearCanvas = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonPurple = new System.Windows.Forms.Button();
            this.buttonBrown = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonLightBlue = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.labelPenSize = new System.Windows.Forms.Label();
            this.comboBoxPenWidth = new System.Windows.Forms.ComboBox();
            this.buttonDefaultPen = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.panelCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCanvas.Controls.Add(this.Canvas);
            this.panelCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCanvas.Location = new System.Drawing.Point(0, 0);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(1163, 765);
            this.panelCanvas.TabIndex = 1;
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1163, 765);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.Resize += new System.EventHandler(this.Canvas_Resize);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainPanel.Controls.Add(this.panelCanvas);
            this.MainPanel.Controls.Add(this.toolsPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1427, 765);
            this.MainPanel.TabIndex = 2;
            // 
            // toolsPanel
            // 
            this.toolsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolsPanel.Controls.Add(this.label2);
            this.toolsPanel.Controls.Add(this.textBoxNumberOfEdges);
            this.toolsPanel.Controls.Add(this.buttonResize);
            this.toolsPanel.Controls.Add(this.label1);
            this.toolsPanel.Controls.Add(this.buttonRotate);
            this.toolsPanel.Controls.Add(this.buttonOpen);
            this.toolsPanel.Controls.Add(this.buttonSetColorPicker);
            this.toolsPanel.Controls.Add(this.labelCurrentColor);
            this.toolsPanel.Controls.Add(this.buttonCurrentColor);
            this.toolsPanel.Controls.Add(this.buttonSetColor);
            this.toolsPanel.Controls.Add(this.labelBlue);
            this.toolsPanel.Controls.Add(this.labelGreen);
            this.toolsPanel.Controls.Add(this.labelRed);
            this.toolsPanel.Controls.Add(this.labelSetColorRGB);
            this.toolsPanel.Controls.Add(this.textBoxBlue);
            this.toolsPanel.Controls.Add(this.textBoxGreen);
            this.toolsPanel.Controls.Add(this.textBoxRed);
            this.toolsPanel.Controls.Add(this.labelShape);
            this.toolsPanel.Controls.Add(this.buttonSegment);
            this.toolsPanel.Controls.Add(this.buttonRectangle);
            this.toolsPanel.Controls.Add(this.buttonEllipse);
            this.toolsPanel.Controls.Add(this.buttonTriangle);
            this.toolsPanel.Controls.Add(this.buttonCircle);
            this.toolsPanel.Controls.Add(this.buttonArrow);
            this.toolsPanel.Controls.Add(this.buttonTrapezoid);
            this.toolsPanel.Controls.Add(this.buttonSquare);
            this.toolsPanel.Controls.Add(this.labelPenColor);
            this.toolsPanel.Controls.Add(this.buttonSavePicture);
            this.toolsPanel.Controls.Add(this.buttonClearCanvas);
            this.toolsPanel.Controls.Add(this.buttonWhite);
            this.toolsPanel.Controls.Add(this.buttonPurple);
            this.toolsPanel.Controls.Add(this.buttonBrown);
            this.toolsPanel.Controls.Add(this.buttonBlack);
            this.toolsPanel.Controls.Add(this.buttonBlue);
            this.toolsPanel.Controls.Add(this.buttonLightBlue);
            this.toolsPanel.Controls.Add(this.buttonOrange);
            this.toolsPanel.Controls.Add(this.buttonYellow);
            this.toolsPanel.Controls.Add(this.buttonGreen);
            this.toolsPanel.Controls.Add(this.buttonRed);
            this.toolsPanel.Controls.Add(this.labelPenSize);
            this.toolsPanel.Controls.Add(this.comboBoxPenWidth);
            this.toolsPanel.Controls.Add(this.buttonDefaultPen);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolsPanel.Location = new System.Drawing.Point(1163, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(264, 765);
            this.toolsPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Количество граней";
            // 
            // textBoxNumberOfEdges
            // 
            this.textBoxNumberOfEdges.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberOfEdges.Location = new System.Drawing.Point(168, 645);
            this.textBoxNumberOfEdges.Name = "textBoxNumberOfEdges";
            this.textBoxNumberOfEdges.Size = new System.Drawing.Size(84, 29);
            this.textBoxNumberOfEdges.TabIndex = 47;
            // 
            // buttonResize
            // 
            this.buttonResize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonResize.Image = ((System.Drawing.Image)(resources.GetObject("buttonResize.Image")));
            this.buttonResize.Location = new System.Drawing.Point(212, 587);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(40, 40);
            this.buttonResize.TabIndex = 46;
            this.buttonResize.UseVisualStyleBackColor = false;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Изменить";
            // 
            // buttonRotate
            // 
            this.buttonRotate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRotate.Image = ((System.Drawing.Image)(resources.GetObject("buttonRotate.Image")));
            this.buttonRotate.Location = new System.Drawing.Point(212, 544);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(40, 40);
            this.buttonRotate.TabIndex = 44;
            this.buttonRotate.UseVisualStyleBackColor = false;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(11, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(116, 35);
            this.buttonOpen.TabIndex = 43;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSetColorPicker
            // 
            this.buttonSetColorPicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetColorPicker.Location = new System.Drawing.Point(11, 475);
            this.buttonSetColorPicker.Name = "buttonSetColorPicker";
            this.buttonSetColorPicker.Size = new System.Drawing.Size(238, 35);
            this.buttonSetColorPicker.TabIndex = 42;
            this.buttonSetColorPicker.Text = "Выбрать новый цвет";
            this.buttonSetColorPicker.UseVisualStyleBackColor = true;
            this.buttonSetColorPicker.Click += new System.EventHandler(this.buttonSetColorPicker_Click);
            // 
            // labelCurrentColor
            // 
            this.labelCurrentColor.AutoSize = true;
            this.labelCurrentColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentColor.Location = new System.Drawing.Point(80, 131);
            this.labelCurrentColor.Name = "labelCurrentColor";
            this.labelCurrentColor.Size = new System.Drawing.Size(110, 21);
            this.labelCurrentColor.TabIndex = 41;
            this.labelCurrentColor.Text = "Текущий цвет";
            // 
            // buttonCurrentColor
            // 
            this.buttonCurrentColor.BackColor = System.Drawing.Color.Red;
            this.buttonCurrentColor.Enabled = false;
            this.buttonCurrentColor.Location = new System.Drawing.Point(204, 131);
            this.buttonCurrentColor.Name = "buttonCurrentColor";
            this.buttonCurrentColor.Size = new System.Drawing.Size(40, 40);
            this.buttonCurrentColor.TabIndex = 40;
            this.buttonCurrentColor.UseVisualStyleBackColor = false;
            // 
            // buttonSetColor
            // 
            this.buttonSetColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetColor.Location = new System.Drawing.Point(11, 434);
            this.buttonSetColor.Name = "buttonSetColor";
            this.buttonSetColor.Size = new System.Drawing.Size(238, 35);
            this.buttonSetColor.TabIndex = 39;
            this.buttonSetColor.Text = "Задать цвет";
            this.buttonSetColor.UseVisualStyleBackColor = true;
            this.buttonSetColor.Click += new System.EventHandler(this.buttonSetColor_Click);
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBlue.Location = new System.Drawing.Point(40, 401);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(43, 21);
            this.labelBlue.TabIndex = 38;
            this.labelBlue.Text = "Blue:";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGreen.Location = new System.Drawing.Point(40, 366);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(55, 21);
            this.labelGreen.TabIndex = 37;
            this.labelGreen.Text = "Green:";
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRed.Location = new System.Drawing.Point(40, 331);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(40, 21);
            this.labelRed.TabIndex = 36;
            this.labelRed.Text = "Red:";
            // 
            // labelSetColorRGB
            // 
            this.labelSetColorRGB.AutoSize = true;
            this.labelSetColorRGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSetColorRGB.Location = new System.Drawing.Point(95, 299);
            this.labelSetColorRGB.Name = "labelSetColorRGB";
            this.labelSetColorRGB.Size = new System.Drawing.Size(140, 21);
            this.labelSetColorRGB.TabIndex = 35;
            this.labelSetColorRGB.Text = "Задать цвет (RGB)";
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBlue.Location = new System.Drawing.Point(142, 393);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(100, 29);
            this.textBoxBlue.TabIndex = 34;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGreen.Location = new System.Drawing.Point(142, 358);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(100, 29);
            this.textBoxGreen.TabIndex = 33;
            // 
            // textBoxRed
            // 
            this.textBoxRed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRed.Location = new System.Drawing.Point(142, 323);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(100, 29);
            this.textBoxRed.TabIndex = 32;
            // 
            // labelShape
            // 
            this.labelShape.AutoSize = true;
            this.labelShape.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShape.Location = new System.Drawing.Point(16, 520);
            this.labelShape.Name = "labelShape";
            this.labelShape.Size = new System.Drawing.Size(62, 21);
            this.labelShape.TabIndex = 31;
            this.labelShape.Text = "Фигура";
            // 
            // buttonSegment
            // 
            this.buttonSegment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSegment.Image = ((System.Drawing.Image)(resources.GetObject("buttonSegment.Image")));
            this.buttonSegment.Location = new System.Drawing.Point(150, 587);
            this.buttonSegment.Name = "buttonSegment";
            this.buttonSegment.Size = new System.Drawing.Size(40, 40);
            this.buttonSegment.TabIndex = 30;
            this.buttonSegment.UseVisualStyleBackColor = false;
            this.buttonSegment.Click += new System.EventHandler(this.buttonSegment_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonRectangle.Image")));
            this.buttonRectangle.Location = new System.Drawing.Point(12, 587);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(40, 40);
            this.buttonRectangle.TabIndex = 29;
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("buttonEllipse.Image")));
            this.buttonEllipse.Location = new System.Drawing.Point(58, 587);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(40, 40);
            this.buttonEllipse.TabIndex = 28;
            this.buttonEllipse.UseVisualStyleBackColor = false;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTriangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTriangle.Image")));
            this.buttonTriangle.Location = new System.Drawing.Point(104, 587);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(40, 40);
            this.buttonTriangle.TabIndex = 27;
            this.buttonTriangle.UseVisualStyleBackColor = false;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCircle.Image = ((System.Drawing.Image)(resources.GetObject("buttonCircle.Image")));
            this.buttonCircle.Location = new System.Drawing.Point(58, 544);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(40, 40);
            this.buttonCircle.TabIndex = 26;
            this.buttonCircle.UseVisualStyleBackColor = false;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonArrow
            // 
            this.buttonArrow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonArrow.Image = ((System.Drawing.Image)(resources.GetObject("buttonArrow.Image")));
            this.buttonArrow.Location = new System.Drawing.Point(150, 544);
            this.buttonArrow.Name = "buttonArrow";
            this.buttonArrow.Size = new System.Drawing.Size(40, 40);
            this.buttonArrow.TabIndex = 25;
            this.buttonArrow.UseVisualStyleBackColor = false;
            this.buttonArrow.Click += new System.EventHandler(this.buttonArrow_Click);
            // 
            // buttonTrapezoid
            // 
            this.buttonTrapezoid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTrapezoid.Image = ((System.Drawing.Image)(resources.GetObject("buttonTrapezoid.Image")));
            this.buttonTrapezoid.Location = new System.Drawing.Point(104, 544);
            this.buttonTrapezoid.Name = "buttonTrapezoid";
            this.buttonTrapezoid.Size = new System.Drawing.Size(40, 40);
            this.buttonTrapezoid.TabIndex = 24;
            this.buttonTrapezoid.UseVisualStyleBackColor = false;
            this.buttonTrapezoid.Click += new System.EventHandler(this.buttonTrapezoid_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSquare.Image = ((System.Drawing.Image)(resources.GetObject("buttonSquare.Image")));
            this.buttonSquare.Location = new System.Drawing.Point(12, 544);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(40, 40);
            this.buttonSquare.TabIndex = 23;
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // labelPenColor
            // 
            this.labelPenColor.AutoSize = true;
            this.labelPenColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPenColor.Location = new System.Drawing.Point(146, 180);
            this.labelPenColor.Name = "labelPenColor";
            this.labelPenColor.Size = new System.Drawing.Size(89, 21);
            this.labelPenColor.TabIndex = 22;
            this.labelPenColor.Text = "Цвет кисти";
            // 
            // buttonSavePicture
            // 
            this.buttonSavePicture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSavePicture.Location = new System.Drawing.Point(142, 12);
            this.buttonSavePicture.Name = "buttonSavePicture";
            this.buttonSavePicture.Size = new System.Drawing.Size(107, 35);
            this.buttonSavePicture.TabIndex = 21;
            this.buttonSavePicture.Text = "Сохранить";
            this.buttonSavePicture.UseVisualStyleBackColor = true;
            this.buttonSavePicture.Click += new System.EventHandler(this.buttonSavePicture_Click);
            // 
            // buttonClearCanvas
            // 
            this.buttonClearCanvas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearCanvas.Location = new System.Drawing.Point(11, 680);
            this.buttonClearCanvas.Name = "buttonClearCanvas";
            this.buttonClearCanvas.Size = new System.Drawing.Size(238, 35);
            this.buttonClearCanvas.TabIndex = 20;
            this.buttonClearCanvas.Text = "Очистить холст";
            this.buttonClearCanvas.UseVisualStyleBackColor = true;
            this.buttonClearCanvas.Click += new System.EventHandler(this.buttonClearCanvas_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.White;
            this.buttonWhite.Location = new System.Drawing.Point(204, 250);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(40, 40);
            this.buttonWhite.TabIndex = 19;
            this.buttonWhite.UseVisualStyleBackColor = false;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // buttonPurple
            // 
            this.buttonPurple.BackColor = System.Drawing.Color.Purple;
            this.buttonPurple.Location = new System.Drawing.Point(66, 250);
            this.buttonPurple.Name = "buttonPurple";
            this.buttonPurple.Size = new System.Drawing.Size(40, 40);
            this.buttonPurple.TabIndex = 18;
            this.buttonPurple.UseVisualStyleBackColor = false;
            this.buttonPurple.Click += new System.EventHandler(this.buttonPurple_Click);
            // 
            // buttonBrown
            // 
            this.buttonBrown.BackColor = System.Drawing.Color.Brown;
            this.buttonBrown.Location = new System.Drawing.Point(112, 250);
            this.buttonBrown.Name = "buttonBrown";
            this.buttonBrown.Size = new System.Drawing.Size(40, 40);
            this.buttonBrown.TabIndex = 17;
            this.buttonBrown.UseVisualStyleBackColor = false;
            this.buttonBrown.Click += new System.EventHandler(this.buttonBrown_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBlack.Location = new System.Drawing.Point(158, 250);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(40, 40);
            this.buttonBlack.TabIndex = 16;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.Location = new System.Drawing.Point(20, 250);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(40, 40);
            this.buttonBlue.TabIndex = 15;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonLightBlue
            // 
            this.buttonLightBlue.BackColor = System.Drawing.Color.LightBlue;
            this.buttonLightBlue.Location = new System.Drawing.Point(204, 204);
            this.buttonLightBlue.Name = "buttonLightBlue";
            this.buttonLightBlue.Size = new System.Drawing.Size(40, 40);
            this.buttonLightBlue.TabIndex = 14;
            this.buttonLightBlue.UseVisualStyleBackColor = false;
            this.buttonLightBlue.Click += new System.EventHandler(this.buttonLightBlue_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.BackColor = System.Drawing.Color.Orange;
            this.buttonOrange.Location = new System.Drawing.Point(66, 204);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(40, 40);
            this.buttonOrange.TabIndex = 12;
            this.buttonOrange.UseVisualStyleBackColor = false;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.Location = new System.Drawing.Point(112, 204);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(40, 40);
            this.buttonYellow.TabIndex = 11;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.Location = new System.Drawing.Point(158, 204);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(40, 40);
            this.buttonGreen.TabIndex = 10;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(20, 204);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(40, 40);
            this.buttonRed.TabIndex = 9;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // labelPenSize
            // 
            this.labelPenSize.AutoSize = true;
            this.labelPenSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPenSize.Location = new System.Drawing.Point(129, 60);
            this.labelPenSize.Name = "labelPenSize";
            this.labelPenSize.Size = new System.Drawing.Size(106, 21);
            this.labelPenSize.TabIndex = 8;
            this.labelPenSize.Text = "Размер кисти";
            // 
            // comboBoxPenWidth
            // 
            this.comboBoxPenWidth.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPenWidth.FormattingEnabled = true;
            this.comboBoxPenWidth.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "10",
            "15",
            "20",
            "30",
            "50",
            "100"});
            this.comboBoxPenWidth.Location = new System.Drawing.Point(70, 84);
            this.comboBoxPenWidth.Name = "comboBoxPenWidth";
            this.comboBoxPenWidth.Size = new System.Drawing.Size(174, 41);
            this.comboBoxPenWidth.TabIndex = 7;
            this.comboBoxPenWidth.Text = "5";
            this.comboBoxPenWidth.SelectedIndexChanged += new System.EventHandler(this.comboBoxPenWidth_SelectedIndexChanged);
            // 
            // buttonDefaultPen
            // 
            this.buttonDefaultPen.BackColor = System.Drawing.Color.White;
            this.buttonDefaultPen.Image = ((System.Drawing.Image)(resources.GetObject("buttonDefaultPen.Image")));
            this.buttonDefaultPen.Location = new System.Drawing.Point(23, 84);
            this.buttonDefaultPen.Name = "buttonDefaultPen";
            this.buttonDefaultPen.Size = new System.Drawing.Size(40, 40);
            this.buttonDefaultPen.TabIndex = 3;
            this.buttonDefaultPen.UseVisualStyleBackColor = false;
            this.buttonDefaultPen.Click += new System.EventHandler(this.buttonDefaultPen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 765);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Рисование";
            this.panelCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.Button buttonDefaultPen;
        private System.Windows.Forms.ComboBox comboBoxPenWidth;
        private System.Windows.Forms.Label labelPenSize;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonPurple;
        private System.Windows.Forms.Button buttonBrown;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonLightBlue;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Label labelPenColor;
        private System.Windows.Forms.Button buttonSavePicture;
        private System.Windows.Forms.Button buttonClearCanvas;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonArrow;
        private System.Windows.Forms.Button buttonTrapezoid;
        private System.Windows.Forms.Label labelShape;
        private System.Windows.Forms.Button buttonSegment;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonSetColorPicker;
        private System.Windows.Forms.Label labelCurrentColor;
        private System.Windows.Forms.Button buttonCurrentColor;
        private System.Windows.Forms.Button buttonSetColor;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelSetColorRGB;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonSquare;
        public System.Windows.Forms.TextBox textBoxNumberOfEdges;
        private System.Windows.Forms.Label label2;
    }
}

