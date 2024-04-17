namespace _11ab1
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
            this.scrollBar = new System.Windows.Forms.HScrollBar();
            this.lblSumLoop = new System.Windows.Forms.RichTextBox();
            this.lblSumFormula = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // scrollBar
            // 
            this.scrollBar.LargeChange = 1;
            this.scrollBar.Location = new System.Drawing.Point(177, 55);
            this.scrollBar.Minimum = 1;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(396, 52);
            this.scrollBar.TabIndex = 0;
            this.scrollBar.Value = 1;
            this.scrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // lblSumLoop
            // 
            this.lblSumLoop.Location = new System.Drawing.Point(177, 166);
            this.lblSumLoop.Name = "lblSumLoop";
            this.lblSumLoop.Size = new System.Drawing.Size(108, 52);
            this.lblSumLoop.TabIndex = 1;
            this.lblSumLoop.Text = "";
            // 
            // lblSumFormula
            // 
            this.lblSumFormula.Location = new System.Drawing.Point(465, 168);
            this.lblSumFormula.Name = "lblSumFormula";
            this.lblSumFormula.Size = new System.Drawing.Size(108, 50);
            this.lblSumFormula.TabIndex = 2;
            this.lblSumFormula.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(360, 249);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(62, 23);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblSumFormula);
            this.Controls.Add(this.lblSumLoop);
            this.Controls.Add(this.scrollBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar scrollBar;
        private System.Windows.Forms.RichTextBox lblSumLoop;
        private System.Windows.Forms.RichTextBox lblSumFormula;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

