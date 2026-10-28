// Decompiled with JetBrains decompiler
// Type: PriceChanger.frmDuplicateProducts
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
public class frmDuplicateProducts : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("grdSuppliers")]
  private DataGridView _grdSuppliers;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("grdProducts")]
  private DataGridView _grdProducts;
  [AccessedThroughProperty("cmdClose")]
  private Button _cmdClose;
  [AccessedThroughProperty("cmdUpdate")]
  private Button _cmdUpdate;

  [DebuggerNonUserCode]
  static frmDuplicateProducts()
  {
  }

  [DebuggerNonUserCode]
  public frmDuplicateProducts()
  {
    this.Load += new EventHandler(this.frmDuplicateProducts_Load);
    frmDuplicateProducts.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmDuplicateProducts.__ENCList)
    {
      if (frmDuplicateProducts.__ENCList.Count == frmDuplicateProducts.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmDuplicateProducts.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmDuplicateProducts.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmDuplicateProducts.__ENCList[index1] = frmDuplicateProducts.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmDuplicateProducts.__ENCList.RemoveRange(index1, checked (frmDuplicateProducts.__ENCList.Count - index1));
        frmDuplicateProducts.__ENCList.Capacity = frmDuplicateProducts.__ENCList.Count;
      }
      frmDuplicateProducts.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmDuplicateProducts));
    this.GroupBox3 = new GroupBox();
    this.grdSuppliers = new DataGridView();
    this.GroupBox2 = new GroupBox();
    this.grdProducts = new DataGridView();
    this.cmdClose = new Button();
    this.cmdUpdate = new Button();
    this.GroupBox3.SuspendLayout();
    ((ISupportInitialize) this.grdSuppliers).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.grdProducts).BeginInit();
    this.SuspendLayout();
    this.GroupBox3.Controls.Add((Control) this.grdSuppliers);
    GroupBox groupBox3_1 = this.GroupBox3;
    Point point1 = new Point(501, 12);
    Point point2 = point1;
    groupBox3_1.Location = point2;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    Size size1 = new Size(413, 214);
    Size size2 = size1;
    groupBox3_2.Size = size2;
    this.GroupBox3.TabIndex = 133;
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
    point1 = new Point(6, 19);
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
    size1 = new Size(396, 183);
    Size size3 = size1;
    grdSuppliers2.Size = size3;
    this.grdSuppliers.TabIndex = 114;
    this.GroupBox2.Controls.Add((Control) this.grdProducts);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(12, 12);
    Point point4 = point1;
    groupBox2_1.Location = point4;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(483, 214);
    Size size4 = size1;
    groupBox2_2.Size = size4;
    this.GroupBox2.TabIndex = 132;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Duplicated Products";
    this.grdProducts.AllowUserToAddRows = false;
    this.grdProducts.AllowUserToDeleteRows = false;
    this.grdProducts.AllowUserToResizeRows = false;
    this.grdProducts.BackgroundColor = Color.Beige;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = Color.AliceBlue;
    gridViewCellStyle3.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.grdProducts.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.grdProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.grdProducts.GridColor = Color.Khaki;
    DataGridView grdProducts1 = this.grdProducts;
    point1 = new Point(15, 19);
    Point point5 = point1;
    grdProducts1.Location = point5;
    this.grdProducts.Name = "grdProducts";
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = Color.Khaki;
    gridViewCellStyle4.Font = new Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.WindowText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
    this.grdProducts.RowHeadersDefaultCellStyle = gridViewCellStyle4;
    this.grdProducts.RowHeadersVisible = false;
    DataGridView grdProducts2 = this.grdProducts;
    size1 = new Size(457, 183);
    Size size5 = size1;
    grdProducts2.Size = size5;
    this.grdProducts.TabIndex = 113;
    this.cmdClose.Anchor = AnchorStyles.None;
    this.cmdClose.AutoEllipsis = true;
    this.cmdClose.BackColor = Color.Khaki;
    this.cmdClose.Font = new Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdClose.Image = (Image) PriceChanger.My.Resources.Resources.close16;
    this.cmdClose.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdClose1 = this.cmdClose;
    point1 = new Point(838, 232);
    Point point6 = point1;
    cmdClose1.Location = point6;
    this.cmdClose.Name = "cmdClose";
    Button cmdClose2 = this.cmdClose;
    size1 = new Size(65, 25);
    Size size6 = size1;
    cmdClose2.Size = size6;
    this.cmdClose.TabIndex = 134;
    this.cmdClose.Text = "Close";
    this.cmdClose.TextAlign = ContentAlignment.MiddleRight;
    this.cmdClose.UseVisualStyleBackColor = false;
    this.cmdUpdate.Anchor = AnchorStyles.Bottom;
    this.cmdUpdate.AutoEllipsis = true;
    this.cmdUpdate.BackColor = Color.Khaki;
    this.cmdUpdate.Font = new Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdUpdate.Image = (Image) PriceChanger.My.Resources.Resources.next16;
    this.cmdUpdate.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdUpdate1 = this.cmdUpdate;
    point1 = new Point(507, 232);
    Point point7 = point1;
    cmdUpdate1.Location = point7;
    this.cmdUpdate.Name = "cmdUpdate";
    Button cmdUpdate2 = this.cmdUpdate;
    size1 = new Size(163, 25);
    Size size7 = size1;
    cmdUpdate2.Size = size7;
    this.cmdUpdate.TabIndex = 135;
    this.cmdUpdate.Text = "Update Preferred Supplier";
    this.cmdUpdate.TextAlign = ContentAlignment.MiddleRight;
    this.cmdUpdate.UseVisualStyleBackColor = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Beige;
    size1 = new Size(920, 269);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.cmdUpdate);
    this.Controls.Add((Control) this.cmdClose);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GroupBox2);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmDuplicateProducts);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Duplicate Products";
    this.GroupBox3.ResumeLayout(false);
    ((ISupportInitialize) this.grdSuppliers).EndInit();
    this.GroupBox2.ResumeLayout(false);
    ((ISupportInitialize) this.grdProducts).EndInit();
    this.ResumeLayout(false);
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
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.grdSuppliers_CellContentClick);
      if (this._grdSuppliers != null)
        this._grdSuppliers.CellContentClick -= cellEventHandler;
      this._grdSuppliers = value;
      if (this._grdSuppliers == null)
        return;
      this._grdSuppliers.CellContentClick += cellEventHandler;
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

  internal virtual DataGridView grdProducts
  {
    [DebuggerNonUserCode] get => this._grdProducts;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.grdProducts_RowEnter);
      if (this._grdProducts != null)
        this._grdProducts.RowEnter -= cellEventHandler;
      this._grdProducts = value;
      if (this._grdProducts == null)
        return;
      this._grdProducts.RowEnter += cellEventHandler;
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

  internal virtual Button cmdUpdate
  {
    [DebuggerNonUserCode] get => this._cmdUpdate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdUpdate_Click);
      if (this._cmdUpdate != null)
        this._cmdUpdate.Click -= eventHandler;
      this._cmdUpdate = value;
      if (this._cmdUpdate == null)
        return;
      this._cmdUpdate.Click += eventHandler;
    }
  }

  private void frmDuplicateProducts_Load(object sender, EventArgs e)
  {
    this.Cursor = Cursors.AppStarting;
    this.SetSelectedSupplierFlag();
    this.RefreshDuplicatedProducts();
    this.Cursor = Cursors.Default;
  }

  public void SetSelectedSupplierFlag()
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.StoredProcedure;
      command.CommandText = "DuplicateProducts_SetSelectedSupplier";
      command.CommandTimeout = 0;
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in SetSelectedSupplierFlag: " + ex.Message, true);
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
      modMain.mgBox("Error in SetSelectedSupplierFlag: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void RefreshDuplicatedProducts()
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
    DataSet dataSet = new DataSet();
    SqlConnection sqlConnection = new SqlConnection();
    try
    {
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      string str = "select F.IIHFProductCode as ProductCode, P.Description, P.productreportcode as ReportCode, " + " COUNT(F.IIHFProductCode) as RecCount " + " from FileImports F" + " inner join Innfront.dbo.products P on P.ProductCode = F.IIHFProductCode collate Latin1_General_CI_AS" + " where F.IIHFProductCode <> '' and Deleted = 0" + " group by  F.IIHFProductCode, P.Description ,  P.productreportcode" + " having(COUNT(F.IIHFProductCode) > 1)" + " Order by IIHFProductCode";
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = str;
      sqlDataAdapter.SelectCommand = command;
      command.CommandTimeout = 0;
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
      this.grdProducts.DataSource = (object) dataSet.Tables[0].DefaultView;
      this.FormatProducts();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in RefreshNonMapped: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void FormatProducts()
  {
    this.grdProducts.AllowUserToAddRows = false;
    this.grdProducts.AllowUserToDeleteRows = false;
    this.grdProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    {
      foreach (DataGridViewColumn column in (BaseCollection) this.grdProducts.Columns)
      {
        column.ReadOnly = true;
        string name = column.Name;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "ProductCode", false) == 0)
        {
          column.HeaderText = "Product Code";
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
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "ReportCode", false) == 0)
        {
          column.HeaderText = "Report Code";
          column.Width = 100;
          column.DisplayIndex = 2;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "RecCount", false) == 0)
        {
          column.HeaderText = "Duplicates";
          column.Width = 80 /*0x50*/;
          column.DisplayIndex = 3;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else
          column.Visible = false;
      }
    }
  }

  private void cmdClose_Click(object sender, EventArgs e) => this.Close();

  public void RefreshSuppliers(string sProdCode)
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
    DataSet dataSet = new DataSet();
    SqlConnection sqlConnection = new SqlConnection();
    try
    {
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      string str = $"{"Select S.SupplierCode, S.Name as SupplierName, isnull(I.NewCost,0) as NewCost, I.Selected, I.IIHFProductCode, I.ImportID from FileImports I " + " inner join Templates T on T.TemplateName = I.TemplateName" + " inner join InnFront.dbo.Suppliers S on S.SupplierCode = T.SupplierCode collate Latin1_General_CI_AS"} where I.IIHFProductCode = '{sProdCode}'" + " Order by I.Selected Desc";
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
      modMain.mgBox("Error in RefreshSuppliers: " + ex.Message, true);
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
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "SupplierName", false) == 0)
        {
          column.HeaderText = "Supplier Name";
          column.Width = 150;
          column.DisplayIndex = 1;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "NewCost", false) == 0)
        {
          column.HeaderText = "New Cost";
          column.Width = 80 /*0x50*/;
          column.DisplayIndex = 2;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "Selected", false) == 0)
        {
          column.HeaderText = "Selected";
          column.Width = 60;
          column.DisplayIndex = 3;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else
          column.Visible = false;
      }
    }
  }

  private void grdProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
  {
    if (e.ColumnIndex == -1 | e.RowIndex == -1)
      return;
    try
    {
      this.RefreshSuppliers(Conversions.ToString(this.grdProducts.Rows[e.RowIndex].Cells["ProductCode"].Value));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.Message);
      ProjectData.ClearProjectError();
    }
  }

  private void grdSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
    if (this.grdSuppliers.SelectedRows.Count == 0 || e.ColumnIndex != 3)
      return;
    long num = Conversions.ToLong(this.grdSuppliers.Rows[this.grdSuppliers.SelectedRows[0].Index].Cells["ImportID"].Value);
    string sProdCode = Strings.Trim(Conversions.ToString(this.grdSuppliers.Rows[this.grdSuppliers.SelectedRows[0].Index].Cells["IIHFProductCode"].Value));
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.StoredProcedure;
      command.CommandText = "DuplicateProducts_SelectedSupplierUpdate";
      command.Parameters.Add(new SqlParameter("@ImportID", SqlDbType.BigInt)).Value = (object) num;
      command.Parameters.Add(new SqlParameter("@ProdCode", SqlDbType.VarChar, 30)).Value = (object) sProdCode;
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in grdSuppliers_CellContentClick: " + ex.Message, true);
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
      modMain.mgBox("Error in grdSuppliers_CellContentClick: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    this.RefreshSuppliers(sProdCode);
  }

  private void cmdUpdate_Click(object sender, EventArgs e)
  {
    if (!modMain.mgBox("Update Prefereed Suppliers?", bYesNo: true) || !this.UpdatePreferredSuppliers())
      return;
    modMain.mgBox("Update Complete");
    this.RefreshSuppliers("z");
    this.RefreshDuplicatedProducts();
  }

  private bool UpdatePreferredSuppliers()
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    bool flag = false;
    try
    {
      this.Cursor = Cursors.AppStarting;
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.StoredProcedure;
      command.CommandText = "DuplicateProducts_UpdateSelectedSuppliers";
      command.CommandTimeout = 0;
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Cursor = Cursors.Default;
        flag = true;
        modMain.mgBox("Error in UpdatePreferredSuppliers: " + exception.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
        this.Cursor = Cursors.Default;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      flag = true;
      this.Cursor = Cursors.Default;
      modMain.mgBox("Error in UpdatePreferredSuppliers: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
    return !flag;
  }
}
