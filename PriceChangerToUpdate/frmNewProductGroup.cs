// Decompiled with JetBrains decompiler
// Type: PriceChanger.frmNewProductGroup
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
public class frmNewProductGroup : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtGroupCode")]
  private TextBox _txtGroupCode;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  [AccessedThroughProperty("txtGroupDesc")]
  private TextBox _txtGroupDesc;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmdDelete")]
  private Button _cmdDelete;
  [AccessedThroughProperty("cmdSave")]
  private Button _cmdSave;

  [DebuggerNonUserCode]
  static frmNewProductGroup()
  {
  }

  [DebuggerNonUserCode]
  public frmNewProductGroup()
  {
    this.Load += new EventHandler(this.frmNewProductGroup_Load);
    frmNewProductGroup.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmNewProductGroup.__ENCList)
    {
      if (frmNewProductGroup.__ENCList.Count == frmNewProductGroup.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmNewProductGroup.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmNewProductGroup.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmNewProductGroup.__ENCList[index1] = frmNewProductGroup.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmNewProductGroup.__ENCList.RemoveRange(index1, checked (frmNewProductGroup.__ENCList.Count - index1));
        frmNewProductGroup.__ENCList.Capacity = frmNewProductGroup.__ENCList.Count;
      }
      frmNewProductGroup.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmNewProductGroup));
    this.txtGroupCode = new TextBox();
    this.Label22 = new Label();
    this.txtGroupDesc = new TextBox();
    this.Label1 = new Label();
    this.cmdDelete = new Button();
    this.cmdSave = new Button();
    this.SuspendLayout();
    this.txtGroupCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtGroupCode.BackColor = Color.Khaki;
    this.txtGroupCode.BorderStyle = BorderStyle.FixedSingle;
    this.txtGroupCode.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtGroupCode1 = this.txtGroupCode;
    Point point1 = new Point(138, 12);
    Point point2 = point1;
    txtGroupCode1.Location = point2;
    this.txtGroupCode.MaxLength = 8;
    this.txtGroupCode.Name = "txtGroupCode";
    TextBox txtGroupCode2 = this.txtGroupCode;
    Size size1 = new Size(69, 24);
    Size size2 = size1;
    txtGroupCode2.Size = size2;
    this.txtGroupCode.TabIndex = 0;
    this.Label22.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label22_1 = this.Label22;
    point1 = new Point(47, 9);
    Point point3 = point1;
    label22_1.Location = point3;
    this.Label22.Name = "Label22";
    Label label22_2 = this.Label22;
    size1 = new Size(85, 24);
    Size size3 = size1;
    label22_2.Size = size3;
    this.Label22.TabIndex = 34;
    this.Label22.Text = "Group Code";
    this.Label22.TextAlign = ContentAlignment.MiddleRight;
    this.txtGroupDesc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtGroupDesc.BackColor = Color.Khaki;
    this.txtGroupDesc.BorderStyle = BorderStyle.FixedSingle;
    this.txtGroupDesc.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtGroupDesc1 = this.txtGroupDesc;
    point1 = new Point(138, 47);
    Point point4 = point1;
    txtGroupDesc1.Location = point4;
    this.txtGroupDesc.MaxLength = 100;
    this.txtGroupDesc.Name = "txtGroupDesc";
    TextBox txtGroupDesc2 = this.txtGroupDesc;
    size1 = new Size(386, 24);
    Size size4 = size1;
    txtGroupDesc2.Size = size4;
    this.txtGroupDesc.TabIndex = 1;
    this.Label1.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(12, 44);
    Point point5 = point1;
    label1_1.Location = point5;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(120, 24);
    Size size5 = size1;
    label1_2.Size = size5;
    this.Label1.TabIndex = 36;
    this.Label1.Text = "Group Description";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.cmdDelete.AutoEllipsis = true;
    this.cmdDelete.BackColor = Color.Khaki;
    this.cmdDelete.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdDelete.Image = (Image) PriceChanger.My.Resources.Resources.close16;
    this.cmdDelete.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdDelete1 = this.cmdDelete;
    point1 = new Point(447, 78);
    Point point6 = point1;
    cmdDelete1.Location = point6;
    this.cmdDelete.Name = "cmdDelete";
    Button cmdDelete2 = this.cmdDelete;
    size1 = new Size(77, 24);
    Size size6 = size1;
    cmdDelete2.Size = size6;
    this.cmdDelete.TabIndex = 3;
    this.cmdDelete.Text = "   Cancel";
    this.cmdDelete.UseVisualStyleBackColor = false;
    this.cmdSave.AutoEllipsis = true;
    this.cmdSave.BackColor = Color.Khaki;
    this.cmdSave.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdSave.Image = (Image) PriceChanger.My.Resources.Resources.accept16;
    this.cmdSave.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdSave1 = this.cmdSave;
    point1 = new Point(372, 78);
    Point point7 = point1;
    cmdSave1.Location = point7;
    this.cmdSave.Name = "cmdSave";
    Button cmdSave2 = this.cmdSave;
    size1 = new Size(69, 24);
    Size size7 = size1;
    cmdSave2.Size = size7;
    this.cmdSave.TabIndex = 2;
    this.cmdSave.Text = "    Save";
    this.cmdSave.UseVisualStyleBackColor = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Beige;
    size1 = new Size(528, 108);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.cmdDelete);
    this.Controls.Add((Control) this.cmdSave);
    this.Controls.Add((Control) this.txtGroupDesc);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtGroupCode);
    this.Controls.Add((Control) this.Label22);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmNewProductGroup);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "New Product Group";
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox txtGroupCode
  {
    [DebuggerNonUserCode] get => this._txtGroupCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtGroupCode_TextChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtGroupCode_Leave);
      if (this._txtGroupCode != null)
      {
        this._txtGroupCode.TextChanged -= eventHandler1;
        this._txtGroupCode.Leave -= eventHandler2;
      }
      this._txtGroupCode = value;
      if (this._txtGroupCode == null)
        return;
      this._txtGroupCode.TextChanged += eventHandler1;
      this._txtGroupCode.Leave += eventHandler2;
    }
  }

  internal virtual Label Label22
  {
    [DebuggerNonUserCode] get => this._Label22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label22 = value;
  }

  internal virtual TextBox txtGroupDesc
  {
    [DebuggerNonUserCode] get => this._txtGroupDesc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtGroupDesc_Leave);
      EventHandler eventHandler2 = new EventHandler(this.txtGroupDesc_TextChanged);
      if (this._txtGroupDesc != null)
      {
        this._txtGroupDesc.Leave -= eventHandler1;
        this._txtGroupDesc.TextChanged -= eventHandler2;
      }
      this._txtGroupDesc = value;
      if (this._txtGroupDesc == null)
        return;
      this._txtGroupDesc.Leave += eventHandler1;
      this._txtGroupDesc.TextChanged += eventHandler2;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

  private void cmdDelete_Click(object sender, EventArgs e) => this.Close();

  private void txtGroupCode_Leave(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtGroupCode.Text), "", false) == 0 || !this.GroupCodeExists())
      return;
    modMain.mgBox($"Product Group Code {this.txtGroupCode.Text} Already Exists");
    this.txtGroupCode.Text = "";
    this.txtGroupCode.Focus();
  }

  public bool GroupCodeExists()
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsISMConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str = $"Select top 1 * from ProductGroups where ProductGroupCode = '{this.txtGroupCode.Text}'";
    command.CommandText = str;
    bool hasRows = false;
    try
    {
      hasRows = command.ExecuteReader().HasRows;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in GroupCodeExists: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    return hasRows;
  }

  public bool GroupDescExists()
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsISMConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str = $"Select top 1 * from ProductGroups where Description = '{Strings.Replace(this.txtGroupDesc.Text, "'", "''")}'";
    command.CommandText = str;
    bool hasRows = false;
    try
    {
      hasRows = command.ExecuteReader().HasRows;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in GroupDescExists: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    return hasRows;
  }

  private void frmNewProductGroup_Load(object sender, EventArgs e)
  {
  }

  private void txtGroupCode_TextChanged(object sender, EventArgs e)
  {
  }

  private void txtGroupDesc_Leave(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtGroupDesc.Text), "", false) == 0 || !this.GroupDescExists())
      return;
    modMain.mgBox($"Product Group Description {this.txtGroupDesc.Text} Already Exists");
    this.txtGroupDesc.Text = "";
    this.txtGroupDesc.Focus();
  }

  private void cmdSave_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtGroupCode.Text), "", false) == 0)
    {
      modMain.mgBox("Enter Product Group Code");
      this.txtGroupCode.Focus();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtGroupDesc.Text), "", false) == 0)
    {
      modMain.mgBox("Enter Product Group Description");
      this.txtGroupCode.Focus();
    }
    else
    {
      this.SaveProductGroup();
      this.Close();
    }
  }

  public void SaveProductGroup()
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
      command.CommandText = "ProductGroup_Insert";
      command.Parameters.Add(new SqlParameter("@GroupCode", SqlDbType.VarChar, 8)).Value = (object) this.txtGroupCode.Text;
      command.Parameters.Add(new SqlParameter("@GroupDesc", SqlDbType.VarChar, 100)).Value = (object) this.txtGroupDesc.Text;
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in SaveProductGroup: " + ex.Message, true);
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
      modMain.mgBox("Error in SaveProductGroup: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  private void txtGroupDesc_TextChanged(object sender, EventArgs e)
  {
  }
}
