// Decompiled with JetBrains decompiler
// Type: PriceChanger.frmDuplicateProductsV2
// Assembly: PriceChanger, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A2A849E8-FEFE-4A2B-AE8B-0FA642F38116
// Assembly location: C:\Users\zeljk\Desktop\VPN\Pricechanger\PriceChanger.exe

using Microsoft.Office.Interop.Excel;
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
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace PriceChanger;

[DesignerGenerated]
public class frmDuplicateProductsV2 : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("grdProducts")]
  private DataGridView _grdProducts;
  [AccessedThroughProperty("cmdUpdate")]
  private System.Windows.Forms.Button _cmdUpdate;
  [AccessedThroughProperty("cmdClose")]
  private System.Windows.Forms.Button _cmdClose;
  [AccessedThroughProperty("txtProdCode")]
  private System.Windows.Forms.TextBox _txtProdCode;
  [AccessedThroughProperty("Label22")]
  private System.Windows.Forms.Label _Label22;
  [AccessedThroughProperty("Label1")]
  private System.Windows.Forms.Label _Label1;
  [AccessedThroughProperty("cmdExport")]
  private System.Windows.Forms.Button _cmdExport;
  [AccessedThroughProperty("rad2007")]
  private RadioButton _rad2007;
  private DataSet moDS;
  private bool bSupplierSelected;

  [DebuggerNonUserCode]
  static frmDuplicateProductsV2()
  {
  }

  public frmDuplicateProductsV2()
  {
    this.Load += new EventHandler(this.frmDuplicateProductsV2_Load);
    frmDuplicateProductsV2.__ENCAddToList((object) this);
    this.moDS = new DataSet();
    this.bSupplierSelected = false;
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmDuplicateProductsV2.__ENCList)
    {
      if (frmDuplicateProductsV2.__ENCList.Count == frmDuplicateProductsV2.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmDuplicateProductsV2.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmDuplicateProductsV2.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmDuplicateProductsV2.__ENCList[index1] = frmDuplicateProductsV2.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmDuplicateProductsV2.__ENCList.RemoveRange(index1, checked (frmDuplicateProductsV2.__ENCList.Count - index1));
        frmDuplicateProductsV2.__ENCList.Capacity = frmDuplicateProductsV2.__ENCList.Count;
      }
      frmDuplicateProductsV2.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.grdProducts = new DataGridView();
    this.cmdUpdate = new System.Windows.Forms.Button();
    this.cmdClose = new System.Windows.Forms.Button();
    this.txtProdCode = new System.Windows.Forms.TextBox();
    this.Label22 = new System.Windows.Forms.Label();
    this.Label1 = new System.Windows.Forms.Label();
    this.cmdExport = new System.Windows.Forms.Button();
    this.rad2007 = new RadioButton();
    ((ISupportInitialize) this.grdProducts).BeginInit();
    this.SuspendLayout();
    this.grdProducts.AllowUserToAddRows = false;
    this.grdProducts.AllowUserToDeleteRows = false;
    this.grdProducts.AllowUserToResizeRows = false;
    this.grdProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.grdProducts.BackgroundColor = Color.Beige;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = Color.AliceBlue;
    gridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.grdProducts.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.grdProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.grdProducts.GridColor = Color.Khaki;
    DataGridView grdProducts1 = this.grdProducts;
    System.Drawing.Point point1 = new System.Drawing.Point(12, 53);
    System.Drawing.Point point2 = point1;
    grdProducts1.Location = point2;
    this.grdProducts.Name = "grdProducts";
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = Color.Khaki;
    gridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.grdProducts.RowHeadersDefaultCellStyle = gridViewCellStyle2;
    this.grdProducts.RowHeadersVisible = false;
    DataGridView grdProducts2 = this.grdProducts;
    Size size1 = new Size(942, 479);
    Size size2 = size1;
    grdProducts2.Size = size2;
    this.grdProducts.TabIndex = 114;
    this.cmdUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.cmdUpdate.AutoEllipsis = true;
    this.cmdUpdate.BackColor = Color.Khaki;
    this.cmdUpdate.Font = new System.Drawing.Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdUpdate.Image = (Image) PriceChanger.My.Resources.Resources.next16;
    this.cmdUpdate.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdUpdate1 = this.cmdUpdate;
    point1 = new System.Drawing.Point(12, 538);
    System.Drawing.Point point3 = point1;
    cmdUpdate1.Location = point3;
    this.cmdUpdate.Name = "cmdUpdate";
    System.Windows.Forms.Button cmdUpdate2 = this.cmdUpdate;
    size1 = new Size(163, 25);
    Size size3 = size1;
    cmdUpdate2.Size = size3;
    this.cmdUpdate.TabIndex = 137;
    this.cmdUpdate.Text = "Update Preferred Supplier";
    this.cmdUpdate.TextAlign = ContentAlignment.MiddleRight;
    this.cmdUpdate.UseVisualStyleBackColor = false;
    this.cmdClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.cmdClose.AutoEllipsis = true;
    this.cmdClose.BackColor = Color.Khaki;
    this.cmdClose.Font = new System.Drawing.Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdClose.Image = (Image) PriceChanger.My.Resources.Resources.close16;
    this.cmdClose.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdClose1 = this.cmdClose;
    point1 = new System.Drawing.Point(889, 538);
    System.Drawing.Point point4 = point1;
    cmdClose1.Location = point4;
    this.cmdClose.Name = "cmdClose";
    System.Windows.Forms.Button cmdClose2 = this.cmdClose;
    size1 = new Size(65, 25);
    Size size4 = size1;
    cmdClose2.Size = size4;
    this.cmdClose.TabIndex = 136;
    this.cmdClose.Text = "Close";
    this.cmdClose.TextAlign = ContentAlignment.MiddleRight;
    this.cmdClose.UseVisualStyleBackColor = false;
    this.txtProdCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtProdCode.BackColor = Color.Khaki;
    this.txtProdCode.BorderStyle = BorderStyle.FixedSingle;
    this.txtProdCode.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtProdCode1 = this.txtProdCode;
    point1 = new System.Drawing.Point(316, 12);
    System.Drawing.Point point5 = point1;
    txtProdCode1.Location = point5;
    this.txtProdCode.MaxLength = 20;
    this.txtProdCode.Name = "txtProdCode";
    System.Windows.Forms.TextBox txtProdCode2 = this.txtProdCode;
    size1 = new Size(140, 24);
    Size size5 = size1;
    txtProdCode2.Size = size5;
    this.txtProdCode.TabIndex = 138;
    this.Label22.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label22_1 = this.Label22;
    point1 = new System.Drawing.Point(11, 12);
    System.Drawing.Point point6 = point1;
    label22_1.Location = point6;
    this.Label22.Name = "Label22";
    System.Windows.Forms.Label label22_2 = this.Label22;
    size1 = new Size(312, 24);
    Size size6 = size1;
    label22_2.Size = size6;
    this.Label22.TabIndex = 139;
    this.Label22.Text = "Show Product Codes where Description is  Like...";
    this.Label22.TextAlign = ContentAlignment.MiddleLeft;
    this.Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label1.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label1_1 = this.Label1;
    point1 = new System.Drawing.Point(482, 12);
    System.Drawing.Point point7 = point1;
    label1_1.Location = point7;
    this.Label1.Name = "Label1";
    System.Windows.Forms.Label label1_2 = this.Label1;
    size1 = new Size(131, 24);
    Size size7 = size1;
    label1_2.Size = size7;
    this.Label1.TabIndex = 140;
    this.Label1.Text = "(Blank shows all)";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.cmdExport.Anchor = AnchorStyles.Bottom;
    this.cmdExport.AutoEllipsis = true;
    this.cmdExport.BackColor = Color.Khaki;
    this.cmdExport.Font = new System.Drawing.Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdExport.Image = (Image) PriceChanger.My.Resources.Resources.next16;
    this.cmdExport.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdExport1 = this.cmdExport;
    point1 = new System.Drawing.Point(204, 538);
    System.Drawing.Point point8 = point1;
    cmdExport1.Location = point8;
    this.cmdExport.Name = "cmdExport";
    System.Windows.Forms.Button cmdExport2 = this.cmdExport;
    size1 = new Size(107, 25);
    Size size8 = size1;
    cmdExport2.Size = size8;
    this.cmdExport.TabIndex = 141;
    this.cmdExport.Text = "Export to Excel";
    this.cmdExport.TextAlign = ContentAlignment.MiddleRight;
    this.cmdExport.UseVisualStyleBackColor = false;
    this.rad2007.Anchor = AnchorStyles.Bottom;
    this.rad2007.AutoSize = true;
    this.rad2007.Checked = true;
    this.rad2007.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    RadioButton rad2007_1 = this.rad2007;
    point1 = new System.Drawing.Point(326, 542);
    System.Drawing.Point point9 = point1;
    rad2007_1.Location = point9;
    this.rad2007.Name = "rad2007";
    RadioButton rad2007_2 = this.rad2007;
    size1 = new Size(84, 21);
    Size size9 = size1;
    rad2007_2.Size = size9;
    this.rad2007.TabIndex = 143;
    this.rad2007.TabStop = true;
    this.rad2007.Text = "2007 (.xls)";
    this.rad2007.UseVisualStyleBackColor = true;
    this.rad2007.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(966, 575);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.rad2007);
    this.Controls.Add((Control) this.cmdExport);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtProdCode);
    this.Controls.Add((Control) this.Label22);
    this.Controls.Add((Control) this.cmdUpdate);
    this.Controls.Add((Control) this.cmdClose);
    this.Controls.Add((Control) this.grdProducts);
    this.Name = nameof (frmDuplicateProductsV2);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Duplicate ProductsV2";
    this.WindowState = FormWindowState.Maximized;
    ((ISupportInitialize) this.grdProducts).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual DataGridView grdProducts
  {
    [DebuggerNonUserCode] get => this._grdProducts;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellMouseEventHandler mouseEventHandler = new DataGridViewCellMouseEventHandler(this.grdProducts_ColumnHeaderMouseClick);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.grdProducts_CellContentClick);
      if (this._grdProducts != null)
      {
        this._grdProducts.ColumnHeaderMouseClick -= mouseEventHandler;
        this._grdProducts.CellContentClick -= cellEventHandler;
      }
      this._grdProducts = value;
      if (this._grdProducts == null)
        return;
      this._grdProducts.ColumnHeaderMouseClick += mouseEventHandler;
      this._grdProducts.CellContentClick += cellEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button cmdUpdate
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

  internal virtual System.Windows.Forms.Button cmdClose
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

  internal virtual System.Windows.Forms.TextBox txtProdCode
  {
    [DebuggerNonUserCode] get => this._txtProdCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtProdCode_TextChanged);
      if (this._txtProdCode != null)
        this._txtProdCode.TextChanged -= eventHandler;
      this._txtProdCode = value;
      if (this._txtProdCode == null)
        return;
      this._txtProdCode.TextChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label22
  {
    [DebuggerNonUserCode] get => this._Label22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label22 = value;
  }

  internal virtual System.Windows.Forms.Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual System.Windows.Forms.Button cmdExport
  {
    [DebuggerNonUserCode] get => this._cmdExport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdExport_Click);
      if (this._cmdExport != null)
        this._cmdExport.Click -= eventHandler;
      this._cmdExport = value;
      if (this._cmdExport == null)
        return;
      this._cmdExport.Click += eventHandler;
    }
  }

  internal virtual RadioButton rad2007
  {
    [DebuggerNonUserCode] get => this._rad2007;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rad2007 = value;
  }

  private void frmDuplicateProductsV2_Load(object sender, EventArgs e)
  {
    this.Cursor = Cursors.AppStarting;
    this.RefreshDuplicatedProducts();
    this.Cursor = Cursors.Default;
  }

  public void RefreshDuplicatedProducts()
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
    SqlConnection sqlConnection = new SqlConnection();
    try
    {
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      string str1 = "select * from DupProducts";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtProdCode.Text), "", false) != 0)
        str1 = $"{str1} where LongDesc like '%{Strings.Trim(this.txtProdCode.Text)}%'";
      string str2 = str1 + " order by ProductCode";
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = str2;
      sqlDataAdapter.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        this.moDS.Tables[0].Clear();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      sqlDataAdapter.Fill(this.moDS);
      this.grdProducts.DataSource = (object) this.moDS.Tables[0].DefaultView;
      this.FormatProducts();
      this.ColourGrid();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in RefreshDuplicatedProducts: " + ex.Message, true);
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
          column.Width = 80 /*0x50*/;
          column.DisplayIndex = 0;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "LongDesc", false) == 0)
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
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "CurrentCostPrice", false) == 0)
        {
          column.HeaderText = "Current Cost";
          column.Width = 70;
          column.DisplayIndex = 3;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
          column.DefaultCellStyle.Format = "n2";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S1Name", false) == 0)
        {
          column.HeaderText = "Avialable Supplier";
          column.Width = 130;
          column.DisplayIndex = 4;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S1Cost", false) == 0)
        {
          column.HeaderText = "Supplier Cost";
          column.Width = 70;
          column.DisplayIndex = 5;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
          column.DefaultCellStyle.Format = "n2";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S2Name", false) == 0)
        {
          column.HeaderText = "Avialable Supplier";
          column.Width = 130;
          column.DisplayIndex = 6;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S2Cost", false) == 0)
        {
          column.HeaderText = "Supplier Cost";
          column.Width = 70;
          column.DisplayIndex = 7;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
          column.DefaultCellStyle.Format = "n2";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S3Name", false) == 0)
        {
          column.HeaderText = "Avialable Supplier";
          column.Width = 130;
          column.DisplayIndex = 8;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S3Cost", false) == 0)
        {
          column.HeaderText = "Supplier Cost";
          column.Width = 70;
          column.DisplayIndex = 9;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
          column.DefaultCellStyle.Format = "n2";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S4Name", false) == 0)
        {
          column.HeaderText = "Avialable Supplier";
          column.Width = 130;
          column.DisplayIndex = 10;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S4Cost", false) == 0)
        {
          column.HeaderText = "Supplier Cost";
          column.Width = 70;
          column.DisplayIndex = 11;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
          column.DefaultCellStyle.Format = "n2";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S5Name", false) == 0)
        {
          column.HeaderText = "Avialable Supplier";
          column.Width = 130;
          column.DisplayIndex = 12;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S5Cost", false) == 0)
        {
          column.HeaderText = "Supplier Cost";
          column.Width = 70;
          column.DisplayIndex = 13;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
          column.DefaultCellStyle.Format = "n2";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S6Name", false) == 0)
        {
          column.HeaderText = "Avialable Supplier";
          column.Width = 130;
          column.DisplayIndex = 14;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S6Cost", false) == 0)
        {
          column.HeaderText = "Supplier Cost";
          column.Width = 70;
          column.DisplayIndex = 15;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
          column.DefaultCellStyle.Format = "n2";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S7Name", false) == 0)
        {
          column.HeaderText = "Avialable Supplier";
          column.Width = 130;
          column.DisplayIndex = 16 /*0x10*/;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S7Cost", false) == 0)
        {
          column.HeaderText = "Supplier Cost";
          column.Width = 70;
          column.DisplayIndex = 17;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
          column.DefaultCellStyle.Format = "n2";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S8Name", false) == 0)
        {
          column.HeaderText = "Avialable Supplier";
          column.Width = 130;
          column.DisplayIndex = 18;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S8Cost", false) == 0)
        {
          column.HeaderText = "Supplier Cost";
          column.Width = 70;
          column.DisplayIndex = 19;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
          column.DefaultCellStyle.Format = "n2";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S9Name", false) == 0)
        {
          column.HeaderText = "Avialable Supplier";
          column.Width = 130;
          column.DisplayIndex = 20;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S9Cost", false) == 0)
        {
          column.HeaderText = "Supplier Cost";
          column.Width = 70;
          column.DisplayIndex = 21;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
          column.DefaultCellStyle.Format = "n2";
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S10Name", false) == 0)
        {
          column.HeaderText = "Avialable Supplier";
          column.Width = 130;
          column.DisplayIndex = 22;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "S10Cost", false) == 0)
        {
          column.HeaderText = "Supplier Cost";
          column.Width = 70;
          column.DisplayIndex = 23;
          column.DefaultCellStyle.BackColor = Color.Beige;
          column.DefaultCellStyle.SelectionBackColor = Color.Khaki;
          column.DefaultCellStyle.SelectionForeColor = Color.Black;
          column.DefaultCellStyle.Format = "n2";
        }
        else
          column.Visible = false;
      }
    }
  }

  private void grdProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.RowIndex < 0)
      return;
    string str;
    switch (e.ColumnIndex)
    {
      case 5:
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Update DupProducts Set S1Selected = 1, S2Selected = 0, S3Selected = 0, S4Selected = 0, S5Selected = 0, S6Selected = 0, S7Selected = 0, S8Selected = 0, S9Selected = 0, S10Selected = 0 where ImportID = ", this.grdProducts.Rows[e.RowIndex].Cells["ImportID"].Value));
        this.grdProducts.Rows[e.RowIndex].Cells["S1Selected"].Value = (object) 1;
        this.grdProducts.Rows[e.RowIndex].Cells["S2Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S3Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S4Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S5Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S6Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S7Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S8Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S9Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S10Selected"].Value = (object) 0;
        this.bSupplierSelected = true;
        break;
      case 6:
        return;
      case 7:
        return;
      case 8:
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Update DupProducts Set S1Selected = 0, S2Selected = 1, S3Selected = 0, S4Selected = 0, S5Selected = 0, S6Selected = 0, S7Selected = 0, S8Selected = 0, S9Selected = 0, S10Selected = 0 where ImportID = ", this.grdProducts.Rows[e.RowIndex].Cells["ImportID"].Value));
        this.grdProducts.Rows[e.RowIndex].Cells["S2Selected"].Value = (object) 1;
        this.grdProducts.Rows[e.RowIndex].Cells["S1Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S3Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S4Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S5Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S6Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S7Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S8Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S9Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S10Selected"].Value = (object) 0;
        this.bSupplierSelected = true;
        break;
      case 9:
        return;
      case 10:
        return;
      case 11:
        return;
      case 12:
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Update DupProducts Set S1Selected = 0, S2Selected = 0, S3Selected = 1, S4Selected = 0, S5Selected = 0, S6Selected = 0, S7Selected = 0, S8Selected = 0, S9Selected = 0, S10Selected = 0  where ImportID = ", this.grdProducts.Rows[e.RowIndex].Cells["ImportID"].Value));
        this.grdProducts.Rows[e.RowIndex].Cells["S3Selected"].Value = (object) 1;
        this.grdProducts.Rows[e.RowIndex].Cells["S2Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S1Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S4Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S5Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S6Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S7Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S8Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S9Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S10Selected"].Value = (object) 0;
        this.bSupplierSelected = true;
        break;
      case 13:
        return;
      case 14:
        return;
      case 15:
        return;
      case 16 /*0x10*/:
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Update DupProducts Set S1Selected = 0, S2Selected = 0, S3Selected = 0, S4Selected = 1, S5Selected = 0, S6Selected = 0, S7Selected = 0, S8Selected = 0, S9Selected = 0, S10Selected = 0 where ImportID = ", this.grdProducts.Rows[e.RowIndex].Cells["ImportID"].Value));
        this.grdProducts.Rows[e.RowIndex].Cells["S4Selected"].Value = (object) 1;
        this.grdProducts.Rows[e.RowIndex].Cells["S2Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S1Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S3Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S5Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S6Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S7Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S8Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S9Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S10Selected"].Value = (object) 0;
        this.bSupplierSelected = true;
        break;
      case 17:
        return;
      case 18:
        return;
      case 19:
        return;
      case 20:
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Update DupProducts Set S1Selected = 0, S2Selected = 0, S3Selected = 0, S4Selected = 0, S5Selected = 1, S6Selected = 0, S7Selected = 0, S8Selected = 0, S9Selected = 0, S10Selected = 0 where ImportID = ", this.grdProducts.Rows[e.RowIndex].Cells["ImportID"].Value));
        this.grdProducts.Rows[e.RowIndex].Cells["S4Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S2Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S1Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S3Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S5Selected"].Value = (object) 1;
        this.grdProducts.Rows[e.RowIndex].Cells["S6Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S7Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S8Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S9Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S10Selected"].Value = (object) 0;
        this.bSupplierSelected = true;
        break;
      case 21:
        return;
      case 22:
        return;
      case 23:
        return;
      case 24:
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Update DupProducts Set S1Selected = 0, S2Selected = 0, S3Selected = 0, S4Selected = 0, S5Selected = 0, S6Selected = 1, S7Selected = 0, S8Selected = 0, S9Selected = 0, S10Selected = 0 where ImportID = ", this.grdProducts.Rows[e.RowIndex].Cells["ImportID"].Value));
        this.grdProducts.Rows[e.RowIndex].Cells["S4Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S2Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S1Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S3Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S5Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S6Selected"].Value = (object) 1;
        this.grdProducts.Rows[e.RowIndex].Cells["S7Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S8Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S9Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S10Selected"].Value = (object) 0;
        this.bSupplierSelected = true;
        break;
      case 25:
        return;
      case 26:
        return;
      case 27:
        return;
      case 28:
        return;
      case 29:
        return;
      case 30:
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Update DupProducts Set S1Selected = 0, S2Selected = 0, S3Selected = 0, S4Selected = 0, S5Selected = 0, S6Selected = 0, S7Selected = 1, S8Selected = 0, S9Selected = 0, S10Selected = 0 where ImportID = ", this.grdProducts.Rows[e.RowIndex].Cells["ImportID"].Value));
        this.grdProducts.Rows[e.RowIndex].Cells["S4Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S2Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S1Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S3Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S5Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S6Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S7Selected"].Value = (object) 1;
        this.grdProducts.Rows[e.RowIndex].Cells["S8Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S9Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S10Selected"].Value = (object) 0;
        this.bSupplierSelected = true;
        break;
      case 31 /*0x1F*/:
        return;
      case 32 /*0x20*/:
        return;
      case 33:
        return;
      case 34:
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Update DupProducts Set S1Selected = 0, S2Selected = 0, S3Selected = 0, S4Selected = 0,  S5Selected = 0, S6Selected = 0, S7Selected = 0, S8Selected = 1, S9Selected = 0, S10Selected = 0 where ImportID = ", this.grdProducts.Rows[e.RowIndex].Cells["ImportID"].Value));
        this.grdProducts.Rows[e.RowIndex].Cells["S4Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S2Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S1Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S3Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S5Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S6Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S7Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S8Selected"].Value = (object) 1;
        this.grdProducts.Rows[e.RowIndex].Cells["S9Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S10Selected"].Value = (object) 0;
        this.bSupplierSelected = true;
        break;
      case 35:
        return;
      case 36:
        return;
      case 37:
        return;
      case 38:
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Update DupProducts Set S1Selected = 0, S2Selected = 0, S3Selected = 0, S4Selected = 0, S5Selected = 0, S6Selected = 0, S7Selected = 0, S8Selected = 0, S9Selected = 1, S10Selected = 0 where ImportID = ", this.grdProducts.Rows[e.RowIndex].Cells["ImportID"].Value));
        this.grdProducts.Rows[e.RowIndex].Cells["S4Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S2Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S1Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S3Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S5Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S6Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S7Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S8Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S9Selected"].Value = (object) 1;
        this.grdProducts.Rows[e.RowIndex].Cells["S10Selected"].Value = (object) 0;
        this.bSupplierSelected = true;
        break;
      case 39:
        return;
      case 40:
        return;
      case 41:
        return;
      case 42:
        str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Update DupProducts Set S1Selected = 0, S2Selected = 0, S3Selected = 0, S4Selected = 0, S5Selected = 0, S6Selected = 0, S7Selected = 0, S8Selected = 0, S9Selected = 0, S10Selected = 1 where ImportID = ", this.grdProducts.Rows[e.RowIndex].Cells["ImportID"].Value));
        this.grdProducts.Rows[e.RowIndex].Cells["S4Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S2Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S1Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S3Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S5Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S6Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S7Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S8Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S9Selected"].Value = (object) 0;
        this.grdProducts.Rows[e.RowIndex].Cells["S10Selected"].Value = (object) 10;
        this.bSupplierSelected = true;
        break;
      default:
        return;
    }
    int rowIndex = e.RowIndex;
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = str;
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
        modMain.mgBox("Error in grdProducts_CellContentClick: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
      this.ColourGrid();
      this.grdProducts.Rows[rowIndex].Selected = true;
      this.grdProducts.CurrentCell = this.grdProducts[1, rowIndex];
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in grdProducts_CellContentClick: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void ColourGrid()
  {
    System.Drawing.Font font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
    int num = checked (this.grdProducts.Rows.Count - 1);
    int index = 0;
    while (index <= num)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.grdProducts.Rows[index].Cells["S1Selected"].Value, (object) 1, false))
      {
        this.grdProducts.Rows[index].Cells[5].Style.Font = font;
        this.grdProducts.Rows[index].Cells[6].Style.Font = font;
      }
      else
      {
        this.grdProducts.Rows[index].Cells[5].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
        this.grdProducts.Rows[index].Cells[6].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.grdProducts.Rows[index].Cells["S2Selected"].Value, (object) 1, false))
      {
        this.grdProducts.Rows[index].Cells[8].Style.Font = font;
        this.grdProducts.Rows[index].Cells[9].Style.Font = font;
      }
      else
      {
        this.grdProducts.Rows[index].Cells[8].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
        this.grdProducts.Rows[index].Cells[9].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.grdProducts.Rows[index].Cells["S3Selected"].Value, (object) 1, false))
      {
        this.grdProducts.Rows[index].Cells[12].Style.Font = font;
        this.grdProducts.Rows[index].Cells[13].Style.Font = font;
      }
      else
      {
        this.grdProducts.Rows[index].Cells[12].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
        this.grdProducts.Rows[index].Cells[13].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.grdProducts.Rows[index].Cells["S4Selected"].Value, (object) 1, false))
      {
        this.grdProducts.Rows[index].Cells[16 /*0x10*/].Style.Font = font;
        this.grdProducts.Rows[index].Cells[17].Style.Font = font;
      }
      else
      {
        this.grdProducts.Rows[index].Cells[16 /*0x10*/].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
        this.grdProducts.Rows[index].Cells[17].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.grdProducts.Rows[index].Cells["S5Selected"].Value, (object) 1, false))
      {
        this.grdProducts.Rows[index].Cells[20].Style.Font = font;
        this.grdProducts.Rows[index].Cells[21].Style.Font = font;
      }
      else
      {
        this.grdProducts.Rows[index].Cells[20].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
        this.grdProducts.Rows[index].Cells[21].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.grdProducts.Rows[index].Cells["S6Selected"].Value, (object) 1, false))
      {
        this.grdProducts.Rows[index].Cells[24].Style.Font = font;
        this.grdProducts.Rows[index].Cells[25].Style.Font = font;
      }
      else
      {
        this.grdProducts.Rows[index].Cells[24].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
        this.grdProducts.Rows[index].Cells[25].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.grdProducts.Rows[index].Cells["S7Selected"].Value, (object) 1, false))
      {
        this.grdProducts.Rows[index].Cells[28].Style.Font = font;
        this.grdProducts.Rows[index].Cells[29].Style.Font = font;
      }
      else
      {
        this.grdProducts.Rows[index].Cells[28].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
        this.grdProducts.Rows[index].Cells[29].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.grdProducts.Rows[index].Cells["S8Selected"].Value, (object) 1, false))
      {
        this.grdProducts.Rows[index].Cells[32 /*0x20*/].Style.Font = font;
        this.grdProducts.Rows[index].Cells[33].Style.Font = font;
      }
      else
      {
        this.grdProducts.Rows[index].Cells[32 /*0x20*/].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
        this.grdProducts.Rows[index].Cells[33].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.grdProducts.Rows[index].Cells["S9Selected"].Value, (object) 1, false))
      {
        this.grdProducts.Rows[index].Cells[36].Style.Font = font;
        this.grdProducts.Rows[index].Cells[37].Style.Font = font;
      }
      else
      {
        this.grdProducts.Rows[index].Cells[36].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
        this.grdProducts.Rows[index].Cells[37].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.grdProducts.Rows[index].Cells["S10Selected"].Value, (object) 1, false))
      {
        this.grdProducts.Rows[index].Cells[41].Style.Font = font;
        this.grdProducts.Rows[index].Cells[41].Style.Font = font;
      }
      else
      {
        this.grdProducts.Rows[index].Cells[40].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
        this.grdProducts.Rows[index].Cells[41].Style.Font = this.grdProducts.Rows[index].Cells[1].Style.Font;
      }
      checked { ++index; }
    }
  }

  private void grdProducts_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
  {
    this.ColourGrid();
  }

  private void cmdClose_Click(object sender, EventArgs e)
  {
    if (!modMain.mgBox("Suppliers have been Selected but not Updated.  Do you want to close this form?", bYesNo: true))
      return;
    this.Close();
  }

  private void cmdUpdate_Click(object sender, EventArgs e)
  {
    if (!modMain.mgBox("Update Prefereed Suppliers?", bYesNo: true) || !this.UpdatePreferredSuppliers())
      return;
    this.bSupplierSelected = false;
    modMain.mgBox("Update Complete");
    this.Close();
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
      command.CommandText = "DuplicateProducts_SetSelected";
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

  private void Label1_Click(object sender, EventArgs e)
  {
  }

  private void txtProdCode_TextChanged(object sender, EventArgs e)
  {
    this.RefreshDuplicatedProducts();
  }

  private void cmdExport_Click(object sender, EventArgs e)
  {
    string Left = "";
    if (modMain.mgBox("Export Data to Excel Spreadsheet?", bYesNo: true))
    {
      try
      {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
        folderBrowserDialog.SelectedPath = "c:\\";
        folderBrowserDialog.Description = "Select the Export directory";
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
          Left = folderBrowserDialog.SelectedPath;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) == 0)
          return;
        this.Cursor = Cursors.WaitCursor;
        string str = $"{Left}\\DuplicateProducts_{DateAndTime.Today.Day.ToString()}{DateAndTime.Today.Month.ToString()}{DateAndTime.Today.Year.ToString()}" + ".xlsx";
        Workbook workbook = new ApplicationClass().Workbooks.Add((object) Missing.Value);
        Worksheet activeSheet = (Worksheet) workbook.ActiveSheet;
        int ColumnIndex1 = 1;
        int num1 = checked (this.grdProducts.ColumnCount - 1);
        int index = 0;
        while (index <= num1)
        {
          if (this.grdProducts.Columns[index].Visible)
          {
            activeSheet.Cells[(object) 1, (object) ColumnIndex1] = (object) this.grdProducts.Columns[index].HeaderText;
            checked { ++ColumnIndex1; }
          }
          checked { ++index; }
        }
        int rowCount = this.grdProducts.RowCount;
        int num2 = 1;
        while (num2 <= rowCount)
        {
          int ColumnIndex2 = 1;
          int num3 = checked (this.grdProducts.ColumnCount - 1);
          int num4 = 0;
          while (num4 <= num3)
          {
            if (this.grdProducts.Columns[num4].Visible)
            {
              activeSheet.Cells[(object) checked (num2 + 1), (object) ColumnIndex2] = (object) this.grdProducts[num4, checked (num2 - 1)].Value.ToString();
              NewLateBinding.LateSetComplex(activeSheet.Cells[(object) checked (num2 + 1), (object) ColumnIndex2], (System.Type) null, "numberformat", new object[1]
              {
                (object) "#0.00"
              }, (string[]) null, (System.Type[]) null, false, true);
              checked { ++ColumnIndex2; }
            }
            checked { ++num4; }
          }
          checked { ++num2; }
        }
        activeSheet.Columns.AutoFit();
        bool flag = false;
        try
        {
          File.OpenWrite(str).Close();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          flag = false;
          ProjectData.ClearProjectError();
        }
        if (File.Exists(str))
          File.Delete(str);
        workbook.SaveAs((object) str, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, ConflictResolution: (object) Missing.Value, AddToMru: (object) Missing.Value, TextCodepage: (object) Missing.Value, TextVisualLayout: (object) Missing.Value, Local: (object) Missing.Value);
        workbook.Close((object) Missing.Value, (object) Missing.Value, (object) Missing.Value);
        this.Cursor = Cursors.Default;
        modMain.mgBox($"Export To {str} Completed OK");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.Cursor = Cursors.Default;
        modMain.mgBox("Error in Export To Excel: " + exception.Message, true);
        ProjectData.ClearProjectError();
      }
    }
  }
}
