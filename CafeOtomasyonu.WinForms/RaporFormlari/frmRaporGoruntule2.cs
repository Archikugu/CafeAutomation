using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu.WinForms.RaporFormlari
{
	public partial class frmRaporGoruntule2 : DevExpress.XtraEditors.XtraForm
	{
		public frmRaporGoruntule2(XtraReport report)
		{
			InitializeComponent();
			documentViewer1.DocumentSource = report;

		}
	}
}