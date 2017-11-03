namespace AlmostPaint.Controls
{
    partial class PPlugin
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
            this.picturefigBtn = new System.Windows.Forms.Button();
            this.textfigBtn = new System.Windows.Forms.Button();
            this.emptyFigureBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturefigBtn
            // 
            this.picturefigBtn.Location = new System.Drawing.Point(26, 234);
            this.picturefigBtn.Name = "picturefigBtn";
            this.picturefigBtn.Size = new System.Drawing.Size(75, 48);
            this.picturefigBtn.TabIndex = 4;
            this.picturefigBtn.Text = "Picture with figure";
            this.picturefigBtn.UseVisualStyleBackColor = true;
            // 
            // textfigBtn
            // 
            this.textfigBtn.Location = new System.Drawing.Point(26, 141);
            this.textfigBtn.Name = "textfigBtn";
            this.textfigBtn.Size = new System.Drawing.Size(75, 48);
            this.textfigBtn.TabIndex = 3;
            this.textfigBtn.Text = "Figure with text";
            this.textfigBtn.UseVisualStyleBackColor = true;
            // 
            // emptyFigureBtn
            // 
            this.emptyFigureBtn.Location = new System.Drawing.Point(26, 47);
            this.emptyFigureBtn.Name = "emptyFigureBtn";
            this.emptyFigureBtn.Size = new System.Drawing.Size(75, 48);
            this.emptyFigureBtn.TabIndex = 2;
            this.emptyFigureBtn.Text = "Empty figure";
            this.emptyFigureBtn.UseVisualStyleBackColor = true;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(121, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(20, 22);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plugins";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emptyFigureBtn);
            this.groupBox1.Controls.Add(this.picturefigBtn);
            this.groupBox1.Controls.Add(this.textfigBtn);
            this.groupBox1.Location = new System.Drawing.Point(6, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 359);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figure PlugIn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // PPlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtn);
            this.Name = "PPlugin";
            this.Size = new System.Drawing.Size(146, 494);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button picturefigBtn;
        private System.Windows.Forms.Button textfigBtn;
        private System.Windows.Forms.Button emptyFigureBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}
