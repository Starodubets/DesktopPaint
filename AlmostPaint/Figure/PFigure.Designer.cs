namespace AlmostPaint.Figure
{
    partial class PFigure
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PFigure";
            this.Size = new System.Drawing.Size(46, 42);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PFigure_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PFigure_KeyDown);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PFigure_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PFigure_MouseDown);
            this.MouseEnter += new System.EventHandler(this.PFigure_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PFigure_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PFigure_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PFigure_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
