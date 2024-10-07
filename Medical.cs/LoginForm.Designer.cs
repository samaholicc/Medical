namespace Medical.cs
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            registerbtn = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            IdTextBox = new TextBox();
            MdpTextBox = new TextBox();
            SeconnecterBtn = new Button();
            ForgettenLabel = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(5, 187, 99);
            label1.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(210, 50);
            label1.TabIndex = 0;
            label1.Text = "Bienvenue!";
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(5, 187, 99);
            label2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(18, 89);
            label2.Name = "label2";
            label2.Size = new Size(162, 30);
            label2.TabIndex = 1;
            label2.Text = "Rejoignez-nous.";
            label2.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(5, 187, 99);
            label3.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(18, 119);
            label3.Name = "label3";
            label3.Size = new Size(141, 30);
            label3.TabIndex = 2;
            label3.Text = "Gratuitement!";
            label3.UseMnemonic = false;
            // 
            // registerbtn
            // 
            registerbtn.BackColor = Color.Transparent;
            registerbtn.FlatAppearance.BorderSize = 2;
            registerbtn.FlatStyle = FlatStyle.Flat;
            registerbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerbtn.ForeColor = Color.White;
            registerbtn.Location = new Point(18, 171);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(141, 38);
            registerbtn.TabIndex = 3;
            registerbtn.Text = "Inscription";
            registerbtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(438, 119);
            label4.Name = "label4";
            label4.Size = new Size(204, 50);
            label4.TabIndex = 4;
            label4.Text = "Connexion";
            label4.UseMnemonic = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(438, 173);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 5;
            label5.Text = "Identifiant :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(438, 217);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 6;
            label6.Text = "Mot de passe :";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(439, 191);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(330, 23);
            IdTextBox.TabIndex = 7;
            // 
            // MdpTextBox
            // 
            MdpTextBox.Location = new Point(439, 235);
            MdpTextBox.Name = "MdpTextBox";
            MdpTextBox.Size = new Size(330, 23);
            MdpTextBox.TabIndex = 8;
            MdpTextBox.UseSystemPasswordChar = true;
            // 
            // SeconnecterBtn
            // 
            SeconnecterBtn.BackColor = Color.Transparent;
            SeconnecterBtn.FlatStyle = FlatStyle.System;
            SeconnecterBtn.ForeColor = SystemColors.ControlText;
            SeconnecterBtn.Location = new Point(438, 264);
            SeconnecterBtn.Name = "SeconnecterBtn";
            SeconnecterBtn.Size = new Size(331, 30);
            SeconnecterBtn.TabIndex = 9;
            SeconnecterBtn.Text = "Se connecter";
            SeconnecterBtn.UseVisualStyleBackColor = false;
            SeconnecterBtn.Click += btnLogin_Click;
            // 
            // ForgettenLabel
            // 
            ForgettenLabel.AutoSize = true;
            ForgettenLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForgettenLabel.ForeColor = Color.Crimson;
            ForgettenLabel.Location = new Point(439, 297);
            ForgettenLabel.Name = "ForgettenLabel";
            ForgettenLabel.Size = new Size(122, 15);
            ForgettenLabel.TabIndex = 10;
            ForgettenLabel.Text = "Mot de passe oublié?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Crimson;
            checkBox1.Location = new Point(607, 296);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Montrer le mot de passe";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(836, 400);
            ControlBox = false;
            Controls.Add(checkBox1);
            Controls.Add(ForgettenLabel);
            Controls.Add(SeconnecterBtn);
            Controls.Add(MdpTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(registerbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button registerbtn;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox IdTextBox;
        private TextBox MdpTextBox;
        private Button SeconnecterBtn;
        private Label ForgettenLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox checkBox1;
    }
}