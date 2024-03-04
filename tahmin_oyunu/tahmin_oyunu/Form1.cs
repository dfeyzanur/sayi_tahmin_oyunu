using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tahmin_oyunu
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            

            InitializeComponent();
        }

        private void buttonBasla_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            hak = 5;
            labelMesaj.Text = "SAYI TAHMİN OYUNUNA HOŞGELDİNİZ! \n 1-20 ARASI BİR SAYI GİRİNİZ!";
            Random random = new Random();
            int sayi = random.Next(0, 20);

            label1.Text = sayi.ToString();
            linkLabel1.Text = (hak.ToString()+"Hakkınız Var!");
            linkLabel1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelMesaj.Visible = true;
          

        }

        int hak = 5;
        int tahminfonk(int sayi)
        {
            int tahmin = Convert.ToInt32(label1.Text);

            if (hak == 0)
            {
                labelMesaj.Text = "Kaybettiniz!";
            }
            else
            {
                if (sayi == tahmin)
                {
                    MessageBox.Show("KAZANDINIZ!");
                    labelMesaj.Text = "Tekrar oynamak için Başla butonuna tıklayınız!";


                }

                else
                {
                    if (sayi < tahmin)
                    {
                        labelMesaj.Text = "YANLIŞ TAHMİN TEKRAR DENEYİNİZ! \n DAHA BÜYÜK!";
                        hak--;
                    }
                    else
                    {
                        labelMesaj.Text = "YANLIŞ TAHMİN TEKRAR DENEYİNİZ!\n DAHA KÜÇÜK";
                        hak--;
                    }
                    


                }
            }
           
            return tahmin;
        }

        private void buttonTahmin_Click_1(object sender, EventArgs e)
        {
            
            
            int sayi=Convert.ToInt32(textBox1.Text);
            if(sayi>0 && sayi<20)
            tahminfonk(sayi);
            else
            {
                MessageBox.Show("1-20 arası bir sayi giriniz!");
            }
           
            linkLabel1.Text=(hak.ToString()+" Hakkınız kaldı!");


        }
    }
}
