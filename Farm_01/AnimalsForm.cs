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
    public partial class AnimalsForm : Form
    {
        AddAnimalForm addAnimalForm = new AddAnimalForm();
        DeleteAnimalForm deleteAnimalForm = new DeleteAnimalForm();
        ReferencesForm referencesForm = new ReferencesForm();
        public AnimalsForm()
        {
            InitializeComponent();
        }

        private void addAnimal_btn_Click(object sender, EventArgs e)
        {
            addAnimalForm.Show();
        }

        private void AnimalsForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> animals = Animal.GetAnimals();
            goat_lbl.Text = animals["goat"].ToString();
            cow_lbl.Text = animals["cow"].ToString();
            chicken_lbl.Text = animals["chicken"].ToString();
            sheep_lbl.Text = animals["sheep"].ToString();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> animals = Animal.GetAnimals();
            goat_lbl.Text = animals["goat"].ToString();
            cow_lbl.Text = animals["cow"].ToString();
            chicken_lbl.Text = animals["chicken"].ToString();
            sheep_lbl.Text = animals["sheep"].ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            deleteAnimalForm.Show();
        }

        private void references_btn_Click(object sender, EventArgs e)
        {
            referencesForm.Show();
        }
    }
}
