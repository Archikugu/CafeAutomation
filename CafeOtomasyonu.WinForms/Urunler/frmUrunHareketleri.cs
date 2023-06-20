using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Mapping;
using CafeOtomasyonu.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu.WinForms.Urunler
{
	public partial class frmUrunHareketleri : DevExpress.XtraEditors.XtraForm
	{
		CafeContext context = new CafeContext();
		UrunHareketleriDal urunHareketleriDal = new UrunHareketleriDal();
		public frmUrunHareketleri()
		{
			InitializeComponent();
			context.UrunHareketleris.Load();
			gridControl1.DataSource = context.UrunHareketleris.Local.ToBindingList();
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
				urunHareketleriDal.Delete(context, u => u.Id == seciliId);
				urunHareketleriDal.Save(context);
				gridControl1.DataSource = urunHareketleriDal.GetAll(context);
			}
		}
	}
}