using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.Kullanıcılar;
using CafeOtomasyonu.WinForms.Kullanicilar;
using CafeOtomasyonu.WinForms.Masalar;
using CafeOtomasyonu.WinForms.Menuler;
using CafeOtomasyonu.WinForms.Musteriler;
using CafeOtomasyonu.WinForms.Odemeler;
using CafeOtomasyonu.WinForms.RaporDosyalari;
using CafeOtomasyonu.WinForms.RaporFormlari;
using CafeOtomasyonu.WinForms.Roller;
using CafeOtomasyonu.WinForms.Satislar;
using CafeOtomasyonu.WinForms.Urunler;
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
using CafeOtomasyonu.WinForms.WinTools;
using CafeOtomasyonu.WinForms.Ayarlar;
using CafeOtomasyonu.Entities.Tools;

namespace CafeOtomasyonu.WinForms.AnaMenu
{
	public partial class frmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		private CafeContext context = new CafeContext();
		KullanicilarDal kullanicilarDal = new KullanicilarDal();
		void FormGetir(XtraForm frm)
		{
			frm.MdiParent = this;
			frm.Show();
		}
		public frmAnaMenu()
		{
			InitializeComponent();

			//ConnectionTools.VeriDoldur(context);

			if (!context.Kullanicilar.Any(k => k.KullaniciAdi == "Admin"))
			{
				Entities.Models.Kullanicilar model = new Entities.Models.Kullanicilar
				{
					AdSoyad = "Gokhan Gok",
					Telefon = "5323563494",
					Adres = "Yenimahalle/Ankara",
					Email = "engokhangok@gmail.com",
					Gorevi = ".Net Developer",
					KullaniciAdi = "Admin",
					Parola = "Dark.5227",
					HatirlatmaSorusu = "Admin",
					Cevap = "Admin",
					Aciklama = "Admin",
					KayitTarihi = DateTime.Now,
					IsAdmin = true
				};
				context.Kullanicilar.Add(model);
				context.SaveChanges();

				foreach (var item in ribbon.Items)
				{
					if (item is BarButtonItem)
					{
						var btn = item as BarButtonItem;
						if (btn.Caption != "")
						{
							Entities.Models.Roller rol = new Entities.Models.Roller
							{
								KullaniciId = 1,
								FormName = "frmAnaMenu",
								ControlCaption = btn.Caption,
								ControlName = btn.Name,
								Visible = true,
							};
							context.Rollers.Add(rol);
							context.SaveChanges();
						}
					}
				}
			}

		}

		private void btnUrunler_ItemClick(object sender, ItemClickEventArgs e)
		{
			XtraForm frm = new frmUrunler();
			FormGetir(frm);
		}

		private void btnMenuler_ItemClick(object sender, ItemClickEventArgs e)
		{
			XtraForm frm = new frmMenuler();
			frm.ShowDialog();
		}

		private void btnMasalar_ItemClick(object sender, ItemClickEventArgs e)
		{
			XtraForm frm = new frmMasalar();
			FormGetir(frm);
		}

		private void frmAnaMenu_Load(object sender, EventArgs e)
		{
			frmKullaniciGirisi frm = new frmKullaniciGirisi();
			frm.ShowDialog();
			KullaniciYetki.YetkileriGetir(context, ribbon);
		}

		private void btnMasaSiparis_ItemClick(object sender, ItemClickEventArgs e)
		{
			XtraForm frm = new frmMasaDurumlari();
			FormGetir(frm);
		}

		private void btnMusteriler_ItemClick(object sender, ItemClickEventArgs e)
		{
			XtraForm frm = new frmMusteriler();
			FormGetir(frm);
		}

		private void btnSatislar_ItemClick(object sender, ItemClickEventArgs e)
		{
			XtraForm frm = new frmSatislar();
			FormGetir(frm);
		}

		private void btnOdemeHareketleri_ItemClick(object sender, ItemClickEventArgs e)
		{
			XtraForm frm = new frmOdemeHareketleri();
			FormGetir(frm);
		}

		private void btnPaketSiparisi_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (MessageBox.Show("Paket Sipariş İşlemini Onaylıyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				var model = context.SatisKodu.First();
				string satisKodu = model.SatisTanimi + model.Sayi;
				model.Sayi++;
				context.SaveChanges();
				XtraForm frm = new frmMasaSiparisleri(satisKodu: satisKodu, paketSiparis: true);
				frm.ShowDialog();
			}
		}

		private void btnMasaHareketleriRaporu_ItemClick(object sender, ItemClickEventArgs e)
		{
			rptMasaHareketleri report = new rptMasaHareketleri();
			frmRaporGoruntule2 frm = new frmRaporGoruntule2(report);
			frm.ShowDialog();
		}

		private void btnOzelRapor_ItemClick(object sender, ItemClickEventArgs e)
		{
			frmOzelRaporOlustur frm = new frmOzelRaporOlustur();
			frm.ShowDialog();
		}

		private void btnMasaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
		{
			XtraForm frm = new frmMasaHareketleri();
			FormGetir(frm);
		}

		private void btnDashboard_ItemClick(object sender, ItemClickEventArgs e)
		{
			XtraForm frm = new frmDashboard();
			FormGetir(frm);
		}

		private void btnKullanicilar_ItemClick(object sender, ItemClickEventArgs e)
		{
			frmKullanicilar frm = new frmKullanicilar();
			frm.ShowDialog();
		}

		private void btnBilgilerim_ItemClick(object sender, ItemClickEventArgs e)
		{
			var model = kullanicilarDal.GetByFilter(context, k => k.Id == KullaniciAyarlari.kullaniciId);
			frmKullaniciKaydet frm = new frmKullaniciKaydet(model);
			frm.ShowDialog();
		}

		private void btnAyarlar_ItemClick(object sender, ItemClickEventArgs e)
		{
			frmFiyatSec frm = new frmFiyatSec();
			frm.ShowDialog();
		}

		private void btnYedekle_ItemClick(object sender, ItemClickEventArgs e)
		{
			frmBackUp frm = new frmBackUp();
			frm.ShowDialog();
		}

		private void btnGrafik_ItemClick(object sender, ItemClickEventArgs e)
		{
			frmGrafik frm = new frmGrafik();
			FormGetir(frm);
		}

		private void btnKullaniciHareketleri_ItemClick(object sender, ItemClickEventArgs e)
		{
			frmKullaniciHareketleri frm = new frmKullaniciHareketleri();
			frm.ShowDialog();
		}

		private void btnUrunHareketleri_ItemClick(object sender, ItemClickEventArgs e)
		{
			frmUrunHareketleri frm = new frmUrunHareketleri();
			frm.ShowDialog();
		}
	}
}