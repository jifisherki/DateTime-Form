namespace DateTime_Form
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxDYear = new System.Windows.Forms.TextBox();
            this.textBoxDMonth = new System.Windows.Forms.TextBox();
            this.textBoxDDay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDDay = new System.Windows.Forms.Button();
            this.buttonDMonth = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.labelEqual = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxDYear2 = new System.Windows.Forms.TextBox();
            this.textBoxDMonth2 = new System.Windows.Forms.TextBox();
            this.textBoxDDay2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxYear2 = new System.Windows.Forms.TextBox();
            this.textBoxMonth2 = new System.Windows.Forms.TextBox();
            this.textBoxSecond2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelDate2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Секунда месяца";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(514, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 26);
            this.label13.TabIndex = 22;
            this.label13.Text = "Секунда месяца";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelDate.Location = new System.Drawing.Point(15, 15);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 15);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "label1";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер месяца";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Номер года";
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Location = new System.Drawing.Point(13, 60);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(112, 20);
            this.textBoxSecond.TabIndex = 5;
            this.textBoxSecond.TextChanged += new System.EventHandler(this.textBoxSecond_TextChanged);
            this.textBoxSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateBoxesKeyPress);
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(12, 159);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(112, 20);
            this.textBoxMonth.TabIndex = 7;
            this.textBoxMonth.TextChanged += new System.EventHandler(this.textBoxMonth_TextChanged);
            this.textBoxMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateBoxesKeyPress);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(13, 254);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(112, 20);
            this.textBoxYear.TabIndex = 8;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateBoxesKeyPress);
            // 
            // textBoxDYear
            // 
            this.textBoxDYear.Location = new System.Drawing.Point(12, 310);
            this.textBoxDYear.Name = "textBoxDYear";
            this.textBoxDYear.Size = new System.Drawing.Size(112, 20);
            this.textBoxDYear.TabIndex = 14;
            this.textBoxDYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dDateBoxesKeyPress);
            // 
            // textBoxDMonth
            // 
            this.textBoxDMonth.Location = new System.Drawing.Point(12, 206);
            this.textBoxDMonth.Name = "textBoxDMonth";
            this.textBoxDMonth.Size = new System.Drawing.Size(112, 20);
            this.textBoxDMonth.TabIndex = 13;
            this.textBoxDMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dDateBoxesKeyPress);
            // 
            // textBoxDDay
            // 
            this.textBoxDDay.Location = new System.Drawing.Point(12, 109);
            this.textBoxDDay.Name = "textBoxDDay";
            this.textBoxDDay.Size = new System.Drawing.Size(112, 20);
            this.textBoxDDay.TabIndex = 12;
            this.textBoxDDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dDateBoxesKeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Разница в годах";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Разница в месяцах";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Разница в днях";
            // 
            // buttonDDay
            // 
            this.buttonDDay.Location = new System.Drawing.Point(149, 100);
            this.buttonDDay.Name = "buttonDDay";
            this.buttonDDay.Size = new System.Drawing.Size(85, 28);
            this.buttonDDay.TabIndex = 15;
            this.buttonDDay.Text = "Добавить";
            this.buttonDDay.UseVisualStyleBackColor = true;
            this.buttonDDay.Click += new System.EventHandler(this.buttonDDay_Click);
            // 
            // buttonDMonth
            // 
            this.buttonDMonth.Location = new System.Drawing.Point(149, 201);
            this.buttonDMonth.Name = "buttonDMonth";
            this.buttonDMonth.Size = new System.Drawing.Size(85, 28);
            this.buttonDMonth.TabIndex = 16;
            this.buttonDMonth.Text = "Добавить";
            this.buttonDMonth.UseVisualStyleBackColor = true;
            this.buttonDMonth.Click += new System.EventHandler(this.buttonDMonth_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Сравнить даты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label8.Location = new System.Drawing.Point(194, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 19;
            // 
            // labelEqual
            // 
            this.labelEqual.AutoSize = true;
            this.labelEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelEqual.Location = new System.Drawing.Point(303, 410);
            this.labelEqual.Name = "labelEqual";
            this.labelEqual.Size = new System.Drawing.Size(41, 15);
            this.labelEqual.TabIndex = 20;
            this.labelEqual.Text = "label1";
            this.labelEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 28);
            this.button3.TabIndex = 36;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(410, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 28);
            this.button4.TabIndex = 35;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(410, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 28);
            this.button5.TabIndex = 34;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxDYear2
            // 
            this.textBoxDYear2.Location = new System.Drawing.Point(513, 310);
            this.textBoxDYear2.Name = "textBoxDYear2";
            this.textBoxDYear2.Size = new System.Drawing.Size(112, 20);
            this.textBoxDYear2.TabIndex = 33;
            // 
            // textBoxDMonth2
            // 
            this.textBoxDMonth2.Location = new System.Drawing.Point(513, 206);
            this.textBoxDMonth2.Name = "textBoxDMonth2";
            this.textBoxDMonth2.Size = new System.Drawing.Size(112, 20);
            this.textBoxDMonth2.TabIndex = 32;
            // 
            // textBoxDDay2
            // 
            this.textBoxDDay2.Location = new System.Drawing.Point(513, 109);
            this.textBoxDDay2.Name = "textBoxDDay2";
            this.textBoxDDay2.Size = new System.Drawing.Size(112, 20);
            this.textBoxDDay2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(513, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Разница в годах";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(513, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 26);
            this.label9.TabIndex = 29;
            this.label9.Text = "Разница в месяцах";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(513, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 26);
            this.label10.TabIndex = 28;
            this.label10.Text = "Разница в днях";
            // 
            // textBoxYear2
            // 
            this.textBoxYear2.Location = new System.Drawing.Point(514, 254);
            this.textBoxYear2.Name = "textBoxYear2";
            this.textBoxYear2.Size = new System.Drawing.Size(112, 20);
            this.textBoxYear2.TabIndex = 27;
            this.textBoxYear2.TextChanged += new System.EventHandler(this.textBoxYear2_TextChanged);
            // 
            // textBoxMonth2
            // 
            this.textBoxMonth2.Location = new System.Drawing.Point(513, 159);
            this.textBoxMonth2.Name = "textBoxMonth2";
            this.textBoxMonth2.Size = new System.Drawing.Size(112, 20);
            this.textBoxMonth2.TabIndex = 26;
            this.textBoxMonth2.TextChanged += new System.EventHandler(this.textBoxMonth2_TextChanged);
            // 
            // textBoxSecond2
            // 
            this.textBoxSecond2.Location = new System.Drawing.Point(514, 60);
            this.textBoxSecond2.Name = "textBoxSecond2";
            this.textBoxSecond2.Size = new System.Drawing.Size(112, 20);
            this.textBoxSecond2.TabIndex = 25;
            this.textBoxSecond2.TextChanged += new System.EventHandler(this.textBoxSecond2_TextChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(514, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 26);
            this.label11.TabIndex = 24;
            this.label11.Text = "Номер года";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(513, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 26);
            this.label12.TabIndex = 23;
            this.label12.Text = "Номер месяца";
            // 
            // labelDate2
            // 
            this.labelDate2.AutoSize = true;
            this.labelDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelDate2.Location = new System.Drawing.Point(516, 15);
            this.labelDate2.Name = "labelDate2";
            this.labelDate2.Size = new System.Drawing.Size(41, 15);
            this.labelDate2.TabIndex = 21;
            this.labelDate2.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBoxDYear2);
            this.Controls.Add(this.textBoxDMonth2);
            this.Controls.Add(this.textBoxDDay2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxYear2);
            this.Controls.Add(this.textBoxMonth2);
            this.Controls.Add(this.textBoxSecond2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelDate2);
            this.Controls.Add(this.labelEqual);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDMonth);
            this.Controls.Add(this.buttonDDay);
            this.Controls.Add(this.textBoxDYear);
            this.Controls.Add(this.textBoxDMonth);
            this.Controls.Add(this.textBoxDDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonDDay;
        private System.Windows.Forms.TextBox textBoxDDay;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDate2;
        private System.Windows.Forms.TextBox textBoxDMonth2;
        private System.Windows.Forms.TextBox textBoxDDay2;
        private System.Windows.Forms.TextBox textBoxDYear2;
        private System.Windows.Forms.TextBox textBoxMonth2;
        private System.Windows.Forms.TextBox textBoxYear2;

        private System.Windows.Forms.TextBox textBoxSecond2;

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label labelEqual;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDMonth;
        private System.Windows.Forms.TextBox textBoxDMonth;
        private System.Windows.Forms.TextBox textBoxDYear;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.TextBox textBoxYear;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label labelDate;

        #endregion
    }
}