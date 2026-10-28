// Decompiled with JetBrains decompiler
// Type: PriceChanger.SpeechBalloon
// Assembly: PriceChanger, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A2A849E8-FEFE-4A2B-AE8B-0FA642F38116
// Assembly location: C:\Users\zeljk\Desktop\VPN\Pricechanger\PriceChanger.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;

#nullable disable
namespace PriceChanger;

public class SpeechBalloon
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private Color MyBorderColor;
  private float MyBorderWidth;
  private bool MyBorderVisible;
  private Rectangle MyBounds;
  private int MyBubbleSize;
  private float MyBubbleSmoothness;
  private int MyBubbleWidth;
  private Color MyFillColor;
  private Font MyFont;
  private GraphicsPath MyPath;
  private int MyRectangleCornerRadius;
  private BalloonShape MyShape;
  private int MyTailBaseWidth;
  private int MyTailLength;
  private float MyTailRotation;
  private bool MyTailVisible;
  private string MyText;
  private Color MyTextColor;

  [DebuggerNonUserCode]
  static SpeechBalloon()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (SpeechBalloon.__ENCList)
    {
      if (SpeechBalloon.__ENCList.Count == SpeechBalloon.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (SpeechBalloon.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (SpeechBalloon.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              SpeechBalloon.__ENCList[index1] = SpeechBalloon.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        SpeechBalloon.__ENCList.RemoveRange(index1, checked (SpeechBalloon.__ENCList.Count - index1));
        SpeechBalloon.__ENCList.Capacity = SpeechBalloon.__ENCList.Count;
      }
      SpeechBalloon.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public event EventHandler RedrawRequired;

  public Color BorderColor
  {
    get => this.MyBorderColor;
    set
    {
      bool flag = value != this.MyBorderColor;
      this.MyBorderColor = value;
      if (!flag)
        return;
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public float BorderWidth
  {
    get => this.MyBorderWidth;
    set
    {
      bool flag = (double) this.MyBorderWidth != (double) value;
      this.MyBorderWidth = value;
      if (!flag)
        return;
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public bool BorderVisible
  {
    get => this.MyBorderVisible;
    set
    {
      bool flag = this.MyBorderVisible != value;
      this.MyBorderVisible = value;
      if (!flag)
        return;
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public Rectangle Bounds
  {
    get => this.MyBounds;
    set
    {
      bool flag = value != this.MyBounds;
      this.MyBounds = value;
      if (!flag)
        return;
      this.RecreatePath();
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public int BubbleSize
  {
    get => this.MyBubbleSize;
    set
    {
      bool flag = this.MyBubbleSize != value;
      this.MyBubbleSize = value;
      if (!flag)
        return;
      this.RecreatePath();
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public float BubbleSmoothness
  {
    get => this.MyBubbleSmoothness;
    set
    {
      bool flag = (double) this.MyBubbleSmoothness != (double) value;
      this.MyBubbleSmoothness = value;
      if (!flag)
        return;
      this.RecreatePath();
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public int BubbleWidth
  {
    get => this.MyBubbleWidth;
    set
    {
      bool flag = this.MyBubbleWidth != value;
      this.MyBubbleWidth = value;
      if (!flag)
        return;
      this.RecreatePath();
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public Color FillColor
  {
    get => this.MyFillColor;
    set
    {
      bool flag = value != this.MyFillColor;
      this.MyFillColor = value;
      if (!flag)
        return;
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public Font Font
  {
    get => this.MyFont;
    set
    {
      bool flag = value != this.MyFont;
      this.MyFont = value;
      if (!flag)
        return;
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public int Height
  {
    get => this.MyBounds.Height;
    set
    {
      bool flag = value != this.MyBounds.Height;
      this.MyBounds.Height = value;
      if (!flag)
        return;
      this.RecreatePath();
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public int Left
  {
    get => this.MyBounds.X;
    set
    {
      bool flag = this.MyBounds.X != value;
      this.MyBounds.X = value;
      if (!flag)
        return;
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public GraphicsPath Path => this.MyPath;

  public int RectangleCornerRadius
  {
    get => this.MyRectangleCornerRadius;
    set
    {
      bool flag = value != this.MyRectangleCornerRadius;
      this.MyRectangleCornerRadius = value;
      if (!flag)
        return;
      this.RecreatePath();
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public BalloonShape Shape
  {
    get => this.MyShape;
    set
    {
      bool flag = this.MyShape != value;
      this.MyShape = value;
      if (!flag)
        return;
      this.RecreatePath();
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public int TailBaseWidth
  {
    get => this.MyTailBaseWidth;
    set
    {
      bool flag = this.MyTailBaseWidth != value;
      this.MyTailBaseWidth = value;
      if (!flag)
        return;
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public int TailLength
  {
    get => this.MyTailLength;
    set
    {
      bool flag = this.MyTailLength != value;
      this.MyTailLength = value;
      if (!flag)
        return;
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public float TailRotation
  {
    get => this.MyTailRotation;
    set
    {
      bool flag = (double) this.MyTailRotation != (double) value;
      this.MyTailRotation = value;
      if (!flag)
        return;
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public bool TailVisible
  {
    get => this.MyTailVisible;
    set
    {
      bool flag = this.MyTailVisible != value;
      this.MyTailVisible = value;
      if (!flag)
        return;
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public string Text
  {
    get => this.MyText;
    set
    {
      bool flag = Operators.CompareString(this.MyText, value, false) != 0;
      this.MyText = value;
      if (!flag)
        return;
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public Color TextColor
  {
    get => this.MyTextColor;
    set
    {
      bool flag = value != this.MyTextColor;
      this.MyTextColor = value;
      if (!flag)
        return;
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public int Top
  {
    get => this.MyBounds.Top;
    set
    {
      bool flag = this.MyBounds.Y != value;
      this.MyBounds.Y = value;
      if (!flag)
        return;
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public int Width
  {
    get => this.MyBounds.Width;
    set
    {
      bool flag = value != this.MyBounds.Width;
      this.MyBounds.Width = value;
      if (!flag)
        return;
      this.RecreatePath();
      EventHandler redrawRequiredEvent = this.RedrawRequired;
      if (redrawRequiredEvent == null)
        return;
      redrawRequiredEvent((object) this, EventArgs.Empty);
    }
  }

  public SpeechBalloon()
  {
    SpeechBalloon.__ENCAddToList((object) this);
    this.MyBorderColor = Color.Black;
    this.MyBorderWidth = 2f;
    this.MyBorderVisible = true;
    this.MyBounds = new Rectangle(0, 0, 200, 100);
    this.MyBubbleSize = 0;
    this.MyBubbleSmoothness = 0.0f;
    this.MyBubbleWidth = 20;
    this.MyFillColor = Color.White;
    this.MyFont = new Font("Comic Sans MS", 9f);
    this.MyPath = new GraphicsPath();
    this.MyRectangleCornerRadius = 0;
    this.MyShape = BalloonShape.Ellipse;
    this.MyTailBaseWidth = 25;
    this.MyTailLength = 75;
    this.MyTailRotation = 115f;
    this.MyTailVisible = true;
    this.MyText = "TEXT GOES HERE!!!";
    this.MyTextColor = Color.Red;
    this.RecreatePath();
  }

  private void RecreatePath()
  {
    this.Path.Reset();
    switch (this.Shape)
    {
      case BalloonShape.Ellipse:
        if (this.BubbleSize == 0)
        {
          this.Path.AddEllipse(0, 0, this.Width, this.Height);
          break;
        }
        int num1 = checked (360 - this.BubbleWidth);
        int bubbleWidth = this.BubbleWidth;
        int num2 = num1;
        int num3 = 0;
        while ((bubbleWidth >> 31 /*0x1F*/ ^ num3) <= (bubbleWidth >> 31 /*0x1F*/ ^ num2))
        {
          Point[] points = new Point[3];
          float num4 = (float) ((double) num3 * Math.PI / 180.0);
          float num5 = (float) ((double) checked (num3 + unchecked (this.BubbleWidth / 2)) * Math.PI / 180.0);
          float num6 = (float) ((double) checked (num3 + this.BubbleWidth) * Math.PI / 180.0);
          float a1 = (float) (this.Width / 2) + (float) (this.Width / 2) * (float) Math.Cos((double) num4);
          float a2 = (float) (this.Height / 2) + (float) (this.Height / 2) * (float) Math.Sin((double) num4);
          int num7 = 0;
          int num8 = 0;
          if (Math.Cos((double) num5) < 0.0 && Math.Sin((double) num5) < 0.0)
          {
            num7 = checked (-this.BubbleSize);
            num8 = checked (-this.BubbleSize);
          }
          else if (Math.Cos((double) num5) > 0.0 && Math.Sin((double) num5) > 0.0)
          {
            num7 = this.BubbleSize;
            num8 = this.BubbleSize;
          }
          else if (Math.Cos((double) num5) < 0.0 && Math.Sin((double) num5) > 0.0)
          {
            num7 = checked (-this.BubbleSize);
            num8 = this.BubbleSize;
          }
          else if (Math.Cos((double) num5) > 0.0 && Math.Sin((double) num5) < 0.0)
          {
            num7 = this.BubbleSize;
            num8 = checked (-this.BubbleSize);
          }
          float a3 = (float) (this.Width / 2) + (float) (this.Width / 2) * (float) Math.Cos((double) num5) + (float) num7;
          float a4 = (float) (this.Height / 2) + (float) (this.Height / 2) * (float) Math.Sin((double) num5) + (float) num8;
          float a5 = (float) (this.Width / 2) + (float) (this.Width / 2) * (float) Math.Cos((double) num6);
          float a6 = (float) (this.Height / 2) + (float) (this.Height / 2) * (float) Math.Sin((double) num6);
          points[0] = new Point(checked ((int) Math.Round((double) a1)), checked ((int) Math.Round((double) a2)));
          points[1] = new Point(checked ((int) Math.Round((double) a3)), checked ((int) Math.Round((double) a4)));
          points[2] = new Point(checked ((int) Math.Round((double) a5)), checked ((int) Math.Round((double) a6)));
          this.Path.AddCurve(points, this.BubbleSmoothness);
          checked { num3 += bubbleWidth; }
        }
        break;
      case BalloonShape.Rectangle:
        if (this.RectangleCornerRadius == 0)
        {
          this.Path.AddRectangle(new Rectangle(0, 0, this.Width, this.Height));
        }
        else
        {
          this.Path.AddLine(checked (0 + this.RectangleCornerRadius), 0, checked (0 + this.Width - this.RectangleCornerRadius * 2), 0);
          this.Path.AddArc(checked (0 + this.Width - this.RectangleCornerRadius * 2), 0, checked (this.RectangleCornerRadius * 2), checked (this.RectangleCornerRadius * 2), 270f, 90f);
          this.Path.AddLine(checked (0 + this.Width), checked (0 + this.RectangleCornerRadius), checked (0 + this.Width), checked (0 + this.Height - this.RectangleCornerRadius * 2));
          this.Path.AddArc(checked (0 + this.Width - this.RectangleCornerRadius * 2), checked (0 + this.Height - this.RectangleCornerRadius * 2), checked (this.RectangleCornerRadius * 2), checked (this.RectangleCornerRadius * 2), 0.0f, 90f);
          this.Path.AddLine(checked (0 + this.Width - this.RectangleCornerRadius * 2), checked (0 + this.Height), checked (0 + this.RectangleCornerRadius), checked (0 + this.Height));
          this.Path.AddArc(0, checked (0 + this.Height - this.RectangleCornerRadius * 2), checked (this.RectangleCornerRadius * 2), checked (this.RectangleCornerRadius * 2), 90f, 90f);
          this.Path.AddLine(0, checked (0 + this.Height - this.RectangleCornerRadius * 2), 0, checked (0 + this.RectangleCornerRadius));
          this.Path.AddArc(0, 0, checked (this.RectangleCornerRadius * 2), checked (this.RectangleCornerRadius * 2), 180f, 90f);
        }
        break;
    }
    this.Path.CloseAllFigures();
  }

  public void Draw(Graphics g)
  {
    GraphicsPath path = new GraphicsPath();
    SolidBrush solidBrush1 = new SolidBrush(this.FillColor);
    SolidBrush solidBrush2 = new SolidBrush(this.TextColor);
    Pen pen1 = new Pen(this.BorderColor, this.BorderWidth);
    StringFormat format = new StringFormat();
    g.TextRenderingHint = TextRenderingHint.AntiAlias;
    g.SmoothingMode = SmoothingMode.HighQuality;
    path.AddLine(checked (-this.TailBaseWidth), 0, this.TailBaseWidth, 0);
    path.AddLine(this.TailBaseWidth, 0, 0, checked (-this.TailLength + unchecked (this.Height / 2)));
    path.CloseFigure();
    if (this.TailVisible && this.BorderVisible)
    {
      Pen pen2 = new Pen(this.BorderColor, this.BorderWidth * 2f);
      GraphicsState gstate = g.Save();
      g.TranslateTransform((float) this.Left + (float) this.Width / 2f, (float) this.Top + (float) this.Height / 2f);
      g.RotateTransform(this.TailRotation);
      g.DrawPath(pen2, path);
      g.Restore(gstate);
    }
    GraphicsState gstate1 = g.Save();
    g.TranslateTransform((float) this.Left, (float) this.Top);
    g.FillPath((Brush) solidBrush1, this.Path);
    if (this.BorderVisible)
      g.DrawPath(pen1, this.Path);
    g.Restore(gstate1);
    if (this.TailVisible)
    {
      GraphicsState gstate2 = g.Save();
      g.TranslateTransform((float) this.Left + (float) this.Width / 2f, (float) this.Top + (float) this.Height / 2f);
      g.RotateTransform(this.TailRotation);
      g.FillPath((Brush) solidBrush1, path);
      g.Restore(gstate2);
    }
    format.LineAlignment = StringAlignment.Center;
    format.Alignment = StringAlignment.Center;
    g.DrawString(this.Text, this.Font, (Brush) solidBrush2, (RectangleF) this.Bounds, format);
    solidBrush1.Dispose();
    solidBrush2.Dispose();
    pen1.Dispose();
  }
}
