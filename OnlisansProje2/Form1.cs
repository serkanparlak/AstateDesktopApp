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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelSifreHatırla.Hide();
        }
        EmlakServerEntitiess edm = new EmlakServerEntitiess();

        private void txtKullaniciGiris_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == (string)txt.Tag)
            {
                txt.Text = "";
                txt.ForeColor = Color.DarkSlateGray;
            }
        }

        private void txtKullaniciGiris_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim() == "")
            {
                txt.Text = (string)txt.Tag;
                txt.ForeColor = Color.Gray;
            }
        }
        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            if (bosKontrol()) return;
            kullanici kln = edm.kullanicis.SingleOrDefault(x=>x.kullaniciAdi==textBox1.Text);
            kullanici kl = new kullanici();
            if (kln != null)
            {
                lblUyelik.Text = "Kullanıcı zaten var!";
                return;
            }
            if (textBox2.TextLength < 4)
            {
                lblUyelik.Text = "Şifre en az 4 haneli olmalı!";
                return;
            }
            if (textBox5.TextLength < 11)
            {
                lblUyelik.Text = "Numaranız 11 haneli olmalı!";
                return;
            }
            kl.kullaniciAdi = textBox1.Text;
            kl.sifre = textBox2.Text;
            kl.ad = textBox3.Text;
            kl.soyad = textBox4.Text;
            kl.telefon = textBox5.Text;
            edm.kullanicis.Add(kl);
            edm.SaveChanges();
            lblUyelik.Text = "Üyelik işemi başarılı!";
        }
        bool b;
        private bool bosKontrol()
        {
            b = false;
            for (int i = 1; i < 6; i++)
            {
                TextBox tx = (TextBox)this.Controls.Find("textBox" + i, true)[0];
                if (tx.Text == "Kullanıcı Adı") { tx.ForeColor = Color.Red; b = true; }
                if (tx.Text == "Şifre") { tx.ForeColor = Color.Red; b = true; }
                if (tx.Text == "Ad") { tx.ForeColor = Color.Red; b = true; }
                if (tx.Text == "Soyad") { tx.ForeColor = Color.Red; b = true; }
                if (tx.Text == "Telefon") { tx.ForeColor = Color.Red; b = true; }
            }
            if (b) { lblUyelik.Text = "Boş alan bırakmayın"; return true; }
            else return false;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            kullanici kl = edm.kullanicis.SingleOrDefault(x => 
                x.kullaniciAdi == txtKullaniciGiris.Text &&
                x.sifre == txtSifreGiris.Text);
            if (kl != null)
            {
                if (kl.rol == "Admin")
                {
                    this.Hide();
                    Admin_Paneli adm = new Admin_Paneli(kl.ID);
                    adm.Show();
                }
                else
                {
                    this.Hide();
                    KullaniciForm kf = new KullaniciForm(kl.ID);
                    kf.Show();
                }
                
            }
            
            else
            {
                lblGiris.Text = "Hata..!";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelSifreHatırla.Show();
            panelGiris.Hide();
        }
        private void linkLabelKapat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtKullaniciHatirla.Text = "";
            lblSifreHatırla.Text = "";
            panelSifreHatırla.Hide();
            panelGiris.Show();
        }

        private void btnHatırlat_Click(object sender, EventArgs e)
        {
            kullanici kl = edm.kullanicis.SingleOrDefault(x => x.kullaniciAdi == txtKullaniciHatirla.Text);
            if (kl != null)
            {
                lblSifreHatırla.Text = kl.sifre;
            }
            else
            {
                lblSifreHatırla.Text = "Kullanıcı bulunamadı..";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSifreGoster_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnUyeGoster")
                textBox2.PasswordChar = '\0';
            else if (btn.Name == "btnGirisGoster")
                txtSifreGiris.PasswordChar = '\0';
        }

        private void btnUyeGoster_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnUyeGoster")
                textBox2.PasswordChar = '*';
            else if (btn.Name == "btnGirisGoster")
                txtSifreGiris.PasswordChar = '*';
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
