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
    public partial class OdemeAlanı : Form
    {
        public OdemeAlanı()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ODEME o = new ODEME();
            txt_kartsahibi.Text = o.KSAdSoyad;
            txt_kartno.Text = o.KSNo;
            txt_ay.Text= o.SKAy.ToString();
            txt_yil.Text = o.SKYil.ToString();
            txt_cvv.Text = o.CVV;

            MessageBox.Show("Ödeme yapıldı.Aracınız kiralandı.");
            this.Hide();

        }
    }
}
