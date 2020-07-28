namespace Capa_Presentacion.Reportes
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Summary description for Report11.
    /// </summary>
    public partial class Report11 : Telerik.Reporting.Report
    {
        public Report11()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
          //  this.list1.DataSource = IndexData(MyData());
        }
        public IEnumerable MyData()
        {
            for (int i = 0; i < 1000; i++)
            {
                yield return "Str #" + i;
            }
        }

        public IEnumerable<Wrapper> IndexData(IEnumerable data)
        {
            int i = 0;
            foreach (var o in data)
            {
                yield return new Wrapper { Index = i++, Data = o };
            }
        }

        public class Wrapper
        {
            public int Index { get; set; }
            public object Data { get; set; }
        }
    }
}