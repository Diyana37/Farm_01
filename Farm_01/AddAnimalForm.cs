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
    public partial class AddAnimalForm : Form
    {
        public AddAnimalForm()
        {
            InitializeComponent();
        }

        private void goat_pic_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Resources/goat.wav");
            player.Play();

            Goat goat = new Goat();
            goat.AddAnimal();
            goat.AddProduct();
        }

        private void cow_pic_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Resources/cow.wav");
            player.Play();

            Cow cow = new Cow();
            cow.AddAnimal();
            cow.AddProduct();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chicken_pic_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Resources/chicken.wav");
            player.Play();

            Chicken chicken = new Chicken();
            chicken.AddAnimal();
            chicken.AddProduct();
        }

        private void sheep_pic_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Resources/sheep.wav");
            player.Play();

            Sheep sheep = new Sheep();
            sheep.AddAnimal();
            sheep.AddProduct();
        }
    }
}
