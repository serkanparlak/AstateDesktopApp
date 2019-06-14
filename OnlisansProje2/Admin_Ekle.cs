using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlisansProje2
{
    public partial class Admin_Ekle : Form
    {
        EmlakServerEntitiess edm = new EmlakServerEntitiess();
        public Admin_Ekle()
        {
            InitializeComponent();
            comboDoldur();
        }
        public void ilan_sahip(int kul_id)//Kullanıcı ve Admin Formadan çağırılıyor!
        {
            var sahip = edm.kullanicis.SingleOrDefault(x => x.ID == kul_id);
            cmbKul_Ekle.SelectedValue = sahip.ID;
            if(sahip.rol != "Admin")
                cmbKul_Ekle.Enabled = false;
        }
        private void comboDoldur()
        {
            cmbKul_Ekle.DataSource = edm.kullanicis.ToList();
            cmbKul_Ekle.DisplayMember = "kullaniciAdi";
            cmbKul_Ekle.ValueMember = "ID";

            cmbKat_Ekle.DataSource = edm.kategoris.ToList();
            cmbKat_Ekle.DisplayMember = "kategoriAdi";
            cmbKat_Ekle.ValueMember = "ID";

            cmbTur_Ekle.DataSource = edm.turs.ToList();
            cmbTur_Ekle.DisplayMember = "turAdi";
            cmbTur_Ekle.ValueMember = "ID";

            cmbil_Ekle.DataSource = edm.ils.ToList();
            cmbil_Ekle.DisplayMember = "ilAdi";
            cmbil_Ekle.ValueMember = "ID";

            var ilce_sorgu = edm.ilces.Where(y => y.ilID == 1);
            cmbilce_Ekle.DataSource = ilce_sorgu.ToList();
            cmbilce_Ekle.DisplayMember = "ilceAdi";
            cmbilce_Ekle.ValueMember = "ID";

            var semt_sorgu = edm.semts.Where(y => y.ilceID == 1);
            cmbSemt_Ekle.DataSource = semt_sorgu.ToList();
            cmbSemt_Ekle.DisplayMember = "semtAdi";
            cmbSemt_Ekle.ValueMember = "ID";

            cmbDetay_Ekle_Oda.SelectedIndex = 0;
            cmbDetay_Ekle_Isitma.SelectedIndex = 0;

            a = 1; //ComboBox 'ların ilk başta çalışmaması için..
        }
        int a;
        private void cmbil_Ekle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a == 1)
            {
                var ilce_sorgu = edm.ilces.Where(y => y.ilID == (int)cmbil_Ekle.SelectedValue);
                cmbilce_Ekle.DataSource = ilce_sorgu.ToList();
            }

        }

        private void cmbilce_Ekle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a == 1)
            {
                var semt_sorgu = edm.semts.Where(y => y.ilceID == (int)cmbilce_Ekle.SelectedValue);
                cmbSemt_Ekle.DataSource = semt_sorgu.ToList();
            }
        }

        #region Resim Kısmı
        string resimPath;
        private void link_Ekle_Resim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Resim Aç";
            openFileDialog1.FileName = null;
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Png Dosyası  (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picture_Ekle_Resim.Image = Image.FromFile(openFileDialog1.FileName);
                resimPath = openFileDialog1.FileName.ToString();
            }
        }
        private void resimKaydet()
        {
            if (resimPath == null)
            {
                return;
            } 
            FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            SqlConnection bag = new SqlConnection(@"Data Source=SERKAN\SQLEXPRESS;Initial Catalog=EmlakServer;Integrated Security=True");
            SqlCommand kmt = new SqlCommand("insert into foto(fotograf) Values(@image)", bag);
            kmt.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;
            try
            {
                bag.Open();
                kmt.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim yükleme esnasında bir hata oluştu");
            }
            bag.Close();
        }
        #endregion
        private void btnilan_Kaydet_Click(object sender, EventArgs e)
        {
            bosAlanlar(); if(b) return;
            resimKaydet();
            try
            {
                ilanDetay idt = new ilanDetay();
                idt.aciklama = txtDetay_Ekle_Aciklama.Text;
                idt.binaYasi = (int)numDetay_Ekle_BinaYas.Value;
                idt.katSayisi = (int)numDetay_Ekle_KatSayisi.Value;
                idt.bulunduguKat = (int)numDetay_Ekle_BulunKat.Value;
                idt.esyalimi = rdbDetay_Ekle_Esyalı.Checked == true ?
                    rdbDetay_Ekle_Esyalı.Text :
                    rdbDetay_Ekle_Esyasiz.Text;
                idt.isitma = (string)cmbDetay_Ekle_Isitma.SelectedItem;
                idt.odaSayisi = (string)cmbDetay_Ekle_Oda.SelectedItem;

                edm.ilanDetays.Add(idt);
                edm.SaveChanges();

                ilan iln = new ilan();
                iln.baslik = txtilan_Ekle_Baslik.Text;
                iln.fiyat = (int)numilan_Ekle_Fiyat.Value;
                iln.kategoriID = (int)cmbKat_Ekle.SelectedValue;
                iln.kullaniciID = (int)cmbKul_Ekle.SelectedValue;
                iln.metrekare = (int)numilan_Ekle_MKare.Value;
                iln.oluşturmaTarihi = dateilan_Ekle_Tarih.Value;
                iln.turID = (int)cmbTur_Ekle.SelectedValue;
                iln.semtID = (int)cmbSemt_Ekle.SelectedValue;
                if (resimPath == null)
                    iln.fotoID = 18;
                else
                    iln.fotoID = edm.fotoes.Max(x => x.ID);

                iln.detay_ID = edm.ilanDetays.Max(x => x.ilanID);
                edm.ilans.Add(iln);
                edm.SaveChanges();
                MessageBox.Show("Ilan başarıyla kaydedildi..", "Başarılı");
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu", "Hata");
            }
        }
        bool b;
        private void bosAlanlar()
        {
            b = false;
            if (txtDetay_Ekle_Aciklama.Text.Trim() == "")
            {
                txtDetay_Ekle_Aciklama.BackColor = Color.RosyBrown;
                b = true;
            }
            if (txtilan_Ekle_Baslik.Text.Trim() == "")
            {
                txtilan_Ekle_Baslik.BackColor = Color.RosyBrown;
                b = true;
            }
        }

        private void txtilan_Ekle_Baslik_Enter(object sender, EventArgs e)
        {
            txtilan_Ekle_Baslik.BackColor = Color.White;
        }

        private void txtDetay_Ekle_Aciklama_Enter(object sender, EventArgs e)
        {
            txtDetay_Ekle_Aciklama.BackColor = Color.White;
        }
    }
}
