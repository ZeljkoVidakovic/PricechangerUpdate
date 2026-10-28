// Decompiled with JetBrains decompiler
// Type: PriceChanger.My.MyProject
// Assembly: PriceChanger, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A2A849E8-FEFE-4A2B-AE8B-0FA642F38116
// Assembly location: C:\Users\zeljk\Desktop\VPN\Pricechanger\PriceChanger.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace PriceChanger.My;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyProject
{
  private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
  private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
  private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

  [DebuggerNonUserCode]
  static MyProject()
  {
  }

  [HelpKeyword("My.Computer")]
  internal static MyComputer Computer
  {
    [DebuggerHidden] get => MyProject.m_ComputerObjectProvider.GetInstance;
  }

  [HelpKeyword("My.Application")]
  internal static MyApplication Application
  {
    [DebuggerHidden] get => MyProject.m_AppObjectProvider.GetInstance;
  }

  [HelpKeyword("My.User")]
  internal static User User
  {
    [DebuggerHidden] get => MyProject.m_UserObjectProvider.GetInstance;
  }

  [HelpKeyword("My.Forms")]
  internal static MyProject.MyForms Forms
  {
    [DebuggerHidden] get => MyProject.m_MyFormsObjectProvider.GetInstance;
  }

  [HelpKeyword("My.WebServices")]
  internal static MyProject.MyWebServices WebServices
  {
    [DebuggerHidden] get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
  internal sealed class MyForms
  {
    public frmDuplicateProducts m_frmDuplicateProducts;
    public frmDuplicateProductsV2 m_frmDuplicateProductsV2;
    public frmMain m_frmMain;
    public frmNewIndex m_frmNewIndex;
    public frmNewProductGroup m_frmNewProductGroup;
    public frmNewProductSubGroup m_frmNewProductSubGroup;
    public frmResolveIndex m_frmResolveIndex;
    public frmResolveProdugtGroups m_frmResolveProdugtGroups;
    public frmResolveSubGroups m_frmResolveSubGroups;
    public frmResolveSupplier m_frmResolveSupplier;
    public frmSelectPriceList m_frmSelectPriceList;
    public frmSelectSupplier m_frmSelectSupplier;
    public mBox m_mBox;
    [ThreadStatic]
    private static Hashtable m_FormBeingCreated;

    public frmDuplicateProducts frmDuplicateProducts
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDuplicateProducts = MyProject.MyForms.Create__Instance__<frmDuplicateProducts>(this.m_frmDuplicateProducts);
        return this.m_frmDuplicateProducts;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDuplicateProducts)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDuplicateProducts>(ref this.m_frmDuplicateProducts);
      }
    }

    public frmDuplicateProductsV2 frmDuplicateProductsV2
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDuplicateProductsV2 = MyProject.MyForms.Create__Instance__<frmDuplicateProductsV2>(this.m_frmDuplicateProductsV2);
        return this.m_frmDuplicateProductsV2;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDuplicateProductsV2)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDuplicateProductsV2>(ref this.m_frmDuplicateProductsV2);
      }
    }

    public frmMain frmMain
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMain = MyProject.MyForms.Create__Instance__<frmMain>(this.m_frmMain);
        return this.m_frmMain;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMain)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMain>(ref this.m_frmMain);
      }
    }

    public frmNewIndex frmNewIndex
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmNewIndex = MyProject.MyForms.Create__Instance__<frmNewIndex>(this.m_frmNewIndex);
        return this.m_frmNewIndex;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmNewIndex)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmNewIndex>(ref this.m_frmNewIndex);
      }
    }

    public frmNewProductGroup frmNewProductGroup
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmNewProductGroup = MyProject.MyForms.Create__Instance__<frmNewProductGroup>(this.m_frmNewProductGroup);
        return this.m_frmNewProductGroup;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmNewProductGroup)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmNewProductGroup>(ref this.m_frmNewProductGroup);
      }
    }

    public frmNewProductSubGroup frmNewProductSubGroup
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmNewProductSubGroup = MyProject.MyForms.Create__Instance__<frmNewProductSubGroup>(this.m_frmNewProductSubGroup);
        return this.m_frmNewProductSubGroup;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmNewProductSubGroup)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmNewProductSubGroup>(ref this.m_frmNewProductSubGroup);
      }
    }

    public frmResolveIndex frmResolveIndex
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmResolveIndex = MyProject.MyForms.Create__Instance__<frmResolveIndex>(this.m_frmResolveIndex);
        return this.m_frmResolveIndex;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmResolveIndex)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmResolveIndex>(ref this.m_frmResolveIndex);
      }
    }

    public frmResolveProdugtGroups frmResolveProdugtGroups
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmResolveProdugtGroups = MyProject.MyForms.Create__Instance__<frmResolveProdugtGroups>(this.m_frmResolveProdugtGroups);
        return this.m_frmResolveProdugtGroups;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmResolveProdugtGroups)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmResolveProdugtGroups>(ref this.m_frmResolveProdugtGroups);
      }
    }

    public frmResolveSubGroups frmResolveSubGroups
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmResolveSubGroups = MyProject.MyForms.Create__Instance__<frmResolveSubGroups>(this.m_frmResolveSubGroups);
        return this.m_frmResolveSubGroups;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmResolveSubGroups)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmResolveSubGroups>(ref this.m_frmResolveSubGroups);
      }
    }

    public frmResolveSupplier frmResolveSupplier
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmResolveSupplier = MyProject.MyForms.Create__Instance__<frmResolveSupplier>(this.m_frmResolveSupplier);
        return this.m_frmResolveSupplier;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmResolveSupplier)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmResolveSupplier>(ref this.m_frmResolveSupplier);
      }
    }

    public frmSelectPriceList frmSelectPriceList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmSelectPriceList = MyProject.MyForms.Create__Instance__<frmSelectPriceList>(this.m_frmSelectPriceList);
        return this.m_frmSelectPriceList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmSelectPriceList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmSelectPriceList>(ref this.m_frmSelectPriceList);
      }
    }

    public frmSelectSupplier frmSelectSupplier
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmSelectSupplier = MyProject.MyForms.Create__Instance__<frmSelectSupplier>(this.m_frmSelectSupplier);
        return this.m_frmSelectSupplier;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmSelectSupplier)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmSelectSupplier>(ref this.m_frmSelectSupplier);
      }
    }

    public mBox mBox
    {
      [DebuggerNonUserCode] get
      {
        this.m_mBox = MyProject.MyForms.Create__Instance__<mBox>(this.m_mBox);
        return this.m_mBox;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_mBox)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<mBox>(ref this.m_mBox);
      }
    }

    [DebuggerHidden]
    private static T Create__Instance__<T>(T Instance) where T : Form, new()
    {
      if ((object) Instance != null && !Instance.IsDisposed)
        return Instance;
      if (MyProject.MyForms.m_FormBeingCreated != null)
      {
        if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
      }
      else
        MyProject.MyForms.m_FormBeingCreated = new Hashtable();
      MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
      try
      {
        return new T();
      }
      catch (TargetInvocationException ex) when (ex.InnerException != null)
      {
        throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
      }
      finally
      {
        MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
      }
    }

    [DebuggerHidden]
    private void Dispose__Instance__<T>(ref T instance) where T : Form
    {
      instance.Dispose();
      instance = default (T);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public MyForms()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => base.GetHashCode();

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal new System.Type GetType() => typeof (MyProject.MyForms);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() => base.ToString();
  }

  [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal sealed class MyWebServices
  {
    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => base.GetHashCode();

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal new System.Type GetType() => typeof (MyProject.MyWebServices);

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public override string ToString() => base.ToString();

    [DebuggerHidden]
    private static T Create__Instance__<T>(T instance) where T : new()
    {
      return (object) instance == null ? new T() : instance;
    }

    [DebuggerHidden]
    private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public MyWebServices()
    {
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [ComVisible(false)]
  internal sealed class ThreadSafeObjectProvider<T> where T : new()
  {
    [ThreadStatic]
    private static T m_ThreadStaticValue;

    internal T GetInstance
    {
      [DebuggerHidden] get
      {
        if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
          MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
        return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public ThreadSafeObjectProvider()
    {
    }
  }
}
