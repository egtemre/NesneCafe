using System.IO.Packaging;

namespace NesneCafe
{
    public partial class NesneCafe : Form
    {
        /* MONEY*/
        int Money = 1000;

        /* FOOD PRICES*/
        int Cheese = 15;
        int Cupcake = 35;
        int Hamburger = 150;
        int Pizza = 160;
        int Hotdog = 55;
        int Pancake = 45;

        /* TOTAL PRICE */
        int TotalPrýce = 0;

        public NesneCafe()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            MoneyLabel.Text = Money.ToString() + "TL";

        }

        private void CupcekPictureBox_Click(object sender, EventArgs e)
        {
            TotalPrýce += Cupcake;
            SepetListBox.Items.Add("Cupcake");
        }

        private void CheesePictureBox_Click(object sender, EventArgs e)
        {
            TotalPrýce += Cheese;
            SepetListBox.Items.Add("Cheese");

        }

        private void HamburgerPictureBox_Click(object sender, EventArgs e)
        {
            TotalPrýce += Hamburger;
            SepetListBox.Items.Add("Hamburger");
        }

        private void PizzaPictureBox_Click(object sender, EventArgs e)
        {
            TotalPrýce += Pizza;
            SepetListBox.Items.Add("Pizza");

        }

        private void HotdogPictureBox_Click(object sender, EventArgs e)
        {
            TotalPrýce += Hotdog;
            SepetListBox.Items.Add("Hotdog");
        }

        private void PancakePictureBox_Click(object sender, EventArgs e)
        {
            TotalPrýce += Pancake;
            SepetListBox.Items.Add("Pancake");
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (TotalPrýce <= 1000)
            {
                /*MATEMATÝCAL PARt*/

                Money = Money - TotalPrýce;

                /*WRÝTÝNG PART */


                MoneyLabel.Text = Money.ToString() + "TL";

                /*INFORMATION*/

                MessageBox.Show("Alýsveris yaptiginiz için tesekkur ederiz!", "BÝlgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }
            else
            {
            MessageBox.Show("Paraniz yetmemektedir!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}