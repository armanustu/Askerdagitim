using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void AskerEkle_Click(object sender, EventArgs e)
        {
           
            string askerismi = txtAsker.Text;
            if ((askerismi != ""))
            {     
                Array.Resize(ref asker, asker.Length + 1);
                asker[asker.Length - 1] = askerismi;
                lstAsker.Items.Add(askerismi);
                txtAsker.Clear();
                txtAsker.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen İsim alanını doldurunuz....");
                txtAsker.Focus();
            }
              
        }
        string[]asker = new string[] { "ARMAN", "ALPER", "HASAN", "VELİ", "MUSTAFA", "CENGİZ", "SELAMİ", "METİN", "ÜMİT", "SELAMİ", "ARDA" }; 
        private void Form1_Load(object sender, EventArgs e)
        {
           
            foreach(var item in asker){
            lstAsker.Items.Add(item);
            }
           foreach (var item in sehir) {
            lstSehir.Items.Add(item);
            }
        }
        string[] sehir = new string[] { "ANKARA", "İSTANBUL", "MALATYA", "DİYARBAKIR", "ELAZIĞ", "İZMİR", "ADANA", "ANTEP", "KAYSERİ", "IĞDIR", "ERZURUM", "SİVAS", "ANTALYA", "ALANYA", "MUŞ" };
        private void DagitimYap_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();
            if (lstDagitim.Items.Count > 0)
            {
                lstDagitim.Items.Clear();

            }            
                for (int i = 0; i < lstAsker.Items.Count; i++)
                {
                    int rd = r.Next(0, lstSehir.Items.Count);
                    lstDagitim.Items.Add(asker[i].ToString() + "->" + sehir[rd].ToString());

                }
            
        }
       
        private void SehirEkle_Click(object sender, EventArgs e)
        {
            string sehir1 = txtSehir.Text;
            if ((sehir1 != ""))
            {   
                Array.Resize(ref sehir, sehir.Length + 1);
                sehir[sehir.Length - 1] = sehir1;
                lstSehir.Items.Add(sehir1);
                txtSehir.Clear();
                txtSehir.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen Şehir alanını doldurunuz....");
                txtSehir.Focus();
            }
                 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstDagitim.Items.Clear();
        }
    }
}
