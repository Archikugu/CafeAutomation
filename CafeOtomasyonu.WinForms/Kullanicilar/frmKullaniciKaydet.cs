using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Interfaces;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.AnaMenu;
using CafeOtomasyonu.WinForms.WinTools;
using DevExpress.XtraBars;
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

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
	public partial class frmKullaniciKaydet : DevExpress.XtraEditors.XtraForm
	{
		CafeContext context = new CafeContext();
		Entities.Models.Kullanicilar _kullanicilar;
		KullaniciHareketleri kullaniciHareketleri = new KullaniciHareketleri();
		KullanicilarDal kullanicilarDal = new KullanicilarDal();
		KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();
		string _girisYapanKullanici;
		public frmKullaniciKaydet(Entities.Models.Kullanicilar kullanicilar, string girisYapanKullanici = null)
		{
			InitializeComponent();
			_kullanicilar = kullanicilar;
			_girisYapanKullanici = girisYapanKullanici;
			toggleSwitchAktifMi.DataBindings.Add("EditValue", _kullanicilar, "AktifMi", true);
			txtAdSoyad.DataBindings.Add("Text", _kullanicilar, "AdSoyad");
			txtTelefon.DataBindings.Add("Text", _kullanicilar, "Telefon");
			txtEmail.DataBindings.Add("Text", _kullanicilar, "Email");
			txtAdres.DataBindings.Add("Text", _kullanicilar, "Adres");
			txtGorevi.DataBindings.Add("Text", _kullanicilar, "Gorevi");
			txtKullaniciAdi.DataBindings.Add("Text", _kullanicilar, "KullaniciAdi");
			txtParola.DataBindings.Add("Text", _kullanicilar, "Parola");
			txtHatirlatmaSorusu.DataBindings.Add("Text", _kullanicilar, "HatirlatmaSorusu");
			txtCevap.DataBindings.Add("Text", _kullanicilar, "Cevap");
			txtAciklama.DataBindings.Add("Text", _kullanicilar, "Aciklama");
			if (_kullanicilar.Id == 0)
			{
				lblBaslik.Text = "Yeni Kullanici Ekleme Sayfası";
			}
			else if (_kullanicilar.Id != 0)
			{
				lblBaslik.Text = _kullanicilar.KullaniciAdi + " Bilgileri Sayfası";
			}

		}

		private void btnKullaniciKaydet_Click(object sender, EventArgs e)
		{
			if (lblBaslik.Text == "Yeni Kullanici Ekleme Sayfası")
			{
				_kullanicilar.KayitTarihi = DateTime.Now;
				if (kullanicilarDal.AddOrUpdate(context, _kullanicilar))
				{
					kullanicilarDal.Save(context);
					var idMax = context.Kullanicilar.Max(k => k.Id);
					kullaniciHareketleri.KullaniciId = idMax;
					string aciklama = "Admin Tarafından Yeni Kullanıcı Eklendi";
					kullaniciHareketleriDal.KullaniciHareketleriEkle(context, kullaniciHareketleri, aciklama);

					frmAnaMenu frm = new frmAnaMenu();
					foreach (var item in frm.ribbon.Items)
					{
						if (item is BarButtonItem)
						{
							var btn = item as BarButtonItem;
							if (btn.Caption != "")
							{
								Entities.Models.Roller rol = new Entities.Models.Roller
								{
									KullaniciId = context.Kullanicilar.Max(k => k.Id),
									FormName = "frmAnaMenu",
									ControlCaption = btn.Caption,
									ControlName = btn.Name,
									Visible = false,
								};
								context.Rollers.Add(rol);
								context.SaveChanges();
							}
						}
					}
					this.Close();
				}
			}
			else
			{
				if (kullanicilarDal.AddOrUpdate(context, _kullanicilar))
				{
					kullanicilarDal.Save(context);
					var id = _kullanicilar.Id;
					kullaniciHareketleri.KullaniciId = id;
					string aciklama;
					if (_girisYapanKullanici != null)
					{
						// var model = kullanicilarDal.GetByFilter(context, k => k.Id == KullaniciAyarlari.kullaniciId);
						aciklama = _kullanicilar.KullaniciAdi + " bilgileri güncelledi ";
					}
					else
					{
						aciklama = "Admin Tarafından " + _kullanicilar.KullaniciAdi + " 'nın bilgileri güncellendi";
					}
					kullaniciHareketleriDal.KullaniciHareketleriEkle(context, kullaniciHareketleri, aciklama);
					this.Close();
				}
			}
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}