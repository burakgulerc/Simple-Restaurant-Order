using BilgeRestoran.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeRestoran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }


        Siparis s;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSiparisIsmi.Text == "")
            {
                MessageBox.Show("Lütfen masa numarasını giriniz.");
                return;
            }

            s = new Siparis();
            s.Isim = txtSiparisIsmi.Text;

            foreach (CheckBox item in grbAraSicak.Controls)
            {
                if (item.Checked)
                {
                    AraSicak araSicak = new AraSicak();
                    araSicak.Isim = item.Text;
                    araSicak.Fiyat = Convert.ToDecimal(item.Tag);
                    s.AraSicak = araSicak;
                }
            }

            foreach (CheckBox item in grbAnaYemek.Controls)
            {

                if (item.Checked)
                {
                    AnaYemek anaYemek = new AnaYemek();
                    anaYemek.Isim = item.Text;
                    anaYemek.Fiyat = Convert.ToDecimal(item.Tag);
                    s.AnaYemek = anaYemek;
                }

            }

            foreach (CheckBox item in grbIcecek.Controls)
            {
                if (item.Checked)
                {
                    Icecek icecek = new Icecek();
                    icecek.Isim = item.Text;
                    icecek.Fiyat = Convert.ToDecimal(item.Tag);
                    s.Icecek = icecek;
                }

            }

            foreach (CheckBox item in grbTatli.Controls)
            {
                if (item.Checked)
                {
                    Tatli tatli = new Tatli();
                    tatli.Isim = item.Text;
                    tatli.Fiyat = Convert.ToDecimal(item.Tag);
                    s.Tatli = tatli;
                }
            }

            // s.SiparisKontrolEt();

            int checkCount = 0;

            foreach (Control item in Controls)                      // Ürün seçmeden sipariş verilmesini engellemek için, checkbox'larda dön ve checked item sayısını kontrol et
            {
                if (item is GroupBox)
                {
                    foreach (CheckBox checkItem in item.Controls)
                    {
                        if (checkItem.Checked == true)
                        {
                            checkCount++;
                        }
                    }
                }

            }

            if (checkCount < 1)
            {
                MessageBox.Show("En az 1 ürün seçmeden sipariş giremezsiniz");
                return;
            }

            s.TutarHesapla();

            lstSiparis.Items.Add(s);

        }

       

        private void btnCiro_Click(object sender, EventArgs e)
        {
            decimal toplam = 0;

            foreach (Siparis item in lstSiparis.Items)
            {
                toplam += item.Fiyat;
            }

            MessageBox.Show(toplam.ToString());
        }
    }
}
