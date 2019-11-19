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
    public partial class ArabaKayitcs : Form
    {
        public ArabaKayitcs()
        {
            InitializeComponent();
            ArabaList();  //araba kayıt sayfasına girer girmez listeyi görebilmek için yazdık.
        } 
        ProjectContext db = new ProjectContext();
       
        public void ArabaList()
        {
            lvw_aracozellik.Items.Clear();
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
                lvw_aracozellik.Items.Add(lv);

            }
        }

        private void Btn_arabakaydet_Click_1(object sender, EventArgs e)
        {
            Arabalar car = new Arabalar();
            car.Plaka = t_plakano.Text;
            car.Marka = t_marka.Text;
            car.Model = t_model.Text;
            car.AracTipi = cmb_aractipi.SelectedItem.ToString();
            car.Vites = cmb_vites.SelectedItem.ToString();
            car.YakıtTipi =cmb_yakittipi.SelectedItem.ToString();
            car.Fiyat = Convert.ToDouble(t_fiyat.Text);
            car.AktifMi = true;


            db.Cars.Add(car);
            db.SaveChanges();

            t_plakano.Text = string.Empty;
            t_marka.Text = string.Empty;
            t_model.Text = string.Empty;
            cmb_aractipi.SelectedIndex = -1;
            cmb_vites.SelectedIndex=-1;
            cmb_yakittipi.SelectedIndex=-1;
            t_fiyat.Text = string.Empty;

            ArabaList();
        }

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {

            if (lvw_aracozellik.SelectedItems.Count <= 0 && updated == null) return;
            updated.Plaka = t_plakano.Text;
            updated.Marka = t_marka.Text;
            updated.Model = t_model.Text;
            updated.AracTipi =(string)cmb_aractipi.SelectedItem;
            updated.Vites=(string)cmb_vites.SelectedItem;
            updated.YakıtTipi=cmb_yakittipi.SelectedItem.ToString();
            updated.Fiyat = Convert.ToDouble(t_fiyat.Text);
               

            db.Entry(db.Cars.Find(updated.ID)).CurrentValues.SetValues(updated);
            db.SaveChanges();

            t_plakano.Text = string.Empty;
            t_marka.Text = string.Empty;
            t_model.Text = string.Empty;
            cmb_aractipi.SelectedIndex = -1;
            cmb_vites.SelectedIndex = -1;
            cmb_yakittipi.SelectedIndex = -1;
            t_fiyat.Text = string.Empty;


            ArabaList();
        }
        Arabalar updated;

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            if (lvw_aracozellik.SelectedItems.Count <= 0) return;

            int id = Convert.ToInt32(lvw_aracozellik.SelectedItems[0].Tag);
            Arabalar deleted = db.Cars.Find(id);
            db.Cars.Remove(deleted);
            db.SaveChanges();
            ArabaList();
        }

        private void Lvw_aracozellik_DoubleClick(object sender, EventArgs e)
        {
            //FulRowSelected ı true yaptık
            int id = Convert.ToInt32(lvw_aracozellik.SelectedItems[0].Tag);
            updated = db.Cars.Find(id);
            t_plakano.Text = updated.Plaka;
            t_marka.Text = updated.Marka;
            t_model.Text = updated.Model;
            cmb_aractipi.SelectedValue = updated.AracTipi.ToString();
            cmb_vites.SelectedItem = updated.Vites;
            cmb_yakittipi.SelectedItem = updated.YakıtTipi.ToString();
            t_fiyat.Text =Convert.ToDouble(updated.Fiyat).ToString();
        }

        private void Btn_karackiralama_Click(object sender, EventArgs e)
        {
            KiralamaForm3 kkk = new KiralamaForm3();
            kkk.Show();
        }
    }
}
