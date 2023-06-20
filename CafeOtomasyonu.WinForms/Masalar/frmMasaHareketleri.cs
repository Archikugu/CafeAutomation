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

namespace CafeOtomasyonu.WinForms.Masalar
{
	public partial class frmMasaHareketleri : DevExpress.XtraEditors.XtraForm
	{
		CafeContext context = new CafeContext();
		MasaHareketleriDal masaHareketleriDal = new MasaHareketleriDal();
		int? _masaId;
		int? _menuId;
		int? _urunId;
		public frmMasaHareketleri(int? masaId = null, int? menuId = null, int? urunId = null)
		{
			InitializeComponent();
			_masaId = masaId;
			_menuId = menuId;
			_urunId = urunId;
			if (_masaId != null)
			{
				gridControl1.DataSource = masaHareketleriDal.GetAll(context, m => m.MasaId == masaId);
				return;
			}
			else if (_menuId != null)
			{
				gridControl1.DataSource = masaHareketleriDal.GetAll(context, m => m.Urun.MenuId == menuId);
				return;
			}
			if (_urunId != null)
			{
				gridControl1.DataSource = masaHareketleriDal.GetAll(context, m => m.UrunId == urunId);
				return;
			}
			gridControl1.DataSource = masaHareketleriDal.GetAll(context);
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}