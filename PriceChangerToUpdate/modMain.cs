// Decompiled with JetBrains decompiler
// Type: PriceChanger.modMain
// Assembly: PriceChanger, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A2A849E8-FEFE-4A2B-AE8B-0FA642F38116
// Assembly location: C:\Users\zeljk\Desktop\VPN\Pricechanger\PriceChanger.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PriceChanger.My;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

#nullable disable
namespace PriceChanger;

[StandardModule]
internal sealed class modMain
{
  private static string sServer;
  private static string sISMDatabase;
  private static string sAppDatabase;
  private static string sSqlPwd;
  private static string sSqlUser;
  private static string sISMServer;
  private static string sISMSqlUser;
  private static string sISMSQLPwd;
  public static string gsAppConnection;
  public static string gsISMConnection;
  public static string sSearchedSupplierCode;
  public static int iSearchedPriceList;
  public static OpenFileDialog fdlg;
  public static string sRelay;
  public static int iEmailBeforeCooldown;
  public static int iCooldown;
  public static string sEmailUser;
  public static string sEmailPwd;

  public static void GetConfigDom()
  {
    modMain.sServer = MySettingsProperty.Settings.Server;
    modMain.sISMDatabase = MySettingsProperty.Settings.ISMDatabase;
    modMain.sAppDatabase = MySettingsProperty.Settings.AppDatabase;
    modMain.sSqlPwd = MySettingsProperty.Settings.SQLPwd;
    modMain.sSqlUser = MySettingsProperty.Settings.SQLUser;
    modMain.sISMServer = MySettingsProperty.Settings.ISMServer;
    modMain.sISMSqlUser = MySettingsProperty.Settings.ISMSQLUser;
    modMain.sISMSQLPwd = MySettingsProperty.Settings.ISMSQLPwd;
    modMain.sRelay = MySettingsProperty.Settings.eMailRelay;
    modMain.iEmailBeforeCooldown = MySettingsProperty.Settings.MailsBeforeCooldown;
    modMain.iCooldown = MySettingsProperty.Settings.CooldownSeconds;
    modMain.sEmailUser = MySettingsProperty.Settings.eMailUser;
    modMain.sEmailPwd = MySettingsProperty.Settings.eMailPwd;
    modMain.gsAppConnection = $"server={modMain.sServer};database={modMain.sAppDatabase};uid={modMain.sSqlUser};pwd={modMain.sSqlPwd};";
    modMain.gsISMConnection = $"server={modMain.sISMServer};database={modMain.sISMDatabase};uid={modMain.sISMSqlUser};pwd={modMain.sISMSQLPwd};";
  }

  public static bool mgBox(string sMessage, bool bErr = false, bool bYesNo = false)
  {
    mBox mBox = new mBox();
    mBox.sMessage = sMessage;
    mBox.bError = bErr;
    mBox.bYesNo = bYesNo;
    int num = (int) mBox.ShowDialog();
    return mBox.iResult != 0;
  }

  public static object sNullTest(ref object oInput)
  {
    object obj;
    try
    {
      if (oInput == DBNull.Value)
      {
        obj = (object) "";
      }
      else
      {
        string Left = oInput.ToString();
        obj = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "System.Object", false) != 0 ? (object) Left.Trim() : (object) "") : (object) "";
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Console.WriteLine(ex.ToString());
      obj = (object) "";
      ProjectData.ClearProjectError();
    }
    return obj;
  }

  public static int iNullTest(ref object oInput)
  {
    int num;
    try
    {
      if (oInput == DBNull.Value)
      {
        num = 0;
      }
      else
      {
        string Left = oInput.ToString();
        num = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "System.Object", false) != 0 ? Convert.ToInt32(Convert.ToDecimal(Left)) : 0) : 0;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Console.WriteLine(ex.ToString());
      num = 0;
      ProjectData.ClearProjectError();
    }
    return num;
  }

  public static int lNullTest(ref object oInput)
  {
    int num;
    try
    {
      if (oInput == DBNull.Value)
      {
        num = 0;
      }
      else
      {
        string Left = oInput.ToString();
        num = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "System.Object", false) != 0 ? checked ((int) Convert.ToInt64(Convert.ToDecimal(Left))) : 0) : 0;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Console.WriteLine(ex.ToString());
      num = 0;
      ProjectData.ClearProjectError();
    }
    return num;
  }

  public static double dNullTest(ref object oInput)
  {
    double num;
    try
    {
      if (oInput == DBNull.Value)
      {
        num = 0.0;
      }
      else
      {
        string Left = oInput.ToString();
        num = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "System.Object", false) != 0 ? Convert.ToDouble(Convert.ToDecimal(Convert.ToDecimal(Left))) : 0.0) : 0.0;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Console.WriteLine(ex.ToString());
      num = 0.0;
      ProjectData.ClearProjectError();
    }
    return num;
  }

  public static bool IsValidSupplier(string sSuppCode)
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsISMConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str = $"Select top 1 SupplierCode from Suppliers where SupplierCode = '{sSuppCode}'";
    command.CommandText = str;
    bool flag;
    try
    {
      flag = command.ExecuteReader().HasRows;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in IsValidSupplier: " + ex.Message, true);
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public static bool IsValidPriceList(int iList)
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsISMConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str = "Select top 1 ProductListID from ProductLists where ProductListID = " + Conversions.ToString(iList);
    command.CommandText = str;
    bool flag;
    try
    {
      flag = command.ExecuteReader().HasRows;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in IsValidPriceList: " + ex.Message, true);
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public static void LogError(string sMessage)
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    sMessage = Strings.Replace(sMessage, "'", "");
    string str = $"Insert into ErrorLog(ErrorMessage) values ('{sMessage}')";
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = str;
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ("Error Logging Error :) " + ex.Message));
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
      ProjectData.ClearProjectError();
    }
  }

  public static string AppPath() => Environment.CurrentDirectory;
}
