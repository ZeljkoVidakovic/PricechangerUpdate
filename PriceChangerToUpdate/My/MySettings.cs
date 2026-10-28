// Decompiled with JetBrains decompiler
// Type: PriceChanger.My.MySettings
// Assembly: PriceChanger, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A2A849E8-FEFE-4A2B-AE8B-0FA642F38116
// Assembly location: C:\Users\zeljk\Desktop\VPN\Pricechanger\PriceChanger.exe

using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace PriceChanger.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
  private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());
  private static bool addedHandler;
  private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

  [DebuggerNonUserCode]
  public MySettings()
  {
  }

  [DebuggerNonUserCode]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  private static void AutoSaveSettings(object sender, EventArgs e)
  {
    if (!MyProject.Application.SaveMySettingsOnExit)
      return;
    MySettingsProperty.Settings.Save();
  }

  public static MySettings Default
  {
    get
    {
      if (!MySettings.addedHandler)
      {
        object handlerLockObject = MySettings.addedHandlerLockObject;
        ObjectFlowControl.CheckForSyncLockOnValueType(handlerLockObject);
        Monitor.Enter(handlerLockObject);
        try
        {
          if (!MySettings.addedHandler)
          {
            MyProject.Application.Shutdown += (ShutdownEventHandler) ([DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Advanced)] (sender, e) =>
            {
              if (!MyProject.Application.SaveMySettingsOnExit)
                return;
              MySettingsProperty.Settings.Save();
            });
            MySettings.addedHandler = true;
          }
        }
        finally
        {
          Monitor.Exit(handlerLockObject);
        }
      }
      MySettings defaultInstance = MySettings.defaultInstance;
      return defaultInstance;
    }
  }

  [DefaultSettingValue("InnFront")]
  [DebuggerNonUserCode]
  [ApplicationScopedSetting]
  public string ISMDatabase => Conversions.ToString(this[nameof (ISMDatabase)]);

  [DebuggerNonUserCode]
  [DefaultSettingValue("PriceChanger")]
  [ApplicationScopedSetting]
  public string AppDatabase => Conversions.ToString(this[nameof (AppDatabase)]);

  [DefaultSettingValue("sa")]
  [DebuggerNonUserCode]
  [ApplicationScopedSetting]
  public string SQLUser => Conversions.ToString(this[nameof (SQLUser)]);

  [DebuggerNonUserCode]
  [ApplicationScopedSetting]
  [DefaultSettingValue("sa")]
  public string ISMSQLUser => Conversions.ToString(this[nameof (ISMSQLUser)]);

  [ApplicationScopedSetting]
  [DefaultSettingValue("Innov8-Dev-SQL")]
  [DebuggerNonUserCode]
  public string Server => Conversions.ToString(this[nameof (Server)]);

  [ApplicationScopedSetting]
  [DefaultSettingValue("sa")]
  [DebuggerNonUserCode]
  public string SQLPwd => Conversions.ToString(this[nameof (SQLPwd)]);

  [DebuggerNonUserCode]
  [DefaultSettingValue("Innov8-Dev-SQL")]
  [ApplicationScopedSetting]
  public string ISMServer => Conversions.ToString(this[nameof (ISMServer)]);

  [DefaultSettingValue("sa")]
  [DebuggerNonUserCode]
  [ApplicationScopedSetting]
  public string ISMSQLPwd => Conversions.ToString(this[nameof (ISMSQLPwd)]);

  [ApplicationScopedSetting]
  [DebuggerNonUserCode]
  [DefaultSettingValue("Innov8-exch")]
  public string eMailRelay => Conversions.ToString(this[nameof (eMailRelay)]);

  [DefaultSettingValue("5")]
  [ApplicationScopedSetting]
  [DebuggerNonUserCode]
  public int MailsBeforeCooldown => Conversions.ToInteger(this[nameof (MailsBeforeCooldown)]);

  [DefaultSettingValue("30")]
  [DebuggerNonUserCode]
  [ApplicationScopedSetting]
  public int CooldownSeconds => Conversions.ToInteger(this[nameof (CooldownSeconds)]);

  [DebuggerNonUserCode]
  [DefaultSettingValue("innov8.co.uk\\iihf_price_changer")]
  [ApplicationScopedSetting]
  public string eMailUser => Conversions.ToString(this[nameof (eMailUser)]);

  [DebuggerNonUserCode]
  [DefaultSettingValue("85Nipping23")]
  [ApplicationScopedSetting]
  public string eMailPwd => Conversions.ToString(this[nameof (eMailPwd)]);
}
