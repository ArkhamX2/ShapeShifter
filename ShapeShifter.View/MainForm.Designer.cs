namespace ShapeShifter.View
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
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripTools = new System.Windows.Forms.ToolStrip();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMouseDraw = new System.Windows.Forms.ToolStripButton();
            this.toolStripFigures = new System.Windows.Forms.ToolStripDropDownButton();
            this.квадратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямоугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кругToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эллипсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.треугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стрелочкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.трапецияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оранжевыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жёлтыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зелёныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.голубойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фиолетовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.белыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSaveFigureToList = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.panelCanvas.SuspendLayout();
            this.toolStripTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1427, 684);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.Resize += new System.EventHandler(this.Canvas_Resize);
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCanvas.Controls.Add(this.statusStrip1);
            this.panelCanvas.Controls.Add(this.Canvas);
            this.panelCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCanvas.Location = new System.Drawing.Point(0, 0);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(1427, 684);
            this.panelCanvas.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 662);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1427, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStripTools
            // 
            this.toolStripTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSave,
            this.toolStripSeparator1,
            this.toolStripMouseDraw,
            this.toolStripFigures,
            this.toolStripDropDownButton1,
            this.toolStripButtonSaveFigureToList,
            this.toolStripSeparator2,
            this.toolStripButtonClear});
            this.toolStripTools.Location = new System.Drawing.Point(0, 0);
            this.toolStripTools.Name = "toolStripTools";
            this.toolStripTools.Size = new System.Drawing.Size(1427, 25);
            this.toolStripTools.TabIndex = 2;
            this.toolStripTools.Text = "toolStrip1";
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(70, 22);
            this.toolStripSave.Text = "Сохранить";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripMouseDraw
            // 
            this.toolStripMouseDraw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMouseDraw.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMouseDraw.Image")));
            this.toolStripMouseDraw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMouseDraw.Name = "toolStripMouseDraw";
            this.toolStripMouseDraw.Size = new System.Drawing.Size(109, 22);
            this.toolStripMouseDraw.Text = "Рисовать мышью";
            this.toolStripMouseDraw.Click += new System.EventHandler(this.toolStripMouseDraw_Click);
            // 
            // toolStripFigures
            // 
            this.toolStripFigures.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFigures.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.квадратToolStripMenuItem,
            this.прямоугольникToolStripMenuItem,
            this.кругToolStripMenuItem,
            this.эллипсToolStripMenuItem,
            this.треугольникToolStripMenuItem,
            this.стрелочкаToolStripMenuItem,
            this.трапецияToolStripMenuItem});
            this.toolStripFigures.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFigures.Image")));
            this.toolStripFigures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFigures.Name = "toolStripFigures";
            this.toolStripFigures.Size = new System.Drawing.Size(63, 22);
            this.toolStripFigures.Text = "Фигуры";
            this.toolStripFigures.Click += new System.EventHandler(this.toolStripFigures_Click);
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.квадратToolStripMenuItem.Text = "Квадрат";
            this.квадратToolStripMenuItem.Click += new System.EventHandler(this.квадратToolStripMenuItem_Click);
            // 
            // прямоугольникToolStripMenuItem
            // 
            this.прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            this.прямоугольникToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.прямоугольникToolStripMenuItem.Text = "Прямоугольник";
            this.прямоугольникToolStripMenuItem.Click += new System.EventHandler(this.прямоугольникToolStripMenuItem_Click);
            // 
            // кругToolStripMenuItem
            // 
            this.кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            this.кругToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.кругToolStripMenuItem.Text = "Круг";
            this.кругToolStripMenuItem.Click += new System.EventHandler(this.кругToolStripMenuItem_Click);
            // 
            // эллипсToolStripMenuItem
            // 
            this.эллипсToolStripMenuItem.Name = "эллипсToolStripMenuItem";
            this.эллипсToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.эллипсToolStripMenuItem.Text = "Эллипс";
            this.эллипсToolStripMenuItem.Click += new System.EventHandler(this.эллипсToolStripMenuItem_Click);
            // 
            // треугольникToolStripMenuItem
            // 
            this.треугольникToolStripMenuItem.Name = "треугольникToolStripMenuItem";
            this.треугольникToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.треугольникToolStripMenuItem.Text = "Треугольник";
            this.треугольникToolStripMenuItem.Click += new System.EventHandler(this.треугольникToolStripMenuItem_Click);
            // 
            // стрелочкаToolStripMenuItem
            // 
            this.стрелочкаToolStripMenuItem.Name = "стрелочкаToolStripMenuItem";
            this.стрелочкаToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.стрелочкаToolStripMenuItem.Text = "Стрелочка";
            this.стрелочкаToolStripMenuItem.Click += new System.EventHandler(this.стрелочкаToolStripMenuItem_Click);
            // 
            // трапецияToolStripMenuItem
            // 
            this.трапецияToolStripMenuItem.Name = "трапецияToolStripMenuItem";
            this.трапецияToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.трапецияToolStripMenuItem.Text = "Трапеция";
            this.трапецияToolStripMenuItem.Click += new System.EventHandler(this.трапецияToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.красныйToolStripMenuItem,
            this.оранжевыйToolStripMenuItem,
            this.жёлтыйToolStripMenuItem,
            this.зелёныйToolStripMenuItem,
            this.голубойToolStripMenuItem,
            this.синийToolStripMenuItem,
            this.фиолетовыйToolStripMenuItem,
            this.белыйToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(92, 22);
            this.toolStripDropDownButton1.Text = "Цвет фигуры";
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.красныйToolStripMenuItem.Text = "Красный";
            this.красныйToolStripMenuItem.Click += new System.EventHandler(this.красныйToolStripMenuItem_Click);
            // 
            // оранжевыйToolStripMenuItem
            // 
            this.оранжевыйToolStripMenuItem.Name = "оранжевыйToolStripMenuItem";
            this.оранжевыйToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.оранжевыйToolStripMenuItem.Text = "Оранжевый";
            this.оранжевыйToolStripMenuItem.Click += new System.EventHandler(this.оранжевыйToolStripMenuItem_Click);
            // 
            // жёлтыйToolStripMenuItem
            // 
            this.жёлтыйToolStripMenuItem.Name = "жёлтыйToolStripMenuItem";
            this.жёлтыйToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.жёлтыйToolStripMenuItem.Text = "Жёлтый";
            this.жёлтыйToolStripMenuItem.Click += new System.EventHandler(this.жёлтыйToolStripMenuItem_Click);
            // 
            // зелёныйToolStripMenuItem
            // 
            this.зелёныйToolStripMenuItem.Name = "зелёныйToolStripMenuItem";
            this.зелёныйToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.зелёныйToolStripMenuItem.Text = "Зелёный";
            this.зелёныйToolStripMenuItem.Click += new System.EventHandler(this.зелёныйToolStripMenuItem_Click);
            // 
            // голубойToolStripMenuItem
            // 
            this.голубойToolStripMenuItem.Name = "голубойToolStripMenuItem";
            this.голубойToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.голубойToolStripMenuItem.Text = "Голубой";
            this.голубойToolStripMenuItem.Click += new System.EventHandler(this.голубойToolStripMenuItem_Click);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.синийToolStripMenuItem.Text = "Синий";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.синийToolStripMenuItem_Click);
            // 
            // фиолетовыйToolStripMenuItem
            // 
            this.фиолетовыйToolStripMenuItem.Name = "фиолетовыйToolStripMenuItem";
            this.фиолетовыйToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.фиолетовыйToolStripMenuItem.Text = "Фиолетовый";
            this.фиолетовыйToolStripMenuItem.Click += new System.EventHandler(this.фиолетовыйToolStripMenuItem_Click);
            // 
            // белыйToolStripMenuItem
            // 
            this.белыйToolStripMenuItem.Name = "белыйToolStripMenuItem";
            this.белыйToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.белыйToolStripMenuItem.Text = "Прозрачный";
            this.белыйToolStripMenuItem.Click += new System.EventHandler(this.белыйToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSaveFigureToList
            // 
            this.toolStripButtonSaveFigureToList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSaveFigureToList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveFigureToList.Image")));
            this.toolStripButtonSaveFigureToList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveFigureToList.Name = "toolStripButtonSaveFigureToList";
            this.toolStripButtonSaveFigureToList.Size = new System.Drawing.Size(113, 22);
            this.toolStripButtonSaveFigureToList.Text = "Сохранить фигуру";
            this.toolStripButtonSaveFigureToList.Click += new System.EventHandler(this.toolStripButtonSaveFigureToList_Click);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonClear.Text = "Очистить";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 684);
            this.Controls.Add(this.toolStripTools);
            this.Controls.Add(this.panelCanvas);
            this.Name = "MainForm";
            this.Text = "Рисование";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.panelCanvas.ResumeLayout(false);
            this.panelCanvas.PerformLayout();
            this.toolStripTools.ResumeLayout(false);
            this.toolStripTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStripTools;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripMouseDraw;
        private System.Windows.Forms.ToolStripDropDownButton toolStripFigures;
        private System.Windows.Forms.ToolStripMenuItem прямоугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эллипсToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveFigureToList;
        private System.Windows.Forms.ToolStripMenuItem треугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кругToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стрелочкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem трапецияToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem красныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оранжевыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жёлтыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зелёныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem голубойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фиолетовыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem белыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
    }
}

