using Org.BouncyCastle.Asn1.Crmf;
using System.Xml.Linq;

namespace Medical.cs
{
    partial class AdminSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSettings));
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            MdptextBox = new TextBox();
            EmailtextBox = new TextBox();
            NametextBox = new TextBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            IdtextBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(434, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(354, 339);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(123, 96);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 2;
            button1.Text = "Lancer la recherche";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(36, 318);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Ajouter";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(180, 318);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Editer";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(322, 318);
            button4.Name = "button4";
            button4.Size = new Size(80, 23);
            button4.TabIndex = 6;
            button4.Text = "Supprimer";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 30);
            label1.TabIndex = 7;
            label1.Text = "Paramètres administrateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(36, 75);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 8;
            label2.Text = "Rechercher : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(36, 148);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 9;
            label3.Text = "Nom complet :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(36, 240);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 10;
            label4.Text = "Identifiant : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(36, 182);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 11;
            label5.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(36, 211);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 12;
            label6.Text = "Mot de passe :";
            // 
            // MdptextBox
            // 
            MdptextBox.Location = new Point(123, 203);
            MdptextBox.Name = "MdptextBox";
            MdptextBox.Size = new Size(292, 23);
            MdptextBox.TabIndex = 13;
            MdptextBox.UseSystemPasswordChar = true;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(123, 174);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(292, 23);
            EmailtextBox.TabIndex = 15;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(123, 145);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(292, 23);
            NametextBox.TabIndex = 16;
            NametextBox.TextChanged += NametextBox_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 261);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(292, 23);
            comboBox1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(36, 267);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 18;
            label7.Text = "Rôle :";
            // 
            // IdtextBox
            // 
            IdtextBox.Location = new Point(123, 232);
            IdtextBox.Name = "IdtextBox";
            IdtextBox.Size = new Size(292, 23);
            IdtextBox.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 20;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(77, 353);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 21;
            label9.Text = "label9";
            label9.Click += label9_Click;
            // 
            // AdminSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 454);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(IdtextBox);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(NametextBox);
            Controls.Add(EmailtextBox);
            Controls.Add(MdptextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminSettings";
            Load += AdminSettings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox MdptextBox;
        private TextBox EmailtextBox;
        private TextBox NametextBox;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox IdtextBox;
        private Label label8;
        private Label label9;
    }
}