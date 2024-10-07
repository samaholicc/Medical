namespace Medical.cs
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            NametextBox = new TextBox();
            IdtextBox = new TextBox();
            EmailtextBox = new TextBox();
            MdptextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(55, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 0;
            label1.Text = "Mon Profil";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(441, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 273);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(42, 141);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "Nom Complet :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(42, 176);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(42, 213);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 4;
            label4.Text = "ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(42, 251);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 4;
            label5.Text = "Mot de passe :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-245, 249);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 4;
            label6.Text = "label4";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-564, 262);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 4;
            label7.Text = "label4";
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(158, 140);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(235, 23);
            NametextBox.TabIndex = 5;
            // 
            // IdtextBox
            // 
            IdtextBox.BackColor = Color.White;
            IdtextBox.Location = new Point(158, 205);
            IdtextBox.Name = "IdtextBox";
            IdtextBox.ReadOnly = true;
            IdtextBox.Size = new Size(235, 23);
            IdtextBox.TabIndex = 6;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(158, 173);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(235, 23);
            EmailtextBox.TabIndex = 7;
            // 
            // MdptextBox
            // 
            MdptextBox.Location = new Point(158, 243);
            MdptextBox.Name = "MdptextBox";
            MdptextBox.Size = new Size(235, 23);
            MdptextBox.TabIndex = 8;
            MdptextBox.UseSystemPasswordChar = true;
            MdptextBox.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(83, 306);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 9;
            button1.Text = "Sauvegarder";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(264, 306);
            button2.Name = "button2";
            button2.Size = new Size(93, 23);
            button2.TabIndex = 10;
            button2.Text = "Déconnexion";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(546, 347);
            button3.Name = "button3";
            button3.Size = new Size(128, 38);
            button3.TabIndex = 11;
            button3.Text = "Changer la photo de profil";
            button3.UseVisualStyleBackColor = true;
            // 
            // UserAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(MdptextBox);
            Controls.Add(EmailtextBox);
            Controls.Add(IdtextBox);
            Controls.Add(NametextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserAccount";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox NametextBox;
        private TextBox IdtextBox;
        private TextBox EmailtextBox;
        private TextBox MdptextBox;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}