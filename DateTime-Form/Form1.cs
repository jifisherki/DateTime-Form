using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Form
{
    public partial class Form1 : Form
    {
        private DateTime _dateTime1;
        private DateTime _dateTime2;

        public Form1()
        {
            InitializeComponent();
        }

        private void dateBoxesKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dDateBoxesKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelEqual.Text = "";
            _dateTime1 = new DateTime();
            _dateTime2 = new DateTime();
            changeFields();
            changeFields2();
        }

        private void changeFields()
        {
            textBoxSecond.Text = _dateTime1.seconds.ToString();
            textBoxMonth.Text = _dateTime1.month.ToString();
            textBoxYear.Text = _dateTime1.year.ToString();
            labelDate.Text = _dateTime1.ToString();
        }

        private void changeFields2()
        {
            textBoxSecond2.Text = _dateTime2.seconds.ToString();
            textBoxMonth2.Text = _dateTime2.month.ToString();
            textBoxYear2.Text = _dateTime2.year.ToString();
            labelDate2.Text = _dateTime2.ToString();
        }

        private void buttonDDay_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDDay.Text.Length == 0) return;
                _dateTime1.AddDays(int.Parse(textBoxDDay.Text));
                changeFields();
            }
            catch (InvalidDataException exception)
            {
                labelDate.Text = exception.Message;
            }
            catch (Exception exception)
            {
                labelDate.Text = "Непредвиденная ошибка";
            }
        }

        private void buttonDMonth_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDMonth.Text.Length == 0) return;
                _dateTime1.AddMonths(int.Parse(textBoxDMonth.Text));
                changeFields();
            }
            catch (InvalidDataException exception)
            {
                labelDate.Text = exception.Message;
            }
            catch (Exception exception)
            {
                labelDate.Text = "Непредвиденная ошибка";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDYear.Text.Length == 0) return;
                _dateTime1.AddYears(int.Parse(textBoxDYear.Text));
                changeFields();
            }
            catch (InvalidDataException exception)
            {
                labelDate.Text = exception.Message;
            }
            catch (Exception exception)
            {
                labelDate.Text = "Непредвиденная ошибка";
            }
        }

        private void textBoxSecond_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSecond.Text.Length == 0) return;
            try
            {
                _dateTime1 = new DateTime(
                    int.Parse(textBoxSecond.Text),
                    _dateTime1.month,
                    _dateTime1.year);
                changeFields();
            }
            catch (InvalidDataException exception)
            {
                labelDate.Text = exception.Message;
            }
            catch (Exception exception)
            {
                labelDate.Text = "Непредвиденная ошибка";
            }
        }

        private void textBoxMonth_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMonth.Text.Length == 0) return;
            try
            {
                _dateTime1 = new DateTime(
                    _dateTime1.seconds,
                    int.Parse(textBoxMonth.Text),
                    _dateTime1.year);
                changeFields();
            }
            catch (InvalidDataException exception)
            {
                labelDate.Text = exception.Message;
            }
            catch (Exception exception)
            {
                labelDate.Text = "Непредвиденная ошибка";
            }
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            if (textBoxYear.Text.Length == 0) return;
            try
            {
                _dateTime1 = new DateTime(
                    _dateTime1.seconds,
                    _dateTime1.month,
                    int.Parse(textBoxYear.Text));
                changeFields();
            }
            catch (InvalidDataException exception)
            {
                labelDate.Text = exception.Message;
            }
            catch (Exception exception)
            {
                labelDate.Text = "Непредвиденная ошибка";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelEqual.Text = (_dateTime1 == _dateTime2) ? "Даты равны" : "Даты не равны";
        }

        private void textBoxYear2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxYear2.Text.Length == 0) return;
            try
            {
                _dateTime2 = new DateTime(
                    _dateTime2.seconds,
                    _dateTime2.month,
                    int.Parse(textBoxYear2.Text));
                changeFields2();
            }
            catch (InvalidDataException exception)
            {
                labelDate2.Text = exception.Message;
            }
            catch (Exception exception)
            {
                labelDate2.Text = "Непредвиденная ошибка";
            }
        }

        private void textBoxMonth2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMonth2.Text.Length == 0) return;
            try
            {
                _dateTime2 = new DateTime(
                    _dateTime2.seconds,
                    int.Parse(textBoxMonth2.Text),
                    _dateTime2.year);
                changeFields2();
            }
            catch (InvalidDataException exception)
            {
                labelDate2.Text = exception.Message;
            }
            catch (Exception exception)
            {
                labelDate2.Text = "Непредвиденная ошибка";
            }
        }

        private void textBoxSecond2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSecond2.Text.Length == 0) return;
            try
            {
                _dateTime2 = new DateTime(
                    int.Parse(textBoxSecond2.Text),
                    _dateTime2.month,
                    _dateTime2.year);
                changeFields2();
            }
            catch (InvalidDataException exception)
            {
                labelDate2.Text = exception.Message;
            }
            catch (Exception exception)
            {
                labelDate2.Text = "Непредвиденная ошибка";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDDay2.Text.Length == 0) return;
                _dateTime2.AddDays(int.Parse(textBoxDDay2.Text));
                changeFields2();
            }
            catch (InvalidDataException exception)
            {
                labelDate2.Text = exception.Message;
            }
            catch (Exception exception)
            {
                labelDate2.Text = "Непредвиденная ошибка";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMonth2.Text.Length == 0) return;
                _dateTime2.AddMonths(int.Parse(textBoxMonth2.Text));
                changeFields2();
            }
            catch (InvalidDataException exception)
            {
                labelDate2.Text = exception.Message;
            }
            catch (Exception exception)
            {
                labelDate2.Text = "Непредвиденная ошибка";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxYear2.Text.Length == 0) return;
                _dateTime2.AddYears(int.Parse(textBoxYear2.Text));
                changeFields2();
            }
            catch (InvalidDataException exception)
            {
                labelDate2.Text = exception.Message;
            }
            catch (Exception exception)
            {
                labelDate2.Text = "Непредвиденная ошибка";
            }
        }
    }
}