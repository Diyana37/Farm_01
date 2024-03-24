using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_01
{
    public partial class DeleteAnimalForm : Form
    {
        public DeleteAnimalForm()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void goat_pic_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Resources/screaming_goat.wav");
            player.Play();

            Goat goat = new Goat();
            goat.DeleteAnimal();
            goat.DeleteProduct();
        }

        private void cow_pic_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Resources/screaming_cow.wav");
            player.Play();

            Cow cow = new Cow();
            cow.DeleteAnimal();
            cow.DeleteProduct();
        }

        private void chicken_pic_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Resources/screaming_chicken.wav");
            player.Play();

            Chicken chicken = new Chicken();
            chicken.DeleteAnimal();
            chicken.DeleteProduct();
        }

        private void sheep_pic_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Resources/screaming_sheep.wav");
            player.Play();

            Sheep sheep = new Sheep();
            sheep.DeleteAnimal();
            sheep.DeleteProduct();
        }
    }
}
