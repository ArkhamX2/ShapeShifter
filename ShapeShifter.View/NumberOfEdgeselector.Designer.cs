namespace ShapeShifter.View
{
    partial class NumberOfEdgeselector
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
            this.textBoxNumberOfEdges = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumberOfEdges
            // 
            this.textBoxNumberOfEdges.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberOfEdges.Location = new System.Drawing.Point(12, 12);
            this.textBoxNumberOfEdges.Name = "textBoxNumberOfEdges";
            this.textBoxNumberOfEdges.Size = new System.Drawing.Size(100, 33);
            this.textBoxNumberOfEdges.TabIndex = 0;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(118, 12);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(85, 33);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "Принять";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // NumberOfEdgeselector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 58);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.textBoxNumberOfEdges);
            this.MaximumSize = new System.Drawing.Size(230, 97);
            this.MinimumSize = new System.Drawing.Size(230, 97);
            this.Name = "NumberOfEdgeselector";
            this.Text = "NumberOfEdgeselector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumberOfEdges;
        private System.Windows.Forms.Button ApplyButton;
    }
}