using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CafeOtomasyonu.WinForms.RaporDosyalari
{
	public partial class rptSiparisFisi : DevExpress.XtraReports.UI.XtraReport
	{
		CafeContext context = new CafeContext();
		MasaHareketleriDal masaHareketleriDal = new MasaHareketleriDal();
		public rptSiparisFisi(string satisKodu, string bilgi, Entities.Models.Satislar satislar = null)
		{
			InitializeComponent();
			ObjectDataSource source = new ObjectDataSource();
			xrLabelBilgi.Text = bilgi;
			source.DataSource = masaHareketleriDal.GetAll(context, m => m.SatisKodu == satisKodu);
			this.DataSource = source;
			xrTableUrunAdi.DataBindings.Add("Text", DataSource, "Urun.UrunAdi");
			xrTableMiktari.DataBindings.Add("Text", DataSource, "Miktari");
			xrTableIndirim.DataBindings.Add("Text", DataSource, "IndirimTutari");
			xrTableFiyati.DataBindings.Add("Text", DataSource, "BirimFiyati");
			xrLblKalan.Text = satislar.Kalan.ToString("C2");
			xrLblOdenen.Text = satislar.Odenen.ToString("C2");

		}

	}
}
