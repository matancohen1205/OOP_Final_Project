namespace WindowsFormsApplication3
{
    partial class entrence_screen_pizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entrence_screen_pizza));
            this.lbl_pizza_restaurant = new System.Windows.Forms.Label();
            this.lbl_ID_Number = new System.Windows.Forms.Label();
            this.lbl_Phone_Number = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_ID_Number = new System.Windows.Forms.TextBox();
            this.txt_phone_number = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_delivery_person = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_costumer_service = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_pizza_restaurant
            // 
            this.lbl_pizza_restaurant.AutoSize = true;
            this.lbl_pizza_restaurant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pizza_restaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_pizza_restaurant.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_pizza_restaurant.Location = new System.Drawing.Point(323, 97);
            this.lbl_pizza_restaurant.Name = "lbl_pizza_restaurant";
            this.lbl_pizza_restaurant.Size = new System.Drawing.Size(753, 120);
            this.lbl_pizza_restaurant.TabIndex = 0;
            this.lbl_pizza_restaurant.Text = "Papa La Pizza";
            // 
            // lbl_ID_Number
            // 
            this.lbl_ID_Number.AutoSize = true;
            this.lbl_ID_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_ID_Number.Location = new System.Drawing.Point(406, 432);
            this.lbl_ID_Number.Name = "lbl_ID_Number";
            this.lbl_ID_Number.Size = new System.Drawing.Size(191, 37);
            this.lbl_ID_Number.TabIndex = 1;
            this.lbl_ID_Number.Text = "ID Number:";
            // 
            // lbl_Phone_Number
            // 
            this.lbl_Phone_Number.AutoSize = true;
            this.lbl_Phone_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_Phone_Number.Location = new System.Drawing.Point(406, 371);
            this.lbl_Phone_Number.Name = "lbl_Phone_Number";
            this.lbl_Phone_Number.Size = new System.Drawing.Size(255, 37);
            this.lbl_Phone_Number.TabIndex = 2;
            this.lbl_Phone_Number.Text = "Phone Number:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_name.Location = new System.Drawing.Point(406, 311);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(117, 37);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name:";
            // 
            // txt_ID_Number
            // 
            this.txt_ID_Number.Location = new System.Drawing.Point(900, 426);
            this.txt_ID_Number.Name = "txt_ID_Number";
            this.txt_ID_Number.Size = new System.Drawing.Size(176, 31);
            this.txt_ID_Number.TabIndex = 4;
            // 
            // txt_phone_number
            // 
            this.txt_phone_number.Location = new System.Drawing.Point(900, 365);
            this.txt_phone_number.Name = "txt_phone_number";
            this.txt_phone_number.Size = new System.Drawing.Size(176, 31);
            this.txt_phone_number.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(900, 305);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(176, 31);
            this.txt_name.TabIndex = 6;
            // 
            // btn_delivery_person
            // 
            this.btn_delivery_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_delivery_person.Location = new System.Drawing.Point(343, 575);
            this.btn_delivery_person.Name = "btn_delivery_person";
            this.btn_delivery_person.Size = new System.Drawing.Size(280, 110);
            this.btn_delivery_person.TabIndex = 8;
            this.btn_delivery_person.Text = "Delivery Person";
            this.btn_delivery_person.UseVisualStyleBackColor = true;
            this.btn_delivery_person.Click += new System.EventHandler(this.btn_delivery_person_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Customer.Location = new System.Drawing.Point(872, 575);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(281, 110);
            this.btn_Customer.TabIndex = 9;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_exit.Location = new System.Drawing.Point(1367, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(152, 64);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_costumer_service
            // 
            this.lbl_costumer_service.AutoSize = true;
            this.lbl_costumer_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_costumer_service.Location = new System.Drawing.Point(322, 805);
            this.lbl_costumer_service.Name = "lbl_costumer_service";
            this.lbl_costumer_service.Size = new System.Drawing.Size(842, 51);
            this.lbl_costumer_service.TabIndex = 11;
            this.lbl_costumer_service.Text = "For join call our costumer service : *3737";
            // 
            // entrence_screen_pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1598, 1033);
            this.Controls.Add(this.lbl_costumer_service);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Customer);
            this.Controls.Add(this.btn_delivery_person);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_phone_number);
            this.Controls.Add(this.txt_ID_Number);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_Phone_Number);
            this.Controls.Add(this.lbl_ID_Number);
            this.Controls.Add(this.lbl_pizza_restaurant);
            this.DoubleBuffered = true;
            this.Name = "entrence_screen_pizza";
            this.Text = "entrence_screen_pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pizza_restaurant;
        private System.Windows.Forms.Label lbl_ID_Number;
        private System.Windows.Forms.Label lbl_Phone_Number;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_ID_Number;
        private System.Windows.Forms.TextBox txt_phone_number;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_delivery_person;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_costumer_service;
    }
}