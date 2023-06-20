using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.Masalar;
using CafeOtomasyonu.WinForms.Roller;
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

namespace CafeOtomasyonu.WinForms.Urunler
{
	public partial class frmUrunler : DevExpress.XtraEditors.XtraForm
	{
		private CafeContext context = new CafeContext();
		UrunDal urunDal = new UrunDal();

		public frmUrunler()
		{
			InitializeComponent();
			Listele();
			KullaniciYetki.AdminMi(context, btnSil);
		}

		private void Listele()
		{
			// gridControl1.DataSource = urunDal.UrunListele(context);
			gridControl1.DataSource = urunDal.GetAll(context);
		}

		private void btnYeni_Click(object sender, EventArgs e)
		{
			frmUrunKaydet frm = new frmUrunKaydet(new Urun());
			frm.ShowDialog();
			if (frm.kaydet)
			{
				Listele();
			}
		}

		private void btnDuzenle_Click(object sender, EventArgs e)
		{
			int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
			frmUrunKaydet frm = new frmUrunKaydet(urunDal.GetByFilter(context, u => u.Id == seciliId));
			frm.ShowDialog();
			if (frm.kaydet)
			{
				Listele();
			}
		}

		private void btnYenile_Click(object sender, EventArgs e)
		{
			Listele();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
			if (MessageBox.Show("Seçili Kayıt Silinecek Onaylıyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				urunDal.Delete(context, u => u.Id == seciliId);
				urunDal.Save(context);
				Listele();
			}
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMasaHareketleri_Click(object sender, EventArgs e)
		{
			int seciliUrunId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
			frmMasaHareketleri frm = new frmMasaHareketleri(urunId: seciliUrunId);
			frm.ShowDialog();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			context.SaveChanges();
			Listele();
		}
	}
}