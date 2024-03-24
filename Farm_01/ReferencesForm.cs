using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Farm_01
{
    public partial class ReferencesForm : Form
    {
        public ReferencesForm()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReferencesForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> animals = Animal.GetProducts();

            string cow_result = (animals["milk_cow"] * Cow.defaultMilkProductionPerDay).ToString();
            cowMilk_lbl.Text = cow_result.ToString();

            string goat_result = (animals["milk_goat"] * Goat.defaultMilkProductionPerDay).ToString();
            goatMilk_lbl.Text = goat_result.ToString();

            string chicken_result = (animals["eggs"] * Chicken.defaultEggsProductionPerDay).ToString();
            chickenEggs_lbl.Text = chicken_result.ToString();

            string sheep_result = (animals["wool"] * Sheep.defaultWoolProductionPerDay).ToString();
            sheepWool_lbl.Text = sheep_result.ToString();
        }
    }
}

