namespace SimpleFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            firstName = new TextBox();
            middleName = new TextBox();
            lastName = new TextBox();
            suffix = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(420, 71);
            label1.Name = "label1";
            label1.Size = new Size(291, 26);
            label1.TabIndex = 0;
            label1.Text = "SIMPLE APPLICATION ";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 44);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 191);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Script MT Bold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(271, 155);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 3;
            label3.Text = "First Name ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(271, 255);
            label2.Name = "label2";
            label2.Size = new Size(143, 28);
            label2.TabIndex = 4;
            label2.Text = "Middle Name\r\n";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Script MT Bold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(271, 359);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 5;
            label4.Text = "Last Name\r\n";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Script MT Bold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(271, 465);
            label5.Name = "label5";
            label5.Size = new Size(74, 28);
            label5.TabIndex = 6;
            label5.Text = "Suffix\r\n";
            // 
            // firstName
            // 
            firstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            firstName.ImeMode = ImeMode.NoControl;
            firstName.Location = new Point(429, 155);
            firstName.Name = "firstName";
            firstName.Size = new Size(244, 27);
            firstName.TabIndex = 7;
            // 
            // middleName
            // 
            middleName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            middleName.Location = new Point(429, 255);
            middleName.Name = "middleName";
            middleName.Size = new Size(244, 27);
            middleName.TabIndex = 8;
            // 
            // lastName
            // 
            lastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lastName.Location = new Point(429, 359);
            lastName.Name = "lastName";
            lastName.Size = new Size(244, 27);
            lastName.TabIndex = 9;
            // 
            // suffix
            // 
            suffix.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            suffix.Location = new Point(429, 465);
            suffix.Name = "suffix";
            suffix.Size = new Size(244, 27);
            suffix.TabIndex = 10;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(429, 536);
            button1.Name = "button1";
            button1.Size = new Size(244, 41);
            button1.TabIndex = 12;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1102, 656);
            Controls.Add(button1);
            Controls.Add(suffix);
            Controls.Add(lastName);
            Controls.Add(middleName);
            Controls.Add(firstName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox firstName;
        private TextBox middleName;
        private TextBox lastName;
        private TextBox suffix;
        private Button button1;
    }
}
