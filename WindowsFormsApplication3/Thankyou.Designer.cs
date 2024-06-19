namespace WindowsFormsApplication3
{
    partial class Thankyou
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thankyou));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start_page = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 25.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(855, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank you for your order!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(200, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(875, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "We are now working on your order!";
            // 
            // btn_start_page
            // 
            this.btn_start_page.Location = new System.Drawing.Point(12, 904);
            this.btn_start_page.Name = "btn_start_page";
            this.btn_start_page.Size = new System.Drawing.Size(359, 73);
            this.btn_start_page.TabIndex = 2;
            this.btn_start_page.Text = "Start Page";
            this.btn_start_page.UseVisualStyleBackColor = true;
            this.btn_start_page.Click += new System.EventHandler(this.btn_start_page_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(16, 78);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Thankyou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 989);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_start_page);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Thankyou";
            this.Text = "Thankyou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_start_page;
        private System.Windows.Forms.Button button2;
    }
}