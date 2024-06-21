using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponsiveApp
{
    public partial class FormTest : Form
    {

        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(725, 548);
        }

        private void FormTest_ResizeEnd(object sender, EventArgs e)
        {
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;

            this.Top = (area.Height - this.Height) / 2;
            this.Left = (area.Width - this.Width) / 2;
        }
    }
}
