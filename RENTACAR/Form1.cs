using RENTACAR.ORM.Context;
using RENTACAR.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RENTACAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
            

        private void Btn_musterikaydet_Click(object sender, EventArgs e)
        {
            Musteriler must = new Musteriler();
            must.TC = txt_tc.Text;
            must.Ad = txt_ad.Text;
            must.Soyad = txt_soyad.Text;
            must.EhliyetNo = txt_ehliyet.Text;
            must.Telefon = txt_telefon.Text;
            must.Email = txt_email.Text;
            must.Adres = txt_adres.Text;
            must.Sifre = txt_sıfre.Text;

            db.Customers.Add(must);
            db.SaveChanges();
            MessageBox.Show("Kayıt başarı ile tamamlandı");

            txt_tc.Text = string.Empty;
            txt_ad.Text = string.Empty;
            txt_soyad.Text = string.Empty;
            txt_ehliyet.Text = string.Empty;
            txt_telefon.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_adres.Text = string.Empty;
            txt_sıfre.Text = string.Empty;

            



        }

        private void Btn_uyegiris_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler();
            musteri.TC = txt_uyetc.Text;
            musteri.Sifre = txt_uyesifre.Text;

            if (txt_uyetc.Text == "A" && txt_uyesifre.Text == "1")
            {
                ArabaKayitcs a = new ArabaKayitcs();
                a.Show();
            }
            else if (db.Customers.Any(x => x.TC == musteri.TC && x.Sifre == musteri.Sifre))
            {
                KiralamaForm3 k = new KiralamaForm3();
                k.Show();
            }
            else
                MessageBox.Show("Böyle bir üye yok");

            txt_uyetc.Text = string.Empty;
            txt_uyesifre.Text = string.Empty;
        }
    }
}
