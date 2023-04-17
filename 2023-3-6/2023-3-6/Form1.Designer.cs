
namespace _2023_3_6
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_button = new System.Windows.Forms.Button();
            this.button_TextBox = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "小魔仙";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "純喫茶";
            // 
            // btn_button
            // 
            this.btn_button.Location = new System.Drawing.Point(398, 64);
            this.btn_button.Name = "btn_button";
            this.btn_button.Size = new System.Drawing.Size(75, 23);
            this.btn_button.TabIndex = 3;
            this.btn_button.Text = "♥";
            this.btn_button.UseVisualStyleBackColor = true;
            this.btn_button.Click += new System.EventHandler(this.btn_button_Click);
            // 
            // button_TextBox
            // 
            this.button_TextBox.Location = new System.Drawing.Point(54, 182);
            this.button_TextBox.Name = "button_TextBox";
            this.button_TextBox.Size = new System.Drawing.Size(75, 23);
            this.button_TextBox.TabIndex = 4;
            this.button_TextBox.Text = "請輸入";
            this.button_TextBox.UseVisualStyleBackColor = true;
            this.button_TextBox.Click += new System.EventHandler(this.button_texBox_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Violet;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Image = global::_2023_3_6.Properties.Resources._163177108852900_P13877757;
            this.label3.Location = new System.Drawing.Point(257, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(780, 795);
            this.label3.TabIndex = 2;
            this.label3.Text = "阿文";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_TextBox);
            this.Controls.Add(this.btn_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_button;
        private System.Windows.Forms.Button button_TextBox;
    }
}

