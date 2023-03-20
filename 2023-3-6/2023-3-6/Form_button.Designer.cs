
namespace _2023_3_6
{
    partial class Form_button
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
            this.btn_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_button1
            // 
            this.btn_button1.Location = new System.Drawing.Point(425, 70);
            this.btn_button1.Name = "btn_button1";
            this.btn_button1.Size = new System.Drawing.Size(75, 23);
            this.btn_button1.TabIndex = 0;
            this.btn_button1.Text = "請再按一次";
            this.btn_button1.UseVisualStyleBackColor = true;
            this.btn_button1.Click += new System.EventHandler(this.btn_button1_Click);
            // 
            // Form_button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_button1);
            this.Name = "Form_button";
            this.Text = "Form_button";
            this.Load += new System.EventHandler(this.Form_button_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_button1;
    }
}