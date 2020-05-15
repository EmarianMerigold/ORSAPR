using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Disc_Kompas.API;
using Disc_Kompas.Logic;

namespace Disc_Kompas.GUI
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
        /// Производит автозаполнение данных в поля.
        /// </summary>
        private void AutoParams()
        {
            MainDiameterTextBox.Text = "250";
            WidthTextBox.Text = "69";
            InsideDiameterTextBox.Text = "26";
            CentralCutTextBox.Text = "200";
            DepthCutTextBox.Text = "10";
            AngleTextBox.Text = "4";
        }
        /// <summary>
        /// Проверяет правильность введенных данных в поля, если же все данные верны то присваивает значения.
        /// </summary>
        private void Validator()
        {
            WarningLabel.Visible = true;
            BuildButton.Enabled = false;

            List<TextBox> TextBoxList = new List<TextBox>();

            TextBoxList.AddRange(new TextBox[]
            {
              MainDiameterTextBox,
              WidthTextBox,
              InsideDiameterTextBox,
              CentralCutTextBox,
              DepthCutTextBox,
              AngleTextBox
            });

            List<Int32> MinInputList = new List<Int32>();
            MinInputList.AddRange(new Int32[] { 137, 26, 26, 80, 5, 1});
            List<Int32> MaxInputList = new List<Int32>();
            MaxInputList.AddRange(new Int32[] { 251, 69, 31, 221, 10, 10});
            int i = 0;
            for (i = 0; i != 6; i++)

            {
                if ((TextBoxList[i].Text == "") || Int32.Parse(TextBoxList[i].Text) < MinInputList[i] ||
                    Int32.Parse(TextBoxList[i].Text) > MaxInputList[i] || TextBoxList[i].Text.Length > 6)
                {
                    TextBoxList[i].BackColor = System.Drawing.Color.Red;
                    WarningLabel.Visible = true;
                    break;
                }
                else
                {
                    TextBoxList[i].BackColor = System.Drawing.Color.Green;
                    WarningLabel.Visible = false;
                }
            }

            if (i == 6)
            {
                if ((Int32.Parse(CentralCutTextBox.Text) + 30) > Int32.Parse(MainDiameterTextBox.Text) || Int32.Parse(CentralCutTextBox.Text) > Int32.Parse(MainDiameterTextBox.Text))
                {
                    WarningLabel.Visible = true;
                    WarningLabel.Text = "Центральный вырез не соответствует условию D - 30";
                    CentralCutTextBox.BackColor = System.Drawing.Color.Red;
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
        /// Обработчик события(срабатывает при изменение значения  в текстовом поле).
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
            bool Edge = false;

            if (EdgeCheckBox.Checked)
            { Edge = true; }

            kompasConnector = new KompasConnector(discParams);
            Builder builder = new Builder();
            builder.Build(kompasConnector.iPart, kompasConnector.kompas, discParams, Edge);  
        }

        /// <summary>
        /// Обработчик, ограничивает ввод символов в поля.
        /// </summary>
        private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}
