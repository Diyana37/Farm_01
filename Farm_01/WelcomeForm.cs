using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_01
{
    public partial class WelcomeForm : Form
    {
        AnimalsForm animalsForm = new AnimalsForm();
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            animalsForm.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
