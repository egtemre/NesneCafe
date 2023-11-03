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
        int TotalPr�ce = 0;

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
            TotalPr�ce += Cupcake;
            SepetListBox.Items.Add("Cupcake");
        }

        private void CheesePictureBox_Click(object sender, EventArgs e)
        {
            TotalPr�ce += Cheese;
            SepetListBox.Items.Add("Cheese");

        }

        private void HamburgerPictureBox_Click(object sender, EventArgs e)
        {
            TotalPr�ce += Hamburger;
            SepetListBox.Items.Add("Hamburger");
        }

        private void PizzaPictureBox_Click(object sender, EventArgs e)
        {
            TotalPr�ce += Pizza;
            SepetListBox.Items.Add("Pizza");

        }

        private void HotdogPictureBox_Click(object sender, EventArgs e)
        {
            TotalPr�ce += Hotdog;
            SepetListBox.Items.Add("Hotdog");
        }

        private void PancakePictureBox_Click(object sender, EventArgs e)
        {
            TotalPr�ce += Pancake;
            SepetListBox.Items.Add("Pancake");
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (TotalPr�ce <= 1000)
            {
                /*MATEMAT�CAL PARt*/

                Money = Money - TotalPr�ce;

                /*WR�T�NG PART */


                MoneyLabel.Text = Money.ToString() + "TL";

                /*INFORMATION*/

                MessageBox.Show("Al�sveris yaptiginiz i�in tesekkur ederiz!", "B�lgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }
            else
            {
            MessageBox.Show("Paraniz yetmemektedir!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}