namespace WinFormsApp1
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Segoe UI", 13.8F);
            button1.Location = new Point(6, 23);
            button1.Name = "button1";
            button1.Size = new Size(108, 45);
            button1.TabIndex = 0;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Font = new Font("Segoe UI", 13.8F);
            button2.Location = new Point(6, 161);
            button2.Name = "button2";
            button2.Size = new Size(108, 45);
            button2.TabIndex = 1;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 13.8F);
            button3.Location = new Point(6, 91);
            button3.Name = "button3";
            button3.Size = new Size(108, 45);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(990, 98);
            label1.Name = "label1";
            label1.Size = new Size(88, 31);
            label1.TabIndex = 3;
            label1.Text = "item ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(990, 173);
            label2.Name = "label2";
            label2.Size = new Size(123, 31);
            label2.TabIndex = 4;
            label2.Text = "item name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(17, 160);
            label3.Name = "label3";
            label3.Size = new Size(164, 31);
            label3.TabIndex = 5;
            label3.Text = "stock available";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(17, 235);
            label4.Name = "label4";
            label4.Size = new Size(144, 31);
            label4.TabIndex = 6;
            label4.Text = "current price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(17, 310);
            label5.Name = "label5";
            label5.Size = new Size(151, 31);
            label5.TabIndex = 7;
            label5.Text = "manufacturer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(17, 385);
            label6.Name = "label6";
            label6.Size = new Size(213, 31);
            label6.TabIndex = 8;
            label6.Text = "manufacturer Email";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F);
            textBox1.Location = new Point(1005, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 38);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F);
            textBox2.Location = new Point(1005, 207);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 38);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F);
            textBox3.Location = new Point(30, 194);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 38);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13.8F);
            textBox4.Location = new Point(32, 269);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 38);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 13.8F);
            textBox5.Location = new Point(32, 344);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(215, 38);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 13.8F);
            textBox6.Location = new Point(32, 419);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(215, 38);
            textBox6.TabIndex = 14;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(931, 605);
            dataGridView1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(973, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 529);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(1260, 207);
            panel2.Name = "panel2";
            panel2.Size = new Size(125, 217);
            panel2.TabIndex = 17;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumSlateBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.MediumBlue;
            button4.Location = new Point(973, 12);
            button4.Name = "button4";
            button4.Size = new Size(281, 41);
            button4.TabIndex = 18;
            button4.Text = "Back To Home Page";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 635);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form2";
            Text = "stock manager";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Button button4;
    }
}