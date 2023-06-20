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

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
	public partial class frmKullaniciRolleri : DevExpress.XtraEditors.XtraForm
	{
		CafeContext context = new CafeContext();
		RollerDal rollerDal = new RollerDal();
		int _kullaniciId;

		public frmKullaniciRolleri(int kullaniciId)
		{
			InitializeComponent();
			_kullaniciId = kullaniciId;
			gridControl1.DataSource = rollerDal.GetAll(context, r => r.KullaniciId == _kullaniciId);
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			rollerDal.Save(context);
			gridView1.RefreshData();
		}
	}
}