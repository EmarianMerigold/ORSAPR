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
        public MainForm()
        {
            InitializeComponent();
            AutoFill();
        }

        private void AutoFill()
        {
            MainDiameter_textBox.Text = "137";
            Width_textBox.Text = "26";
            InsideDiameter_textBox.Text = "26";
            CentralCut_textBox.Text = "80";
            DepthCut_textBox.Text = "5";
            Angle_textBox.Text = "1";
        }

    }
}
