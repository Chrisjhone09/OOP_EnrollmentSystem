namespace OOP
{
    partial class ApprovalForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            panel4 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            panel6 = new Panel();
            phone = new Label();
            email = new Label();
            birthday = new Label();
            address = new Label();
            sex = new Label();
            age = new Label();
            chosenProgram = new Label();
            program = new Label();
            studentName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 529);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 439);
            panel2.Name = "panel2";
            panel2.Size = new Size(447, 90);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(246, 21);
            button2.Name = "button2";
            button2.Size = new Size(86, 32);
            button2.TabIndex = 1;
            button2.Text = "Reject";
            button2.UseVisualStyleBackColor = false;
            button2.Click += async (sender, e) => await Reject_Click(sender, e);
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(338, 21);
            button1.Name = "button1";
            button1.Size = new Size(86, 32);
            button1.TabIndex = 0;
            button1.Text = "Approve";
            button1.UseVisualStyleBackColor = false;
            button1.Click += async (sender, e) => await Approve_Click(sender, e);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.7030563F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.2969437F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(447, 439);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            panel3.Size = new Size(180, 433);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(20, 145);
            panel4.Name = "panel4";
            panel4.Size = new Size(140, 268);
            panel4.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Purple;
            label8.Location = new Point(84, 239);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 10;
            label8.Text = "Phone";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Purple;
            label9.Location = new Point(90, 208);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 9;
            label9.Text = "Email";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Purple;
            label7.Location = new Point(68, 167);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 7;
            label7.Text = "Birthday";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Purple;
            label5.Location = new Point(71, 129);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 6;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(104, 92);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 5;
            label4.Text = "Sex";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Purple;
            label6.Location = new Point(100, 55);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 4;
            label6.Text = "Age";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(13, 20);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 1;
            label3.Text = "Chosen program";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(189, 3);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20);
            panel5.Size = new Size(255, 433);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.AutoSize = true;
            panel6.Controls.Add(phone);
            panel6.Controls.Add(email);
            panel6.Controls.Add(birthday);
            panel6.Controls.Add(address);
            panel6.Controls.Add(sex);
            panel6.Controls.Add(age);
            panel6.Controls.Add(chosenProgram);
            panel6.Controls.Add(program);
            panel6.Controls.Add(studentName);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(20, 20);
            panel6.Name = "panel6";
            panel6.Size = new Size(215, 393);
            panel6.TabIndex = 0;
            // 
            // phone
            // 
            phone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            phone.AutoSize = true;
            phone.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phone.ForeColor = Color.Black;
            phone.Location = new Point(21, 364);
            phone.Name = "phone";
            phone.Size = new Size(110, 20);
            phone.TabIndex = 8;
            phone.Text = "Student Name";
            // 
            // email
            // 
            email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.Black;
            email.Location = new Point(21, 333);
            email.Name = "email";
            email.Size = new Size(110, 20);
            email.TabIndex = 7;
            email.Text = "Student Name";
            // 
            // birthday
            // 
            birthday.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            birthday.AutoSize = true;
            birthday.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            birthday.ForeColor = Color.Black;
            birthday.Location = new Point(21, 292);
            birthday.Name = "birthday";
            birthday.Size = new Size(110, 20);
            birthday.TabIndex = 6;
            birthday.Text = "Student Name";
            // 
            // address
            // 
            address.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            address.AutoSize = true;
            address.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address.ForeColor = Color.Black;
            address.Location = new Point(21, 254);
            address.Name = "address";
            address.Size = new Size(110, 20);
            address.TabIndex = 5;
            address.Text = "Student Name";
            // 
            // sex
            // 
            sex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sex.AutoSize = true;
            sex.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sex.ForeColor = Color.Black;
            sex.Location = new Point(21, 217);
            sex.Name = "sex";
            sex.Size = new Size(110, 20);
            sex.TabIndex = 4;
            sex.Text = "Student Name";
            // 
            // age
            // 
            age.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            age.AutoSize = true;
            age.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            age.ForeColor = Color.Black;
            age.Location = new Point(21, 180);
            age.Name = "age";
            age.Size = new Size(110, 20);
            age.TabIndex = 3;
            age.Text = "Student Name";
            // 
            // chosenProgram
            // 
            chosenProgram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chosenProgram.AutoSize = true;
            chosenProgram.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chosenProgram.ForeColor = Color.Black;
            chosenProgram.Location = new Point(21, 145);
            chosenProgram.Name = "chosenProgram";
            chosenProgram.Size = new Size(110, 20);
            chosenProgram.TabIndex = 2;
            chosenProgram.Text = "Student Name";
            // 
            // program
            // 
            program.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            program.AutoSize = true;
            program.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            program.ForeColor = Color.Black;
            program.Location = new Point(21, 54);
            program.Name = "program";
            program.Size = new Size(110, 20);
            program.TabIndex = 1;
            program.Text = "Student Name";
            // 
            // studentName
            // 
            studentName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentName.AutoSize = true;
            studentName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentName.ForeColor = Color.Purple;
            studentName.Location = new Point(21, 29);
            studentName.Name = "studentName";
            studentName.Size = new Size(140, 25);
            studentName.TabIndex = 0;
            studentName.Text = "Student Name";
            // 
            // ApprovalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(447, 529);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ApprovalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApprovalForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel6;
        private Label studentName;
        private Label label6;
        private Label label3;
        private Label program;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label4;
        private Button button1;
        private Label label8;
        private Button button2;
        private Label phone;
        private Label email;
        private Label birthday;
        private Label address;
        private Label sex;
        private Label age;
        private Label chosenProgram;
    }
}