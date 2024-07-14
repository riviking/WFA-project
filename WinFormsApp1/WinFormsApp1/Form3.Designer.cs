namespace WinFormsApp1
{
    partial class Form3
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
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(193, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 149);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Bisque;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(10, 94);
            label2.Name = "label2";
            label2.Size = new Size(353, 49);
            label2.TabIndex = 2;
            label2.Text = "Stock Manager DB";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 10);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._1714455399250;
            pictureBox1.Location = new Point(94, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 89);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Aquamarine;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(193, 199);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 149);
            panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.download;
            pictureBox3.Location = new Point(0, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(372, 74);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources._20221131_836741_577551_71;
            pictureBox2.Location = new Point(48, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(282, 38);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(-4, 97);
            label3.Name = "label3";
            label3.Size = new Size(387, 54);
            label3.TabIndex = 0;
            label3.Text = "Price list of All items";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCoral;
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(193, 383);
            panel3.Name = "panel3";
            panel3.Size = new Size(372, 149);
            panel3.TabIndex = 2;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.megaphone_loudspeaker_making_announcement_vector2;
            pictureBox5.Location = new Point(62, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(129, 100);
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.megaphone_loudspeaker_making_announcement_vector1;
            pictureBox4.Location = new Point(189, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(129, 100);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Moccasin;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(21, 95);
            label4.Name = "label4";
            label4.Size = new Size(319, 54);
            label4.TabIndex = 4;
            label4.Text = "announcements";
            label4.Click += label4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 558);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Form3";
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label4;
    }
}