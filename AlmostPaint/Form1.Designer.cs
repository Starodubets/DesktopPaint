namespace AlmostPaint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pMenu1 = new AlmostPaint.Controls.PMenu();
            this.pStatusBar1 = new AlmostPaint.Controls.PStatusBar();
            this.pToolBox1 = new AlmostPaint.Controls.PToolBox();
            this.pPlugin1 = new AlmostPaint.Controls.PPlugin();
            this.pProperty1 = new AlmostPaint.Controls.PProperty();
            this.pDraw1 = new AlmostPaint.Controls.PDraw();
            this.SuspendLayout();
            // 
            // pMenu1
            // 
            this.pMenu1.Location = new System.Drawing.Point(0, -2);
            this.pMenu1.Name = "pMenu1";
            this.pMenu1.Size = new System.Drawing.Size(993, 27);
            this.pMenu1.TabIndex = 1;
            // 
            // pStatusBar1
            // 
            this.pStatusBar1.Location = new System.Drawing.Point(0, 603);
            this.pStatusBar1.Name = "pStatusBar1";
            this.pStatusBar1.Size = new System.Drawing.Size(993, 24);
            this.pStatusBar1.TabIndex = 2;
            // 
            // pToolBox1
            // 
            this.pToolBox1.Location = new System.Drawing.Point(1, 22);
            this.pToolBox1.Name = "pToolBox1";
            this.pToolBox1.Size = new System.Drawing.Size(993, 25);
            this.pToolBox1.TabIndex = 3;
            // 
            // pPlugin1
            // 
            this.pPlugin1.Location = new System.Drawing.Point(12, 75);
            this.pPlugin1.Name = "pPlugin1";
            this.pPlugin1.Size = new System.Drawing.Size(146, 523);
            this.pPlugin1.TabIndex = 4;
            // 
            // pProperty1
            // 
            this.pProperty1.Location = new System.Drawing.Point(799, 89);
            this.pProperty1.Name = "pProperty1";
            this.pProperty1.Size = new System.Drawing.Size(194, 499);
            this.pProperty1.TabIndex = 5;
            // 
            // pDraw1
            // 
            this.pDraw1.Location = new System.Drawing.Point(173, 75);
            this.pDraw1.Name = "pDraw1";
            this.pDraw1.Size = new System.Drawing.Size(598, 513);
            this.pDraw1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 629);
            this.Controls.Add(this.pDraw1);
            this.Controls.Add(this.pProperty1);
            this.Controls.Add(this.pPlugin1);
            this.Controls.Add(this.pToolBox1);
            this.Controls.Add(this.pStatusBar1);
            this.Controls.Add(this.pMenu1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.PMenu pMenu1;
        private Controls.PStatusBar pStatusBar1;
        private Controls.PToolBox pToolBox1;
        private Controls.PPlugin pPlugin1;
        private Controls.PProperty pProperty1;
        private Controls.PDraw pDraw1;
    }
}

