
namespace Part1__prime_numb_
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
            this.components = new System.ComponentModel.Container();
            this.Check = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NumbBox = new System.Windows.Forms.TextBox();
            this.ResBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(141, 91);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 34);
            this.Check.TabIndex = 0;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NumbBox
            // 
            this.NumbBox.Location = new System.Drawing.Point(33, 46);
            this.NumbBox.Name = "NumbBox";
            this.NumbBox.Size = new System.Drawing.Size(100, 26);
            this.NumbBox.TabIndex = 2;
            this.NumbBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ResBox
            // 
            this.ResBox.Location = new System.Drawing.Point(33, 147);
            this.ResBox.Name = "ResBox";
            this.ResBox.Size = new System.Drawing.Size(100, 26);
            this.ResBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResBox);
            this.Controls.Add(this.NumbBox);
            this.Controls.Add(this.Check);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox NumbBox;
        private System.Windows.Forms.TextBox ResBox;
    }
}

