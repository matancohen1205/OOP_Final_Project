namespace WindowsFormsApplication3
{
    partial class Database
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
            this.txt_ID_Number = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Phone_Number = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_phone_number = new System.Windows.Forms.Label();
            this.lbl_ID_Number = new System.Windows.Forms.Label();
            this.lbl_member = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_member = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ID_Number
            // 
            this.txt_ID_Number.Location = new System.Drawing.Point(313, 178);
            this.txt_ID_Number.Name = "txt_ID_Number";
            this.txt_ID_Number.Size = new System.Drawing.Size(121, 31);
            this.txt_ID_Number.TabIndex = 1;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(313, 63);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(121, 31);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Phone_Number
            // 
            this.txt_Phone_Number.Location = new System.Drawing.Point(313, 122);
            this.txt_Phone_Number.Name = "txt_Phone_Number";
            this.txt_Phone_Number.Size = new System.Drawing.Size(121, 31);
            this.txt_Phone_Number.TabIndex = 4;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(84, 69);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(74, 25);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_phone_number
            // 
            this.lbl_phone_number.AutoSize = true;
            this.lbl_phone_number.Location = new System.Drawing.Point(84, 128);
            this.lbl_phone_number.Name = "lbl_phone_number";
            this.lbl_phone_number.Size = new System.Drawing.Size(161, 25);
            this.lbl_phone_number.TabIndex = 6;
            this.lbl_phone_number.Text = "Phone Number:";
            // 
            // lbl_ID_Number
            // 
            this.lbl_ID_Number.AutoSize = true;
            this.lbl_ID_Number.Location = new System.Drawing.Point(84, 184);
            this.lbl_ID_Number.Name = "lbl_ID_Number";
            this.lbl_ID_Number.Size = new System.Drawing.Size(119, 25);
            this.lbl_ID_Number.TabIndex = 7;
            this.lbl_ID_Number.Text = "ID Number:";
            // 
            // lbl_member
            // 
            this.lbl_member.AutoSize = true;
            this.lbl_member.Location = new System.Drawing.Point(84, 236);
            this.lbl_member.Name = "lbl_member";
            this.lbl_member.Size = new System.Drawing.Size(96, 25);
            this.lbl_member.TabIndex = 9;
            this.lbl_member.Text = "Member:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(137, 507);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(189, 64);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 933);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(136, 52);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(137, 650);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(184, 75);
            this.btn_remove.TabIndex = 12;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Phone_Number,
            this.ID,
            this.member});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(473, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(1122, 973);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 10;
            this.Name.Name = "Name";
            this.Name.Width = 200;
            // 
            // Phone_Number
            // 
            this.Phone_Number.HeaderText = "Phone Number";
            this.Phone_Number.MinimumWidth = 10;
            this.Phone_Number.Name = "Phone_Number";
            this.Phone_Number.Width = 200;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.Width = 200;
            // 
            // member
            // 
            this.member.HeaderText = "Member";
            this.member.MinimumWidth = 10;
            this.member.Name = "member";
            this.member.Width = 200;
            // 
            // cmb_member
            // 
            this.cmb_member.FormattingEnabled = true;
            this.cmb_member.Items.AddRange(new object[] {
            "",
            "guest",
            "gold",
            "premium",
            "friend",
            "delivery"});
            this.cmb_member.Location = new System.Drawing.Point(313, 228);
            this.cmb_member.Name = "cmb_member";
            this.cmb_member.Size = new System.Drawing.Size(121, 33);
            this.cmb_member.TabIndex = 14;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1607, 997);
            this.Controls.Add(this.cmb_member);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_member);
            this.Controls.Add(this.lbl_ID_Number);
            this.Controls.Add(this.lbl_phone_number);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_Phone_Number);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_ID_Number);
            this.Text = "Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_ID_Number;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Phone_Number;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_phone_number;
        private System.Windows.Forms.Label lbl_ID_Number;
        private System.Windows.Forms.Label lbl_member;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox cmb_member;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn member;
    }
}