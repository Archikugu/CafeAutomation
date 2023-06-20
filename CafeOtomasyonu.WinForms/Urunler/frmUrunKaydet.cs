using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Interfaces;
using CafeOtomasyonu.Entities.Mapping;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.AnaMenu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu.WinForms.Urunler
{
	public partial class frmUrunKaydet : DevExpress.XtraEditors.XtraForm
	{
		private MenuDal menuDal = new MenuDal();
		private UrunDal urunDal = new UrunDal();
		private Urun _urun;
		private CafeContext context = new CafeContext();
		UrunHareketleri urunHareketleri = new UrunHareketleri();
		UrunHareketleriDal urunHareketleriDal = new UrunHareketleriDal();
		public bool kaydet = false;
		string _girisYapanKullanici;
		public frmUrunKaydet(Urun entity)
		{
			InitializeComponent();
			_urun = entity;
			lookUpMenu.Properties.DataSource = menuDal.GetAll(context);
			lookUpMenu.DataBindings.Add("EditValue", _urun, "MenuId");
			txtUrunAdi.DataBindings.Add("Text", _urun, "UrunAdi");
			txtUrunKodu.DataBindings.Add("Text", _urun, "UrunKodu");
			calcBirimFiyati1.DataBindings.Add("Text", _urun, "BirimFiyati1", true);
			calcBirimFiyati2.DataBindings.Add("Text", _urun, "BirimFiyati2", true);
			calcBirimFiyati3.DataBindings.Add("Text", _urun, "BirimFiyati3", true);
			txtAciklama.DataBindings.Add("Text", _urun, "Aciklama");
			dateEdit1.DataBindings.Add("Text", _urun, "Tarih", true);
			if (_urun.Id != 0)
			{
				if (_urun.Resim != null)
				{
					try
					{
						pictureEdit1.Image = Image.FromFile(_urun.Resim);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}

				}
			}
		}

		private void btnUrunKaydet_Click(object sender, EventArgs e)
		{
			if (pictureEdit1.GetLoadedImageLocation() != "")
			{
				string hedefYol = $"{Application.StartupPath}\\Image\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png";
				if (File.Exists(hedefYol))
				{
					File.Delete(hedefYol);
				}
				File.Copy(pictureEdit1.GetLoadedImageLocation(), hedefYol);
				_urun.Resim = $"Image\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png";
			}
			if (urunDal.AddOrUpdate(context, _urun))
			{
				urunDal.Save(context);
				kaydet = true;
				this.Close();
			}


			if (lblBaslik.Text == "Ürün Kayıt")
			{
				_urun.Tarih = DateTime.Now;
				if (urunDal.AddOrUpdate(context, _urun))
				{
					urunDal.Save(context);
					var idMax = context.Urun.Max(k => k.Id);
					urunHareketleri.UrunId = idMax;
					string aciklama = "Admin Tarafından Yeni Ürün Eklendi";
					urunHareketleriDal.UrunHareketleriEkle(context, urunHareketleri, aciklama);

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
				if (urunHareketleriDal.AddOrUpdate(context, urunHareketleri))
				{
					urunHareketleriDal.Save(context);
					var id = _urun.Id;
					urunHareketleri.UrunId = id;
					string aciklama;
					if (_girisYapanKullanici != null)
					{
						// var model = kullanicilarDal.GetByFilter(context, k => k.Id == KullaniciAyarlari.kullaniciId);
						aciklama = _urun.UrunAdi + " güncelledi ";
					}
					else
					{
						aciklama = "Admin Tarafından " + _urun.UrunAdi + " güncellendi";
					}
					urunHareketleriDal.UrunHareketleriEkle(context, urunHareketleri, aciklama);
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