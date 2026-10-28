// Decompiled with JetBrains decompiler
// Type: PriceChanger.frmResolveSubGroups
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
public class frmResolveSubGroups : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("cmdAddNew")]
  private Button _cmdAddNew;
  [AccessedThroughProperty("cmdMap")]
  private Button _cmdMap;
  [AccessedThroughProperty("cmdClose")]
  private Button _cmdClose;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("grdProductGroups")]
  private DataGridView _grdProductGroups;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("grdNonMapped")]
  private DataGridView _grdNonMapped;
  private string sProdGroupID;
  private string sProdGroup;

  [DebuggerNonUserCode]
  static frmResolveSubGroups()
  {
  }

  [DebuggerNonUserCode]
  public frmResolveSubGroups()
  {
    this.Load += new EventHandler(this.frmResolveSubGroups_Load);
    frmResolveSubGroups.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmResolveSubGroups.__ENCList)
    {
      if (frmResolveSubGroups.__ENCList.Count == frmResolveSubGroups.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmResolveSubGroups.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmResolveSubGroups.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmResolveSubGroups.__ENCList[index1] = frmResolveSubGroups.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmResolveSubGroups.__ENCList.RemoveRange(index1, checked (frmResolveSubGroups.__ENCList.Count - index1));
        frmResolveSubGroups.__ENCList.Capacity = frmResolveSubGroups.__ENCList.Count;
      }
      frmResolveSubGroups.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmResolveSubGroups));
    this.GroupBox3 = new GroupBox();
    this.grdProductGroups = new DataGridView();
    this.GroupBox2 = new GroupBox();
    this.grdNonMapped = new DataGridView();
    this.cmdAddNew = new Button();
    this.cmdMap = new Button();
    this.cmdClose = new Button();
    this.GroupBox3.SuspendLayout();
    ((ISupportInitialize) this.grdProductGroups).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.grdNonMapped).BeginInit();
    this.SuspendLayout();
    this.GroupBox3.Controls.Add((Control) this.grdProductGroups);
    GroupBox groupBox3_1 = this.GroupBox3;
    Point point1 = new Point(383, 12);
    Point point2 = point1;
    groupBox3_1.Location = point2;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    Size size1 = new Size(354, 292);
    Size size2 = size1;
    groupBox3_2.Size = size2;
    this.GroupBox3.TabIndex = 122;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Available Product Sub Groups";
    this.grdProductGroups.AllowUserToAddRows = false;
    this.grdProductGroups.AllowUserToDeleteRows = false;
    this.grdProductGroups.AllowUserToResizeRows = false;
    this.grdProductGroups.BackgroundColor = Color.Beige;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = Color.AliceBlue;
    gridViewCellStyle1.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.grdProductGroups.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.grdProductGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.grdProductGroups.GridColor = Color.Khaki;
    DataGridView grdProductGroups1 = this.grdProductGroups;
    point1 = new Point(15, 19);
    Point point3 = point1;
    grdProductGroups1.Location = point3;
    this.grdProductGroups.MultiSelect = false;
    this.grdProductGroups.Name = "grdProductGroups";
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = Color.Khaki;
    gridViewCellStyle2.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.grdProductGroups.RowHeadersDefaultCellStyle = gridViewCellStyle2;
    this.grdProductGroups.RowHeadersVisible = false;
    DataGridView grdProductGroups2 = this.grdProductGroups;
    size1 = new Size(330, 267);
    Size size3 = size1;
    grdProductGroups2.Size = size3;
    this.grdProductGroups.TabIndex = 114;
    this.GroupBox2.Controls.Add((Control) this.grdNonMapped);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(12, 12);
    Point point4 = point1;
    groupBox2_1.Location = point4;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(365, 292);
    Size size4 = size1;
    groupBox2_2.Size = size4;
    this.GroupBox2.TabIndex = 121;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Non Mapped Product Sub Groups";
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
    this.grdNonMapped.MultiSelect = false;
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
    size1 = new Size(332, 267);
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
    point1 = new Point(398, 316);
    Point point6 = point1;
    cmdAddNew1.Location = point6;
    this.cmdAddNew.Name = "cmdAddNew";
    Button cmdAddNew2 = this.cmdAddNew;
    size1 = new Size(166, 25);
    Size size6 = size1;
    cmdAddNew2.Size = size6;
    this.cmdAddNew.TabIndex = 125;
    this.cmdAddNew.Text = "Add New Product Sub Group";
    this.cmdAddNew.TextAlign = ContentAlignment.MiddleRight;
    this.cmdAddNew.UseVisualStyleBackColor = false;
    this.cmdMap.Anchor = AnchorStyles.Bottom;
    this.cmdMap.AutoEllipsis = true;
    this.cmdMap.BackColor = Color.Khaki;
    this.cmdMap.Font = new Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdMap.Image = (Image) PriceChanger.My.Resources.Resources.next16;
    this.cmdMap.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdMap1 = this.cmdMap;
    point1 = new Point(27, 316);
    Point point7 = point1;
    cmdMap1.Location = point7;
    this.cmdMap.Name = "cmdMap";
    Button cmdMap2 = this.cmdMap;
    size1 = new Size(192 /*0xC0*/, 25);
    Size size7 = size1;
    cmdMap2.Size = size7;
    this.cmdMap.TabIndex = 124;
    this.cmdMap.Text = "Map Selected Product Sub Group";
    this.cmdMap.TextAlign = ContentAlignment.MiddleRight;
    this.cmdMap.UseVisualStyleBackColor = false;
    this.cmdClose.Anchor = AnchorStyles.None;
    this.cmdClose.AutoEllipsis = true;
    this.cmdClose.BackColor = Color.Khaki;
    this.cmdClose.Font = new Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdClose.Image = (Image) PriceChanger.My.Resources.Resources.close16;
    this.cmdClose.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdClose1 = this.cmdClose;
    point1 = new Point(663, 316);
    Point point8 = point1;
    cmdClose1.Location = point8;
    this.cmdClose.Name = "cmdClose";
    Button cmdClose2 = this.cmdClose;
    size1 = new Size(65, 25);
    Size size8 = size1;
    cmdClose2.Size = size8;
    this.cmdClose.TabIndex = 123;
    this.cmdClose.Text = "Close";
    this.cmdClose.TextAlign = ContentAlignment.MiddleRight;
    this.cmdClose.UseVisualStyleBackColor = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Beige;
    size1 = new Size(743, 353);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.cmdAddNew);
    this.Controls.Add((Control) this.cmdMap);
    this.Controls.Add((Control) this.cmdClose);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GroupBox2);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmResolveSubGroups);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Resolve Sub Groups";
    this.GroupBox3.ResumeLayout(false);
    ((ISupportInitialize) this.grdProductGroups).EndInit();
    this.GroupBox2.ResumeLayout(false);
    ((ISupportInitialize) this.grdNonMapped).EndInit();
    this.ResumeLayout(false);
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

  internal virtual DataGridView grdProductGroups
  {
    [DebuggerNonUserCode] get => this._grdProductGroups;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grdProductGroups = value;
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
      DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.grdNonMapped_RowEnter);
      DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.grdNonMapped_CellContentClick);
      if (this._grdNonMapped != null)
      {
        this._grdNonMapped.RowEnter -= cellEventHandler1;
        this._grdNonMapped.CellContentClick -= cellEventHandler2;
      }
      this._grdNonMapped = value;
      if (this._grdNonMapped == null)
        return;
      this._grdNonMapped.RowEnter += cellEventHandler1;
      this._grdNonMapped.CellContentClick += cellEventHandler2;
    }
  }

  private void cmdClose_Click(object sender, EventArgs e) => this.Close();

  private void frmResolveSubGroups_Load(object sender, EventArgs e) => this.RefreshNonMapped();

  public void RefreshNonMapped()
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
    DataSet dataSet = new DataSet();
    SqlConnection sqlConnection = new SqlConnection();
    try
    {
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      string str = "select  Distinct  ProductGroup,  Subgroup, ProductGroupID  from NewProducts where SubGroupID = ''" + " Order by ProductGroup";
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
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "ProductGroup", false) == 0)
        {
          column.HeaderText = "Product Group";
          column.Width = 150;
          column.DisplayIndex = 0;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "Subgroup", false) == 0)
        {
          column.HeaderText = "Product Sub Group";
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

  private void grdNonMapped_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
  }

  private void grdNonMapped_RowEnter(object sender, DataGridViewCellEventArgs e)
  {
    if (e.ColumnIndex == -1 | e.RowIndex == -1)
      return;
    try
    {
      this.sProdGroupID = Conversions.ToString(this.grdNonMapped.Rows[e.RowIndex].Cells["ProductGroupID"].Value);
      this.sProdGroup = Conversions.ToString(this.grdNonMapped.Rows[e.RowIndex].Cells["ProductGroup"].Value);
      this.RefreshSubGroups(this.sProdGroupID);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  public void RefreshSubGroups(string sProdGroup)
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
    DataSet dataSet = new DataSet();
    SqlConnection sqlConnection = new SqlConnection();
    try
    {
      sqlConnection.ConnectionString = modMain.gsISMConnection;
      string str = $"select  ProductSubgroupCode, Description from ProductSubGroups where ProductGroupCode = '{sProdGroup}'" + " Order by Description";
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
      this.grdProductGroups.DataSource = (object) dataSet.Tables[0].DefaultView;
      this.FormatProductGroups();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in RefreshSubGroups: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void FormatProductGroups()
  {
    this.grdProductGroups.AllowUserToAddRows = false;
    this.grdProductGroups.AllowUserToDeleteRows = false;
    this.grdProductGroups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    {
      foreach (DataGridViewColumn column in (BaseCollection) this.grdProductGroups.Columns)
      {
        column.ReadOnly = true;
        string name = column.Name;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "ProductSubgroupCode", false) == 0)
        {
          column.HeaderText = "Sub Group Code";
          column.Width = 100;
          column.DisplayIndex = 0;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "Description", false) == 0)
        {
          column.HeaderText = "Sub Group Description";
          column.Width = 210;
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

  private void cmdAddNew_Click(object sender, EventArgs e)
  {
    if (this.grdNonMapped.SelectedRows.Count == 0)
    {
      modMain.mgBox("Select Non Mapped Sub Group");
    }
    else
    {
      frmNewProductSubGroup newProductSubGroup = new frmNewProductSubGroup();
      newProductSubGroup.Text = "New Product Sub Group For " + this.sProdGroup;
      newProductSubGroup.sProdGroupID = this.sProdGroupID;
      newProductSubGroup.sProdGroup = this.sProdGroup;
      int num = (int) newProductSubGroup.ShowDialog();
      this.RefreshSubGroups(this.sProdGroupID);
    }
  }

  private void cmdMap_Click(object sender, EventArgs e)
  {
    if (this.grdNonMapped.SelectedRows.Count == 0)
    {
      modMain.mgBox("Select Non Mapped Sub Group To Map");
      this.grdNonMapped.Focus();
    }
    else if (this.grdProductGroups.SelectedRows.Count == 0)
    {
      modMain.mgBox("Select Product Sub Group To Map To");
      this.grdProductGroups.Focus();
    }
    else if (modMain.mgBox("Confirm Selected Product Group Mapping?", bYesNo: true))
    {
      this.MapSelectedRow();
      this.RefreshNonMapped();
    }
  }

  public void MapSelectedRow()
  {
    string str1 = Conversions.ToString(this.grdProductGroups.Rows[this.grdProductGroups.SelectedRows[0].Index].Cells["ProductSubgroupCode"].Value);
    string str2 = Conversions.ToString(this.grdProductGroups.Rows[this.grdProductGroups.SelectedRows[0].Index].Cells["Description"].Value);
    string str3 = Conversions.ToString(this.grdNonMapped.Rows[this.grdNonMapped.SelectedRows[0].Index].Cells["Subgroup"].Value);
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    bool flag = false;
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.StoredProcedure;
      command.CommandText = "NewProduct_ProductSubGroupUpdate";
      command.Parameters.Add(new SqlParameter("@CurrentSubGroup", SqlDbType.VarChar, 100)).Value = (object) str3;
      command.Parameters.Add(new SqlParameter("@ProdGroupCode", SqlDbType.VarChar, 8)).Value = (object) this.sProdGroupID;
      command.Parameters.Add(new SqlParameter("@SubGroupCode", SqlDbType.VarChar, 8)).Value = (object) str1;
      command.Parameters.Add(new SqlParameter("@SubGroupDesc", SqlDbType.VarChar, 100)).Value = (object) str2;
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
        modMain.mgBox("Error in MapSelectedRow: " + ex.Message, true);
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
      modMain.mgBox("Error in MapSelectedRow: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
  }
}
