// Decompiled with JetBrains decompiler
// Type: PriceChanger.frmNewIndex
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
public class frmNewIndex : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("cmdDelete")]
  private Button _cmdDelete;
  [AccessedThroughProperty("cmdSave")]
  private Button _cmdSave;
  [AccessedThroughProperty("txtIndex")]
  private TextBox _txtIndex;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  [AccessedThroughProperty("lblAnalysisCode")]
  private Label _lblAnalysisCode;

  [DebuggerNonUserCode]
  static frmNewIndex()
  {
  }

  [DebuggerNonUserCode]
  public frmNewIndex()
  {
    this.Load += new EventHandler(this.frmNewIndex_Load);
    frmNewIndex.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmNewIndex.__ENCList)
    {
      if (frmNewIndex.__ENCList.Count == frmNewIndex.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmNewIndex.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmNewIndex.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmNewIndex.__ENCList[index1] = frmNewIndex.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmNewIndex.__ENCList.RemoveRange(index1, checked (frmNewIndex.__ENCList.Count - index1));
        frmNewIndex.__ENCList.Capacity = frmNewIndex.__ENCList.Count;
      }
      frmNewIndex.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmNewIndex));
    this.txtIndex = new TextBox();
    this.Label1 = new Label();
    this.Label22 = new Label();
    this.cmdDelete = new Button();
    this.cmdSave = new Button();
    this.lblAnalysisCode = new Label();
    this.SuspendLayout();
    this.txtIndex.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtIndex.BackColor = Color.Khaki;
    this.txtIndex.BorderStyle = BorderStyle.FixedSingle;
    this.txtIndex.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtIndex1 = this.txtIndex;
    Point point1 = new Point(125, 55);
    Point point2 = point1;
    txtIndex1.Location = point2;
    this.txtIndex.MaxLength = 100;
    this.txtIndex.Name = "txtIndex";
    TextBox txtIndex2 = this.txtIndex;
    Size size1 = new Size(425, 24);
    Size size2 = size1;
    txtIndex2.Size = size2;
    this.txtIndex.TabIndex = 37;
    this.Label1.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(15, 55);
    Point point3 = point1;
    label1_1.Location = point3;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(104, 24);
    Size size3 = size1;
    label1_2.Size = size3;
    this.Label1.TabIndex = 41;
    this.Label1.Text = "Description";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label22.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label22_1 = this.Label22;
    point1 = new Point(12, 18);
    Point point4 = point1;
    label22_1.Location = point4;
    this.Label22.Name = "Label22";
    Label label22_2 = this.Label22;
    size1 = new Size(107, 24);
    Size size4 = size1;
    label22_2.Size = size4;
    this.Label22.TabIndex = 40;
    this.Label22.Text = "Analysis Code";
    this.Label22.TextAlign = ContentAlignment.MiddleRight;
    this.cmdDelete.AutoEllipsis = true;
    this.cmdDelete.BackColor = Color.Khaki;
    this.cmdDelete.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdDelete.Image = (Image) PriceChanger.My.Resources.Resources.close16;
    this.cmdDelete.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdDelete1 = this.cmdDelete;
    point1 = new Point(477, 85);
    Point point5 = point1;
    cmdDelete1.Location = point5;
    this.cmdDelete.Name = "cmdDelete";
    Button cmdDelete2 = this.cmdDelete;
    size1 = new Size(77, 24);
    Size size5 = size1;
    cmdDelete2.Size = size5;
    this.cmdDelete.TabIndex = 39;
    this.cmdDelete.Text = "   Cancel";
    this.cmdDelete.UseVisualStyleBackColor = false;
    this.cmdSave.AutoEllipsis = true;
    this.cmdSave.BackColor = Color.Khaki;
    this.cmdSave.Font = new Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdSave.Image = (Image) PriceChanger.My.Resources.Resources.accept16;
    this.cmdSave.ImageAlign = ContentAlignment.MiddleLeft;
    Button cmdSave1 = this.cmdSave;
    point1 = new Point(402, 85);
    Point point6 = point1;
    cmdSave1.Location = point6;
    this.cmdSave.Name = "cmdSave";
    Button cmdSave2 = this.cmdSave;
    size1 = new Size(69, 24);
    Size size6 = size1;
    cmdSave2.Size = size6;
    this.cmdSave.TabIndex = 38;
    this.cmdSave.Text = "    Save";
    this.cmdSave.UseVisualStyleBackColor = false;
    this.lblAnalysisCode.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label lblAnalysisCode1 = this.lblAnalysisCode;
    point1 = new Point(125, 18);
    Point point7 = point1;
    lblAnalysisCode1.Location = point7;
    this.lblAnalysisCode.Name = "lblAnalysisCode";
    Label lblAnalysisCode2 = this.lblAnalysisCode;
    size1 = new Size(107, 24);
    Size size7 = size1;
    lblAnalysisCode2.Size = size7;
    this.lblAnalysisCode.TabIndex = 42;
    this.lblAnalysisCode.Text = "Analysis Code";
    this.lblAnalysisCode.TextAlign = ContentAlignment.MiddleLeft;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Beige;
    size1 = new Size(562, 119);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.lblAnalysisCode);
    this.Controls.Add((Control) this.cmdDelete);
    this.Controls.Add((Control) this.cmdSave);
    this.Controls.Add((Control) this.txtIndex);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.Label22);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmNewIndex);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "New Index";
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

  internal virtual TextBox txtIndex
  {
    [DebuggerNonUserCode] get => this._txtIndex;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtIndex = value;
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Label Label22
  {
    [DebuggerNonUserCode] get => this._Label22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label22 = value;
  }

  internal virtual Label lblAnalysisCode
  {
    [DebuggerNonUserCode] get => this._lblAnalysisCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAnalysisCode = value;
    }
  }

  private void cmdDelete_Click(object sender, EventArgs e) => this.Close();

  private void frmNewIndex_Load(object sender, EventArgs e)
  {
    this.lblAnalysisCode.Text = this.GenerateNewAnalysisCode();
  }

  public string GenerateNewAnalysisCode()
  {
    SqlConnection sqlConnection = new SqlConnection();
    string newAnalysisCode = "";
    sqlConnection.ConnectionString = modMain.gsISMConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str = "Select top 1 AnalysisCode from AnalysisTree where AnalysisCode like 'PA%' and ParentAnalysisID = 2 order by AnalysisCode desc ";
    command.CommandText = str;
    try
    {
      SqlDataReader sqlDataReader = command.ExecuteReader();
      if (sqlDataReader.HasRows)
      {
        while (sqlDataReader.Read())
        {
          newAnalysisCode = Strings.Mid(Conversions.ToString(sqlDataReader["AnalysisCode"]), 3, 4);
          object oInput1 = (object) newAnalysisCode;
          int num = modMain.lNullTest(ref oInput1);
          newAnalysisCode = Conversions.ToString(oInput1);
          object oInput2 = (object) checked ((long) num + 1L);
          object obj = modMain.sNullTest(ref oInput2);
          Conversions.ToLong(oInput2);
          newAnalysisCode = Conversions.ToString(obj);
          newAnalysisCode = "PA" + newAnalysisCode;
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in GroupDescExists: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    return newAnalysisCode;
  }

  private void cmdSave_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtIndex.Text), "", false) == 0)
    {
      modMain.mgBox("Enter Index Description");
      this.txtIndex.Focus();
    }
    else
    {
      this.SaveIndex();
      this.Close();
    }
  }

  public void SaveIndex()
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
      command.CommandText = "Index_Insert";
      command.Parameters.Add(new SqlParameter("@AnalysisCode", SqlDbType.VarChar, 8)).Value = (object) this.lblAnalysisCode.Text;
      command.Parameters.Add(new SqlParameter("@IndexDesc", SqlDbType.VarChar, 100)).Value = (object) this.txtIndex.Text;
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in SaveIndex: " + ex.Message, true);
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
      modMain.mgBox("Error in SaveIndex: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
  }
}
