namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.q = new System.Windows.Forms.Button();
            this.w = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.y = new System.Windows.Forms.Button();
            this.u = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // q
            // 
            this.q.Location = new System.Drawing.Point(46, 29);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(75, 23);
            this.q.TabIndex = 0;
            this.q.Text = "q";
            this.q.UseVisualStyleBackColor = true;
            // 
            // w
            // 
            this.w.Location = new System.Drawing.Point(170, 29);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(75, 23);
            this.w.TabIndex = 1;
            this.w.Text = "w";
            this.w.UseVisualStyleBackColor = true;
            // 
            // e
            // 
            this.e.Location = new System.Drawing.Point(294, 28);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(75, 23);
            this.e.TabIndex = 2;
            this.e.Text = "e";
            this.e.UseVisualStyleBackColor = true;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(46, 140);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(75, 23);
            this.y.TabIndex = 3;
            this.y.Text = "y";
            this.y.UseVisualStyleBackColor = true;
            // 
            // u
            // 
            this.u.Location = new System.Drawing.Point(170, 140);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(75, 23);
            this.u.TabIndex = 4;
            this.u.Text = "u";
            this.u.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 262);
            this.Controls.Add(this.u);
            this.Controls.Add(this.y);
            this.Controls.Add(this.e);
            this.Controls.Add(this.w);
            this.Controls.Add(this.q);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button q;
        private System.Windows.Forms.Button w;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button y;
        private System.Windows.Forms.Button u;
    }
}

