namespace Capa_Presentacion.Formreportes
{
    partial class REPORT_LISTAVENTACATEGORIA
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.reportHeaderSection1 = new Telerik.Reporting.ReportHeaderSection();
            this.table1 = new Telerik.Reporting.Table();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox43 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox42 = new Telerik.Reporting.TextBox();
            this.textBox40 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(3D);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox40});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.132D);
            this.detail.Name = "detail";
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.132D);
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // reportHeaderSection1
            // 
            this.reportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(4.1D);
            this.reportHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.table1,
            this.textBox11,
            this.textBox10});
            this.reportHeaderSection1.Name = "reportHeaderSection1";
            // 
            // table1
            // 
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.072D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(6.247D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.804D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.676D)));
            this.table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.7D)));
            this.table1.Body.SetCellContent(0, 0, this.textBox5);
            this.table1.Body.SetCellContent(0, 1, this.textBox7);
            this.table1.Body.SetCellContent(0, 2, this.textBox9);
            this.table1.Body.SetCellContent(0, 3, this.textBox43);
            tableGroup1.Name = "tableGroup";
            tableGroup1.ReportItem = this.textBox4;
            tableGroup2.Name = "tableGroup1";
            tableGroup2.ReportItem = this.textBox6;
            tableGroup3.Name = "tableGroup2";
            tableGroup3.ReportItem = this.textBox8;
            tableGroup4.Name = "group";
            tableGroup4.ReportItem = this.textBox42;
            this.table1.ColumnGroups.Add(tableGroup1);
            this.table1.ColumnGroups.Add(tableGroup2);
            this.table1.ColumnGroups.Add(tableGroup3);
            this.table1.ColumnGroups.Add(tableGroup4);
            this.table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox5,
            this.textBox7,
            this.textBox9,
            this.textBox43,
            this.textBox4,
            this.textBox6,
            this.textBox8,
            this.textBox42});
            this.table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.7D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.table1.Name = "table1";
            tableGroup5.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup5.Name = "detailTableGroup";
            this.table1.RowGroups.Add(tableGroup5);
            this.table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.8D), Telerik.Reporting.Drawing.Unit.Cm(1.4D));
            this.table1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Cm(20D);
            this.table1.Style.Visible = true;
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = true;
            this.textBox5.Format = "{0:N2}";
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.072D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox5.Value = "=Fields.idcategoria";
            // 
            // textBox7
            // 
            this.textBox7.CanGrow = false;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.247D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox7.Value = "=Fields.nombre";
            // 
            // textBox9
            // 
            this.textBox9.CanGrow = true;
            this.textBox9.Format = "{0:N2}";
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.804D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox9.Value = "=Fields.cantidad";
            // 
            // textBox43
            // 
            this.textBox43.CanGrow = true;
            this.textBox43.Format = "{0:N2}";
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.676D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox43.StyleName = "";
            this.textBox43.Value = "=Fields.importe";
            // 
            // textBox4
            // 
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.072D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox4.Value = "NroCategoria";
            // 
            // textBox6
            // 
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.247D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox6.Value = "Detalle";
            // 
            // textBox8
            // 
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.804D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox8.Value = "Cantidad";
            // 
            // textBox42
            // 
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.676D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox42.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox42.StyleName = "";
            this.textBox42.Value = "Total";
            // 
            // textBox40
            // 
            this.textBox40.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.2D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15D), Telerik.Reporting.Drawing.Unit.Cm(0.8D));
            this.textBox40.Style.Font.Bold = true;
            this.textBox40.Style.Font.Name = "SansSerif";
            this.textBox40.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
            this.textBox40.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox40.Value = "LISTADO DE ARTICULOS VENDIDOS POR CATEGORIA";
            // 
            // textBox10
            // 
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.21D), Telerik.Reporting.Drawing.Unit.Cm(2.8D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.317D), Telerik.Reporting.Drawing.Unit.Cm(0.4D));
            this.textBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox10.Style.Font.Bold = true;
            this.textBox10.Style.Font.Name = "SansSerif";
            this.textBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            this.textBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox10.Value = "Total";
            // 
            // textBox11
            // 
            this.textBox11.Format = "{0:N2}";
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.3D), Telerik.Reporting.Drawing.Unit.Cm(2.8D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.468D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
            this.textBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox11.Style.Font.Bold = true;
            this.textBox11.Style.Font.Name = "SansSerif";
            this.textBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
            this.textBox11.Value = "= Count(Fields.importe)";
            // 
            // REPORT_LISTAVENTACATEGORIA
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detail,
            this.pageFooterSection1,
            this.reportHeaderSection1});
            this.Name = "REPORT_LISTAVENTACATEGORIA";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(17D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.ReportHeaderSection reportHeaderSection1;
        public Telerik.Reporting.Table table1;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox43;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox42;
        public Telerik.Reporting.TextBox textBox40;
        internal Telerik.Reporting.TextBox textBox11;
        internal Telerik.Reporting.TextBox textBox10;
    }
}