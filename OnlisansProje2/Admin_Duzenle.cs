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
    public partial class Admin_Duzenle : Form
    {
        EmlakServerEntitiess edm = new EmlakServerEntitiess();
        public Admin_Duzenle(int index)
        {
            InitializeComponent();
            ilanDuzenleMetod(index);
            SorguDetayMetod(index);
            DigerIslemler(index);
            resimGetir(index);
            ilanID = index;
            b = 1;
        }
        int ilanID;
        public void kullanicimi(int kul_id)//Kullanıcı Formdan çağrılıyor!
        {
            var sor1 = edm.ilans.SingleOrDefault(x => x.ID == ilanID);
            var sor_kul = edm.kullanicis.SingleOrDefault(x => x.ID == sor1.kullaniciID);
            var sor_kul2 = edm.kullanicis.SingleOrDefault(x => x.ID == kul_id);
            if (sor_kul.ID != sor_kul2.ID)
            {
                btnilan_Guncelle.Visible = false;
                linkFoto_Degistir.Visible = false;
            }
            else
            {
                btnilan_Guncelle.Visible = true;
                linkFoto_Degistir.Visible = true;
            }
        }
            
        private void resimGetir(int index)
        {
            ilan ilan_sor = edm.ilans.SingleOrDefault(x => x.ID == index);
            foto ft = edm.fotoes.SingleOrDefault(x => x.ID == ilan_sor.fotoID);
            SqlConnection bag = new SqlConnection(@"Data Source=SERKAN\SQLEXPRESS;Initial Catalog=EmlakServer;Integrated Security=True");
            bag.Open();
            SqlCommand komut = new SqlCommand("Select * from foto where ID = '"+ilan_sor.fotoID+"' ", bag);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                try
                {
                    byte[] Pic = (byte[])oku["fotograf"];
                    MemoryStream Resim1 = new MemoryStream(Pic);
                    Image img = Image.FromStream(Resim1);
                    picture_Foto_Duzenle.Image = img;
                }
                catch
                {
                    MessageBox.Show("Resim yüklenirken bir hata oluştu..");
                }
            }
            bag.Close();
        }

        private void DigerIslemler(int ilan_id)
        {
            var sorgu_ilan = edm.ilans.SingleOrDefault(x => x.ID == ilan_id);
            var sorgu_semt = edm.semts.SingleOrDefault(x => x.ID == sorgu_ilan.semtID);
            var sorgu_ilce = edm.ilces.SingleOrDefault(x => x.ID == sorgu_semt.ilceID);
            var sorgu_il = edm.ils.SingleOrDefault(x => x.ID == sorgu_ilce.ilID);

            var sorgu_kul = edm.kullanicis.SingleOrDefault(x => x.ID == sorgu_ilan.kullaniciID);
            txtKul_Duzen_Adi.Text = sorgu_kul.kullaniciAdi;

            cmbKat_Duzen.DataSource = edm.kategoris.ToList();
            cmbKat_Duzen.DisplayMember = "kategoriAdi";
            cmbKat_Duzen.ValueMember = "ID";
            cmbKat_Duzen.SelectedValue = sorgu_ilan.kategoriID;

            cmbTur_Duzen.DataSource = edm.turs.ToList();
            cmbTur_Duzen.DisplayMember = "turAdi";
            cmbTur_Duzen.ValueMember = "ID";
            cmbTur_Duzen.SelectedValue = sorgu_ilan.turID;

            cmbil_Duzen.DataSource = edm.ils.ToList();
            cmbil_Duzen.DisplayMember = "ilAdi";
            cmbil_Duzen.ValueMember = "ID";
            cmbil_Duzen.SelectedValue = sorgu_il.ID;

            cmbilce_Duzen.DataSource = edm.ilces.Where(x => x.ilID == sorgu_il.ID).ToList();
            cmbilce_Duzen.DisplayMember = "ilceAdi";
            cmbilce_Duzen.ValueMember = "ID";
            cmbilce_Duzen.SelectedValue = sorgu_ilce.ID;

            cmbSemt_Duzen.DataSource = edm.semts.Where(x => x.ilceID == sorgu_ilce.ID).ToList();
            cmbSemt_Duzen.DisplayMember = "semtAdi";
            cmbSemt_Duzen.ValueMember = "ID";
            cmbSemt_Duzen.SelectedValue = sorgu_ilan.semtID;

            b = 1;
        }
        private void SorguDetayMetod(int k)
        {
            var sorgu_detaymı = edm.ilans.SingleOrDefault(x => x.ID == k);
            var sorgu2 = edm.ilanDetays.SingleOrDefault(x => x.ilanID == sorgu_detaymı.detay_ID);
            cmbDetay_Duzen_OdaSayi.SelectedItem = sorgu2.odaSayisi;
            cmbDetay_Duzen_Isıtma.SelectedItem = sorgu2.isitma;
            numDetay_Duzen_KatSayisi.Value = (int)sorgu2.katSayisi;
            if (sorgu2.esyalimi == "Eşyalı")
                rdbDetay_Duzen_Esyalı.Checked = true;
            else
                rdbDetay_Duzen_Esyasız.Checked = true;
            numDetay_Duzen_Bulun_Kat.Value = (int)sorgu2.bulunduguKat;
            numDetay_Duzen_BinaYas.Value = (int)sorgu2.binaYasi;
            txtDetay_Duzen_Aciklama.Text = sorgu2.aciklama;

        }

        private void ilanDuzenleMetod(int i)
        {
            var sorgu = edm.ilans.SingleOrDefault(x => x.ID == i);
            numilan_Duzen_ID.Value = (int)sorgu.ID;
            txtilan_Duzen_Baslik.Text = sorgu.baslik;
            numilan_Duzen_Fiyat.Value = (int)sorgu.fiyat;
            numilan_Duzen_M_Kare.Value = (int)sorgu.metrekare;
            dateilan_Duzen_Olusturma.Text = sorgu.oluşturmaTarihi.ToString();
        }
        int b;
        private void cmbil_Duzen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (b == 1)
            {
                var ilce_sorgu = edm.ilces.Where(y => y.ilID == (int)cmbil_Duzen.SelectedValue);
                cmbilce_Duzen.DataSource = ilce_sorgu.ToList();
            }
        }

        private void cmbilce_Duzen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (b == 1)
            {
                var semt_sorgu = edm.semts.Where(y => y.ilceID == (int)cmbilce_Duzen.SelectedValue);
                cmbSemt_Duzen.DataSource = semt_sorgu.ToList();
            }
        }
        string resimPath;
        private void linkFoto_Degistir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Resim Aç";
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Png Dosyası  (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picture_Foto_Duzenle.Image = Image.FromFile(openFileDialog1.FileName);
                resimPath = openFileDialog1.FileName.ToString();
            }
        }
        int k = 0;
        private void resimGuncelle(int index)
        {
            if (resimPath == null)
                return;
            ilan sorgu = edm.ilans.SingleOrDefault(x => x.ID == index);
            FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            SqlConnection bag = new SqlConnection(@"Data Source=SERKAN\SQLEXPRESS;Initial Catalog=EmlakServer;Integrated Security=True");
            SqlCommand kmt = new SqlCommand();
            kmt.Connection = bag;
            if(sorgu.fotoID == 18)
            {
                kmt.CommandText = "insert into foto(fotograf) Values(@image)";
                k = 1;
            }
            else
            {
                kmt.CommandText = "update foto set fotograf = @image where ID = '"+sorgu.fotoID+"'";
            }
            kmt.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;
            try
            {
                bag.Open();
                kmt.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Resim güncelleme esnasında bir hata oluştu");
            }
            bag.Close();
        }
        private void btnilan_Guncelle_Click(object sender, EventArgs e)
        {
            resimGuncelle(ilanID);
            try
            {
                ilan iln = edm.ilans.SingleOrDefault(x => x.ID == ilanID);
                if(k == 1)
                {
                    k = edm.fotoes.Max(x => x.ID);
                    iln.fotoID = k;
                    k = 0;
                }
                iln.baslik = txtilan_Duzen_Baslik.Text;
                iln.fiyat = (int)numilan_Duzen_Fiyat.Value;
                iln.metrekare = int.Parse(numilan_Duzen_M_Kare.Text);
                iln.oluşturmaTarihi = dateilan_Duzen_Olusturma.Value;
                iln.kategoriID = (int)cmbKat_Duzen.SelectedValue;
                iln.turID = (int)cmbTur_Duzen.SelectedValue;
                iln.semtID = (int)cmbSemt_Duzen.SelectedValue;

                var sorgu_detay = edm.ilans.SingleOrDefault(x => x.ID == ilanID);
                ilanDetay idt = edm.ilanDetays.SingleOrDefault(x => x.ilanID == sorgu_detay.detay_ID);
                idt.odaSayisi = (string)cmbDetay_Duzen_OdaSayi.SelectedItem;
                idt.isitma = (string)cmbDetay_Duzen_Isıtma.SelectedItem;
                idt.katSayisi = (int)numDetay_Duzen_KatSayisi.Value;
                idt.bulunduguKat = (int)numDetay_Duzen_Bulun_Kat.Value;
                idt.esyalimi = rdbDetay_Duzen_Esyalı.Checked ?
                    rdbDetay_Duzen_Esyalı.Text :
                    rdbDetay_Duzen_Esyasız.Text;
                idt.binaYasi = (int)numDetay_Duzen_BinaYas.Value;
                idt.aciklama = txtDetay_Duzen_Aciklama.Text;

                edm.SaveChanges();
                MessageBox.Show("Güncelleme işlemi başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var ilanim = edm.ilans.SingleOrDefault(x => x.ID == ilanID);
            var kullanicim = edm.kullanicis.SingleOrDefault(x => x.ID == ilanim.kullaniciID);
            lblTelefon.Text = kullanicim.telefon;
        }
        
    }
}
