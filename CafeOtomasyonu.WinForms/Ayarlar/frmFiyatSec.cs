using CafeOtomasyonu.Entities.Models;
using DevExpress.Utils.MVVM.Services;
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

namespace CafeOtomasyonu.WinForms.Ayarlar
{
	public partial class frmFiyatSec : DevExpress.XtraEditors.XtraForm
	{
		CafeContext context = new CafeContext();
		public frmFiyatSec()
		{
			InitializeComponent();
			List<object> obj = new List<object>();
			int i = 0;
			foreach (var item in typeof(Urun).GetProperties())
			{
				if (item.Name.Contains("BirimFiyati"))
				{
					obj.Insert(i, item.Name);
					i++;
				}

			}
			lookUpBirimFiyati.Properties.DataSource = obj;
			AyarGetir();
		}

		private void AyarGetir()
		{
			var model = context.ProgramAyarlari.FirstOrDefault(p => p.AyarTanimi == "Birim Fiyatı");
			if (model != null)
			{
				lookUpBirimFiyati.EditValue = model.AyarAdi;
			}
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			var modelProgram = context.ProgramAyarlari.FirstOrDefault(p => p.AyarTanimi == "Birim Fiyatı");
			if (modelProgram != null)
			{
				modelProgram.AyarAdi = lookUpBirimFiyati.EditValue.ToString();
			}
			else if (modelProgram == null)
			{
				ProgramAyarlari entity = new ProgramAyarlari
				{
					AyarTanimi = "Birim Fiyatı",
					AyarAdi = lookUpBirimFiyati.EditValue.ToString()
				};
				context.ProgramAyarlari.Add(entity);
			}
			context.SaveChanges();
			AyarGetir();
			MessageBox.Show("Ayarlar kaydedildi");
		}
		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}



