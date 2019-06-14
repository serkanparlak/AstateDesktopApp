using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlisansProje2
{
    public partial class Hesap_Ayarları : Form
    {
        public Hesap_Ayarları(int id)
        {
            InitializeComponent();
            kul_id = id;
            var sorgu = edm.kullanicis.SingleOrDefault(x => x.ID == kul_id);
            txtKul_Adi.Text = sorgu.kullaniciAdi;
            txtSifre.Text = sorgu.sifre;
            txtAd.Text = sorgu.ad;
            txtSoyad.Text = sorgu.soyad;
            txtTelefon.Text = sorgu.telefon;
            lblRol.Text = sorgu.rol == "Admin" ?
                "Admin" : "Kullanıcı";
        }
        int kul_id;
        EmlakServerEntitiess edm = new EmlakServerEntitiess();
        private void btnHesapGuncelle_Click(object sender, EventArgs e)
        {
            if (txtSifre.TextLength < 4) { MessageBox.Show("Şifre 4 haneden az olamaz!"); return; }
            if (txtTelefon.TextLength < 11) { MessageBox.Show("Telefon hatalı!"); return; }
            kullanici kl = edm.kullanicis.SingleOrDefault(x => x.ID == kul_id);
            kl.kullaniciAdi = txtKul_Adi.Text;
            kl.sifre = txtSifre.Text;
            kl.ad = txtAd.Text;
            kl.soyad = txtSoyad.Text;
            kl.telefon = txtTelefon.Text;
            try
            {
                edm.SaveChanges();
                MessageBox.Show("Güncelleme başarılı!","Güncel",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("Bir hata oluştu!"); }
                
        }

        private void chkSifre_Goster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = chkSifre_Goster.Checked == true ?
                '\0' : '*';
        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hesap silinecek!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
            {
                kullanici kl = edm.kullanicis.SingleOrDefault(x => x.ID == kul_id);
                try
                {
                    edm.kullanicis.Remove(kl);
                    edm.SaveChanges();
                    this.Hide();
                    Form1 fr = new Form1();
                    fr.Show();
                }
                catch { MessageBox.Show("Silme başarısız!"); };
            }
            
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
