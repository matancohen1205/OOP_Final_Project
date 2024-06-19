using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class MyDeliverySystem : Form
    {
        public User Currentuser { get; set; }
        public MyDeliverySystem()
        {
            InitializeComponent();
        }
        public class Order
        {


            public int TotalItems { get; set; } = 0;
            public int pizzapeperoni { get; set; } = 0;
            public int pizzavegtable { get; set; } = 0;
            public int cheesypizza { get; set; } = 0;
            public int cocacola { get; set; } = 0;
            public int fanta { get; set; } = 0;
            public int musshokolad { get; set; } = 0;
            public int bavaria { get; set; } = 0;
            public Order()
            {
            }
            public Order(Order other)
            {
                pizzapeperoni = other.pizzapeperoni;
                pizzavegtable = other.pizzavegtable;
                cheesypizza = other.cheesypizza;
                cocacola = other.cocacola;
                fanta = other.fanta;
                musshokolad = other.musshokolad;
                bavaria = other.bavaria;
                TotalItems = other.TotalItems;
            }
        }
            
       

        

        private double Sum = 0.0;
        Order currentOrder = new Order();
        private double Pizzapeperonniprice = 55.0;
        private double Pizzavegtableprice = 35.0;
        private double Cheesypizzaprice = 30.0;
        private double Fantaprice = 10.0;
        private double CocaColaprice = 10.0;
        private double musshokoladprice = 20.0;
        private double bavariaprice = 20.0;
        private void updatesumlabel()
        {
            if (Currentuser.benefits() == "guest")
            {
                Pizzapeperonniprice = 55.0 * 1;
                Pizzavegtableprice = 35.0 * 1;
                Cheesypizzaprice = 30.0 * 1;
                Fantaprice = 10.0 * 1;
                CocaColaprice = 10.0 * 1;
                musshokoladprice = 20.0 * 1;
                bavariaprice = 20.0 * 1;
            }
           
            if (Currentuser.benefits() == "gold")
            {
                Pizzapeperonniprice = 55.0 * 0.75;
                Pizzavegtableprice = 35.0 * 0.75;
                Cheesypizzaprice = 30.0 * 0.75;
                Fantaprice = 10.0 * 0.75;
                CocaColaprice = 10.0 * 0.75;
                musshokoladprice = 20.0 * 0.75;
                bavariaprice = 20.0 * 0.75;
            }
           if (Currentuser.benefits() == "premium")
           {
                Pizzapeperonniprice = 55.0 * 0.5;
                Pizzavegtableprice = 35.0 * 0.5;
                Cheesypizzaprice = 30.0 * 0.5;
                Fantaprice = 10.0 * 0.5;
                CocaColaprice = 10.0 * 0.5;
                musshokoladprice = 20.0 * 0.5;
                bavariaprice = 20.0 * 0.5;
           }
            if (Currentuser.benefits() == "delivery")
            {
                Pizzapeperonniprice = 55.0 * 0.05;
                Pizzavegtableprice = 35.0 * 0.05;
                Cheesypizzaprice = 30.0 * 0.05;
                Fantaprice = 10.0 * 0.05;
                CocaColaprice = 10.0 * 0.05;
                musshokoladprice = 20.0 * 0.05;
                bavariaprice = 20.0 * 0.05;
            }

          
            Sum = 0.0;
            Sum += Pizzapeperonniprice * currentOrder.pizzapeperoni;
            Sum += Pizzavegtableprice * currentOrder.pizzavegtable;
            Sum += Cheesypizzaprice * currentOrder.cheesypizza;
            Sum += Fantaprice * currentOrder.fanta;
            Sum += CocaColaprice * currentOrder.cocacola;
            Sum += musshokoladprice * currentOrder.musshokolad;
            Sum += bavariaprice * currentOrder.bavaria;

            SumLabel.Text = $"Total: ${Sum:F2}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentOrder.pizzavegtable++;
            updatesumlabel();
        }

        private void pic_pizzapeperonni_Click(object sender, EventArgs e)
        {
            currentOrder.pizzapeperoni++;
            updatesumlabel();
        }

        private void pic_cheesy_pizza_Click(object sender, EventArgs e)
        {
            currentOrder.cheesypizza++;
            updatesumlabel();
        }

        private void pic_coca_cola_Click(object sender, EventArgs e)
        {
            currentOrder.cocacola++;
            updatesumlabel();
        }

        private void pic_bavaria_Click(object sender, EventArgs e)
        {
            currentOrder.bavaria++;
            updatesumlabel();
        }

        private void pic_mus_shokolad_Click(object sender, EventArgs e)
        {
            currentOrder.musshokolad++;
            updatesumlabel();
        }

        private void pic_fanta_Click(object sender, EventArgs e)
        {
            currentOrder.fanta++;
            updatesumlabel();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            string soundFilePath = @"C:\Users\matan\Music\y2mate.is - little caesars pizza pizza sound-YlLM7DR9KYE-48k-1693754247.wav";
            if (Sum > 0.0)
            {
                using (SoundPlayer player = new SoundPlayer(soundFilePath))
                {
                    // Play the sound
                    player.Play();
                }
                // Go to the next Form
                Thankyou Tothankyou = new Thankyou();
                Tothankyou.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select an item","Order");
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            currentOrder.pizzavegtable++;
            updatesumlabel();
        }
    }
}
