#region License LGPL 3
// Copyright © Marvin Emilson Pineda Mazariegos 2011.
// http://marvinpinedablog.blogspot.com/
//
// This library is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this library.  If not, see <http://www.gnu.org/licenses/>.
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Drawing;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.CodeDom;
using System.ComponentModel.Design.Serialization;
using System.ComponentModel.Design;
using System.Reflection;
using System.Data;

namespace ComboBoxMultiColumns
{
    [SecurityPermissionAttribute(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    [ToolboxBitmap(typeof(ComboBoxMultiColumns))]
    [DesignerSerializer(typeof(ComboBoxMultiColumnSerializer), typeof(CodeDomSerializer))]
    [Designer(typeof(ComboBoxMultiColumnsDesigner))]
    public class ComboBoxMultiColumns : ComboBox
    {
        internal Popup dropDown;
        private ComboBoxColumnCollection columns;
        private ObjectCollection items;
        private int dropDownItemHeight;
        private int dropDownRows;
        private bool hotTrackItems;

        private const int WM_USER = 0x0400,
                          WM_REFLECT = WM_USER + 0x1C00,
                          WM_COMMAND = 0x0111,
                          CBN_DROPDOWN = 7;

        private int HIWORD(int n)
        {
            return (n >> 16) & 0xffff;
        }

        private void ShowDropDown()
        {
            if (this.dropDown != null)
            {
                this.dropDown.Show(this, 0, this.Height);
            }
        }
        internal void HideDropDown()
        {
            if (dropDown != null)
            {
                dropDown.Hide();
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == (WM_REFLECT + WM_COMMAND))
            {
                if (HIWORD((int)m.WParam) == CBN_DROPDOWN)
                {
                    BeginInvoke(new MethodInvoker(ShowDropDown));
                    return;
                }
            }

            base.WndProc(ref m);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.dropDown != null)
                {
                    this.dropDown.Dispose();
                    this.dropDown = null;
                }
            }

            base.Dispose(disposing);
        }

        public ComboBoxMultiColumns()
        {
            base.DropDownHeight = 100;
            base.DropDownWidth = 100;
            this.dropDownItemHeight = 24;
            this.dropDownRows = 8;
            this.hotTrackItems = true;
            this.PopupSizeable = true;
            this.ShowHeaders = true;
            this.dropDown = new Popup(this);
            this.columns = new ComboBoxColumnCollection(this);
        }

        public new bool DroppedDown
        {
            get { return dropDown.Visible; }
            set
            {
                Trace.WriteLine(DroppedDown);
                if (DroppedDown)
                    HideDropDown();
                else
                    ShowDropDown();
            }
        }
        [DefaultValue(24), Category("New Properties")]
        public int DropDownItemHeight
        {
            get { return this.dropDownItemHeight; }
            set { this.dropDownItemHeight = value; }
        }
        [DefaultValue(8), Category("New Properties")]
        public int DropDownRows
        {
            get { return this.dropDownRows; }
            set { this.dropDownRows = value; }
        }
        [DefaultValue(true), Category("New Properties")]
        public bool HotTrackItems
        {
            get { return this.hotTrackItems; }
            set { this.hotTrackItems = value; }
        }
        [DefaultValue(true), Category("New Properties")]
        public bool PopupSizeable { get; set; }
        [DefaultValue(true), Category("New Properties")]
        public bool ShowHeaders { get; set; }
        [Category("New Properties")]
        public ComboBoxColumnCollection Columns
        {
            get { return columns; }
        }

        #region -> Unused properties

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DrawMode DrawMode
        {
            get { return base.DrawMode; }
            set { base.DrawMode = DrawMode.Normal; }
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new int ItemHeight
        {
            get { return base.ItemHeight; }
            set { base.ItemHeight = 14; }
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ObjectCollection Items
        {
            get { return items; }
            set { items = new ObjectCollection(this); }
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool IntegralHeight
        {
            get { return base.IntegralHeight; }
            set { base.IntegralHeight = false; }
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new int MaxDropDownItems
        {
            get { return base.MaxDropDownItems; }
            set { base.MaxDropDownItems = 8; }
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool Sorted
        {
            get { return base.Sorted; }
            set { base.Sorted = false; }
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new int DropDownWidth
        {
            get { return base.DropDownWidth; }
            set { base.DropDownWidth = value; }
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new int DropDownHeight
        {
            get { return base.DropDownHeight; }
            set { base.DropDownHeight = value; }
        }

        #endregion
    }

    #region -> ComboBoxColumn, ComboBoxColumnCollection, ComboBoxColumnAlignment

    public class ComboBoxColumn : ICloneable
    {
        private bool _AutoSize = false;
        private ComboBoxColumnAlignment _Alignment = ComboBoxColumnAlignment.Left;
        private string _Caption;
        private string _FieldName;
        private int _Width = 100;
        private bool _Visible = true;
        private string _FormatString = string.Empty;

        public ComboBoxColumn()
        {
        }

        /*
        public ComboBoxColumn(string Caption, string FieldName, string FormatString, bool Visible, int Width)
            : this(ComboBoxColumnAlignment.Left, false, Caption, FieldName, FormatString, Visible, Width)
        {
        }

        public ComboBoxColumn(bool AutoSize, string Caption, string FieldName, string FormatString, bool Visible, int Width)
            : this(ComboBoxColumnAlignment.Left, AutoSize, Caption, FieldName, FormatString, Visible, Width)
        {
        }
        */

        public ComboBoxColumn(ComboBoxColumnAlignment Alignment, bool AutoSize, string Caption, string FieldName, string FormatString, bool Visible, int Width)
        {
            this.Alignment = Alignment;
            this.AutoSize = AutoSize;
            this.Caption = Caption;
            this.FieldName = FieldName;
            this.FormatString = FormatString;
            this.Visible = Visible;
            this.Width = Width;
        }

        [DefaultValue(false)]
        public bool AutoSize
        {
            get { return _AutoSize; }
            set { _AutoSize = value; }
        }
        [DefaultValue(typeof(ComboBoxColumnAlignment), "Left")]
        public ComboBoxColumnAlignment Alignment
        {
            get { return _Alignment; }
            set { _Alignment = value; }
        }
        public string Caption 
        {
            get { return _Caption; }
            set { _Caption = value; }
        }
        public string FieldName 
        {
            get { return _FieldName; }
            set { _FieldName = value; }
        }
        [DefaultValue(100)]
        public int Width 
        {
            get { return _Width; }
            set { _Width = value; }
        }
        [DefaultValue(true)]
        public bool Visible
        {
            get { return _Visible; }
            set { _Visible = value; }
        }
        [DefaultValue("")]
        public string FormatString
        {
            get { return _FormatString; }
            set { _FormatString = value; }
        }

        #region ICloneable Members

        public object Clone()
        {
            ComboBoxColumn clone = new ComboBoxColumn();
            foreach (PropertyInfo property in this.GetType().GetProperties())
            {
                PropertyInfo cloneProperty = clone.GetType().GetProperty(property.Name);
                cloneProperty.SetValue(clone, property.GetValue(this, null), null);
            }
            return clone;
        }

        #endregion
    }
    [Editor(typeof(ComboBoxMultiColumnEditor), typeof(UITypeEditor))]
    public class ComboBoxColumnCollection : CollectionBase
    {
        ComboBoxMultiColumns Owner;
        internal ComboBoxColumnCollection(ComboBoxMultiColumns owner)
        {
            this.Owner = owner;
        }

        public int Add(ComboBoxColumn column)
        {
            return this.List.Add(column);
        }
        public void AddRange(ComboBoxColumn[] collection)
        {
            this.InnerList.Clear();
            this.InnerList.AddRange(collection);
            this.Owner.dropDown.CreateColumns(this.Owner.Columns);
        }
    }
    public enum ComboBoxColumnAlignment
    {
        Left,
        Center,
        Right
    }

    #endregion

    #region -> Popup, InternalDataGridView, GripBounds

    [SecurityPermissionAttribute(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ToolboxItem(false)]
    internal class Popup : ToolStripDropDown
    {
        private Size sizeBeforeToHide = Size.Empty;
        private VisualStyleRenderer StyleRenderer;
        private ToolStripControlHost ControlHost;
        private ComboBoxMultiColumns Owner;

        public InternalDataGridView Content { get; private set; }
        internal ComboBoxMultiColumns MyOwner
        {
            get { return Owner; }
        }

        public Popup(ComboBoxMultiColumns owner)
        {
            this.Content = new InternalDataGridView(owner);
            this.ControlHost = new ToolStripControlHost(this.Content);
            this.ControlHost.AutoSize = false;

            this.Owner = owner;
            this.DoubleBuffered = true;
            this.AutoSize = false;
            this.AutoClose = true;
            this.ResizeRedraw = true;
            this.Padding = new Padding(4, 2, 4, 0x10);
            this.RegionChanged += (sender, e) => UpdateRegion();
            this.Paint += (sender, e) => PaintSizeGrip(e);
            this.DefaultDropDownDirection = ToolStripDropDownDirection.Default;
            this.Items.Add(ControlHost);
            this.UpdateRegion();
        }

        private void PaintSizeGrip(PaintEventArgs e)
        {
            if (e == null || e.Graphics == null || !this.Owner.PopupSizeable)
                return;

            Size clientSize = this.ClientSize;

            using (Bitmap gripImage = new Bitmap(0x10, 0x10))
            {
                using (Graphics g = Graphics.FromImage(gripImage))
                {
                    if (Application.RenderWithVisualStyles)
                    {
                        if (StyleRenderer == null)
                            StyleRenderer = new VisualStyleRenderer(VisualStyleElement.Status.Gripper.Normal);
                        StyleRenderer.DrawBackground(g, new Rectangle(0, 0, 0x10, 0x10));
                    }
                    else
                    {
                        ControlPaint.DrawSizeGrip(g, this.Content.BackColor, 0, 0, 0x10, 0x10);
                    }
                }

                GraphicsState gs = e.Graphics.Save();
                e.Graphics.ResetTransform();
                e.Graphics.DrawImage(gripImage, clientSize.Width - 0x10, clientSize.Height - 0x10, 0x10, 0x10);
                e.Graphics.Restore(gs);
            }
        }
        private bool InternalProcessResizing(ref Message m, bool contentControl)
        {
            if (m.Msg == 0x0084)
                return OnNcHitTest(ref m, contentControl);
            return false;
        }
        private bool OnNcHitTest(ref Message m, bool contentControl)
        {
            if (!this.Owner.PopupSizeable) 
                return false;

            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            Point clientLocation = this.PointToClient(new Point(x, y));
            GripBounds gripBounds = new GripBounds(ClientRectangle);
            IntPtr transparent = new IntPtr(-1);

            if (gripBounds.BottomRight.Contains(clientLocation))
            {
                m.Result = (IntPtr)17;
                return true;
            }
            if (gripBounds.Right.Contains(clientLocation))
            {
                m.Result = (IntPtr)11;
                return true;
            }
            if (gripBounds.Bottom.Contains(clientLocation))
            {
                m.Result = (IntPtr)15;
                return true;
            }

            return false;
        }
        private void UpdateRegion()
        {
            if (this.Region != null)
            {
                this.Region.Dispose();
                this.Region = null;
            }
            if (this.Content.Region != null)
            {
                this.Region = this.Content.Region.Clone();
            }
        }
        private void PopulateColumnsFromBindingSource()
        {
            BindingSource bs = this.Owner.DataSource as BindingSource;
            if (bs.DataSource is DataTable)
                PopulateColumnsFromDataTable(bs.DataSource as DataTable);
            if (bs.DataSource is IList)
                PopulateColumnsFromIList(bs.DataSource as IList);
        }
        private void PopulateColumnsFromDataTable(DataTable source)
        {
            foreach (DataColumn dc in source.Columns) //(this.Owner.DataSource as DataTable).Columns)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = dc.ColumnName;
                col.DataPropertyName = dc.ColumnName;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.MinimumWidth = 100;
                this.Content.Columns.Add(col);
            }
        }
        private void PopulateColumnsFromIList(IList source)
        {
            PropertyInfo item = source.GetType().GetProperty("Item"); // (this.Owner.DataSource as IList).GetType().GetProperty("Item");
            object clase = Activator.CreateInstance(Type.GetType(item.PropertyType.AssemblyQualifiedName));
            foreach (PropertyInfo p in clase.GetType().GetProperties())
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = p.Name;
                col.DataPropertyName = p.Name;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.MinimumWidth = 100;
                this.Content.Columns.Add(col);
            }
        }
        private void PopulateColumns()
        {
            if (this.Owner.DataSource == null)
                return;

            if (this.Owner.DataSource is BindingSource)
                this.PopulateColumnsFromBindingSource();
            if (this.Owner.DataSource is DataTable)
                this.PopulateColumnsFromDataTable(this.Owner.DataSource as DataTable);
            else
                this.PopulateColumnsFromIList(this.Owner.DataSource as IList);
        }
        internal void CreateColumns(ComboBoxColumnCollection columns)
        {
            this.Content.Columns.Clear();
            foreach (ComboBoxColumn column in columns)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = column.Caption;
                col.DataPropertyName = column.FieldName;
                if (column.AutoSize)
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.Width = column.Width;
                col.MinimumWidth = column.Width;

                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.Format = column.FormatString;
                if (column.Alignment == ComboBoxColumnAlignment.Center)
                    cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                else if (column.Alignment == ComboBoxColumnAlignment.Right)
                    cellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                else if (column.Alignment == ComboBoxColumnAlignment.Left)
                    cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                col.DefaultCellStyle = cellStyle;
                col.Visible = column.Visible;
                this.Content.Columns.Add(col);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (this.InternalProcessResizing(ref m, false))
                return;

            base.WndProc(ref m);
        }
        protected override CreateParams CreateParams
        {
            [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x08000000;
                return cp; // base.CreateParams;
            }
        }
        protected override void OnOpening(CancelEventArgs e)
        {
            if (this.Content.Columns.Count == 0)
                this.PopulateColumns();

            if (this.Content.ColumnHeadersVisible != this.Owner.ShowHeaders)
                this.Content.ColumnHeadersVisible = this.Owner.ShowHeaders;

            if (this.Content.RowTemplate.Height != this.Owner.DropDownItemHeight)
                this.Content.RowTemplate.Height = this.Owner.DropDownItemHeight;

            int columnHeadersWidth = this.Content.ColumnHeadersVisible ? this.Content.ColumnHeadersHeight : 1;
            int marginBottom = this.Owner.PopupSizeable ? 0x10 : 4;
            int preferredWidth = this.Owner.Width, preferredHeight = 0x6a;
            if (this.Content.Columns.Count > 0)
            {
                preferredWidth = this.Content.GetPreferredSize(Size.Empty).Width;
                preferredHeight = columnHeadersWidth + (this.Owner.DropDownItemHeight * this.Owner.DropDownRows) + marginBottom + 4;
            }

            Size size = new Size(preferredWidth, preferredHeight);
            if (this.sizeBeforeToHide != Size.Empty)
                size = this.sizeBeforeToHide;

            this.Size = size;
            this.ControlHost.Size = new Size(this.Size.Width - 8, this.Size.Height - marginBottom - 2);
            this.UpdateRegion();
            base.OnOpening(e);
        }
        protected override void OnOpened(EventArgs e)
        {
            this.Content.Focus();
            base.OnOpened(e);
        }
        protected override void OnClosing(ToolStripDropDownClosingEventArgs e)
        {
            this.sizeBeforeToHide = this.Size;
            base.OnClosing(e);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            if (this.Content != null && this.Content.Visible)
            {
                this.ControlHost.Size = new Size(this.Size.Width - 8, this.Size.Height - 0x10 - 2);
            }
            base.OnSizeChanged(e);
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
                NativeMethods.AnimateWindow(new HandleRef(this, this.Handle), 200, NativeMethods.AnimationFlags.Activate | NativeMethods.AnimationFlags.VerticalPositive);
        }
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class InternalDataGridView : DataGridView
    {
        private ComboBoxMultiColumns Owner;

        internal IList RowCollection
        {
            get 
            {
                if (this.Owner.DataSource is DataTable)
                    return (this.Owner.DataSource as DataTable).DefaultView.OfType<DataRowView>().ToArray();
                if (this.Owner.DataSource is BindingSource)
                {
                    BindingSource bs = this.Owner.DataSource as BindingSource;
                    if (bs.DataSource is DataTable)
                        return (bs.DataSource as DataTable).DefaultView.OfType<DataRowView>().ToArray();
                    if (bs.DataSource is IList)
                        return bs.DataSource as IList;
                }

                return this.Owner.DataSource as IList; 
            }
        }

        public InternalDataGridView(ComboBoxMultiColumns owner)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            this.AutoGenerateColumns = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeColumns = false;
            this.AllowUserToResizeRows = false;
            this.RowHeadersVisible = false;
            this.VirtualMode = true;
            this.ReadOnly = true;
            this.Dock = DockStyle.Fill;
            this.BackgroundColor = Color.White;
            this.ColumnHeadersHeight = 26;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RowTemplate.Resizable = DataGridViewTriState.False;
            this.RowTemplate.Height = 24;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.MultiSelect = false;
            this.Owner = owner;

            this.MouseClick += new MouseEventHandler(InternalDataGridView_MouseClick);
            this.KeyUp += new KeyEventHandler(InternalDataGridView_KeyUp);
            this.CellValueNeeded += new DataGridViewCellValueEventHandler(InternalDataGridView_CellValueNeeded);
        }

        int GetFirstVisibleCell()
        {
            foreach (DataGridViewColumn col in this.Columns)
            {
                if (col.Visible)
                    return col.Index;
            }

            return -1;
        }
        void MoveToSelectedRow()
        {
            for (int r = 0; r < this.RowCollection.Count; r++)
            {
                if (this.RowCollection[r].Equals(this.Owner.SelectedItem))
                    this.CurrentCell = this.Rows[r].Cells[GetFirstVisibleCell()];
            }

            if (this.CurrentRow != null && this.GetRowDisplayRectangle(this.CurrentRow.Index, true).IsEmpty)
                this.FirstDisplayedScrollingRowIndex = this.CurrentRow.Index;
        }
        void SetSelectedItem(int RowIndex)
        {
            if (this.Owner.DataSource is DataTable)
                this.Owner.SelectedItem = (this.Owner.DataSource as DataTable).DefaultView[RowIndex];
            else
                this.Owner.SelectedItem = (this.Owner.DataSource as IList)[RowIndex];
            this.Owner.Focus();
            this.Owner.HideDropDown();
        }
        object GetValueUsingReflection(object Source, string DataPropertyName)
        {
            if (Source == null) return (string)null;

            object retValue = string.Empty;
            string[] splitDataProperty = DataPropertyName.Split('.');
            PropertyInfo pInfo = Source.GetType().GetProperty(splitDataProperty[0]);
            if (pInfo != null)
            {
                if (splitDataProperty.Length > 1)
                {
                    string newDataPropertyName = string.Empty;
                    for (int split = 1; split < splitDataProperty.Length; split++)
                        newDataPropertyName += (string.IsNullOrEmpty(newDataPropertyName) ? "" : ".") + splitDataProperty[split];
                    retValue = GetValueUsingReflection(pInfo.GetValue(Source, null), newDataPropertyName);
                }
                else
                {
                    retValue = pInfo.GetValue(Source, null);
                }
            }

            return retValue;
        }
        void InternalDataGridView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            string dataPropertyName = this.Columns[e.ColumnIndex].DataPropertyName;

            if (this.Owner.DataSource is DataTable)
            {
                if (((DataRowView)this.RowCollection[e.RowIndex]).Row.Table.Columns.Contains(dataPropertyName))
                    e.Value = ((DataRowView)this.RowCollection[e.RowIndex])[dataPropertyName];
                else
                    e.Value = null;
            }
            else
            {
                object row = this.RowCollection[e.RowIndex];
                PropertyDescriptor pd = TypeDescriptor.GetProperties(row)[dataPropertyName];
                if (pd != null)
                {
                    e.Value = pd.GetValue(row);
                    return;
                }
                e.Value = GetValueUsingReflection(row, dataPropertyName);
            }
        }
        void InternalDataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.CurrentRow != null)
            {
                this.SetSelectedItem(this.CurrentRow.Index);
            }
        }
        void InternalDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = this.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.Cell)
            {
                this.SetSelectedItem(hit.RowIndex);
            }
        }

        protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                return false;
            return base.ProcessDataGridViewKey(e);
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible && !this.Disposing && this.Owner.DataSource != null)
            {
                this.RowCount = this.RowCollection.Count;
                this.MoveToSelectedRow();
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (this.Owner.HotTrackItems)
            {
                Point point = this.PointToClient(Control.MousePosition);
                DataGridView.HitTestInfo hit = this.HitTest(point.X, point.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    this.CurrentCell = this.Rows[hit.RowIndex].Cells[this.GetFirstVisibleCell()];
                }
            }
            base.OnMouseMove(e);
        }
        protected override void PaintBackground(Graphics graphics, Rectangle clipBounds, Rectangle gridBounds)
        {
            base.PaintBackground(graphics, clipBounds, gridBounds);
            if (this.Columns.Count == 0)
                graphics.DrawString("DataSource Undefined", this.Font, Brushes.Black, gridBounds, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
        }
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal struct GripBounds
    {
        private const int GripSize = 6;
        private const int CornerGripSize = GripSize << 1;

        public GripBounds(Rectangle clientRectangle)
        {
            this.clientRectangle = clientRectangle;
        }

        private Rectangle clientRectangle;
        public Rectangle ClientRectangle
        {
            get { return clientRectangle; }
            //set { clientRectangle = value; }
        }

        public Rectangle Bottom
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Y = rect.Bottom - GripSize + 1;
                rect.Height = GripSize;
                return rect;
            }
        }

        public Rectangle BottomRight
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Y = rect.Bottom - CornerGripSize + 1;
                rect.Height = CornerGripSize;
                rect.X = rect.Width - CornerGripSize + 1;
                rect.Width = CornerGripSize;
                return rect;
            }
        }

        public Rectangle Top
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Height = GripSize;
                return rect;
            }
        }

        public Rectangle TopRight
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Height = CornerGripSize;
                rect.X = rect.Width - CornerGripSize + 1;
                rect.Width = CornerGripSize;
                return rect;
            }
        }

        public Rectangle Left
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Width = GripSize;
                return rect;
            }
        }

        public Rectangle BottomLeft
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Width = CornerGripSize;
                rect.Y = rect.Height - CornerGripSize + 1;
                rect.Height = CornerGripSize;
                return rect;
            }
        }

        public Rectangle Right
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.X = rect.Right - GripSize + 1;
                rect.Width = GripSize;
                return rect;
            }
        }

        public Rectangle TopLeft
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Width = CornerGripSize;
                rect.Height = CornerGripSize;
                return rect;
            }
        }
    }

    #endregion

    #region -> ComboBoxMultiColumns-UITypeEditor

    internal class ComboBoxMultiColumnEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc == null)
                return value;

            using (ComboBoxColumnEditor form = new ComboBoxColumnEditor(value))
            {
                if (edSvc.ShowDialog(form) == DialogResult.OK)
                {
                    IComponentChangeService iccs = (IComponentChangeService)context.GetService(typeof(IComponentChangeService));
                    iccs.OnComponentChanging(context.Instance, null);
                    (value as ComboBoxColumnCollection).AddRange(form.NewCollection);
                    iccs.OnComponentChanged(context.Instance, null, null, null);
                }
            }

            return value;
        }
    }

    #endregion

    #region -> ComboBoxMultiColumns-CodeDomSerialize

    internal class ComboBoxMultiColumnSerializer : CodeDomSerializer
    {
        public override object Deserialize(IDesignerSerializationManager manager, object codeObject)
        {
            CodeDomSerializer baseClassSerializer = (CodeDomSerializer)manager.GetSerializer(typeof(ComboBoxMultiColumns).BaseType, typeof(CodeDomSerializer));
            return baseClassSerializer.Deserialize(manager, codeObject);
        }
        public override object Serialize(IDesignerSerializationManager manager, object value)
        {
            CodeDomSerializer baseClassSerializer = (CodeDomSerializer)manager.GetSerializer(typeof(ComboBoxMultiColumns).BaseType, typeof(CodeDomSerializer));
            object codeObject = baseClassSerializer.Serialize(manager, value);
            if (codeObject is CodeStatementCollection)
            {
                ComboBoxMultiColumns comboBoxMultiColumns = value as ComboBoxMultiColumns;
                if (comboBoxMultiColumns != null)
                {
                    CodeStatementCollection statements = (CodeStatementCollection)codeObject;
                    List<CodeObjectCreateExpression> parameter_list = new List<CodeObjectCreateExpression>();
                    foreach (ComboBoxColumn column in comboBoxMultiColumns.Columns)
                    {
                        parameter_list.Add
                            (
                                new CodeObjectCreateExpression
                                    (
                                        typeof(ComboBoxColumn), 
                                        new CodeExpression[] 
                                            {
                                                new CodePropertyReferenceExpression(new CodeVariableReferenceExpression("ComboBoxMultiColumns.ComboBoxColumnAlignment"), column.Alignment.ToString()),
                                                new CodePrimitiveExpression(column.AutoSize),
                                                new CodePrimitiveExpression(column.Caption), 
                                                new CodePrimitiveExpression(column.FieldName),
                                                new CodePrimitiveExpression(column.FormatString),
                                                new CodePrimitiveExpression(column.Visible),
                                                new CodePrimitiveExpression(column.Width)
                                            }
                                    )
                            );
                    }

                    CodeArrayCreateExpression createArray = new CodeArrayCreateExpression(typeof(ComboBoxColumn), parameter_list.ToArray());
                    CodeFieldReferenceExpression target = base.SerializeToExpression(manager, value) as CodeFieldReferenceExpression;
                    if (target != null && parameter_list.Count > 0)
                    {
                        //CodeMethodInvokeExpression methodCall = new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("this." + target.FieldName + ".Columns"), "AddRange", createArray);
                        CodeMethodReferenceExpression methodCall = new CodeMethodReferenceExpression(new CodeThisReferenceExpression(), target.FieldName + ".Columns.AddRange");
                        CodeMethodInvokeExpression invoker = new CodeMethodInvokeExpression(methodCall, createArray);
                        statements.Add(invoker);
                    }
                }
            }

            return codeObject;
        }
    }

    #endregion

    #region -> ComboBoxMultiColumns-ControlDesigner

    internal class ComboBoxMultiColumnsDesigner : ControlDesigner
    {
        DesignerActionListCollection actionList;

        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (actionList == null)
                {
                    actionList = new DesignerActionListCollection();
                    actionList.Add(new CustomActionList(this.Control));
                }
                return actionList;
            }
        }
        /*public override DesignerVerbCollection Verbs
        {
            get
            {
                DesignerVerbCollection verbs = new DesignerVerbCollection();
                verbs.Add(new DesignerVerb("Edit Columns", new EventHandler(EditColumns)));
                return verbs; // base.Verbs;
            }
        }*/
        /*private void EditColumns(object sender, EventArgs e)
        {
            ComboBoxColumnEditor editor = new ComboBoxColumnEditor((this.Control as ComboBoxMultiColumns).Columns);
            IUIService service = base.Component.Site.GetService(typeof(IUIService)) as IUIService;
            if (service != null)
            {
                if (service.ShowDialog(editor) == DialogResult.OK)
                {
                    IComponentChangeService iccs = (IComponentChangeService)GetService(typeof(IComponentChangeService));
                    iccs.OnComponentChanging(this.Control, null);
                    ((ComboBoxMultiColumns)this.Control).Columns.AddRange(editor.NewCollection);
                    iccs.OnComponentChanged(this.Control, null, null, null);
                }
            }
            editor.Dispose();
        }*/

        internal class CustomActionList : DesignerActionList
        {
            ComboBoxMultiColumns Owner;
            DesignerActionUIService designerActionSvc;

            private PropertyDescriptor GetPropertyByName(string propertyName)
            {
                PropertyDescriptor pd = TypeDescriptor.GetProperties(this.Owner, true)[propertyName];
                if (pd == null)
                    throw new Exception("Property not found");
                return pd;
            }

            public CustomActionList(IComponent owner) : base(owner)
            {
                this.Owner = owner as ComboBoxMultiColumns;
                this.designerActionSvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
            }
            public override DesignerActionItemCollection GetSortedActionItems()
            {
                DesignerActionItemCollection items = new DesignerActionItemCollection();
                items.Add(new DesignerActionHeaderItem("Popup"));
                items.Add(new DesignerActionHeaderItem("DataGridView"));
                items.Add(new DesignerActionPropertyItem("DropDownItemHeight", "Item Height", "DataGridView"));
                items.Add(new DesignerActionPropertyItem("DropDownRows", "Show Rows", "DataGridView"));
                items.Add(new DesignerActionPropertyItem("PopupSizeable", "Sizeable", "Popup"));
                items.Add(new DesignerActionPropertyItem("ShowHeaders", "Show Headers", "DataGridView"));
                items.Add(new DesignerActionPropertyItem("HotTrackItems", "Hot Track Items", "DataGridView"));
                items.Add(new DesignerActionMethodItem(this, "OnEditColumns", "Edit Columns", true));
                return items;
            }

            public bool PopupSizeable
            {
                get { return Owner.PopupSizeable; }
                set 
                {
                    GetPropertyByName("PopupSizeable").SetValue(this.Owner, value);
                    designerActionSvc.Refresh(this.Owner);
                }
            }
            public bool ShowHeaders
            {
                get { return this.Owner.ShowHeaders; }
                set 
                {
                    GetPropertyByName("ShowHeaders").SetValue(this.Owner, value);
                    designerActionSvc.Refresh(this.Owner);
                }
            }
            public bool HotTrackItems
            {
                get { return this.Owner.HotTrackItems; }
                set 
                {
                    GetPropertyByName("HotTrackItems").SetValue(this.Owner, value);
                    designerActionSvc.Refresh(this.Owner);
                }
            }
            public int DropDownRows
            {
                get { return this.Owner.DropDownRows; }
                set 
                {
                    GetPropertyByName("DropDownRows").SetValue(this.Owner, value);
                    designerActionSvc.Refresh(this.Owner);
                }
            }
            public int DropDownItemHeight
            {
                get { return this.Owner.DropDownItemHeight; }
                set 
                {
                    GetPropertyByName("DropDownItemHeight").SetValue(this.Owner, value);
                    designerActionSvc.Refresh(this.Owner);
                }
            }
            public void OnEditColumns()
            {
                ComboBoxColumnEditor editor = new ComboBoxColumnEditor(this.Owner.Columns);
                IUIService service = base.Component.Site.GetService(typeof(IUIService)) as IUIService;
                if (service != null)
                {
                    if (service.ShowDialog(editor) == DialogResult.OK)
                    {
                        IComponentChangeService iccs = (IComponentChangeService)GetService(typeof(IComponentChangeService));
                        iccs.OnComponentChanging(this.Owner, null);
                        this.Owner.Columns.AddRange(editor.NewCollection);
                        iccs.OnComponentChanged(this.Owner, null, null, null);
                        designerActionSvc.HideUI(this.Owner);
                    }
                }
                editor.Dispose();
            }
        }
    }

    #endregion
}
