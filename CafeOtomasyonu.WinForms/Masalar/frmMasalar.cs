using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Mapping;
using CafeOtomasyonu.Entities.Models;
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

namespace CafeOtomasyonu.WinForms.Masalar
{
	public partial class frmMasalar : DevExpress.XtraEditors.XtraForm
	{
		CafeContext context = new CafeContext();
		MasalarDal masalarDal = new MasalarDal();

		public frmMasalar()
		{
			InitializeComponent();
			Listele();
		}

		private void Listele()
		{
			gridControl1.DataSource = masalarDal.MasalariListele(context);
		}

		private void btnYenile_Click(object sender, EventArgs e)
		{
			Listele();
		}

		private void btnYeni_Click(object sender, EventArgs e)
		{
			frmMasaKaydet frm = new frmMasaKaydet(new Entities.Models.Masalar());
			frm.ShowDialog();
			if (frm.kaydet)
			{
				Listele();
			}
		}

		private void btnDuzenle_Click(object sender, EventArgs e)
		{
			int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
			var masalar = masalarDal.GetByFilter(context, m => m.Id == seciliId);
			frmMasaKaydet frm = new frmMasaKaydet(masalar);
			frm.ShowDialog();
			if (frm.kaydet)
			{
				Listele();
			}
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
			if (MessageBox.Show("Seçili Kayıt Silinecek Onaylıyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				masalarDal.Delete(context, m => m.Id == seciliId);
				masalarDal.Save(context);
				Listele();
			}
		}

		private void btnDurumDegistir_Click(object sender, EventArgs e)
		{

			if (gridView1.SelectedRowsCount > 0)
			{
				int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
				var masalar = masalarDal.GetByFilter(context, m => m.Id == seciliId);
				if (masalar.Durumu)
				{
					masalar.Durumu = false;
				}
				else if (!masalar.Durumu)
				{
					masalar.Durumu = true;
				}
			}
			masalarDal.Save(context);
			Listele();
		}

		private void btnRezerveDegistir_Click(object sender, EventArgs e)
		{
			if (gridView1.SelectedRowsCount > 0)
			{
				int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
				var masalar = masalarDal.GetByFilter(context, m => m.Id == seciliId);
				if (masalar.RezerveMi)
				{
					masalar.RezerveMi = false;
				}
				else if (!masalar.RezerveMi)
				{
					masalar.RezerveMi = true;
				}
			}
			masalarDal.Save(context);
			Listele();
		}

		private void btnMasaHareketleri_Click(object sender, EventArgs e)
		{
			int seciliMasaId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
			frmMasaHareketleri frm = new frmMasaHareketleri(masaId: seciliMasaId);
			frm.ShowDialog();
		}
	}
}