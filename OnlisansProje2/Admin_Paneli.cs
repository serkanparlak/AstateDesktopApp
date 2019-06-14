using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlisansProje2
{
    public partial class Admin_Paneli : Form
    {
        public Admin_Paneli(int index)
        {
            InitializeComponent();
            adminbilgigetir(index);
            kul_id = index;
            cmbTur.DataSource = edm.turs.ToList();
            cmbTur.DisplayMember = "turAdi";
            cmbTur.ValueMember = "turAdi";
            cmbTur.SelectedIndex = -1;
        }

        EmlakServerEntitiess edm = new EmlakServerEntitiess();
        int kul_id;
        private void adminbilgigetir(int kullanici)
        {
            kullanici kl = edm.kullanicis.SingleOrDefault(x=>x.ID == kullanici);
            lblAdmin_Bilgi.Text = kl.kullaniciAdi+"\n"+kl.ad + " " + kl.soyad;
        }
        private void kolongenislik()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[1].Width = 175;
        }
        void listele()
        {
            var sorgu = from i in edm.ilans
                        join d in edm.ilanDetays on i.detay_ID equals d.ilanID
                        join t in edm.turs on i.turID equals t.ID
                        select new
                        {
                            i.ID,
                            i.baslik,
                            i.fiyat,
                            i.metrekare,
                            d.odaSayisi,
                            d.bulunduguKat,
                            d.isitma,
                            t.turAdi
                        };
            dataGridView1.DataSource = sorgu.OrderBy(i => i.baslik).ToList();
            kolongenislik();
        }
        int ilan_index;
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Admin_Duzenle adm_duzen = new Admin_Duzenle(ilan_index);
            adm_duzen.Show();
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ilan_index = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            btnIlanSil.Enabled = true;
        }
        private void Admin_Paneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnIlanlar_Click(object sender, EventArgs e)
        {
            listele();
            txt_Hizli_Ara.Text = "Hızlı arama";
            txt_Hizli_Ara.ForeColor = Color.Gray;
        }

        private void txt_Hizli_Ara_Leave(object sender, EventArgs e)
        {
            if (txt_Hizli_Ara.Text.Trim() == "")
            {
                txt_Hizli_Ara.Text = "Hızlı arama";
                txt_Hizli_Ara.ForeColor = Color.Gray;
            }
        }

        private void txt_Hizli_Ara_Enter(object sender, EventArgs e)
        {
            if (txt_Hizli_Ara.Text == "Hızlı arama")
            {
                txt_Hizli_Ara.Text = "";
                txt_Hizli_Ara.ForeColor = Color.Black;
            }
        }

        private void linkDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hesap_Ayarları hsp = new Hesap_Ayarları(kul_id);
            hsp.Show();
        }
        private void link_Admin_Cikis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Çıkış yapılacak!", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
        }

        private void btn_Hizli_Ara_Click(object sender, EventArgs e)
        {
            if (txt_Hizli_Ara.Text == "Hızlı arama")
                return;

            var sorgu = from i in edm.ilans
                        join d in edm.ilanDetays on i.detay_ID equals d.ilanID
                        join t in edm.turs on i.turID equals t.ID
                        select new
                        {
                            i.ID,
                            i.baslik,
                            i.fiyat,
                            i.metrekare,
                            d.odaSayisi,
                            d.bulunduguKat,
                            d.isitma,
                            t.turAdi
                        };

            dataGridView1.DataSource = sorgu.Where(i => i.baslik.Contains(txt_Hizli_Ara.Text)).OrderBy(i => i.fiyat).ToList();
            kolongenislik();
        }

        #region Fitreleme

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            var sorgu = from i in edm.ilans
                        join d in edm.ilanDetays on i.detay_ID equals d.ilanID 
                        join t in edm.turs on i.turID equals t.ID 
                        select new
                        {
                            i.ID,
                            i.baslik,
                            i.fiyat,
                            i.metrekare,
                            d.odaSayisi,
                            d.bulunduguKat,
                            d.isitma,
                            t.turAdi
                        };
            if (numMinFiyat.Value != 0)
            {
                sorgu = sorgu.Where(i => i.fiyat > (int)numMinFiyat.Value);
            }
            if (numMaxFiyat.Value != 0)
            {
                sorgu = sorgu.Where(i => i.fiyat < (int)numMaxFiyat.Value);
            }
            if (numMinMetre.Value != 0)
            {
                sorgu = sorgu.Where(i => i.metrekare > (int)numMinMetre.Value);
            }
            if (numMaxMetre.Value != 0)
            {
                sorgu = sorgu.Where(i => i.metrekare < (int)numMaxMetre.Value);
            }
            if (cmbOdaSayi.SelectedIndex != -1)
            {
                sorgu = sorgu.Where(d => d.odaSayisi == (string)cmbOdaSayi.SelectedItem);
            }
            if (cmbIsitma.SelectedIndex != -1)
            {
                sorgu = sorgu.Where(d => d.isitma == (string)cmbIsitma.SelectedItem);
            }
            if (cmbDaireKati.SelectedIndex != -1)
            {
                int bul_kat;
                if ((string)cmbDaireKati.SelectedItem == "15+")
                    sorgu = sorgu.Where(d => d.bulunduguKat > 15);
                else
                {
                    bul_kat = Convert.ToInt32(cmbDaireKati.SelectedItem);
                    sorgu = sorgu.Where(d => d.bulunduguKat == bul_kat);
                }
            }
            if (cmbTur.SelectedIndex != -1)
            {
                sorgu = sorgu.Where(t => t.turAdi == (string)cmbTur.SelectedValue);
            }

            dataGridView1.DataSource = sorgu.OrderBy(x => x.baslik).ToList();
            kolongenislik();
        }
        
        private void btnFiltreKaldir_Click(object sender, EventArgs e)
        {
            numMinFiyat.Value = 0;
            numMaxFiyat.Value = 0;
            numMinMetre.Value = 0;
            numMaxMetre.Value = 0;
            cmbOdaSayi.SelectedIndex = -1;
            cmbDaireKati.SelectedIndex = -1;
            cmbIsitma.SelectedIndex = -1;
            cmbTur.SelectedIndex = -1;
            dataGridView1.DataSource = null;
        }
        #endregion

        private void btnIlanEkle_Click(object sender, EventArgs e)
        {
            Admin_Ekle adm = new Admin_Ekle();
            adm.ilan_sahip(kul_id);
            adm.Show();
        }

        private void btnIlanSil_Click(object sender, EventArgs e)
        {
            try
            {
                ilan iln_sil = edm.ilans.SingleOrDefault(x => x.ID == ilan_index);
                ilanDetay dty_sil = edm.ilanDetays.SingleOrDefault(x => x.ilanID == iln_sil.detay_ID);
                foto ft_sil = edm.fotoes.SingleOrDefault(x => x.ID == iln_sil.fotoID);

                if (MessageBox.Show("Silmek istediğinize eminmisiniz", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    edm.ilans.Remove(iln_sil);
                    edm.ilanDetays.Remove(dty_sil);
                    if(ft_sil.ID != 18)
                        edm.fotoes.Remove(ft_sil);
                    edm.SaveChanges();
                    MessageBox.Show("Kayıt silindi");
                    listele();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }



        

        

        

    }
}
