// Decompiled with JetBrains decompiler
// Type: PriceChanger.frmSelectSupplier
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
public class frmSelectSupplier : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("grdSuppliers")]
  private DataGridView _grdSuppliers;
  [AccessedThroughProperty("cmdDelete")]
  private Button _cmdDelete;
  [AccessedThroughProperty("cmdSelect")]
  private Button _cmdSelect;
  [AccessedThroughProperty("txtSupplierCode")]
  private TextBox _txtSupplierCode;
  [AccessedThroughProperty("txtSupplierName")]
  private TextBox _txtSupplierName;
  public string sSearchString;

  [DebuggerNonUserCode]
  static frmSelectSupplier()
  {
  }

  [DebuggerNonUserCode]
  public frmSelectSupplier()
  {
    this.Load += new EventHandler(this.frmSelectSupplier_Load);
    frmSelectSupplier.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmSelectSupplier.__ENCList)
    {
      if (frmSelectSupplier.__ENCList.Count == frmSelectSupplier.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmSelectSupplier.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmSelectSupplier.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmSelectSupplier.__ENCList[index1] = frmSelectSupplier.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmSelectSupplier.__ENCList.RemoveRange(index1, checked (frmSelectSupplier.__ENCList.Count - index1));
        frmSelectSupplier.__ENCList.Capacity = frmSelectSupplier.__ENCList.Count;
      }
      frmSelectSupplier.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSelectSupplier));
    this.grdSuppliers = new DataGridView();
    this.txtSupplierCode = new TextBox();
    this.txtSupplierName = new TextBox();
    this.cmdDelete = new Button();
    this.cmdSelect = new Button();
    ((ISupportInitialize) this.grdSuppliers).BeginInit();
    this.SuspendLayout();
    this.grdSuppliers.AllowUserToAddRows = false;
    this.grdSuppliers.AllowUserToDeleteRows = false;
    this.grdSuppliers.AllowUserToResizeRows = false;
    this.grdSuppliers.BackgroundColor = Color.Beige;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = Color.AliceBlue;
    gridViewCellStyle1.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.grdSuppliers.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.grdSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.grdSuppliers.GridColor = Color.Khaki;
    DataGridView grdSuppliers1 = this.grdSuppliers;
    Point point1 = new Point(6, 12);
    Point point2 = point1;
    grdSuppliers1.Location = point2;
    this.grdSuppliers.MultiSelect = false;
    this.grdSuppliers.Name = "grdSuppliers";
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = Color.Khaki;
    gridViewCellStyle2.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.grdSuppliers.RowHeadersDefaultCellStyle = gridViewCellStyle2;
    this.grdSuppliers.RowHeadersVisible = false;
    DataGridView grdSuppliers2 = this.grdSuppliers;
    Size size1 = new Size(482, 159);
    Size size2 = size1;
    grdSuppliers2.Size = size2;
    this.grdSuppliers.TabIndex = 109;
    this.txtSupplierCode.BackColor = Color.Khaki;
    this.txtSupplierCode.BorderStyle = BorderStyle.FixedSingle;
    this.txtSupplierCode.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtSupplierCode1 = this.txtSupplierCode;
    point1 = new Point(12, 183);
    Point point3 = point1;
    txtSupplierCode1.Location = point3;
    this.txtSupplierCode.MaxLength = 3;
    this.txtSupplierCode.Name = "txtSupplierCode";
    TextBox txtSupplierCode2 = this.txtSupplierCode;
    size1 = new Size(84, 24);
    Size size3 = size1;
    txtSupplierCode2.Size = size3;
    this.txtSupplierCode.TabIndex = 112 /*0x70*/;
    this.txtSupplierName.BackColor = Color.Khaki;
    this.txtSupplierName.BorderStyle = BorderStyle.FixedSingle;
    this.txtSupplierName.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtSupplierName1 = this.txtSupplierName;
    point1 = new Point(102, 183);
    Point point4 = point1;
    txtSupplierName1.Location = point4;
    this.txtSupplierName.MaxLength = 30;
    this.txtSupplierName.Name = "txtSupplierName";
    TextBox txtSupplierName2 = this.txtSupplierName;
    size1 = new Size(182, 24);
    Size size4 = size1;
    txtSupplierName2.Size = size4;
    this.txtSupplierName.TabIndex = 113;
    this.cmdDelete.AutoEllipsis = true;
    this.cmdDelete.BackColor = Color.Khaki;
    this.cmdDelete.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdDelete.Image = (Image) PriceChanger.My.Resources.Resources.delete32;
    this.cmdDelete.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdDelete1 = this.cmdDelete;
    point1 = new Point(290, 177);
    Point point5 = point1;
    cmdDelete1.Location = point5;
    this.cmdDelete.Name = "cmdDelete";
    Button cmdDelete2 = this.cmdDelete;
    size1 = new Size(96 /*0x60*/, 34);
    Size size5 = size1;
    cmdDelete2.Size = size5;
    this.cmdDelete.TabIndex = 110;
    this.cmdDelete.Text = "          Cancel";
    this.cmdDelete.UseVisualStyleBackColor = false;
    this.cmdSelect.AutoEllipsis = true;
    this.cmdSelect.BackColor = Color.Khaki;
    this.cmdSelect.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdSelect.Image = (Image) PriceChanger.My.Resources.Resources.accept32;
    this.cmdSelect.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdSelect1 = this.cmdSelect;
    point1 = new Point(392, 177);
    Point point6 = point1;
    cmdSelect1.Location = point6;
    this.cmdSelect.Name = "cmdSelect";
    Button cmdSelect2 = this.cmdSelect;
    size1 = new Size(96 /*0x60*/, 34);
    Size size6 = size1;
    cmdSelect2.Size = size6;
    this.cmdSelect.TabIndex = 111;
    this.cmdSelect.Text = "       Select";
    this.cmdSelect.UseVisualStyleBackColor = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Beige;
    size1 = new Size(495, 222);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtSupplierName);
    this.Controls.Add((Control) this.txtSupplierCode);
    this.Controls.Add((Control) this.cmdDelete);
    this.Controls.Add((Control) this.cmdSelect);
    this.Controls.Add((Control) this.grdSuppliers);
    this.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSelectSupplier);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Select Supplier";
    ((ISupportInitialize) this.grdSuppliers).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual DataGridView grdSuppliers
  {
    [DebuggerNonUserCode] get => this._grdSuppliers;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.grdSuppliers_CellContentClick);
      EventHandler eventHandler = new EventHandler(this.grdSuppliers_DoubleClick);
      if (this._grdSuppliers != null)
      {
        this._grdSuppliers.CellContentClick -= cellEventHandler;
        this._grdSuppliers.DoubleClick -= eventHandler;
      }
      this._grdSuppliers = value;
      if (this._grdSuppliers == null)
        return;
      this._grdSuppliers.CellContentClick += cellEventHandler;
      this._grdSuppliers.DoubleClick += eventHandler;
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

  internal virtual TextBox txtSupplierCode
  {
    [DebuggerNonUserCode] get => this._txtSupplierCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtSupplierCode_TextChanged);
      if (this._txtSupplierCode != null)
        this._txtSupplierCode.TextChanged -= eventHandler;
      this._txtSupplierCode = value;
      if (this._txtSupplierCode == null)
        return;
      this._txtSupplierCode.TextChanged += eventHandler;
    }
  }

  internal virtual TextBox txtSupplierName
  {
    [DebuggerNonUserCode] get => this._txtSupplierName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtSupplierName_TextChanged);
      if (this._txtSupplierName != null)
        this._txtSupplierName.TextChanged -= eventHandler;
      this._txtSupplierName = value;
      if (this._txtSupplierName == null)
        return;
      this._txtSupplierName.TextChanged += eventHandler;
    }
  }

  private void frmSelectSupplier_Load(object sender, EventArgs e)
  {
    this.sSearchString = Strings.Replace(this.sSearchString, "/", "");
    this.txtSupplierCode.Text = this.sSearchString;
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
      string str1 = "select SupplierCode, Name from Suppliers where SupplierCode <> 'z_z' ";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtSupplierCode.Text), "", false) != 0)
        str1 = $"{str1} and  SupplierCode like '{this.txtSupplierCode.Text}%'";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtSupplierName.Text), "", false) != 0)
        str1 = $"{str1} and Name like '{this.txtSupplierName.Text}%'";
      string str2 = str1 + " Order by SupplierCode";
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
      this.grdSuppliers.DataSource = (object) dataSet.Tables[0].DefaultView;
      this.FormatSupplierGrid();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in RefreshSupplierGrid: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void FormatSupplierGrid()
  {
    this.grdSuppliers.AllowUserToAddRows = false;
    this.grdSuppliers.AllowUserToDeleteRows = false;
    this.grdSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    {
      foreach (DataGridViewColumn column in (BaseCollection) this.grdSuppliers.Columns)
      {
        column.ReadOnly = true;
        string name = column.Name;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "SupplierCode", false) == 0)
        {
          column.HeaderText = "Supplier Code";
          column.Width = 100;
          column.DisplayIndex = 0;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "Name", false) == 0)
        {
          column.HeaderText = "Supplier Name";
          column.Width = 350;
          column.DisplayIndex = 1;
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
    if (this.grdSuppliers.SelectedRows.Count == 1)
    {
      modMain.sSearchedSupplierCode = Strings.Trim(Conversions.ToString(this.grdSuppliers.Rows[this.grdSuppliers.SelectedRows[0].Index].Cells["SupplierCode"].Value));
      this.Close();
    }
    else
      modMain.mgBox("Please Select A Supplier");
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

  private void grdSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
  }
}
