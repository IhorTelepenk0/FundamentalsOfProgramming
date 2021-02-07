
namespace Part2__calc_
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
            this.Op1 = new System.Windows.Forms.TextBox();
            this.Op2 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.ResBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Op1
            // 
            this.Op1.Location = new System.Drawing.Point(83, 47);
            this.Op1.Name = "Op1";
            this.Op1.Size = new System.Drawing.Size(100, 26);
            this.Op1.TabIndex = 0;
            // 
            // Op2
            // 
            this.Op2.Location = new System.Drawing.Point(83, 112);
            this.Op2.Name = "Op2";
            this.Op2.Size = new System.Drawing.Size(100, 26);
            this.Op2.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(64, 215);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(44, 38);
            this.add.TabIndex = 2;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(134, 215);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(38, 38);
            this.Sub.TabIndex = 3;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mult
            // 
            this.Mult.Location = new System.Drawing.Point(227, 215);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(39, 38);
            this.Mult.TabIndex = 4;
            this.Mult.Text = "x";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(292, 215);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(45, 39);
            this.Div.TabIndex = 5;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // ResBox
            // 
            this.ResBox.Location = new System.Drawing.Point(83, 282);
            this.ResBox.Name = "ResBox";
            this.ResBox.Size = new System.Drawing.Size(100, 26);
            this.ResBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.ResBox);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Op2);
            this.Controls.Add(this.Op1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Op1;
        private System.Windows.Forms.TextBox Op2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.TextBox ResBox;
    }
}

