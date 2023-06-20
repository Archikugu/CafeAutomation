using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.WinTools;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu.WinForms.Kullanıcılar
{
	public partial class frmKullaniciGirisi : DevExpress.XtraEditors.XtraForm
	{
		private bool giris;
		private CafeContext context = new CafeContext();
		private KullaniciHareketleriDal KullaniciHareketleriDal = new KullaniciHareketleriDal();
		private KullaniciHareketleri entity = new KullaniciHareketleri();
		void BilgileriGetir()
		{
			if (Properties.Settings.Default.BeniHatirla)
			{
				txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
				txtSifre.Text = Properties.Settings.Default.Parola;
				checkBeniHatırla.Checked = true;
			}
			else
			{
				txtKullaniciAdi.Text = null;
				txtSifre.Text = null;
				checkBeniHatırla.Checked = false;
			}
		}
		void BilgileriKaydet()
		{
			if (checkBeniHatırla.Checked)
			{
				Properties.Settings.Default.KullaniciAdi = txtKullaniciAdi.Text;
				Properties.Settings.Default.Parola = txtSifre.Text;
				Properties.Settings.Default.BeniHatirla = true;
				Properties.Settings.Default.Save();
			}
			else
			{
				Properties.Settings.Default.KullaniciAdi = null;
				Properties.Settings.Default.Parola = null;
				Properties.Settings.Default.BeniHatirla = false;
				Properties.Settings.Default.Save();
			}
		}

		public frmKullaniciGirisi()
		{
			InitializeComponent();
			BilgileriGetir();
		}

		private void btnGiris_Click(object sender, EventArgs e)
		{
			var model = context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Parola == txtSifre.Text);
			if (model != null)
			{
				giris = true;
				BilgileriKaydet();
				KullaniciAyarlari.kullaniciId = model.Id;
				//entity.KullaniciId = model.Id;
				//string aciklama = model.KullaniciAdi + " adlı kullanıcı sisteme giriş yaptı";
				//KullaniciHareketleriDal.KullaniciHareketleriEkle(context, entity, aciklama);


				this.Close();
			}
			else
			{
				MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			if (!giris)
			{
				Application.Exit();
			}
		}

		private void frmKullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!giris)
			{
				Application.Exit();
			}
		}

		private void lblKaydol_Click(object sender, EventArgs e)
		{
			frmKaydol frm = new frmKaydol(new Entities.Models.Kullanicilar());
			frm.ShowDialog();
		}

		private void btnParolamiUnuttum_Click(object sender, EventArgs e)
		{
			frmParolamiUnuttum frm = new frmParolamiUnuttum();
			frm.ShowDialog();
		}

		
	}
}