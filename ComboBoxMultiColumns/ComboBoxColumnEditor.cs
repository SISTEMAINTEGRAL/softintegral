using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxMultiColumns
{
    [ToolboxItem(false)]
    internal partial class ComboBoxColumnEditor : Form
    {
        BindingSource bs = new BindingSource();
        IList<ComboBoxColumn> columns = new List<ComboBoxColumn>();

        public ComboBoxColumn[] NewCollection
        {
            get
            {
                return columns.ToArray();
            }
        }

        public ComboBoxColumnEditor(object value)
        {
            InitializeComponent();

            foreach (ComboBoxColumn column in value as ComboBoxColumnCollection)
                columns.Add(column.Clone() as ComboBoxColumn);

            bs.DataSource = columns;
            this.listBox1.DataSource = bs;
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            ComboBoxColumn column = (ComboBoxColumn)this.bs[e.Index];

            ControlPaint.DrawButton(e.Graphics, new Rectangle(0, e.Bounds.Y + ((e.Bounds.Height - 20) / 2), 20, 20), ButtonState.Normal);
            e.Graphics.DrawString(e.Index.ToString(), this.listBox1.Font, Brushes.Black, new Rectangle(0, e.Bounds.Y + ((e.Bounds.Height - 20) / 2), 20, 20), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            Color backColor = (e.State & DrawItemState.Focus) > 0 || (e.State & DrawItemState.Selected) > 0 ? SystemColors.Highlight : SystemColors.Window;
            Color foreColor = (e.State & DrawItemState.Focus) > 0 || (e.State & DrawItemState.Selected) > 0 ? SystemColors.HighlightText : SystemColors.ControlText;

            e.Graphics.FillRectangle(new SolidBrush(backColor), new Rectangle(22, e.Bounds.Y, e.Bounds.Width - 22, e.Bounds.Height));
            TextRenderer.DrawText(e.Graphics, string.Format("{0} (\"{1}\")", column.Caption, column.FieldName), this.listBox1.Font, new Rectangle(22, e.Bounds.Y, e.Bounds.Width - 22, e.Bounds.Height), foreColor, TextFormatFlags.WordEllipsis | TextFormatFlags.VerticalCenter);
            //e.Graphics.DrawString(string.Format("{0} (\"{1}\")", column.Caption, column.FieldName), this.listBox1.Font, new SolidBrush(foreColor), new Rectangle(22, e.Bounds.Y, e.Bounds.Width - 22, e.Bounds.Height), new StringFormat() { LineAlignment = StringAlignment.Center });
        }
        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = this.listBox1.SelectedValue;
        }
        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            this.listBox1.Invalidate();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            this.bs.Add(new ComboBoxColumn());
            this.bs.MoveLast();
        }
        private void bRemover_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
                bs.RemoveCurrent();
        }
        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void bSubir_Click(object sender, EventArgs e)
        {
            if (bs.Position == 0)
                return;

            ComboBoxColumn col1 = ((ComboBoxColumn)bs.Current).Clone() as ComboBoxColumn;
            ComboBoxColumn col2 = ((ComboBoxColumn)bs[bs.Position - 1]).Clone() as ComboBoxColumn;
            bs[bs.Position - 1] = col1;
            bs[bs.Position] = col2;
            bs.Position--;
        }
        private void bBajar_Click(object sender, EventArgs e)
        {
            if (bs.Position == bs.Count - 1)
                return;

            ComboBoxColumn col1 = ((ComboBoxColumn)bs.Current).Clone() as ComboBoxColumn;
            ComboBoxColumn col2 = ((ComboBoxColumn)bs[bs.Position + 1]).Clone() as ComboBoxColumn;
            bs[bs.Position + 1] = col1;
            bs[bs.Position] = col2;
            bs.Position++;
        }
    }
}
