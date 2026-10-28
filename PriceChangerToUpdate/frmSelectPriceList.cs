// Decompiled with JetBrains decompiler
// Type: PriceChanger.frmSelectPriceList
// Assembly: PriceChanger, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A2A849E8-FEFE-4A2B-AE8B-0FA642F38116
// Assembly location: C:\Users\zeljk\Desktop\VPN\Pricechanger\PriceChanger.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace PriceChanger;

[DesignerGenerated]
public class frmSelectPriceList : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtDesc")]
  private TextBox _txtDesc;
  [AccessedThroughProperty("cmdDelete")]
  private Button _cmdDelete;
  [AccessedThroughProperty("cmdSelect")]
  private Button _cmdSelect;
  [AccessedThroughProperty("grdPriceList")]
  private DataGridView _grdPriceList;
  public string sSearchString;

  [DebuggerNonUserCode]
  static frmSelectPriceList()
  {
  }

  [DebuggerNonUserCode]
  public frmSelectPriceList()
  {
    this.Load += new EventHandler(this.frmSelectPriceList_Load);
    frmSelectPriceList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmSelectPriceList.__ENCList)
    {
      if (frmSelectPriceList.__ENCList.Count == frmSelectPriceList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmSelectPriceList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmSelectPriceList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmSelectPriceList.__ENCList[index1] = frmSelectPriceList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmSelectPriceList.__ENCList.RemoveRange(index1, checked (frmSelectPriceList.__ENCList.Count - index1));
        frmSelectPriceList.__ENCList.Capacity = frmSelectPriceList.__ENCList.Count;
      }
      frmSelectPriceList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSelectPriceList));
    this.txtDesc = new TextBox();
    this.grdPriceList = new DataGridView();
    this.cmdDelete = new Button();
    this.cmdSelect = new Button();
    ((ISupportInitialize) this.grdPriceList).BeginInit();
    this.SuspendLayout();
    this.txtDesc.BackColor = Color.Khaki;
    this.txtDesc.BorderStyle = BorderStyle.FixedSingle;
    this.txtDesc.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtDesc1 = this.txtDesc;
    Point point1 = new Point(6, 174);
    Point point2 = point1;
    txtDesc1.Location = point2;
    this.txtDesc.MaxLength = 3;
    this.txtDesc.Name = "txtDesc";
    TextBox txtDesc2 = this.txtDesc;
    Size size1 = new Size(241, 24);
    Size size2 = size1;
    txtDesc2.Size = size2;
    this.txtDesc.TabIndex = 118;
    this.grdPriceList.AllowUserToAddRows = false;
    this.grdPriceList.AllowUserToDeleteRows = false;
    this.grdPriceList.AllowUserToResizeRows = false;
    this.grdPriceList.BackgroundColor = Color.Beige;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = Color.AliceBlue;
    gridViewCellStyle1.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.grdPriceList.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.grdPriceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.grdPriceList.GridColor = Color.Khaki;
    DataGridView grdPriceList1 = this.grdPriceList;
    point1 = new Point(6, 3);
    Point point3 = point1;
    grdPriceList1.Location = point3;
    this.grdPriceList.MultiSelect = false;
    this.grdPriceList.Name = "grdPriceList";
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = Color.Khaki;
    gridViewCellStyle2.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.grdPriceList.RowHeadersDefaultCellStyle = gridViewCellStyle2;
    this.grdPriceList.RowHeadersVisible = false;
    DataGridView grdPriceList2 = this.grdPriceList;
    size1 = new Size(445, 159);
    Size size3 = size1;
    grdPriceList2.Size = size3;
    this.grdPriceList.TabIndex = 114;
    this.cmdDelete.AutoEllipsis = true;
    this.cmdDelete.BackColor = Color.Khaki;
    this.cmdDelete.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdDelete.Image = (Image) PriceChanger.My.Resources.Resources.delete32;
    this.cmdDelete.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdDelete1 = this.cmdDelete;
    point1 = new Point(253, 168);
    Point point4 = point1;
    cmdDelete1.Location = point4;
    this.cmdDelete.Name = "cmdDelete";
    Button cmdDelete2 = this.cmdDelete;
    size1 = new Size(96 /*0x60*/, 34);
    Size size4 = size1;
    cmdDelete2.Size = size4;
    this.cmdDelete.TabIndex = 115;
    this.cmdDelete.Text = "          Cancel";
    this.cmdDelete.UseVisualStyleBackColor = false;
    this.cmdSelect.AutoEllipsis = true;
    this.cmdSelect.BackColor = Color.Khaki;
    this.cmdSelect.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdSelect.Image = (Image) PriceChanger.My.Resources.Resources.accept32;
    this.cmdSelect.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdSelect1 = this.cmdSelect;
    point1 = new Point(355, 168);
    Point point5 = point1;
    cmdSelect1.Location = point5;
    this.cmdSelect.Name = "cmdSelect";
    Button cmdSelect2 = this.cmdSelect;
    size1 = new Size(96 /*0x60*/, 34);
    Size size5 = size1;
    cmdSelect2.Size = size5;
    this.cmdSelect.TabIndex = 116;
    this.cmdSelect.Text = "       Select";
    this.cmdSelect.UseVisualStyleBackColor = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Beige;
    size1 = new Size(456, 210);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtDesc);
    this.Controls.Add((Control) this.cmdDelete);
    this.Controls.Add((Control) this.cmdSelect);
    this.Controls.Add((Control) this.grdPriceList);
    this.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSelectPriceList);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Select Price List";
    ((ISupportInitialize) this.grdPriceList).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox txtDesc
  {
    [DebuggerNonUserCode] get => this._txtDesc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtSupplierName_TextChanged);
      if (this._txtDesc != null)
        this._txtDesc.TextChanged -= eventHandler;
      this._txtDesc = value;
      if (this._txtDesc == null)
        return;
      this._txtDesc.TextChanged += eventHandler;
    }
  }

  internal virtual Button cmdDelete
  {
    [DebuggerNonUserCode] get => this._cmdDelete;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdDelete_Click);
      if (this._cmdDelete != null)
        this._cmdDelete.Click -= eventHandler;
      this._cmdDelete = value;
      if (this._cmdDelete == null)
        return;
      this._cmdDelete.Click += eventHandler;
    }
  }

  internal virtual Button cmdSelect
  {
    [DebuggerNonUserCode] get => this._cmdSelect;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdSelect_Click);
      if (this._cmdSelect != null)
        this._cmdSelect.Click -= eventHandler;
      this._cmdSelect = value;
      if (this._cmdSelect == null)
        return;
      this._cmdSelect.Click += eventHandler;
    }
  }

  internal virtual DataGridView grdPriceList
  {
    [DebuggerNonUserCode] get => this._grdPriceList;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.grdPriceList_CellContentClick);
      EventHandler eventHandler = new EventHandler(this.grdSuppliers_DoubleClick);
      if (this._grdPriceList != null)
      {
        this._grdPriceList.CellContentClick -= cellEventHandler;
        this._grdPriceList.DoubleClick -= eventHandler;
      }
      this._grdPriceList = value;
      if (this._grdPriceList == null)
        return;
      this._grdPriceList.CellContentClick += cellEventHandler;
      this._grdPriceList.DoubleClick += eventHandler;
    }
  }

  private void frmSelectPriceList_Load(object sender, EventArgs e)
  {
    this.sSearchString = Strings.Replace(this.sSearchString, "/", "");
    this.txtDesc.Text = this.sSearchString;
    this.RefreshSupplierGrid();
  }

  public void RefreshSupplierGrid()
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
    DataSet dataSet = new DataSet();
    SqlConnection sqlConnection = new SqlConnection();
    try
    {
      sqlConnection.ConnectionString = modMain.gsISMConnection;
      string str1 = "select ProductListID, Description, ProductListType from ProductLists where ProductListID > -1 ";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtDesc.Text), "", false) != 0)
        str1 = $"{str1} and  Description like '{this.txtDesc.Text}%'";
      string str2 = str1 + " Order by Description";
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = str2;
      sqlDataAdapter.SelectCommand = command;
      try
      {
        dataSet.Tables[0].Clear();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      sqlDataAdapter.Fill(dataSet);
      this.grdPriceList.DataSource = (object) dataSet.Tables[0].DefaultView;
      this.FormatListGrid();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in RefreshSupplierGrid: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void FormatListGrid()
  {
    this.grdPriceList.AllowUserToAddRows = false;
    this.grdPriceList.AllowUserToDeleteRows = false;
    this.grdPriceList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    {
      foreach (DataGridViewColumn column in (BaseCollection) this.grdPriceList.Columns)
      {
        column.ReadOnly = true;
        string name = column.Name;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "ProductListID", false) == 0)
        {
          column.HeaderText = "Number";
          column.Width = 60;
          column.DisplayIndex = 0;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "Description", false) == 0)
        {
          column.HeaderText = "Description";
          column.Width = 300;
          column.DisplayIndex = 1;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "ProductListType", false) == 0)
        {
          column.HeaderText = "Type";
          column.Width = 60;
          column.DisplayIndex = 2;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else
          column.Visible = false;
      }
    }
  }

  private void cmdSelect_Click(object sender, EventArgs e)
  {
    if (this.grdPriceList.SelectedRows.Count == 1)
    {
      modMain.iSearchedPriceList = Conversions.ToInteger(this.grdPriceList.Rows[this.grdPriceList.SelectedRows[0].Index].Cells["ProductListID"].Value);
      this.Close();
    }
    else
      modMain.mgBox("Please Select A Price List");
  }

  private void grdSuppliers_DoubleClick(object sender, EventArgs e)
  {
    this.cmdSelect_Click(RuntimeHelpers.GetObjectValue(sender), e);
  }

  private void cmdDelete_Click(object sender, EventArgs e) => this.Close();

  private void txtSupplierCode_TextChanged(object sender, EventArgs e)
  {
    this.RefreshSupplierGrid();
  }

  private void txtSupplierName_TextChanged(object sender, EventArgs e)
  {
    this.RefreshSupplierGrid();
  }

  private void grdPriceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
  }
}
