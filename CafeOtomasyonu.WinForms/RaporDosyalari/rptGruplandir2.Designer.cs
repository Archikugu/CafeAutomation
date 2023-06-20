namespace CafeOtomasyonu.WinForms.RaporDosyalari
{
	partial class rptGruplandir2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			DevExpress.DataAccess.EntityFramework.EFConnectionParameters efConnectionParameters1 = new DevExpress.DataAccess.EntityFramework.EFConnectionParameters();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.label1 = new DevExpress.XtraReports.UI.XRLabel();
			this.table1 = new DevExpress.XtraReports.UI.XRTable();
			this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.table2 = new DevExpress.XtraReports.UI.XRTable();
			this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
			this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
			this.efDataSource1 = new DevExpress.DataAccess.EntityFramework.EFDataSource(this.components);
			this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
			this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.efDataSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// TopMargin
			// 
			this.TopMargin.Dpi = 254F;
			this.TopMargin.HeightF = 50F;
			this.TopMargin.Name = "TopMargin";
			// 
			// BottomMargin
			// 
			this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
			this.BottomMargin.Dpi = 254F;
			this.BottomMargin.HeightF = 58.42F;
			this.BottomMargin.Name = "BottomMargin";
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
			this.ReportHeader.Dpi = 254F;
			this.ReportHeader.HeightF = 87.51305F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.table1});
			this.GroupHeader1.Dpi = 254F;
			this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("SatisKodu", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
			this.GroupHeader1.HeightF = 158.6331F;
			this.GroupHeader1.Name = "GroupHeader1";
			this.GroupHeader1.StylePriority.UseTextAlignment = false;
			this.GroupHeader1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
			this.Detail.Dpi = 254F;
			this.Detail.HeightF = 63.42F;
			this.Detail.HierarchyPrintOptions.Indent = 50.8F;
			this.Detail.Name = "Detail";
			// 
			// pageInfo1
			// 
			this.pageInfo1.Dpi = 254F;
			this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.pageInfo1.Name = "pageInfo1";
			this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.pageInfo1.SizeF = new System.Drawing.SizeF(1435F, 58F);
			this.pageInfo1.StyleName = "PageInfo";
			this.pageInfo1.StylePriority.UseTextAlignment = false;
			this.pageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// pageInfo2
			// 
			this.pageInfo2.Dpi = 254F;
			this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(1435F, 0F);
			this.pageInfo2.Name = "pageInfo2";
			this.pageInfo2.SizeF = new System.Drawing.SizeF(1435F, 58F);
			this.pageInfo2.StyleName = "PageInfo";
			this.pageInfo2.StylePriority.UseTextAlignment = false;
			this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.pageInfo2.TextFormatString = "Page {0} of {1}";
			// 
			// label1
			// 
			this.label1.Dpi = 254F;
			this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.label1.Name = "label1";
			this.label1.SizeF = new System.Drawing.SizeF(2870F, 61.45361F);
			this.label1.StyleName = "Title";
			this.label1.Text = "Rapor";
			// 
			// table1
			// 
			this.table1.Dpi = 254F;
			this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.table1.Name = "table1";
			this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
			this.table1.SizeF = new System.Drawing.SizeF(2870F, 71.12F);
			// 
			// tableRow1
			// 
			this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2,
            this.tableCell3,
            this.tableCell4,
            this.tableCell5,
            this.tableCell6,
            this.tableCell7,
            this.tableCell8});
			this.tableRow1.Dpi = 254F;
			this.tableRow1.Name = "tableRow1";
			this.tableRow1.Weight = 1D;
			// 
			// tableCell1
			// 
			this.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.tableCell1.Dpi = 254F;
			this.tableCell1.Name = "tableCell1";
			this.tableCell1.StyleName = "DetailCaption1";
			this.tableCell1.StylePriority.UseBorders = false;
			this.tableCell1.StylePriority.UseTextAlignment = false;
			this.tableCell1.Text = "Id";
			this.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.tableCell1.Weight = 0.037459947007873751D;
			// 
			// tableCell2
			// 
			this.tableCell2.Dpi = 254F;
			this.tableCell2.Name = "tableCell2";
			this.tableCell2.StyleName = "DetailCaption1";
			this.tableCell2.Text = "Satis Kodu";
			this.tableCell2.Weight = 0.11472205185308688D;
			// 
			// tableCell3
			// 
			this.tableCell3.Dpi = 254F;
			this.tableCell3.Name = "tableCell3";
			this.tableCell3.StyleName = "DetailCaption1";
			this.tableCell3.StylePriority.UseTextAlignment = false;
			this.tableCell3.Text = "Miktari";
			this.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.tableCell3.Weight = 0.079076669938888289D;
			// 
			// tableCell4
			// 
			this.tableCell4.Dpi = 254F;
			this.tableCell4.Name = "tableCell4";
			this.tableCell4.StyleName = "DetailCaption1";
			this.tableCell4.StylePriority.UseTextAlignment = false;
			this.tableCell4.Text = "Birim Fiyati";
			this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.tableCell4.Weight = 0.11870005537823933D;
			// 
			// tableCell5
			// 
			this.tableCell5.Dpi = 254F;
			this.tableCell5.Name = "tableCell5";
			this.tableCell5.StyleName = "DetailCaption1";
			this.tableCell5.StylePriority.UseTextAlignment = false;
			this.tableCell5.Text = "Indirim Tutari";
			this.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.tableCell5.Weight = 0.13551735695230835D;
			// 
			// tableCell6
			// 
			this.tableCell6.Dpi = 254F;
			this.tableCell6.Name = "tableCell6";
			this.tableCell6.StyleName = "DetailCaption1";
			this.tableCell6.Text = "Masalar Masa Adi";
			this.tableCell6.Weight = 0.17123234446455793D;
			// 
			// tableCell7
			// 
			this.tableCell7.Dpi = 254F;
			this.tableCell7.Name = "tableCell7";
			this.tableCell7.StyleName = "DetailCaption1";
			this.tableCell7.Text = "Urun Urun Adi";
			this.tableCell7.Weight = 0.1434211438541213D;
			// 
			// tableCell8
			// 
			this.tableCell8.Dpi = 254F;
			this.tableCell8.Name = "tableCell8";
			this.tableCell8.StyleName = "DetailCaption1";
			this.tableCell8.Text = "Urun Menu Menu Adi";
			this.tableCell8.Weight = 0.19987042257594731D;
			// 
			// table2
			// 
			this.table2.Dpi = 254F;
			this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.table2.Name = "table2";
			this.table2.OddStyleName = "DetailData3_Odd";
			this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
			this.table2.SizeF = new System.Drawing.SizeF(2870F, 63.42F);
			// 
			// tableRow2
			// 
			this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell9,
            this.tableCell10,
            this.tableCell11,
            this.tableCell12,
            this.tableCell13,
            this.tableCell14,
            this.tableCell15,
            this.tableCell16});
			this.tableRow2.Dpi = 254F;
			this.tableRow2.Name = "tableRow2";
			this.tableRow2.Weight = 11.683999633789062D;
			// 
			// tableCell9
			// 
			this.tableCell9.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.tableCell9.Dpi = 254F;
			this.tableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Id]")});
			this.tableCell9.Name = "tableCell9";
			this.tableCell9.StyleName = "DetailData1";
			this.tableCell9.StylePriority.UseBorders = false;
			this.tableCell9.StylePriority.UseTextAlignment = false;
			this.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.tableCell9.Weight = 0.037459947007873751D;
			// 
			// tableCell10
			// 
			this.tableCell10.Dpi = 254F;
			this.tableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SatisKodu]")});
			this.tableCell10.Name = "tableCell10";
			this.tableCell10.StyleName = "DetailData1";
			this.tableCell10.Weight = 0.11472205185308688D;
			// 
			// tableCell11
			// 
			this.tableCell11.Dpi = 254F;
			this.tableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Miktari]")});
			this.tableCell11.Name = "tableCell11";
			this.tableCell11.StyleName = "DetailData1";
			this.tableCell11.StylePriority.UseTextAlignment = false;
			this.tableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.tableCell11.Weight = 0.079076669938888289D;
			// 
			// tableCell12
			// 
			this.tableCell12.Dpi = 254F;
			this.tableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BirimFiyati]")});
			this.tableCell12.Name = "tableCell12";
			this.tableCell12.StyleName = "DetailData1";
			this.tableCell12.StylePriority.UseTextAlignment = false;
			this.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.tableCell12.TextFormatString = "{0:C2}";
			this.tableCell12.Weight = 0.11870005537823933D;
			// 
			// tableCell13
			// 
			this.tableCell13.Dpi = 254F;
			this.tableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IndirimTutari]")});
			this.tableCell13.Name = "tableCell13";
			this.tableCell13.StyleName = "DetailData1";
			this.tableCell13.StylePriority.UseTextAlignment = false;
			this.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.tableCell13.TextFormatString = "{0:C2}";
			this.tableCell13.Weight = 0.13551735695230835D;
			// 
			// tableCell14
			// 
			this.tableCell14.Dpi = 254F;
			this.tableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Masalar.MasaAdi]")});
			this.tableCell14.Name = "tableCell14";
			this.tableCell14.StyleName = "DetailData1";
			this.tableCell14.Weight = 0.17123234446455793D;
			// 
			// tableCell15
			// 
			this.tableCell15.Dpi = 254F;
			this.tableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Urun.UrunAdi]")});
			this.tableCell15.Name = "tableCell15";
			this.tableCell15.StyleName = "DetailData1";
			this.tableCell15.Weight = 0.1434211438541213D;
			// 
			// tableCell16
			// 
			this.tableCell16.Dpi = 254F;
			this.tableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Urun.Menu.MenuAdi]")});
			this.tableCell16.Name = "tableCell16";
			this.tableCell16.StyleName = "DetailData1";
			this.tableCell16.Weight = 0.19987044384255226D;
			// 
			// efDataSource1
			// 
			efConnectionParameters1.ConnectionString = "";
			efConnectionParameters1.ConnectionStringName = "";
			efConnectionParameters1.Source = typeof(CafeOtomasyonu.Entities.Models.CafeContext);
			this.efDataSource1.ConnectionParameters = efConnectionParameters1;
			this.efDataSource1.Name = "efDataSource1";
			// 
			// Title
			// 
			this.Title.BackColor = System.Drawing.Color.Transparent;
			this.Title.BorderColor = System.Drawing.Color.Black;
			this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.Title.BorderWidth = 1F;
			this.Title.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
			this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.Title.Name = "Title";
			this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
			// 
			// DetailCaption1
			// 
			this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.DetailCaption1.BorderColor = System.Drawing.Color.White;
			this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
			this.DetailCaption1.BorderWidth = 2F;
			this.DetailCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.DetailCaption1.ForeColor = System.Drawing.Color.White;
			this.DetailCaption1.Name = "DetailCaption1";
			this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
			this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// DetailData1
			// 
			this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
			this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
			this.DetailData1.BorderWidth = 2F;
			this.DetailData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
			this.DetailData1.ForeColor = System.Drawing.Color.Black;
			this.DetailData1.Name = "DetailData1";
			this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
			this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// DetailData3_Odd
			// 
			this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
			this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
			this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.DetailData3_Odd.BorderWidth = 1F;
			this.DetailData3_Odd.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
			this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
			this.DetailData3_Odd.Name = "DetailData3_Odd";
			this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
			this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// PageInfo
			// 
			this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
			this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.PageInfo.Name = "PageInfo";
			this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
			// 
			// xrLabel1
			// 
			this.xrLabel1.Dpi = 254F;
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 71.12001F);
			this.xrLabel1.Multiline = true;
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(495.3F, 87.51305F);
			this.xrLabel1.StylePriority.UseTextAlignment = false;
			this.xrLabel1.Text = "[satisKodu]";
			this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// rptGruplandir2
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.efDataSource1});
			this.DataMember = "MasaHareketleri";
			this.DataSource = this.efDataSource1;
			this.Dpi = 254F;
			this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
			this.Landscape = true;
			this.Margins = new DevExpress.Drawing.DXMargins(50F, 50F, 50F, 58.42F);
			this.PageHeight = 2100;
			this.PageWidth = 2970;
			this.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
			this.SnapGridSize = 25F;
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
			this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.Version = "22.2";
			((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.efDataSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
		private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
		private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		private DevExpress.XtraReports.UI.XRLabel label1;
		private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
		private DevExpress.XtraReports.UI.XRTable table1;
		private DevExpress.XtraReports.UI.XRTableRow tableRow1;
		private DevExpress.XtraReports.UI.XRTableCell tableCell1;
		private DevExpress.XtraReports.UI.XRTableCell tableCell2;
		private DevExpress.XtraReports.UI.XRTableCell tableCell3;
		private DevExpress.XtraReports.UI.XRTableCell tableCell4;
		private DevExpress.XtraReports.UI.XRTableCell tableCell5;
		private DevExpress.XtraReports.UI.XRTableCell tableCell6;
		private DevExpress.XtraReports.UI.XRTableCell tableCell7;
		private DevExpress.XtraReports.UI.XRTableCell tableCell8;
		private DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.XRTable table2;
		private DevExpress.XtraReports.UI.XRTableRow tableRow2;
		private DevExpress.XtraReports.UI.XRTableCell tableCell9;
		private DevExpress.XtraReports.UI.XRTableCell tableCell10;
		private DevExpress.XtraReports.UI.XRTableCell tableCell11;
		private DevExpress.XtraReports.UI.XRTableCell tableCell12;
		private DevExpress.XtraReports.UI.XRTableCell tableCell13;
		private DevExpress.XtraReports.UI.XRTableCell tableCell14;
		private DevExpress.XtraReports.UI.XRTableCell tableCell15;
		private DevExpress.XtraReports.UI.XRTableCell tableCell16;
		private DevExpress.DataAccess.EntityFramework.EFDataSource efDataSource1;
		private DevExpress.XtraReports.UI.XRControlStyle Title;
		private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
		private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
		private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
		private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
	}
}
