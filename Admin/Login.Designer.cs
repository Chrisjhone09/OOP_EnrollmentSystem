namespace OOP
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel4 = new Panel();
            validationText = new Label();
            button1 = new Button();
            panel6 = new Panel();
            password = new TextBox();
            panel5 = new Panel();
            label3 = new Label();
            username = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.9166679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.0833321F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(684, 467);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(4, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 217);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(331, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 306);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(validationText);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(password);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(username);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 101);
            panel4.Name = "panel4";
            panel4.Size = new Size(349, 205);
            panel4.TabIndex = 1;
            // 
            // validationText
            // 
            validationText.AutoSize = true;
            validationText.ForeColor = Color.FromArgb(192, 0, 0);
            validationText.Location = new Point(55, 146);
            validationText.Name = "validationText";
            validationText.Size = new Size(164, 15);
            validationText.TabIndex = 8;
            validationText.Text = "Invalid username or password";
            validationText.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(55, 169);
            button1.Name = "button1";
            button1.Size = new Size(243, 33);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Purple;
            panel6.Location = new Point(55, 140);
            panel6.Name = "panel6";
            panel6.Size = new Size(243, 1);
            panel6.TabIndex = 6;
            // 
            // password
            // 
            password.BackColor = SystemColors.Control;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(55, 112);
            password.Name = "password";
            password.Size = new Size(243, 23);
            password.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Purple;
            panel5.Location = new Point(55, 75);
            panel5.Name = "panel5";
            panel5.Size = new Size(243, 1);
            panel5.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(52, 89);
            label3.Name = "label3";
            label3.Size = new Size(68, 24);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // username
            // 
            username.BackColor = SystemColors.Control;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(55, 46);
            username.Name = "username";
            username.Size = new Size(243, 23);
            username.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(52, 23);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(349, 101);
            panel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(123, 66);
            label4.Name = "label4";
            label4.Size = new Size(115, 24);
            label4.TabIndex = 1;
            label4.Text = "Login to proceed";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(93, 24);
            label1.Name = "label1";
            label1.Size = new Size(181, 56);
            label1.TabIndex = 0;
            label1.Text = "WELCOME";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 467);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private TextBox username;
        private Button button1;
        private Panel panel6;
        private TextBox password;
        private Label label3;
        private Label label4;
        private Label validationText;
    }
}