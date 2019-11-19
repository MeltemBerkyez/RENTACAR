using RENTACAR.ORM.Context;
using RENTACAR.ORM.Entity;
using System;
using System.Collections;
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
    public partial class KiralamaForm3 : Form
    {
        public KiralamaForm3()
        {
            InitializeComponent();
            ArabaList();
            
        }

        List<DateTime> list = new List<DateTime>();

        public void KontrolEt(int arabaid)
        {
            List<Kİralama> krl = new List<Kİralama>();
            krl = db.Rents.Where(x => x.AktifMi == true && x.ArabaID == arabaid).ToList();

            foreach (Kİralama item in krl)
            {
                DateTime start = new DateTime();
                start = item.AlisTarihi;
                DateTime end = new DateTime();
                end = item.TeslimTarihi;

                var dates = new List<DateTime>();
                for (var dt = start; dt <= end; dt = dt.AddDays(1))
                {
                    dates.Add(dt);

                    list.Add(dt);
                }
            }
        }

        List<DateTime> secilentariharalıgı = new List<DateTime>();
            public bool GonderilenKontrol(DateTime AlisTarihi, DateTime TeslimTarihi)
            {

                DateTime start = new DateTime();
                start = AlisTarihi;
                DateTime end = new DateTime();
                end = TeslimTarihi;

                var dates = new List<DateTime>();
                for (var dt = start; dt <= end; dt = dt.AddDays(1))
                {
                    dates.Add(dt);

                    secilentariharalıgı.Add(dt);
                }


                for (int i = 0; i < dates.Count; i++)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (dates[i].ToString() == list[j].ToString())
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        
        ProjectContext db = new ProjectContext();
        public void ArabaList()
        {
            lvw_musteripaneli.Items.Clear();
            foreach (Arabalar item in db.Cars.ToList())
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = item.ID.ToString();
                lv.SubItems.Add(item.Plaka);
                lv.SubItems.Add(item.Marka);
                lv.SubItems.Add(item.Model);
                lv.SubItems.Add(item.AracTipi);
                lv.SubItems.Add(item.Vites);
                lv.SubItems.Add(item.YakıtTipi);
                lv.SubItems.Add(item.Fiyat.ToString());
                lv.Tag = item.ID;  //tıkladığım arabanın bilgilerini arabakaydetmedeki  textlere dolduruyor.
                lvw_musteripaneli.Items.Add(lv);

            }
        }

        //List<DateTime> clist = new List<DateTime>();
        //List<DateTime> sqlist = new List<DateTime>();
        //Kİralama sec = new Kİralama();
        private void Btn_devam_Click(object sender, EventArgs e)
        {
            list.Clear();//listeye sğrekli ekleme yaptığımızdan veri doluyor program hata veriyor.O yüzden listeyi temizliyoruz...
            secilentariharalıgı.Clear();
            KontrolEt(arabaid);
            //List<Arabalar> arabalars = new List<Arabalar>();
            //arabalars = db.Cars.Where(x => x.ID ==arabaid).ToList();

            bool a = GonderilenKontrol(dateTimePicker1.Value, dateTimePicker2.Value);
            if (a == false)
            {
                MessageBox.Show("İstediğiniz Tarihte Araba Dolu Olduğundan Veremiyoruz.");
            }
            else
            {
                TimeSpan ks = dateTimePicker2.Value - dateTimePicker1.Value;

                int ide = Convert.ToInt32(lvw_musteripaneli.SelectedItems[0].Tag);
                Arabalar me = db.Cars.Find(ide);
                txt_rat.Text = Convert.ToString(dateTimePicker1.Value);
                txt_ret.Text = Convert.ToString(dateTimePicker2.Value);
                int FATURA = Convert.ToInt32(me.Fiyat) * ks.Days;
                lbl_fatura.Text = FATURA.ToString();

            };
             


            //    sec.AlisTarihi = dateTimePicker1.Value;
            //    sec.TeslimTarihi = dateTimePicker2.Value;
            //    if (sec.TeslimTarihi <= sec.AlisTarihi)
            //    {
            //        MessageBox.Show("Teslim alma tarihinden ileri bir tarih seçiniz.");
            //    }


            //    for (DateTime i = dateTimePicker1.Value; i <= dateTimePicker2.Value; i = i.AddDays(1))
            //    {
            //        clist.Add(i);
            //        MessageBox.Show(i.ToString());
            //    }


            //    List<Kİralama> krl = new List<Kİralama>();
            //    krl = db.Rents.ToList();
            //    List<Arabalar> a = new List<Arabalar>();
            //    a = db.Cars.ToList();
            //    List<Arabalar> kiraliklar = new List<Arabalar>();
            //    List<int> list = new List<int>();
            //    foreach (var i in krl)
            //    {
            //        list.Add(i.ArabaID);
            //    }
            //    //   lvw_musteripaneli.Items.Clear();
            //    foreach (Arabalar itemaraba in a) //mercedes renault fiat
            //    {
            //        if (list.Contains(itemaraba.ID))
            //        {
            //            List<Kİralama> arb = new List<Kİralama>();

            //            arb=db.Rents.Where(z => z.ArabaID == itemaraba.ID).ToList();
            //            if (arb != null)
            //            {
            //                DateTime start=DateTime.MinValue; DateTime end = DateTime.MinValue;
            //                foreach (Kİralama itemm in arb)
            //                {


            //                start = Convert.ToDateTime(itemm.TeslimAlmaYeri);

            //                end = Convert.ToDateTime(itemm.TeslimEtmeYeri);
            //                }
            //                for (var dt = start; dt <= end; dt = dt.AddDays(1))
            //                {
            //                    sqlist.Add(dt.Date);
            //                }
            //                if ((sqlist.Contains(sec.AlisTarihi.Date) || sqlist.Contains(sec.TeslimTarihi.Date)))
            //                {
            //                    MessageBox.Show("");
            //                    break;
            //                }
            //                else
            //                {
            //                    if (!kiraliklar.Contains(itemaraba))
            //                    {
            //                        ListViewItem lst = new ListViewItem();
            //                        lst.Text = itemaraba.ID.ToString();
            //                        lst.SubItems.Add(itemaraba.Plaka);
            //                        lst.SubItems.Add(itemaraba.Marka);
            //                        lst.SubItems.Add(itemaraba.Model);
            //                        lst.SubItems.Add(itemaraba.AracTipi);
            //                        lst.SubItems.Add(itemaraba.Vites);
            //                        lst.SubItems.Add(itemaraba.YakıtTipi);
            //                        lst.SubItems.Add(itemaraba.Fiyat.ToString());
            //                        lst.Tag = itemaraba.ID;
            //                        lvw_musteripaneli.Items.Add(lst);
            //                        kiraliklar.Add(itemaraba);
            //                    }

            //                }
            //            }                    
            //        }
            //        else
            //        {
            //            ListViewItem lst = new ListViewItem();
            //            lst.Text = itemaraba.ID.ToString();
            //            lst.SubItems.Add(itemaraba.Plaka);
            //            lst.SubItems.Add(itemaraba.Marka);
            //            lst.SubItems.Add(itemaraba.Model);
            //            lst.SubItems.Add(itemaraba.AracTipi);
            //            lst.SubItems.Add(itemaraba.Vites);
            //            lst.SubItems.Add(itemaraba.YakıtTipi);
            //            lst.SubItems.Add(itemaraba.Fiyat.ToString());
            //            lst.Tag = itemaraba.ID;
            //            lvw_musteripaneli.Items.Add(lst);
            //        }
            //    }
        }
        Arabalar rent;

        private void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lvw_musteripaneli.SelectedItems[0].Text);

            List<Arabalar> arabalars = new List<Arabalar>();
            arabalars = db.Cars.Where(x => x.ID == id).ToList();

            rent = db.Cars.Find(id);

            Kİralama kiralama = new Kİralama();
            Arabalar at = new Arabalar();
            Musteriler m = new Musteriler();
            foreach (Arabalar item in arabalars)
            {

                TimeSpan ks = dateTimePicker2.Value - dateTimePicker1.Value;

                kiralama.ArabaID = rent.ID;
                kiralama.MusteriID = rent.ID;
                kiralama.AlisTarihi = dateTimePicker1.Value;
                kiralama.TeslimTarihi = dateTimePicker2.Value;
                kiralama.KiralanmaSuresi = ks.Days;
                kiralama.Fatura = ks.Days * at.Fiyat;
               // kiralama.AktifMi = false;
                kiralama.AktifMi = true;


            }

            db.Rents.Add(kiralama);
            db.Entry(db.Cars.Find(rent.ID)).CurrentValues.SetValues(rent);

            db.SaveChanges();
            OdemeAlanı oa = new OdemeAlanı();

            oa.Show();

            ArabaList();
        }
        Arabalar me;
        //private void Lvw_musteripaneli_DoubleClick(object sender, EventArgs e)
        //{
        //    //TimeSpan ks = dateTimePicker2.Value - dateTimePicker1.Value;


        //    int idd = Convert.ToInt32(lvw_musteripaneli.SelectedItems[0].Tag);
        //    me= db.Cars.Find(idd);
        // //   Kİralama ke = new Kİralama();
        //    txt_rplaka.Text = me.Plaka;
        //    txt_rmarka.Text = me.Marka;
        //    txt_rmodel.Text = me.Model;
        //    txt_raract.Text = me.AracTipi;
        //    txt_rvites.Text = me.Vites;
        //    txt_ryakit.Text = me.YakıtTipi;
        //    txt_rgunluk.Text = Convert.ToString(me.Fiyat);
        //   // txt_rat.Text = Convert.ToString(dateTimePicker1.Value);
        //  //  txt_ret.Text = Convert.ToString(dateTimePicker2.Value);
        ////    int FATURA = Convert.ToInt32(me.Fiyat) * ks.Days;
        //  //  lbl_fatura.Text = FATURA.ToString();



        //}

        public int arabaid;
        private void Lvw_musteripaneli_MouseClick(object sender, MouseEventArgs e)
        {
            int idd = Convert.ToInt32(lvw_musteripaneli.SelectedItems[0].Tag);
            me = db.Cars.Find(idd);
            txt_rplaka.Text = me.Plaka;
            txt_rmarka.Text = me.Marka;
            txt_rmodel.Text = me.Model;
            txt_raract.Text = me.AracTipi;
            txt_rvites.Text = me.Vites;
            txt_ryakit.Text = me.YakıtTipi;
            txt_rgunluk.Text = Convert.ToString(me.Fiyat);
            arabaid = idd;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = true;
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value <= dateTimePicker1.Value)
               {
                   MessageBox.Show("Teslim alma tarihinden ileri bir tarih seçiniz.");
                  return; //return demezsen uyarı verir ama hesaplaya basınca devam eder işleme. return yapınca programa devam etmiyor.
               }
        }
    }

}

