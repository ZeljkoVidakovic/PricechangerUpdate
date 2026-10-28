// Decompiled with JetBrains decompiler
// Type: PriceChanger.frmResolveIndex
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
public class frmResolveIndex : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("cmdMap")]
  private Button _cmdMap;
  [AccessedThroughProperty("cmdClose")]
  private Button _cmdClose;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("grdIndex")]
  private DataGridView _grdIndex;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("grdNonMapped")]
  private DataGridView _grdNonMapped;
  [AccessedThroughProperty("cmdAddNew")]
  private Button _cmdAddNew;
  [AccessedThroughProperty("cmdCreateAll")]
  private Button _cmdCreateAll;

  [DebuggerNonUserCode]
  static frmResolveIndex()
  {
  }

  [DebuggerNonUserCode]
  public frmResolveIndex()
  {
    this.Load += new EventHandler(this.frmResolveIndex_Load);
    frmResolveIndex.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmResolveIndex.__ENCList)
    {
      if (frmResolveIndex.__ENCList.Count == frmResolveIndex.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmResolveIndex.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmResolveIndex.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmResolveIndex.__ENCList[index1] = frmResolveIndex.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmResolveIndex.__ENCList.RemoveRange(index1, checked (frmResolveIndex.__ENCList.Count - index1));
        frmResolveIndex.__ENCList.Capacity = frmResolveIndex.__ENCList.Count;
      }
      frmResolveIndex.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmResolveIndex));
    this.GroupBox3 = new GroupBox();
    this.grdIndex = new DataGridView();
    this.GroupBox2 = new GroupBox();
    this.grdNonMapped = new DataGridView();
    this.cmdAddNew = new Button();
    this.cmdMap = new Button();
    this.cmdClose = new Button();
    this.cmdCreateAll = new Button();
    this.GroupBox3.SuspendLayout();
    ((ISupportInitialize) this.grdIndex).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.grdNonMapped).BeginInit();
    this.SuspendLayout();
    this.GroupBox3.Controls.Add((Control) this.grdIndex);
    GroupBox groupBox3_1 = this.GroupBox3;
    Point point1 = new Point(501, 12);
    Point point2 = point1;
    groupBox3_1.Location = point2;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    Size size1 = new Size(298, 292);
    Size size2 = size1;
    groupBox3_2.Size = size2;
    this.GroupBox3.TabIndex = 131;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Available Indexes";
    this.grdIndex.AllowUserToAddRows = false;
    this.grdIndex.AllowUserToDeleteRows = false;
    this.grdIndex.AllowUserToResizeRows = false;
    this.grdIndex.BackgroundColor = Color.Beige;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = Color.AliceBlue;
    gridViewCellStyle1.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.grdIndex.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.grdIndex.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.grdIndex.GridColor = Color.Khaki;
    DataGridView grdIndex1 = this.grdIndex;
    point1 = new Point(6, 19);
    Point point3 = point1;
    grdIndex1.Location = point3;
    this.grdIndex.MultiSelect = false;
    this.grdIndex.Name = "grdIndex";
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = Color.Khaki;
    gridViewCellStyle2.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.grdIndex.RowHeadersDefaultCellStyle = gridViewCellStyle2;
    this.grdIndex.RowHeadersVisible = false;
    DataGridView grdIndex2 = this.grdIndex;
    size1 = new Size(278, 267);
    Size size3 = size1;
    grdIndex2.Size = size3;
    this.grdIndex.TabIndex = 114;
    this.GroupBox2.Controls.Add((Control) this.grdNonMapped);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(12, 12);
    Point point4 = point1;
    groupBox2_1.Location = point4;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(483, 292);
    Size size4 = size1;
    groupBox2_2.Size = size4;
    this.GroupBox2.TabIndex = 130;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Non Mapped Products";
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
    point1 = new Point(15, 19);
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
    size1 = new Size(457, 267);
    Size size5 = size1;
    grdNonMapped2.Size = size5;
    this.grdNonMapped.TabIndex = 113;
    this.cmdAddNew.Anchor = AnchorStyles.Bottom;
    this.cmdAddNew.AutoEllipsis = true;
    this.cmdAddNew.BackColor = Color.Khaki;
    this.cmdAddNew.Font = new Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdAddNew.Image = (Image) PriceChanger.My.Resources.Resources.add16;
    this.cmdAddNew.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdAddNew1 = this.cmdAddNew;
    point1 = new Point(507, 310);
    Point point6 = point1;
    cmdAddNew1.Location = point6;
    this.cmdAddNew.Name = "cmdAddNew";
    Button cmdAddNew2 = this.cmdAddNew;
    size1 = new Size(111, 25);
    Size size6 = size1;
    cmdAddNew2.Size = size6;
    this.cmdAddNew.TabIndex = 134;
    this.cmdAddNew.Text = "Add New Index";
    this.cmdAddNew.TextAlign = ContentAlignment.MiddleRight;
    this.cmdAddNew.UseVisualStyleBackColor = false;
    this.cmdMap.Anchor = AnchorStyles.Bottom;
    this.cmdMap.AutoEllipsis = true;
    this.cmdMap.BackColor = Color.Khaki;
    this.cmdMap.Font = new Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdMap.Image = (Image) PriceChanger.My.Resources.Resources.next16;
    this.cmdMap.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdMap1 = this.cmdMap;
    point1 = new Point(27, 310);
    Point point7 = point1;
    cmdMap1.Location = point7;
    this.cmdMap.Name = "cmdMap";
    Button cmdMap2 = this.cmdMap;
    size1 = new Size(148, 25);
    Size size7 = size1;
    cmdMap2.Size = size7;
    this.cmdMap.TabIndex = 133;
    this.cmdMap.Text = "Map Selected Products";
    this.cmdMap.TextAlign = ContentAlignment.MiddleRight;
    this.cmdMap.UseVisualStyleBackColor = false;
    this.cmdClose.Anchor = AnchorStyles.None;
    this.cmdClose.AutoEllipsis = true;
    this.cmdClose.BackColor = Color.Khaki;
    this.cmdClose.Font = new Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdClose.Image = (Image) PriceChanger.My.Resources.Resources.close16;
    this.cmdClose.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdClose1 = this.cmdClose;
    point1 = new Point(720, 310);
    Point point8 = point1;
    cmdClose1.Location = point8;
    this.cmdClose.Name = "cmdClose";
    Button cmdClose2 = this.cmdClose;
    size1 = new Size(65, 25);
    Size size8 = size1;
    cmdClose2.Size = size8;
    this.cmdClose.TabIndex = 132;
    this.cmdClose.Text = "Close";
    this.cmdClose.TextAlign = ContentAlignment.MiddleRight;
    this.cmdClose.UseVisualStyleBackColor = false;
    this.cmdCreateAll.Anchor = AnchorStyles.Bottom;
    this.cmdCreateAll.AutoEllipsis = true;
    this.cmdCreateAll.BackColor = Color.Khaki;
    this.cmdCreateAll.Font = new Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdCreateAll.Image = (Image) PriceChanger.My.Resources.Resources.add16;
    this.cmdCreateAll.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdCreateAll1 = this.cmdCreateAll;
    point1 = new Point(269, 310);
    Point point9 = point1;
    cmdCreateAll1.Location = point9;
    this.cmdCreateAll.Name = "cmdCreateAll";
    Button cmdCreateAll2 = this.cmdCreateAll;
    size1 = new Size(132, 25);
    Size size9 = size1;
    cmdCreateAll2.Size = size9;
    this.cmdCreateAll.TabIndex = 135;
    this.cmdCreateAll.Text = "Auto Create Indexes";
    this.cmdCreateAll.TextAlign = ContentAlignment.MiddleRight;
    this.cmdCreateAll.UseVisualStyleBackColor = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Beige;
    size1 = new Size(808, 341);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.cmdCreateAll);
    this.Controls.Add((Control) this.cmdAddNew);
    this.Controls.Add((Control) this.cmdMap);
    this.Controls.Add((Control) this.cmdClose);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GroupBox2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmResolveIndex);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Resolve Index";
    this.GroupBox3.ResumeLayout(false);
    ((ISupportInitialize) this.grdIndex).EndInit();
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

  internal virtual DataGridView grdIndex
  {
    [DebuggerNonUserCode] get => this._grdIndex;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grdIndex = value;
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

  internal virtual Button cmdAddNew
  {
    [DebuggerNonUserCode] get => this._cmdAddNew;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdAddNew_Click);
      if (this._cmdAddNew != null)
        this._cmdAddNew.Click -= eventHandler;
      this._cmdAddNew = value;
      if (this._cmdAddNew == null)
        return;
      this._cmdAddNew.Click += eventHandler;
    }
  }

  internal virtual Button cmdCreateAll
  {
    [DebuggerNonUserCode] get => this._cmdCreateAll;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdCreateAll_Click);
      if (this._cmdCreateAll != null)
        this._cmdCreateAll.Click -= eventHandler;
      this._cmdCreateAll = value;
      if (this._cmdCreateAll == null)
        return;
      this._cmdCreateAll.Click += eventHandler;
    }
  }

  private void cmdClose_Click(object sender, EventArgs e) => this.Close();

  private void frmResolveIndex_Load(object sender, EventArgs e)
  {
    this.RefreshNonMapped();
    this.RefreshIndex();
  }

  public void RefreshNonMapped()
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
    DataSet dataSet = new DataSet();
    SqlConnection sqlConnection = new SqlConnection();
    try
    {
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      string str = "select  UniqueID, Description, [Index] from NewProducts where [Index]  = '' or [index] not in (Select Description  collate Latin1_General_CI_AS from innfront.dbo.AnalysisTree where ParentAnalysisID = 2) " + " Order by Code";
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
          column.Width = 240 /*0xF0*/;
          column.DisplayIndex = 0;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "Index", false) == 0)
        {
          column.HeaderText = "Index";
          column.Width = 180;
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

  public void RefreshIndex()
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
    DataSet dataSet = new DataSet();
    SqlConnection sqlConnection = new SqlConnection();
    try
    {
      sqlConnection.ConnectionString = modMain.gsISMConnection;
      string str = "select AnalysisCode, Description from AnalysisTree where ParentAnalysisID = 2" + " Order by Description";
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
      this.grdIndex.DataSource = (object) dataSet.Tables[0].DefaultView;
      this.FormatIndex();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in RefreshNonMapped: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void FormatIndex()
  {
    this.grdIndex.AllowUserToAddRows = false;
    this.grdIndex.AllowUserToDeleteRows = false;
    this.grdIndex.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    {
      foreach (DataGridViewColumn column in (BaseCollection) this.grdIndex.Columns)
      {
        column.ReadOnly = true;
        string name = column.Name;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "AnalysisCode", false) == 0)
        {
          column.HeaderText = "Analysis Code";
          column.Width = 100;
          column.DisplayIndex = 0;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "Description", false) == 0)
        {
          column.HeaderText = "Description";
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

  private void cmdMap_Click(object sender, EventArgs e)
  {
    if (this.grdNonMapped.SelectedRows.Count == 0)
    {
      modMain.mgBox("Select Non Mapped Product To Map");
      this.grdNonMapped.Focus();
    }
    else if (this.grdIndex.SelectedRows.Count == 0)
    {
      modMain.mgBox("Select Index To Map To");
      this.grdIndex.Focus();
    }
    else if (modMain.mgBox("Confirm Selected Index Mappings?", bYesNo: true))
    {
      this.MapSelectedRows();
      this.RefreshNonMapped();
    }
  }

  public void MapSelectedRows()
  {
    string sIndex = Conversions.ToString(this.grdIndex.Rows[this.grdIndex.SelectedRows[0].Index].Cells["Description"].Value);
    {
      foreach (DataGridViewRow selectedRow in (BaseCollection) this.grdNonMapped.SelectedRows)
      {
        DataRow dataRow = (DataRow) null;
        try
        {
          dataRow = ((DataRowView) selectedRow.DataBoundItem).Row;
          this.MapIndex(Conversions.ToInteger(dataRow.ItemArray[0].ToString()), sIndex);
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

  public void MapIndex(int iID, string sIndex)
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
      command.CommandText = "NewProduct_IndexUpdate";
      command.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int)).Value = (object) iID;
      command.Parameters.Add(new SqlParameter("@Index", SqlDbType.VarChar, 100)).Value = (object) sIndex;
      sqlDataAdapter2.SelectCommand = command;
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

  private void cmdAddNew_Click(object sender, EventArgs e)
  {
    int num = (int) new frmNewIndex().ShowDialog();
    this.RefreshIndex();
  }

  private void cmdCreateAll_Click(object sender, EventArgs e)
  {
    if (!modMain.mgBox("Create ALL Missing Indexes?", bYesNo: true))
      return;
    this.CreateMissingIndexes();
    this.RefreshNonMapped();
    this.RefreshIndex();
  }

  public void CreateMissingIndexes()
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
      command.CommandText = "NewProducts_IndexesCreateMissing";
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
        modMain.mgBox("Error in CreateMissingIndexes: " + ex.Message, true);
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
      modMain.mgBox("Error in CreateMissingIndexes: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
  }
}
