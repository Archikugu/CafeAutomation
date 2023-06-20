using CafeOtomasyonu.Entities.Models;
using DevExpress.XtraEditors;
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

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
	public partial class frmKullaniciHareketleri : DevExpress.XtraEditors.XtraForm
	{
		private CafeContext context = new CafeContext();
		public frmKullaniciHareketleri()
		{
			InitializeComponent();
			context.KullaniciHareketleri.Load();
			gridControl1.DataSource = context.KullaniciHareketleri.Local.ToBindingList();
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}