// Decompiled with JetBrains decompiler
// Type: PriceChanger.frmNewProductSubGroup
// Assembly: PriceChanger, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A2A849E8-FEFE-4A2B-AE8B-0FA642F38116
// Assembly location: C:\Users\zeljk\Desktop\VPN\Pricechanger\PriceChanger.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
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
public class frmNewProductSubGroup : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("cmdDelete")]
  private Button _cmdDelete;
  [AccessedThroughProperty("cmdSave")]
  private Button _cmdSave;
  [AccessedThroughProperty("txtSubGroupDesc")]
  private TextBox _txtSubGroupDesc;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtSubGroupCode")]
  private TextBox _txtSubGroupCode;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  public string sProdGroupID;
  public string sProdGroup;

  [DebuggerNonUserCode]
  static frmNewProductSubGroup()
  {
  }

  [DebuggerNonUserCode]
  public frmNewProductSubGroup()
  {
    this.Load += new EventHandler(this.frmNewProductSubGroup_Load);
    frmNewProductSubGroup.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmNewProductSubGroup.__ENCList)
    {
      if (frmNewProductSubGroup.__ENCList.Count == frmNewProductSubGroup.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmNewProductSubGroup.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmNewProductSubGroup.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmNewProductSubGroup.__ENCList[index1] = frmNewProductSubGroup.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmNewProductSubGroup.__ENCList.RemoveRange(index1, checked (frmNewProductSubGroup.__ENCList.Count - index1));
        frmNewProductSubGroup.__ENCList.Capacity = frmNewProductSubGroup.__ENCList.Count;
      }
      frmNewProductSubGroup.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmNewProductSubGroup));
    this.txtSubGroupDesc = new TextBox();
    this.Label1 = new Label();
    this.txtSubGroupCode = new TextBox();
    this.Label22 = new Label();
    this.cmdDelete = new Button();
    this.cmdSave = new Button();
    this.SuspendLayout();
    this.txtSubGroupDesc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtSubGroupDesc.BackColor = Color.Khaki;
    this.txtSubGroupDesc.BorderStyle = BorderStyle.FixedSingle;
    this.txtSubGroupDesc.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtSubGroupDesc1 = this.txtSubGroupDesc;
    Point point1 = new Point(182, 47);
    Point point2 = point1;
    txtSubGroupDesc1.Location = point2;
    this.txtSubGroupDesc.MaxLength = 100;
    this.txtSubGroupDesc.Name = "txtSubGroupDesc";
    TextBox txtSubGroupDesc2 = this.txtSubGroupDesc;
    Size size1 = new Size(359, 24);
    Size size2 = size1;
    txtSubGroupDesc2.Size = size2;
    this.txtSubGroupDesc.TabIndex = 38;
    this.Label1.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(12, 44);
    Point point3 = point1;
    label1_1.Location = point3;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(156, 24);
    Size size3 = size1;
    label1_2.Size = size3;
    this.Label1.TabIndex = 42;
    this.Label1.Text = "Sub Group Description";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.txtSubGroupCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtSubGroupCode.BackColor = Color.Khaki;
    this.txtSubGroupCode.BorderStyle = BorderStyle.FixedSingle;
    this.txtSubGroupCode.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtSubGroupCode1 = this.txtSubGroupCode;
    point1 = new Point(182, 12);
    Point point4 = point1;
    txtSubGroupCode1.Location = point4;
    this.txtSubGroupCode.MaxLength = 8;
    this.txtSubGroupCode.Name = "txtSubGroupCode";
    TextBox txtSubGroupCode2 = this.txtSubGroupCode;
    size1 = new Size(89, 24);
    Size size4 = size1;
    txtSubGroupCode2.Size = size4;
    this.txtSubGroupCode.TabIndex = 37;
    this.Label22.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label22_1 = this.Label22;
    point1 = new Point(51, 9);
    Point point5 = point1;
    label22_1.Location = point5;
    this.Label22.Name = "Label22";
    Label label22_2 = this.Label22;
    size1 = new Size(117, 24);
    Size size5 = size1;
    label22_2.Size = size5;
    this.Label22.TabIndex = 41;
    this.Label22.Text = "Sub Group Code";
    this.Label22.TextAlign = ContentAlignment.MiddleRight;
    this.cmdDelete.AutoEllipsis = true;
    this.cmdDelete.BackColor = Color.Khaki;
    this.cmdDelete.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdDelete.Image = (Image) PriceChanger.My.Resources.Resources.close16;
    this.cmdDelete.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdDelete1 = this.cmdDelete;
    point1 = new Point(466, 78);
    Point point6 = point1;
    cmdDelete1.Location = point6;
    this.cmdDelete.Name = "cmdDelete";
    Button cmdDelete2 = this.cmdDelete;
    size1 = new Size(77, 24);
    Size size6 = size1;
    cmdDelete2.Size = size6;
    this.cmdDelete.TabIndex = 40;
    this.cmdDelete.Text = "   Cancel";
    this.cmdDelete.UseVisualStyleBackColor = false;
    this.cmdSave.AutoEllipsis = true;
    this.cmdSave.BackColor = Color.Khaki;
    this.cmdSave.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdSave.Image = (Image) PriceChanger.My.Resources.Resources.accept16;
    this.cmdSave.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdSave1 = this.cmdSave;
    point1 = new Point(391, 78);
    Point point7 = point1;
    cmdSave1.Location = point7;
    this.cmdSave.Name = "cmdSave";
    Button cmdSave2 = this.cmdSave;
    size1 = new Size(69, 24);
    Size size7 = size1;
    cmdSave2.Size = size7;
    this.cmdSave.TabIndex = 39;
    this.cmdSave.Text = "    Save";
    this.cmdSave.UseVisualStyleBackColor = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Beige;
    size1 = new Size(553, 113);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.cmdDelete);
    this.Controls.Add((Control) this.cmdSave);
    this.Controls.Add((Control) this.txtSubGroupDesc);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtSubGroupCode);
    this.Controls.Add((Control) this.Label22);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmNewProductSubGroup);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "New Product Sub Group";
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual Button cmdSave
  {
    [DebuggerNonUserCode] get => this._cmdSave;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdSave_Click);
      if (this._cmdSave != null)
        this._cmdSave.Click -= eventHandler;
      this._cmdSave = value;
      if (this._cmdSave == null)
        return;
      this._cmdSave.Click += eventHandler;
    }
  }

  internal virtual TextBox txtSubGroupDesc
  {
    [DebuggerNonUserCode] get => this._txtSubGroupDesc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtSubGroupDesc_TextChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtSubGroupDesc_Leave);
      if (this._txtSubGroupDesc != null)
      {
        this._txtSubGroupDesc.TextChanged -= eventHandler1;
        this._txtSubGroupDesc.Leave -= eventHandler2;
      }
      this._txtSubGroupDesc = value;
      if (this._txtSubGroupDesc == null)
        return;
      this._txtSubGroupDesc.TextChanged += eventHandler1;
      this._txtSubGroupDesc.Leave += eventHandler2;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual TextBox txtSubGroupCode
  {
    [DebuggerNonUserCode] get => this._txtSubGroupCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtSubGroupCode_TextChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtSubGroupCode_Leave);
      if (this._txtSubGroupCode != null)
      {
        this._txtSubGroupCode.TextChanged -= eventHandler1;
        this._txtSubGroupCode.Leave -= eventHandler2;
      }
      this._txtSubGroupCode = value;
      if (this._txtSubGroupCode == null)
        return;
      this._txtSubGroupCode.TextChanged += eventHandler1;
      this._txtSubGroupCode.Leave += eventHandler2;
    }
  }

  internal virtual Label Label22
  {
    [DebuggerNonUserCode] get => this._Label22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label22 = value;
  }

  private void cmdDelete_Click(object sender, EventArgs e) => this.Close();

  private void frmNewProductSubGroup_Load(object sender, EventArgs e)
  {
  }

  private void txtSubGroupCode_Leave(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtSubGroupCode.Text), "", false) == 0 || !this.GroupSubCodeExists())
      return;
    modMain.mgBox($"Product Group Sub Code {this.txtSubGroupCode.Text} Already Exists");
    this.txtSubGroupCode.Text = "";
    this.txtSubGroupCode.Focus();
  }

  private void txtSubGroupCode_TextChanged(object sender, EventArgs e)
  {
  }

  public bool GroupSubDescExists()
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsISMConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str = $"Select top 1 * from ProductSubGroups where Description = '{Strings.Replace(this.txtSubGroupDesc.Text, "'", "''")}' and ProductGroupCode = '{this.sProdGroupID}'";
    command.CommandText = str;
    bool hasRows = false;
    try
    {
      hasRows = command.ExecuteReader().HasRows;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in GroupSubCodeExists: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    return hasRows;
  }

  public bool GroupSubCodeExists()
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsISMConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str = $"Select top 1 * from ProductSubGroups where ProductSubGroupCode = '{this.txtSubGroupCode.Text}' and ProductGroupCode = '{this.sProdGroupID}'";
    command.CommandText = str;
    bool hasRows = false;
    try
    {
      hasRows = command.ExecuteReader().HasRows;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in GroupSubCodeExists: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    return hasRows;
  }

  private void txtSubGroupDesc_Leave(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtSubGroupDesc.Text), "", false) == 0 || !this.GroupSubDescExists())
      return;
    modMain.mgBox($"Product Sub Group Description {this.txtSubGroupDesc.Text} Already Exists for Product Group {this.sProdGroup}");
    this.txtSubGroupDesc.Text = "";
    this.txtSubGroupDesc.Focus();
  }

  private void txtSubGroupDesc_TextChanged(object sender, EventArgs e)
  {
  }

  private void cmdSave_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtSubGroupCode.Text), "", false) == 0)
    {
      modMain.mgBox("Enter Product Sub Group Code");
      this.txtSubGroupCode.Focus();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtSubGroupDesc.Text), "", false) == 0)
    {
      modMain.mgBox("Enter Product Sub Group Description");
      this.txtSubGroupDesc.Focus();
    }
    else
    {
      this.SaveProductSubGroup();
      this.Close();
    }
  }

  public void SaveProductSubGroup()
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
      command.CommandText = "ProductSubGroup_Insert";
      command.Parameters.Add(new SqlParameter("@GroupCode", SqlDbType.VarChar, 8)).Value = (object) this.sProdGroupID;
      command.Parameters.Add(new SqlParameter("@SubGroupCode", SqlDbType.VarChar, 8)).Value = (object) this.txtSubGroupCode.Text;
      command.Parameters.Add(new SqlParameter("@GroupDesc", SqlDbType.VarChar, 100)).Value = (object) this.txtSubGroupDesc.Text;
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in SaveProductSubGroup: " + ex.Message, true);
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
      modMain.mgBox("Error in SaveProductSubGroup: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
  }
}
