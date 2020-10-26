using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acconting
{
    public partial class Formloading : Form
    {
        public Formloading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadingProgressbar.Value += 10;
            if (LoadingProgressbar.Value==100)
            {
                timer1.Stop();
                new FormMain().ShowDialog();
                this.Close();
            }
        }
    }
}
