using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustRipeFarm_v3
{
    public partial class loadingScreen : Form
    {
        public loadingScreen()
        {
            InitializeComponent();
            System.Diagnostics.Debugger.Launch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
