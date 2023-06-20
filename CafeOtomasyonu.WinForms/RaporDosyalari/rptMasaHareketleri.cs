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
	public partial class rptMasaHareketleri : DevExpress.XtraReports.UI.XtraReport
	{
		CafeContext context = new CafeContext();
		MasaHareketleriDal masaHareketleriDal = new MasaHareketleriDal();
		public rptMasaHareketleri()
		{
			InitializeComponent();
			ObjectDataSource source = new ObjectDataSource();
			source.DataSource = masaHareketleriDal.GetAll(context);
			DataSource = source;
			xrTableId.DataBindings.Add("Text", DataSource, "Id");
			xrTableSatisKodu.DataBindings.Add("Text", DataSource, "SatisKodu");
			xrTableMasaAdi.DataBindings.Add("Text", DataSource, "Masalar.MasaAdi");
			xrTableMenu.DataBindings.Add("Text", DataSource, "Urun.Menu.MenuAdi");
			xrTableUrunAdi.DataBindings.Add("Text", DataSource, "Urun.UrunAdi");
			xrTableMiktari.DataBindings.Add("Text", DataSource, "Miktari");
			xrTableFiyati.DataBindings.Add("Text", DataSource, "BirimFiyati");
			xrTableIndirimTutari.DataBindings.Add("Text", DataSource, "IndirimTutari");
			xrTableAciklama.DataBindings.Add("Text", DataSource, "Aciklama");
			xrTableTarih.DataBindings.Add("Text", DataSource, "Tarih");
		}


	}
}
