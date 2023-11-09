using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace iciceform
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, c, d;
            a = textBox1.Text;
            b = textBox2.Text;
            c = "admin";
            d = "1234";
            

            if (a == c && b == d)

            {
                Form2 form2 = new Form2(); // açılacak form

                form2.Show();
                this.Hide();

            }

            else
            {
               sayac++;  // Hatalı giriş sayısını bir artır



                if (sayac > 3) // Hatalı giriş sayısı 3'e eşit veya daha büyükse, formu kapat
                    {
                        
                    MessageBox.Show("3 kere Hatalı giriş yaptınız , program kapatılacak ");
                    this.Close();

                

                }
                else
                    {
                    MessageBox.Show("Hatalı Giriş Yaptınız : " + (3 - sayac));  // Kullanıcıya hata mesajı göster
                        
                    }
           
                }
            }
        }
    }

