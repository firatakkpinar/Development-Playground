namespace proje_bufe_satis
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 236);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adetler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 53);
            label1.Name = "label1";
            label1.Size = new Size(54, 26);
            label1.TabIndex = 0;
            label1.Text = "Bilet";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 93);
            label2.Name = "label2";
            label2.Size = new Size(37, 26);
            label2.TabIndex = 2;
            label2.Text = "Su";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(107, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 34);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 130);
            label3.Name = "label3";
            label3.Size = new Size(48, 26);
            label3.TabIndex = 4;
            label3.Text = "Çay";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(107, 169);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 34);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 172);
            label4.Name = "label4";
            label4.Size = new Size(60, 26);
            label4.TabIndex = 6;
            label4.Text = "Mısır";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LemonChiffon;
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(321, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(291, 236);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fiyatlar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 50);
            label5.Name = "label5";
            label5.Size = new Size(123, 104);
            label5.TabIndex = 1;
            label5.Text = " Bilet:70 TL\r\n      Su:5 TL\r\n  Çay:10 TL\r\nMısır:30 TL";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.PaleGreen;
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(630, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(291, 236);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kasa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(113, 41);
            label6.Name = "label6";
            label6.Size = new Size(67, 26);
            label6.TabIndex = 10;
            label6.Text = "00 TL";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 41);
            label7.Name = "label7";
            label7.Size = new Size(88, 26);
            label7.TabIndex = 11;
            label7.Text = "Toplam:";
            // 
            // button1
            // 
            button1.Location = new Point(45, 70);
            button1.Name = "button1";
            button1.Size = new Size(135, 49);
            button1.TabIndex = 12;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 177);
            label8.Name = "label8";
            label8.Size = new Size(150, 26);
            label8.TabIndex = 13;
            label8.Text = "Kasadaki Para:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(177, 177);
            label9.Name = "label9";
            label9.Size = new Size(67, 26);
            label9.TabIndex = 14;
            label9.Text = "00 TL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 458);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Büfe Sinema";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private Label label5;
        private GroupBox groupBox3;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Button button1;
    }
}