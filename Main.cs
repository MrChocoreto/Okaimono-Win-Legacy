using System;
using System.Windows.Forms;

namespace Okaimono_Win_Legacy
{
    public partial class Okaimono : Form
    {
        public Okaimono()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            MinimumSize = new System.Drawing.Size() { Width = 800, Height = 600 };
        }
    }
}
