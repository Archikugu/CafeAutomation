using CafeOtomasyonu.Entities.DAL;
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

namespace CafeOtomasyonu.WinForms.Urunler
{
	public partial class frmUrunSec : DevExpress.XtraEditors.XtraForm
	{
		CafeContext context = new CafeContext();
		UrunDal urunDal = new UrunDal();
		public Urun urunModel;
		public bool secildi;
		public frmUrunSec()
		{
			InitializeComponent();
			gridControl1.DataSource = urunDal.GetAll(context);
		}

		private void btnSec_Click(object sender, EventArgs e)
		{
			if (gridView1.SelectedRowsCount > 0)
			{
				int urunId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
				urunModel = urunDal.GetByFilter(context, u => u.Id == urunId);
				secildi = true;
				this.Close();
			}
		}
	}
}