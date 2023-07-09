namespace WinFormsApp1
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            textBox7 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            label3 = new Label();
            groupBox4 = new GroupBox();
            textBox11 = new TextBox();
            label8 = new Label();
            button4 = new Button();
            label9 = new Label();
            textBox12 = new TextBox();
            label10 = new Label();
            textBox13 = new TextBox();
            listBox2 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(6, 80);
            button1.Name = "button1";
            button1.Size = new Size(383, 23);
            button1.TabIndex = 2;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(383, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 144);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Sonuç : ";
            // 
            // button2
            // 
            button2.Location = new Point(6, 109);
            button2.Name = "button2";
            button2.Size = new Size(383, 23);
            button2.TabIndex = 3;
            button2.Text = "Double";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(383, 23);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 51);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(383, 23);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 80);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(383, 23);
            textBox5.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 114);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hesaplama İşlemi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Location = new Point(12, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(399, 179);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Not İşlemi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 144);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 3;
            label2.Text = "Label";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(12, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(399, 350);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sınav Notu İşlemi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(231, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(8, 178);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(387, 154);
            listBox1.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(61, 48);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(149, 23);
            textBox7.TabIndex = 4;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(299, 120);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(90, 23);
            textBox10.TabIndex = 4;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(189, 123);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(44, 23);
            textBox9.TabIndex = 4;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(75, 120);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(44, 23);
            textBox8.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(250, 123);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 6;
            label7.Text = "Proje : ";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(61, 16);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(149, 23);
            textBox6.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 123);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 6;
            label6.Text = "Sınav 2 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 51);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Soyadı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 123);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 6;
            label5.Text = "Sınav : 1";
            // 
            // button3
            // 
            button3.Location = new Point(8, 149);
            button3.Name = "button3";
            button3.Size = new Size(383, 23);
            button3.TabIndex = 5;
            button3.Text = "Hesapla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 19);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 6;
            label3.Text = "Adı";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listBox2);
            groupBox4.Controls.Add(textBox12);
            groupBox4.Controls.Add(textBox13);
            groupBox4.Controls.Add(textBox11);
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Location = new Point(425, 20);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(398, 291);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ürün Kdv İşlemi";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(71, 14);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(318, 23);
            textBox11.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 19);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 3;
            label8.Text = "Ürün";
            // 
            // button4
            // 
            button4.Location = new Point(6, 98);
            button4.Name = "button4";
            button4.Size = new Size(383, 23);
            button4.TabIndex = 2;
            button4.Text = "Hesapla";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 46);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 3;
            label9.Text = "Fiyat";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(71, 43);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(318, 23);
            textBox12.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 77);
            label10.Name = "label10";
            label10.Size = new Size(27, 15);
            label10.TabIndex = 3;
            label10.Text = "Kdv";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(71, 69);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(318, 23);
            textBox13.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(6, 127);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(383, 154);
            listBox2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 679);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hesaplama İşlemi";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private GroupBox groupBox3;
        private ListBox listBox1;
        private TextBox textBox7;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label label7;
        private TextBox textBox6;
        private Label label6;
        private Label label4;
        private Label label5;
        private Button button3;
        private Label label3;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
        private TextBox textBox11;
        private Label label8;
        private Button button4;
        private TextBox textBox12;
        private Label label10;
        private Label label9;
        private ListBox listBox2;
        private TextBox textBox13;
    }
}