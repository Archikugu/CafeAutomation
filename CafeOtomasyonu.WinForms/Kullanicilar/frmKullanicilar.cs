using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.Kullanicilar;
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

namespace CafeOtomasyonu.WinForms.Kullanıcılar
{
	public partial class frmKullanicilar : DevExpress.XtraEditors.XtraForm
	{
		CafeContext context = new CafeContext();
		KullanicilarDal kullanicilarDal = new KullanicilarDal();
		KullaniciHareketleri kullaniciHareketleri = new KullaniciHareketleri();
		public frmKullanicilar()
		{
			InitializeComponent();
			Listele();
			KullaniciYetki.AdminMi(context, btnKaydet, btnGuncelle, btnEkle, btnRoller, gridControl1);
		}

		private void Listele()
		{
			gridControl1.DataSource = kullanicilarDal.GetAll(context);
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			context.SaveChanges();
			Listele();

		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			frmKullaniciKaydet frm = new frmKullaniciKaydet(new Entities.Models.Kullanicilar());
			frm.ShowDialog();
			Listele();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
			var model = kullanicilarDal.GetByFilter(context, k => k.Id == seciliId);
			frmKullaniciKaydet frm = new frmKullaniciKaydet(model);
			frm.ShowDialog();
			Listele();
		}

		private void btnRoller_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
			frmKullaniciRolleri frm = new frmKullaniciRolleri(id);
			frm.ShowDialog();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
			if (MessageBox.Show("Kayıt Silinsin mi","Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				kullanicilarDal.Delete(context, c => c.Id == seciliId);
				kullanicilarDal.Save(context);
				gridControl1.DataSource = kullanicilarDal.GetAll(context);
			}
		}
	}
}
