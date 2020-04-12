using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disc
{
    public partial class MainForm : Form
    {
        private KompasConnector kompasConnector;
        private DiscParams discParams;

        public MainForm()
        {
            InitializeComponent();
            AutoParams();
        } 
        /// <summary>
        /// Функция, которая производит автозаполнение данных в поля.
        /// </summary>
        private void AutoParams()
        {
            MainDiameterTextBox.Text = "137";
            WidthTextBox.Text = "26";
            InsideDiameterTextBox.Text = "26";
            CentralCutTextBox.Text = "80";
            DepthCutTextBox.Text = "5";
            AngleTextBox.Text = "10";
        }
        /// <summary>
        /// Функция проверяет правильность введенных данных в поля, если же все данные верны то присваивает значения.
        /// </summary>
        private void Validator()
        {
            WarningLabel.Visible = true;
            BuildButton.Enabled = false;
            // Переменная, которая ведет подсчёт правильно заполненых полей.
            int rightToken = 0;
            if ((MainDiameterTextBox.Text == "") || Int32.Parse(MainDiameterTextBox.Text) < 137 || Int32.Parse(MainDiameterTextBox.Text) > 251)
            {
                MainDiameterTextBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                MainDiameterTextBox.BackColor = System.Drawing.Color.Green;
                rightToken++;
            }

            if ((WidthTextBox.Text == "") || Int32.Parse(WidthTextBox.Text) < 26 || (Int32.Parse(WidthTextBox.Text)) > 69)
            {
                WidthTextBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                WidthTextBox.BackColor = System.Drawing.Color.Green;
                rightToken++;
            }

            if ((InsideDiameterTextBox.Text == "") || Int32.Parse(InsideDiameterTextBox.Text) < 26 || (Int32.Parse(InsideDiameterTextBox.Text)) > 31)
            {
                InsideDiameterTextBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                InsideDiameterTextBox.BackColor = System.Drawing.Color.Green;
                rightToken++;
            }

            if ((CentralCutTextBox.Text == "") || Int32.Parse(CentralCutTextBox.Text) < 80)
            {
                CentralCutTextBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                CentralCutTextBox.BackColor = System.Drawing.Color.Green;
                rightToken++;
            }

            if ((DepthCutTextBox.Text == "") || Int32.Parse(DepthCutTextBox.Text) < 5 || (Int32.Parse(DepthCutTextBox.Text)) > 10)
            {
                DepthCutTextBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                DepthCutTextBox.BackColor = System.Drawing.Color.Green;
                rightToken++;
            }

            if ((AngleTextBox.Text == "") || Int32.Parse(AngleTextBox.Text) < 1 || (Int32.Parse(AngleTextBox.Text)) > 10)
            {
                AngleTextBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                AngleTextBox.BackColor = System.Drawing.Color.Green;
                rightToken++;
            }

            if (rightToken == 6)
            {
                if ((Int32.Parse(CentralCutTextBox.Text) + 30) > Int32.Parse(MainDiameterTextBox.Text) || Int32.Parse(CentralCutTextBox.Text) > Int32.Parse(MainDiameterTextBox.Text))
                {
                    WarningLabel.Visible = true;
                    WarningLabel.Text = "Центральный вырез не соответствует условию D - 30";
                    CentralCutTextBox.BackColor = System.Drawing.Color.Red;
                    rightToken = 0;
                }
                else
                {
                    BuildButton.Enabled = true;
                    discParams = new DiscParams(Convert.ToInt32(MainDiameterTextBox.Text), Convert.ToInt32(WidthTextBox.Text), Convert.ToInt32(InsideDiameterTextBox.Text),
                    Convert.ToInt32(CentralCutTextBox.Text), Convert.ToInt32(DepthCutTextBox.Text), Convert.ToInt32(AngleTextBox.Text));
                    WarningLabel.Visible = false;
                    WarningLabel.Text = "Параметры введены неверно!";
                }
            }
        }

        /// <summary>
        /// Функция, которая является обработчиком события(срабатывает при изменение значения  в текстовом поле).
        /// </summary>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Validator();
        }

        /// <summary>
        /// Обработчик кнопки "Построить."
        /// </summary>
        private void BuildButton_Click(object sender, EventArgs e)
        {
            kompasConnector = new KompasConnector(discParams);
            //Builder builder = new Builder();
            //builder.Build(kompasConnector.iPart, kompasConnector.kompas, discParams);
        }

        /// <summary>
        /// Обработчик, который ограничивает ввод символов в поля.
        /// </summary>
        private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая в ASCII
            {
                e.Handled = true;
            }
        }
    }
}
