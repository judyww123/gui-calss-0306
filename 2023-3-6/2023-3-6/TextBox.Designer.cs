
namespace _2023_3_6
{
    partial class TextBox
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.result_1 = new System.Windows.Forms.Label();
            this.result_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(382, 93);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 22);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "+10";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result_1
            // 
            this.result_1.AutoSize = true;
            this.result_1.Location = new System.Drawing.Point(380, 50);
            this.result_1.Name = "result_1";
            this.result_1.Size = new System.Drawing.Size(32, 12);
            this.result_1.TabIndex = 2;
            this.result_1.Text = "結果:";
            // 
            // result_2
            // 
            this.result_2.AutoSize = true;
            this.result_2.Location = new System.Drawing.Point(418, 50);
            this.result_2.Name = "result_2";
            this.result_2.Size = new System.Drawing.Size(24, 12);
            this.result_2.TabIndex = 3;
            this.result_2.Text = "N/A";
            // 
            // TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result_2);
            this.Controls.Add(this.result_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox1);
            this.Name = "TextBox";
            this.Text = "TextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result_1;
        private System.Windows.Forms.Label result_2;
    }
}