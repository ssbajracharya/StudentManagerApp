namespace StudentManagerApp
{
    partial class AddStudentForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            comboMonth = new ComboBox();
            comboGrade = new ComboBox();
            btnSubmit = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(430, 155);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(432, 216);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(430, 297);
            label3.Name = "label3";
            label3.Size = new Size(133, 32);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(432, 378);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(432, 453);
            label5.Name = "label5";
            label5.Size = new Size(248, 32);
            label5.TabIndex = 4;
            label5.Text = "Month of Admission";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(432, 519);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 5;
            label6.Text = "Grade";
            // 
            // txtId
            // 
            txtId.Location = new Point(737, 157);
            txtId.Name = "txtId";
            txtId.Size = new Size(189, 31);
            txtId.TabIndex = 6;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(737, 221);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(189, 31);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(737, 302);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(189, 31);
            txtLastName.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(737, 374);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(189, 31);
            txtAddress.TabIndex = 9;
            // 
            // comboMonth
            // 
            comboMonth.FormattingEnabled = true;
            comboMonth.Location = new Point(737, 452);
            comboMonth.Name = "comboMonth";
            comboMonth.Size = new Size(189, 33);
            comboMonth.TabIndex = 10;
            // 
            // comboGrade
            // 
            comboGrade.FormattingEnabled = true;
            comboGrade.Items.AddRange(new object[] { "A", "B", "C", "D", "F" });
            comboGrade.Location = new Point(737, 521);
            comboGrade.Name = "comboGrade";
            comboGrade.Size = new Size(189, 33);
            comboGrade.TabIndex = 11;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(569, 702);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(215, 53);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(578, 64);
            label7.Name = "label7";
            label7.Size = new Size(258, 32);
            label7.TabIndex = 13;
            label7.Text = "ADD STUDENT FORM";
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 860);
            Controls.Add(label7);
            Controls.Add(btnSubmit);
            Controls.Add(comboGrade);
            Controls.Add(comboMonth);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            Load += AddStudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private ComboBox comboMonth;
        private ComboBox comboGrade;
        private Button btnSubmit;
        private Label label7;
    }
}