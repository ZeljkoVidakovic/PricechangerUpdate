// Decompiled with JetBrains decompiler
// Type: PriceChanger.mBox
// Assembly: PriceChanger, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A2A849E8-FEFE-4A2B-AE8B-0FA642F38116
// Assembly location: C:\Users\zeljk\Desktop\VPN\Pricechanger\PriceChanger.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace PriceChanger;

[DesignerGenerated]
public class mBox : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("lblOK")]
  private Button _lblOK;
  [AccessedThroughProperty("lblNo")]
  private Button _lblNo;
  [AccessedThroughProperty("lblYes")]
  private Button _lblYes;
  public int iResult;
  public string sMessage;
  public bool bYesNo;
  public bool bError;
  private SpeechBalloon balloon;

  [DebuggerNonUserCode]
  static mBox()
  {
  }

  public mBox()
  {
    this.Paint += new PaintEventHandler(this.mBox_Paint);
    this.Load += new EventHandler(this.mBox_Load);
    mBox.__ENCAddToList((object) this);
    this.sMessage = "";
    this.balloon = new SpeechBalloon();
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (mBox.__ENCList)
    {
      if (mBox.__ENCList.Count == mBox.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (mBox.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (mBox.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              mBox.__ENCList[index1] = mBox.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        mBox.__ENCList.RemoveRange(index1, checked (mBox.__ENCList.Count - index1));
        mBox.__ENCList.Capacity = mBox.__ENCList.Count;
      }
      mBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.lblOK = new Button();
    this.lblNo = new Button();
    this.lblYes = new Button();
    this.SuspendLayout();
    this.lblOK.BackColor = Color.SandyBrown;
    this.lblOK.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button lblOk1 = this.lblOK;
    Point point1 = new Point(335, 169);
    Point point2 = point1;
    lblOk1.Location = point2;
    this.lblOK.Name = "lblOK";
    Button lblOk2 = this.lblOK;
    Size size1 = new Size(46, 27);
    Size size2 = size1;
    lblOk2.Size = size2;
    this.lblOK.TabIndex = 5;
    this.lblOK.Text = "OK";
    this.lblOK.UseVisualStyleBackColor = false;
    this.lblNo.BackColor = Color.SandyBrown;
    this.lblNo.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button lblNo1 = this.lblNo;
    point1 = new Point(266, 169);
    Point point3 = point1;
    lblNo1.Location = point3;
    this.lblNo.Name = "lblNo";
    Button lblNo2 = this.lblNo;
    size1 = new Size(46, 27);
    Size size3 = size1;
    lblNo2.Size = size3;
    this.lblNo.TabIndex = 6;
    this.lblNo.Text = "No";
    this.lblNo.UseVisualStyleBackColor = false;
    this.lblYes.BackColor = Color.SandyBrown;
    this.lblYes.Font = new Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button lblYes1 = this.lblYes;
    point1 = new Point(335, 169);
    Point point4 = point1;
    lblYes1.Location = point4;
    this.lblYes.Name = "lblYes";
    Button lblYes2 = this.lblYes;
    size1 = new Size(46, 27);
    Size size4 = size1;
    lblYes2.Size = size4;
    this.lblYes.TabIndex = 7;
    this.lblYes.Text = "Yes";
    this.lblYes.UseVisualStyleBackColor = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Maroon;
    size1 = new Size(716, 208 /*0xD0*/);
    this.ClientSize = size1;
    this.ControlBox = false;
    this.Controls.Add((Control) this.lblYes);
    this.Controls.Add((Control) this.lblNo);
    this.Controls.Add((Control) this.lblOK);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (mBox);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = nameof (mBox);
    this.TransparencyKey = Color.Maroon;
    this.ResumeLayout(false);
  }

  internal virtual Button lblOK
  {
    [DebuggerNonUserCode] get => this._lblOK;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lblOK_Click);
      if (this._lblOK != null)
        this._lblOK.Click -= eventHandler;
      this._lblOK = value;
      if (this._lblOK == null)
        return;
      this._lblOK.Click += eventHandler;
    }
  }

  internal virtual Button lblNo
  {
    [DebuggerNonUserCode] get => this._lblNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lblNo_Click);
      if (this._lblNo != null)
        this._lblNo.Click -= eventHandler;
      this._lblNo = value;
      if (this._lblNo == null)
        return;
      this._lblNo.Click += eventHandler;
    }
  }

  internal virtual Button lblYes
  {
    [DebuggerNonUserCode] get => this._lblYes;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lblYes_Click);
      if (this._lblYes != null)
        this._lblYes.Click -= eventHandler;
      this._lblYes = value;
      if (this._lblYes == null)
        return;
      this._lblYes.Click += eventHandler;
    }
  }

  private void Button1_Click(object sender, EventArgs e) => this.Close();

  private void mBox_Load(object sender, EventArgs e)
  {
    this.sMessage = "    " + this.sMessage;
    this.balloon.Text = this.sMessage;
    this.balloon.Font = new Font("Calibri", 10f, FontStyle.Bold);
    if (this.bError)
    {
      modMain.LogError(this.sMessage);
      this.balloon.TextColor = Color.DarkRed;
      this.balloon.BubbleSize = 0;
      this.balloon.BubbleWidth = 27;
      this.balloon.BubbleSmoothness = 0.0f;
      this.balloon.BorderColor = Color.DarkRed;
      this.lblOK.BackColor = Color.DarkRed;
      this.lblOK.ForeColor = Color.White;
      this.balloon.Width = 450;
      this.balloon.Height = 150;
    }
    else
    {
      this.balloon.BubbleSize = 0;
      this.balloon.Height = 100;
      this.balloon.BubbleWidth = 27;
      this.balloon.BubbleSmoothness = 0.0f;
      this.balloon.TextColor = Color.FromArgb(-4696298);
      this.balloon.BorderColor = Color.FromArgb(-16777216 /*0xFF000000*/);
      this.balloon.Width = 280;
    }
    this.balloon.Left = 100;
    this.balloon.Top = 50;
    this.balloon.FillColor = Color.FromArgb(-1);
    this.balloon.BorderWidth = 2f;
    this.balloon.TailVisible = false;
    this.iResult = 0;
    if (this.bYesNo)
    {
      this.lblYes.Visible = true;
      this.lblNo.Visible = true;
      this.lblOK.Visible = false;
    }
    else
    {
      this.lblYes.Visible = false;
      this.lblNo.Visible = false;
      this.lblOK.Visible = true;
    }
  }

  private void mBox_Paint(object sender, PaintEventArgs e) => this.balloon.Draw(e.Graphics);

  private void lblOK_Click(object sender, EventArgs e) => this.Close();

  private void lblYes_Click(object sender, EventArgs e)
  {
    this.iResult = 1;
    this.Close();
  }

  private void lblNo_Click(object sender, EventArgs e)
  {
    this.iResult = 0;
    this.Close();
  }
}
