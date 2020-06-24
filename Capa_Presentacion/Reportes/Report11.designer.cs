namespace Capa_Presentacion.Reportes
{
    partial class Report11
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
            this.detail = new Telerik.Reporting.DetailSection();
            this.list1 = new Telerik.Reporting.List();
            this.objectDataSource1 = new Telerik.Reporting.ObjectDataSource();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(1.6141732931137085D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.list1});
            this.detail.Name = "detail";
            // 
            // list1
            // 
            this.list1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.0472440719604492D)));
            this.list1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.57563173770904541D)));
            this.list1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.57563173770904541D)));
            this.list1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.72184246778488159D)));
            this.list1.Body.SetCellContent(2, 0, this.textBox10);
            this.list1.Body.SetCellContent(0, 0, this.textBox9);
            this.list1.Body.SetCellContent(1, 0, this.textBox1);
            tableGroup1.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.codigobarraproducto%4"));
            tableGroup1.Name = "ColumnGroup1";
            this.list1.ColumnGroups.Add(tableGroup1);
            this.list1.DataSource = null;
            this.list1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox10,
            this.textBox9,
            this.textBox1});
            this.list1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0393700934946537D), Telerik.Reporting.Drawing.Unit.Inch(0.0393700934946537D));
            this.list1.Name = "list1";
            tableGroup3.Name = "group2";
            tableGroup4.Name = "group3";
            tableGroup5.Name = "group1";
            tableGroup2.ChildGroups.Add(tableGroup3);
            tableGroup2.ChildGroups.Add(tableGroup4);
            tableGroup2.ChildGroups.Add(tableGroup5);
            tableGroup2.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.codigobarraproducto/4"));
            tableGroup2.Name = "RowGroup1";
            this.list1.RowGroups.Add(tableGroup2);
            this.list1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0472440719604492D), Telerik.Reporting.Drawing.Unit.Inch(0.73744326829910278D));
            this.list1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.list1.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid;
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // textBox10
            // 
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0472440719604492D), Telerik.Reporting.Drawing.Unit.Cm(0.72184258699417114D));
            this.textBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox10.StyleName = "";
            this.textBox10.Value = "=Fields.codigobarraproducto";
            // 
            // textBox9
            // 
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0472440719604492D), Telerik.Reporting.Drawing.Unit.Cm(0.57563155889511108D));
            this.textBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox9.StyleName = "";
            this.textBox9.Value = "=Fields.nombrecategoria";
            // 
            // textBox1
            // 
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0472440719604492D), Telerik.Reporting.Drawing.Unit.Cm(0.57563155889511108D));
            this.textBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox1.StyleName = "";
            this.textBox1.Value = "=Fields.nombrearticulo";
            // 
            // Report11
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "Report11";
            this.PageSettings.ColumnCount = 3;
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.Style.BackgroundColor = System.Drawing.Color.White;
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(5.7836661338806152D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.ObjectDataSource objectDataSource1;
        public Telerik.Reporting.List list1;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox1;
    }
}