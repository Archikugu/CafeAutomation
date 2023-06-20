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

namespace CafeOtomasyonu.WinForms.Odemeler
{
	public partial class frmOdemeHareketleri : DevExpress.XtraEditors.XtraForm
	{
		CafeContext context = new CafeContext();
		OdemeHareketleriDal odemeHareketleriDal = new OdemeHareketleriDal();

		public frmOdemeHareketleri(string satisKodu = null)
		{
			InitializeComponent();
			if (satisKodu == null)
			{
				gridControl1.DataSource = odemeHareketleriDal.GetAll(context);
			}
			else if (satisKodu != null)
			{
				gridControl1.DataSource = odemeHareketleriDal.GetAll(context, o => o.SatisKodu == satisKodu);
			}
		}
	}
}