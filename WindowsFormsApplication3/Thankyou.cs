using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Thankyou : Form
    {
        public Thankyou()
        {
            InitializeComponent();
        }

        private void btn_start_page_Click(object sender, EventArgs e)
        {

            entrence_screen_pizza Tothestart = new entrence_screen_pizza();
            Tothestart.Show();
            this.Hide();
        }
    }
}
