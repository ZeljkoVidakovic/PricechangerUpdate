// Decompiled with JetBrains decompiler
// Type: PriceChanger.frmResolveSupplier
// Assembly: PriceChanger, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A2A849E8-FEFE-4A2B-AE8B-0FA642F38116
// Assembly location: C:\Users\zeljk\Desktop\VPN\Pricechanger\PriceChanger.exe

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
public class frmResolveSupplier : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("cmdMap")]
  private Button _cmdMap;
  [AccessedThroughProperty("cmdClose")]
  private Button _cmdClose;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("grdSuppliers")]
  private DataGridView _grdSuppliers;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("grdNonMapped")]
  private DataGridView _grdNonMapped;

  [DebuggerNonUserCode]
  static frmResolveSupplier()
  {
  }

  [DebuggerNonUserCode]
  public frmResolveSupplier()
  {
    this.Load += new EventHandler(this.frmResolveSupplier_Load);
    frmResolveSupplier.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmResolveSupplier.__ENCList)
    {
      if (frmResolveSupplier.__ENCList.Count == frmResolveSupplier.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmResolveSupplier.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmResolveSupplier.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmResolveSupplier.__ENCList[index1] = frmResolveSupplier.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmResolveSupplier.__ENCList.RemoveRange(index1, checked (frmResolveSupplier.__ENCList.Count - index1));
        frmResolveSupplier.__ENCList.Capacity = frmResolveSupplier.__ENCList.Count;
      }
      frmResolveSupplier.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
    this.GroupBox3 = new GroupBox();
    this.grdSuppliers = new DataGridView();
    this.GroupBox2 = new GroupBox();
    this.grdNonMapped = new DataGridView();
    this.cmdMap = new Button();
    this.cmdClose = new Button();
    this.GroupBox3.SuspendLayout();
    ((ISupportInitialize) this.grdSuppliers).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.grdNonMapped).BeginInit();
    this.SuspendLayout();
    this.GroupBox3.Controls.Add((Control) this.grdSuppliers);
    GroupBox groupBox3_1 = this.GroupBox3;
    Point point1 = new Point(472, 12);
    Point point2 = point1;
    groupBox3_1.Location = point2;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    Size size1 = new Size(354, 292);
    Size size2 = size1;
    groupBox3_2.Size = size2;
    this.GroupBox3.TabIndex = (int) sbyte.MaxValue;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Available Suppliers";
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
    point1 = new Point(15, 19);
    Point point3 = point1;
    grdSuppliers1.Location = point3;
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
    size1 = new Size(330, 267);
    Size size3 = size1;
    grdSuppliers2.Size = size3;
    this.grdSuppliers.TabIndex = 114;
    this.GroupBox2.Controls.Add((Control) this.grdNonMapped);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(12, 12);
    Point point4 = point1;
    groupBox2_1.Location = point4;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(451, 292);
    Size size4 = size1;
    groupBox2_2.Size = size4;
    this.GroupBox2.TabIndex = 126;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Non Mapped Suppliers";
    this.grdNonMapped.AllowUserToAddRows = false;
    this.grdNonMapped.AllowUserToDeleteRows = false;
    this.grdNonMapped.AllowUserToResizeRows = false;
    this.grdNonMapped.BackgroundColor = Color.Beige;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = Color.AliceBlue;
    gridViewCellStyle3.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.grdNonMapped.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.grdNonMapped.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.grdNonMapped.GridColor = Color.Khaki;
    DataGridView grdNonMapped1 = this.grdNonMapped;
    point1 = new Point(6, 19);
    Point point5 = point1;
    grdNonMapped1.Location = point5;
    this.grdNonMapped.Name = "grdNonMapped";
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = Color.Khaki;
    gridViewCellStyle4.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.WindowText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
    this.grdNonMapped.RowHeadersDefaultCellStyle = gridViewCellStyle4;
    this.grdNonMapped.RowHeadersVisible = false;
    DataGridView grdNonMapped2 = this.grdNonMapped;
    size1 = new Size(437, 267);
    Size size5 = size1;
    grdNonMapped2.Size = size5;
    this.grdNonMapped.TabIndex = 113;
    this.cmdMap.Anchor = AnchorStyles.Bottom;
    this.cmdMap.AutoEllipsis = true;
    this.cmdMap.BackColor = Color.Khaki;
    this.cmdMap.Font = new Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdMap.Image = (Image) PriceChanger.My.Resources.Resources.next16;
    this.cmdMap.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdMap1 = this.cmdMap;
    point1 = new Point(18, 310);
    Point point6 = point1;
    cmdMap1.Location = point6;
    this.cmdMap.Name = "cmdMap";
    Button cmdMap2 = this.cmdMap;
    size1 = new Size(148, 25);
    Size size6 = size1;
    cmdMap2.Size = size6;
    this.cmdMap.TabIndex = 129;
    this.cmdMap.Text = "Map Selected Suppliers";
    this.cmdMap.TextAlign = ContentAlignment.MiddleRight;
    this.cmdMap.UseVisualStyleBackColor = false;
    this.cmdClose.Anchor = AnchorStyles.None;
    this.cmdClose.AutoEllipsis = true;
    this.cmdClose.BackColor = Color.Khaki;
    this.cmdClose.Font = new Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdClose.Image = (Image) PriceChanger.My.Resources.Resources.close16;
    this.cmdClose.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdClose1 = this.cmdClose;
    point1 = new Point(752, 310);
    Point point7 = point1;
    cmdClose1.Location = point7;
    this.cmdClose.Name = "cmdClose";
    Button cmdClose2 = this.cmdClose;
    size1 = new Size(65, 25);
    Size size7 = size1;
    cmdClose2.Size = size7;
    this.cmdClose.TabIndex = 128 /*0x80*/;
    this.cmdClose.Text = "Close";
    this.cmdClose.TextAlign = ContentAlignment.MiddleRight;
    this.cmdClose.UseVisualStyleBackColor = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Beige;
    size1 = new Size(838, 343);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.cmdMap);
    this.Controls.Add((Control) this.cmdClose);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GroupBox2);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmResolveSupplier);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Resolve Supplier";
    this.GroupBox3.ResumeLayout(false);
    ((ISupportInitialize) this.grdSuppliers).EndInit();
    this.GroupBox2.ResumeLayout(false);
    ((ISupportInitialize) this.grdNonMapped).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual Button cmdMap
  {
    [DebuggerNonUserCode] get => this._cmdMap;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdMap_Click);
      if (this._cmdMap != null)
        this._cmdMap.Click -= eventHandler;
      this._cmdMap = value;
      if (this._cmdMap == null)
        return;
      this._cmdMap.Click += eventHandler;
    }
  }

  internal virtual Button cmdClose
  {
    [DebuggerNonUserCode] get => this._cmdClose;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdClose_Click);
      if (this._cmdClose != null)
        this._cmdClose.Click -= eventHandler;
      this._cmdClose = value;
      if (this._cmdClose == null)
        return;
      this._cmdClose.Click += eventHandler;
    }
  }

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
    }
  }

  internal virtual DataGridView grdSuppliers
  {
    [DebuggerNonUserCode] get => this._grdSuppliers;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grdSuppliers = value;
    }
  }

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual DataGridView grdNonMapped
  {
    [DebuggerNonUserCode] get => this._grdNonMapped;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grdNonMapped = value;
    }
  }

  private void cmdClose_Click(object sender, EventArgs e) => this.Close();

  private void frmResolveSupplier_Load(object sender, EventArgs e)
  {
    this.RefreshNonMapped();
    this.RefreshSuppliers();
  }

  public void RefreshSuppliers()
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
    DataSet dataSet = new DataSet();
    SqlConnection sqlConnection = new SqlConnection();
    try
    {
      sqlConnection.ConnectionString = modMain.gsISMConnection;
      string str = "select  SupplierCode, Name from Suppliers" + " Order by Name";
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = str;
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
      this.FormatSuppliers();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in RefreshNonMapped: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void FormatSuppliers()
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
          column.Width = 200;
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

  public void FormatNonMapped()
  {
    this.grdNonMapped.AllowUserToAddRows = false;
    this.grdNonMapped.AllowUserToDeleteRows = false;
    this.grdNonMapped.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    {
      foreach (DataGridViewColumn column in (BaseCollection) this.grdNonMapped.Columns)
      {
        column.ReadOnly = true;
        string name = column.Name;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "Description", false) == 0)
        {
          column.HeaderText = "Product Desc";
          column.Width = 250;
          column.DisplayIndex = 0;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "PreferredSupplier", false) == 0)
        {
          column.HeaderText = "Preferred Supplier";
          column.Width = 150;
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

  public void RefreshNonMapped()
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
    DataSet dataSet = new DataSet();
    SqlConnection sqlConnection = new SqlConnection();
    try
    {
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      string str = "select UniqueID, Description, PreferredSupplier from NewProducts where SupplierID = '' and PreferredSupplier <> ''" + " Order by PreferredSupplier";
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = str;
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
      this.grdNonMapped.DataSource = (object) dataSet.Tables[0].DefaultView;
      this.FormatNonMapped();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in RefreshNonMapped: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  private void cmdMap_Click(object sender, EventArgs e)
  {
    if (this.grdNonMapped.SelectedRows.Count == 0)
    {
      modMain.mgBox("Select Non Mapped Product To Map");
      this.grdNonMapped.Focus();
    }
    else if (this.grdSuppliers.SelectedRows.Count == 0)
    {
      modMain.mgBox("Select Supplier To Map To");
      this.grdSuppliers.Focus();
    }
    else if (modMain.mgBox("Confirm Selected Supplier Mappings?", bYesNo: true))
    {
      this.MapSelectedRows();
      this.RefreshNonMapped();
    }
  }

  public void MapSelectedRows()
  {
    string sSupplier = Conversions.ToString(this.grdSuppliers.Rows[this.grdSuppliers.SelectedRows[0].Index].Cells["SupplierCode"].Value);
    string sSupplierName = Conversions.ToString(this.grdSuppliers.Rows[this.grdSuppliers.SelectedRows[0].Index].Cells["Name"].Value);
    {
      foreach (DataGridViewRow selectedRow in (BaseCollection) this.grdNonMapped.SelectedRows)
      {
        DataRow dataRow = (DataRow) null;
        try
        {
          dataRow = ((DataRowView) selectedRow.DataBoundItem).Row;
          this.MapSupplier(Conversions.ToInteger(dataRow.ItemArray[0].ToString()), sSupplier, sSupplierName);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Debug.WriteLine("Error: " + ex.Message);
          ProjectData.ClearProjectError();
        }
        if (dataRow != null)
          ;
      }
    }
  }

  public void MapSupplier(int ID, string sSupplier, string sSupplierName)
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    bool flag = false;
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.StoredProcedure;
      command.CommandText = "NewProduct_SupplierUpdate";
      command.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int)).Value = (object) ID;
      command.Parameters.Add(new SqlParameter("@SupplierCode", SqlDbType.VarChar, 8)).Value = (object) sSupplier;
      command.Parameters.Add(new SqlParameter("@SupplierName", SqlDbType.VarChar, 100)).Value = (object) sSupplierName;
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in MapSupplier: " + ex.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      flag = true;
      modMain.mgBox("Error in MapSupplier: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
  }
}
