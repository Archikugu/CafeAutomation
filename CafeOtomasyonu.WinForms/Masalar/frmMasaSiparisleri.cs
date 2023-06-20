using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.Odemeler;
using CafeOtomasyonu.WinForms.RaporDosyalari;
using CafeOtomasyonu.WinForms.RaporFormlari;
using CafeOtomasyonu.WinForms.Urunler;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu.WinForms.Menuler
{
	public partial class frmMasaSiparisleri : DevExpress.XtraEditors.XtraForm
	{
		CafeContext context = new CafeContext();
		MusterilerDal musterilerDal = new MusterilerDal();
		MasaHareketleriDal masaHareketleriDal = new MasaHareketleriDal();
		int? _masaId = null;
		string _satisKodu = null;
		OdemeHareketleriDal odemeHareketleriDal = new OdemeHareketleriDal();
		private Entities.Models.Satislar satislar;
		private SatislarDal satislarDal = new SatislarDal();
		private Entities.Models.Masalar masalar;
		private MasalarDal masalarDal = new MasalarDal();
		UrunDal urunDal = new UrunDal();
		bool _paketSiparis = false;
		bool yazdir;
		MenuDal menuDal = new MenuDal();
		frmUrunSec frm = new frmUrunSec();
		public frmMasaSiparisleri(int? masaId = null, string masaAdi = null, string satisKodu = null, bool paketSiparis = false)
		{
			InitializeComponent();
			_masaId = masaId;
			_satisKodu = satisKodu;
			_paketSiparis = paketSiparis;
			context.MasaHareketleri.Where(m => m.SatisKodu == _satisKodu).Load();
			context.OdemeHareketleri.Where(o => o.SatisKodu == _satisKodu).Load();
			context.Urun.Load(); //ürün adlarını listelemek 
			gridControlSiparisler.DataSource = context.MasaHareketleri.Local.ToBindingList();
			gridControlOdemeler.DataSource = context.OdemeHareketleri.Local.ToBindingList();

			lookUpMusteri.Properties.DataSource = musterilerDal.GetAll(context);
			if (_masaId != null)
			{
				lblBaslik.Text = masaAdi + " Siparisleri";
				masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);

			}
			else if (_masaId == null)
			{
				lblBaslik.Text = "Paket Siparişi veya Veresiye İşlemleri";
			}
			satislar = satislarDal.GetByFilter(context, s => s.SatisKodu == _satisKodu);
			if (satislar != null)
			{
				lookUpMusteri.EditValue = satislar.MusteriId;
				txtSatisAciklama.Text = satislar.Aciklama;
				dateEditTarih.Text = satislar.SonIslemTarihi.ToString("dd.MM.yyyy");
			}
			HizliSatis();
		}
		public void HizliSatis()
		{
			var model = menuDal.GetAll(context);
			foreach (var item in model)
			{
				var page = new XtraTabPage();
				page.Text = item.MenuAdi;
				page.Name = item.Id.ToString();
				page.Dock = DockStyle.Fill;
				xtraTabControl1.TabPages.Add(page);
				FlowLayoutPanel panel = new FlowLayoutPanel();
				panel.Dock = DockStyle.Fill;
				page.Controls.Add(panel);


				var modelHizliSatis = urunDal.GetAll(context, u => u.HizliSatis && u.MenuId == item.Id);
				foreach (var urun in modelHizliSatis)
				{
					SimpleButton btn = new SimpleButton();
					btn.Text = urun.UrunAdi;
					btn.Name = urun.Id.ToString();
					btn.Appearance.TextOptions.VAlignment = VertAlignment.Bottom;
					// düzeltilecek btn.ImageToTextAligment = ImageAlignToText.TopCenter;
					btn.Size = new Size(100, 100);
					var image = Image.FromFile(urun.Resim);
					imageList1.Images.Add(image);
					btn.ImageList = imageList1;
					btn.Image = imageList1.Images[0];
					imageList1.Images.RemoveAt(0);
					btn.Appearance.BackColor = Control.DefaultBackColor;
					btn.BorderStyle = BorderStyles.NoBorder;
					panel.Controls.Add(btn);
					btn.Click += Btn_Click;
				}

			}
		}

		private void Btn_Click(object sender, EventArgs e)
		{
			var senderbtn = sender as SimpleButton;
			MessageBox.Show(senderbtn.Text);

			int urunId = Convert.ToInt32(senderbtn.Name);
			var model = urunDal.GetByFilter(context, u => u.Id == urunId);

			MasaHareketleri entity = new MasaHareketleri
			{
				SatisKodu = _satisKodu,
				UrunId = urunId,
				MasaId = _masaId,
				Miktari = 1,
				IndirimOrani = 0,
				BirimFiyati = Fiyat(model),
				Aciklama = "",
				Tarih = DateTime.Now
			};
			masaHareketleriDal.AddOrUpdate(context, entity);


		}

		void Hesapla()
		{
			calcIndirimToplami.Value = Convert.ToDecimal(colIndirimTutari.SummaryItem.SummaryValue);
			calcIndirimliToplami.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
			calcOdenen.Value = Convert.ToDecimal(colOdenen.SummaryItem.SummaryValue);
			calcToplam.Value = calcIndirimToplami.Value + calcIndirimliToplami.Value;
			calcKalan.Value = calcIndirimliToplami.Value - calcOdenen.Value;
			//İndirim oranı 0 a bölünme de hata fırlatacak
			if (calcToplam.Value != 0)
			{
				calcIndirimOrani.Value = 100 * Convert.ToDecimal(colIndirimTutari.SummaryItem.SummaryValue) /
					(Convert.ToDecimal(colTutar.SummaryItem.SummaryValue) +
					Convert.ToDecimal(colIndirimTutari.SummaryItem.SummaryValue));
			}
			else if (calcToplam.Value == 0)
			{
				calcIndirimOrani.Value = 0;
			}
		}

		private void btnMusteriSil_Click(object sender, EventArgs e)
		{
			lookUpMusteri.EditValue = null;
		}

		private void repositorySiparisSil_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (MessageBox.Show("Seçili siparişin silinemesini onaylıyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				gridViewSiparisler.DeleteSelectedRows();
				Hesapla();
			}
		}

		private void repositoryOdemeSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			if (MessageBox.Show("Seçili ödemenin silinemesini onaylıyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				gridViewOdemeler.DeleteSelectedRows();
				Hesapla();
			}
		}
		decimal Fiyat(Urun model)
		{
			decimal birimFiyat = model.BirimFiyati1;
			var modelProgram = context.ProgramAyarlari.FirstOrDefault(p => p.AyarTanimi == "Birim Fiyatı");
			if (modelProgram != null)
			{
				switch (modelProgram.AyarAdi)
				{
					case "BirimFiyati1":
						birimFiyat = model.BirimFiyati1;
						break;
					case "BirimFiyati2":
						birimFiyat = model.BirimFiyati2;
						break;
					case "BirimFiyati3":
						birimFiyat = model.BirimFiyati3;
						break;

				}
			}
			return birimFiyat;
		}
		private void btnSiparisEkle_Click(object sender, EventArgs e)
		{

			frm.ShowDialog();
			if (frm.secildi)
			{
				MasaHareketleri entity = new MasaHareketleri
				{
					SatisKodu = _satisKodu,
					MasaId = _masaId,
					UrunId = frm.urunModel.Id,
					Miktari = 1,
					BirimFiyati = Fiyat(frm.urunModel),
					IndirimOrani = 0,
					Aciklama = "",
					Tarih = DateTime.Now,

				};
				masaHareketleriDal.AddOrUpdate(context, entity);
			}
		}


		private void gridViewSiparisler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
		{
			Hesapla();
		}

		private void btnYenile_Click(object sender, EventArgs e)
		{
			Hesapla();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (gridViewSiparisler.RowCount > 0)
			{
				if (dateEditTarih.EditValue != null)
				{
					if (satislar == null)
					{
						satislar = new Entities.Models.Satislar();
						satislar.SatisKodu = _satisKodu;
					}
					satislar.MusteriId = (int?)lookUpMusteri.EditValue;
					satislar.Aciklama = txtSatisAciklama.Text;
					satislar.SonIslemTarihi = Convert.ToDateTime(dateEditTarih.EditValue);
					satislar.Kalan = calcKalan.Value;
					satislar.Odenen = calcOdenen.Value;
					satislar.Tutar = calcToplam.Value;
					satislar.IndirimToplami = calcIndirimToplami.Value;
					satislar.PaketSiparisMi = _paketSiparis;
					satislarDal.AddOrUpdate(context, satislar);
					context.SaveChanges();
					yazdir = true;
				}
				else
				{
					MessageBox.Show("Tarih Girilmesi gerekir", "Uyarı");
				}
			}
			else
			{
				MessageBox.Show("Herhangi bir kayıt bulunamadı", "Gokhan Gok 190255049");
			}
		}
		private void btnOdemeler_Click(object sender, EventArgs e)
		{
			if (gridViewSiparisler.RowCount > 0)
			{
				var btn = sender as SimpleButton;
				frmOdeme frm = new frmOdeme(btn.Text, _satisKodu, calcKalan.Value);
				frm.ShowDialog();
				if (frm.kaydedildi)
				{
					if (odemeHareketleriDal.AddOrUpdate(context, frm.odemeHareketleri))
					{
						gridViewOdemeler.RefreshData();
						Hesapla();
					}
				}
			}
		}

		private void gridViewOdemeler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
		{
			Hesapla();
		}

		private void btnSonuclandır_Click(object sender, EventArgs e)
		{
			if (gridViewSiparisler.RowCount > 0)
			{
				if (_masaId != null)
				{
					//Borçlu müşteri için 
					if (calcKalan.Value > 0)
					{
						if (MessageBox.Show("Bu işlemi onaylarsanız müşteriye borç işlemi kaydedilecektir", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
						{
							if (satislar != null)
							{

								if (satislar.MusteriId == null)
								{
									MessageBox.Show("Önce Müşteri Seçmelisiniz");
								}
								else
								{
									Sonuclandır();
									this.Close();
								}
							}
						}

					}
					else if (calcKalan.Value == 0)
					{
						Sonuclandır();
						this.Close();
					}
				}
			}
		}

		private void Sonuclandır()
		{
			//Hesap ödeme sonuçlandır kalan borç var mı kullanıcı getirme
			masalar.SatisKodu = null;
			masalar.Durumu = false;
			masalar.Islem = null;
			masalar.KullaniciId = null;
			masalarDal.AddOrUpdate(context, masalar);
			masalarDal.Save(context);
		}

		private void repositoryFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			int urunId = Convert.ToInt32(gridViewSiparisler.GetFocusedRowCellValue(colUrunId));
			var model = urunDal.GetByFilter(context, u => u.Id == urunId);
			barFiyat1.Caption = model.BirimFiyati1.ToString();
			barFiyat2.Caption = model.BirimFiyati2.ToString();
			barFiyat3.Caption = model.BirimFiyati3.ToString();
			radialMenu1.ShowPopup(MousePosition);
		}

		private void Fiyatlar(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			gridViewSiparisler.SetFocusedRowCellValue(colBirimFiyati, e.Item.Caption);
		}

		private void btnYazdir_Click(object sender, EventArgs e)
		{
			btnKaydet.PerformClick();
			if (yazdir)
			{
				if (_masaId != null)
				{
					rptSiparisFisi rpt = new rptSiparisFisi(_satisKodu, masalar.MasaAdi, satislar);
					frmRaporGoruntule frm = new frmRaporGoruntule(rpt);
					frm.ShowDialog();
				}
				else if (_masaId == null)
				{
					if (satislar.MusteriId == null)
					{
						rptSiparisFisi rpt = new rptSiparisFisi(_satisKodu, _satisKodu, satislar);
						frmRaporGoruntule frm = new frmRaporGoruntule(rpt);
						frm.ShowDialog();
					}
					else if (satislar.MusteriId != null)
					{
						rptSiparisFisi rpt = new rptSiparisFisi(_satisKodu, _satisKodu + satislar.Musteriler.AdiSoyadi, satislar);
						frmRaporGoruntule frm = new frmRaporGoruntule(rpt);
						frm.ShowDialog();
					}

				}
			}
		}

		private void gridViewSiparisler_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			Hesapla();
		}


	}
}
