// Decompiled with JetBrains decompiler
// Type: PriceChanger.frmMain
// Assembly: PriceChanger, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A2A849E8-FEFE-4A2B-AE8B-0FA642F38116
// Assembly location: C:\Users\zeljk\Desktop\VPN\Pricechanger\PriceChanger.exe

using Excel;
using Graphing.V3;
using Graphing.V3.Base;
using Graphing.V3.Pie;
using Guifreaks.NavigationBar;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Outlook;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace PriceChanger;

[DesignerGenerated]
public class frmMain : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("tcMain")]
  private TabControl _tcMain;
  [AccessedThroughProperty("tpImport")]
  private TabPage _tpImport;
  [AccessedThroughProperty("tpTemplates")]
  private TabPage _tpTemplates;
  [AccessedThroughProperty("tpSettings")]
  private TabPage _tpSettings;
  [AccessedThroughProperty("tpManage")]
  private TabPage _tpManage;
  [AccessedThroughProperty("Label2")]
  private System.Windows.Forms.Label _Label2;
  [AccessedThroughProperty("txtSP")]
  private System.Windows.Forms.TextBox _txtSP;
  [AccessedThroughProperty("Label13")]
  private System.Windows.Forms.Label _Label13;
  [AccessedThroughProperty("Label12")]
  private System.Windows.Forms.Label _Label12;
  [AccessedThroughProperty("Label11")]
  private System.Windows.Forms.Label _Label11;
  [AccessedThroughProperty("Label10")]
  private System.Windows.Forms.Label _Label10;
  [AccessedThroughProperty("chkProductMapping")]
  private System.Windows.Forms.CheckBox _chkProductMapping;
  [AccessedThroughProperty("Label9")]
  private System.Windows.Forms.Label _Label9;
  [AccessedThroughProperty("chkSterling")]
  private System.Windows.Forms.CheckBox _chkSterling;
  [AccessedThroughProperty("chkEuro")]
  private System.Windows.Forms.CheckBox _chkEuro;
  [AccessedThroughProperty("chkGross")]
  private System.Windows.Forms.CheckBox _chkGross;
  [AccessedThroughProperty("chkNet")]
  private System.Windows.Forms.CheckBox _chkNet;
  [AccessedThroughProperty("Label8")]
  private System.Windows.Forms.Label _Label8;
  [AccessedThroughProperty("Label7")]
  private System.Windows.Forms.Label _Label7;
  [AccessedThroughProperty("Label5")]
  private System.Windows.Forms.Label _Label5;
  [AccessedThroughProperty("Label6")]
  private System.Windows.Forms.Label _Label6;
  [AccessedThroughProperty("txtTemplateName")]
  private System.Windows.Forms.TextBox _txtTemplateName;
  [AccessedThroughProperty("cboCalcPrice1")]
  private ComboBox _cboCalcPrice1;
  [AccessedThroughProperty("cboCalcPrice2")]
  private ComboBox _cboCalcPrice2;
  [AccessedThroughProperty("cboCalcPrice3")]
  private ComboBox _cboCalcPrice3;
  [AccessedThroughProperty("cboSuppProduct")]
  private ComboBox _cboSuppProduct;
  [AccessedThroughProperty("cboIIHFProductCode")]
  private ComboBox _cboIIHFProductCode;
  [AccessedThroughProperty("cmdSaveTemplate")]
  private System.Windows.Forms.Button _cmdSaveTemplate;
  [AccessedThroughProperty("Label19")]
  private System.Windows.Forms.Label _Label19;
  [AccessedThroughProperty("Label18")]
  private System.Windows.Forms.Label _Label18;
  [AccessedThroughProperty("Label17")]
  private System.Windows.Forms.Label _Label17;
  [AccessedThroughProperty("Label16")]
  private System.Windows.Forms.Label _Label16;
  [AccessedThroughProperty("Label14")]
  private System.Windows.Forms.Label _Label14;
  [AccessedThroughProperty("txtPriceList")]
  private System.Windows.Forms.TextBox _txtPriceList;
  [AccessedThroughProperty("txtSupplierCode")]
  private System.Windows.Forms.TextBox _txtSupplierCode;
  [AccessedThroughProperty("cmdDelete")]
  private System.Windows.Forms.Button _cmdDelete;
  [AccessedThroughProperty("cmdSearchSupplier")]
  private System.Windows.Forms.Button _cmdSearchSupplier;
  [AccessedThroughProperty("cmdSearchPriceList")]
  private System.Windows.Forms.Button _cmdSearchPriceList;
  [AccessedThroughProperty("ToolTip1")]
  private ToolTip _ToolTip1;
  [AccessedThroughProperty("Label1")]
  private System.Windows.Forms.Label _Label1;
  [AccessedThroughProperty("ListBox1")]
  private System.Windows.Forms.ListBox _ListBox1;
  [AccessedThroughProperty("nbSettings")]
  private NaviBand _nbSettings;
  [AccessedThroughProperty("nbTemplates")]
  private NaviBand _nbTemplates;
  [AccessedThroughProperty("lbTemplates")]
  private System.Windows.Forms.ListBox _lbTemplates;
  [AccessedThroughProperty("lblNewTemplate")]
  private System.Windows.Forms.Label _lblNewTemplate;
  [AccessedThroughProperty("nbImport")]
  private NaviBand _nbImport;
  [AccessedThroughProperty("lstImported")]
  private System.Windows.Forms.ListBox _lstImported;
  [AccessedThroughProperty("lstWaiting")]
  private System.Windows.Forms.ListBox _lstWaiting;
  [AccessedThroughProperty("lblImported")]
  private System.Windows.Forms.Label _lblImported;
  [AccessedThroughProperty("lblWaiting")]
  private System.Windows.Forms.Label _lblWaiting;
  [AccessedThroughProperty("naviBar1")]
  private NaviBar _naviBar1;
  [AccessedThroughProperty("cmdBrowse")]
  private System.Windows.Forms.Button _cmdBrowse;
  [AccessedThroughProperty("txtImport")]
  private System.Windows.Forms.TextBox _txtImport;
  [AccessedThroughProperty("Label22")]
  private System.Windows.Forms.Label _Label22;
  [AccessedThroughProperty("lblTemplateName")]
  private System.Windows.Forms.Label _lblTemplateName;
  [AccessedThroughProperty("lblSheets")]
  private System.Windows.Forms.Label _lblSheets;
  [AccessedThroughProperty("gbImportResults")]
  private System.Windows.Forms.GroupBox _gbImportResults;
  [AccessedThroughProperty("lblMapped")]
  private System.Windows.Forms.Label _lblMapped;
  [AccessedThroughProperty("lblValid")]
  private System.Windows.Forms.Label _lblValid;
  [AccessedThroughProperty("lblTotalImported")]
  private System.Windows.Forms.Label _lblTotalImported;
  [AccessedThroughProperty("Label25")]
  private System.Windows.Forms.Label _Label25;
  [AccessedThroughProperty("Label24")]
  private System.Windows.Forms.Label _Label24;
  [AccessedThroughProperty("Label23")]
  private System.Windows.Forms.Label _Label23;
  [AccessedThroughProperty("PictureBox2")]
  private PictureBox _PictureBox2;
  [AccessedThroughProperty("PictureBox1")]
  private PictureBox _PictureBox1;
  [AccessedThroughProperty("lstSheets")]
  private System.Windows.Forms.ListBox _lstSheets;
  [AccessedThroughProperty("cmdImport")]
  private System.Windows.Forms.Button _cmdImport;
  [AccessedThroughProperty("cmdSaveSettings")]
  private System.Windows.Forms.Button _cmdSaveSettings;
  [AccessedThroughProperty("txtExchRate")]
  private System.Windows.Forms.TextBox _txtExchRate;
  [AccessedThroughProperty("Label15")]
  private System.Windows.Forms.Label _Label15;
  [AccessedThroughProperty("Label21")]
  private System.Windows.Forms.Label _Label21;
  [AccessedThroughProperty("lstSettings")]
  private System.Windows.Forms.ListBox _lstSettings;
  [AccessedThroughProperty("pboxImportedAsc")]
  private PictureBox _pboxImportedAsc;
  [AccessedThroughProperty("pboxWaitingAsc")]
  private PictureBox _pboxWaitingAsc;
  [AccessedThroughProperty("pboxWaitingDesc")]
  private PictureBox _pboxWaitingDesc;
  [AccessedThroughProperty("pboxImportedDesc")]
  private PictureBox _pboxImportedDesc;
  [AccessedThroughProperty("pBoxTemplateAsc")]
  private PictureBox _pBoxTemplateAsc;
  [AccessedThroughProperty("pboxTemplateDesc")]
  private PictureBox _pboxTemplateDesc;
  [AccessedThroughProperty("nbManagement")]
  private NaviBand _nbManagement;
  [AccessedThroughProperty("lstManagement")]
  private System.Windows.Forms.ListBox _lstManagement;
  [AccessedThroughProperty("Label3")]
  private System.Windows.Forms.Label _Label3;
  [AccessedThroughProperty("GroupBox1")]
  private System.Windows.Forms.GroupBox _GroupBox1;
  [AccessedThroughProperty("chkRecalcSalesUplift")]
  private System.Windows.Forms.CheckBox _chkRecalcSalesUplift;
  [AccessedThroughProperty("cmdProcessDBMaint")]
  private System.Windows.Forms.Button _cmdProcessDBMaint;
  [AccessedThroughProperty("GroupBox3")]
  private System.Windows.Forms.GroupBox _GroupBox3;
  [AccessedThroughProperty("chkBackup")]
  private System.Windows.Forms.CheckBox _chkBackup;
  [AccessedThroughProperty("txtBackupPath")]
  private System.Windows.Forms.TextBox _txtBackupPath;
  [AccessedThroughProperty("Label4")]
  private System.Windows.Forms.Label _Label4;
  [AccessedThroughProperty("chkReindex")]
  private System.Windows.Forms.CheckBox _chkReindex;
  [AccessedThroughProperty("cmdRemap")]
  private System.Windows.Forms.Button _cmdRemap;
  [AccessedThroughProperty("lblLastRunReindex")]
  private System.Windows.Forms.Label _lblLastRunReindex;
  [AccessedThroughProperty("lblLastRunBackup")]
  private System.Windows.Forms.Label _lblLastRunBackup;
  [AccessedThroughProperty("lblLastRunRecalc")]
  private System.Windows.Forms.Label _lblLastRunRecalc;
  [AccessedThroughProperty("lblLastRunNewSell")]
  private System.Windows.Forms.Label _lblLastRunNewSell;
  [AccessedThroughProperty("chkRecalcNewSell")]
  private System.Windows.Forms.CheckBox _chkRecalcNewSell;
  [AccessedThroughProperty("lblLastRunClearDown")]
  private System.Windows.Forms.Label _lblLastRunClearDown;
  [AccessedThroughProperty("chkClearImported")]
  private System.Windows.Forms.CheckBox _chkClearImported;
  [AccessedThroughProperty("lblLastRunCalcRetail")]
  private System.Windows.Forms.Label _lblLastRunCalcRetail;
  [AccessedThroughProperty("chkRecalcNewRetail")]
  private System.Windows.Forms.CheckBox _chkRecalcNewRetail;
  [AccessedThroughProperty("GroupBox2")]
  private System.Windows.Forms.GroupBox _GroupBox2;
  [AccessedThroughProperty("txtNotes")]
  private System.Windows.Forms.TextBox _txtNotes;
  [AccessedThroughProperty("Label20")]
  private System.Windows.Forms.Label _Label20;
  [AccessedThroughProperty("Label26")]
  private System.Windows.Forms.Label _Label26;
  [AccessedThroughProperty("txtTemplateNotes")]
  private System.Windows.Forms.TextBox _txtTemplateNotes;
  [AccessedThroughProperty("chkOverwriteCosts")]
  private System.Windows.Forms.CheckBox _chkOverwriteCosts;
  [AccessedThroughProperty("radSell")]
  private RadioButton _radSell;
  [AccessedThroughProperty("radRetail")]
  private RadioButton _radRetail;
  [AccessedThroughProperty("radCost")]
  private RadioButton _radCost;
  [AccessedThroughProperty("cmdBrowseApprovedPrices")]
  private System.Windows.Forms.Button _cmdBrowseApprovedPrices;
  [AccessedThroughProperty("txtImportApproved")]
  private System.Windows.Forms.TextBox _txtImportApproved;
  [AccessedThroughProperty("Label27")]
  private System.Windows.Forms.Label _Label27;
  [AccessedThroughProperty("cmdImportApproved")]
  private System.Windows.Forms.Button _cmdImportApproved;
  [AccessedThroughProperty("cmdRemoveImported")]
  private System.Windows.Forms.Button _cmdRemoveImported;
  [AccessedThroughProperty("cmdProcessData")]
  private System.Windows.Forms.Button _cmdProcessData;
  [AccessedThroughProperty("chkOverwriteRetail")]
  private System.Windows.Forms.CheckBox _chkOverwriteRetail;
  [AccessedThroughProperty("chkOverwriteSell")]
  private System.Windows.Forms.CheckBox _chkOverwriteSell;
  [AccessedThroughProperty("lblLastRunOverwriteApprovedRetail")]
  private System.Windows.Forms.Label _lblLastRunOverwriteApprovedRetail;
  [AccessedThroughProperty("lblLastRunOverwriteApprovedSell")]
  private System.Windows.Forms.Label _lblLastRunOverwriteApprovedSell;
  [AccessedThroughProperty("lblLastRunOverwriteApprovedCosts")]
  private System.Windows.Forms.Label _lblLastRunOverwriteApprovedCosts;
  [AccessedThroughProperty("chkStandard")]
  private System.Windows.Forms.CheckBox _chkStandard;
  [AccessedThroughProperty("txtEmail")]
  private System.Windows.Forms.TextBox _txtEmail;
  [AccessedThroughProperty("Label28")]
  private System.Windows.Forms.Label _Label28;
  [AccessedThroughProperty("nbExport")]
  private NaviBand _nbExport;
  [AccessedThroughProperty("tpExport")]
  private TabPage _tpExport;
  [AccessedThroughProperty("Label29")]
  private System.Windows.Forms.Label _Label29;
  [AccessedThroughProperty("lstExported")]
  private System.Windows.Forms.ListBox _lstExported;
  [AccessedThroughProperty("pBoxExportAsc")]
  private PictureBox _pBoxExportAsc;
  [AccessedThroughProperty("pBoxExportedAsc")]
  private PictureBox _pBoxExportedAsc;
  [AccessedThroughProperty("pboxExportedDesc")]
  private PictureBox _pboxExportedDesc;
  [AccessedThroughProperty("lstExport")]
  private System.Windows.Forms.ListBox _lstExport;
  [AccessedThroughProperty("pBoxExportDesc")]
  private PictureBox _pBoxExportDesc;
  [AccessedThroughProperty("lblExported")]
  private System.Windows.Forms.Label _lblExported;
  [AccessedThroughProperty("lblExport")]
  private System.Windows.Forms.Label _lblExport;
  [AccessedThroughProperty("lblExportLocation")]
  private System.Windows.Forms.Label _lblExportLocation;
  [AccessedThroughProperty("cmdExport")]
  private System.Windows.Forms.Button _cmdExport;
  [AccessedThroughProperty("lblExportTemplateName")]
  private System.Windows.Forms.Label _lblExportTemplateName;
  [AccessedThroughProperty("txtExportLocation")]
  private System.Windows.Forms.TextBox _txtExportLocation;
  [AccessedThroughProperty("Label30")]
  private System.Windows.Forms.Label _Label30;
  [AccessedThroughProperty("cmdBrowseExportFolder")]
  private System.Windows.Forms.Button _cmdBrowseExportFolder;
  [AccessedThroughProperty("cmdBrowseBackupFoler")]
  private System.Windows.Forms.Button _cmdBrowseBackupFoler;
  [AccessedThroughProperty("lblExportFile")]
  private System.Windows.Forms.Label _lblExportFile;
  [AccessedThroughProperty("Label32")]
  private System.Windows.Forms.Label _Label32;
  [AccessedThroughProperty("lblEmail")]
  private System.Windows.Forms.Label _lblEmail;
  [AccessedThroughProperty("Label33")]
  private System.Windows.Forms.Label _Label33;
  [AccessedThroughProperty("cmdResetExportedFlag")]
  private System.Windows.Forms.Button _cmdResetExportedFlag;
  [AccessedThroughProperty("txteMailBody")]
  private System.Windows.Forms.TextBox _txteMailBody;
  [AccessedThroughProperty("Label34")]
  private System.Windows.Forms.Label _Label34;
  [AccessedThroughProperty("txteMailSubject")]
  private System.Windows.Forms.TextBox _txteMailSubject;
  [AccessedThroughProperty("Label31")]
  private System.Windows.Forms.Label _Label31;
  [AccessedThroughProperty("nbNewProducts")]
  private NaviBand _nbNewProducts;
  [AccessedThroughProperty("tpNewProducts")]
  private TabPage _tpNewProducts;
  [AccessedThroughProperty("lstNewProducts")]
  private System.Windows.Forms.ListBox _lstNewProducts;
  [AccessedThroughProperty("cmdImportNewProducts")]
  private System.Windows.Forms.Button _cmdImportNewProducts;
  [AccessedThroughProperty("cmdBrowseNewProducts")]
  private System.Windows.Forms.Button _cmdBrowseNewProducts;
  [AccessedThroughProperty("txtImportNewProducts")]
  private System.Windows.Forms.TextBox _txtImportNewProducts;
  [AccessedThroughProperty("Label35")]
  private System.Windows.Forms.Label _Label35;
  [AccessedThroughProperty("Label36")]
  private System.Windows.Forms.Label _Label36;
  [AccessedThroughProperty("lblNewProductsLastImported")]
  private System.Windows.Forms.Label _lblNewProductsLastImported;
  [AccessedThroughProperty("Label37")]
  private System.Windows.Forms.Label _Label37;
  [AccessedThroughProperty("lblMappedINdex")]
  private System.Windows.Forms.Label _lblMappedINdex;
  [AccessedThroughProperty("lblMappedPriceLists")]
  private System.Windows.Forms.Label _lblMappedPriceLists;
  [AccessedThroughProperty("lblMappedSuppliers")]
  private System.Windows.Forms.Label _lblMappedSuppliers;
  [AccessedThroughProperty("lblMappedSubGroups")]
  private System.Windows.Forms.Label _lblMappedSubGroups;
  [AccessedThroughProperty("lblMappedProductGroups")]
  private System.Windows.Forms.Label _lblMappedProductGroups;
  [AccessedThroughProperty("radResolveIndex")]
  private RadioButton _radResolveIndex;
  [AccessedThroughProperty("radResolveSuppliers")]
  private RadioButton _radResolveSuppliers;
  [AccessedThroughProperty("radResolveSubGroups")]
  private RadioButton _radResolveSubGroups;
  [AccessedThroughProperty("radResolveProdGroups")]
  private RadioButton _radResolveProdGroups;
  [AccessedThroughProperty("cmdResolve")]
  private System.Windows.Forms.Button _cmdResolve;
    // Added by Zeljko
    [AccessedThroughProperty("cmdResolveClear")]
    private System.Windows.Forms.Button _cmdResolveClear;


    [AccessedThroughProperty("cmdExportAll")]
  private System.Windows.Forms.Button _cmdExportAll;
  [AccessedThroughProperty("txteMailSender")]
  private System.Windows.Forms.TextBox _txteMailSender;
  [AccessedThroughProperty("Label38")]
  private System.Windows.Forms.Label _Label38;
  [AccessedThroughProperty("chkAttach")]
  private System.Windows.Forms.CheckBox _chkAttach;
  [AccessedThroughProperty("chkOutlook")]
  private System.Windows.Forms.CheckBox _chkOutlook;
  [AccessedThroughProperty("lblInfo")]
  private System.Windows.Forms.Label _lblInfo;
  [AccessedThroughProperty("lblSpam")]
  private System.Windows.Forms.Label _lblSpam;
  [AccessedThroughProperty("pbarSpam")]
  private ProgressBar _pbarSpam;
  [AccessedThroughProperty("cmdUpdateProducts")]
  private System.Windows.Forms.Button _cmdUpdateProducts;
  [AccessedThroughProperty("lblUpdateParams")]
  private System.Windows.Forms.Label _lblUpdateParams;
  [AccessedThroughProperty("lblCreateNominals")]
  private System.Windows.Forms.Label _lblCreateNominals;
  [AccessedThroughProperty("lblUpdateTaxCodes")]
  private System.Windows.Forms.Label _lblUpdateTaxCodes;
  [AccessedThroughProperty("lblCreateStockCodes")]
  private System.Windows.Forms.Label _lblCreateStockCodes;
  [AccessedThroughProperty("lblUpdateInfo")]
  private System.Windows.Forms.Label _lblUpdateInfo;
  [AccessedThroughProperty("lblCreateIndexRecords")]
  private System.Windows.Forms.Label _lblCreateIndexRecords;
  [AccessedThroughProperty("lblCreatePriceBands")]
  private System.Windows.Forms.Label _lblCreatePriceBands;
  [AccessedThroughProperty("lblUpdateNominals")]
  private System.Windows.Forms.Label _lblUpdateNominals;
  [AccessedThroughProperty("lblCreateProdultListItems")]
  private System.Windows.Forms.Label _lblCreateProdultListItems;
  [AccessedThroughProperty("lblPriceList")]
  private System.Windows.Forms.Label _lblPriceList;
  [AccessedThroughProperty("Label40")]
  private System.Windows.Forms.Label _Label40;
  [AccessedThroughProperty("GroupBox4")]
  private System.Windows.Forms.GroupBox _GroupBox4;
  [AccessedThroughProperty("lblLastRunDateCopyPending")]
  private System.Windows.Forms.Label _lblLastRunDateCopyPending;
  [AccessedThroughProperty("chkCopyPending")]
  private System.Windows.Forms.CheckBox _chkCopyPending;
  [AccessedThroughProperty("chkIncludeDeleted")]
  private System.Windows.Forms.CheckBox _chkIncludeDeleted;
  [AccessedThroughProperty("chkDuplicateProducts")]
  private System.Windows.Forms.CheckBox _chkDuplicateProducts;
  [AccessedThroughProperty("cmdProductMaint")]
  private System.Windows.Forms.Button _cmdProductMaint;
  [AccessedThroughProperty("lblLastUpdatePOPPrices")]
  private System.Windows.Forms.Label _lblLastUpdatePOPPrices;
  [AccessedThroughProperty("chkUpdatePOPPrices")]
  private System.Windows.Forms.CheckBox _chkUpdatePOPPrices;
  [AccessedThroughProperty("lblLastRunUpdateCostSellRetail")]
  private System.Windows.Forms.Label _lblLastRunUpdateCostSellRetail;
  [AccessedThroughProperty("chkUpdateCostSellretail")]
  private System.Windows.Forms.CheckBox _chkUpdateCostSellretail;
  private bool buttonPressed;
  private OleDbConnection cn;
  private OleDbDataAdapter da;
  private DataSet dsCSV;
  private string sSheetName;
  private double dDiscountPerc;
  private int iBaseUnits;
  private int[] XLSArray;
  private string sImportTemplate;
  private string sImportedTemplate;
  private string aModuleName;
  private string aProcName;
  private int iOffset;
  private string sExt;
  private string sExportPath;
  private string sExportFile;

  [DebuggerNonUserCode]
  static frmMain()
  {
  }

  public frmMain()
  {
    this.Resize += new EventHandler(this.frmMain_Resize);
    this.ResizeEnd += new EventHandler(this.frmMain_ResizeEnd);
    this.ImeModeChanged += new EventHandler(this.frmMain_ImeModeChanged);
    this.Load += new EventHandler(this.frmMain_Load);
    frmMain.__ENCAddToList((object) this);
    this.XLSArray = new int[6];
    this.aModuleName = Process.GetCurrentProcess().MainModule.ModuleName;
    this.aProcName = Path.GetFileNameWithoutExtension(this.aModuleName);
    this.iOffset = 10;
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMain.__ENCList)
    {
      if (frmMain.__ENCList.Count == frmMain.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMain.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMain.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMain.__ENCList[index1] = frmMain.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMain.__ENCList.RemoveRange(index1, checked (frmMain.__ENCList.Count - index1));
        frmMain.__ENCList.Capacity = frmMain.__ENCList.Count;
      }
      frmMain.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMain));
    this.tcMain = new TabControl();
    this.tpImport = new TabPage();
    this.txtTemplateNotes = new System.Windows.Forms.TextBox();
    this.Label26 = new System.Windows.Forms.Label();
    this.gbImportResults = new System.Windows.Forms.GroupBox();
    this.lblPriceList = new System.Windows.Forms.Label();
    this.Label40 = new System.Windows.Forms.Label();
    this.cmdRemoveImported = new System.Windows.Forms.Button();
    this.cmdRemap = new System.Windows.Forms.Button();
    this.PictureBox2 = new PictureBox();
    this.PictureBox1 = new PictureBox();
    this.lblMapped = new System.Windows.Forms.Label();
    this.lblValid = new System.Windows.Forms.Label();
    this.lblTotalImported = new System.Windows.Forms.Label();
    this.Label25 = new System.Windows.Forms.Label();
    this.Label24 = new System.Windows.Forms.Label();
    this.Label23 = new System.Windows.Forms.Label();
    this.lblSheets = new System.Windows.Forms.Label();
    this.lstSheets = new System.Windows.Forms.ListBox();
    this.cmdImport = new System.Windows.Forms.Button();
    this.lblTemplateName = new System.Windows.Forms.Label();
    this.cmdBrowse = new System.Windows.Forms.Button();
    this.txtImport = new System.Windows.Forms.TextBox();
    this.Label22 = new System.Windows.Forms.Label();
    this.Label1 = new System.Windows.Forms.Label();
    this.tpTemplates = new TabPage();
    this.chkStandard = new System.Windows.Forms.CheckBox();
    this.txtEmail = new System.Windows.Forms.TextBox();
    this.Label28 = new System.Windows.Forms.Label();
    this.txtNotes = new System.Windows.Forms.TextBox();
    this.Label20 = new System.Windows.Forms.Label();
    this.txtPriceList = new System.Windows.Forms.TextBox();
    this.txtSupplierCode = new System.Windows.Forms.TextBox();
    this.Label19 = new System.Windows.Forms.Label();
    this.Label18 = new System.Windows.Forms.Label();
    this.Label17 = new System.Windows.Forms.Label();
    this.Label16 = new System.Windows.Forms.Label();
    this.Label14 = new System.Windows.Forms.Label();
    this.cboCalcPrice1 = new ComboBox();
    this.cboCalcPrice2 = new ComboBox();
    this.cboCalcPrice3 = new ComboBox();
    this.cboSuppProduct = new ComboBox();
    this.cboIIHFProductCode = new ComboBox();
    this.txtTemplateName = new System.Windows.Forms.TextBox();
    this.txtSP = new System.Windows.Forms.TextBox();
    this.Label13 = new System.Windows.Forms.Label();
    this.Label12 = new System.Windows.Forms.Label();
    this.Label11 = new System.Windows.Forms.Label();
    this.Label10 = new System.Windows.Forms.Label();
    this.chkProductMapping = new System.Windows.Forms.CheckBox();
    this.Label9 = new System.Windows.Forms.Label();
    this.chkSterling = new System.Windows.Forms.CheckBox();
    this.chkEuro = new System.Windows.Forms.CheckBox();
    this.chkGross = new System.Windows.Forms.CheckBox();
    this.chkNet = new System.Windows.Forms.CheckBox();
    this.Label8 = new System.Windows.Forms.Label();
    this.Label7 = new System.Windows.Forms.Label();
    this.Label5 = new System.Windows.Forms.Label();
    this.Label6 = new System.Windows.Forms.Label();
    this.Label2 = new System.Windows.Forms.Label();
    this.cmdSearchPriceList = new System.Windows.Forms.Button();
    this.cmdSearchSupplier = new System.Windows.Forms.Button();
    this.cmdDelete = new System.Windows.Forms.Button();
    this.cmdSaveTemplate = new System.Windows.Forms.Button();
    this.tpSettings = new TabPage();
    this.txteMailSender = new System.Windows.Forms.TextBox();
    this.Label38 = new System.Windows.Forms.Label();
    this.txteMailBody = new System.Windows.Forms.TextBox();
    this.Label34 = new System.Windows.Forms.Label();
    this.txteMailSubject = new System.Windows.Forms.TextBox();
    this.Label31 = new System.Windows.Forms.Label();
    this.txtExportLocation = new System.Windows.Forms.TextBox();
    this.Label30 = new System.Windows.Forms.Label();
    this.txtBackupPath = new System.Windows.Forms.TextBox();
    this.Label4 = new System.Windows.Forms.Label();
    this.txtExchRate = new System.Windows.Forms.TextBox();
    this.Label15 = new System.Windows.Forms.Label();
    this.Label21 = new System.Windows.Forms.Label();
    this.cmdBrowseExportFolder = new System.Windows.Forms.Button();
    this.cmdBrowseBackupFoler = new System.Windows.Forms.Button();
    this.cmdSaveSettings = new System.Windows.Forms.Button();
    this.tpManage = new TabPage();
    this.GroupBox4 = new System.Windows.Forms.GroupBox();
    this.lblLastRunDateCopyPending = new System.Windows.Forms.Label();
    this.chkCopyPending = new System.Windows.Forms.CheckBox();
    this.chkIncludeDeleted = new System.Windows.Forms.CheckBox();
    this.chkDuplicateProducts = new System.Windows.Forms.CheckBox();
    this.cmdProductMaint = new System.Windows.Forms.Button();
    this.GroupBox1 = new System.Windows.Forms.GroupBox();
    this.lblLastRunOverwriteApprovedRetail = new System.Windows.Forms.Label();
    this.lblLastRunOverwriteApprovedSell = new System.Windows.Forms.Label();
    this.lblLastRunOverwriteApprovedCosts = new System.Windows.Forms.Label();
    this.cmdProcessData = new System.Windows.Forms.Button();
    this.chkOverwriteRetail = new System.Windows.Forms.CheckBox();
    this.chkOverwriteSell = new System.Windows.Forms.CheckBox();
    this.lblLastRunCalcRetail = new System.Windows.Forms.Label();
    this.chkOverwriteCosts = new System.Windows.Forms.CheckBox();
    this.chkRecalcNewRetail = new System.Windows.Forms.CheckBox();
    this.lblLastRunNewSell = new System.Windows.Forms.Label();
    this.chkRecalcNewSell = new System.Windows.Forms.CheckBox();
    this.GroupBox2 = new System.Windows.Forms.GroupBox();
    this.cmdImportApproved = new System.Windows.Forms.Button();
    this.radSell = new RadioButton();
    this.radRetail = new RadioButton();
    this.radCost = new RadioButton();
    this.cmdBrowseApprovedPrices = new System.Windows.Forms.Button();
    this.txtImportApproved = new System.Windows.Forms.TextBox();
    this.Label27 = new System.Windows.Forms.Label();
    this.GroupBox3 = new System.Windows.Forms.GroupBox();
    this.lblLastRunClearDown = new System.Windows.Forms.Label();
    this.cmdProcessDBMaint = new System.Windows.Forms.Button();
    this.lblLastRunReindex = new System.Windows.Forms.Label();
    this.chkClearImported = new System.Windows.Forms.CheckBox();
    this.lblLastRunBackup = new System.Windows.Forms.Label();
    this.lblLastRunRecalc = new System.Windows.Forms.Label();
    this.chkReindex = new System.Windows.Forms.CheckBox();
    this.chkRecalcSalesUplift = new System.Windows.Forms.CheckBox();
    this.chkBackup = new System.Windows.Forms.CheckBox();
    this.Label3 = new System.Windows.Forms.Label();
    this.tpExport = new TabPage();
    this.lblInfo = new System.Windows.Forms.Label();
    this.lblSpam = new System.Windows.Forms.Label();
    this.pbarSpam = new ProgressBar();
    this.chkOutlook = new System.Windows.Forms.CheckBox();
    this.chkAttach = new System.Windows.Forms.CheckBox();
    this.lblEmail = new System.Windows.Forms.Label();
    this.Label33 = new System.Windows.Forms.Label();
    this.lblExportFile = new System.Windows.Forms.Label();
    this.Label32 = new System.Windows.Forms.Label();
    this.lblExportTemplateName = new System.Windows.Forms.Label();
    this.lblExportLocation = new System.Windows.Forms.Label();
    this.Label29 = new System.Windows.Forms.Label();
    this.cmdExportAll = new System.Windows.Forms.Button();
    this.cmdResetExportedFlag = new System.Windows.Forms.Button();
    this.cmdExport = new System.Windows.Forms.Button();
    this.tpNewProducts = new TabPage();
    this.lblCreateIndexRecords = new System.Windows.Forms.Label();
    this.lblCreatePriceBands = new System.Windows.Forms.Label();
    this.lblUpdateNominals = new System.Windows.Forms.Label();
    this.lblCreateProdultListItems = new System.Windows.Forms.Label();
    this.cmdResolve = new System.Windows.Forms.Button();

        // Added by Zeljko
        this.cmdResolveClear = new System.Windows.Forms.Button();


        this.lblUpdateInfo = new System.Windows.Forms.Label();
    this.lblUpdateParams = new System.Windows.Forms.Label();
    this.lblCreateNominals = new System.Windows.Forms.Label();
    this.lblUpdateTaxCodes = new System.Windows.Forms.Label();
    this.lblCreateStockCodes = new System.Windows.Forms.Label();
    this.cmdUpdateProducts = new System.Windows.Forms.Button();
    this.radResolveIndex = new RadioButton();
    this.radResolveSuppliers = new RadioButton();
    this.radResolveSubGroups = new RadioButton();
    this.radResolveProdGroups = new RadioButton();
    this.lblMappedINdex = new System.Windows.Forms.Label();
    this.lblMappedPriceLists = new System.Windows.Forms.Label();
    this.lblMappedSuppliers = new System.Windows.Forms.Label();
    this.lblMappedSubGroups = new System.Windows.Forms.Label();
    this.lblMappedProductGroups = new System.Windows.Forms.Label();
    this.lblNewProductsLastImported = new System.Windows.Forms.Label();
    this.Label37 = new System.Windows.Forms.Label();
    this.txtImportNewProducts = new System.Windows.Forms.TextBox();
    this.Label35 = new System.Windows.Forms.Label();
    this.Label36 = new System.Windows.Forms.Label();
    this.cmdImportNewProducts = new System.Windows.Forms.Button();
    this.cmdBrowseNewProducts = new System.Windows.Forms.Button();
    this.ToolTip1 = new ToolTip(this.components);
    this.pBoxExportAsc = new PictureBox();
    this.pBoxExportedAsc = new PictureBox();
    this.pboxExportedDesc = new PictureBox();
    this.pBoxExportDesc = new PictureBox();
    this.pboxTemplateDesc = new PictureBox();
    this.pBoxTemplateAsc = new PictureBox();
    this.pboxImportedAsc = new PictureBox();
    this.pboxImportedDesc = new PictureBox();
    this.pboxWaitingAsc = new PictureBox();
    this.pboxWaitingDesc = new PictureBox();
    this.ListBox1 = new System.Windows.Forms.ListBox();
    this.naviBar1 = new NaviBar(this.components);
    this.nbImport = new NaviBand(this.components);
    this.lblImported = new System.Windows.Forms.Label();
    this.lstWaiting = new System.Windows.Forms.ListBox();
    this.lstImported = new System.Windows.Forms.ListBox();
    this.lblWaiting = new System.Windows.Forms.Label();
    this.nbExport = new NaviBand(this.components);
    this.lstExported = new System.Windows.Forms.ListBox();
    this.lstExport = new System.Windows.Forms.ListBox();
    this.lblExport = new System.Windows.Forms.Label();
    this.lblExported = new System.Windows.Forms.Label();
    this.nbTemplates = new NaviBand(this.components);
    this.lbTemplates = new System.Windows.Forms.ListBox();
    this.lblNewTemplate = new System.Windows.Forms.Label();
    this.nbNewProducts = new NaviBand(this.components);
    this.lstNewProducts = new System.Windows.Forms.ListBox();
    this.nbSettings = new NaviBand(this.components);
    this.lstSettings = new System.Windows.Forms.ListBox();
    this.nbManagement = new NaviBand(this.components);
    this.lstManagement = new System.Windows.Forms.ListBox();
    this.lblLastRunUpdateCostSellRetail = new System.Windows.Forms.Label();
    this.chkUpdateCostSellretail = new System.Windows.Forms.CheckBox();
    this.lblLastUpdatePOPPrices = new System.Windows.Forms.Label();
    this.chkUpdatePOPPrices = new System.Windows.Forms.CheckBox();
    this.tcMain.SuspendLayout();
    this.tpImport.SuspendLayout();
    this.gbImportResults.SuspendLayout();
    ((ISupportInitialize) this.PictureBox2).BeginInit();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.tpTemplates.SuspendLayout();
    this.tpSettings.SuspendLayout();
    this.tpManage.SuspendLayout();
    this.GroupBox4.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.tpExport.SuspendLayout();
    this.tpNewProducts.SuspendLayout();
    ((ISupportInitialize) this.pBoxExportAsc).BeginInit();
    ((ISupportInitialize) this.pBoxExportedAsc).BeginInit();
    ((ISupportInitialize) this.pboxExportedDesc).BeginInit();
    ((ISupportInitialize) this.pBoxExportDesc).BeginInit();
    ((ISupportInitialize) this.pboxTemplateDesc).BeginInit();
    ((ISupportInitialize) this.pBoxTemplateAsc).BeginInit();
    ((ISupportInitialize) this.pboxImportedAsc).BeginInit();
    ((ISupportInitialize) this.pboxImportedDesc).BeginInit();
    ((ISupportInitialize) this.pboxWaitingAsc).BeginInit();
    ((ISupportInitialize) this.pboxWaitingDesc).BeginInit();
    this.naviBar1.BeginInit();
    this.naviBar1.SuspendLayout();
    this.nbImport.ClientArea.SuspendLayout();
    this.nbImport.SuspendLayout();
    this.nbExport.ClientArea.SuspendLayout();
    this.nbExport.SuspendLayout();
    this.nbTemplates.ClientArea.SuspendLayout();
    this.nbTemplates.SuspendLayout();
    this.nbNewProducts.ClientArea.SuspendLayout();
    this.nbNewProducts.SuspendLayout();
    this.nbSettings.ClientArea.SuspendLayout();
    this.nbSettings.SuspendLayout();
    this.nbManagement.ClientArea.SuspendLayout();
    this.nbManagement.SuspendLayout();
    this.SuspendLayout();
    this.tcMain.Controls.Add((Control) this.tpImport);
    this.tcMain.Controls.Add((Control) this.tpTemplates);
    this.tcMain.Controls.Add((Control) this.tpSettings);
    this.tcMain.Controls.Add((Control) this.tpManage);
    this.tcMain.Controls.Add((Control) this.tpExport);
    this.tcMain.Controls.Add((Control) this.tpNewProducts);
    this.tcMain.Dock = DockStyle.Fill;
    TabControl tcMain1 = this.tcMain;
    Size size1 = new Size(42, 17);
        Size size1Clear = new Size(42, 17);
        Size size2 = size1;
    tcMain1.ItemSize = size2;
    TabControl tcMain2 = this.tcMain;
    System.Drawing.Point point1 = new System.Drawing.Point(198, 0);
        System.Drawing.Point point1Clear = new System.Drawing.Point(198, 0);
        System.Drawing.Point point2 = point1;
    tcMain2.Location = point2;
    this.tcMain.Name = "tcMain";
    this.tcMain.SelectedIndex = 0;
    TabControl tcMain3 = this.tcMain;
    size1 = new Size(806, 671);
    Size size3 = size1;
    tcMain3.Size = size3;
    this.tcMain.TabIndex = 2;
    this.tpImport.BackColor = Color.Beige;
    this.tpImport.Controls.Add((Control) this.txtTemplateNotes);
    this.tpImport.Controls.Add((Control) this.Label26);
    this.tpImport.Controls.Add((Control) this.gbImportResults);
    this.tpImport.Controls.Add((Control) this.lblSheets);
    this.tpImport.Controls.Add((Control) this.lstSheets);
    this.tpImport.Controls.Add((Control) this.cmdImport);
    this.tpImport.Controls.Add((Control) this.lblTemplateName);
    this.tpImport.Controls.Add((Control) this.cmdBrowse);
    this.tpImport.Controls.Add((Control) this.txtImport);
    this.tpImport.Controls.Add((Control) this.Label22);
    this.tpImport.Controls.Add((Control) this.Label1);
    TabPage tpImport1 = this.tpImport;
    point1 = new System.Drawing.Point(4, 21);
    System.Drawing.Point point3 = point1;
    tpImport1.Location = point3;
    this.tpImport.Name = "tpImport";
    TabPage tpImport2 = this.tpImport;
    System.Windows.Forms.Padding padding1 = new System.Windows.Forms.Padding(3);
    System.Windows.Forms.Padding padding2 = padding1;
    tpImport2.Padding = padding2;
    TabPage tpImport3 = this.tpImport;
    size1 = new Size(798, 615);
    Size size4 = size1;
    tpImport3.Size = size4;
    this.tpImport.TabIndex = 0;
    this.tpImport.Text = "Import";
    this.txtTemplateNotes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtTemplateNotes.BackColor = Color.Khaki;
    this.txtTemplateNotes.BorderStyle = BorderStyle.FixedSingle;
    this.txtTemplateNotes.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtTemplateNotes1 = this.txtTemplateNotes;
    point1 = new System.Drawing.Point(154, 240 /*0xF0*/);
    System.Drawing.Point point4 = point1;
    txtTemplateNotes1.Location = point4;
    this.txtTemplateNotes.MaxLength = (int) byte.MaxValue;
    this.txtTemplateNotes.Multiline = true;
    this.txtTemplateNotes.Name = "txtTemplateNotes";
    System.Windows.Forms.TextBox txtTemplateNotes2 = this.txtTemplateNotes;
    size1 = new Size(489, 51);
    Size size5 = size1;
    txtTemplateNotes2.Size = size5;
    this.txtTemplateNotes.TabIndex = 42;
    this.Label26.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label26_1 = this.Label26;
    point1 = new System.Drawing.Point(18, 237);
    System.Drawing.Point point5 = point1;
    label26_1.Location = point5;
    this.Label26.Name = "Label26";
    System.Windows.Forms.Label label26_2 = this.Label26;
    size1 = new Size(130, 24);
    Size size6 = size1;
    label26_2.Size = size6;
    this.Label26.TabIndex = 41;
    this.Label26.Text = "Template Notes";
    this.Label26.TextAlign = ContentAlignment.MiddleRight;
    this.gbImportResults.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.gbImportResults.Controls.Add((Control) this.lblPriceList);
    this.gbImportResults.Controls.Add((Control) this.Label40);
    this.gbImportResults.Controls.Add((Control) this.cmdRemoveImported);
    this.gbImportResults.Controls.Add((Control) this.cmdRemap);
    this.gbImportResults.Controls.Add((Control) this.PictureBox2);
    this.gbImportResults.Controls.Add((Control) this.PictureBox1);
    this.gbImportResults.Controls.Add((Control) this.lblMapped);
    this.gbImportResults.Controls.Add((Control) this.lblValid);
    this.gbImportResults.Controls.Add((Control) this.lblTotalImported);
    this.gbImportResults.Controls.Add((Control) this.Label25);
    this.gbImportResults.Controls.Add((Control) this.Label24);
    this.gbImportResults.Controls.Add((Control) this.Label23);
    this.gbImportResults.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.gbImportResults.ForeColor = SystemColors.ControlText;
    System.Windows.Forms.GroupBox gbImportResults1 = this.gbImportResults;
    point1 = new System.Drawing.Point(21, 446);
    System.Drawing.Point point6 = point1;
    gbImportResults1.Location = point6;
    this.gbImportResults.Name = "gbImportResults";
    System.Windows.Forms.GroupBox gbImportResults2 = this.gbImportResults;
    size1 = new Size(756, 147);
    Size size7 = size1;
    gbImportResults2.Size = size7;
    this.gbImportResults.TabIndex = 39;
    this.gbImportResults.TabStop = false;
    this.gbImportResults.Text = "Import Results";
    this.gbImportResults.Visible = false;
    this.lblPriceList.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblPriceList1 = this.lblPriceList;
    point1 = new System.Drawing.Point(176 /*0xB0*/, 112 /*0x70*/);
    System.Drawing.Point point7 = point1;
    lblPriceList1.Location = point7;
    this.lblPriceList.Name = "lblPriceList";
    System.Windows.Forms.Label lblPriceList2 = this.lblPriceList;
    size1 = new Size(79, 24);
    Size size8 = size1;
    lblPriceList2.Size = size8;
    this.lblPriceList.TabIndex = 43;
    this.lblPriceList.Text = "0";
    this.lblPriceList.TextAlign = ContentAlignment.MiddleLeft;
    this.Label40.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label40_1 = this.Label40;
    point1 = new System.Drawing.Point(12, 112 /*0x70*/);
    System.Drawing.Point point8 = point1;
    label40_1.Location = point8;
    this.Label40.Name = "Label40";
    System.Windows.Forms.Label label40_2 = this.Label40;
    size1 = new Size(158, 24);
    Size size9 = size1;
    label40_2.Size = size9;
    this.Label40.TabIndex = 42;
    this.Label40.Text = "Records On Price List";
    this.Label40.TextAlign = ContentAlignment.MiddleRight;
    this.cmdRemoveImported.Anchor = AnchorStyles.Bottom;
    this.cmdRemoveImported.AutoEllipsis = true;
    this.cmdRemoveImported.BackColor = Color.Khaki;
    this.cmdRemoveImported.Font = new System.Drawing.Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdRemoveImported.Image = (Image) PriceChanger.My.Resources.Resources.next16;
    this.cmdRemoveImported.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdRemoveImported1 = this.cmdRemoveImported;
    point1 = new System.Drawing.Point(273, 80 /*0x50*/);
    System.Drawing.Point point9 = point1;
    cmdRemoveImported1.Location = point9;
    this.cmdRemoveImported.Name = "cmdRemoveImported";
    System.Windows.Forms.Button cmdRemoveImported2 = this.cmdRemoveImported;
    size1 = new Size(141, 25);
    Size size10 = size1;
    cmdRemoveImported2.Size = size10;
    this.cmdRemoveImported.TabIndex = 41;
    this.cmdRemoveImported.Text = "Remove Imported Data";
    this.cmdRemoveImported.TextAlign = ContentAlignment.MiddleRight;
    this.cmdRemoveImported.UseVisualStyleBackColor = false;
    this.cmdRemap.Anchor = AnchorStyles.Bottom;
    this.cmdRemap.AutoEllipsis = true;
    this.cmdRemap.BackColor = Color.Khaki;
    this.cmdRemap.Font = new System.Drawing.Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdRemap.Image = (Image) PriceChanger.My.Resources.Resources.next16;
    this.cmdRemap.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdRemap1 = this.cmdRemap;
    point1 = new System.Drawing.Point(273, 111);
    System.Drawing.Point point10 = point1;
    cmdRemap1.Location = point10;
    this.cmdRemap.Name = "cmdRemap";
    System.Windows.Forms.Button cmdRemap2 = this.cmdRemap;
    size1 = new Size(141, 25);
    Size size11 = size1;
    cmdRemap2.Size = size11;
    this.cmdRemap.TabIndex = 40;
    this.cmdRemap.Text = "Redo Product Mapping";
    this.cmdRemap.TextAlign = ContentAlignment.MiddleRight;
    this.cmdRemap.UseVisualStyleBackColor = false;
    this.PictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    PictureBox pictureBox2_1 = this.PictureBox2;
    point1 = new System.Drawing.Point(562, 39);
    System.Drawing.Point point11 = point1;
    pictureBox2_1.Location = point11;
    this.PictureBox2.Name = "PictureBox2";
    PictureBox pictureBox2_2 = this.PictureBox2;
    size1 = new Size(188, 91);
    Size size12 = size1;
    pictureBox2_2.Size = size12;
    this.PictureBox2.TabIndex = 40;
    this.PictureBox2.TabStop = false;
    this.PictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    PictureBox pictureBox1_1 = this.PictureBox1;
    point1 = new System.Drawing.Point(433, 32 /*0x20*/);
    System.Drawing.Point point12 = point1;
    pictureBox1_1.Location = point12;
    this.PictureBox1.Name = "PictureBox1";
    PictureBox pictureBox1_2 = this.PictureBox1;
    size1 = new Size(123, 104);
    Size size13 = size1;
    pictureBox1_2.Size = size13;
    this.PictureBox1.TabIndex = 39;
    this.PictureBox1.TabStop = false;
    this.lblMapped.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblMapped1 = this.lblMapped;
    point1 = new System.Drawing.Point(175, 81);
    System.Drawing.Point point13 = point1;
    lblMapped1.Location = point13;
    this.lblMapped.Name = "lblMapped";
    System.Windows.Forms.Label lblMapped2 = this.lblMapped;
    size1 = new Size(79, 24);
    Size size14 = size1;
    lblMapped2.Size = size14;
    this.lblMapped.TabIndex = 38;
    this.lblMapped.Text = "0";
    this.lblMapped.TextAlign = ContentAlignment.MiddleLeft;
    this.lblValid.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblValid1 = this.lblValid;
    point1 = new System.Drawing.Point(175, 50);
    System.Drawing.Point point14 = point1;
    lblValid1.Location = point14;
    this.lblValid.Name = "lblValid";
    System.Windows.Forms.Label lblValid2 = this.lblValid;
    size1 = new Size(80 /*0x50*/, 24);
    Size size15 = size1;
    lblValid2.Size = size15;
    this.lblValid.TabIndex = 37;
    this.lblValid.Text = "0";
    this.lblValid.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTotalImported.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblTotalImported1 = this.lblTotalImported;
    point1 = new System.Drawing.Point(175, 19);
    System.Drawing.Point point15 = point1;
    lblTotalImported1.Location = point15;
    this.lblTotalImported.Name = "lblTotalImported";
    System.Windows.Forms.Label lblTotalImported2 = this.lblTotalImported;
    size1 = new Size(80 /*0x50*/, 24);
    Size size16 = size1;
    lblTotalImported2.Size = size16;
    this.lblTotalImported.TabIndex = 36;
    this.lblTotalImported.Text = "0";
    this.lblTotalImported.TextAlign = ContentAlignment.MiddleLeft;
    this.Label25.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label25_1 = this.Label25;
    point1 = new System.Drawing.Point(11, 81);
    System.Drawing.Point point16 = point1;
    label25_1.Location = point16;
    this.Label25.Name = "Label25";
    System.Windows.Forms.Label label25_2 = this.Label25;
    size1 = new Size(158, 24);
    Size size17 = size1;
    label25_2.Size = size17;
    this.Label25.TabIndex = 35;
    this.Label25.Text = "Mapped Records";
    this.Label25.TextAlign = ContentAlignment.MiddleRight;
    this.Label24.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label24_1 = this.Label24;
    point1 = new System.Drawing.Point(19, 50);
    System.Drawing.Point point17 = point1;
    label24_1.Location = point17;
    this.Label24.Name = "Label24";
    System.Windows.Forms.Label label24_2 = this.Label24;
    size1 = new Size(150, 24);
    Size size18 = size1;
    label24_2.Size = size18;
    this.Label24.TabIndex = 34;
    this.Label24.Text = "Valid Records";
    this.Label24.TextAlign = ContentAlignment.MiddleRight;
    this.Label23.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label23_1 = this.Label23;
    point1 = new System.Drawing.Point(11, 19);
    System.Drawing.Point point18 = point1;
    label23_1.Location = point18;
    this.Label23.Name = "Label23";
    System.Windows.Forms.Label label23_2 = this.Label23;
    size1 = new Size(158, 24);
    Size size19 = size1;
    label23_2.Size = size19;
    this.Label23.TabIndex = 33;
    this.Label23.Text = "Total Records Imported";
    this.Label23.TextAlign = ContentAlignment.MiddleRight;
    this.lblSheets.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblSheets1 = this.lblSheets;
    point1 = new System.Drawing.Point(18, 136);
    System.Drawing.Point point19 = point1;
    lblSheets1.Location = point19;
    this.lblSheets.Name = "lblSheets";
    System.Windows.Forms.Label lblSheets2 = this.lblSheets;
    size1 = new Size(130, 24);
    Size size20 = size1;
    lblSheets2.Size = size20;
    this.lblSheets.TabIndex = 38;
    this.lblSheets.Text = "Select Import Sheet";
    this.lblSheets.TextAlign = ContentAlignment.MiddleRight;
    this.lblSheets.Visible = false;
    this.lstSheets.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.lstSheets.BackColor = Color.Khaki;
    this.lstSheets.BorderStyle = BorderStyle.FixedSingle;
    this.lstSheets.DrawMode = DrawMode.OwnerDrawFixed;
    this.lstSheets.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lstSheets.FormattingEnabled = true;
    this.lstSheets.ItemHeight = 15;
    System.Windows.Forms.ListBox lstSheets1 = this.lstSheets;
    point1 = new System.Drawing.Point(154, 136);
    System.Drawing.Point point20 = point1;
    lstSheets1.Location = point20;
    this.lstSheets.Name = "lstSheets";
    System.Windows.Forms.ListBox lstSheets2 = this.lstSheets;
    size1 = new Size(489, 92);
    Size size21 = size1;
    lstSheets2.Size = size21;
    this.lstSheets.TabIndex = 37;
    this.lstSheets.Visible = false;
    this.cmdImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.cmdImport.AutoEllipsis = true;
    this.cmdImport.BackColor = Color.Khaki;
    this.cmdImport.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdImport.Image = (Image) PriceChanger.My.Resources.Resources.next32;
    this.cmdImport.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdImport1 = this.cmdImport;
    point1 = new System.Drawing.Point(649, 136);
    System.Drawing.Point point21 = point1;
    cmdImport1.Location = point21;
    this.cmdImport.Name = "cmdImport";
    System.Windows.Forms.Button cmdImport2 = this.cmdImport;
    size1 = new Size(96 /*0x60*/, 34);
    Size size22 = size1;
    cmdImport2.Size = size22;
    this.cmdImport.TabIndex = 35;
    this.cmdImport.Text = "Import";
    this.cmdImport.TextAlign = ContentAlignment.MiddleRight;
    this.cmdImport.UseVisualStyleBackColor = false;
    this.lblTemplateName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.lblTemplateName.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblTemplateName1 = this.lblTemplateName;
    point1 = new System.Drawing.Point(2, 51);
    System.Drawing.Point point22 = point1;
    lblTemplateName1.Location = point22;
    this.lblTemplateName.Name = "lblTemplateName";
    System.Windows.Forms.Label lblTemplateName2 = this.lblTemplateName;
    size1 = new Size(775, 26);
    Size size23 = size1;
    lblTemplateName2.Size = size23;
    this.lblTemplateName.TabIndex = 34;
    this.lblTemplateName.Text = "Template Name:";
    this.lblTemplateName.TextAlign = ContentAlignment.MiddleCenter;
    this.cmdBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.cmdBrowse.AutoEllipsis = true;
    this.cmdBrowse.BackColor = Color.Khaki;
    this.cmdBrowse.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdBrowse.Image = (Image) PriceChanger.My.Resources.Resources.search1;
    this.cmdBrowse.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdBrowse1 = this.cmdBrowse;
    point1 = new System.Drawing.Point(751, 101);
    System.Drawing.Point point23 = point1;
    cmdBrowse1.Location = point23;
    this.cmdBrowse.Name = "cmdBrowse";
    System.Windows.Forms.Button cmdBrowse2 = this.cmdBrowse;
    size1 = new Size(26, 24);
    Size size24 = size1;
    cmdBrowse2.Size = size24;
    this.cmdBrowse.TabIndex = 33;
    this.ToolTip1.SetToolTip((Control) this.cmdBrowse, "Browse for file");
    this.cmdBrowse.UseVisualStyleBackColor = false;
    this.txtImport.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtImport.BackColor = Color.Khaki;
    this.txtImport.BorderStyle = BorderStyle.FixedSingle;
    this.txtImport.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtImport1 = this.txtImport;
    point1 = new System.Drawing.Point(154, 101);
    System.Drawing.Point point24 = point1;
    txtImport1.Location = point24;
    this.txtImport.MaxLength = 20;
    this.txtImport.Name = "txtImport";
    System.Windows.Forms.TextBox txtImport2 = this.txtImport;
    size1 = new Size(591, 24);
    Size size25 = size1;
    txtImport2.Size = size25;
    this.txtImport.TabIndex = 31 /*0x1F*/;
    this.Label22.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label22_1 = this.Label22;
    point1 = new System.Drawing.Point(32 /*0x20*/, 101);
    System.Drawing.Point point25 = point1;
    label22_1.Location = point25;
    this.Label22.Name = "Label22";
    System.Windows.Forms.Label label22_2 = this.Label22;
    size1 = new Size(116, 24);
    Size size26 = size1;
    label22_2.Size = size26;
    this.Label22.TabIndex = 32 /*0x20*/;
    this.Label22.Text = "Select Import File";
    this.Label22.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label1.Font = new System.Drawing.Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label1_1 = this.Label1;
    point1 = new System.Drawing.Point(2, 13);
    System.Drawing.Point point26 = point1;
    label1_1.Location = point26;
    this.Label1.Name = "Label1";
    System.Windows.Forms.Label label1_2 = this.Label1;
    size1 = new Size(775, 26);
    Size size27 = size1;
    label1_2.Size = size27;
    this.Label1.TabIndex = 2;
    this.Label1.Text = "Import Files";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    this.tpTemplates.BackColor = Color.Beige;
    this.tpTemplates.Controls.Add((Control) this.chkStandard);
    this.tpTemplates.Controls.Add((Control) this.txtEmail);
    this.tpTemplates.Controls.Add((Control) this.Label28);
    this.tpTemplates.Controls.Add((Control) this.txtNotes);
    this.tpTemplates.Controls.Add((Control) this.Label20);
    this.tpTemplates.Controls.Add((Control) this.txtPriceList);
    this.tpTemplates.Controls.Add((Control) this.txtSupplierCode);
    this.tpTemplates.Controls.Add((Control) this.Label19);
    this.tpTemplates.Controls.Add((Control) this.Label18);
    this.tpTemplates.Controls.Add((Control) this.Label17);
    this.tpTemplates.Controls.Add((Control) this.Label16);
    this.tpTemplates.Controls.Add((Control) this.Label14);
    this.tpTemplates.Controls.Add((Control) this.cboCalcPrice1);
    this.tpTemplates.Controls.Add((Control) this.cboCalcPrice2);
    this.tpTemplates.Controls.Add((Control) this.cboCalcPrice3);
    this.tpTemplates.Controls.Add((Control) this.cboSuppProduct);
    this.tpTemplates.Controls.Add((Control) this.cboIIHFProductCode);
    this.tpTemplates.Controls.Add((Control) this.txtTemplateName);
    this.tpTemplates.Controls.Add((Control) this.txtSP);
    this.tpTemplates.Controls.Add((Control) this.Label13);
    this.tpTemplates.Controls.Add((Control) this.Label12);
    this.tpTemplates.Controls.Add((Control) this.Label11);
    this.tpTemplates.Controls.Add((Control) this.Label10);
    this.tpTemplates.Controls.Add((Control) this.chkProductMapping);
    this.tpTemplates.Controls.Add((Control) this.Label9);
    this.tpTemplates.Controls.Add((Control) this.chkSterling);
    this.tpTemplates.Controls.Add((Control) this.chkEuro);
    this.tpTemplates.Controls.Add((Control) this.chkGross);
    this.tpTemplates.Controls.Add((Control) this.chkNet);
    this.tpTemplates.Controls.Add((Control) this.Label8);
    this.tpTemplates.Controls.Add((Control) this.Label7);
    this.tpTemplates.Controls.Add((Control) this.Label5);
    this.tpTemplates.Controls.Add((Control) this.Label6);
    this.tpTemplates.Controls.Add((Control) this.Label2);
    this.tpTemplates.Controls.Add((Control) this.cmdSearchPriceList);
    this.tpTemplates.Controls.Add((Control) this.cmdSearchSupplier);
    this.tpTemplates.Controls.Add((Control) this.cmdDelete);
    this.tpTemplates.Controls.Add((Control) this.cmdSaveTemplate);
    TabPage tpTemplates1 = this.tpTemplates;
    point1 = new System.Drawing.Point(4, 21);
    System.Drawing.Point point27 = point1;
    tpTemplates1.Location = point27;
    this.tpTemplates.Name = "tpTemplates";
    TabPage tpTemplates2 = this.tpTemplates;
    padding1 = new System.Windows.Forms.Padding(3);
    System.Windows.Forms.Padding padding3 = padding1;
    tpTemplates2.Padding = padding3;
    TabPage tpTemplates3 = this.tpTemplates;
    size1 = new Size(798, 615);
    Size size28 = size1;
    tpTemplates3.Size = size28;
    this.tpTemplates.TabIndex = 1;
    this.tpTemplates.Text = "Templates";
    this.chkStandard.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkStandard1 = this.chkStandard;
    point1 = new System.Drawing.Point(57, 75);
    System.Drawing.Point point28 = point1;
    chkStandard1.Location = point28;
    this.chkStandard.Name = "chkStandard";
    this.chkStandard.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkStandard2 = this.chkStandard;
    size1 = new Size(177, 24);
    Size size29 = size1;
    chkStandard2.Size = size29;
    this.chkStandard.TabIndex = 36;
    this.chkStandard.Text = "Standard Template Export ";
    this.chkStandard.TextAlign = ContentAlignment.MiddleRight;
    this.chkStandard.UseVisualStyleBackColor = true;
    this.txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtEmail.BackColor = Color.Khaki;
    this.txtEmail.BorderStyle = BorderStyle.FixedSingle;
    this.txtEmail.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtEmail1 = this.txtEmail;
    point1 = new System.Drawing.Point(221, 531);
    System.Drawing.Point point29 = point1;
    txtEmail1.Location = point29;
    this.txtEmail.MaxLength = (int) byte.MaxValue;
    this.txtEmail.Name = "txtEmail";
    System.Windows.Forms.TextBox txtEmail2 = this.txtEmail;
    size1 = new Size(564, 24);
    Size size30 = size1;
    txtEmail2.Size = size30;
    this.txtEmail.TabIndex = 35;
    this.Label28.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label28_1 = this.Label28;
    point1 = new System.Drawing.Point(134, 530);
    System.Drawing.Point point30 = point1;
    label28_1.Location = point30;
    this.Label28.Name = "Label28";
    System.Windows.Forms.Label label28_2 = this.Label28;
    size1 = new Size(65, 24);
    Size size31 = size1;
    label28_2.Size = size31;
    this.Label28.TabIndex = 34;
    this.Label28.Text = "eMail";
    this.Label28.TextAlign = ContentAlignment.MiddleRight;
    this.txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtNotes.BackColor = Color.Khaki;
    this.txtNotes.BorderStyle = BorderStyle.FixedSingle;
    this.txtNotes.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtNotes1 = this.txtNotes;
    point1 = new System.Drawing.Point(221, 474);
    System.Drawing.Point point31 = point1;
    txtNotes1.Location = point31;
    this.txtNotes.MaxLength = (int) byte.MaxValue;
    this.txtNotes.Multiline = true;
    this.txtNotes.Name = "txtNotes";
    System.Windows.Forms.TextBox txtNotes2 = this.txtNotes;
    size1 = new Size(564, 51);
    Size size32 = size1;
    txtNotes2.Size = size32;
    this.txtNotes.TabIndex = 33;
    this.Label20.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label20_1 = this.Label20;
    point1 = new System.Drawing.Point(48 /*0x30*/, 473);
    System.Drawing.Point point32 = point1;
    label20_1.Location = point32;
    this.Label20.Name = "Label20";
    System.Windows.Forms.Label label20_2 = this.Label20;
    size1 = new Size(151, 24);
    Size size33 = size1;
    label20_2.Size = size33;
    this.Label20.TabIndex = 32 /*0x20*/;
    this.Label20.Text = "Notes";
    this.Label20.TextAlign = ContentAlignment.MiddleRight;
    this.txtPriceList.BackColor = Color.Khaki;
    this.txtPriceList.BorderStyle = BorderStyle.FixedSingle;
    this.txtPriceList.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtPriceList1 = this.txtPriceList;
    point1 = new System.Drawing.Point(221, 130);
    System.Drawing.Point point33 = point1;
    txtPriceList1.Location = point33;
    this.txtPriceList.MaxLength = 6;
    this.txtPriceList.Name = "txtPriceList";
    System.Windows.Forms.TextBox txtPriceList2 = this.txtPriceList;
    size1 = new Size(93, 24);
    Size size34 = size1;
    txtPriceList2.Size = size34;
    this.txtPriceList.TabIndex = 2;
    this.txtSupplierCode.BackColor = Color.Khaki;
    this.txtSupplierCode.BorderStyle = BorderStyle.FixedSingle;
    this.txtSupplierCode.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtSupplierCode1 = this.txtSupplierCode;
    point1 = new System.Drawing.Point(221, 102);
    System.Drawing.Point point34 = point1;
    txtSupplierCode1.Location = point34;
    this.txtSupplierCode.MaxLength = 20;
    this.txtSupplierCode.Name = "txtSupplierCode";
    System.Windows.Forms.TextBox txtSupplierCode2 = this.txtSupplierCode;
    size1 = new Size(93, 24);
    Size size35 = size1;
    txtSupplierCode2.Size = size35;
    this.txtSupplierCode.TabIndex = 1;
    this.Label19.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label19_1 = this.Label19;
    point1 = new System.Drawing.Point(274, 329);
    System.Drawing.Point point35 = point1;
    label19_1.Location = point35;
    this.Label19.Name = "Label19";
    System.Windows.Forms.Label label19_2 = this.Label19;
    size1 = new Size(151, 24);
    Size size36 = size1;
    label19_2.Size = size36;
    this.Label19.TabIndex = 29;
    this.Label19.Text = "Select from spreadsheet";
    this.Label19.TextAlign = ContentAlignment.MiddleLeft;
    this.Label18.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label18_1 = this.Label18;
    point1 = new System.Drawing.Point(274, 355);
    System.Drawing.Point point36 = point1;
    label18_1.Location = point36;
    this.Label18.Name = "Label18";
    System.Windows.Forms.Label label18_2 = this.Label18;
    size1 = new Size(151, 24);
    Size size37 = size1;
    label18_2.Size = size37;
    this.Label18.TabIndex = 28;
    this.Label18.Text = "Select from spreadsheet";
    this.Label18.TextAlign = ContentAlignment.MiddleLeft;
    this.Label17.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label17_1 = this.Label17;
    point1 = new System.Drawing.Point(274, 383);
    System.Drawing.Point point37 = point1;
    label17_1.Location = point37;
    this.Label17.Name = "Label17";
    System.Windows.Forms.Label label17_2 = this.Label17;
    size1 = new Size(151, 24);
    Size size38 = size1;
    label17_2.Size = size38;
    this.Label17.TabIndex = 27;
    this.Label17.Text = "Select from spreadsheet";
    this.Label17.TextAlign = ContentAlignment.MiddleLeft;
    this.Label16.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label16_1 = this.Label16;
    point1 = new System.Drawing.Point(274, 407);
    System.Drawing.Point point38 = point1;
    label16_1.Location = point38;
    this.Label16.Name = "Label16";
    System.Windows.Forms.Label label16_2 = this.Label16;
    size1 = new Size(151, 24);
    Size size39 = size1;
    label16_2.Size = size39;
    this.Label16.TabIndex = 26;
    this.Label16.Text = "Select from spreadsheet";
    this.Label16.TextAlign = ContentAlignment.MiddleLeft;
    this.Label14.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label14_1 = this.Label14;
    point1 = new System.Drawing.Point(274, 297);
    System.Drawing.Point point39 = point1;
    label14_1.Location = point39;
    this.Label14.Name = "Label14";
    System.Windows.Forms.Label label14_2 = this.Label14;
    size1 = new Size(151, 24);
    Size size40 = size1;
    label14_2.Size = size40;
    this.Label14.TabIndex = 24;
    this.Label14.Text = "Select from spreadsheet";
    this.Label14.TextAlign = ContentAlignment.MiddleLeft;
    this.cboCalcPrice1.BackColor = Color.Khaki;
    this.cboCalcPrice1.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cboCalcPrice1.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cboCalcPrice1.FormattingEnabled = true;
    this.cboCalcPrice1.Items.AddRange(new object[27]
    {
      (object) "",
      (object) "A",
      (object) "B",
      (object) "C",
      (object) "D",
      (object) "E",
      (object) "F",
      (object) "G",
      (object) "H",
      (object) "I",
      (object) "J",
      (object) "K",
      (object) "L",
      (object) "M",
      (object) "N",
      (object) "O",
      (object) "P",
      (object) "Q",
      (object) "R",
      (object) "S",
      (object) "T",
      (object) "U",
      (object) "V",
      (object) "W",
      (object) "X",
      (object) "Y",
      (object) "Z"
    });
    ComboBox cboCalcPrice1_1 = this.cboCalcPrice1;
    point1 = new System.Drawing.Point(221, 354);
    System.Drawing.Point point40 = point1;
    cboCalcPrice1_1.Location = point40;
    this.cboCalcPrice1.Name = "cboCalcPrice1";
    ComboBox cboCalcPrice1_2 = this.cboCalcPrice1;
    size1 = new Size(47, 23);
    Size size41 = size1;
    cboCalcPrice1_2.Size = size41;
    this.cboCalcPrice1.TabIndex = 10;
    this.cboCalcPrice2.BackColor = Color.Khaki;
    this.cboCalcPrice2.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cboCalcPrice2.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cboCalcPrice2.FormattingEnabled = true;
    this.cboCalcPrice2.Items.AddRange(new object[27]
    {
      (object) "",
      (object) "A",
      (object) "B",
      (object) "C",
      (object) "D",
      (object) "E",
      (object) "F",
      (object) "G",
      (object) "H",
      (object) "I",
      (object) "J",
      (object) "K",
      (object) "L",
      (object) "M",
      (object) "N",
      (object) "O",
      (object) "P",
      (object) "Q",
      (object) "R",
      (object) "S",
      (object) "T",
      (object) "U",
      (object) "V",
      (object) "W",
      (object) "X",
      (object) "Y",
      (object) "Z"
    });
    ComboBox cboCalcPrice2_1 = this.cboCalcPrice2;
    point1 = new System.Drawing.Point(221, 382);
    System.Drawing.Point point41 = point1;
    cboCalcPrice2_1.Location = point41;
    this.cboCalcPrice2.Name = "cboCalcPrice2";
    ComboBox cboCalcPrice2_2 = this.cboCalcPrice2;
    size1 = new Size(47, 23);
    Size size42 = size1;
    cboCalcPrice2_2.Size = size42;
    this.cboCalcPrice2.TabIndex = 11;
    this.cboCalcPrice3.BackColor = Color.Khaki;
    this.cboCalcPrice3.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cboCalcPrice3.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cboCalcPrice3.FormattingEnabled = true;
    this.cboCalcPrice3.Items.AddRange(new object[27]
    {
      (object) "",
      (object) "A",
      (object) "B",
      (object) "C",
      (object) "D",
      (object) "E",
      (object) "F",
      (object) "G",
      (object) "H",
      (object) "I",
      (object) "J",
      (object) "K",
      (object) "L",
      (object) "M",
      (object) "N",
      (object) "O",
      (object) "P",
      (object) "Q",
      (object) "R",
      (object) "S",
      (object) "T",
      (object) "U",
      (object) "V",
      (object) "W",
      (object) "X",
      (object) "Y",
      (object) "Z"
    });
    ComboBox cboCalcPrice3_1 = this.cboCalcPrice3;
    point1 = new System.Drawing.Point(221, 410);
    System.Drawing.Point point42 = point1;
    cboCalcPrice3_1.Location = point42;
    this.cboCalcPrice3.Name = "cboCalcPrice3";
    ComboBox cboCalcPrice3_2 = this.cboCalcPrice3;
    size1 = new Size(47, 23);
    Size size43 = size1;
    cboCalcPrice3_2.Size = size43;
    this.cboCalcPrice3.TabIndex = 12;
    this.cboSuppProduct.BackColor = Color.Khaki;
    this.cboSuppProduct.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cboSuppProduct.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cboSuppProduct.FormattingEnabled = true;
    this.cboSuppProduct.Items.AddRange(new object[27]
    {
      (object) "",
      (object) "A",
      (object) "B",
      (object) "C",
      (object) "D",
      (object) "E",
      (object) "F",
      (object) "G",
      (object) "H",
      (object) "I",
      (object) "J",
      (object) "K",
      (object) "L",
      (object) "M",
      (object) "N",
      (object) "O",
      (object) "P",
      (object) "Q",
      (object) "R",
      (object) "S",
      (object) "T",
      (object) "U",
      (object) "V",
      (object) "W",
      (object) "X",
      (object) "Y",
      (object) "Z"
    });
    ComboBox cboSuppProduct1 = this.cboSuppProduct;
    point1 = new System.Drawing.Point(221, 298);
    System.Drawing.Point point43 = point1;
    cboSuppProduct1.Location = point43;
    this.cboSuppProduct.Name = "cboSuppProduct";
    ComboBox cboSuppProduct2 = this.cboSuppProduct;
    size1 = new Size(47, 23);
    Size size44 = size1;
    cboSuppProduct2.Size = size44;
    this.cboSuppProduct.TabIndex = 8;
    this.cboIIHFProductCode.BackColor = Color.Khaki;
    this.cboIIHFProductCode.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cboIIHFProductCode.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cboIIHFProductCode.FormattingEnabled = true;
    this.cboIIHFProductCode.Items.AddRange(new object[27]
    {
      (object) "",
      (object) "A",
      (object) "B",
      (object) "C",
      (object) "D",
      (object) "E",
      (object) "F",
      (object) "G",
      (object) "H",
      (object) "I",
      (object) "J",
      (object) "K",
      (object) "L",
      (object) "M",
      (object) "N",
      (object) "O",
      (object) "P",
      (object) "Q",
      (object) "R",
      (object) "S",
      (object) "T",
      (object) "U",
      (object) "V",
      (object) "W",
      (object) "X",
      (object) "Y",
      (object) "Z"
    });
    ComboBox cboIihfProductCode1 = this.cboIIHFProductCode;
    point1 = new System.Drawing.Point(221, 326);
    System.Drawing.Point point44 = point1;
    cboIihfProductCode1.Location = point44;
    this.cboIIHFProductCode.Name = "cboIIHFProductCode";
    ComboBox cboIihfProductCode2 = this.cboIIHFProductCode;
    size1 = new Size(47, 23);
    Size size45 = size1;
    cboIihfProductCode2.Size = size45;
    this.cboIIHFProductCode.TabIndex = 9;
    this.txtTemplateName.BackColor = Color.Khaki;
    this.txtTemplateName.BorderStyle = BorderStyle.FixedSingle;
    this.txtTemplateName.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtTemplateName1 = this.txtTemplateName;
    point1 = new System.Drawing.Point(221, 47);
    System.Drawing.Point point45 = point1;
    txtTemplateName1.Location = point45;
    this.txtTemplateName.MaxLength = 100;
    this.txtTemplateName.Name = "txtTemplateName";
    System.Windows.Forms.TextBox txtTemplateName2 = this.txtTemplateName;
    size1 = new Size(184, 24);
    Size size46 = size1;
    txtTemplateName2.Size = size46;
    this.txtTemplateName.TabIndex = 0;
    this.txtSP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtSP.BackColor = Color.Khaki;
    this.txtSP.BorderStyle = BorderStyle.FixedSingle;
    this.txtSP.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtSp1 = this.txtSP;
    point1 = new System.Drawing.Point(221, 444);
    System.Drawing.Point point46 = point1;
    txtSp1.Location = point46;
    this.txtSP.MaxLength = (int) byte.MaxValue;
    this.txtSP.Name = "txtSP";
    System.Windows.Forms.TextBox txtSp2 = this.txtSP;
    size1 = new Size(564, 24);
    Size size47 = size1;
    txtSp2.Size = size47;
    this.txtSP.TabIndex = 13;
    this.Label13.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label13_1 = this.Label13;
    point1 = new System.Drawing.Point(54, 382);
    System.Drawing.Point point47 = point1;
    label13_1.Location = point47;
    this.Label13.Name = "Label13";
    System.Windows.Forms.Label label13_2 = this.Label13;
    size1 = new Size(151, 24);
    Size size48 = size1;
    label13_2.Size = size48;
    this.Label13.TabIndex = 16 /*0x10*/;
    this.Label13.Text = "Calc Price 2";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    this.Label12.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label12_1 = this.Label12;
    point1 = new System.Drawing.Point(54, 410);
    System.Drawing.Point point48 = point1;
    label12_1.Location = point48;
    this.Label12.Name = "Label12";
    System.Windows.Forms.Label label12_2 = this.Label12;
    size1 = new Size(151, 24);
    Size size49 = size1;
    label12_2.Size = size49;
    this.Label12.TabIndex = 15;
    this.Label12.Text = "Calc Price 3";
    this.Label12.TextAlign = ContentAlignment.MiddleRight;
    this.Label11.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label11_1 = this.Label11;
    point1 = new System.Drawing.Point(54, 354);
    System.Drawing.Point point49 = point1;
    label11_1.Location = point49;
    this.Label11.Name = "Label11";
    System.Windows.Forms.Label label11_2 = this.Label11;
    size1 = new Size(151, 24);
    Size size50 = size1;
    label11_2.Size = size50;
    this.Label11.TabIndex = 14;
    this.Label11.Text = "Calc Price 1";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    this.Label10.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label10_1 = this.Label10;
    point1 = new System.Drawing.Point(48 /*0x30*/, 443);
    System.Drawing.Point point50 = point1;
    label10_1.Location = point50;
    this.Label10.Name = "Label10";
    System.Windows.Forms.Label label10_2 = this.Label10;
    size1 = new Size(151, 24);
    Size size51 = size1;
    label10_2.Size = size51;
    this.Label10.TabIndex = 13;
    this.Label10.Text = "Stored Procedure Name";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    this.chkProductMapping.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkProductMapping1 = this.chkProductMapping;
    point1 = new System.Drawing.Point(50, 157);
    System.Drawing.Point point51 = point1;
    chkProductMapping1.Location = point51;
    this.chkProductMapping.Name = "chkProductMapping";
    this.chkProductMapping.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkProductMapping2 = this.chkProductMapping;
    size1 = new Size(184, 24);
    Size size52 = size1;
    chkProductMapping2.Size = size52;
    this.chkProductMapping.TabIndex = 3;
    this.chkProductMapping.Text = "Product Mapping Required";
    this.chkProductMapping.TextAlign = ContentAlignment.MiddleRight;
    this.chkProductMapping.UseVisualStyleBackColor = true;
    this.Label9.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label9_1 = this.Label9;
    point1 = new System.Drawing.Point(54, 326);
    System.Drawing.Point point52 = point1;
    label9_1.Location = point52;
    this.Label9.Name = "Label9";
    System.Windows.Forms.Label label9_2 = this.Label9;
    size1 = new Size(151, 24);
    Size size53 = size1;
    label9_2.Size = size53;
    this.Label9.TabIndex = 11;
    this.Label9.Text = "IIHF Product Code";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    this.chkSterling.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkSterling1 = this.chkSterling;
    point1 = new System.Drawing.Point(150, 269);
    System.Drawing.Point point53 = point1;
    chkSterling1.Location = point53;
    this.chkSterling.Name = "chkSterling";
    this.chkSterling.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkSterling2 = this.chkSterling;
    size1 = new Size(84, 24);
    Size size54 = size1;
    chkSterling2.Size = size54;
    this.chkSterling.TabIndex = 7;
    this.chkSterling.Text = "Sterling";
    this.chkSterling.TextAlign = ContentAlignment.MiddleRight;
    this.chkSterling.UseVisualStyleBackColor = true;
    this.chkEuro.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkEuro1 = this.chkEuro;
    point1 = new System.Drawing.Point(169, 241);
    System.Drawing.Point point54 = point1;
    chkEuro1.Location = point54;
    this.chkEuro.Name = "chkEuro";
    this.chkEuro.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkEuro2 = this.chkEuro;
    size1 = new Size(65, 24);
    Size size55 = size1;
    chkEuro2.Size = size55;
    this.chkEuro.TabIndex = 6;
    this.chkEuro.Text = "Euro";
    this.chkEuro.TextAlign = ContentAlignment.MiddleRight;
    this.chkEuro.UseVisualStyleBackColor = true;
    this.chkGross.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkGross1 = this.chkGross;
    point1 = new System.Drawing.Point(169, 213);
    System.Drawing.Point point55 = point1;
    chkGross1.Location = point55;
    this.chkGross.Name = "chkGross";
    this.chkGross.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkGross2 = this.chkGross;
    size1 = new Size(65, 24);
    Size size56 = size1;
    chkGross2.Size = size56;
    this.chkGross.TabIndex = 5;
    this.chkGross.Text = "Gross";
    this.chkGross.TextAlign = ContentAlignment.MiddleRight;
    this.chkGross.UseVisualStyleBackColor = true;
    this.chkNet.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkNet1 = this.chkNet;
    point1 = new System.Drawing.Point(175, 185);
    System.Drawing.Point point56 = point1;
    chkNet1.Location = point56;
    this.chkNet.Name = "chkNet";
    this.chkNet.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkNet2 = this.chkNet;
    size1 = new Size(59, 24);
    Size size57 = size1;
    chkNet2.Size = size57;
    this.chkNet.TabIndex = 4;
    this.chkNet.Text = "Net";
    this.chkNet.TextAlign = ContentAlignment.MiddleRight;
    this.chkNet.UseVisualStyleBackColor = true;
    this.Label8.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label8_1 = this.Label8;
    point1 = new System.Drawing.Point(54, 298);
    System.Drawing.Point point57 = point1;
    label8_1.Location = point57;
    this.Label8.Name = "Label8";
    System.Windows.Forms.Label label8_2 = this.Label8;
    size1 = new Size(151, 24);
    Size size58 = size1;
    label8_2.Size = size58;
    this.Label8.TabIndex = 6;
    this.Label8.Text = "Supplier Product Code";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.Label7.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label7_1 = this.Label7;
    point1 = new System.Drawing.Point(77, 130);
    System.Drawing.Point point58 = point1;
    label7_1.Location = point58;
    this.Label7.Name = "Label7";
    System.Windows.Forms.Label label7_2 = this.Label7;
    size1 = new Size(128 /*0x80*/, 24);
    Size size59 = size1;
    label7_2.Size = size59;
    this.Label7.TabIndex = 5;
    this.Label7.Text = "Price List Number";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.Label5.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label5_1 = this.Label5;
    point1 = new System.Drawing.Point(77, 102);
    System.Drawing.Point point59 = point1;
    label5_1.Location = point59;
    this.Label5.Name = "Label5";
    System.Windows.Forms.Label label5_2 = this.Label5;
    size1 = new Size(128 /*0x80*/, 24);
    Size size60 = size1;
    label5_2.Size = size60;
    this.Label5.TabIndex = 4;
    this.Label5.Text = "Supplier Code";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.Label6.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label6_1 = this.Label6;
    point1 = new System.Drawing.Point(77, 47);
    System.Drawing.Point point60 = point1;
    label6_1.Location = point60;
    this.Label6.Name = "Label6";
    System.Windows.Forms.Label label6_2 = this.Label6;
    size1 = new Size(128 /*0x80*/, 24);
    Size size61 = size1;
    label6_2.Size = size61;
    this.Label6.TabIndex = 3;
    this.Label6.Text = "Template Name";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label2.Font = new System.Drawing.Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label2_1 = this.Label2;
    point1 = new System.Drawing.Point(6, 6);
    System.Drawing.Point point61 = point1;
    label2_1.Location = point61;
    this.Label2.Name = "Label2";
    System.Windows.Forms.Label label2_2 = this.Label2;
    size1 = new Size(738, 26);
    Size size62 = size1;
    label2_2.Size = size62;
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Manage Templates";
    this.Label2.TextAlign = ContentAlignment.MiddleCenter;
    this.cmdSearchPriceList.AutoEllipsis = true;
    this.cmdSearchPriceList.BackColor = Color.Khaki;
    this.cmdSearchPriceList.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdSearchPriceList.Image = (Image) PriceChanger.My.Resources.Resources.search1;
    this.cmdSearchPriceList.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdSearchPriceList1 = this.cmdSearchPriceList;
    point1 = new System.Drawing.Point(320, 130);
    System.Drawing.Point point62 = point1;
    cmdSearchPriceList1.Location = point62;
    this.cmdSearchPriceList.Name = "cmdSearchPriceList";
    System.Windows.Forms.Button cmdSearchPriceList2 = this.cmdSearchPriceList;
    size1 = new Size(26, 24);
    Size size63 = size1;
    cmdSearchPriceList2.Size = size63;
    this.cmdSearchPriceList.TabIndex = 31 /*0x1F*/;
    this.ToolTip1.SetToolTip((Control) this.cmdSearchPriceList, "Search for Price List");
    this.cmdSearchPriceList.UseVisualStyleBackColor = false;
    this.cmdSearchSupplier.AutoEllipsis = true;
    this.cmdSearchSupplier.BackColor = Color.Khaki;
    this.cmdSearchSupplier.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdSearchSupplier.Image = (Image) PriceChanger.My.Resources.Resources.search1;
    this.cmdSearchSupplier.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdSearchSupplier1 = this.cmdSearchSupplier;
    point1 = new System.Drawing.Point(320, 102);
    System.Drawing.Point point63 = point1;
    cmdSearchSupplier1.Location = point63;
    this.cmdSearchSupplier.Name = "cmdSearchSupplier";
    System.Windows.Forms.Button cmdSearchSupplier2 = this.cmdSearchSupplier;
    size1 = new Size(26, 24);
    Size size64 = size1;
    cmdSearchSupplier2.Size = size64;
    this.cmdSearchSupplier.TabIndex = 30;
    this.ToolTip1.SetToolTip((Control) this.cmdSearchSupplier, "Search for Supplier");
    this.cmdSearchSupplier.UseVisualStyleBackColor = false;
    this.cmdDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.cmdDelete.AutoEllipsis = true;
    this.cmdDelete.BackColor = Color.Khaki;
    this.cmdDelete.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdDelete.Image = (Image) PriceChanger.My.Resources.Resources.delete32;
    this.cmdDelete.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdDelete1 = this.cmdDelete;
    point1 = new System.Drawing.Point(587, 575);
    System.Drawing.Point point64 = point1;
    cmdDelete1.Location = point64;
    this.cmdDelete.Name = "cmdDelete";
    System.Windows.Forms.Button cmdDelete2 = this.cmdDelete;
    size1 = new Size(96 /*0x60*/, 34);
    Size size65 = size1;
    cmdDelete2.Size = size65;
    this.cmdDelete.TabIndex = 14;
    this.cmdDelete.Text = "          Delete";
    this.cmdDelete.UseVisualStyleBackColor = false;
    this.cmdSaveTemplate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.cmdSaveTemplate.AutoEllipsis = true;
    this.cmdSaveTemplate.BackColor = Color.Khaki;
    this.cmdSaveTemplate.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdSaveTemplate.Image = (Image) PriceChanger.My.Resources.Resources.accept32;
    this.cmdSaveTemplate.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdSaveTemplate1 = this.cmdSaveTemplate;
    point1 = new System.Drawing.Point(689, 573);
    System.Drawing.Point point65 = point1;
    cmdSaveTemplate1.Location = point65;
    this.cmdSaveTemplate.Name = "cmdSaveTemplate";
    System.Windows.Forms.Button cmdSaveTemplate2 = this.cmdSaveTemplate;
    size1 = new Size(96 /*0x60*/, 34);
    Size size66 = size1;
    cmdSaveTemplate2.Size = size66;
    this.cmdSaveTemplate.TabIndex = 15;
    this.cmdSaveTemplate.Text = "Save    ";
    this.cmdSaveTemplate.TextAlign = ContentAlignment.MiddleRight;
    this.cmdSaveTemplate.UseVisualStyleBackColor = false;
    this.tpSettings.BackColor = Color.Beige;
    this.tpSettings.Controls.Add((Control) this.txteMailSender);
    this.tpSettings.Controls.Add((Control) this.Label38);
    this.tpSettings.Controls.Add((Control) this.txteMailBody);
    this.tpSettings.Controls.Add((Control) this.Label34);
    this.tpSettings.Controls.Add((Control) this.txteMailSubject);
    this.tpSettings.Controls.Add((Control) this.Label31);
    this.tpSettings.Controls.Add((Control) this.txtExportLocation);
    this.tpSettings.Controls.Add((Control) this.Label30);
    this.tpSettings.Controls.Add((Control) this.txtBackupPath);
    this.tpSettings.Controls.Add((Control) this.Label4);
    this.tpSettings.Controls.Add((Control) this.txtExchRate);
    this.tpSettings.Controls.Add((Control) this.Label15);
    this.tpSettings.Controls.Add((Control) this.Label21);
    this.tpSettings.Controls.Add((Control) this.cmdBrowseExportFolder);
    this.tpSettings.Controls.Add((Control) this.cmdBrowseBackupFoler);
    this.tpSettings.Controls.Add((Control) this.cmdSaveSettings);
    TabPage tpSettings1 = this.tpSettings;
    point1 = new System.Drawing.Point(4, 21);
    System.Drawing.Point point66 = point1;
    tpSettings1.Location = point66;
    this.tpSettings.Name = "tpSettings";
    TabPage tpSettings2 = this.tpSettings;
    size1 = new Size(798, 615);
    Size size67 = size1;
    tpSettings2.Size = size67;
    this.tpSettings.TabIndex = 2;
    this.tpSettings.Text = "Settings";
    this.txteMailSender.BackColor = Color.Khaki;
    this.txteMailSender.BorderStyle = BorderStyle.FixedSingle;
    this.txteMailSender.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txteMailSender1 = this.txteMailSender;
    point1 = new System.Drawing.Point(188, 170);
    System.Drawing.Point point67 = point1;
    txteMailSender1.Location = point67;
    this.txteMailSender.MaxLength = 100;
    this.txteMailSender.Name = "txteMailSender";
    System.Windows.Forms.TextBox txteMailSender2 = this.txteMailSender;
    size1 = new Size(401, 24);
    Size size68 = size1;
    txteMailSender2.Size = size68;
    this.txteMailSender.TabIndex = 48 /*0x30*/;
    this.Label38.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label38_1 = this.Label38;
    point1 = new System.Drawing.Point(4, 170);
    System.Drawing.Point point68 = point1;
    label38_1.Location = point68;
    this.Label38.Name = "Label38";
    System.Windows.Forms.Label label38_2 = this.Label38;
    size1 = new Size(168, 24);
    Size size69 = size1;
    label38_2.Size = size69;
    this.Label38.TabIndex = 47;
    this.Label38.Text = "eMail Sender";
    this.Label38.TextAlign = ContentAlignment.MiddleRight;
    this.txteMailBody.BackColor = Color.Khaki;
    this.txteMailBody.BorderStyle = BorderStyle.FixedSingle;
    this.txteMailBody.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txteMailBody1 = this.txteMailBody;
    point1 = new System.Drawing.Point(188, 245);
    System.Drawing.Point point69 = point1;
    txteMailBody1.Location = point69;
    this.txteMailBody.MaxLength = 2000;
    this.txteMailBody.Multiline = true;
    this.txteMailBody.Name = "txteMailBody";
    System.Windows.Forms.TextBox txteMailBody2 = this.txteMailBody;
    size1 = new Size(401, 292);
    Size size70 = size1;
    txteMailBody2.Size = size70;
    this.txteMailBody.TabIndex = 46;
    this.Label34.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label34_1 = this.Label34;
    point1 = new System.Drawing.Point(4, 245);
    System.Drawing.Point point70 = point1;
    label34_1.Location = point70;
    this.Label34.Name = "Label34";
    System.Windows.Forms.Label label34_2 = this.Label34;
    size1 = new Size(168, 24);
    Size size71 = size1;
    label34_2.Size = size71;
    this.Label34.TabIndex = 45;
    this.Label34.Text = "eMail Content";
    this.Label34.TextAlign = ContentAlignment.MiddleRight;
    this.txteMailSubject.BackColor = Color.Khaki;
    this.txteMailSubject.BorderStyle = BorderStyle.FixedSingle;
    this.txteMailSubject.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txteMailSubject1 = this.txteMailSubject;
    point1 = new System.Drawing.Point(188, 206);
    System.Drawing.Point point71 = point1;
    txteMailSubject1.Location = point71;
    this.txteMailSubject.MaxLength = 100;
    this.txteMailSubject.Name = "txteMailSubject";
    System.Windows.Forms.TextBox txteMailSubject2 = this.txteMailSubject;
    size1 = new Size(401, 24);
    Size size72 = size1;
    txteMailSubject2.Size = size72;
    this.txteMailSubject.TabIndex = 44;
    this.Label31.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label31_1 = this.Label31;
    point1 = new System.Drawing.Point(4, 206);
    System.Drawing.Point point72 = point1;
    label31_1.Location = point72;
    this.Label31.Name = "Label31";
    System.Windows.Forms.Label label31_2 = this.Label31;
    size1 = new Size(168, 24);
    Size size73 = size1;
    label31_2.Size = size73;
    this.Label31.TabIndex = 43;
    this.Label31.Text = "eMail Subject";
    this.Label31.TextAlign = ContentAlignment.MiddleRight;
    this.txtExportLocation.BackColor = Color.Khaki;
    this.txtExportLocation.BorderStyle = BorderStyle.FixedSingle;
    this.txtExportLocation.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtExportLocation1 = this.txtExportLocation;
    point1 = new System.Drawing.Point(188, 135);
    System.Drawing.Point point73 = point1;
    txtExportLocation1.Location = point73;
    this.txtExportLocation.MaxLength = (int) byte.MaxValue;
    this.txtExportLocation.Name = "txtExportLocation";
    System.Windows.Forms.TextBox txtExportLocation2 = this.txtExportLocation;
    size1 = new Size(401, 24);
    Size size74 = size1;
    txtExportLocation2.Size = size74;
    this.txtExportLocation.TabIndex = 40;
    this.Label30.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label30_1 = this.Label30;
    point1 = new System.Drawing.Point(4, 135);
    System.Drawing.Point point74 = point1;
    label30_1.Location = point74;
    this.Label30.Name = "Label30";
    System.Windows.Forms.Label label30_2 = this.Label30;
    size1 = new Size(168, 24);
    Size size75 = size1;
    label30_2.Size = size75;
    this.Label30.TabIndex = 39;
    this.Label30.Text = "Export File Location";
    this.Label30.TextAlign = ContentAlignment.MiddleRight;
    this.txtBackupPath.BackColor = Color.Khaki;
    this.txtBackupPath.BorderStyle = BorderStyle.FixedSingle;
    this.txtBackupPath.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtBackupPath1 = this.txtBackupPath;
    point1 = new System.Drawing.Point(188, 94);
    System.Drawing.Point point75 = point1;
    txtBackupPath1.Location = point75;
    this.txtBackupPath.MaxLength = (int) byte.MaxValue;
    this.txtBackupPath.Name = "txtBackupPath";
    System.Windows.Forms.TextBox txtBackupPath2 = this.txtBackupPath;
    size1 = new Size(401, 24);
    Size size76 = size1;
    txtBackupPath2.Size = size76;
    this.txtBackupPath.TabIndex = 38;
    this.Label4.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label4_1 = this.Label4;
    point1 = new System.Drawing.Point(4, 94);
    System.Drawing.Point point76 = point1;
    label4_1.Location = point76;
    this.Label4.Name = "Label4";
    System.Windows.Forms.Label label4_2 = this.Label4;
    size1 = new Size(168, 24);
    Size size77 = size1;
    label4_2.Size = size77;
    this.Label4.TabIndex = 37;
    this.Label4.Text = "Database Backup Location";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.txtExchRate.BackColor = Color.Khaki;
    this.txtExchRate.BorderStyle = BorderStyle.FixedSingle;
    this.txtExchRate.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtExchRate1 = this.txtExchRate;
    point1 = new System.Drawing.Point(188, 59);
    System.Drawing.Point point77 = point1;
    txtExchRate1.Location = point77;
    this.txtExchRate.MaxLength = 20;
    this.txtExchRate.Name = "txtExchRate";
    System.Windows.Forms.TextBox txtExchRate2 = this.txtExchRate;
    size1 = new Size(93, 24);
    Size size78 = size1;
    txtExchRate2.Size = size78;
    this.txtExchRate.TabIndex = 35;
    this.Label15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label15.Font = new System.Drawing.Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label15_1 = this.Label15;
    point1 = new System.Drawing.Point(20, 13);
    System.Drawing.Point point78 = point1;
    label15_1.Location = point78;
    this.Label15.Name = "Label15";
    System.Windows.Forms.Label label15_2 = this.Label15;
    size1 = new Size(760, 26);
    Size size79 = size1;
    label15_2.Size = size79;
    this.Label15.TabIndex = 34;
    this.Label15.Text = "Manage Settings";
    this.Label15.TextAlign = ContentAlignment.MiddleCenter;
    this.Label21.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label21_1 = this.Label21;
    point1 = new System.Drawing.Point(21, 59);
    System.Drawing.Point point79 = point1;
    label21_1.Location = point79;
    this.Label21.Name = "Label21";
    System.Windows.Forms.Label label21_2 = this.Label21;
    size1 = new Size(151, 24);
    Size size80 = size1;
    label21_2.Size = size80;
    this.Label21.TabIndex = 33;
    this.Label21.Text = "Sterling Exchange Rate";
    this.Label21.TextAlign = ContentAlignment.MiddleRight;
    this.cmdBrowseExportFolder.AutoEllipsis = true;
    this.cmdBrowseExportFolder.BackColor = Color.Khaki;
    this.cmdBrowseExportFolder.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdBrowseExportFolder.Image = (Image) PriceChanger.My.Resources.Resources.search1;
    this.cmdBrowseExportFolder.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button browseExportFolder1 = this.cmdBrowseExportFolder;
    point1 = new System.Drawing.Point(595, 135);
    System.Drawing.Point point80 = point1;
    browseExportFolder1.Location = point80;
    this.cmdBrowseExportFolder.Name = "cmdBrowseExportFolder";
    System.Windows.Forms.Button browseExportFolder2 = this.cmdBrowseExportFolder;
    size1 = new Size(26, 24);
    Size size81 = size1;
    browseExportFolder2.Size = size81;
    this.cmdBrowseExportFolder.TabIndex = 42;
    this.ToolTip1.SetToolTip((Control) this.cmdBrowseExportFolder, "Browse for File Export Folder");
    this.cmdBrowseExportFolder.UseVisualStyleBackColor = false;
    this.cmdBrowseBackupFoler.AutoEllipsis = true;
    this.cmdBrowseBackupFoler.BackColor = Color.Khaki;
    this.cmdBrowseBackupFoler.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdBrowseBackupFoler.Image = (Image) PriceChanger.My.Resources.Resources.search1;
    this.cmdBrowseBackupFoler.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button browseBackupFoler1 = this.cmdBrowseBackupFoler;
    point1 = new System.Drawing.Point(595, 94);
    System.Drawing.Point point81 = point1;
    browseBackupFoler1.Location = point81;
    this.cmdBrowseBackupFoler.Name = "cmdBrowseBackupFoler";
    System.Windows.Forms.Button browseBackupFoler2 = this.cmdBrowseBackupFoler;
    size1 = new Size(26, 24);
    Size size82 = size1;
    browseBackupFoler2.Size = size82;
    this.cmdBrowseBackupFoler.TabIndex = 41;
    this.ToolTip1.SetToolTip((Control) this.cmdBrowseBackupFoler, "Browse for DB backup Folder");
    this.cmdBrowseBackupFoler.UseVisualStyleBackColor = false;
    this.cmdSaveSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.cmdSaveSettings.AutoEllipsis = true;
    this.cmdSaveSettings.BackColor = Color.Khaki;
    this.cmdSaveSettings.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdSaveSettings.Image = (Image) PriceChanger.My.Resources.Resources.accept32;
    this.cmdSaveSettings.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdSaveSettings1 = this.cmdSaveSettings;
    point1 = new System.Drawing.Point(684, 561);
    System.Drawing.Point point82 = point1;
    cmdSaveSettings1.Location = point82;
    this.cmdSaveSettings.Name = "cmdSaveSettings";
    System.Windows.Forms.Button cmdSaveSettings2 = this.cmdSaveSettings;
    size1 = new Size(96 /*0x60*/, 34);
    Size size83 = size1;
    cmdSaveSettings2.Size = size83;
    this.cmdSaveSettings.TabIndex = 36;
    this.cmdSaveSettings.Text = "Save    ";
    this.cmdSaveSettings.TextAlign = ContentAlignment.MiddleRight;
    this.ToolTip1.SetToolTip((Control) this.cmdSaveSettings, "Save Settings");
    this.cmdSaveSettings.UseVisualStyleBackColor = false;
    this.tpManage.BackColor = Color.Beige;
    this.tpManage.Controls.Add((Control) this.GroupBox4);
    this.tpManage.Controls.Add((Control) this.GroupBox1);
    this.tpManage.Controls.Add((Control) this.GroupBox2);
    this.tpManage.Controls.Add((Control) this.GroupBox3);
    this.tpManage.Controls.Add((Control) this.Label3);
    TabPage tpManage1 = this.tpManage;
    point1 = new System.Drawing.Point(4, 21);
    System.Drawing.Point point83 = point1;
    tpManage1.Location = point83;
    this.tpManage.Name = "tpManage";
    TabPage tpManage2 = this.tpManage;
    size1 = new Size(798, 646);
    Size size84 = size1;
    tpManage2.Size = size84;
    this.tpManage.TabIndex = 3;
    this.tpManage.Text = "Management";
    this.GroupBox4.Controls.Add((Control) this.lblLastRunDateCopyPending);
    this.GroupBox4.Controls.Add((Control) this.chkCopyPending);
    this.GroupBox4.Controls.Add((Control) this.chkIncludeDeleted);
    this.GroupBox4.Controls.Add((Control) this.chkDuplicateProducts);
    this.GroupBox4.Controls.Add((Control) this.cmdProductMaint);
    this.GroupBox4.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.GroupBox4.ForeColor = SystemColors.ControlText;
    System.Windows.Forms.GroupBox groupBox4_1 = this.GroupBox4;
    point1 = new System.Drawing.Point(23, 200);
    System.Drawing.Point point84 = point1;
    groupBox4_1.Location = point84;
    this.GroupBox4.Name = "GroupBox4";
    System.Windows.Forms.GroupBox groupBox4_2 = this.GroupBox4;
    size1 = new Size(463, 89);
    Size size85 = size1;
    groupBox4_2.Size = size85;
    this.GroupBox4.TabIndex = 45;
    this.GroupBox4.TabStop = false;
    this.GroupBox4.Text = "Product Maintenance";
    this.lblLastRunDateCopyPending.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label runDateCopyPending1 = this.lblLastRunDateCopyPending;
    point1 = new System.Drawing.Point(234, 50);
    System.Drawing.Point point85 = point1;
    runDateCopyPending1.Location = point85;
    this.lblLastRunDateCopyPending.Name = "lblLastRunDateCopyPending";
    System.Windows.Forms.Label runDateCopyPending2 = this.lblLastRunDateCopyPending;
    size1 = new Size(155, 24);
    Size size86 = size1;
    runDateCopyPending2.Size = size86;
    this.lblLastRunDateCopyPending.TabIndex = 143;
    this.lblLastRunDateCopyPending.Text = "Last run Date: ";
    this.lblLastRunDateCopyPending.TextAlign = ContentAlignment.MiddleLeft;
    this.chkCopyPending.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkCopyPending1 = this.chkCopyPending;
    point1 = new System.Drawing.Point(76, 50);
    System.Drawing.Point point86 = point1;
    chkCopyPending1.Location = point86;
    this.chkCopyPending.Name = "chkCopyPending";
    this.chkCopyPending.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkCopyPending2 = this.chkCopyPending;
    size1 = new Size(152, 24);
    Size size87 = size1;
    chkCopyPending2.Size = size87;
    this.chkCopyPending.TabIndex = 142;
    this.chkCopyPending.Text = "Copy to Pending File";
    this.chkCopyPending.TextAlign = ContentAlignment.MiddleRight;
    this.chkCopyPending.UseVisualStyleBackColor = true;
    this.chkIncludeDeleted.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkIncludeDeleted1 = this.chkIncludeDeleted;
    point1 = new System.Drawing.Point(234, 22);
    System.Drawing.Point point87 = point1;
    chkIncludeDeleted1.Location = point87;
    this.chkIncludeDeleted.Name = "chkIncludeDeleted";
    this.chkIncludeDeleted.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkIncludeDeleted2 = this.chkIncludeDeleted;
    size1 = new Size(166, 24);
    Size size88 = size1;
    chkIncludeDeleted2.Size = size88;
    this.chkIncludeDeleted.TabIndex = 141;
    this.chkIncludeDeleted.Text = "Show Previously Selected";
    this.chkIncludeDeleted.TextAlign = ContentAlignment.MiddleRight;
    this.chkIncludeDeleted.UseVisualStyleBackColor = true;
    this.chkDuplicateProducts.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox duplicateProducts1 = this.chkDuplicateProducts;
    point1 = new System.Drawing.Point(50, 22);
    System.Drawing.Point point88 = point1;
    duplicateProducts1.Location = point88;
    this.chkDuplicateProducts.Name = "chkDuplicateProducts";
    this.chkDuplicateProducts.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox duplicateProducts2 = this.chkDuplicateProducts;
    size1 = new Size(177, 24);
    Size size89 = size1;
    duplicateProducts2.Size = size89;
    this.chkDuplicateProducts.TabIndex = 140;
    this.chkDuplicateProducts.Text = "Review Duplicate Products";
    this.chkDuplicateProducts.TextAlign = ContentAlignment.MiddleRight;
    this.chkDuplicateProducts.UseVisualStyleBackColor = true;
    this.cmdProductMaint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.cmdProductMaint.AutoEllipsis = true;
    this.cmdProductMaint.BackColor = Color.Khaki;
    this.cmdProductMaint.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdProductMaint.Image = (Image) PriceChanger.My.Resources.Resources.next32;
    this.cmdProductMaint.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdProductMaint1 = this.cmdProductMaint;
    point1 = new System.Drawing.Point(395, 48 /*0x30*/);
    System.Drawing.Point point89 = point1;
    cmdProductMaint1.Location = point89;
    this.cmdProductMaint.Name = "cmdProductMaint";
    System.Windows.Forms.Button cmdProductMaint2 = this.cmdProductMaint;
    size1 = new Size(62, 34);
    Size size90 = size1;
    cmdProductMaint2.Size = size90;
    this.cmdProductMaint.TabIndex = 43;
    this.cmdProductMaint.Text = "Go";
    this.cmdProductMaint.TextAlign = ContentAlignment.MiddleRight;
    this.ToolTip1.SetToolTip((Control) this.cmdProductMaint, "Process Database Maintenance Options");
    this.cmdProductMaint.UseVisualStyleBackColor = false;
    this.GroupBox1.Controls.Add((Control) this.lblLastUpdatePOPPrices);
    this.GroupBox1.Controls.Add((Control) this.chkUpdatePOPPrices);
    this.GroupBox1.Controls.Add((Control) this.lblLastRunUpdateCostSellRetail);
    this.GroupBox1.Controls.Add((Control) this.chkUpdateCostSellretail);
    this.GroupBox1.Controls.Add((Control) this.lblLastRunOverwriteApprovedRetail);
    this.GroupBox1.Controls.Add((Control) this.lblLastRunOverwriteApprovedSell);
    this.GroupBox1.Controls.Add((Control) this.lblLastRunOverwriteApprovedCosts);
    this.GroupBox1.Controls.Add((Control) this.cmdProcessData);
    this.GroupBox1.Controls.Add((Control) this.chkOverwriteRetail);
    this.GroupBox1.Controls.Add((Control) this.chkOverwriteSell);
    this.GroupBox1.Controls.Add((Control) this.lblLastRunCalcRetail);
    this.GroupBox1.Controls.Add((Control) this.chkOverwriteCosts);
    this.GroupBox1.Controls.Add((Control) this.chkRecalcNewRetail);
    this.GroupBox1.Controls.Add((Control) this.lblLastRunNewSell);
    this.GroupBox1.Controls.Add((Control) this.chkRecalcNewSell);
    this.GroupBox1.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.GroupBox1.ForeColor = SystemColors.ControlText;
    System.Windows.Forms.GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new System.Drawing.Point(23, 295);
    System.Drawing.Point point90 = point1;
    groupBox1_1.Location = point90;
    this.GroupBox1.Name = "GroupBox1";
    System.Windows.Forms.GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(463, 220);
    Size size91 = size1;
    groupBox1_2.Size = size91;
    this.GroupBox1.TabIndex = 40;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Data Updates";
    this.lblLastRunOverwriteApprovedRetail.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label overwriteApprovedRetail1 = this.lblLastRunOverwriteApprovedRetail;
    point1 = new System.Drawing.Point(230, 134);
    System.Drawing.Point point91 = point1;
    overwriteApprovedRetail1.Location = point91;
    this.lblLastRunOverwriteApprovedRetail.Name = "lblLastRunOverwriteApprovedRetail";
    System.Windows.Forms.Label overwriteApprovedRetail2 = this.lblLastRunOverwriteApprovedRetail;
    size1 = new Size(155, 24);
    Size size92 = size1;
    overwriteApprovedRetail2.Size = size92;
    this.lblLastRunOverwriteApprovedRetail.TabIndex = 50;
    this.lblLastRunOverwriteApprovedRetail.Text = "Last run Date: ";
    this.lblLastRunOverwriteApprovedRetail.TextAlign = ContentAlignment.MiddleLeft;
    this.lblLastRunOverwriteApprovedSell.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label overwriteApprovedSell1 = this.lblLastRunOverwriteApprovedSell;
    point1 = new System.Drawing.Point(230, 78);
    System.Drawing.Point point92 = point1;
    overwriteApprovedSell1.Location = point92;
    this.lblLastRunOverwriteApprovedSell.Name = "lblLastRunOverwriteApprovedSell";
    System.Windows.Forms.Label overwriteApprovedSell2 = this.lblLastRunOverwriteApprovedSell;
    size1 = new Size(139, 24);
    Size size93 = size1;
    overwriteApprovedSell2.Size = size93;
    this.lblLastRunOverwriteApprovedSell.TabIndex = 49;
    this.lblLastRunOverwriteApprovedSell.Text = "Last run Date: ";
    this.lblLastRunOverwriteApprovedSell.TextAlign = ContentAlignment.MiddleLeft;
    this.lblLastRunOverwriteApprovedCosts.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label overwriteApprovedCosts1 = this.lblLastRunOverwriteApprovedCosts;
    point1 = new System.Drawing.Point(230, 22);
    System.Drawing.Point point93 = point1;
    overwriteApprovedCosts1.Location = point93;
    this.lblLastRunOverwriteApprovedCosts.Name = "lblLastRunOverwriteApprovedCosts";
    System.Windows.Forms.Label overwriteApprovedCosts2 = this.lblLastRunOverwriteApprovedCosts;
    size1 = new Size(139, 24);
    Size size94 = size1;
    overwriteApprovedCosts2.Size = size94;
    this.lblLastRunOverwriteApprovedCosts.TabIndex = 48 /*0x30*/;
    this.lblLastRunOverwriteApprovedCosts.Text = "Last run Date: ";
    this.lblLastRunOverwriteApprovedCosts.TextAlign = ContentAlignment.MiddleLeft;
    this.cmdProcessData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.cmdProcessData.AutoEllipsis = true;
    this.cmdProcessData.BackColor = Color.Khaki;
    this.cmdProcessData.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdProcessData.Image = (Image) PriceChanger.My.Resources.Resources.next32;
    this.cmdProcessData.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdProcessData1 = this.cmdProcessData;
    point1 = new System.Drawing.Point(395, 180);
    System.Drawing.Point point94 = point1;
    cmdProcessData1.Location = point94;
    this.cmdProcessData.Name = "cmdProcessData";
    System.Windows.Forms.Button cmdProcessData2 = this.cmdProcessData;
    size1 = new Size(62, 34);
    Size size95 = size1;
    cmdProcessData2.Size = size95;
    this.cmdProcessData.TabIndex = 47;
    this.cmdProcessData.Text = "Go";
    this.cmdProcessData.TextAlign = ContentAlignment.MiddleRight;
    this.ToolTip1.SetToolTip((Control) this.cmdProcessData, "Process Data Update Options");
    this.cmdProcessData.UseVisualStyleBackColor = false;
    this.chkOverwriteRetail.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkOverwriteRetail1 = this.chkOverwriteRetail;
    point1 = new System.Drawing.Point(14, 134);
    System.Drawing.Point point95 = point1;
    chkOverwriteRetail1.Location = point95;
    this.chkOverwriteRetail.Name = "chkOverwriteRetail";
    this.chkOverwriteRetail.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkOverwriteRetail2 = this.chkOverwriteRetail;
    size1 = new Size(210, 24);
    Size size96 = size1;
    chkOverwriteRetail2.Size = size96;
    this.chkOverwriteRetail.TabIndex = 46;
    this.chkOverwriteRetail.Text = "Overwrite with Approved Retail";
    this.chkOverwriteRetail.TextAlign = ContentAlignment.MiddleRight;
    this.chkOverwriteRetail.UseVisualStyleBackColor = true;
    this.chkOverwriteSell.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkOverwriteSell1 = this.chkOverwriteSell;
    point1 = new System.Drawing.Point(30, 78);
    System.Drawing.Point point96 = point1;
    chkOverwriteSell1.Location = point96;
    this.chkOverwriteSell.Name = "chkOverwriteSell";
    this.chkOverwriteSell.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkOverwriteSell2 = this.chkOverwriteSell;
    size1 = new Size(194, 24);
    Size size97 = size1;
    chkOverwriteSell2.Size = size97;
    this.chkOverwriteSell.TabIndex = 45;
    this.chkOverwriteSell.Text = "Overwrite with Approved Sell";
    this.chkOverwriteSell.TextAlign = ContentAlignment.MiddleRight;
    this.chkOverwriteSell.UseVisualStyleBackColor = true;
    this.lblLastRunCalcRetail.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lastRunCalcRetail1 = this.lblLastRunCalcRetail;
    point1 = new System.Drawing.Point(230, 106);
    System.Drawing.Point point97 = point1;
    lastRunCalcRetail1.Location = point97;
    this.lblLastRunCalcRetail.Name = "lblLastRunCalcRetail";
    System.Windows.Forms.Label lastRunCalcRetail2 = this.lblLastRunCalcRetail;
    size1 = new Size(139, 24);
    Size size98 = size1;
    lastRunCalcRetail2.Size = size98;
    this.lblLastRunCalcRetail.TabIndex = 44;
    this.lblLastRunCalcRetail.Text = "Last run Date: ";
    this.lblLastRunCalcRetail.TextAlign = ContentAlignment.MiddleLeft;
    this.chkOverwriteCosts.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkOverwriteCosts1 = this.chkOverwriteCosts;
    point1 = new System.Drawing.Point(18, 22);
    System.Drawing.Point point98 = point1;
    chkOverwriteCosts1.Location = point98;
    this.chkOverwriteCosts.Name = "chkOverwriteCosts";
    this.chkOverwriteCosts.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkOverwriteCosts2 = this.chkOverwriteCosts;
    size1 = new Size(206, 24);
    Size size99 = size1;
    chkOverwriteCosts2.Size = size99;
    this.chkOverwriteCosts.TabIndex = 41;
    this.chkOverwriteCosts.Text = "Overwrite with Approved Costs";
    this.chkOverwriteCosts.TextAlign = ContentAlignment.MiddleRight;
    this.chkOverwriteCosts.UseVisualStyleBackColor = true;
    this.chkRecalcNewRetail.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkRecalcNewRetail1 = this.chkRecalcNewRetail;
    point1 = new System.Drawing.Point(72, 106);
    System.Drawing.Point point99 = point1;
    chkRecalcNewRetail1.Location = point99;
    this.chkRecalcNewRetail.Name = "chkRecalcNewRetail";
    this.chkRecalcNewRetail.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkRecalcNewRetail2 = this.chkRecalcNewRetail;
    size1 = new Size(152, 24);
    Size size100 = size1;
    chkRecalcNewRetail2.Size = size100;
    this.chkRecalcNewRetail.TabIndex = 43;
    this.chkRecalcNewRetail.Text = "Recalc New Retail";
    this.chkRecalcNewRetail.TextAlign = ContentAlignment.MiddleCenter;
    this.chkRecalcNewRetail.UseVisualStyleBackColor = true;
    this.lblLastRunNewSell.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblLastRunNewSell1 = this.lblLastRunNewSell;
    point1 = new System.Drawing.Point(230, 51);
    System.Drawing.Point point100 = point1;
    lblLastRunNewSell1.Location = point100;
    this.lblLastRunNewSell.Name = "lblLastRunNewSell";
    System.Windows.Forms.Label lblLastRunNewSell2 = this.lblLastRunNewSell;
    size1 = new Size(139, 24);
    Size size101 = size1;
    lblLastRunNewSell2.Size = size101;
    this.lblLastRunNewSell.TabIndex = 42;
    this.lblLastRunNewSell.Text = "Last run Date: ";
    this.lblLastRunNewSell.TextAlign = ContentAlignment.MiddleLeft;
    this.chkRecalcNewSell.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkRecalcNewSell1 = this.chkRecalcNewSell;
    point1 = new System.Drawing.Point(90, 50);
    System.Drawing.Point point101 = point1;
    chkRecalcNewSell1.Location = point101;
    this.chkRecalcNewSell.Name = "chkRecalcNewSell";
    this.chkRecalcNewSell.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkRecalcNewSell2 = this.chkRecalcNewSell;
    size1 = new Size(134, 24);
    Size size102 = size1;
    chkRecalcNewSell2.Size = size102;
    this.chkRecalcNewSell.TabIndex = 41;
    this.chkRecalcNewSell.Text = "Recalc New Sell";
    this.chkRecalcNewSell.TextAlign = ContentAlignment.MiddleCenter;
    this.chkRecalcNewSell.UseVisualStyleBackColor = true;
    this.GroupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.GroupBox2.Controls.Add((Control) this.cmdImportApproved);
    this.GroupBox2.Controls.Add((Control) this.radSell);
    this.GroupBox2.Controls.Add((Control) this.radRetail);
    this.GroupBox2.Controls.Add((Control) this.radCost);
    this.GroupBox2.Controls.Add((Control) this.cmdBrowseApprovedPrices);
    this.GroupBox2.Controls.Add((Control) this.txtImportApproved);
    this.GroupBox2.Controls.Add((Control) this.Label27);
    this.GroupBox2.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.GroupBox2.ForeColor = SystemColors.ControlText;
    System.Windows.Forms.GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new System.Drawing.Point(8, 540);
    System.Drawing.Point point102 = point1;
    groupBox2_1.Location = point102;
    this.GroupBox2.Name = "GroupBox2";
    System.Windows.Forms.GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(771, 98);
    Size size103 = size1;
    groupBox2_2.Size = size103;
    this.GroupBox2.TabIndex = 44;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Import Approved Files";
    this.cmdImportApproved.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.cmdImportApproved.AutoEllipsis = true;
    this.cmdImportApproved.BackColor = Color.Khaki;
    this.cmdImportApproved.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdImportApproved.Image = (Image) PriceChanger.My.Resources.Resources.next22;
    this.cmdImportApproved.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdImportApproved1 = this.cmdImportApproved;
    point1 = new System.Drawing.Point(637, 63 /*0x3F*/);
    System.Drawing.Point point103 = point1;
    cmdImportApproved1.Location = point103;
    this.cmdImportApproved.Name = "cmdImportApproved";
    System.Windows.Forms.Button cmdImportApproved2 = this.cmdImportApproved;
    size1 = new Size(96 /*0x60*/, 27);
    Size size104 = size1;
    cmdImportApproved2.Size = size104;
    this.cmdImportApproved.TabIndex = 42;
    this.cmdImportApproved.Text = "Import";
    this.cmdImportApproved.TextAlign = ContentAlignment.MiddleRight;
    this.cmdImportApproved.UseVisualStyleBackColor = false;
    this.radSell.AutoSize = true;
    RadioButton radSell1 = this.radSell;
    point1 = new System.Drawing.Point(151, 71);
    System.Drawing.Point point104 = point1;
    radSell1.Location = point104;
    this.radSell.Name = "radSell";
    this.radSell.RightToLeft = RightToLeft.Yes;
    RadioButton radSell2 = this.radSell;
    size1 = new Size(79, 19);
    Size size105 = size1;
    radSell2.Size = size105;
    this.radSell.TabIndex = 39;
    this.radSell.Text = "Sell Prices";
    this.radSell.TextAlign = ContentAlignment.MiddleRight;
    this.radSell.UseVisualStyleBackColor = true;
    this.radRetail.AutoSize = true;
    RadioButton radRetail1 = this.radRetail;
    point1 = new System.Drawing.Point(252, 71);
    System.Drawing.Point point105 = point1;
    radRetail1.Location = point105;
    this.radRetail.Name = "radRetail";
    this.radRetail.RightToLeft = RightToLeft.Yes;
    RadioButton radRetail2 = this.radRetail;
    size1 = new Size(91, 19);
    Size size106 = size1;
    radRetail2.Size = size106;
    this.radRetail.TabIndex = 38;
    this.radRetail.Text = "Retail Prices";
    this.radRetail.TextAlign = ContentAlignment.MiddleRight;
    this.radRetail.UseVisualStyleBackColor = true;
    this.radCost.AutoSize = true;
    this.radCost.Checked = true;
    RadioButton radCost1 = this.radCost;
    point1 = new System.Drawing.Point(50, 71);
    System.Drawing.Point point106 = point1;
    radCost1.Location = point106;
    this.radCost.Name = "radCost";
    this.radCost.RightToLeft = RightToLeft.Yes;
    RadioButton radCost2 = this.radCost;
    size1 = new Size(84, 19);
    Size size107 = size1;
    radCost2.Size = size107;
    this.radCost.TabIndex = 37;
    this.radCost.TabStop = true;
    this.radCost.Text = "Cost Prices";
    this.radCost.TextAlign = ContentAlignment.MiddleRight;
    this.radCost.UseVisualStyleBackColor = true;
    this.cmdBrowseApprovedPrices.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.cmdBrowseApprovedPrices.AutoEllipsis = true;
    this.cmdBrowseApprovedPrices.BackColor = Color.Khaki;
    this.cmdBrowseApprovedPrices.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdBrowseApprovedPrices.Image = (Image) PriceChanger.My.Resources.Resources.search1;
    this.cmdBrowseApprovedPrices.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button browseApprovedPrices1 = this.cmdBrowseApprovedPrices;
    point1 = new System.Drawing.Point(739, 33);
    System.Drawing.Point point107 = point1;
    browseApprovedPrices1.Location = point107;
    this.cmdBrowseApprovedPrices.Name = "cmdBrowseApprovedPrices";
    System.Windows.Forms.Button browseApprovedPrices2 = this.cmdBrowseApprovedPrices;
    size1 = new Size(26, 24);
    Size size108 = size1;
    browseApprovedPrices2.Size = size108;
    this.cmdBrowseApprovedPrices.TabIndex = 36;
    this.ToolTip1.SetToolTip((Control) this.cmdBrowseApprovedPrices, "Browse for Approved Prices file");
    this.cmdBrowseApprovedPrices.UseVisualStyleBackColor = false;
    this.txtImportApproved.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtImportApproved.BackColor = Color.Khaki;
    this.txtImportApproved.BorderStyle = BorderStyle.FixedSingle;
    this.txtImportApproved.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtImportApproved1 = this.txtImportApproved;
    point1 = new System.Drawing.Point(140, 33);
    System.Drawing.Point point108 = point1;
    txtImportApproved1.Location = point108;
    this.txtImportApproved.MaxLength = 20;
    this.txtImportApproved.Name = "txtImportApproved";
    System.Windows.Forms.TextBox txtImportApproved2 = this.txtImportApproved;
    size1 = new Size(593, 24);
    Size size109 = size1;
    txtImportApproved2.Size = size109;
    this.txtImportApproved.TabIndex = 34;
    this.Label27.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label27_1 = this.Label27;
    point1 = new System.Drawing.Point(12, 30);
    System.Drawing.Point point109 = point1;
    label27_1.Location = point109;
    this.Label27.Name = "Label27";
    System.Windows.Forms.Label label27_2 = this.Label27;
    size1 = new Size(122, 24);
    Size size110 = size1;
    label27_2.Size = size110;
    this.Label27.TabIndex = 35;
    this.Label27.Text = "Select Import File";
    this.Label27.TextAlign = ContentAlignment.MiddleRight;
    this.GroupBox3.Controls.Add((Control) this.lblLastRunClearDown);
    this.GroupBox3.Controls.Add((Control) this.cmdProcessDBMaint);
    this.GroupBox3.Controls.Add((Control) this.lblLastRunReindex);
    this.GroupBox3.Controls.Add((Control) this.chkClearImported);
    this.GroupBox3.Controls.Add((Control) this.lblLastRunBackup);
    this.GroupBox3.Controls.Add((Control) this.lblLastRunRecalc);
    this.GroupBox3.Controls.Add((Control) this.chkReindex);
    this.GroupBox3.Controls.Add((Control) this.chkRecalcSalesUplift);
    this.GroupBox3.Controls.Add((Control) this.chkBackup);
    this.GroupBox3.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.GroupBox3.ForeColor = SystemColors.ControlText;
    System.Windows.Forms.GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new System.Drawing.Point(23, 42);
    System.Drawing.Point point110 = point1;
    groupBox3_1.Location = point110;
    this.GroupBox3.Name = "GroupBox3";
    System.Windows.Forms.GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(463, 152);
    Size size111 = size1;
    groupBox3_2.Size = size111;
    this.GroupBox3.TabIndex = 42;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Database Maintenance";
    this.lblLastRunClearDown.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lastRunClearDown1 = this.lblLastRunClearDown;
    point1 = new System.Drawing.Point(233, 60);
    System.Drawing.Point point111 = point1;
    lastRunClearDown1.Location = point111;
    this.lblLastRunClearDown.Name = "lblLastRunClearDown";
    System.Windows.Forms.Label lastRunClearDown2 = this.lblLastRunClearDown;
    size1 = new Size(147, 24);
    Size size112 = size1;
    lastRunClearDown2.Size = size112;
    this.lblLastRunClearDown.TabIndex = 46;
    this.lblLastRunClearDown.Text = "Last run Date: ";
    this.lblLastRunClearDown.TextAlign = ContentAlignment.MiddleLeft;
    this.cmdProcessDBMaint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.cmdProcessDBMaint.AutoEllipsis = true;
    this.cmdProcessDBMaint.BackColor = Color.Khaki;
    this.cmdProcessDBMaint.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdProcessDBMaint.Image = (Image) PriceChanger.My.Resources.Resources.next32;
    this.cmdProcessDBMaint.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdProcessDbMaint1 = this.cmdProcessDBMaint;
    point1 = new System.Drawing.Point(395, 112 /*0x70*/);
    System.Drawing.Point point112 = point1;
    cmdProcessDbMaint1.Location = point112;
    this.cmdProcessDBMaint.Name = "cmdProcessDBMaint";
    System.Windows.Forms.Button cmdProcessDbMaint2 = this.cmdProcessDBMaint;
    size1 = new Size(62, 34);
    Size size113 = size1;
    cmdProcessDbMaint2.Size = size113;
    this.cmdProcessDBMaint.TabIndex = 43;
    this.cmdProcessDBMaint.Text = "Go";
    this.cmdProcessDBMaint.TextAlign = ContentAlignment.MiddleRight;
    this.ToolTip1.SetToolTip((Control) this.cmdProcessDBMaint, "Process Database Maintenance Options");
    this.cmdProcessDBMaint.UseVisualStyleBackColor = false;
    this.lblLastRunReindex.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblLastRunReindex1 = this.lblLastRunReindex;
    point1 = new System.Drawing.Point(233, 93);
    System.Drawing.Point point113 = point1;
    lblLastRunReindex1.Location = point113;
    this.lblLastRunReindex.Name = "lblLastRunReindex";
    System.Windows.Forms.Label lblLastRunReindex2 = this.lblLastRunReindex;
    size1 = new Size(147, 24);
    Size size114 = size1;
    lblLastRunReindex2.Size = size114;
    this.lblLastRunReindex.TabIndex = 42;
    this.lblLastRunReindex.Text = "Last run Date: ";
    this.lblLastRunReindex.TextAlign = ContentAlignment.MiddleLeft;
    this.chkClearImported.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkClearImported1 = this.chkClearImported;
    point1 = new System.Drawing.Point(75, 60);
    System.Drawing.Point point114 = point1;
    chkClearImported1.Location = point114;
    this.chkClearImported.Name = "chkClearImported";
    this.chkClearImported.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkClearImported2 = this.chkClearImported;
    size1 = new Size(152, 24);
    Size size115 = size1;
    chkClearImported2.Size = size115;
    this.chkClearImported.TabIndex = 45;
    this.chkClearImported.Text = "Clear Imported Files";
    this.chkClearImported.TextAlign = ContentAlignment.MiddleRight;
    this.chkClearImported.UseVisualStyleBackColor = true;
    this.lblLastRunBackup.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblLastRunBackup1 = this.lblLastRunBackup;
    point1 = new System.Drawing.Point(233, 30);
    System.Drawing.Point point115 = point1;
    lblLastRunBackup1.Location = point115;
    this.lblLastRunBackup.Name = "lblLastRunBackup";
    System.Windows.Forms.Label lblLastRunBackup2 = this.lblLastRunBackup;
    size1 = new Size(147, 24);
    Size size116 = size1;
    lblLastRunBackup2.Size = size116;
    this.lblLastRunBackup.TabIndex = 41;
    this.lblLastRunBackup.Text = "Last run Date: ";
    this.lblLastRunBackup.TextAlign = ContentAlignment.MiddleLeft;
    this.lblLastRunRecalc.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblLastRunRecalc1 = this.lblLastRunRecalc;
    point1 = new System.Drawing.Point(233, 123);
    System.Drawing.Point point116 = point1;
    lblLastRunRecalc1.Location = point116;
    this.lblLastRunRecalc.Name = "lblLastRunRecalc";
    System.Windows.Forms.Label lblLastRunRecalc2 = this.lblLastRunRecalc;
    size1 = new Size(139, 24);
    Size size117 = size1;
    lblLastRunRecalc2.Size = size117;
    this.lblLastRunRecalc.TabIndex = 40;
    this.lblLastRunRecalc.Text = "Last run Date: ";
    this.lblLastRunRecalc.TextAlign = ContentAlignment.MiddleLeft;
    this.chkReindex.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkReindex1 = this.chkReindex;
    point1 = new System.Drawing.Point(93, 93);
    System.Drawing.Point point117 = point1;
    chkReindex1.Location = point117;
    this.chkReindex.Name = "chkReindex";
    this.chkReindex.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkReindex2 = this.chkReindex;
    size1 = new Size(134, 24);
    Size size118 = size1;
    chkReindex2.Size = size118;
    this.chkReindex.TabIndex = 40;
    this.chkReindex.Text = "Reindex Database";
    this.chkReindex.TextAlign = ContentAlignment.MiddleRight;
    this.chkReindex.UseVisualStyleBackColor = true;
    this.chkRecalcSalesUplift.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox recalcSalesUplift1 = this.chkRecalcSalesUplift;
    point1 = new System.Drawing.Point(93, 123);
    System.Drawing.Point point118 = point1;
    recalcSalesUplift1.Location = point118;
    this.chkRecalcSalesUplift.Name = "chkRecalcSalesUplift";
    this.chkRecalcSalesUplift.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox recalcSalesUplift2 = this.chkRecalcSalesUplift;
    size1 = new Size(134, 24);
    Size size119 = size1;
    recalcSalesUplift2.Size = size119;
    this.chkRecalcSalesUplift.TabIndex = 39;
    this.chkRecalcSalesUplift.Text = "Recalc Sales Uplift";
    this.chkRecalcSalesUplift.TextAlign = ContentAlignment.MiddleRight;
    this.chkRecalcSalesUplift.UseVisualStyleBackColor = true;
    this.chkBackup.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkBackup1 = this.chkBackup;
    point1 = new System.Drawing.Point(93, 30);
    System.Drawing.Point point119 = point1;
    chkBackup1.Location = point119;
    this.chkBackup.Name = "chkBackup";
    this.chkBackup.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkBackup2 = this.chkBackup;
    size1 = new Size(134, 24);
    Size size120 = size1;
    chkBackup2.Size = size120;
    this.chkBackup.TabIndex = 39;
    this.chkBackup.Text = "Backup Database";
    this.chkBackup.TextAlign = ContentAlignment.MiddleRight;
    this.chkBackup.UseVisualStyleBackColor = true;
    this.Label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label3.Font = new System.Drawing.Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label3_1 = this.Label3;
    point1 = new System.Drawing.Point(4, 4);
    System.Drawing.Point point120 = point1;
    label3_1.Location = point120;
    this.Label3.Name = "Label3";
    System.Windows.Forms.Label label3_2 = this.Label3;
    size1 = new Size(775, 26);
    Size size121 = size1;
    label3_2.Size = size121;
    this.Label3.TabIndex = 3;
    this.Label3.Text = "System Management";
    this.Label3.TextAlign = ContentAlignment.MiddleCenter;
    this.tpExport.BackColor = Color.Beige;
    this.tpExport.Controls.Add((Control) this.lblInfo);
    this.tpExport.Controls.Add((Control) this.lblSpam);
    this.tpExport.Controls.Add((Control) this.pbarSpam);
    this.tpExport.Controls.Add((Control) this.chkOutlook);
    this.tpExport.Controls.Add((Control) this.chkAttach);
    this.tpExport.Controls.Add((Control) this.lblEmail);
    this.tpExport.Controls.Add((Control) this.Label33);
    this.tpExport.Controls.Add((Control) this.lblExportFile);
    this.tpExport.Controls.Add((Control) this.Label32);
    this.tpExport.Controls.Add((Control) this.lblExportTemplateName);
    this.tpExport.Controls.Add((Control) this.lblExportLocation);
    this.tpExport.Controls.Add((Control) this.Label29);
    this.tpExport.Controls.Add((Control) this.cmdExportAll);
    this.tpExport.Controls.Add((Control) this.cmdResetExportedFlag);
    this.tpExport.Controls.Add((Control) this.cmdExport);
    TabPage tpExport1 = this.tpExport;
    point1 = new System.Drawing.Point(4, 21);
    System.Drawing.Point point121 = point1;
    tpExport1.Location = point121;
    this.tpExport.Name = "tpExport";
    TabPage tpExport2 = this.tpExport;
    size1 = new Size(798, 615);
    Size size122 = size1;
    tpExport2.Size = size122;
    this.tpExport.TabIndex = 4;
    this.tpExport.Text = "Export";
    this.lblInfo.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblInfo1 = this.lblInfo;
    point1 = new System.Drawing.Point(46, 277);
    System.Drawing.Point point122 = point1;
    lblInfo1.Location = point122;
    this.lblInfo.Name = "lblInfo";
    System.Windows.Forms.Label lblInfo2 = this.lblInfo;
    size1 = new Size(693, 24);
    Size size123 = size1;
    lblInfo2.Size = size123;
    this.lblInfo.TabIndex = 50;
    this.lblInfo.TextAlign = ContentAlignment.MiddleCenter;
    this.lblSpam.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblSpam1 = this.lblSpam;
    point1 = new System.Drawing.Point(273, 316);
    System.Drawing.Point point123 = point1;
    lblSpam1.Location = point123;
    this.lblSpam.Name = "lblSpam";
    System.Windows.Forms.Label lblSpam2 = this.lblSpam;
    size1 = new Size(212, 24);
    Size size124 = size1;
    lblSpam2.Size = size124;
    this.lblSpam.TabIndex = 48 /*0x30*/;
    this.lblSpam.Text = "Anti Spam Cooldown";
    this.lblSpam.TextAlign = ContentAlignment.MiddleCenter;
    this.lblSpam.Visible = false;
    this.pbarSpam.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.pbarSpam.ForeColor = Color.Khaki;
    ProgressBar pbarSpam1 = this.pbarSpam;
    point1 = new System.Drawing.Point(49, 343);
    System.Drawing.Point point124 = point1;
    pbarSpam1.Location = point124;
    this.pbarSpam.Maximum = 300;
    this.pbarSpam.Name = "pbarSpam";
    ProgressBar pbarSpam2 = this.pbarSpam;
    size1 = new Size(690, 23);
    Size size125 = size1;
    pbarSpam2.Size = size125;
    this.pbarSpam.TabIndex = 47;
    this.pbarSpam.Value = 6;
    this.pbarSpam.Visible = false;
    this.chkOutlook.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkOutlook1 = this.chkOutlook;
    point1 = new System.Drawing.Point(300, 182);
    System.Drawing.Point point125 = point1;
    chkOutlook1.Location = point125;
    this.chkOutlook.Name = "chkOutlook";
    this.chkOutlook.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkOutlook2 = this.chkOutlook;
    size1 = new Size(134, 24);
    Size size126 = size1;
    chkOutlook2.Size = size126;
    this.chkOutlook.TabIndex = 46;
    this.chkOutlook.Text = "Outlook";
    this.chkOutlook.TextAlign = ContentAlignment.MiddleRight;
    this.chkOutlook.UseVisualStyleBackColor = true;
    this.chkOutlook.Visible = false;
    this.chkAttach.Checked = true;
    this.chkAttach.CheckState = CheckState.Checked;
    this.chkAttach.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkAttach1 = this.chkAttach;
    point1 = new System.Drawing.Point(300, 228);
    System.Drawing.Point point126 = point1;
    chkAttach1.Location = point126;
    this.chkAttach.Name = "chkAttach";
    this.chkAttach.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkAttach2 = this.chkAttach;
    size1 = new Size(134, 24);
    Size size127 = size1;
    chkAttach2.Size = size127;
    this.chkAttach.TabIndex = 45;
    this.chkAttach.Text = "Send Attachement";
    this.chkAttach.TextAlign = ContentAlignment.MiddleRight;
    this.chkAttach.UseVisualStyleBackColor = true;
    this.chkAttach.Visible = false;
    this.lblEmail.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblEmail1 = this.lblEmail;
    point1 = new System.Drawing.Point(163, 133);
    System.Drawing.Point point127 = point1;
    lblEmail1.Location = point127;
    this.lblEmail.Name = "lblEmail";
    System.Windows.Forms.Label lblEmail2 = this.lblEmail;
    size1 = new Size(469, 24);
    Size size128 = size1;
    lblEmail2.Size = size128;
    this.lblEmail.TabIndex = 42;
    this.lblEmail.TextAlign = ContentAlignment.MiddleLeft;
    this.Label33.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label33_1 = this.Label33;
    point1 = new System.Drawing.Point(29, 133);
    System.Drawing.Point point128 = point1;
    label33_1.Location = point128;
    this.Label33.Name = "Label33";
    System.Windows.Forms.Label label33_2 = this.Label33;
    size1 = new Size(128 /*0x80*/, 24);
    Size size129 = size1;
    label33_2.Size = size129;
    this.Label33.TabIndex = 41;
    this.Label33.Text = "eMail To:";
    this.Label33.TextAlign = ContentAlignment.MiddleRight;
    this.lblExportFile.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblExportFile1 = this.lblExportFile;
    point1 = new System.Drawing.Point(163, 94);
    System.Drawing.Point point129 = point1;
    lblExportFile1.Location = point129;
    this.lblExportFile.Name = "lblExportFile";
    System.Windows.Forms.Label lblExportFile2 = this.lblExportFile;
    size1 = new Size(469, 24);
    Size size130 = size1;
    lblExportFile2.Size = size130;
    this.lblExportFile.TabIndex = 40;
    this.lblExportFile.TextAlign = ContentAlignment.MiddleLeft;
    this.Label32.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label32_1 = this.Label32;
    point1 = new System.Drawing.Point(29, 94);
    System.Drawing.Point point130 = point1;
    label32_1.Location = point130;
    this.Label32.Name = "Label32";
    System.Windows.Forms.Label label32_2 = this.Label32;
    size1 = new Size(128 /*0x80*/, 24);
    Size size131 = size1;
    label32_2.Size = size131;
    this.Label32.TabIndex = 39;
    this.Label32.Text = "Output Excel Path:";
    this.Label32.TextAlign = ContentAlignment.MiddleRight;
    this.lblExportTemplateName.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label exportTemplateName1 = this.lblExportTemplateName;
    point1 = new System.Drawing.Point(163, 60);
    System.Drawing.Point point131 = point1;
    exportTemplateName1.Location = point131;
    this.lblExportTemplateName.Name = "lblExportTemplateName";
    System.Windows.Forms.Label exportTemplateName2 = this.lblExportTemplateName;
    size1 = new Size(280, 24);
    Size size132 = size1;
    exportTemplateName2.Size = size132;
    this.lblExportTemplateName.TabIndex = 38;
    this.lblExportTemplateName.TextAlign = ContentAlignment.MiddleLeft;
    this.lblExportLocation.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblExportLocation1 = this.lblExportLocation;
    point1 = new System.Drawing.Point(29, 60);
    System.Drawing.Point point132 = point1;
    lblExportLocation1.Location = point132;
    this.lblExportLocation.Name = "lblExportLocation";
    System.Windows.Forms.Label lblExportLocation2 = this.lblExportLocation;
    size1 = new Size(128 /*0x80*/, 24);
    Size size133 = size1;
    lblExportLocation2.Size = size133;
    this.lblExportLocation.TabIndex = 37;
    this.lblExportLocation.Text = "Template Name:";
    this.lblExportLocation.TextAlign = ContentAlignment.MiddleRight;
    this.Label29.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label29.Font = new System.Drawing.Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label29_1 = this.Label29;
    point1 = new System.Drawing.Point(3, 8);
    System.Drawing.Point point133 = point1;
    label29_1.Location = point133;
    this.Label29.Name = "Label29";
    System.Windows.Forms.Label label29_2 = this.Label29;
    size1 = new Size(775, 26);
    Size size134 = size1;
    label29_2.Size = size134;
    this.Label29.TabIndex = 4;
    this.Label29.Text = "Export Templates";
    this.Label29.TextAlign = ContentAlignment.MiddleCenter;
    this.cmdExportAll.AutoEllipsis = true;
    this.cmdExportAll.BackColor = Color.Khaki;
    this.cmdExportAll.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdExportAll.Image = (Image) PriceChanger.My.Resources.Resources.addfile32;
    this.cmdExportAll.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdExportAll1 = this.cmdExportAll;
    point1 = new System.Drawing.Point(49, 222);
    System.Drawing.Point point134 = point1;
    cmdExportAll1.Location = point134;
    this.cmdExportAll.Name = "cmdExportAll";
    System.Windows.Forms.Button cmdExportAll2 = this.cmdExportAll;
    size1 = new Size(209, 35);
    Size size135 = size1;
    cmdExportAll2.Size = size135;
    this.cmdExportAll.TabIndex = 44;
    this.cmdExportAll.Text = "Export ALL Templates      ";
    this.cmdExportAll.TextAlign = ContentAlignment.MiddleRight;
    this.cmdExportAll.UseVisualStyleBackColor = false;
    this.cmdResetExportedFlag.Anchor = AnchorStyles.Bottom;
    this.cmdResetExportedFlag.AutoEllipsis = true;
    this.cmdResetExportedFlag.BackColor = Color.Khaki;
    this.cmdResetExportedFlag.Font = new System.Drawing.Font("Calibri", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdResetExportedFlag.Image = (Image) PriceChanger.My.Resources.Resources.next16;
    this.cmdResetExportedFlag.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button resetExportedFlag1 = this.cmdResetExportedFlag;
    point1 = new System.Drawing.Point(49, 572);
    System.Drawing.Point point135 = point1;
    resetExportedFlag1.Location = point135;
    this.cmdResetExportedFlag.Name = "cmdResetExportedFlag";
    System.Windows.Forms.Button resetExportedFlag2 = this.cmdResetExportedFlag;
    size1 = new Size(141, 25);
    Size size136 = size1;
    resetExportedFlag2.Size = size136;
    this.cmdResetExportedFlag.TabIndex = 43;
    this.cmdResetExportedFlag.Text = "Reset Exported Flag";
    this.cmdResetExportedFlag.TextAlign = ContentAlignment.MiddleRight;
    this.cmdResetExportedFlag.UseVisualStyleBackColor = false;
    this.cmdResetExportedFlag.Visible = false;
    this.cmdExport.AutoEllipsis = true;
    this.cmdExport.BackColor = Color.Khaki;
    this.cmdExport.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdExport.Image = (Image) PriceChanger.My.Resources.Resources.addfile32;
    this.cmdExport.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdExport1 = this.cmdExport;
    point1 = new System.Drawing.Point(49, 171);
    System.Drawing.Point point136 = point1;
    cmdExport1.Location = point136;
    this.cmdExport.Name = "cmdExport";
    System.Windows.Forms.Button cmdExport2 = this.cmdExport;
    size1 = new Size(209, 35);
    Size size137 = size1;
    cmdExport2.Size = size137;
    this.cmdExport.TabIndex = 36;
    this.cmdExport.Text = "Export Selected Template   ";
    this.cmdExport.TextAlign = ContentAlignment.MiddleRight;
    this.cmdExport.UseVisualStyleBackColor = false;
    this.tpNewProducts.BackColor = Color.Beige;
    this.tpNewProducts.Controls.Add((Control) this.lblCreateIndexRecords);
    this.tpNewProducts.Controls.Add((Control) this.lblCreatePriceBands);
    this.tpNewProducts.Controls.Add((Control) this.lblUpdateNominals);
    this.tpNewProducts.Controls.Add((Control) this.lblCreateProdultListItems);
    this.tpNewProducts.Controls.Add((Control) this.cmdResolve);

        // Added by Zeljko
        this.tpNewProducts.Controls.Add((Control)this.cmdResolveClear);

        this.tpNewProducts.Controls.Add((Control) this.lblUpdateInfo);
    this.tpNewProducts.Controls.Add((Control) this.lblUpdateParams);
    this.tpNewProducts.Controls.Add((Control) this.lblCreateNominals);
    this.tpNewProducts.Controls.Add((Control) this.lblUpdateTaxCodes);
    this.tpNewProducts.Controls.Add((Control) this.lblCreateStockCodes);
    this.tpNewProducts.Controls.Add((Control) this.cmdUpdateProducts);
    this.tpNewProducts.Controls.Add((Control) this.radResolveIndex);
    this.tpNewProducts.Controls.Add((Control) this.radResolveSuppliers);
    this.tpNewProducts.Controls.Add((Control) this.radResolveSubGroups);
    this.tpNewProducts.Controls.Add((Control) this.radResolveProdGroups);
    this.tpNewProducts.Controls.Add((Control) this.lblMappedINdex);
    this.tpNewProducts.Controls.Add((Control) this.lblMappedPriceLists);
    this.tpNewProducts.Controls.Add((Control) this.lblMappedSuppliers);
    this.tpNewProducts.Controls.Add((Control) this.lblMappedSubGroups);
    this.tpNewProducts.Controls.Add((Control) this.lblMappedProductGroups);
    this.tpNewProducts.Controls.Add((Control) this.lblNewProductsLastImported);
    this.tpNewProducts.Controls.Add((Control) this.Label37);
    this.tpNewProducts.Controls.Add((Control) this.txtImportNewProducts);
    this.tpNewProducts.Controls.Add((Control) this.Label35);
    this.tpNewProducts.Controls.Add((Control) this.Label36);
    this.tpNewProducts.Controls.Add((Control) this.cmdImportNewProducts);
    this.tpNewProducts.Controls.Add((Control) this.cmdBrowseNewProducts);
    TabPage tpNewProducts1 = this.tpNewProducts;
    point1 = new System.Drawing.Point(4, 21);
    System.Drawing.Point point137 = point1;
    tpNewProducts1.Location = point137;
    this.tpNewProducts.Name = "tpNewProducts";
    TabPage tpNewProducts2 = this.tpNewProducts;
    size1 = new Size(798, 615);
    Size size138 = size1;
    tpNewProducts2.Size = size138;
    this.tpNewProducts.TabIndex = 5;
    this.tpNewProducts.Text = " New Products";
    this.lblCreateIndexRecords.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label createIndexRecords1 = this.lblCreateIndexRecords;
    point1 = new System.Drawing.Point(371, 462);
    System.Drawing.Point point138 = point1;
    createIndexRecords1.Location = point138;
    this.lblCreateIndexRecords.Name = "lblCreateIndexRecords";
    System.Windows.Forms.Label createIndexRecords2 = this.lblCreateIndexRecords;
    size1 = new Size(271, 24);
    Size size139 = size1;
    createIndexRecords2.Size = size139;
    this.lblCreateIndexRecords.TabIndex = 66;
    this.lblCreateIndexRecords.Text = "Mapped Product Groups";
    this.lblCreateIndexRecords.TextAlign = ContentAlignment.MiddleLeft;
    this.lblCreateIndexRecords.Visible = false;
    this.lblCreatePriceBands.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label createPriceBands1 = this.lblCreatePriceBands;
    point1 = new System.Drawing.Point(371, 422);
    System.Drawing.Point point139 = point1;
    createPriceBands1.Location = point139;
    this.lblCreatePriceBands.Name = "lblCreatePriceBands";
    System.Windows.Forms.Label createPriceBands2 = this.lblCreatePriceBands;
    size1 = new Size(271, 24);
    Size size140 = size1;
    createPriceBands2.Size = size140;
    this.lblCreatePriceBands.TabIndex = 65;
    this.lblCreatePriceBands.Text = "Mapped Product Groups";
    this.lblCreatePriceBands.TextAlign = ContentAlignment.MiddleLeft;
    this.lblCreatePriceBands.Visible = false;
    this.lblUpdateNominals.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblUpdateNominals1 = this.lblUpdateNominals;
    point1 = new System.Drawing.Point(371, 502);
    System.Drawing.Point point140 = point1;
    lblUpdateNominals1.Location = point140;
    this.lblUpdateNominals.Name = "lblUpdateNominals";
    System.Windows.Forms.Label lblUpdateNominals2 = this.lblUpdateNominals;
    size1 = new Size(271, 24);
    Size size141 = size1;
    lblUpdateNominals2.Size = size141;
    this.lblUpdateNominals.TabIndex = 64 /*0x40*/;
    this.lblUpdateNominals.Text = "Mapped Product Groups";
    this.lblUpdateNominals.TextAlign = ContentAlignment.MiddleLeft;
    this.lblUpdateNominals.Visible = false;
    this.lblCreateProdultListItems.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label produltListItems1 = this.lblCreateProdultListItems;
    point1 = new System.Drawing.Point(371, 382);
    System.Drawing.Point point141 = point1;
    produltListItems1.Location = point141;
    this.lblCreateProdultListItems.Name = "lblCreateProdultListItems";
    System.Windows.Forms.Label produltListItems2 = this.lblCreateProdultListItems;
    size1 = new Size(271, 24);
    Size size142 = size1;
    produltListItems2.Size = size142;
    this.lblCreateProdultListItems.TabIndex = 63 /*0x3F*/;
    this.lblCreateProdultListItems.Text = "Mapped Product Groups";
    this.lblCreateProdultListItems.TextAlign = ContentAlignment.MiddleLeft;
    this.lblCreateProdultListItems.Visible = false;
    this.cmdResolve.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.cmdResolve.AutoEllipsis = true;
    this.cmdResolve.BackColor = Color.Khaki;
    this.cmdResolve.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdResolve.Image = (Image) PriceChanger.My.Resources.Resources.next32;
    this.cmdResolve.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdResolve1 = this.cmdResolve;
    point1 = new System.Drawing.Point(240 /*0xF0*/, 306);
    System.Drawing.Point point142 = point1;
    cmdResolve1.Location = point142;
    this.cmdResolve.Name = "cmdResolve";
    System.Windows.Forms.Button cmdResolve2 = this.cmdResolve;
    size1 = new Size(189, 34);
    Size size143 = size1;
    cmdResolve2.Size = size143;
    this.cmdResolve.TabIndex = 55;
    this.cmdResolve.Text = "       Resolve Selected ";
    this.cmdResolve.UseVisualStyleBackColor = false;
      // Added by Zeljko
       this.cmdResolveClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        this.cmdResolveClear.AutoEllipsis = true;
        this.cmdResolveClear.BackColor = Color.Khaki;
        this.cmdResolveClear.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
        this.cmdResolveClear.Image = (Image) PriceChanger.My.Resources.Resources.next32;
        this.cmdResolveClear.ImageAlign = ContentAlignment.MiddleLeft;
        System.Windows.Forms.Button cmdResolve1Clear = this.cmdResolveClear;
        point1Clear = new System.Drawing.Point(240 , 406);// Location x, z
        System.Drawing.Point point142Clear = point1Clear;
        cmdResolve1Clear.Location = point142Clear;
        this.cmdResolveClear.Name = "cmdResolveClear";
        System.Windows.Forms.Button cmdResolve2Clear = this.cmdResolveClear;
        size1Clear = new Size(189, 34);
        Size size143Clear = size1Clear;
        cmdResolve2Clear.Size = size143Clear;
        this.cmdResolveClear.TabIndex = 56;
        this.cmdResolveClear.Text = "       Clear Data ";
        this.cmdResolveClear.UseVisualStyleBackColor = false;


        this.lblUpdateInfo.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblUpdateInfo1 = this.lblUpdateInfo;
    point1 = new System.Drawing.Point(16 /*0x10*/, 333);
    System.Drawing.Point point143 = point1;
    lblUpdateInfo1.Location = point143;
    this.lblUpdateInfo.Name = "lblUpdateInfo";
    System.Windows.Forms.Label lblUpdateInfo2 = this.lblUpdateInfo;
    size1 = new Size(756, 24);
    Size size144 = size1;
    lblUpdateInfo2.Size = size144;
    this.lblUpdateInfo.TabIndex = 62;
    this.lblUpdateInfo.TextAlign = ContentAlignment.MiddleCenter;
    this.lblUpdateInfo.Visible = false;
    this.lblUpdateParams.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblUpdateParams1 = this.lblUpdateParams;
    point1 = new System.Drawing.Point(70, 502);
    System.Drawing.Point point144 = point1;
    lblUpdateParams1.Location = point144;
    this.lblUpdateParams.Name = "lblUpdateParams";
    System.Windows.Forms.Label lblUpdateParams2 = this.lblUpdateParams;
    size1 = new Size(271, 24);
    Size size145 = size1;
    lblUpdateParams2.Size = size145;
    this.lblUpdateParams.TabIndex = 61;
    this.lblUpdateParams.Text = "Mapped Product Groups";
    this.lblUpdateParams.TextAlign = ContentAlignment.MiddleRight;
    this.lblUpdateParams.Visible = false;
    this.lblCreateNominals.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblCreateNominals1 = this.lblCreateNominals;
    point1 = new System.Drawing.Point(70, 462);
    System.Drawing.Point point145 = point1;
    lblCreateNominals1.Location = point145;
    this.lblCreateNominals.Name = "lblCreateNominals";
    System.Windows.Forms.Label lblCreateNominals2 = this.lblCreateNominals;
    size1 = new Size(271, 24);
    Size size146 = size1;
    lblCreateNominals2.Size = size146;
    this.lblCreateNominals.TabIndex = 60;
    this.lblCreateNominals.Text = "Mapped Product Groups";
    this.lblCreateNominals.TextAlign = ContentAlignment.MiddleRight;
    this.lblCreateNominals.Visible = false;
    this.lblUpdateTaxCodes.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblUpdateTaxCodes1 = this.lblUpdateTaxCodes;
    point1 = new System.Drawing.Point(70, 422);
    System.Drawing.Point point146 = point1;
    lblUpdateTaxCodes1.Location = point146;
    this.lblUpdateTaxCodes.Name = "lblUpdateTaxCodes";
    System.Windows.Forms.Label lblUpdateTaxCodes2 = this.lblUpdateTaxCodes;
    size1 = new Size(271, 24);
    Size size147 = size1;
    lblUpdateTaxCodes2.Size = size147;
    this.lblUpdateTaxCodes.TabIndex = 59;
    this.lblUpdateTaxCodes.Text = "Mapped Product Groups";
    this.lblUpdateTaxCodes.TextAlign = ContentAlignment.MiddleRight;
    this.lblUpdateTaxCodes.Visible = false;
    this.lblCreateStockCodes.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label createStockCodes1 = this.lblCreateStockCodes;
    point1 = new System.Drawing.Point(70, 382);
    System.Drawing.Point point147 = point1;
    createStockCodes1.Location = point147;
    this.lblCreateStockCodes.Name = "lblCreateStockCodes";
    System.Windows.Forms.Label createStockCodes2 = this.lblCreateStockCodes;
    size1 = new Size(271, 24);
    Size size148 = size1;
    createStockCodes2.Size = size148;
    this.lblCreateStockCodes.TabIndex = 58;
    this.lblCreateStockCodes.Text = "Mapped Product Groups";
    this.lblCreateStockCodes.TextAlign = ContentAlignment.MiddleRight;
    this.lblCreateStockCodes.Visible = false;
    this.cmdUpdateProducts.Anchor = AnchorStyles.Bottom;
    this.cmdUpdateProducts.AutoEllipsis = true;
    this.cmdUpdateProducts.BackColor = Color.Khaki;
    this.cmdUpdateProducts.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdUpdateProducts.Image = (Image) PriceChanger.My.Resources.Resources.next32;
    this.cmdUpdateProducts.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button cmdUpdateProducts1 = this.cmdUpdateProducts;
    point1 = new System.Drawing.Point(240 /*0xF0*/, 558);
    System.Drawing.Point point148 = point1;
    cmdUpdateProducts1.Location = point148;
    this.cmdUpdateProducts.Name = "cmdUpdateProducts";
    System.Windows.Forms.Button cmdUpdateProducts2 = this.cmdUpdateProducts;
    size1 = new Size(189, 34);
    Size size149 = size1;
    cmdUpdateProducts2.Size = size149;
    this.cmdUpdateProducts.TabIndex = 56;
    this.cmdUpdateProducts.Text = "       Update Products to ISM";
    this.cmdUpdateProducts.UseVisualStyleBackColor = false;
    this.cmdUpdateProducts.Visible = false;
    this.radResolveIndex.AutoSize = true;
    this.radResolveIndex.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    RadioButton radResolveIndex1 = this.radResolveIndex;
    point1 = new System.Drawing.Point(357, 270);
    System.Drawing.Point point149 = point1;
    radResolveIndex1.Location = point149;
    this.radResolveIndex.Name = "radResolveIndex";
    RadioButton radResolveIndex2 = this.radResolveIndex;
    size1 = new Size(72, 21);
    Size size150 = size1;
    radResolveIndex2.Size = size150;
    this.radResolveIndex.TabIndex = 54;
    this.radResolveIndex.Text = "Resolve";
    this.radResolveIndex.UseVisualStyleBackColor = true;
    this.radResolveSuppliers.AutoSize = true;
    this.radResolveSuppliers.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    RadioButton resolveSuppliers1 = this.radResolveSuppliers;
    point1 = new System.Drawing.Point(357, 232);
    System.Drawing.Point point150 = point1;
    resolveSuppliers1.Location = point150;
    this.radResolveSuppliers.Name = "radResolveSuppliers";
    RadioButton resolveSuppliers2 = this.radResolveSuppliers;
    size1 = new Size(72, 21);
    Size size151 = size1;
    resolveSuppliers2.Size = size151;
    this.radResolveSuppliers.TabIndex = 52;
    this.radResolveSuppliers.Text = "Resolve";
    this.radResolveSuppliers.UseVisualStyleBackColor = true;
    this.radResolveSubGroups.AutoSize = true;
    this.radResolveSubGroups.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    RadioButton resolveSubGroups1 = this.radResolveSubGroups;
    point1 = new System.Drawing.Point(357, 198);
    System.Drawing.Point point151 = point1;
    resolveSubGroups1.Location = point151;
    this.radResolveSubGroups.Name = "radResolveSubGroups";
    RadioButton resolveSubGroups2 = this.radResolveSubGroups;
    size1 = new Size(72, 21);
    Size size152 = size1;
    resolveSubGroups2.Size = size152;
    this.radResolveSubGroups.TabIndex = 51;
    this.radResolveSubGroups.Text = "Resolve";
    this.radResolveSubGroups.UseVisualStyleBackColor = true;
    this.radResolveProdGroups.AutoSize = true;
    this.radResolveProdGroups.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    RadioButton resolveProdGroups1 = this.radResolveProdGroups;
    point1 = new System.Drawing.Point(357, 164);
    System.Drawing.Point point152 = point1;
    resolveProdGroups1.Location = point152;
    this.radResolveProdGroups.Name = "radResolveProdGroups";
    RadioButton resolveProdGroups2 = this.radResolveProdGroups;
    size1 = new Size(72, 21);
    Size size153 = size1;
    resolveProdGroups2.Size = size153;
    this.radResolveProdGroups.TabIndex = 50;
    this.radResolveProdGroups.Text = "Resolve";
    this.radResolveProdGroups.UseVisualStyleBackColor = true;
    this.lblMappedINdex.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblMappedIndex1 = this.lblMappedINdex;
    point1 = new System.Drawing.Point(73, 268);
    System.Drawing.Point point153 = point1;
    lblMappedIndex1.Location = point153;
    this.lblMappedINdex.Name = "lblMappedINdex";
    System.Windows.Forms.Label lblMappedIndex2 = this.lblMappedINdex;
    size1 = new Size(268, 24);
    Size size154 = size1;
    lblMappedIndex2.Size = size154;
    this.lblMappedINdex.TabIndex = 49;
    this.lblMappedINdex.Text = "Mapped Index";
    this.lblMappedINdex.TextAlign = ContentAlignment.MiddleRight;
    this.lblMappedPriceLists.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label mappedPriceLists1 = this.lblMappedPriceLists;
    point1 = new System.Drawing.Point(32 /*0x20*/, 171);
    System.Drawing.Point point154 = point1;
    mappedPriceLists1.Location = point154;
    this.lblMappedPriceLists.Name = "lblMappedPriceLists";
    System.Windows.Forms.Label mappedPriceLists2 = this.lblMappedPriceLists;
    size1 = new Size(48 /*0x30*/, 24);
    Size size155 = size1;
    mappedPriceLists2.Size = size155;
    this.lblMappedPriceLists.TabIndex = 48 /*0x30*/;
    this.lblMappedPriceLists.Text = "Mapped Price Lists";
    this.lblMappedPriceLists.TextAlign = ContentAlignment.MiddleRight;
    this.lblMappedPriceLists.Visible = false;
    this.lblMappedSuppliers.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblMappedSuppliers1 = this.lblMappedSuppliers;
    point1 = new System.Drawing.Point(73, 230);
    System.Drawing.Point point155 = point1;
    lblMappedSuppliers1.Location = point155;
    this.lblMappedSuppliers.Name = "lblMappedSuppliers";
    System.Windows.Forms.Label lblMappedSuppliers2 = this.lblMappedSuppliers;
    size1 = new Size(268, 24);
    Size size156 = size1;
    lblMappedSuppliers2.Size = size156;
    this.lblMappedSuppliers.TabIndex = 47;
    this.lblMappedSuppliers.Text = "Mapped Suppliers";
    this.lblMappedSuppliers.TextAlign = ContentAlignment.MiddleRight;
    this.lblMappedSubGroups.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblMappedSubGroups1 = this.lblMappedSubGroups;
    point1 = new System.Drawing.Point(73, 195);
    System.Drawing.Point point156 = point1;
    lblMappedSubGroups1.Location = point156;
    this.lblMappedSubGroups.Name = "lblMappedSubGroups";
    System.Windows.Forms.Label lblMappedSubGroups2 = this.lblMappedSubGroups;
    size1 = new Size(268, 24);
    Size size157 = size1;
    lblMappedSubGroups2.Size = size157;
    this.lblMappedSubGroups.TabIndex = 46;
    this.lblMappedSubGroups.Text = "Mapped Sub Groups";
    this.lblMappedSubGroups.TextAlign = ContentAlignment.MiddleRight;
    this.lblMappedProductGroups.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label mappedProductGroups1 = this.lblMappedProductGroups;
    point1 = new System.Drawing.Point(70, 161);
    System.Drawing.Point point157 = point1;
    mappedProductGroups1.Location = point157;
    this.lblMappedProductGroups.Name = "lblMappedProductGroups";
    System.Windows.Forms.Label mappedProductGroups2 = this.lblMappedProductGroups;
    size1 = new Size(271, 24);
    Size size158 = size1;
    mappedProductGroups2.Size = size158;
    this.lblMappedProductGroups.TabIndex = 45;
    this.lblMappedProductGroups.Text = "Mapped Product Groups";
    this.lblMappedProductGroups.TextAlign = ContentAlignment.MiddleRight;
    this.lblNewProductsLastImported.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label productsLastImported1 = this.lblNewProductsLastImported;
    point1 = new System.Drawing.Point(221, 65);
    System.Drawing.Point point158 = point1;
    productsLastImported1.Location = point158;
    this.lblNewProductsLastImported.Name = "lblNewProductsLastImported";
    System.Windows.Forms.Label productsLastImported2 = this.lblNewProductsLastImported;
    size1 = new Size(208 /*0xD0*/, 24);
    Size size159 = size1;
    productsLastImported2.Size = size159;
    this.lblNewProductsLastImported.TabIndex = 44;
    this.lblNewProductsLastImported.TextAlign = ContentAlignment.MiddleLeft;
    this.Label37.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label37_1 = this.Label37;
    point1 = new System.Drawing.Point(16 /*0x10*/, 65);
    System.Drawing.Point point159 = point1;
    label37_1.Location = point159;
    this.Label37.Name = "Label37";
    System.Windows.Forms.Label label37_2 = this.Label37;
    size1 = new Size(208 /*0xD0*/, 24);
    Size size160 = size1;
    label37_2.Size = size160;
    this.Label37.TabIndex = 43;
    this.Label37.Text = "New Products Last Imported on:";
    this.Label37.TextAlign = ContentAlignment.MiddleRight;
    this.txtImportNewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtImportNewProducts.BackColor = Color.Khaki;
    this.txtImportNewProducts.BorderStyle = BorderStyle.FixedSingle;
    this.txtImportNewProducts.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox importNewProducts1 = this.txtImportNewProducts;
    point1 = new System.Drawing.Point(136, 116);
    System.Drawing.Point point160 = point1;
    importNewProducts1.Location = point160;
    this.txtImportNewProducts.MaxLength = 20;
    this.txtImportNewProducts.Name = "txtImportNewProducts";
    System.Windows.Forms.TextBox importNewProducts2 = this.txtImportNewProducts;
    size1 = new Size(620, 24);
    Size size161 = size1;
    importNewProducts2.Size = size161;
    this.txtImportNewProducts.TabIndex = 37;
    this.Label35.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label35_1 = this.Label35;
    point1 = new System.Drawing.Point(14, 116);
    System.Drawing.Point point161 = point1;
    label35_1.Location = point161;
    this.Label35.Name = "Label35";
    System.Windows.Forms.Label label35_2 = this.Label35;
    size1 = new Size(116, 24);
    Size size162 = size1;
    label35_2.Size = size162;
    this.Label35.TabIndex = 38;
    this.Label35.Text = "Select Import File";
    this.Label35.TextAlign = ContentAlignment.MiddleRight;
    this.Label36.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label36.Font = new System.Drawing.Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label label36_1 = this.Label36;
    point1 = new System.Drawing.Point(15, 13);
    System.Drawing.Point point162 = point1;
    label36_1.Location = point162;
    this.Label36.Name = "Label36";
    System.Windows.Forms.Label label36_2 = this.Label36;
    size1 = new Size(775, 26);
    Size size163 = size1;
    label36_2.Size = size163;
    this.Label36.TabIndex = 36;
    this.Label36.Text = "Import New Products";
    this.Label36.TextAlign = ContentAlignment.MiddleCenter;
    this.cmdImportNewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.cmdImportNewProducts.AutoEllipsis = true;
    this.cmdImportNewProducts.BackColor = Color.Khaki;
    this.cmdImportNewProducts.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdImportNewProducts.Image = (Image) PriceChanger.My.Resources.Resources.next32;
    this.cmdImportNewProducts.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button importNewProducts3 = this.cmdImportNewProducts;
    point1 = new System.Drawing.Point(660, 151);
    System.Drawing.Point point163 = point1;
    importNewProducts3.Location = point163;
    this.cmdImportNewProducts.Name = "cmdImportNewProducts";
    System.Windows.Forms.Button importNewProducts4 = this.cmdImportNewProducts;
    size1 = new Size(96 /*0x60*/, 34);
    Size size164 = size1;
    importNewProducts4.Size = size164;
    this.cmdImportNewProducts.TabIndex = 40;
    this.cmdImportNewProducts.Text = "Import";
    this.cmdImportNewProducts.TextAlign = ContentAlignment.MiddleRight;
    this.cmdImportNewProducts.UseVisualStyleBackColor = false;
    this.cmdBrowseNewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.cmdBrowseNewProducts.AutoEllipsis = true;
    this.cmdBrowseNewProducts.BackColor = Color.Khaki;
    this.cmdBrowseNewProducts.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.cmdBrowseNewProducts.Image = (Image) PriceChanger.My.Resources.Resources.search1;
    this.cmdBrowseNewProducts.ImageAlign = ContentAlignment.MiddleLeft;
    System.Windows.Forms.Button browseNewProducts1 = this.cmdBrowseNewProducts;
    point1 = new System.Drawing.Point(762, 116);
    System.Drawing.Point point164 = point1;
    browseNewProducts1.Location = point164;
    this.cmdBrowseNewProducts.Name = "cmdBrowseNewProducts";
    System.Windows.Forms.Button browseNewProducts2 = this.cmdBrowseNewProducts;
    size1 = new Size(26, 24);
    Size size165 = size1;
    browseNewProducts2.Size = size165;
    this.cmdBrowseNewProducts.TabIndex = 39;
    this.ToolTip1.SetToolTip((Control) this.cmdBrowseNewProducts, "Browse for file");
    this.cmdBrowseNewProducts.UseVisualStyleBackColor = false;
    this.pBoxExportAsc.BackColor = Color.Khaki;
    this.pBoxExportAsc.Image = (Image) PriceChanger.My.Resources.Resources.down241;
    PictureBox pBoxExportAsc1 = this.pBoxExportAsc;
    point1 = new System.Drawing.Point(164, 5);
    System.Drawing.Point point165 = point1;
    pBoxExportAsc1.Location = point165;
    this.pBoxExportAsc.Name = "pBoxExportAsc";
    PictureBox pBoxExportAsc2 = this.pBoxExportAsc;
    size1 = new Size(25, 23);
    Size size166 = size1;
    pBoxExportAsc2.Size = size166;
    this.pBoxExportAsc.TabIndex = 44;
    this.pBoxExportAsc.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.pBoxExportAsc, "Click To Change Sort Order");
    this.pBoxExportedAsc.Anchor = AnchorStyles.Left;
    this.pBoxExportedAsc.BackColor = Color.Khaki;
    this.pBoxExportedAsc.Image = (Image) PriceChanger.My.Resources.Resources.down241;
    PictureBox pBoxExportedAsc1 = this.pBoxExportedAsc;
    point1 = new System.Drawing.Point(164, 282);
    System.Drawing.Point point166 = point1;
    pBoxExportedAsc1.Location = point166;
    this.pBoxExportedAsc.Name = "pBoxExportedAsc";
    PictureBox pBoxExportedAsc2 = this.pBoxExportedAsc;
    size1 = new Size(25, 23);
    Size size167 = size1;
    pBoxExportedAsc2.Size = size167;
    this.pBoxExportedAsc.TabIndex = 47;
    this.pBoxExportedAsc.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.pBoxExportedAsc, "Click To Change Sort Order");
    this.pboxExportedDesc.Anchor = AnchorStyles.Left;
    this.pboxExportedDesc.BackColor = Color.Khaki;
    this.pboxExportedDesc.Image = (Image) componentResourceManager.GetObject("pboxExportedDesc.Image");
    PictureBox pboxExportedDesc1 = this.pboxExportedDesc;
    point1 = new System.Drawing.Point(11, 282);
    System.Drawing.Point point167 = point1;
    pboxExportedDesc1.Location = point167;
    this.pboxExportedDesc.Name = "pboxExportedDesc";
    PictureBox pboxExportedDesc2 = this.pboxExportedDesc;
    size1 = new Size(25, 23);
    Size size168 = size1;
    pboxExportedDesc2.Size = size168;
    this.pboxExportedDesc.TabIndex = 48 /*0x30*/;
    this.pboxExportedDesc.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.pboxExportedDesc, "Click To Change Sort Order");
    this.pboxExportedDesc.Visible = false;
    this.pBoxExportDesc.BackColor = Color.Khaki;
    this.pBoxExportDesc.Image = (Image) componentResourceManager.GetObject("pBoxExportDesc.Image");
    PictureBox pBoxExportDesc1 = this.pBoxExportDesc;
    point1 = new System.Drawing.Point(11, 5);
    System.Drawing.Point point168 = point1;
    pBoxExportDesc1.Location = point168;
    this.pBoxExportDesc.Name = "pBoxExportDesc";
    PictureBox pBoxExportDesc2 = this.pBoxExportDesc;
    size1 = new Size(25, 23);
    Size size169 = size1;
    pBoxExportDesc2.Size = size169;
    this.pBoxExportDesc.TabIndex = 45;
    this.pBoxExportDesc.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.pBoxExportDesc, "Click To Change Sort Order");
    this.pBoxExportDesc.Visible = false;
    this.pboxTemplateDesc.BackColor = Color.Khaki;
    this.pboxTemplateDesc.Image = (Image) componentResourceManager.GetObject("pboxTemplateDesc.Image");
    PictureBox pboxTemplateDesc1 = this.pboxTemplateDesc;
    point1 = new System.Drawing.Point(3, 0);
    System.Drawing.Point point169 = point1;
    pboxTemplateDesc1.Location = point169;
    this.pboxTemplateDesc.Name = "pboxTemplateDesc";
    PictureBox pboxTemplateDesc2 = this.pboxTemplateDesc;
    size1 = new Size(25, 23);
    Size size170 = size1;
    pboxTemplateDesc2.Size = size170;
    this.pboxTemplateDesc.TabIndex = 44;
    this.pboxTemplateDesc.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.pboxTemplateDesc, "Click To Change Sort Order");
    this.pboxTemplateDesc.Visible = false;
    this.pBoxTemplateAsc.BackColor = Color.Khaki;
    this.pBoxTemplateAsc.Image = (Image) PriceChanger.My.Resources.Resources.down241;
    PictureBox pBoxTemplateAsc1 = this.pBoxTemplateAsc;
    point1 = new System.Drawing.Point(166, 1);
    System.Drawing.Point point170 = point1;
    pBoxTemplateAsc1.Location = point170;
    this.pBoxTemplateAsc.Name = "pBoxTemplateAsc";
    PictureBox pBoxTemplateAsc2 = this.pBoxTemplateAsc;
    size1 = new Size(25, 23);
    Size size171 = size1;
    pBoxTemplateAsc2.Size = size171;
    this.pBoxTemplateAsc.TabIndex = 43;
    this.pBoxTemplateAsc.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.pBoxTemplateAsc, "Click To Change Sort Order");
    this.pboxImportedAsc.Anchor = AnchorStyles.Left;
    this.pboxImportedAsc.BackColor = Color.Khaki;
    this.pboxImportedAsc.Image = (Image) PriceChanger.My.Resources.Resources.down241;
    PictureBox pboxImportedAsc1 = this.pboxImportedAsc;
    point1 = new System.Drawing.Point(164, 275);
    System.Drawing.Point point171 = point1;
    pboxImportedAsc1.Location = point171;
    this.pboxImportedAsc.Name = "pboxImportedAsc";
    PictureBox pboxImportedAsc2 = this.pboxImportedAsc;
    size1 = new Size(25, 23);
    Size size172 = size1;
    pboxImportedAsc2.Size = size172;
    this.pboxImportedAsc.TabIndex = 40;
    this.pboxImportedAsc.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.pboxImportedAsc, "Click To Change Sort Order");
    this.pboxImportedDesc.Anchor = AnchorStyles.Left;
    this.pboxImportedDesc.BackColor = Color.Khaki;
    this.pboxImportedDesc.Image = (Image) componentResourceManager.GetObject("pboxImportedDesc.Image");
    PictureBox pboxImportedDesc1 = this.pboxImportedDesc;
    point1 = new System.Drawing.Point(1, 272);
    System.Drawing.Point point172 = point1;
    pboxImportedDesc1.Location = point172;
    this.pboxImportedDesc.Name = "pboxImportedDesc";
    PictureBox pboxImportedDesc2 = this.pboxImportedDesc;
    size1 = new Size(25, 23);
    Size size173 = size1;
    pboxImportedDesc2.Size = size173;
    this.pboxImportedDesc.TabIndex = 41;
    this.pboxImportedDesc.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.pboxImportedDesc, "Click To Change Sort Order");
    this.pboxImportedDesc.Visible = false;
    this.pboxWaitingAsc.BackColor = Color.Khaki;
    this.pboxWaitingAsc.Image = (Image) PriceChanger.My.Resources.Resources.down241;
    PictureBox pboxWaitingAsc1 = this.pboxWaitingAsc;
    point1 = new System.Drawing.Point(169, 4);
    System.Drawing.Point point173 = point1;
    pboxWaitingAsc1.Location = point173;
    this.pboxWaitingAsc.Name = "pboxWaitingAsc";
    PictureBox pboxWaitingAsc2 = this.pboxWaitingAsc;
    size1 = new Size(25, 23);
    Size size174 = size1;
    pboxWaitingAsc2.Size = size174;
    this.pboxWaitingAsc.TabIndex = 41;
    this.pboxWaitingAsc.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.pboxWaitingAsc, "Click To Change Sort Order");
    this.pboxWaitingDesc.BackColor = Color.Khaki;
    this.pboxWaitingDesc.Image = (Image) componentResourceManager.GetObject("pboxWaitingDesc.Image");
    PictureBox pboxWaitingDesc1 = this.pboxWaitingDesc;
    point1 = new System.Drawing.Point(3, 3);
    System.Drawing.Point point174 = point1;
    pboxWaitingDesc1.Location = point174;
    this.pboxWaitingDesc.Name = "pboxWaitingDesc";
    PictureBox pboxWaitingDesc2 = this.pboxWaitingDesc;
    size1 = new Size(25, 23);
    Size size175 = size1;
    pboxWaitingDesc2.Size = size175;
    this.pboxWaitingDesc.TabIndex = 42;
    this.pboxWaitingDesc.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.pboxWaitingDesc, "Click To Change Sort Order");
    this.pboxWaitingDesc.Visible = false;
    this.ListBox1.BackColor = Color.Beige;
    this.ListBox1.DrawMode = DrawMode.OwnerDrawFixed;
    this.ListBox1.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.ListBox1.FormattingEnabled = true;
    this.ListBox1.ItemHeight = 15;
    System.Windows.Forms.ListBox listBox1_1 = this.ListBox1;
    point1 = new System.Drawing.Point(24, 192 /*0xC0*/);
    System.Drawing.Point point175 = point1;
    listBox1_1.Location = point175;
    this.ListBox1.Name = "ListBox1";
    System.Windows.Forms.ListBox listBox1_2 = this.ListBox1;
    size1 = new Size(151, 169);
    Size size176 = size1;
    listBox1_2.Size = size176;
    this.ListBox1.TabIndex = 11;
    this.naviBar1.ActiveBand = this.nbImport;
    this.naviBar1.BackColor = Color.Beige;
    this.naviBar1.Controls.Add((Control) this.nbImport);
    this.naviBar1.Controls.Add((Control) this.nbExport);
    this.naviBar1.Controls.Add((Control) this.nbTemplates);
    this.naviBar1.Controls.Add((Control) this.nbNewProducts);
    this.naviBar1.Controls.Add((Control) this.nbSettings);
    this.naviBar1.Controls.Add((Control) this.nbManagement);
    this.naviBar1.Controls.Add((Control) this.ListBox1);
    this.naviBar1.Dock = DockStyle.Left;
    this.naviBar1.LayoutStyle = NaviLayoutStyle.Office2007Black;
    NaviBar naviBar1_1 = this.naviBar1;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point176 = point1;
    naviBar1_1.Location = point176;
    this.naviBar1.Name = "naviBar1";
    NaviBar naviBar1_2 = this.naviBar1;
    size1 = new Size(198, 671);
    Size size177 = size1;
    naviBar1_2.Size = size177;
    this.naviBar1.TabIndex = 1;
    this.naviBar1.Text = "naviBar1";
    this.naviBar1.VisibleLargeButtons = 3;
    this.nbImport.ClientArea.Controls.Add((Control) this.pboxImportedAsc);
    this.nbImport.ClientArea.Controls.Add((Control) this.pboxImportedDesc);
    this.nbImport.ClientArea.Controls.Add((Control) this.lblImported);
    this.nbImport.ClientArea.Controls.Add((Control) this.lstWaiting);
    this.nbImport.ClientArea.Controls.Add((Control) this.lstImported);
    this.nbImport.ClientArea.Controls.Add((Control) this.pboxWaitingAsc);
    this.nbImport.ClientArea.Controls.Add((Control) this.pboxWaitingDesc);
    this.nbImport.ClientArea.Controls.Add((Control) this.lblWaiting);
    NaviBandClientArea clientArea1 = this.nbImport.ClientArea;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point177 = point1;
    clientArea1.Location = point177;
    this.nbImport.ClientArea.Name = "ClientArea";
    NaviBandClientArea clientArea2 = this.nbImport.ClientArea;
    size1 = new Size(196, 508);
    Size size178 = size1;
    clientArea2.Size = size178;
    this.nbImport.ClientArea.TabIndex = 0;
    this.nbImport.LargeImage = (Image) PriceChanger.My.Resources.Resources.next22;
    this.nbImport.LayoutStyle = NaviLayoutStyle.Office2007Black;
    NaviBand nbImport1 = this.nbImport;
    point1 = new System.Drawing.Point(1, 27);
    System.Drawing.Point point178 = point1;
    nbImport1.Location = point178;
    this.nbImport.Name = "nbImport";
    NaviBand nbImport2 = this.nbImport;
    size1 = new Size(196, 508);
    Size size179 = size1;
    nbImport2.Size = size179;
    this.nbImport.SmallImage = (Image) PriceChanger.My.Resources.Resources.next16;
    this.nbImport.TabIndex = 0;
    this.nbImport.Text = "Import Files";
    this.lblImported.Anchor = AnchorStyles.Left;
    this.lblImported.BackColor = Color.Khaki;
    this.lblImported.BorderStyle = BorderStyle.FixedSingle;
    this.lblImported.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblImported1 = this.lblImported;
    point1 = new System.Drawing.Point(0, 272);
    System.Drawing.Point point179 = point1;
    lblImported1.Location = point179;
    this.lblImported.Name = "lblImported";
    System.Windows.Forms.Label lblImported2 = this.lblImported;
    size1 = new Size(196, 33);
    Size size180 = size1;
    lblImported2.Size = size180;
    this.lblImported.TabIndex = 5;
    this.lblImported.Text = "Imported Files";
    this.lblImported.TextAlign = ContentAlignment.MiddleCenter;
    this.lstWaiting.BackColor = Color.Beige;
    this.lstWaiting.DrawMode = DrawMode.OwnerDrawFixed;
    this.lstWaiting.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lstWaiting.FormattingEnabled = true;
    this.lstWaiting.ItemHeight = 15;
    System.Windows.Forms.ListBox lstWaiting1 = this.lstWaiting;
    point1 = new System.Drawing.Point(0, 33);
    System.Drawing.Point point180 = point1;
    lstWaiting1.Location = point180;
    this.lstWaiting.Name = "lstWaiting";
    System.Windows.Forms.ListBox lstWaiting2 = this.lstWaiting;
    size1 = new Size(199, 229);
    Size size181 = size1;
    lstWaiting2.Size = size181;
    this.lstWaiting.TabIndex = 4;
    this.lstImported.BackColor = Color.Beige;
    this.lstImported.DrawMode = DrawMode.OwnerDrawFixed;
    this.lstImported.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lstImported.FormattingEnabled = true;
    this.lstImported.ItemHeight = 15;
    System.Windows.Forms.ListBox lstImported1 = this.lstImported;
    point1 = new System.Drawing.Point(-1, 289);
    System.Drawing.Point point181 = point1;
    lstImported1.Location = point181;
    this.lstImported.Name = "lstImported";
    System.Windows.Forms.ListBox lstImported2 = this.lstImported;
    size1 = new Size(199, 259);
    Size size182 = size1;
    lstImported2.Size = size182;
    this.lstImported.TabIndex = 5;
    this.lblWaiting.BackColor = Color.Khaki;
    this.lblWaiting.BorderStyle = BorderStyle.FixedSingle;
    this.lblWaiting.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblWaiting1 = this.lblWaiting;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point182 = point1;
    lblWaiting1.Location = point182;
    this.lblWaiting.Name = "lblWaiting";
    System.Windows.Forms.Label lblWaiting2 = this.lblWaiting;
    size1 = new Size(196, 33);
    Size size183 = size1;
    lblWaiting2.Size = size183;
    this.lblWaiting.TabIndex = 4;
    this.lblWaiting.Text = "Files For Import";
    this.lblWaiting.TextAlign = ContentAlignment.MiddleCenter;
    this.nbExport.ClientArea.Controls.Add((Control) this.lstExported);
    this.nbExport.ClientArea.Controls.Add((Control) this.pBoxExportAsc);
    this.nbExport.ClientArea.Controls.Add((Control) this.pBoxExportedAsc);
    this.nbExport.ClientArea.Controls.Add((Control) this.pboxExportedDesc);
    this.nbExport.ClientArea.Controls.Add((Control) this.lstExport);
    this.nbExport.ClientArea.Controls.Add((Control) this.pBoxExportDesc);
    this.nbExport.ClientArea.Controls.Add((Control) this.lblExport);
    this.nbExport.ClientArea.Controls.Add((Control) this.lblExported);
    NaviBandClientArea clientArea3 = this.nbExport.ClientArea;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point183 = point1;
    clientArea3.Location = point183;
    this.nbExport.ClientArea.Name = "ClientArea";
    NaviBandClientArea clientArea4 = this.nbExport.ClientArea;
    size1 = new Size(196, 508);
    Size size184 = size1;
    clientArea4.Size = size184;
    this.nbExport.ClientArea.TabIndex = 0;
    this.nbExport.LargeImage = (Image) PriceChanger.My.Resources.Resources.addfile22;
    this.nbExport.LayoutStyle = NaviLayoutStyle.Office2007Black;
    NaviBand nbExport1 = this.nbExport;
    point1 = new System.Drawing.Point(1, 27);
    System.Drawing.Point point184 = point1;
    nbExport1.Location = point184;
    this.nbExport.Name = "nbExport";
    NaviBand nbExport2 = this.nbExport;
    size1 = new Size(196, 508);
    Size size185 = size1;
    nbExport2.Size = size185;
    this.nbExport.SmallImage = (Image) PriceChanger.My.Resources.Resources.addfile16;
    this.nbExport.TabIndex = 21;
    this.nbExport.Text = "Export";
    this.lstExported.BackColor = Color.Beige;
    this.lstExported.DrawMode = DrawMode.OwnerDrawFixed;
    this.lstExported.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lstExported.FormattingEnabled = true;
    this.lstExported.ItemHeight = 15;
    System.Windows.Forms.ListBox lstExported1 = this.lstExported;
    point1 = new System.Drawing.Point(0, 295);
    System.Drawing.Point point185 = point1;
    lstExported1.Location = point185;
    this.lstExported.Name = "lstExported";
    System.Windows.Forms.ListBox lstExported2 = this.lstExported;
    size1 = new Size(199, 214);
    Size size186 = size1;
    lstExported2.Size = size186;
    this.lstExported.TabIndex = 50;
    this.lstExport.BackColor = Color.Beige;
    this.lstExport.DrawMode = DrawMode.OwnerDrawFixed;
    this.lstExport.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lstExport.FormattingEnabled = true;
    this.lstExport.ItemHeight = 15;
    System.Windows.Forms.ListBox lstExport1 = this.lstExport;
    point1 = new System.Drawing.Point(0, 33);
    System.Drawing.Point point186 = point1;
    lstExport1.Location = point186;
    this.lstExport.Name = "lstExport";
    System.Windows.Forms.ListBox lstExport2 = this.lstExport;
    size1 = new Size(199, 229);
    Size size187 = size1;
    lstExport2.Size = size187;
    this.lstExport.TabIndex = 49;
    this.lblExport.BackColor = Color.Khaki;
    this.lblExport.BorderStyle = BorderStyle.FixedSingle;
    this.lblExport.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblExport1 = this.lblExport;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point187 = point1;
    lblExport1.Location = point187;
    this.lblExport.Name = "lblExport";
    System.Windows.Forms.Label lblExport2 = this.lblExport;
    size1 = new Size(196, 33);
    Size size188 = size1;
    lblExport2.Size = size188;
    this.lblExport.TabIndex = 43;
    this.lblExport.Text = "Files For Export";
    this.lblExport.TextAlign = ContentAlignment.MiddleCenter;
    this.lblExported.Anchor = AnchorStyles.Left;
    this.lblExported.BackColor = Color.Khaki;
    this.lblExported.BorderStyle = BorderStyle.FixedSingle;
    this.lblExported.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lblExported1 = this.lblExported;
    point1 = new System.Drawing.Point(0, 278);
    System.Drawing.Point point188 = point1;
    lblExported1.Location = point188;
    this.lblExported.Name = "lblExported";
    System.Windows.Forms.Label lblExported2 = this.lblExported;
    size1 = new Size(196, 33);
    Size size189 = size1;
    lblExported2.Size = size189;
    this.lblExported.TabIndex = 46;
    this.lblExported.Text = "Exported Files";
    this.lblExported.TextAlign = ContentAlignment.MiddleCenter;
    this.nbTemplates.ClientArea.Controls.Add((Control) this.pboxTemplateDesc);
    this.nbTemplates.ClientArea.Controls.Add((Control) this.pBoxTemplateAsc);
    this.nbTemplates.ClientArea.Controls.Add((Control) this.lbTemplates);
    this.nbTemplates.ClientArea.Controls.Add((Control) this.lblNewTemplate);
    NaviBandClientArea clientArea5 = this.nbTemplates.ClientArea;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point189 = point1;
    clientArea5.Location = point189;
    this.nbTemplates.ClientArea.Name = "ClientArea";
    NaviBandClientArea clientArea6 = this.nbTemplates.ClientArea;
    size1 = new Size(196, 508);
    Size size190 = size1;
    clientArea6.Size = size190;
    this.nbTemplates.ClientArea.TabIndex = 0;
    this.nbTemplates.LargeImage = (Image) PriceChanger.My.Resources.Resources.cut22;
    this.nbTemplates.LayoutStyle = NaviLayoutStyle.Office2007Black;
    NaviBand nbTemplates1 = this.nbTemplates;
    point1 = new System.Drawing.Point(1, 27);
    System.Drawing.Point point190 = point1;
    nbTemplates1.Location = point190;
    this.nbTemplates.Name = "nbTemplates";
    NaviBand nbTemplates2 = this.nbTemplates;
    size1 = new Size(196, 508);
    Size size191 = size1;
    nbTemplates2.Size = size191;
    this.nbTemplates.SmallImage = (Image) PriceChanger.My.Resources.Resources.documentsorcopy16;
    this.nbTemplates.TabIndex = 1;
    this.nbTemplates.Text = "Templates";
    this.lbTemplates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.lbTemplates.BackColor = Color.Beige;
    this.lbTemplates.DrawMode = DrawMode.OwnerDrawFixed;
    this.lbTemplates.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lbTemplates.FormattingEnabled = true;
    this.lbTemplates.ItemHeight = 15;
    System.Windows.Forms.ListBox lbTemplates1 = this.lbTemplates;
    point1 = new System.Drawing.Point(0, 27);
    System.Drawing.Point point191 = point1;
    lbTemplates1.Location = point191;
    this.lbTemplates.Name = "lbTemplates";
    System.Windows.Forms.ListBox lbTemplates2 = this.lbTemplates;
    size1 = new Size(197, 754);
    Size size192 = size1;
    lbTemplates2.Size = size192;
    this.lbTemplates.TabIndex = 1;
    this.lblNewTemplate.BackColor = Color.Khaki;
    this.lblNewTemplate.BorderStyle = BorderStyle.FixedSingle;
    this.lblNewTemplate.Font = new System.Drawing.Font("Calibri", 12f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    this.lblNewTemplate.ForeColor = Color.MidnightBlue;
    System.Windows.Forms.Label lblNewTemplate1 = this.lblNewTemplate;
    point1 = new System.Drawing.Point(-2, 0);
    System.Drawing.Point point192 = point1;
    lblNewTemplate1.Location = point192;
    this.lblNewTemplate.Name = "lblNewTemplate";
    System.Windows.Forms.Label lblNewTemplate2 = this.lblNewTemplate;
    size1 = new Size(198, 27);
    Size size193 = size1;
    lblNewTemplate2.Size = size193;
    this.lblNewTemplate.TabIndex = 23;
    this.lblNewTemplate.Text = "New Template";
    this.lblNewTemplate.TextAlign = ContentAlignment.MiddleCenter;
    this.nbNewProducts.ClientArea.Controls.Add((Control) this.lstNewProducts);
    NaviBandClientArea clientArea7 = this.nbNewProducts.ClientArea;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point193 = point1;
    clientArea7.Location = point193;
    this.nbNewProducts.ClientArea.Name = "ClientArea";
    NaviBandClientArea clientArea8 = this.nbNewProducts.ClientArea;
    size1 = new Size(196, 508);
    Size size194 = size1;
    clientArea8.Size = size194;
    this.nbNewProducts.ClientArea.TabIndex = 0;
    this.nbNewProducts.LargeImage = (Image) PriceChanger.My.Resources.Resources.add22;
    this.nbNewProducts.LayoutStyle = NaviLayoutStyle.Office2007Black;
    NaviBand nbNewProducts1 = this.nbNewProducts;
    point1 = new System.Drawing.Point(1, 27);
    System.Drawing.Point point194 = point1;
    nbNewProducts1.Location = point194;
    this.nbNewProducts.Name = "nbNewProducts";
    NaviBand nbNewProducts2 = this.nbNewProducts;
    size1 = new Size(196, 508);
    Size size195 = size1;
    nbNewProducts2.Size = size195;
    this.nbNewProducts.SmallImage = (Image) PriceChanger.My.Resources.Resources.add161;
    this.nbNewProducts.TabIndex = 30;
    this.nbNewProducts.Text = "New Products";
    this.lstNewProducts.BackColor = Color.Beige;
    this.lstNewProducts.DrawMode = DrawMode.OwnerDrawFixed;
    this.lstNewProducts.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lstNewProducts.FormattingEnabled = true;
    this.lstNewProducts.ItemHeight = 15;
    System.Windows.Forms.ListBox lstNewProducts1 = this.lstNewProducts;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point195 = point1;
    lstNewProducts1.Location = point195;
    this.lstNewProducts.Name = "lstNewProducts";
    System.Windows.Forms.ListBox lstNewProducts2 = this.lstNewProducts;
    size1 = new Size(197, 829);
    Size size196 = size1;
    lstNewProducts2.Size = size196;
    this.lstNewProducts.TabIndex = 41;
    this.nbSettings.ClientArea.Controls.Add((Control) this.lstSettings);
    NaviBandClientArea clientArea9 = this.nbSettings.ClientArea;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point196 = point1;
    clientArea9.Location = point196;
    this.nbSettings.ClientArea.Name = "ClientArea";
    NaviBandClientArea clientArea10 = this.nbSettings.ClientArea;
    size1 = new Size(196, 508);
    Size size197 = size1;
    clientArea10.Size = size197;
    this.nbSettings.ClientArea.TabIndex = 0;
    this.nbSettings.LargeImage = (Image) PriceChanger.My.Resources.Resources.configure22;
    this.nbSettings.LayoutStyle = NaviLayoutStyle.Office2007Black;
    NaviBand nbSettings1 = this.nbSettings;
    point1 = new System.Drawing.Point(1, 27);
    System.Drawing.Point point197 = point1;
    nbSettings1.Location = point197;
    this.nbSettings.Name = "nbSettings";
    NaviBand nbSettings2 = this.nbSettings;
    size1 = new Size(196, 508);
    Size size198 = size1;
    nbSettings2.Size = size198;
    this.nbSettings.SmallImage = (Image) PriceChanger.My.Resources.Resources.configure16;
    this.nbSettings.TabIndex = 5;
    this.nbSettings.Text = "Settings";
    this.lstSettings.BackColor = Color.Beige;
    this.lstSettings.DrawMode = DrawMode.OwnerDrawFixed;
    this.lstSettings.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lstSettings.FormattingEnabled = true;
    this.lstSettings.ItemHeight = 15;
    System.Windows.Forms.ListBox lstSettings1 = this.lstSettings;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point198 = point1;
    lstSettings1.Location = point198;
    this.lstSettings.Name = "lstSettings";
    System.Windows.Forms.ListBox lstSettings2 = this.lstSettings;
    size1 = new Size(197, 829);
    Size size199 = size1;
    lstSettings2.Size = size199;
    this.lstSettings.TabIndex = 40;
    this.nbManagement.ClientArea.Controls.Add((Control) this.lstManagement);
    NaviBandClientArea clientArea11 = this.nbManagement.ClientArea;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point199 = point1;
    clientArea11.Location = point199;
    this.nbManagement.ClientArea.Name = "ClientArea";
    NaviBandClientArea clientArea12 = this.nbManagement.ClientArea;
    size1 = new Size(196, 508);
    Size size200 = size1;
    clientArea12.Size = size200;
    this.nbManagement.ClientArea.TabIndex = 0;
    this.nbManagement.LargeImage = (Image) PriceChanger.My.Resources.Resources.key22;
    this.nbManagement.LayoutStyle = NaviLayoutStyle.Office2007Black;
    NaviBand nbManagement1 = this.nbManagement;
    point1 = new System.Drawing.Point(1, 27);
    System.Drawing.Point point200 = point1;
    nbManagement1.Location = point200;
    this.nbManagement.Name = "nbManagement";
    NaviBand nbManagement2 = this.nbManagement;
    size1 = new Size(196, 508);
    Size size201 = size1;
    nbManagement2.Size = size201;
    this.nbManagement.SmallImage = (Image) PriceChanger.My.Resources.Resources.key16;
    this.nbManagement.TabIndex = 15;
    this.nbManagement.Text = "Management";
    this.lstManagement.BackColor = Color.Beige;
    this.lstManagement.DrawMode = DrawMode.OwnerDrawFixed;
    this.lstManagement.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lstManagement.FormattingEnabled = true;
    this.lstManagement.ItemHeight = 15;
    System.Windows.Forms.ListBox lstManagement1 = this.lstManagement;
    point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point201 = point1;
    lstManagement1.Location = point201;
    this.lstManagement.Name = "lstManagement";
    System.Windows.Forms.ListBox lstManagement2 = this.lstManagement;
    size1 = new Size(197, 829);
    Size size202 = size1;
    lstManagement2.Size = size202;
    this.lstManagement.TabIndex = 41;
    this.lblLastRunUpdateCostSellRetail.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label updateCostSellRetail1 = this.lblLastRunUpdateCostSellRetail;
    point1 = new System.Drawing.Point(230, 162);
    System.Drawing.Point point202 = point1;
    updateCostSellRetail1.Location = point202;
    this.lblLastRunUpdateCostSellRetail.Name = "lblLastRunUpdateCostSellRetail";
    System.Windows.Forms.Label updateCostSellRetail2 = this.lblLastRunUpdateCostSellRetail;
    size1 = new Size(155, 24);
    Size size203 = size1;
    updateCostSellRetail2.Size = size203;
    this.lblLastRunUpdateCostSellRetail.TabIndex = 52;
    this.lblLastRunUpdateCostSellRetail.Text = "Last run Date: ";
    this.lblLastRunUpdateCostSellRetail.TextAlign = ContentAlignment.MiddleLeft;
    this.chkUpdateCostSellretail.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox updateCostSellretail1 = this.chkUpdateCostSellretail;
    point1 = new System.Drawing.Point(60, 162);
    System.Drawing.Point point203 = point1;
    updateCostSellretail1.Location = point203;
    this.chkUpdateCostSellretail.Name = "chkUpdateCostSellretail";
    this.chkUpdateCostSellretail.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox updateCostSellretail2 = this.chkUpdateCostSellretail;
    size1 = new Size(164, 24);
    Size size204 = size1;
    updateCostSellretail2.Size = size204;
    this.chkUpdateCostSellretail.TabIndex = 51;
    this.chkUpdateCostSellretail.Text = "Update Cost/Sell/Retail";
    this.chkUpdateCostSellretail.TextAlign = ContentAlignment.MiddleRight;
    this.chkUpdateCostSellretail.UseVisualStyleBackColor = true;
    this.lblLastUpdatePOPPrices.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Label lastUpdatePopPrices1 = this.lblLastUpdatePOPPrices;
    point1 = new System.Drawing.Point(230, 190);
    System.Drawing.Point point204 = point1;
    lastUpdatePopPrices1.Location = point204;
    this.lblLastUpdatePOPPrices.Name = "lblLastUpdatePOPPrices";
    System.Windows.Forms.Label lastUpdatePopPrices2 = this.lblLastUpdatePOPPrices;
    size1 = new Size(155, 24);
    Size size205 = size1;
    lastUpdatePopPrices2.Size = size205;
    this.lblLastUpdatePOPPrices.TabIndex = 54;
    this.lblLastUpdatePOPPrices.Text = "Last run Date: ";
    this.lblLastUpdatePOPPrices.TextAlign = ContentAlignment.MiddleLeft;
    this.chkUpdatePOPPrices.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.CheckBox chkUpdatePopPrices1 = this.chkUpdatePOPPrices;
    point1 = new System.Drawing.Point(90, 190);
    System.Drawing.Point point205 = point1;
    chkUpdatePopPrices1.Location = point205;
    this.chkUpdatePOPPrices.Name = "chkUpdatePOPPrices";
    this.chkUpdatePOPPrices.RightToLeft = RightToLeft.Yes;
    System.Windows.Forms.CheckBox chkUpdatePopPrices2 = this.chkUpdatePOPPrices;
    size1 = new Size(134, 24);
    Size size206 = size1;
    chkUpdatePopPrices2.Size = size206;
    this.chkUpdatePOPPrices.TabIndex = 53;
    this.chkUpdatePOPPrices.Text = "Update POP Prices";
    this.chkUpdatePOPPrices.TextAlign = ContentAlignment.MiddleRight;
    this.chkUpdatePOPPrices.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(1004, 671);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.tcMain);
    this.Controls.Add((Control) this.naviBar1);
    this.FormBorderStyle = FormBorderStyle.Fixed3D;
    this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmMain);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "IIHF Price Changing Utility - Zeljko 2026 V1.01";
    this.WindowState = FormWindowState.Maximized;
    this.tcMain.ResumeLayout(false);
    this.tpImport.ResumeLayout(false);
    this.tpImport.PerformLayout();
    this.gbImportResults.ResumeLayout(false);
    ((ISupportInitialize) this.PictureBox2).EndInit();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.tpTemplates.ResumeLayout(false);
    this.tpTemplates.PerformLayout();
    this.tpSettings.ResumeLayout(false);
    this.tpSettings.PerformLayout();
    this.tpManage.ResumeLayout(false);
    this.GroupBox4.ResumeLayout(false);
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.GroupBox3.ResumeLayout(false);
    this.tpExport.ResumeLayout(false);
    this.tpNewProducts.ResumeLayout(false);
    this.tpNewProducts.PerformLayout();
    ((ISupportInitialize) this.pBoxExportAsc).EndInit();
    ((ISupportInitialize) this.pBoxExportedAsc).EndInit();
    ((ISupportInitialize) this.pboxExportedDesc).EndInit();
    ((ISupportInitialize) this.pBoxExportDesc).EndInit();
    ((ISupportInitialize) this.pboxTemplateDesc).EndInit();
    ((ISupportInitialize) this.pBoxTemplateAsc).EndInit();
    ((ISupportInitialize) this.pboxImportedAsc).EndInit();
    ((ISupportInitialize) this.pboxImportedDesc).EndInit();
    ((ISupportInitialize) this.pboxWaitingAsc).EndInit();
    ((ISupportInitialize) this.pboxWaitingDesc).EndInit();
    this.naviBar1.EndInit();
    this.naviBar1.ResumeLayout(false);
    this.nbImport.ClientArea.ResumeLayout(false);
    this.nbImport.ResumeLayout(false);
    this.nbExport.ClientArea.ResumeLayout(false);
    this.nbExport.ResumeLayout(false);
    this.nbTemplates.ClientArea.ResumeLayout(false);
    this.nbTemplates.ResumeLayout(false);
    this.nbNewProducts.ClientArea.ResumeLayout(false);
    this.nbNewProducts.ResumeLayout(false);
    this.nbSettings.ClientArea.ResumeLayout(false);
    this.nbSettings.ResumeLayout(false);
    this.nbManagement.ClientArea.ResumeLayout(false);
    this.nbManagement.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual TabControl tcMain
  {
    [DebuggerNonUserCode] get => this._tcMain;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._tcMain = value;
  }

  internal virtual TabPage tpImport
  {
    [DebuggerNonUserCode] get => this._tpImport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._tpImport = value;
  }

  internal virtual TabPage tpTemplates
  {
    [DebuggerNonUserCode] get => this._tpTemplates;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._tpTemplates = value;
    }
  }

  internal virtual TabPage tpSettings
  {
    [DebuggerNonUserCode] get => this._tpSettings;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._tpSettings = value;
    }
  }

  internal virtual TabPage tpManage
  {
    [DebuggerNonUserCode] get => this._tpManage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.tpManage_Click);
      if (this._tpManage != null)
        this._tpManage.Click -= eventHandler;
      this._tpManage = value;
      if (this._tpManage == null)
        return;
      this._tpManage.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual System.Windows.Forms.TextBox txtSP
  {
    [DebuggerNonUserCode] get => this._txtSP;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtSP = value;
  }

  internal virtual System.Windows.Forms.Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual System.Windows.Forms.Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual System.Windows.Forms.Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual System.Windows.Forms.Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual System.Windows.Forms.CheckBox chkProductMapping
  {
    [DebuggerNonUserCode] get => this._chkProductMapping;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkProductMapping = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual System.Windows.Forms.CheckBox chkSterling
  {
    [DebuggerNonUserCode] get => this._chkSterling;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkSterling_CheckedChanged);
      if (this._chkSterling != null)
        this._chkSterling.CheckedChanged -= eventHandler;
      this._chkSterling = value;
      if (this._chkSterling == null)
        return;
      this._chkSterling.CheckedChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkEuro
  {
    [DebuggerNonUserCode] get => this._chkEuro;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkEuro_CheckedChanged);
      if (this._chkEuro != null)
        this._chkEuro.CheckedChanged -= eventHandler;
      this._chkEuro = value;
      if (this._chkEuro == null)
        return;
      this._chkEuro.CheckedChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkGross
  {
    [DebuggerNonUserCode] get => this._chkGross;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkGross_CheckedChanged);
      if (this._chkGross != null)
        this._chkGross.CheckedChanged -= eventHandler;
      this._chkGross = value;
      if (this._chkGross == null)
        return;
      this._chkGross.CheckedChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkNet
  {
    [DebuggerNonUserCode] get => this._chkNet;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkNet_CheckedChanged);
      if (this._chkNet != null)
        this._chkNet.CheckedChanged -= eventHandler;
      this._chkNet = value;
      if (this._chkNet == null)
        return;
      this._chkNet.CheckedChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual System.Windows.Forms.Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual System.Windows.Forms.Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual System.Windows.Forms.Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual System.Windows.Forms.TextBox txtTemplateName
  {
    [DebuggerNonUserCode] get => this._txtTemplateName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtTemplateName = value;
    }
  }

  internal virtual ComboBox cboCalcPrice1
  {
    [DebuggerNonUserCode] get => this._cboCalcPrice1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cboCalcPrice1 = value;
    }
  }

  internal virtual ComboBox cboCalcPrice2
  {
    [DebuggerNonUserCode] get => this._cboCalcPrice2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cboCalcPrice2 = value;
    }
  }

  internal virtual ComboBox cboCalcPrice3
  {
    [DebuggerNonUserCode] get => this._cboCalcPrice3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cboCalcPrice3 = value;
    }
  }

  internal virtual ComboBox cboSuppProduct
  {
    [DebuggerNonUserCode] get => this._cboSuppProduct;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cboSuppProduct = value;
    }
  }

  internal virtual ComboBox cboIIHFProductCode
  {
    [DebuggerNonUserCode] get => this._cboIIHFProductCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cboIIHFProductCode = value;
    }
  }

  internal virtual System.Windows.Forms.Button cmdSaveTemplate
  {
    [DebuggerNonUserCode] get => this._cmdSaveTemplate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdSaveTemplate_Click);
      if (this._cmdSaveTemplate != null)
        this._cmdSaveTemplate.Click -= eventHandler;
      this._cmdSaveTemplate = value;
      if (this._cmdSaveTemplate == null)
        return;
      this._cmdSaveTemplate.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label19
  {
    [DebuggerNonUserCode] get => this._Label19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
  }

  internal virtual System.Windows.Forms.Label Label18
  {
    [DebuggerNonUserCode] get => this._Label18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
  }

  internal virtual System.Windows.Forms.Label Label17
  {
    [DebuggerNonUserCode] get => this._Label17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
  }

  internal virtual System.Windows.Forms.Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual System.Windows.Forms.Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual System.Windows.Forms.TextBox txtPriceList
  {
    [DebuggerNonUserCode] get => this._txtPriceList;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtPriceList_Leave);
      if (this._txtPriceList != null)
        this._txtPriceList.Leave -= eventHandler;
      this._txtPriceList = value;
      if (this._txtPriceList == null)
        return;
      this._txtPriceList.Leave += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtSupplierCode
  {
    [DebuggerNonUserCode] get => this._txtSupplierCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtSupplierCode_Leave);
      EventHandler eventHandler2 = new EventHandler(this.txtSupplierCode_TextChanged);
      if (this._txtSupplierCode != null)
      {
        this._txtSupplierCode.Leave -= eventHandler1;
        this._txtSupplierCode.TextChanged -= eventHandler2;
      }
      this._txtSupplierCode = value;
      if (this._txtSupplierCode == null)
        return;
      this._txtSupplierCode.Leave += eventHandler1;
      this._txtSupplierCode.TextChanged += eventHandler2;
    }
  }

  internal virtual System.Windows.Forms.Button cmdDelete
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

  internal virtual System.Windows.Forms.Button cmdSearchSupplier
  {
    [DebuggerNonUserCode] get => this._cmdSearchSupplier;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdSearchSupplier_Click);
      if (this._cmdSearchSupplier != null)
        this._cmdSearchSupplier.Click -= eventHandler;
      this._cmdSearchSupplier = value;
      if (this._cmdSearchSupplier == null)
        return;
      this._cmdSearchSupplier.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button cmdSearchPriceList
  {
    [DebuggerNonUserCode] get => this._cmdSearchPriceList;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdSearchPriceList_Click);
      if (this._cmdSearchPriceList != null)
        this._cmdSearchPriceList.Click -= eventHandler;
      this._cmdSearchPriceList = value;
      if (this._cmdSearchPriceList == null)
        return;
      this._cmdSearchPriceList.Click += eventHandler;
    }
  }

  internal virtual ToolTip ToolTip1
  {
    [DebuggerNonUserCode] get => this._ToolTip1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolTip1 = value;
  }

  internal virtual System.Windows.Forms.Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual System.Windows.Forms.ListBox ListBox1
  {
    [DebuggerNonUserCode] get => this._ListBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ListBox1 = value;
  }

  internal virtual NaviBand nbSettings
  {
    [DebuggerNonUserCode] get => this._nbSettings;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.nbSettings_ClientSizeChanged);
      if (this._nbSettings != null)
        this._nbSettings.ClientSizeChanged -= eventHandler;
      this._nbSettings = value;
      if (this._nbSettings == null)
        return;
      this._nbSettings.ClientSizeChanged += eventHandler;
    }
  }

  internal virtual NaviBand nbTemplates
  {
    [DebuggerNonUserCode] get => this._nbTemplates;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.nbTemplates_ClientSizeChanged);
      if (this._nbTemplates != null)
        this._nbTemplates.ClientSizeChanged -= eventHandler;
      this._nbTemplates = value;
      if (this._nbTemplates == null)
        return;
      this._nbTemplates.ClientSizeChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.ListBox lbTemplates
  {
    [DebuggerNonUserCode] get => this._lbTemplates;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lbTemplates_SelectedIndexChanged);
      DrawItemEventHandler itemEventHandler = new DrawItemEventHandler(this.lbTemplates_DrawItem);
      if (this._lbTemplates != null)
      {
        this._lbTemplates.SelectedIndexChanged -= eventHandler;
        this._lbTemplates.DrawItem -= itemEventHandler;
      }
      this._lbTemplates = value;
      if (this._lbTemplates == null)
        return;
      this._lbTemplates.SelectedIndexChanged += eventHandler;
      this._lbTemplates.DrawItem += itemEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label lblNewTemplate
  {
    [DebuggerNonUserCode] get => this._lblNewTemplate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.lblNewTemplate_MouseLeave);
      EventHandler eventHandler2 = new EventHandler(this.lblNewTemplate_Click);
      EventHandler eventHandler3 = new EventHandler(this.lblNewTemplate_MouseHover);
      EventHandler eventHandler4 = new EventHandler(this.lblNewTemplate_MouseEnter);
      if (this._lblNewTemplate != null)
      {
        this._lblNewTemplate.MouseLeave -= eventHandler1;
        this._lblNewTemplate.Click -= eventHandler2;
        this._lblNewTemplate.MouseHover -= eventHandler3;
        this._lblNewTemplate.MouseEnter -= eventHandler4;
      }
      this._lblNewTemplate = value;
      if (this._lblNewTemplate == null)
        return;
      this._lblNewTemplate.MouseLeave += eventHandler1;
      this._lblNewTemplate.Click += eventHandler2;
      this._lblNewTemplate.MouseHover += eventHandler3;
      this._lblNewTemplate.MouseEnter += eventHandler4;
    }
  }

  internal virtual NaviBand nbImport
  {
    [DebuggerNonUserCode] get => this._nbImport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.nbImport_ClientSizeChanged);
      if (this._nbImport != null)
        this._nbImport.ClientSizeChanged -= eventHandler;
      this._nbImport = value;
      if (this._nbImport == null)
        return;
      this._nbImport.ClientSizeChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.ListBox lstImported
  {
    [DebuggerNonUserCode] get => this._lstImported;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DrawItemEventHandler itemEventHandler = new DrawItemEventHandler(this.lstImported_DrawItem);
      EventHandler eventHandler = new EventHandler(this.lstImported_Click);
      if (this._lstImported != null)
      {
        this._lstImported.DrawItem -= itemEventHandler;
        this._lstImported.Click -= eventHandler;
      }
      this._lstImported = value;
      if (this._lstImported == null)
        return;
      this._lstImported.DrawItem += itemEventHandler;
      this._lstImported.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.ListBox lstWaiting
  {
    [DebuggerNonUserCode] get => this._lstWaiting;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DrawItemEventHandler itemEventHandler = new DrawItemEventHandler(this.lstWaiting_DrawItem);
      EventHandler eventHandler1 = new EventHandler(this.lstWaiting_DoubleClick);
      EventHandler eventHandler2 = new EventHandler(this.lstWaiting_Click);
      if (this._lstWaiting != null)
      {
        this._lstWaiting.DrawItem -= itemEventHandler;
        this._lstWaiting.DoubleClick -= eventHandler1;
        this._lstWaiting.Click -= eventHandler2;
      }
      this._lstWaiting = value;
      if (this._lstWaiting == null)
        return;
      this._lstWaiting.DrawItem += itemEventHandler;
      this._lstWaiting.DoubleClick += eventHandler1;
      this._lstWaiting.Click += eventHandler2;
    }
  }

  internal virtual System.Windows.Forms.Label lblImported
  {
    [DebuggerNonUserCode] get => this._lblImported;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblImported = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblWaiting
  {
    [DebuggerNonUserCode] get => this._lblWaiting;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblWaiting = value;
    }
  }

  internal virtual NaviBar naviBar1
  {
    [DebuggerNonUserCode] get => this._naviBar1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.naviBar1_ActiveBandChanged);
      if (this._naviBar1 != null)
        this._naviBar1.ActiveBandChanged -= eventHandler;
      this._naviBar1 = value;
      if (this._naviBar1 == null)
        return;
      this._naviBar1.ActiveBandChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button cmdBrowse
  {
    [DebuggerNonUserCode] get => this._cmdBrowse;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdBrowse_Click);
      if (this._cmdBrowse != null)
        this._cmdBrowse.Click -= eventHandler;
      this._cmdBrowse = value;
      if (this._cmdBrowse == null)
        return;
      this._cmdBrowse.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtImport
  {
    [DebuggerNonUserCode] get => this._txtImport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtImport = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label22
  {
    [DebuggerNonUserCode] get => this._Label22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label22 = value;
  }

  internal virtual System.Windows.Forms.Label lblTemplateName
  {
    [DebuggerNonUserCode] get => this._lblTemplateName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTemplateName = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblSheets
  {
    [DebuggerNonUserCode] get => this._lblSheets;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSheets = value;
    }
  }

  internal virtual System.Windows.Forms.GroupBox gbImportResults
  {
    [DebuggerNonUserCode] get => this._gbImportResults;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._gbImportResults = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblMapped
  {
    [DebuggerNonUserCode] get => this._lblMapped;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMapped = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblValid
  {
    [DebuggerNonUserCode] get => this._lblValid;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblValid = value;
  }

  internal virtual System.Windows.Forms.Label lblTotalImported
  {
    [DebuggerNonUserCode] get => this._lblTotalImported;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTotalImported = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label25
  {
    [DebuggerNonUserCode] get => this._Label25;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label25 = value;
  }

  internal virtual System.Windows.Forms.Label Label24
  {
    [DebuggerNonUserCode] get => this._Label24;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label24 = value;
  }

  internal virtual System.Windows.Forms.Label Label23
  {
    [DebuggerNonUserCode] get => this._Label23;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label23 = value;
  }

  internal virtual PictureBox PictureBox2
  {
    [DebuggerNonUserCode] get => this._PictureBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._PictureBox2 = value;
    }
  }

  internal virtual PictureBox PictureBox1
  {
    [DebuggerNonUserCode] get => this._PictureBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._PictureBox1 = value;
    }
  }

  internal virtual System.Windows.Forms.ListBox lstSheets
  {
    [DebuggerNonUserCode] get => this._lstSheets;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DrawItemEventHandler itemEventHandler = new DrawItemEventHandler(this.lstSheets_DrawItem);
      EventHandler eventHandler = new EventHandler(this.lstSheets_Click);
      if (this._lstSheets != null)
      {
        this._lstSheets.DrawItem -= itemEventHandler;
        this._lstSheets.Click -= eventHandler;
      }
      this._lstSheets = value;
      if (this._lstSheets == null)
        return;
      this._lstSheets.DrawItem += itemEventHandler;
      this._lstSheets.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button cmdImport
  {
    [DebuggerNonUserCode] get => this._cmdImport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdImport_Click);
      if (this._cmdImport != null)
        this._cmdImport.Click -= eventHandler;
      this._cmdImport = value;
      if (this._cmdImport == null)
        return;
      this._cmdImport.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button cmdSaveSettings
  {
    [DebuggerNonUserCode] get => this._cmdSaveSettings;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdSaveSettings_Click);
      if (this._cmdSaveSettings != null)
        this._cmdSaveSettings.Click -= eventHandler;
      this._cmdSaveSettings = value;
      if (this._cmdSaveSettings == null)
        return;
      this._cmdSaveSettings.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtExchRate
  {
    [DebuggerNonUserCode] get => this._txtExchRate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtExchRate = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  internal virtual System.Windows.Forms.Label Label21
  {
    [DebuggerNonUserCode] get => this._Label21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label21 = value;
  }

  internal virtual System.Windows.Forms.ListBox lstSettings
  {
    [DebuggerNonUserCode] get => this._lstSettings;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lstSettings = value;
    }
  }

  internal virtual PictureBox pboxImportedAsc
  {
    [DebuggerNonUserCode] get => this._pboxImportedAsc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.pboxImportedAsc_Click);
      EventHandler eventHandler2 = new EventHandler(this.pboxImportedAsc_MouseHover);
      EventHandler eventHandler3 = new EventHandler(this.pboxImportedAsc_MouseEnter);
      if (this._pboxImportedAsc != null)
      {
        this._pboxImportedAsc.Click -= eventHandler1;
        this._pboxImportedAsc.MouseHover -= eventHandler2;
        this._pboxImportedAsc.MouseEnter -= eventHandler3;
      }
      this._pboxImportedAsc = value;
      if (this._pboxImportedAsc == null)
        return;
      this._pboxImportedAsc.Click += eventHandler1;
      this._pboxImportedAsc.MouseHover += eventHandler2;
      this._pboxImportedAsc.MouseEnter += eventHandler3;
    }
  }

  internal virtual PictureBox pboxWaitingAsc
  {
    [DebuggerNonUserCode] get => this._pboxWaitingAsc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.pboxWaitingAsc_MouseHover);
      EventHandler eventHandler2 = new EventHandler(this.pboxWaitingAsc_MouseEnter);
      EventHandler eventHandler3 = new EventHandler(this.pboxWaitingAsc_Click);
      if (this._pboxWaitingAsc != null)
      {
        this._pboxWaitingAsc.MouseHover -= eventHandler1;
        this._pboxWaitingAsc.MouseEnter -= eventHandler2;
        this._pboxWaitingAsc.Click -= eventHandler3;
      }
      this._pboxWaitingAsc = value;
      if (this._pboxWaitingAsc == null)
        return;
      this._pboxWaitingAsc.MouseHover += eventHandler1;
      this._pboxWaitingAsc.MouseEnter += eventHandler2;
      this._pboxWaitingAsc.Click += eventHandler3;
    }
  }

  internal virtual PictureBox pboxWaitingDesc
  {
    [DebuggerNonUserCode] get => this._pboxWaitingDesc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.pboxWaitingDesc_Click);
      EventHandler eventHandler2 = new EventHandler(this.pboxWaitingDesc_MouseHover);
      EventHandler eventHandler3 = new EventHandler(this.pboxWaitingDesc_MouseEnter);
      if (this._pboxWaitingDesc != null)
      {
        this._pboxWaitingDesc.Click -= eventHandler1;
        this._pboxWaitingDesc.MouseHover -= eventHandler2;
        this._pboxWaitingDesc.MouseEnter -= eventHandler3;
      }
      this._pboxWaitingDesc = value;
      if (this._pboxWaitingDesc == null)
        return;
      this._pboxWaitingDesc.Click += eventHandler1;
      this._pboxWaitingDesc.MouseHover += eventHandler2;
      this._pboxWaitingDesc.MouseEnter += eventHandler3;
    }
  }

  internal virtual PictureBox pboxImportedDesc
  {
    [DebuggerNonUserCode] get => this._pboxImportedDesc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.pboxImportedDesc_Click);
      EventHandler eventHandler2 = new EventHandler(this.pboxImportedDesc_MouseHover);
      EventHandler eventHandler3 = new EventHandler(this.pboxImportedDesc_MouseEnter);
      if (this._pboxImportedDesc != null)
      {
        this._pboxImportedDesc.Click -= eventHandler1;
        this._pboxImportedDesc.MouseHover -= eventHandler2;
        this._pboxImportedDesc.MouseEnter -= eventHandler3;
      }
      this._pboxImportedDesc = value;
      if (this._pboxImportedDesc == null)
        return;
      this._pboxImportedDesc.Click += eventHandler1;
      this._pboxImportedDesc.MouseHover += eventHandler2;
      this._pboxImportedDesc.MouseEnter += eventHandler3;
    }
  }

  internal virtual PictureBox pBoxTemplateAsc
  {
    [DebuggerNonUserCode] get => this._pBoxTemplateAsc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.pBoxTemplateAsc_Click);
      if (this._pBoxTemplateAsc != null)
        this._pBoxTemplateAsc.Click -= eventHandler;
      this._pBoxTemplateAsc = value;
      if (this._pBoxTemplateAsc == null)
        return;
      this._pBoxTemplateAsc.Click += eventHandler;
    }
  }

  internal virtual PictureBox pboxTemplateDesc
  {
    [DebuggerNonUserCode] get => this._pboxTemplateDesc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.pboxTemplateDesc_Click);
      if (this._pboxTemplateDesc != null)
        this._pboxTemplateDesc.Click -= eventHandler;
      this._pboxTemplateDesc = value;
      if (this._pboxTemplateDesc == null)
        return;
      this._pboxTemplateDesc.Click += eventHandler;
    }
  }

  internal virtual NaviBand nbManagement
  {
    [DebuggerNonUserCode] get => this._nbManagement;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.nbManagement_ClientSizeChanged);
      if (this._nbManagement != null)
        this._nbManagement.ClientSizeChanged -= eventHandler;
      this._nbManagement = value;
      if (this._nbManagement == null)
        return;
      this._nbManagement.ClientSizeChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.ListBox lstManagement
  {
    [DebuggerNonUserCode] get => this._lstManagement;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lstManagement = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual System.Windows.Forms.GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkRecalcSalesUplift
  {
    [DebuggerNonUserCode] get => this._chkRecalcSalesUplift;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkRecalcSalesUplift = value;
    }
  }

  internal virtual System.Windows.Forms.Button cmdProcessDBMaint
  {
    [DebuggerNonUserCode] get => this._cmdProcessDBMaint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdProcess_Click);
      if (this._cmdProcessDBMaint != null)
        this._cmdProcessDBMaint.Click -= eventHandler;
      this._cmdProcessDBMaint = value;
      if (this._cmdProcessDBMaint == null)
        return;
      this._cmdProcessDBMaint.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkBackup
  {
    [DebuggerNonUserCode] get => this._chkBackup;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkBackup = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtBackupPath
  {
    [DebuggerNonUserCode] get => this._txtBackupPath;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtBackupPath = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual System.Windows.Forms.CheckBox chkReindex
  {
    [DebuggerNonUserCode] get => this._chkReindex;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkReindex = value;
    }
  }

  internal virtual System.Windows.Forms.Button cmdRemap
  {
    [DebuggerNonUserCode] get => this._cmdRemap;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdRemap_Click);
      if (this._cmdRemap != null)
        this._cmdRemap.Click -= eventHandler;
      this._cmdRemap = value;
      if (this._cmdRemap == null)
        return;
      this._cmdRemap.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label lblLastRunReindex
  {
    [DebuggerNonUserCode] get => this._lblLastRunReindex;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastRunReindex = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblLastRunBackup
  {
    [DebuggerNonUserCode] get => this._lblLastRunBackup;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastRunBackup = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblLastRunRecalc
  {
    [DebuggerNonUserCode] get => this._lblLastRunRecalc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastRunRecalc = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblLastRunNewSell
  {
    [DebuggerNonUserCode] get => this._lblLastRunNewSell;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastRunNewSell = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkRecalcNewSell
  {
    [DebuggerNonUserCode] get => this._chkRecalcNewSell;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkRecalcNewSell = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblLastRunClearDown
  {
    [DebuggerNonUserCode] get => this._lblLastRunClearDown;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastRunClearDown = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkClearImported
  {
    [DebuggerNonUserCode] get => this._chkClearImported;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkClearImported = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblLastRunCalcRetail
  {
    [DebuggerNonUserCode] get => this._lblLastRunCalcRetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastRunCalcRetail = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkRecalcNewRetail
  {
    [DebuggerNonUserCode] get => this._chkRecalcNewRetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkRecalcNewRetail = value;
    }
  }

  internal virtual System.Windows.Forms.GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtNotes
  {
    [DebuggerNonUserCode] get => this._txtNotes;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtNotes = value;
  }

  internal virtual System.Windows.Forms.Label Label20
  {
    [DebuggerNonUserCode] get => this._Label20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label20 = value;
  }

  internal virtual System.Windows.Forms.Label Label26
  {
    [DebuggerNonUserCode] get => this._Label26;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label26 = value;
  }

  internal virtual System.Windows.Forms.TextBox txtTemplateNotes
  {
    [DebuggerNonUserCode] get => this._txtTemplateNotes;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtTemplateNotes_KeyPress);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtTemplateNotes_KeyDown);
      if (this._txtTemplateNotes != null)
      {
        this._txtTemplateNotes.KeyPress -= pressEventHandler;
        this._txtTemplateNotes.KeyDown -= keyEventHandler;
      }
      this._txtTemplateNotes = value;
      if (this._txtTemplateNotes == null)
        return;
      this._txtTemplateNotes.KeyPress += pressEventHandler;
      this._txtTemplateNotes.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkOverwriteCosts
  {
    [DebuggerNonUserCode] get => this._chkOverwriteCosts;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkOverwriteCosts = value;
    }
  }

  internal virtual RadioButton radSell
  {
    [DebuggerNonUserCode] get => this._radSell;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.radSell_CheckedChanged);
      if (this._radSell != null)
        this._radSell.CheckedChanged -= eventHandler;
      this._radSell = value;
      if (this._radSell == null)
        return;
      this._radSell.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton radRetail
  {
    [DebuggerNonUserCode] get => this._radRetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.radRetail_CheckedChanged);
      if (this._radRetail != null)
        this._radRetail.CheckedChanged -= eventHandler;
      this._radRetail = value;
      if (this._radRetail == null)
        return;
      this._radRetail.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton radCost
  {
    [DebuggerNonUserCode] get => this._radCost;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.radCost_CheckedChanged);
      if (this._radCost != null)
        this._radCost.CheckedChanged -= eventHandler;
      this._radCost = value;
      if (this._radCost == null)
        return;
      this._radCost.CheckedChanged += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button cmdBrowseApprovedPrices
  {
    [DebuggerNonUserCode] get => this._cmdBrowseApprovedPrices;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdBrowseApprovedPrices_Click);
      if (this._cmdBrowseApprovedPrices != null)
        this._cmdBrowseApprovedPrices.Click -= eventHandler;
      this._cmdBrowseApprovedPrices = value;
      if (this._cmdBrowseApprovedPrices == null)
        return;
      this._cmdBrowseApprovedPrices.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtImportApproved
  {
    [DebuggerNonUserCode] get => this._txtImportApproved;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtImportApproved = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label27
  {
    [DebuggerNonUserCode] get => this._Label27;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label27 = value;
  }

  internal virtual System.Windows.Forms.Button cmdImportApproved
  {
    [DebuggerNonUserCode] get => this._cmdImportApproved;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdImportApproved_Click);
      if (this._cmdImportApproved != null)
        this._cmdImportApproved.Click -= eventHandler;
      this._cmdImportApproved = value;
      if (this._cmdImportApproved == null)
        return;
      this._cmdImportApproved.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button cmdRemoveImported
  {
    [DebuggerNonUserCode] get => this._cmdRemoveImported;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdRemoveImported_Click);
      if (this._cmdRemoveImported != null)
        this._cmdRemoveImported.Click -= eventHandler;
      this._cmdRemoveImported = value;
      if (this._cmdRemoveImported == null)
        return;
      this._cmdRemoveImported.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button cmdProcessData
  {
    [DebuggerNonUserCode] get => this._cmdProcessData;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdProcessData_Click);
      if (this._cmdProcessData != null)
        this._cmdProcessData.Click -= eventHandler;
      this._cmdProcessData = value;
      if (this._cmdProcessData == null)
        return;
      this._cmdProcessData.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkOverwriteRetail
  {
    [DebuggerNonUserCode] get => this._chkOverwriteRetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkOverwriteRetail = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkOverwriteSell
  {
    [DebuggerNonUserCode] get => this._chkOverwriteSell;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkOverwriteSell = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblLastRunOverwriteApprovedRetail
  {
    [DebuggerNonUserCode] get => this._lblLastRunOverwriteApprovedRetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastRunOverwriteApprovedRetail = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblLastRunOverwriteApprovedSell
  {
    [DebuggerNonUserCode] get => this._lblLastRunOverwriteApprovedSell;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastRunOverwriteApprovedSell = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblLastRunOverwriteApprovedCosts
  {
    [DebuggerNonUserCode] get => this._lblLastRunOverwriteApprovedCosts;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastRunOverwriteApprovedCosts = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkStandard
  {
    [DebuggerNonUserCode] get => this._chkStandard;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkStandard = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtEmail
  {
    [DebuggerNonUserCode] get => this._txtEmail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtEmail = value;
  }

  internal virtual System.Windows.Forms.Label Label28
  {
    [DebuggerNonUserCode] get => this._Label28;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label28 = value;
  }

  internal virtual NaviBand nbExport
  {
    [DebuggerNonUserCode] get => this._nbExport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.nbExport_ClientSizeChanged);
      if (this._nbExport != null)
        this._nbExport.ClientSizeChanged -= eventHandler;
      this._nbExport = value;
      if (this._nbExport == null)
        return;
      this._nbExport.ClientSizeChanged += eventHandler;
    }
  }

  internal virtual TabPage tpExport
  {
    [DebuggerNonUserCode] get => this._tpExport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._tpExport = value;
  }

  internal virtual System.Windows.Forms.Label Label29
  {
    [DebuggerNonUserCode] get => this._Label29;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label29 = value;
  }

  internal virtual System.Windows.Forms.ListBox lstExported
  {
    [DebuggerNonUserCode] get => this._lstExported;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DrawItemEventHandler itemEventHandler = new DrawItemEventHandler(this.lstExported_DrawItem);
      EventHandler eventHandler = new EventHandler(this.lstExported_Click);
      if (this._lstExported != null)
      {
        this._lstExported.DrawItem -= itemEventHandler;
        this._lstExported.Click -= eventHandler;
      }
      this._lstExported = value;
      if (this._lstExported == null)
        return;
      this._lstExported.DrawItem += itemEventHandler;
      this._lstExported.Click += eventHandler;
    }
  }

  internal virtual PictureBox pBoxExportAsc
  {
    [DebuggerNonUserCode] get => this._pBoxExportAsc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.pBoxExportAsc_Click);
      if (this._pBoxExportAsc != null)
        this._pBoxExportAsc.Click -= eventHandler;
      this._pBoxExportAsc = value;
      if (this._pBoxExportAsc == null)
        return;
      this._pBoxExportAsc.Click += eventHandler;
    }
  }

  internal virtual PictureBox pBoxExportedAsc
  {
    [DebuggerNonUserCode] get => this._pBoxExportedAsc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.pBoxExportedAsc_Click);
      if (this._pBoxExportedAsc != null)
        this._pBoxExportedAsc.Click -= eventHandler;
      this._pBoxExportedAsc = value;
      if (this._pBoxExportedAsc == null)
        return;
      this._pBoxExportedAsc.Click += eventHandler;
    }
  }

  internal virtual PictureBox pboxExportedDesc
  {
    [DebuggerNonUserCode] get => this._pboxExportedDesc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.pboxExportedDesc_Click);
      if (this._pboxExportedDesc != null)
        this._pboxExportedDesc.Click -= eventHandler;
      this._pboxExportedDesc = value;
      if (this._pboxExportedDesc == null)
        return;
      this._pboxExportedDesc.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.ListBox lstExport
  {
    [DebuggerNonUserCode] get => this._lstExport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DrawItemEventHandler itemEventHandler = new DrawItemEventHandler(this.lstExport_DrawItem);
      EventHandler eventHandler1 = new EventHandler(this.lstExport_DoubleClick);
      EventHandler eventHandler2 = new EventHandler(this.lstExport_Click);
      EventHandler eventHandler3 = new EventHandler(this.lstExport_SelectedIndexChanged);
      if (this._lstExport != null)
      {
        this._lstExport.DrawItem -= itemEventHandler;
        this._lstExport.DoubleClick -= eventHandler1;
        this._lstExport.Click -= eventHandler2;
        this._lstExport.SelectedIndexChanged -= eventHandler3;
      }
      this._lstExport = value;
      if (this._lstExport == null)
        return;
      this._lstExport.DrawItem += itemEventHandler;
      this._lstExport.DoubleClick += eventHandler1;
      this._lstExport.Click += eventHandler2;
      this._lstExport.SelectedIndexChanged += eventHandler3;
    }
  }

  internal virtual PictureBox pBoxExportDesc
  {
    [DebuggerNonUserCode] get => this._pBoxExportDesc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.pBoxExportDesc_Click);
      if (this._pBoxExportDesc != null)
        this._pBoxExportDesc.Click -= eventHandler;
      this._pBoxExportDesc = value;
      if (this._pBoxExportDesc == null)
        return;
      this._pBoxExportDesc.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label lblExported
  {
    [DebuggerNonUserCode] get => this._lblExported;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblExported = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblExport
  {
    [DebuggerNonUserCode] get => this._lblExport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblExport = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblExportLocation
  {
    [DebuggerNonUserCode] get => this._lblExportLocation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblExportLocation = value;
    }
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

  internal virtual System.Windows.Forms.Label lblExportTemplateName
  {
    [DebuggerNonUserCode] get => this._lblExportTemplateName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblExportTemplateName = value;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtExportLocation
  {
    [DebuggerNonUserCode] get => this._txtExportLocation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtExportLocation = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label30
  {
    [DebuggerNonUserCode] get => this._Label30;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label30 = value;
  }

  internal virtual System.Windows.Forms.Button cmdBrowseExportFolder
  {
    [DebuggerNonUserCode] get => this._cmdBrowseExportFolder;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdBrowseExportFolder_Click);
      if (this._cmdBrowseExportFolder != null)
        this._cmdBrowseExportFolder.Click -= eventHandler;
      this._cmdBrowseExportFolder = value;
      if (this._cmdBrowseExportFolder == null)
        return;
      this._cmdBrowseExportFolder.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button cmdBrowseBackupFoler
  {
    [DebuggerNonUserCode] get => this._cmdBrowseBackupFoler;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdBrowseBackupFoler_Click);
      if (this._cmdBrowseBackupFoler != null)
        this._cmdBrowseBackupFoler.Click -= eventHandler;
      this._cmdBrowseBackupFoler = value;
      if (this._cmdBrowseBackupFoler == null)
        return;
      this._cmdBrowseBackupFoler.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label lblExportFile
  {
    [DebuggerNonUserCode] get => this._lblExportFile;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblExportFile = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label32
  {
    [DebuggerNonUserCode] get => this._Label32;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label32 = value;
  }

  internal virtual System.Windows.Forms.Label lblEmail
  {
    [DebuggerNonUserCode] get => this._lblEmail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblEmail = value;
  }

  internal virtual System.Windows.Forms.Label Label33
  {
    [DebuggerNonUserCode] get => this._Label33;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label33 = value;
  }

  internal virtual System.Windows.Forms.Button cmdResetExportedFlag
  {
    [DebuggerNonUserCode] get => this._cmdResetExportedFlag;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdResetExportedFlag_Click);
      if (this._cmdResetExportedFlag != null)
        this._cmdResetExportedFlag.Click -= eventHandler;
      this._cmdResetExportedFlag = value;
      if (this._cmdResetExportedFlag == null)
        return;
      this._cmdResetExportedFlag.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.TextBox txteMailBody
  {
    [DebuggerNonUserCode] get => this._txteMailBody;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txteMailBody = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label34
  {
    [DebuggerNonUserCode] get => this._Label34;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label34 = value;
  }

  internal virtual System.Windows.Forms.TextBox txteMailSubject
  {
    [DebuggerNonUserCode] get => this._txteMailSubject;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txteMailSubject = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label31
  {
    [DebuggerNonUserCode] get => this._Label31;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label31 = value;
  }

  internal virtual NaviBand nbNewProducts
  {
    [DebuggerNonUserCode] get => this._nbNewProducts;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.nbNewProducts_ClientSizeChanged);
      if (this._nbNewProducts != null)
        this._nbNewProducts.ClientSizeChanged -= eventHandler;
      this._nbNewProducts = value;
      if (this._nbNewProducts == null)
        return;
      this._nbNewProducts.ClientSizeChanged += eventHandler;
    }
  }

  internal virtual TabPage tpNewProducts
  {
    [DebuggerNonUserCode] get => this._tpNewProducts;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.tpNewProducts_Click);
      if (this._tpNewProducts != null)
        this._tpNewProducts.Click -= eventHandler;
      this._tpNewProducts = value;
      if (this._tpNewProducts == null)
        return;
      this._tpNewProducts.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.ListBox lstNewProducts
  {
    [DebuggerNonUserCode] get => this._lstNewProducts;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lstNewProducts = value;
    }
  }

  internal virtual System.Windows.Forms.Button cmdImportNewProducts
  {
    [DebuggerNonUserCode] get => this._cmdImportNewProducts;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdImportNewProducts_Click);
      if (this._cmdImportNewProducts != null)
        this._cmdImportNewProducts.Click -= eventHandler;
      this._cmdImportNewProducts = value;
      if (this._cmdImportNewProducts == null)
        return;
      this._cmdImportNewProducts.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button cmdBrowseNewProducts
  {
    [DebuggerNonUserCode] get => this._cmdBrowseNewProducts;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdBrowseNewProducts_Click);
      if (this._cmdBrowseNewProducts != null)
        this._cmdBrowseNewProducts.Click -= eventHandler;
      this._cmdBrowseNewProducts = value;
      if (this._cmdBrowseNewProducts == null)
        return;
      this._cmdBrowseNewProducts.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtImportNewProducts
  {
    [DebuggerNonUserCode] get => this._txtImportNewProducts;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtImportNewProducts = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label35
  {
    [DebuggerNonUserCode] get => this._Label35;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label35 = value;
  }

  internal virtual System.Windows.Forms.Label Label36
  {
    [DebuggerNonUserCode] get => this._Label36;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label36 = value;
  }

  internal virtual System.Windows.Forms.Label lblNewProductsLastImported
  {
    [DebuggerNonUserCode] get => this._lblNewProductsLastImported;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblNewProductsLastImported = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label37
  {
    [DebuggerNonUserCode] get => this._Label37;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label37 = value;
  }

  internal virtual System.Windows.Forms.Label lblMappedINdex
  {
    [DebuggerNonUserCode] get => this._lblMappedINdex;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMappedINdex = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblMappedPriceLists
  {
    [DebuggerNonUserCode] get => this._lblMappedPriceLists;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMappedPriceLists = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblMappedSuppliers
  {
    [DebuggerNonUserCode] get => this._lblMappedSuppliers;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMappedSuppliers = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblMappedSubGroups
  {
    [DebuggerNonUserCode] get => this._lblMappedSubGroups;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMappedSubGroups = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblMappedProductGroups
  {
    [DebuggerNonUserCode] get => this._lblMappedProductGroups;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMappedProductGroups = value;
    }
  }

  internal virtual RadioButton radResolveIndex
  {
    [DebuggerNonUserCode] get => this._radResolveIndex;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._radResolveIndex = value;
    }
  }

  internal virtual RadioButton radResolveSuppliers
  {
    [DebuggerNonUserCode] get => this._radResolveSuppliers;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._radResolveSuppliers = value;
    }
  }

  internal virtual RadioButton radResolveSubGroups
  {
    [DebuggerNonUserCode] get => this._radResolveSubGroups;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._radResolveSubGroups = value;
    }
  }

  internal virtual RadioButton radResolveProdGroups
  {
    [DebuggerNonUserCode] get => this._radResolveProdGroups;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._radResolveProdGroups = value;
    }
  }

  internal virtual System.Windows.Forms.Button cmdResolve
  {
    [DebuggerNonUserCode] get => this._cmdResolve;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdResolve_Click);
      if (this._cmdResolve != null)
        this._cmdResolve.Click -= eventHandler;
      this._cmdResolve = value;
      if (this._cmdResolve == null)
        return;
      this._cmdResolve.Click += eventHandler;
    }
  }

    //Added by Zeljko
    internal virtual System.Windows.Forms.Button cmdResolveClear
    {
        [DebuggerNonUserCode]
        get => this._cmdResolveClear;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler eventHandler = new EventHandler(this.cmdResolveClear_Click);
            if (this._cmdResolveClear != null)
                this._cmdResolveClear.Click -= eventHandler;
            this._cmdResolveClear = value;
            if (this._cmdResolveClear == null)
                return;
            this._cmdResolveClear.Click += eventHandler;
        }
    }

    internal virtual System.Windows.Forms.Button cmdExportAll
  {
    [DebuggerNonUserCode] get => this._cmdExportAll;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdExportAll_Click);
      if (this._cmdExportAll != null)
        this._cmdExportAll.Click -= eventHandler;
      this._cmdExportAll = value;
      if (this._cmdExportAll == null)
        return;
      this._cmdExportAll.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.TextBox txteMailSender
  {
    [DebuggerNonUserCode] get => this._txteMailSender;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txteMailSender = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label38
  {
    [DebuggerNonUserCode] get => this._Label38;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label38 = value;
  }

  internal virtual System.Windows.Forms.CheckBox chkAttach
  {
    [DebuggerNonUserCode] get => this._chkAttach;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkAttach = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkOutlook
  {
    [DebuggerNonUserCode] get => this._chkOutlook;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkOutlook = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblInfo
  {
    [DebuggerNonUserCode] get => this._lblInfo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblInfo = value;
  }

  internal virtual System.Windows.Forms.Label lblSpam
  {
    [DebuggerNonUserCode] get => this._lblSpam;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSpam = value;
  }

  internal virtual ProgressBar pbarSpam
  {
    [DebuggerNonUserCode] get => this._pbarSpam;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pbarSpam = value;
  }

  internal virtual System.Windows.Forms.Button cmdUpdateProducts
  {
    [DebuggerNonUserCode] get => this._cmdUpdateProducts;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdUpdateProducts_Click);
      if (this._cmdUpdateProducts != null)
        this._cmdUpdateProducts.Click -= eventHandler;
      this._cmdUpdateProducts = value;
      if (this._cmdUpdateProducts == null)
        return;
      this._cmdUpdateProducts.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label lblUpdateParams
  {
    [DebuggerNonUserCode] get => this._lblUpdateParams;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblUpdateParams = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblCreateNominals
  {
    [DebuggerNonUserCode] get => this._lblCreateNominals;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblCreateNominals = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblUpdateTaxCodes
  {
    [DebuggerNonUserCode] get => this._lblUpdateTaxCodes;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblUpdateTaxCodes = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblCreateStockCodes
  {
    [DebuggerNonUserCode] get => this._lblCreateStockCodes;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblCreateStockCodes = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblUpdateInfo
  {
    [DebuggerNonUserCode] get => this._lblUpdateInfo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblUpdateInfo = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblCreateIndexRecords
  {
    [DebuggerNonUserCode] get => this._lblCreateIndexRecords;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblCreateIndexRecords = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblCreatePriceBands
  {
    [DebuggerNonUserCode] get => this._lblCreatePriceBands;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblCreatePriceBands = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblUpdateNominals
  {
    [DebuggerNonUserCode] get => this._lblUpdateNominals;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblUpdateNominals = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblCreateProdultListItems
  {
    [DebuggerNonUserCode] get => this._lblCreateProdultListItems;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblCreateProdultListItems = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblPriceList
  {
    [DebuggerNonUserCode] get => this._lblPriceList;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblPriceList = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label40
  {
    [DebuggerNonUserCode] get => this._Label40;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label40 = value;
  }

  internal virtual System.Windows.Forms.GroupBox GroupBox4
  {
    [DebuggerNonUserCode] get => this._GroupBox4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox4 = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblLastRunDateCopyPending
  {
    [DebuggerNonUserCode] get => this._lblLastRunDateCopyPending;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastRunDateCopyPending = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkCopyPending
  {
    [DebuggerNonUserCode] get => this._chkCopyPending;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkCopyPending = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkIncludeDeleted
  {
    [DebuggerNonUserCode] get => this._chkIncludeDeleted;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkIncludeDeleted = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkDuplicateProducts
  {
    [DebuggerNonUserCode] get => this._chkDuplicateProducts;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkDuplicateProducts = value;
    }
  }

  internal virtual System.Windows.Forms.Button cmdProductMaint
  {
    [DebuggerNonUserCode] get => this._cmdProductMaint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmdProductMaint_Click);
      if (this._cmdProductMaint != null)
        this._cmdProductMaint.Click -= eventHandler;
      this._cmdProductMaint = value;
      if (this._cmdProductMaint == null)
        return;
      this._cmdProductMaint.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label lblLastUpdatePOPPrices
  {
    [DebuggerNonUserCode] get => this._lblLastUpdatePOPPrices;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastUpdatePOPPrices = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkUpdatePOPPrices
  {
    [DebuggerNonUserCode] get => this._chkUpdatePOPPrices;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkUpdatePOPPrices = value;
    }
  }

  internal virtual System.Windows.Forms.Label lblLastRunUpdateCostSellRetail
  {
    [DebuggerNonUserCode] get => this._lblLastRunUpdateCostSellRetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblLastRunUpdateCostSellRetail = value;
    }
  }

  internal virtual System.Windows.Forms.CheckBox chkUpdateCostSellretail
  {
    [DebuggerNonUserCode] get => this._chkUpdateCostSellretail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkUpdateCostSellretail = value;
    }
  }

  private void frmMain_ImeModeChanged(object sender, EventArgs e)
  {
  }

  private void frmMain_Load(object sender, EventArgs e)
  {
    if (Process.GetProcessesByName(this.aProcName).Length > 1)
    {
      modMain.mgBox("Application is already running");
      System.Windows.Forms.Application.Exit();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Environment.UserName.ToLower(), "pfttt", false) == 0)
      this.naviBar1.Buttons[2].Enabled = false;
    this.lbTemplates.BringToFront();
    this.pboxImportedDesc.Top = this.pboxImportedAsc.Top;
    this.pboxImportedDesc.Left = this.pboxImportedAsc.Left;
    this.pboxWaitingDesc.Top = this.pboxWaitingAsc.Top;
    this.pboxWaitingDesc.Left = this.pboxWaitingAsc.Left;
    this.pboxTemplateDesc.Top = this.pBoxTemplateAsc.Top;
    this.pboxTemplateDesc.Left = this.pBoxTemplateAsc.Left;
    this.pBoxExportDesc.Top = this.pBoxExportAsc.Top;
    this.pBoxExportDesc.Left = this.pBoxExportAsc.Left;
    this.pboxExportedDesc.Top = this.pBoxExportedAsc.Top;
    this.pboxExportedDesc.Left = this.pBoxExportedAsc.Left;
    modMain.GetConfigDom();
    this.GetSettings();
    this.CheckActionLog();
    this.RefreshTemplates(true);
    this.tcMain.SizeMode = TabSizeMode.Fixed;
    this.tcMain.ItemSize = new Size(0, 1);
    this.tcMain.Appearance = TabAppearance.Buttons;
    this.tcMain.SelectedTab = this.tpImport;
    this.naviBar1.ActiveBand = this.nbImport;
  }

  public void SetManagementTab()
  {
    this.chkBackup.ForeColor = Color.Black;
    this.chkBackup.Checked = false;
    this.chkClearImported.ForeColor = Color.Black;
    this.chkClearImported.Checked = false;
    this.chkRecalcSalesUplift.ForeColor = Color.Black;
    this.chkRecalcSalesUplift.Checked = false;
    this.chkReindex.ForeColor = Color.Black;
    this.chkReindex.Checked = false;
    this.chkRecalcNewSell.ForeColor = Color.Black;
    this.chkRecalcNewSell.Checked = false;
    this.chkOverwriteCosts.ForeColor = Color.Black;
    this.chkOverwriteCosts.Checked = false;
    this.chkOverwriteSell.ForeColor = Color.Black;
    this.chkOverwriteSell.Checked = false;
    this.chkOverwriteRetail.ForeColor = Color.Black;
    this.chkOverwriteRetail.Checked = false;
    this.chkRecalcNewRetail.ForeColor = Color.Black;
    this.chkRecalcNewRetail.Checked = false;
    this.chkCopyPending.ForeColor = Color.Black;
    this.chkCopyPending.Checked = false;
    this.ShowLastManageRunTimes();
  }

  public void ShowLastManageRunTimes()
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str = "Select top 1 * from LastActionTimes";
    command.CommandText = str;
    try
    {
      SqlDataReader sqlDataReader = command.ExecuteReader();
      if (!sqlDataReader.HasRows)
        return;
      while (sqlDataReader.Read())
      {
        this.lblLastRunRecalc.Text = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader["LastRecalcSalesUplift"])) ? "Last Run Date: " + Strings.FormatDateTime(Conversions.ToDate(sqlDataReader["LastRecalcSalesUplift"]), DateFormat.ShortDate) : "Last Run Date: Never";
        this.lblLastRunBackup.Text = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader["LastDBBackup"])) ? "Last Run Date: " + Strings.FormatDateTime(Conversions.ToDate(sqlDataReader["LastDBBackup"]), DateFormat.ShortDate) : "Last Run Date: Never";
        this.lblLastRunClearDown.Text = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader["LastImportClearDown"])) ? "Last Run Date: " + Strings.FormatDateTime(Conversions.ToDate(sqlDataReader["LastImportClearDown"]), DateFormat.ShortDate) : "Last Run Date: Never";
        this.lblLastRunReindex.Text = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader["LastDBMaint"])) ? "Last Run Date: " + Strings.FormatDateTime(Conversions.ToDate(sqlDataReader["LastDBMaint"]), DateFormat.ShortDate) : "Last Run Date: Never";
        this.lblLastRunNewSell.Text = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader["LastRecalcNewSell"])) ? "Last Run Date: " + Strings.FormatDateTime(Conversions.ToDate(sqlDataReader["LastRecalcNewSell"]), DateFormat.ShortDate) : "Last Run Date: Never";
        this.lblLastRunCalcRetail.Text = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader["LastRecalcNewRetail"])) ? "Last Run Date: " + Strings.FormatDateTime(Conversions.ToDate(sqlDataReader["LastRecalcNewRetail"]), DateFormat.ShortDate) : "Last Run Date: Never";
        this.lblLastRunOverwriteApprovedSell.Text = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader["LastOverwriteApprovedSell"])) ? "Last Run Date: " + Strings.FormatDateTime(Conversions.ToDate(sqlDataReader["LastOverwriteApprovedSell"]), DateFormat.ShortDate) : "Last Run Date: Never";
        this.lblLastRunOverwriteApprovedCosts.Text = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader["LastOverwriteApprovedCosts"])) ? "Last Run Date: " + Strings.FormatDateTime(Conversions.ToDate(sqlDataReader["LastOverwriteApprovedCosts"]), DateFormat.ShortDate) : "Last Run Date: Never";
        this.lblLastRunOverwriteApprovedRetail.Text = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader["LastOverwriteApprovedRetail"])) ? "Last Run Date: " + Strings.FormatDateTime(Conversions.ToDate(sqlDataReader["LastOverwriteApprovedRetail"]), DateFormat.ShortDate) : "Last Run Date: Never";
        this.lblLastRunDateCopyPending.Text = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader["LastCopyToPending"])) ? "Last Run Date: " + Strings.FormatDateTime(Conversions.ToDate(sqlDataReader["LastCopyToPending"]), DateFormat.ShortDate) : "Last Run Date: Never";
        this.lblLastRunUpdateCostSellRetail.Text = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader["LastUpdateCostSellRetail"])) ? "Last Run Date: " + Strings.FormatDateTime(Conversions.ToDate(sqlDataReader["LastUpdateCostSellRetail"]), DateFormat.ShortDate) : "Last Run Date: Never";
        this.lblLastUpdatePOPPrices.Text = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader["LastUpdatePOPPrices"])) ? "Last Run Date: " + Strings.FormatDateTime(Conversions.ToDate(sqlDataReader["LastUpdatePOPPrices"]), DateFormat.ShortDate) : "Last Run Date: Never";
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in ShowLastManageRunTimes: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  private void naviBar1_ActiveBandChanged(object sender, EventArgs e)
  {
    modMain.GetConfigDom();
    string name = this.naviBar1.ActiveBand.Name;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "nbImport", false) == 0)
    {
      this.tcMain.SelectedTab = this.tpImport;
      this.RefreshImportViews();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "nbSettings", false) == 0)
      this.tcMain.SelectedTab = this.tpSettings;
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "nbManagement", false) == 0)
    {
      this.SetManagementTab();
      this.tcMain.SelectedTab = this.tpManage;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "nbTemplates", false) == 0)
      this.tcMain.SelectedTab = this.tpTemplates;
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "nbExport", false) == 0)
    {
      this.tcMain.SelectedTab = this.tpExport;
      this.RefreshExportViews();
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "nbNewProducts", false) != 0)
        return;
      this.ShowLastNewProductImportDate();
      this.ShowMappingResults();
      this.tcMain.SelectedTab = this.tpNewProducts;
    }
  }

  private void lblNewTemplate_MouseEnter(object sender, EventArgs e) => this.Cursor = Cursors.Hand;

  private void lblNewTemplate_MouseHover(object sender, EventArgs e) => this.Cursor = Cursors.Hand;

  private void lblNewTemplate_Click(object sender, EventArgs e) => this.ClearFields();

  private void chkNet_CheckedChanged(object sender, EventArgs e)
  {
    this.chkGross.Checked = !this.chkNet.Checked;
  }

  private void chkGross_CheckedChanged(object sender, EventArgs e)
  {
    this.chkNet.Checked = !this.chkGross.Checked;
  }

  private void chkEuro_CheckedChanged(object sender, EventArgs e)
  {
    this.chkSterling.Checked = !this.chkEuro.Checked;
  }

  private void chkSterling_CheckedChanged(object sender, EventArgs e)
  {
    this.chkEuro.Checked = !this.chkSterling.Checked;
  }

  public void ClearFields()
  {
    this.txtSP.Text = "";
    this.txtTemplateName.Text = "";
    this.chkEuro.Checked = true;
    this.chkNet.Checked = true;
    this.txtPriceList.Text = "";
    this.txtSupplierCode.Text = "";
    this.cboCalcPrice1.SelectedIndex = 0;
    this.cboCalcPrice2.SelectedIndex = 0;
    this.cboCalcPrice3.SelectedIndex = 0;
    this.cboSuppProduct.SelectedIndex = 0;
    this.cboIIHFProductCode.SelectedIndex = 0;
    this.chkProductMapping.Checked = false;
    this.txtNotes.Text = "";
    this.txtEmail.Text = "";
  }

  private void cmdDelete_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtTemplateName.Text), "", false) == 0 || !modMain.mgBox("Are you sure you want to delete this Template?", bYesNo: true))
      return;
    this.DeleteTemplate(this.txtTemplateName.Text);
    this.ClearFields();
    this.RefreshTemplates(true);
    this.pBoxTemplateAsc.Visible = true;
    this.pboxTemplateDesc.Visible = false;
  }

  private void cmdSaveTemplate_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtTemplateName.Text), "", false) == 0)
    {
      modMain.mgBox("Enter Template Name");
      this.txtTemplateName.Focus();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtSupplierCode.Text), "", false) == 0)
    {
      modMain.mgBox("Enter Supplier Code");
      this.txtSupplierCode.Focus();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtPriceList.Text), "", false) == 0)
    {
      modMain.mgBox("Enter Price List");
      this.txtPriceList.Focus();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtSP.Text), "", false) == 0)
    {
      modMain.mgBox("Enter Stored Procedure Name");
      this.txtSP.Focus();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtEmail.Text), "", false) != 0 & !this.txtEmail.Text.Contains("@"))
    {
      modMain.mgBox("Invalid eMail Address");
      this.txtEmail.Focus();
    }
    else if (this.SaveTemplateData())
    {
      modMain.mgBox("Template Saved OK");
      this.RefreshTemplates(true);
      this.pBoxTemplateAsc.Visible = true;
      this.pboxTemplateDesc.Visible = false;
    }
  }

  public bool SaveTemplateData()
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    string str1 = !this.chkEuro.Checked ? "S" : "E";
    string str2 = !this.chkNet.Checked ? "G" : "N";
    bool flag;
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.StoredProcedure;
      command.CommandText = "Template_UpdateInsert";
      SqlParameter sqlParameter = command.Parameters.Add(new SqlParameter("@TemplateName", SqlDbType.VarChar, (int) byte.MaxValue));
      System.Windows.Forms.TextBox txtTemplateName = this.txtTemplateName;
      object text = (object) txtTemplateName.Text;
      object obj = modMain.sNullTest(ref text);
      txtTemplateName.Text = Conversions.ToString(text);
      object objectValue = RuntimeHelpers.GetObjectValue(obj);
      sqlParameter.Value = objectValue;
      command.Parameters.Add(new SqlParameter("@SupplierCode", SqlDbType.VarChar, 50)).Value = (object) this.txtSupplierCode.Text;
      command.Parameters.Add(new SqlParameter("@PriceListNumber", SqlDbType.Int)).Value = (object) Convert.ToInt16(this.txtPriceList.Text);
      command.Parameters.Add(new SqlParameter("@ProductMappingRequired", SqlDbType.Bit)).Value = (object) this.chkProductMapping.Checked;
      command.Parameters.Add(new SqlParameter("@ValueType", SqlDbType.Char, 1)).Value = (object) str2;
      command.Parameters.Add(new SqlParameter("@Currency", SqlDbType.Char, 1)).Value = (object) str1;
      command.Parameters.Add(new SqlParameter("@SupplierProductCode", SqlDbType.Char, 1)).Value = (object) this.cboSuppProduct.Text;
      command.Parameters.Add(new SqlParameter("@IIHFProductCode", SqlDbType.Char, 1)).Value = (object) this.cboIIHFProductCode.Text;
      command.Parameters.Add(new SqlParameter("@CalcPrice1", SqlDbType.Char, 1)).Value = (object) this.cboCalcPrice1.Text;
      command.Parameters.Add(new SqlParameter("@CalcPrice2", SqlDbType.Char, 1)).Value = (object) this.cboCalcPrice2.Text;
      command.Parameters.Add(new SqlParameter("@CalcPrice3", SqlDbType.Char, 1)).Value = (object) this.cboCalcPrice3.Text;
      command.Parameters.Add(new SqlParameter("@StoredProcedureName", SqlDbType.VarChar, (int) byte.MaxValue)).Value = (object) this.txtSP.Text;
      command.Parameters.Add(new SqlParameter("@Notes", SqlDbType.VarChar, 2550)).Value = (object) this.txtNotes.Text;
      command.Parameters.Add(new SqlParameter("@Standard", SqlDbType.Bit)).Value = (object) this.chkStandard.Checked;
      command.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, (int) byte.MaxValue)).Value = (object) this.txtEmail.Text;
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
        flag = true;
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in SaveData: " + ex.Message, true);
        flag = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public void RefreshTemplates(bool bAsc)
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str1 = "Select TemplateName from Templates";
    string str2 = !bAsc ? str1 + " order by TemplateName Desc" : str1 + " order by TemplateName";
    command.CommandText = str2;
    try
    {
      System.Data.DataTable dataTable = new System.Data.DataTable();
      dataTable.Load((IDataReader) command.ExecuteReader());
      command.Dispose();
      this.lbTemplates.DisplayMember = dataTable.Columns[0].ColumnName;
      this.lbTemplates.ValueMember = dataTable.Columns[0].ColumnName;
      this.lbTemplates.DataSource = (object) dataTable;
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in Refresh Templates: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    finally
    {
      sqlConnection.Close();
      sqlConnection.Dispose();
    }
  }

  private void lbTemplates_DrawItem(object sender, DrawItemEventArgs e)
  {
    if (e.Index < 0)
      return;
    e.DrawBackground();
    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
      e.Graphics.FillRectangle(Brushes.Khaki, e.Bounds);
    using (new SolidBrush(e.ForeColor))
      e.Graphics.DrawString(this.lbTemplates.GetItemText(RuntimeHelpers.GetObjectValue(this.lbTemplates.Items[e.Index])), e.Font, Brushes.Black, (RectangleF) e.Bounds);
    e.DrawFocusRectangle();
  }

  private void lbTemplates_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.GetTemplateData(this.lbTemplates.Text);
  }

  public string GeteMail(string sTemplate)
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str1 = $"Select top 1 eMail from templates where templateName = '{sTemplate}'";
    command.CommandText = str1;
    string str2 = null;
    try
    {
      SqlDataReader sqlDataReader = command.ExecuteReader();
      if (sqlDataReader.HasRows)
      {
        if (sqlDataReader.Read())
        {
          object objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["eMail"]);
          str2 = Conversions.ToString(modMain.sNullTest(ref objectValue));
          goto label_6;
        }
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in GeteMail: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
label_6:
    return str2;
  }

  public string GetTemplateNotes(string sTemplate)
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str = $"Select top 1 Notes from templates where templateName = '{sTemplate}'";
    command.CommandText = str;
    string templateNotes = null;
    try
    {
      SqlDataReader sqlDataReader = command.ExecuteReader();
      if (sqlDataReader.HasRows)
      {
        if (sqlDataReader.Read())
        {
          object objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["Notes"]);
          templateNotes = Conversions.ToString(modMain.sNullTest(ref objectValue));
          goto label_6;
        }
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in GetTemplateNotes: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
label_6:
    return templateNotes;
  }

  public void GetTemplateData(string sTemplate)
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str1 = $"Select top 1 * from templates where templateName = '{sTemplate}'";
    command.CommandText = str1;
    try
    {
      SqlDataReader sqlDataReader = command.ExecuteReader();
      if (!sqlDataReader.HasRows)
        return;
      while (sqlDataReader.Read())
      {
        System.Windows.Forms.TextBox txtTemplateName = this.txtTemplateName;
        object objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["TemplateName"]);
        string str2 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        txtTemplateName.Text = str2;
        System.Windows.Forms.TextBox txtSupplierCode = this.txtSupplierCode;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["SupplierCode"]);
        string str3 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        txtSupplierCode.Text = str3;
        System.Windows.Forms.TextBox txtPriceList = this.txtPriceList;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["PriceListNumber"]);
        string str4 = modMain.iNullTest(ref objectValue).ToString();
        txtPriceList.Text = str4;
        this.chkProductMapping.Checked = Conversions.ToBoolean(sqlDataReader["ProductMappingRequired"]);
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["ValueType"]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(modMain.sNullTest(ref objectValue), (object) "N", false))
          this.chkNet.Checked = true;
        else
          this.chkGross.Checked = true;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["Currency"]);
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(modMain.sNullTest(ref objectValue), (object) "E", false))
          this.chkEuro.Checked = true;
        else
          this.chkSterling.Checked = true;
        ComboBox cboSuppProduct = this.cboSuppProduct;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["SupplierProductCode"]);
        string str5 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        cboSuppProduct.Text = str5;
        ComboBox cboIihfProductCode = this.cboIIHFProductCode;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["IIHFProductCode"]);
        string str6 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        cboIihfProductCode.Text = str6;
        ComboBox cboCalcPrice1 = this.cboCalcPrice1;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["CalcPrice1"]);
        string str7 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        cboCalcPrice1.Text = str7;
        ComboBox cboCalcPrice2 = this.cboCalcPrice2;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["CalcPrice2"]);
        string str8 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        cboCalcPrice2.Text = str8;
        ComboBox cboCalcPrice3 = this.cboCalcPrice3;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["CalcPrice3"]);
        string str9 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        cboCalcPrice3.Text = str9;
        System.Windows.Forms.TextBox txtSp = this.txtSP;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["StoredProcedureName"]);
        string str10 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        txtSp.Text = str10;
        System.Windows.Forms.TextBox txtNotes = this.txtNotes;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["Notes"]);
        string str11 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        txtNotes.Text = str11;
        System.Windows.Forms.TextBox txtEmail = this.txtEmail;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["email"]);
        string str12 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        txtEmail.Text = str12;
        this.chkStandard.Checked = Conversions.ToBoolean(sqlDataReader["StandardTemplate"]);
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in GetTemplateData: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void DeleteTemplate(string sTemplate)
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = $"Delete from Templates where TemplateName = '{sTemplate}'";
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in DeleteTemplate: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in DeleteTemplate: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  private void lblNewTemplate_MouseLeave(object sender, EventArgs e)
  {
    this.Cursor = Cursors.Default;
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    this.buttonPressed = true;
    this.lbTemplates.Refresh();
  }

  private void txtSupplierCode_Leave(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Left(this.txtSupplierCode.Text, 1), "/", false) == 0)
    {
      modMain.sSearchedSupplierCode = "";
      int num = (int) new frmSelectSupplier()
      {
        sSearchString = this.txtSupplierCode.Text
      }.ShowDialog();
      this.txtSupplierCode.Text = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(modMain.sSearchedSupplierCode, "", false) == 0 ? "" : modMain.sSearchedSupplierCode;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtSupplierCode.Text), "", false) != 0 && !modMain.IsValidSupplier(this.txtSupplierCode.Text))
    {
      modMain.mgBox("Supplier is not Valid!");
      this.txtSupplierCode.Focus();
    }
  }

  private void txtSupplierCode_TextChanged(object sender, EventArgs e)
  {
  }

  private void txtPriceList_Leave(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Left(this.txtPriceList.Text, 1), "/", false) == 0)
    {
      modMain.iSearchedPriceList = 0;
      int num = (int) new frmSelectPriceList()
      {
        sSearchString = this.txtPriceList.Text
      }.ShowDialog();
      this.txtPriceList.Text = modMain.iSearchedPriceList == 0 ? "" : Conversions.ToString(modMain.iSearchedPriceList);
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtPriceList.Text), "", false) != 0 && !modMain.IsValidPriceList(Conversions.ToInteger(this.txtPriceList.Text)))
    {
      modMain.mgBox("Price List is not Valid!");
      this.txtPriceList.Focus();
    }
  }

  private void cmdSearchSupplier_Click(object sender, EventArgs e)
  {
    modMain.sSearchedSupplierCode = "";
    int num = (int) new frmSelectSupplier()
    {
      sSearchString = this.txtSupplierCode.Text
    }.ShowDialog();
    this.txtSupplierCode.Text = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(modMain.sSearchedSupplierCode, "", false) == 0 ? "" : modMain.sSearchedSupplierCode;
  }

  private void cmdSearchPriceList_Click(object sender, EventArgs e)
  {
    modMain.iSearchedPriceList = 0;
    int num = (int) new frmSelectPriceList()
    {
      sSearchString = this.txtPriceList.Text
    }.ShowDialog();
    this.txtPriceList.Text = modMain.iSearchedPriceList == 0 ? "" : Conversions.ToString(modMain.iSearchedPriceList);
  }

  private void naviGroup2_Click(object sender, EventArgs e)
  {
  }

  private void Button1_Click_1(object sender, EventArgs e)
  {
    this.nbImport.BackColor = Color.Beige;
    this.nbImport.ClientArea.BackColor = Color.Beige;
  }

  private void lstWaiting_Click(object sender, EventArgs e)
  {
    this.sImportTemplate = "";
    this.lstSheets.Visible = false;
    this.lblSheets.Visible = false;
    this.txtImport.Text = "";
    this.lblSheets.Visible = false;
    this.lstSheets.Visible = false;
    this.lblTemplateName.Text = "Template Name: " + this.lstWaiting.Text;
    this.sImportTemplate = this.lstWaiting.Text;
    this.gbImportResults.Visible = false;
    this.txtTemplateNotes.Text = this.GetTemplateNotes(this.lstWaiting.Text);
  }

  private void lstWaiting_DoubleClick(object sender, EventArgs e)
  {
    this.cmdBrowse_Click(RuntimeHelpers.GetObjectValue(sender), e);
  }

  private void lstWaiting_DrawItem(object sender, DrawItemEventArgs e)
  {
    if (e.Index < 0)
      return;
    e.DrawBackground();
    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
      e.Graphics.FillRectangle(Brushes.Khaki, e.Bounds);
    using (new SolidBrush(e.ForeColor))
      e.Graphics.DrawString(this.lstWaiting.GetItemText(RuntimeHelpers.GetObjectValue(this.lstWaiting.Items[e.Index])), e.Font, Brushes.Black, (RectangleF) e.Bounds);
    e.DrawFocusRectangle();
  }

  private void lstImported_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lstImported.Text, "", false) == 0)
      return;
    this.ShowImportResults(this.lstImported.Text);
  }

  private void lstImported_DrawItem(object sender, DrawItemEventArgs e)
  {
    if (e.Index < 0)
      return;
    e.DrawBackground();
    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
      e.Graphics.FillRectangle(Brushes.Khaki, e.Bounds);
    using (new SolidBrush(e.ForeColor))
      e.Graphics.DrawString(this.lstImported.GetItemText(RuntimeHelpers.GetObjectValue(this.lstImported.Items[e.Index])), e.Font, Brushes.Black, (RectangleF) e.Bounds);
    e.DrawFocusRectangle();
  }

  private void cmdBrowse_Click(object sender, EventArgs e)
  {
    modMain.fdlg = new OpenFileDialog();
    modMain.fdlg.Title = "Browse for Template Import Excel File";
    modMain.fdlg.Filter = "Excel files|*.XLS*";
    modMain.fdlg.FilterIndex = 2;
    modMain.fdlg.RestoreDirectory = true;
    if (modMain.fdlg.ShowDialog() != DialogResult.OK)
      return;
    this.txtImport.Text = modMain.fdlg.FileName;
    if (this.CheckWorksheets())
    {
      this.lblSheets.Visible = true;
      this.lstSheets.Visible = true;
    }
    else
    {
      this.lblSheets.Visible = false;
      this.lstSheets.Visible = false;
    }
  }

  public void RefreshImportViews()
  {
    this.RefreshImported(true);
    this.RefreshWaiting(true);
  }

  public void RefreshExportViews()
  {
    this.RefreshExported(true);
    this.RefreshWaitingForExport(true);
    if (this.lstExport.Items.Count <= 0)
      return;
    this.lblExportTemplateName.Text = ((DataRowView) this.lstExport.Items[0]).Row[0].ToString();
    this.SetExportFileName(this.lblExportTemplateName.Text);
    this.lblEmail.Text = this.GeteMail(this.lblExportTemplateName.Text);
  }

  public void RefreshWaitingForExport(bool bAsc)
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str1 = "Select TemplateName from Templates where Exported = 0 and StandardTemplate = 1";
    string str2 = !bAsc ? str1 + " order by TemplateName Desc" : str1 + " order by TemplateName";
    command.CommandText = str2;
    try
    {
      System.Data.DataTable dataTable = new System.Data.DataTable();
      dataTable.Load((IDataReader) command.ExecuteReader());
      command.Dispose();
      this.lstExport.DisplayMember = dataTable.Columns[0].ColumnName;
      this.lstExport.ValueMember = dataTable.Columns[0].ColumnName;
      this.lstExport.DataSource = (object) dataTable;
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in Refresh RefreshWaitingForExport: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    finally
    {
      sqlConnection.Close();
      sqlConnection.Dispose();
    }
  }

  public void RefreshExported(bool bAsc)
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str1 = "Select TemplateName from Templates where Exported = 1";
    string str2 = !bAsc ? str1 + " order by TemplateName Desc" : str1 + " order by TemplateName";
    command.CommandText = str2;
    try
    {
      System.Data.DataTable dataTable = new System.Data.DataTable();
      dataTable.Load((IDataReader) command.ExecuteReader());
      command.Dispose();
      this.lstExported.DisplayMember = dataTable.Columns[0].ColumnName;
      this.lstExported.ValueMember = dataTable.Columns[0].ColumnName;
      this.lstExported.DataSource = (object) dataTable;
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in Refresh RefreshExported: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    finally
    {
      sqlConnection.Close();
      sqlConnection.Dispose();
    }
  }

  public void RefreshWaiting(bool bAsc)
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str1 = "Select TemplateName from Templates where TemplateName not in (Select TemplateName from FileImports)";
    string str2 = !bAsc ? str1 + " order by TemplateName Desc" : str1 + " order by TemplateName";
    command.CommandText = str2;
    try
    {
      System.Data.DataTable dataTable = new System.Data.DataTable();
      dataTable.Load((IDataReader) command.ExecuteReader());
      command.Dispose();
      this.lstWaiting.DisplayMember = dataTable.Columns[0].ColumnName;
      this.lstWaiting.ValueMember = dataTable.Columns[0].ColumnName;
      this.lstWaiting.DataSource = (object) dataTable;
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in Refresh RefreshImportViews: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    finally
    {
      sqlConnection.Close();
      sqlConnection.Dispose();
    }
  }

  public void RefreshImported(bool bAsc)
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str1 = "Select distinct TemplateName from FileImports";
    string str2 = !bAsc ? str1 + " order by TemplateName Desc" : str1 + " order by TemplateName";
    command.CommandText = str2;
    try
    {
      System.Data.DataTable dataTable = new System.Data.DataTable();
      dataTable.Load((IDataReader) command.ExecuteReader());
      command.Dispose();
      this.lstImported.DisplayMember = dataTable.Columns[0].ColumnName;
      this.lstImported.ValueMember = dataTable.Columns[0].ColumnName;
      this.lstImported.DataSource = (object) dataTable;
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in Refresh RefreshImportViews: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    finally
    {
      sqlConnection.Close();
      sqlConnection.Dispose();
    }
  }

  private void cmdImport_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.lstWaiting.Text), "", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.sImportTemplate, "", false) == 0)
    {
      modMain.mgBox("Select Template to Import!");
    }
    else
    {
      this.sImportTemplate = this.lstWaiting.Text;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtImport.Text), "", false) == 0)
      {
        modMain.mgBox("Select file to Import");
        this.txtImport.Focus();
      }
      else if (!this.txtImport.Text.ToLower().Contains(".xls") & !this.txtImport.Text.ToLower().Contains(".xlsx"))
      {
        modMain.mgBox("File must be Office Excel Format");
        this.txtImport.Focus();
      }
      else
      {
        if (this.lstSheets.Visible)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.sSheetName, "", false) == 0)
          {
            modMain.mgBox("Select Sheet to Import");
            return;
          }
          if (!modMain.mgBox($"Confrim Import of Sheet: {this.sSheetName}?", bYesNo: true))
            return;
        }
        this.Cursor = Cursors.AppStarting;
        this.sImportedTemplate = this.sImportTemplate;
        if (this.ImportFile(this.txtImport.Text))
        {
          this.MapProducts(this.sImportedTemplate);
          this.ExecTemplateSP(this.sImportedTemplate);
          this.RefreshImportViews();
          this.ArchiveFile();
          this.txtImport.Text = "";
          this.lblSheets.Visible = false;
          this.lstSheets.Visible = false;
          this.sImportedTemplate = Strings.Replace(this.sImportedTemplate, "[", "");
          this.sImportedTemplate = Strings.Replace(this.sImportedTemplate, "]", "");
          this.ShowImportResults(this.sImportedTemplate);
        }
        this.Cursor = Cursors.Default;
      }
    }
  }

  public void ArchiveFile()
  {
    string fileName = this.GetFileName(this.txtImport.Text);
    string path = this.FolderFromFileName(this.txtImport.Text) + "\\Archive";
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    string text = this.txtImport.Text;
    string destFileName = $"{path}\\{fileName}";
    if (!System.IO.File.Exists(text))
      return;
    System.IO.File.Move(text, destFileName);
  }

  public string GetFileName(string FileFullPath)
  {
    int startIndex = checked (FileFullPath.LastIndexOfAny(Conversions.ToCharArrayRankOne("\\")) + 1);
    return FileFullPath.Substring(startIndex, checked (Strings.Len(FileFullPath) - startIndex));
  }

  public string FolderFromFileName(string FileFullPath)
  {
    int length = checked (FileFullPath.LastIndexOfAny(Conversions.ToCharArrayRankOne("\\")) + 1);
    return FileFullPath.Substring(0, length);
  }

  public void ShowImportResults(string sTemplate)
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.StoredProcedure;
      command.CommandText = "Template_GetImportedCounts";
      command.Parameters.Add(new SqlParameter("@TemplateName", SqlDbType.VarChar, (int) byte.MaxValue)).Value = (object) sTemplate;
      command.Parameters.Add(new SqlParameter("@TotalRecords", SqlDbType.Int)).Value = (object) 0;
      command.Parameters.Add(new SqlParameter("@ValidRecords", SqlDbType.Int)).Value = (object) 0;
      command.Parameters.Add(new SqlParameter("@MappedRecords", SqlDbType.Int)).Value = (object) 0;
      command.Parameters.Add(new SqlParameter("@PriceListRecords", SqlDbType.Int)).Value = (object) 0;
      command.Parameters["@TotalRecords"].Direction = ParameterDirection.Output;
      command.Parameters["@ValidRecords"].Direction = ParameterDirection.Output;
      command.Parameters["@MappedRecords"].Direction = ParameterDirection.Output;
      command.Parameters["@PriceListRecords"].Direction = ParameterDirection.Output;
      command.CommandTimeout = 0;
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
        this.gbImportResults.Text = "Import Results for " + sTemplate;
        this.lblTotalImported.Text = command.Parameters["@TotalRecords"].Value.ToString();
        this.lblValid.Text = command.Parameters["@ValidRecords"].Value.ToString();
        this.lblMapped.Text = command.Parameters["@MappedRecords"].Value.ToString();
        this.lblPriceList.Text = command.Parameters["@PriceListRecords"].Value.ToString();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in ShowImportResults: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in ShowImportResults: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    Decimal num = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblValid.Text, "0", false) != 0 ? new Decimal((double) Convert.ToInt16(this.lblMapped.Text) / (double) Convert.ToInt16(this.lblValid.Text) * (double) byte.MaxValue) : 0M;
    Decimal decValue = Decimal.Subtract(255M, num);
    PieChart pieChart1 = new PieChart();
    Render render = new Render();
    PieChart pieChart2 = pieChart1;
    pieChart2.KeyTitle = "";
    pieChart2.KeyTitleFontStyle = FontStyle.Bold;
    pieChart2.KeyBackColor = Color.Beige;
    pieChart2.ImageSize = new Size(25, 25);
    pieChart2.AutoSize = true;
    pieChart2.Diameter = 85f;
    pieChart2.Thickness = 5f;
    pieChart2.Color = Color.Beige;
    pieChart2.GraphBorder = true;
    pieChart2.PieSliceCollection.Add(new PieSlice(num, Color.Yellow, "Mapped Valid Rows"));
    pieChart2.PieSliceCollection.Add(new PieSlice(decValue, Color.Gold, "Non Mapped Valid Rows"));
    this.PictureBox1.Image = render.DrawChart((BaseGraph) pieChart1);
    this.PictureBox2.Image = render.DrawKey((BaseGraph) pieChart1);
    this.gbImportResults.Visible = true;
  }

  public void ExecTemplateSP(string sTemplate)
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.StoredProcedure;
      command.CommandText = "Template_ExecSP";
      command.Parameters.Add(new SqlParameter("@TemplateName", SqlDbType.VarChar, (int) byte.MaxValue)).Value = (object) sTemplate;
      command.CommandTimeout = 0;
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in ExecTemplateSP: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in ExecTemplateSP: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void MapProducts(string sTemplate)
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.StoredProcedure;
      command.CommandText = "Template_MapImportedProducts";
      command.Parameters.Add(new SqlParameter("@TemplateName", SqlDbType.VarChar, (int) byte.MaxValue)).Value = (object) sTemplate;
      command.CommandTimeout = 0;
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in MapProducts: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in MapProducts: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void SetXLSArray()
  {
    int index = 0;
    while (index <= 5)
    {
      this.XLSArray[index] = -1;
      checked { ++index; }
    }
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str = $"Select top 1 * from templates where templateName = '{this.sImportTemplate}'";
    command.CommandText = str;
    try
    {
      SqlDataReader sqlDataReader = command.ExecuteReader();
      if (!sqlDataReader.HasRows)
        return;
      while (sqlDataReader.Read())
      {
        this.XLSArray[1] = this.SetArrayInt(Conversions.ToString(sqlDataReader["SupplierProductCode"]));
        this.XLSArray[2] = this.SetArrayInt(Conversions.ToString(sqlDataReader["IIHFProductCode"]));
        this.XLSArray[3] = this.SetArrayInt(Conversions.ToString(sqlDataReader["CalcPrice1"]));
        this.XLSArray[4] = this.SetArrayInt(Conversions.ToString(sqlDataReader["CalcPrice2"]));
        this.XLSArray[5] = this.SetArrayInt(Conversions.ToString(sqlDataReader["CalcPrice3"]));
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in SetXLSArray: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public int SetArrayInt(string sChar)
  {
    string Left = sChar;
    return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "A", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "B", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "C", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "D", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "E", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "F", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "G", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "H", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "I", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "J", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "K", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "L", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "M", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "N", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "O", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "P", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Q", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "U", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "R", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "S", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "T", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "U", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "V", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "W", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "X", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Y", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Z", false) != 0 ? -1 : 26) : 25) : 24) : 23) : 22) : 21) : 20) : 19) : 18) : 17) : 16 /*0x10*/) : 15) : 14) : 13) : 12) : 11) : 10) : 9) : 8) : 7) : 6) : 5) : 4) : 3) : 2) : 1) : 0;
  }

  public bool ImportFile(string sFilename)
  {
    string sCalc1 = "";
    string sCalc2 = "";
    string sCalc3 = "";
    string ProductCode = "";
    string sIIHFCode = "";
    bool flag = false;
    this.sExt = Path.GetExtension(sFilename);
    this.SetXLSArray();
    this.sSheetName = this.lstSheets.Visible ? this.lstSheets.Text : this.GetWorksheetName();
    string selectCommandText = $"select * from [{this.sSheetName}]";
    try
    {
      this.cn = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.sExt, ".xls", false) != 0 ? new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;data Source={this.txtImport.Text} ;Extended Properties=Excel 8.0") : new OleDbConnection($"provider=Microsoft.Jet.OLEDB.4.0;data source={this.txtImport.Text};Extended Properties='Excel 8.0;IMEX=1;HDR=YES'");
      this.da = new OleDbDataAdapter(selectCommandText, this.cn);
      this.cn.Open();
      this.dsCSV = new DataSet();
      this.da.Fill(this.dsCSV);
      this.cn.Close();
      System.Data.DataTable table = this.dsCSV.Tables[0];
      {
        foreach (DataRow row in table.Rows)
        {
          if (this.XLSArray[1] > -1)
            ProductCode = row[this.XLSArray[1]].ToString();
          if (this.XLSArray[2] > -1)
            sIIHFCode = row[this.XLSArray[2]].ToString();
          if (this.XLSArray[3] > -1)
            sCalc1 = row[this.XLSArray[3]].ToString();
          if (this.XLSArray[4] > -1)
            sCalc2 = row[this.XLSArray[4]].ToString();
          if (this.XLSArray[5] > -1)
            sCalc3 = row[this.XLSArray[5]].ToString();
          this.InsertImportRecord(this.lstWaiting.Text, ProductCode, sIIHFCode, sCalc1, sCalc2, sCalc3);
        }
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      modMain.mgBox("Error reading Import File: " + exception.Message, true);
      this.cn.Close();
      this.cn = (OleDbConnection) null;
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  public void InsertImportRecord(
    string Template,
    string ProductCode,
    string sIIHFCode,
    string sCalc1,
    string sCalc2,
    string sCalc3)
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.StoredProcedure;
      command.CommandText = "Template_Import";
      command.Parameters.Add(new SqlParameter("@TemplateName", SqlDbType.VarChar, (int) byte.MaxValue)).Value = (object) Template;
      command.Parameters.Add(new SqlParameter("@ProductCode", SqlDbType.VarChar, (int) byte.MaxValue)).Value = (object) ProductCode;
      command.Parameters.Add(new SqlParameter("@IIHFProductCode", SqlDbType.VarChar, (int) byte.MaxValue)).Value = (object) sIIHFCode;
      command.Parameters.Add(new SqlParameter("@Calc1", SqlDbType.VarChar, 50)).Value = (object) sCalc1;
      command.Parameters.Add(new SqlParameter("@Calc2", SqlDbType.VarChar, 50)).Value = (object) sCalc2;
      command.Parameters.Add(new SqlParameter("@Calc3", SqlDbType.VarChar, 50)).Value = (object) sCalc3;
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in InsertImportRecord: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in InsertImportRecord: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public bool CheckWorksheets()
  {
    int num = 0;
    this.sExt = Path.GetExtension(this.txtImport.Text);
    this.lstSheets.Items.Clear();
    try
    {
      this.cn = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.sExt, ".xls", false) != 0 ? new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;data Source={this.txtImport.Text} ;Extended Properties=Excel 8.0") : new OleDbConnection($"provider=Microsoft.Jet.OLEDB.4.0;data source={this.txtImport.Text};Extended Properties='Excel 8.0;IMEX=1;HDR=YES'");
      this.cn.Open();
      System.Data.DataTable oleDbSchemaTable = this.cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
      {
        (object) null,
        (object) null,
        (object) null,
        (object) "TABLE"
      });
      {
        foreach (DataRow row in oleDbSchemaTable.Rows)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(row[3], (object) "TABLE", false) && Strings.InStr(Conversions.ToString(row[2]), "$") > 0 & Strings.InStr(Conversions.ToString(row[2]), "Print") == 0)
          {
            this.lstSheets.Items.Add(RuntimeHelpers.GetObjectValue(row[2]));
            checked { ++num; }
          }
        }
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw ex;
    }
    finally
    {
      this.cn.Close();
      this.cn = (OleDbConnection) null;
    }
    return num > 1;
  }

  public string GetWorksheetName()
  {
    string worksheetName = "";
    try
    {
      this.sExt = Path.GetExtension(this.txtImport.Text);
      this.cn = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.sExt, ".xls", false) != 0 ? new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;data Source={this.txtImport.Text} ;Extended Properties=Excel 8.0") : new OleDbConnection($"provider=Microsoft.Jet.OLEDB.4.0;data source={this.txtImport.Text};Extended Properties='Excel 8.0;IMEX=1;HDR=YES'");
      this.cn.Open();
      System.Data.DataTable oleDbSchemaTable = this.cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[4]
      {
        (object) null,
        (object) null,
        (object) null,
        (object) "TABLE"
      });
      {
        foreach (DataRow row in oleDbSchemaTable.Rows)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(row[3], (object) "TABLE", false) && Strings.InStr(Conversions.ToString(row[2]), "$") > 0)
          {
            worksheetName = Conversions.ToString(row[2]);
            break;
          }
        }
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in GetWorksheetName: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.cn.Close();
      this.cn = (OleDbConnection) null;
    }
    return worksheetName;
  }

  private void lstSheets_Click(object sender, EventArgs e) => this.sSheetName = this.lstSheets.Text;

  private void lstSheets_DrawItem(object sender, DrawItemEventArgs e)
  {
    if (e.Index < 0)
      return;
    e.DrawBackground();
    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
      e.Graphics.FillRectangle(Brushes.Beige, e.Bounds);
    using (new SolidBrush(e.ForeColor))
      e.Graphics.DrawString(this.lstSheets.GetItemText(RuntimeHelpers.GetObjectValue(this.lstSheets.Items[e.Index])), e.Font, Brushes.Black, (RectangleF) e.Bounds);
    e.DrawFocusRectangle();
  }

  private void frmMain_Resize(object sender, EventArgs e)
  {
    if (this.WindowState == FormWindowState.Maximized)
    {
      this.lstWaiting.Height = 380;
      this.lstImported.Height = 380;
      this.lstExport.Height = 380;
    }
    else
    {
      this.lstWaiting.Height = 230;
      this.lstExport.Height = 230;
    }
    this.lblImported.Top = checked (this.lstWaiting.Top + this.lstWaiting.Height);
    this.lstImported.Top = checked (this.lblImported.Top + this.lblImported.Height);
    this.nbImport.BackColor = Color.Beige;
    System.Windows.Forms.ListBox lstImported = this.lstImported;
    Size clientSize = this.nbImport.ClientSize;
    int num1 = checked (clientSize.Height - this.lblImported.Height - this.lblWaiting.Height - this.lstWaiting.Height + this.iOffset);
    lstImported.Height = num1;
    this.pboxImportedAsc.Top = checked (this.lblImported.Top + 4);
    this.pboxImportedDesc.Top = checked (this.lblImported.Top + 4);
    System.Windows.Forms.ListBox lbTemplates = this.lbTemplates;
    clientSize = this.nbTemplates.ClientSize;
    int num2 = checked (clientSize.Height - this.lblNewTemplate.Height + this.iOffset);
    lbTemplates.Height = num2;
    System.Windows.Forms.ListBox lstSettings = this.lstSettings;
    clientSize = this.nbSettings.ClientSize;
    int num3 = checked (clientSize.Height + this.iOffset);
    lstSettings.Height = num3;
    System.Windows.Forms.ListBox lstNewProducts = this.lstNewProducts;
    clientSize = this.nbNewProducts.ClientSize;
    int num4 = checked (clientSize.Height + this.iOffset);
    lstNewProducts.Height = num4;
    System.Windows.Forms.ListBox lstManagement = this.lstManagement;
    clientSize = this.nbManagement.ClientSize;
    int num5 = checked (clientSize.Height + this.iOffset);
    lstManagement.Height = num5;
    this.lblExported.Top = checked (this.lstExport.Top + this.lstExport.Height);
    this.pBoxExportedAsc.Top = checked (this.lblExported.Top + 4);
    this.pboxExportedDesc.Top = checked (this.lblExported.Top + 4);
    this.lstExported.Top = checked (this.lblExported.Top + this.lblExported.Height);
    System.Windows.Forms.ListBox lstExported = this.lstExported;
    clientSize = this.nbExport.ClientSize;
    int num6 = checked (clientSize.Height - this.lblExported.Height - this.lblExport.Height - this.lstExport.Height + this.iOffset);
    lstExported.Height = num6;
  }

  private void frmMain_ResizeEnd(object sender, EventArgs e)
  {
  }

  public void GetSettings()
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str1 = "Select top 1 * from Settings";
    command.CommandText = str1;
    try
    {
      SqlDataReader sqlDataReader = command.ExecuteReader();
      if (!sqlDataReader.HasRows)
        return;
      while (sqlDataReader.Read())
      {
        System.Windows.Forms.TextBox txtExchRate = this.txtExchRate;
        object objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["SterlingExchRate"]);
        string str2 = Conversions.ToString(modMain.dNullTest(ref objectValue));
        txtExchRate.Text = str2;
        System.Windows.Forms.TextBox txtBackupPath = this.txtBackupPath;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["DBBackupFolder"]);
        string str3 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        txtBackupPath.Text = str3;
        System.Windows.Forms.TextBox txtExportLocation = this.txtExportLocation;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["ExportLocation"]);
        string str4 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        txtExportLocation.Text = str4;
        System.Windows.Forms.TextBox txteMailSubject = this.txteMailSubject;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["eMailSubject"]);
        string str5 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        txteMailSubject.Text = str5;
        System.Windows.Forms.TextBox txteMailBody = this.txteMailBody;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["eMailBody"]);
        string str6 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        txteMailBody.Text = str6;
        System.Windows.Forms.TextBox txteMailSender = this.txteMailSender;
        objectValue = RuntimeHelpers.GetObjectValue(sqlDataReader["eMailSender"]);
        string str7 = Conversions.ToString(modMain.sNullTest(ref objectValue));
        txteMailSender.Text = str7;
        this.sExportPath = this.txtExportLocation.Text;
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in GetSettings: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  private void cmdSaveSettings_Click(object sender, EventArgs e)
  {
    if (!this.SaveSettings())
      return;
    modMain.mgBox("Settings Saved OK");
  }

  public bool SaveSettings()
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
      command.CommandText = "Save_Settings";
      command.Parameters.Add(new SqlParameter("@SterlingExchRate", SqlDbType.Money)).Value = (object) Convert.ToDecimal(this.txtExchRate.Text);
      command.Parameters.Add(new SqlParameter("@BackupFolder", SqlDbType.VarChar, 2550)).Value = (object) this.txtBackupPath.Text;
      command.Parameters.Add(new SqlParameter("@ExportLocation", SqlDbType.VarChar, 2550)).Value = (object) this.txtExportLocation.Text;
      command.Parameters.Add(new SqlParameter("@eMailSubject", SqlDbType.VarChar, (int) byte.MaxValue)).Value = (object) this.txteMailSubject.Text;
      command.Parameters.Add(new SqlParameter("@eMailBody", SqlDbType.VarChar, 2000)).Value = (object) this.txteMailBody.Text;
      command.Parameters.Add(new SqlParameter("@eMailSender", SqlDbType.VarChar, 100)).Value = (object) this.txteMailSender.Text;
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in SaveSettings: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in SaveSettings: " + ex.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    if (flag)
      return false;
    this.sExportPath = this.txtExportLocation.Text;
    return true;
  }

  public bool ClearImportedData()
  {
    SqlConnection sqlConnection = new SqlConnection();
    bool flag = false;
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str = "Exec ClearImportedRecords";
    command.CommandText = str;
    try
    {
      command.ExecuteReader();
      this.gbImportResults.Visible = false;
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      modMain.mgBox("Error in ClearImportedData: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  private void nbImport_ClientSizeChanged(object sender, EventArgs e)
  {
    this.nbImport.BackColor = Color.Beige;
    this.nbImport.ClientArea.BackColor = Color.Beige;
    this.lblImported.Top = checked (this.lstWaiting.Top + this.lstWaiting.Height);
    this.lstImported.Top = checked (this.lblImported.Top + this.lblImported.Height);
    this.lstImported.Height = checked (this.nbImport.ClientSize.Height - this.lblImported.Height - this.lblWaiting.Height - this.lstWaiting.Height + this.iOffset);
    this.pboxImportedAsc.Top = checked (this.lblImported.Top + 4);
    this.pboxImportedDesc.Top = checked (this.lblImported.Top + 4);
  }

  private void pboxWaitingAsc_Click(object sender, EventArgs e)
  {
    this.RefreshWaiting(false);
    this.pboxWaitingAsc.Visible = false;
    this.pboxWaitingDesc.Visible = true;
  }

  private void pboxImportedAsc_MouseEnter(object sender, EventArgs e) => this.Cursor = Cursors.Hand;

  private void pboxImportedAsc_MouseHover(object sender, EventArgs e) => this.Cursor = Cursors.Hand;

  private void pboxImportedDesc_MouseEnter(object sender, EventArgs e)
  {
    this.Cursor = Cursors.Hand;
  }

  private void pboxImportedDesc_MouseHover(object sender, EventArgs e)
  {
    this.Cursor = Cursors.Hand;
  }

  private void pboxWaitingAsc_MouseEnter(object sender, EventArgs e) => this.Cursor = Cursors.Hand;

  private void pboxWaitingAsc_MouseHover(object sender, EventArgs e) => this.Cursor = Cursors.Hand;

  private void pboxWaitingDesc_MouseEnter(object sender, EventArgs e) => this.Cursor = Cursors.Hand;

  private void pboxWaitingDesc_MouseHover(object sender, EventArgs e) => this.Cursor = Cursors.Hand;

  private void pboxImportedAsc_Click(object sender, EventArgs e)
  {
    this.RefreshImported(false);
    this.pboxImportedDesc.Visible = true;
    this.pboxImportedAsc.Visible = false;
  }

  private void pboxImportedDesc_Click(object sender, EventArgs e)
  {
    this.RefreshImported(true);
    this.pboxImportedDesc.Visible = false;
    this.pboxImportedAsc.Visible = true;
  }

  private void pboxWaitingDesc_Click(object sender, EventArgs e)
  {
    this.RefreshWaiting(true);
    this.pboxWaitingAsc.Visible = true;
    this.pboxWaitingDesc.Visible = false;
  }

  private void pBoxTemplateAsc_Click(object sender, EventArgs e)
  {
    this.RefreshTemplates(false);
    this.pboxTemplateDesc.Visible = true;
    this.pBoxTemplateAsc.Visible = false;
  }

  private void pboxTemplateDesc_Click(object sender, EventArgs e)
  {
    this.RefreshTemplates(true);
    this.pboxTemplateDesc.Visible = false;
    this.pBoxTemplateAsc.Visible = true;
  }

  private void nbTemplates_ClientSizeChanged(object sender, EventArgs e)
  {
    this.lbTemplates.Height = checked (this.nbTemplates.ClientSize.Height - this.lblNewTemplate.Height + this.iOffset);
  }

  private void nbSettings_ClientSizeChanged(object sender, EventArgs e)
  {
    this.lstSettings.Height = checked (this.nbSettings.ClientSize.Height + this.iOffset);
  }

  public bool RecalcNewRetail()
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
      command.CommandText = nameof (RecalcNewRetail);
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in RecalcNewRetail: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in RecalcNewRetail: " + ex.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  public bool RecalcNewSell()
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
      command.CommandText = nameof (RecalcNewSell);
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in recalcNewSell: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in recalcNewSell: " + ex.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  public bool RecalcSalesUplift()
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
      command.CommandText = nameof (RecalcSalesUplift);
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in RecalcSalesUplift: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in RecalcSalesUplift: " + ex.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  private void cmdProcess_Click(object sender, EventArgs e)
  {
    if (!modMain.mgBox("Are you sure you want to Process Selected Database Maintenence Actions?", bYesNo: true))
      return;
    this.Cursor = Cursors.AppStarting;
    if (this.chkBackup.Checked)
    {
      if (this.BackupDatabase())
        this.chkBackup.ForeColor = Color.DarkGreen;
      else
        this.chkBackup.ForeColor = Color.DarkRed;
      System.Windows.Forms.Application.DoEvents();
    }
    if (this.chkClearImported.Checked)
    {
      if (this.ClearImportedData())
        this.chkClearImported.ForeColor = Color.DarkGreen;
      else
        this.chkClearImported.ForeColor = Color.DarkRed;
      System.Windows.Forms.Application.DoEvents();
    }
    if (this.chkReindex.Checked && this.ReindexDatabase())
    {
      if (this.ClearImportedData())
        this.chkReindex.ForeColor = Color.DarkGreen;
      else
        this.chkReindex.ForeColor = Color.DarkRed;
      System.Windows.Forms.Application.DoEvents();
    }
    if (this.chkRecalcSalesUplift.Checked)
    {
      if (this.RecalcSalesUplift())
        this.chkRecalcSalesUplift.ForeColor = Color.DarkGreen;
      else
        this.chkRecalcSalesUplift.ForeColor = Color.DarkRed;
      System.Windows.Forms.Application.DoEvents();
    }
    this.Cursor = Cursors.Default;
    modMain.mgBox("Processing Complete");
    this.chkBackup.Checked = false;
    this.chkClearImported.Checked = false;
    this.chkReindex.Checked = false;
    this.chkRecalcSalesUplift.Checked = false;
    this.ShowLastManageRunTimes();
  }

  public bool ReindexDatabase()
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
      command.CommandText = "Database_Maint";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in BackupDatabase: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in BackupDatabase: " + ex.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  public bool BackupDatabase()
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
      command.CommandText = "Database_Backup";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in BackupDatabase: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in BackupDatabase: " + ex.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  private void cmdRemap_Click(object sender, EventArgs e)
  {
    if (!modMain.mgBox($"Are you sure you want to Remap {this.lstImported.Text}?", bYesNo: true))
      return;
    this.RemapProducts(this.lstImported.Text);
    this.ShowImportResults(this.lstImported.Text);
    modMain.mgBox("Product Remapping Complete");
  }

  public void RemapProducts(string Template)
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.StoredProcedure;
      command.CommandText = "Template_MapImportedProducts";
      command.Parameters.Add(new SqlParameter("@TemplateName", SqlDbType.VarChar, (int) byte.MaxValue)).Value = (object) Template;
      command.CommandTimeout = 0;
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in RemapProducts: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in RemapProducts: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  private void txtTemplateNotes_KeyDown(object sender, KeyEventArgs e) => e.Handled = true;

  private void txtTemplateNotes_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

  private void cmdImportApproved_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtImportApproved.Text), "", false) == 0)
    {
      modMain.mgBox("Select file to Import");
      this.txtImportApproved.Focus();
    }
    else if (!this.txtImportApproved.Text.ToLower().Contains(".xls") & !this.txtImportApproved.Text.ToLower().Contains(".xlsx"))
    {
      modMain.mgBox("File must be Office Excel Format");
      this.txtImportApproved.Focus();
    }
    else
    {
      if (this.chkOverwriteCosts.Checked && !modMain.mgBox("Confirm Overwrite Imported Values?", bYesNo: true))
        return;
      this.Cursor = Cursors.AppStarting;
      this.ImportApprovedPricesFile(this.txtImportApproved.Text);
      this.txtImportApproved.Text = "";
      this.Cursor = Cursors.Default;
      modMain.mgBox("Import Complete");
    }
  }

  public void ImportApprovedPricesFile(string sFilename)
  {
    this.sExt = Path.GetExtension(sFilename);
    string sValueType = !this.radCost.Checked ? (!this.radSell.Checked ? "R" : "S") : "C";
    bool flag = this.chkOverwriteCosts.Checked;
    string selectCommandText = "select * from [Sheet1$]";
    try
    {
      this.cn = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.sExt, ".xls", false) != 0 ? new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;data Source={this.txtImportApproved.Text} ;Extended Properties=Excel 8.0") : new OleDbConnection($"provider=Microsoft.Jet.OLEDB.4.0;data source={this.txtImportApproved.Text};Extended Properties='Excel 8.0;IMEX=1;HDR=YES'");
      this.da = new OleDbDataAdapter(selectCommandText, this.cn);
      this.cn.Open();
      this.dsCSV = new DataSet();
      this.da.Fill(this.dsCSV);
      this.cn.Close();
      System.Data.DataTable table = this.dsCSV.Tables[0];
      {
        foreach (DataRow row in table.Rows)
        {
          object oInput1 = (object) row[0].ToString();
          string sProductCode = Conversions.ToString(modMain.sNullTest(ref oInput1));
          object oInput2 = (object) row[1].ToString();
          double dValue = modMain.dNullTest(ref oInput2);
          this.InsertApprovedImportRecord(sProductCode, dValue, sValueType);
        }
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error reading Import File: " + ex.Message, true);
      this.cn.Close();
      this.cn = (OleDbConnection) null;
      ProjectData.ClearProjectError();
    }
  }

  public bool InsertApprovedImportRecord(string sProductCode, double dValue, string sValueType)
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
      command.CommandText = "ApprovedCost_UpdateInsert";
      command.Parameters.Add(new SqlParameter("@ProductCode", SqlDbType.VarChar, (int) byte.MaxValue)).Value = (object) sProductCode;
      command.Parameters.Add(new SqlParameter("@Value", SqlDbType.Money)).Value = (object) dValue;
      command.Parameters.Add(new SqlParameter("@ValueType", SqlDbType.Char, 1)).Value = (object) sValueType;
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in InsertApprovedImportRecord: " + ex.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      modMain.mgBox("Error in InsertApprovedImportRecord: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  private void nbManagement_ClientSizeChanged(object sender, EventArgs e)
  {
    this.lstManagement.Height = checked (this.nbManagement.ClientSize.Height + this.iOffset);
  }

  private void cmdBrowseApprovedPrices_Click(object sender, EventArgs e)
  {
    modMain.fdlg = new OpenFileDialog();
    modMain.fdlg.Title = "Browse for Approved Prices Excel File";
    modMain.fdlg.Filter = "Excel files|*.XLS*";
    modMain.fdlg.FilterIndex = 2;
    modMain.fdlg.RestoreDirectory = true;
    if (modMain.fdlg.ShowDialog() != DialogResult.OK)
      return;
    this.txtImportApproved.Text = modMain.fdlg.FileName;
  }

  private void cmdRemoveImported_Click(object sender, EventArgs e)
  {
    if (!modMain.mgBox($"Are you sure you want to Remove Imported Records for {this.lstImported.Text}?", bYesNo: true) || !this.RemoveImported(this.lstImported.Text))
      return;
    modMain.mgBox("Imported Data Removed OK");
    this.RefreshImportViews();
    this.gbImportResults.Visible = false;
  }

  public bool RemoveImported(string sTemplate)
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    bool flag = false;
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = $"Delete from FileImports where TemplateName = '{sTemplate}'";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in RemoveImported: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in RemoveImported: " + ex.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  public void BuildDupProductsTable()
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.StoredProcedure;
      command.CommandText = "DuplicateProducts_CreateTable";
      command.CommandTimeout = 0;
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in BuildDupProductsTable: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in BuildDupProductsTable: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  private void cmdProcessData_Click(object sender, EventArgs e)
  {
    if (!modMain.mgBox("Are you sure you want to Process Selected Data Update Actions?", bYesNo: true))
      return;
    this.Cursor = Cursors.AppStarting;
    if (this.chkOverwriteCosts.Checked)
    {
      if (this.OverwriteApprovedCosts())
        this.chkOverwriteCosts.ForeColor = Color.DarkGreen;
      else
        this.chkOverwriteCosts.ForeColor = Color.DarkRed;
      System.Windows.Forms.Application.DoEvents();
    }
    if (this.chkRecalcNewSell.Checked)
    {
      if (this.RecalcNewSell())
        this.chkRecalcNewSell.ForeColor = Color.DarkGreen;
      else
        this.chkRecalcNewSell.ForeColor = Color.DarkRed;
      System.Windows.Forms.Application.DoEvents();
    }
    if (this.chkOverwriteSell.Checked)
    {
      if (this.OverwriteApprovedSell())
        this.chkOverwriteSell.ForeColor = Color.DarkGreen;
      else
        this.chkOverwriteSell.ForeColor = Color.DarkRed;
      System.Windows.Forms.Application.DoEvents();
    }
    if (this.chkRecalcNewRetail.Checked)
    {
      if (this.RecalcNewRetail())
        this.chkRecalcNewRetail.ForeColor = Color.DarkGreen;
      else
        this.chkRecalcNewRetail.ForeColor = Color.DarkRed;
      System.Windows.Forms.Application.DoEvents();
    }
    if (this.chkOverwriteRetail.Checked)
    {
      if (this.OverwriteApprovedRetail())
        this.chkOverwriteRetail.ForeColor = Color.DarkGreen;
      else
        this.chkOverwriteRetail.ForeColor = Color.DarkRed;
      System.Windows.Forms.Application.DoEvents();
    }
    if (this.chkUpdateCostSellretail.Checked)
    {
      if (this.UpdateCostSellRetail())
        this.chkUpdateCostSellretail.ForeColor = Color.DarkGreen;
      else
        this.chkUpdateCostSellretail.ForeColor = Color.DarkRed;
      System.Windows.Forms.Application.DoEvents();
    }
    if (this.chkUpdatePOPPrices.Checked)
    {
      if (this.UpdatePOPPrices())
        this.chkUpdatePOPPrices.ForeColor = Color.DarkGreen;
      else
        this.chkUpdatePOPPrices.ForeColor = Color.DarkRed;
      System.Windows.Forms.Application.DoEvents();
    }
    this.Cursor = Cursors.Default;
    modMain.mgBox("Processing Complete");
    this.chkOverwriteCosts.Checked = false;
    this.chkRecalcNewSell.Checked = false;
    this.chkOverwriteSell.Checked = false;
    this.chkRecalcNewRetail.Checked = false;
    this.chkOverwriteRetail.Checked = false;
    this.ShowLastManageRunTimes();
  }

  public bool UpdatePOPPrices()
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
      command.CommandText = "I8_UpdatePOPPrices";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in I8_UpdatePOPPrices: " + ex.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      modMain.mgBox("Error in I8_UpdatePOPPrices: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  public bool UpdateCostSellRetail()
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
      command.CommandText = "I8_UpdateCostSellRetail";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in UpdateCostSellRetail: " + ex.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      modMain.mgBox("Error in UpdateCostSellRetail: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  public bool CopyProductsToPending()
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
      command.CommandText = nameof (CopyProductsToPending);
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in CopyProductsToPending: " + ex.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      modMain.mgBox("Error in CopyProductsToPending: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  public bool AnyDuplicates()
  {
    SqlConnection sqlConnection = new SqlConnection();
    int num = 0;
    string str = "Select top 1 ImportID from FileImports where IIHFProductCode in \t(Select F.IIHFProductCode from FileImports F" + " where F.IIHFProductCode <> '' and Deleted = 0 group by  F.IIHFProductCode having(COUNT(F.IIHFProductCode) > 1))";
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    command.CommandText = str;
    command.CommandTimeout = 0;
    try
    {
      System.Data.DataTable dataTable = new System.Data.DataTable();
      dataTable.Load((IDataReader) command.ExecuteReader());
      num = dataTable.Rows.Count;
      command.Dispose();
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in AnyDuplicates: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    finally
    {
      sqlConnection.Close();
      sqlConnection.Dispose();
    }
    return num != 0;
  }

  public void ResetImportedProductsDeletedFlag()
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    bool flag = false;
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = "Update FileImports Set Deleted = 0";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in ResetImportedProductsDeletedFlag: " + ex.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      modMain.mgBox("Error in ResetImportedProductsDeletedFlag: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public bool OverwriteApprovedCosts()
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
      command.CommandText = nameof (OverwriteApprovedCosts);
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in OverwriteApprovedCosts: " + ex.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      modMain.mgBox("Error in OverwriteApprovedCosts: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  public bool OverwriteApprovedSell()
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
      command.CommandText = nameof (OverwriteApprovedSell);
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in OverwriteApprovedSell: " + ex.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      modMain.mgBox("Error in OverwriteApprovedSell: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  public bool OverwriteApprovedRetail()
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
      command.CommandText = nameof (OverwriteApprovedRetail);
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in OverwriteApprovedRetail: " + ex.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      modMain.mgBox("Error in OverwriteApprovedRetail: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  public bool CheckActionLog()
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
      command.CommandText = "CreateActionsLog";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in CreateActionsLog: " + ex.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      modMain.mgBox("Error in CreateActionsLog: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  private void radCost_CheckedChanged(object sender, EventArgs e)
  {
    this.txtImportApproved.Text = "";
  }

  private void radSell_CheckedChanged(object sender, EventArgs e)
  {
    this.txtImportApproved.Text = "";
  }

  private void radRetail_CheckedChanged(object sender, EventArgs e)
  {
    this.txtImportApproved.Text = "";
  }

  private void nbExport_ClientSizeChanged(object sender, EventArgs e)
  {
    this.lblExported.Top = checked (this.lstExport.Top + this.lstExport.Height);
    this.pBoxExportedAsc.Top = checked (this.lblExported.Top + 4);
    this.pboxExportedDesc.Top = checked (this.lblExported.Top + 4);
    this.lstExported.Top = checked (this.lblExported.Top + this.lblExported.Height);
    this.lstExported.Height = checked (this.nbExport.ClientSize.Height - this.lblExported.Height - this.lblExport.Height - this.lstExport.Height + this.iOffset);
  }

  private void lstExport_Click(object sender, EventArgs e)
  {
    if (this.lstExport.Items.Count == 0)
      return;
    this.lblExportTemplateName.Text = this.lstExport.Text;
    this.SetExportFileName(this.lstExport.Text);
    this.lblEmail.Text = this.GeteMail(this.lblExportTemplateName.Text);
  }

  public void SetExportFileName(string sTemplate)
  {
    this.sExportFile = $"{this.sExportPath}\\{sTemplate}.xls";
    this.lblExportFile.Text = this.sExportFile;
  }

  private void lstExport_DoubleClick(object sender, EventArgs e)
  {
  }

  private void lstExport_DrawItem(object sender, DrawItemEventArgs e)
  {
    if (e.Index < 0)
      return;
    e.DrawBackground();
    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
      e.Graphics.FillRectangle(Brushes.Khaki, e.Bounds);
    using (new SolidBrush(e.ForeColor))
      e.Graphics.DrawString(this.lstExport.GetItemText(RuntimeHelpers.GetObjectValue(this.lstExport.Items[e.Index])), e.Font, Brushes.Black, (RectangleF) e.Bounds);
    e.DrawFocusRectangle();
  }

  private void lstExported_Click(object sender, EventArgs e)
  {
    this.cmdResetExportedFlag.Visible = true;
  }

  private void lstExported_DrawItem(object sender, DrawItemEventArgs e)
  {
    if (e.Index < 0)
      return;
    e.DrawBackground();
    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
      e.Graphics.FillRectangle(Brushes.Khaki, e.Bounds);
    using (new SolidBrush(e.ForeColor))
      e.Graphics.DrawString(this.lstExported.GetItemText(RuntimeHelpers.GetObjectValue(this.lstExported.Items[e.Index])), e.Font, Brushes.Black, (RectangleF) e.Bounds);
    e.DrawFocusRectangle();
  }

  private void pBoxExportAsc_Click(object sender, EventArgs e)
  {
    this.RefreshWaitingForExport(false);
    this.pBoxExportDesc.Visible = true;
    this.pBoxExportAsc.Visible = false;
  }

  private void pboxExportedDesc_Click(object sender, EventArgs e)
  {
    this.RefreshExported(true);
    this.pboxExportedDesc.Visible = false;
    this.pBoxExportedAsc.Visible = true;
  }

  private void pBoxExportDesc_Click(object sender, EventArgs e)
  {
    this.RefreshWaitingForExport(true);
    this.pBoxExportDesc.Visible = false;
    this.pBoxExportAsc.Visible = true;
  }

  private void pBoxExportedAsc_Click(object sender, EventArgs e)
  {
    this.RefreshExported(false);
    this.pboxExportedDesc.Visible = true;
    this.pBoxExportedAsc.Visible = false;
  }

  private void cmdBrowseBackupFoler_Click(object sender, EventArgs e)
  {
    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtBackupPath.Text), "", false) != 0)
      folderBrowserDialog.SelectedPath = Strings.Trim(this.txtBackupPath.Text);
    folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
    folderBrowserDialog.Description = "Select the Database Backup directory";
    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
      this.txtBackupPath.Text = folderBrowserDialog.SelectedPath;
  }

  private void cmdBrowseExportFolder_Click(object sender, EventArgs e)
  {
    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtExportLocation.Text), "", false) != 0)
      folderBrowserDialog.SelectedPath = Strings.Trim(this.txtExportLocation.Text);
    folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
    folderBrowserDialog.Description = "Select the File Export directory";
    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
      this.txtExportLocation.Text = folderBrowserDialog.SelectedPath;
  }

  private void cmdExport_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtExportLocation.Text), "", false) == 0)
      modMain.mgBox("Please Configure Export Directory in Settings Screen");
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.lblExportTemplateName.Text), "", false) == 0)
    {
      modMain.mgBox("Select Template to Export ");
    }
    else
    {
      if (this.ExportTemplateData(this.lblExportTemplateName.Text, this.lblExportFile.Text))
      {
        this.UpdateExportedFlag(this.lblExportTemplateName.Text, true);
        this.NotifyExportFileCreatedAndOfferOpen(this.lblExportFile.Text);
        this.RefreshExportViews();
        /* Original: send export by e-mail (SMTP or Outlook). Disabled — user is prompted to open file instead.
        if (this.chkOutlook.Checked)
        {
          if (this.eMailFile(this.lblExportFile.Text, this.lblEmail.Text))
            modMain.mgBox("Export File Created and Mailed");
          else
            modMain.mgBox("Export File Created but NOT Mailed");
        }
        else if (this.SendMail(this.lblExportFile.Text, this.lblEmail.Text))
        {
          modMain.mgBox("Export File Created and Mailed");
          this.UpdateExportedFlag(this.lblExportTemplateName.Text, true);
        }
        else
          modMain.mgBox("Export File Created but NOT Mailed");
        */
      }
      this.Cursor = Cursors.Default;
    }
  }

  /// <summary>Notifies that the export file exists; user may dismiss (No) or open it (Yes).</summary>
  private void NotifyExportFileCreatedAndOfferOpen(string fullPath, string preambleOrNull = null)
  {
    if (string.IsNullOrEmpty(fullPath))
    {
      modMain.mgBox("Export completed but the file path was empty.");
      return;
    }
    string path = fullPath;
    try
    {
      if (!Path.IsPathRooted(path))
        path = Path.GetFullPath(path);
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      path = fullPath;
      ProjectData.ClearProjectError();
    }
    if (!File.Exists(path))
    {
      modMain.mgBox("Export completed but the file was not found:\n" + path, true);
      return;
    }
    string text = preambleOrNull != null
      ? preambleOrNull + "\n\n" + path + "\n\nClick \"Yes\" to open this file, or \"No\" to close."
      : "The export file has been created:\n\n" + path + "\n\nClick \"Yes\" to open the file now, or \"No\" to close.";
    DialogResult dr = MessageBox.Show(
      text,
      "Export created",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Information,
      MessageBoxDefaultButton.Button2);
    if (dr == DialogResult.Yes)
    {
      try
      {
        Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Could not open the file: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
    }
  }

  public bool SendMail(string sFileName, string sEmailAddress)
  {
    return false;
    /* Original SMTP send — disabled (see NotifyExportFileCreatedAndOfferOpen).
    bool flag = false;
    this.GetFileName(sFileName);
    System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(sFileName);
    string[] strArray1 = new string[6];
    int index1 = 0;
    sEmailAddress = Strings.Replace(sEmailAddress, " ", "");
    while (index1 <= 5)
    {
      strArray1[index1] = "";
      checked { ++index1; }
    }
    int index2 = 0;
    object oInput1 = (object) sEmailAddress;
    object Left1 = modMain.sNullTest(ref oInput1);
    sEmailAddress = Conversions.ToString(oInput1);
    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(Left1, (object) "", false))
      return false;
    if (!sEmailAddress.Contains(";"))
    {
      strArray1[0] = sEmailAddress;
    }
    else
    {
      while (Strings.Len(sEmailAddress) > 0)
      {
        if (sEmailAddress.Contains(";"))
        {
          string Expression = Strings.Mid(sEmailAddress, 1, checked (Strings.InStr(sEmailAddress, ";") - 1));
          strArray1[index2] = Expression;
          sEmailAddress = Strings.Mid(sEmailAddress, checked (Strings.Len(Expression) + 2), checked (Strings.Len(sEmailAddress) - Strings.Len(Expression)));
          checked { ++index2; }
        }
        else
        {
          strArray1[index2] = sEmailAddress;
          sEmailAddress = "";
        }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArray1[0], "", false) == 0)
      return false;
    try
    {
      MailMessage message = new MailMessage();
      MailMessage mailMessage = message;
      mailMessage.From = new MailAddress(this.txteMailSender.Text);
      int index3 = 0;
      while (index3 <= 5)
      {
        string[] strArray2 = strArray1;
        string[] strArray3 = strArray2;
        int index4 = index3;
        int index5 = index4;
        object oInput2 = (object) strArray3[index5];
        object Left2 = modMain.sNullTest(ref oInput2);
        strArray2[index4] = Conversions.ToString(oInput2);
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(Left2, (object) "", false), (object) (Strings.InStr(strArray1[index3], "@") > 0))))
          mailMessage.To.Add(strArray1[index3]);
        checked { ++index3; }
      }
      mailMessage.Bcc.Add(this.txteMailSender.Text);
      mailMessage.Subject = this.txteMailSubject.Text;
      mailMessage.Body = this.txteMailBody.Text;
      if (this.chkAttach.Checked)
        mailMessage.Attachments.Add(attachment);
      new SmtpClient(modMain.sRelay)
      {
        Credentials = ((ICredentialsByHost) new NetworkCredential(modMain.sEmailUser, modMain.sEmailPwd))
      }.Send(message);
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      modMain.mgBox("Error in eMail File: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
    return !flag;
    */
  }

  public bool eMailFile(string sFileName, string sEmailAddress)
  {
    return false;
    /* Original Outlook send — disabled (see NotifyExportFileCreatedAndOfferOpen).
    bool flag = false;
    string fileName = this.GetFileName(sFileName);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(sEmailAddress), "", false) == 0)
      return false;
    try
    {
      _MailItem mailItem = (_MailItem) ((Microsoft.Office.Interop.Outlook._Application) new Microsoft.Office.Interop.Outlook.ApplicationClass()).CreateItem(OlItemType.olMailItem);
      mailItem.Subject = this.txteMailSubject.Text;
      mailItem.Body = this.txteMailBody.Text;
      mailItem.To = sEmailAddress;
      string Source = sFileName;
      string DisplayName = fileName;
      string str = Conversions.ToString(mailItem.Body.Length);
      Attachments attachments = mailItem.Attachments;
      Microsoft.Office.Interop.Outlook.Attachment attachment;
      if (this.chkAttach.Checked)
        attachment = attachments.Add((object) Source, (object) Missing.Value, (object) (Conversions.ToDouble(str) + 1.0), (object) DisplayName);
      mailItem.Send();
      attachment = (Microsoft.Office.Interop.Outlook.Attachment) null;
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in Send eMailFile: " + ex.Message);
      ProjectData.ClearProjectError();
    }
    try
    {
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      modMain.mgBox("Error in eMail File: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
    return !flag;
    */
  }

  public bool ExportTemplateData(string sTemplate, string sExportPath)
  {
    bool flag1 = false;
    System.Data.DataTable exportData = null;
    try
    {
      exportData = this.GetExportData(sTemplate);
      Microsoft.Office.Interop.Excel.ApplicationClass o1 = new Microsoft.Office.Interop.Excel.ApplicationClass();
      Workbook o2 = o1.Workbooks.Add((object) Missing.Value);
      Worksheet activeSheet = (Worksheet) o2.ActiveSheet;
      NewLateBinding.LateSetComplex(o1.Selection, (System.Type) null, "NumberFormat", new object[1]
      {
        (object) "Text"
      }, (string[]) null, (System.Type[]) null, false, true);
      activeSheet.get_Range((object) "J1", (object) Missing.Value).EntireColumn.NumberFormat = (object) "@";
      activeSheet.get_Range((object) "K1", (object) Missing.Value).EntireColumn.NumberFormat = (object) "@";
      activeSheet.get_Range((object) "L1", (object) Missing.Value).EntireColumn.NumberFormat = (object) "@";
      int ColumnIndex1 = 0;
      int num = 0;
      {
        foreach (DataColumn column in (InternalDataCollectionBase) exportData.Columns)
        {
          checked { ++ColumnIndex1; }
          o1.Cells[(object) 1, (object) ColumnIndex1] = (object) column.ColumnName;
        }
      }
      {
        foreach (DataRow row in exportData.Rows)
        {
          checked { ++num; }
          int ColumnIndex2 = 0;
          {
            foreach (DataColumn column in (InternalDataCollectionBase) exportData.Columns)
            {
              checked { ++ColumnIndex2; }
              o1.Cells[(object) checked (num + 1), (object) ColumnIndex2] = RuntimeHelpers.GetObjectValue(row[column.ColumnName]);
            }
          }
        }
      }
      activeSheet.Columns.AutoFit();
      string sExportFile = this.sExportFile;
      bool flag2 = false;
      try
      {
        System.IO.File.OpenWrite(sExportFile).Close();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag2 = false;
        ProjectData.ClearProjectError();
      }
      if (System.IO.File.Exists(sExportFile))
        System.IO.File.Delete(sExportFile);
      o2.SaveAs((object) sExportFile, (object) XlFileFormat.xlExcel8, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, ConflictResolution: (object) Missing.Value, AddToMru: (object) Missing.Value, TextCodepage: (object) Missing.Value, TextVisualLayout: (object) Missing.Value, Local: (object) Missing.Value);
      GC.Collect();
      GC.WaitForPendingFinalizers();
      Marshal.FinalReleaseComObject((object) activeSheet);
      o2.Close((object) false, (object) false, (object) Missing.Value);
      Marshal.FinalReleaseComObject((object) o2);
      o1.Quit();
      Marshal.FinalReleaseComObject((object) o1);
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag1 = true;
      modMain.mgBox("Error in ExportTemplateData: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
    exportData?.Dispose();
    return !flag1;
  }

  public System.Data.DataTable GetExportData(string sTemplate)
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.StoredProcedure;
    command.CommandText = "Template_Export";
    command.Parameters.Add(new SqlParameter("@TemplateName", SqlDbType.VarChar, (int) byte.MaxValue)).Value = (object) sTemplate;
    System.Data.DataTable exportData = null;
    try
    {
      System.Data.DataTable dataTable = new System.Data.DataTable();
      dataTable.Load((IDataReader) command.ExecuteReader());
      command.Dispose();
      exportData = dataTable;
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in GetExportData: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
    finally
    {
      sqlConnection.Close();
      sqlConnection.Dispose();
    }
    return exportData;
  }

  public void SetNewProductsUpdate()
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = "Update LastActionTimes set ImportNewProducts = GETDATE()";
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in ClearNewProductsTable: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in ClearNewProductsTable: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void ClearNewProductsCode()
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = "Update NewProducts set code = ''";
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in ClearNewProductsCode: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in ClearNewProductsCode: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void ClearNewProductsTable()
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = "Truncate Table NewProducts";
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in ClearNewProductsTable: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in ClearNewProductsTable: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void UpdateExportedFlag(string sTemplate, bool bExported)
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = !bExported ? $"Update Templates Set Exported = 0 where TemplateName = '{sTemplate}'" : $"Update Templates Set Exported = 1 where TemplateName = '{sTemplate}'";
      sqlDataAdapter2.SelectCommand = command;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in UpdateExportedFlag: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in UpdateExportedFlag: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  private void cmdResetExportedFlag_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.lstExported.Text), "", false) == 0)
      return;
    this.UpdateExportedFlag(this.lstExported.Text, false);
    this.cmdResetExportedFlag.Visible = false;
    this.RefreshExportViews();
  }

  private void nbNewProducts_ClientSizeChanged(object sender, EventArgs e)
  {
    this.lstNewProducts.Height = checked (this.nbNewProducts.ClientSize.Height + this.iOffset);
  }

  private void cmdBrowseNewProducts_Click(object sender, EventArgs e)
  {
    modMain.fdlg = new OpenFileDialog();
    modMain.fdlg.Title = "Browse for New Product Import Excel File";
    modMain.fdlg.Filter = "Excel files|*.XLS*";
    modMain.fdlg.FilterIndex = 2;
    modMain.fdlg.RestoreDirectory = true;
    if (modMain.fdlg.ShowDialog() != DialogResult.OK)
      return;
    this.txtImportNewProducts.Text = modMain.fdlg.FileName;
  }

  private void cmdImportNewProducts_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.txtImportNewProducts.Text), "", false) == 0)
    {
      modMain.mgBox("Select New Product Import File");
      this.cmdBrowseNewProducts.Focus();
    }
    else if (!this.txtImportNewProducts.Text.ToLower().Contains(".xls") & !this.txtImportNewProducts.Text.ToLower().Contains(".xlsx"))
    {
      modMain.mgBox("File must be Office Excel Format");
      this.txtImportNewProducts.Focus();
    }
    else
    {
      this.cmdUpdateProducts.Visible = false;
      this.lblUpdateInfo.Visible = false;
      this.lblCreateIndexRecords.Visible = false;
      this.lblCreateNominals.Visible = false;
      this.lblCreatePriceBands.Visible = false;
      this.lblCreateStockCodes.Visible = false;
      this.lblUpdateTaxCodes.Visible = false;
      this.lblUpdateParams.Visible = false;
      this.lblUpdateNominals.Visible = false;
      this.lblCreateProdultListItems.Visible = false;
      if (this.ImportNewProductFile(this.txtImportNewProducts.Text))
      {
        this.ClearNewProductsCode();
        this.UpdateNewProducts();
        this.ShowMappingResults();
        this.SetNewProductsUpdate();
        this.ShowLastNewProductImportDate();
        this.txtImportNewProducts.Text = "";
        this.Cursor = Cursors.Default;
        modMain.mgBox("New products Imported OK");
      }
    }
  }

  public bool ImportNewProductFile(string sFilename)
  {
    bool flag = false;
    this.Cursor = Cursors.AppStarting;
    this.ClearNewProductsTable();
    this.sExt = Path.GetExtension(sFilename);
    string selectCommandText = "select * from [Sheet1$]";
    try
    {
      DataSet dataSet;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.sExt, ".xls", false) == 0)
      {
        this.cn = new OleDbConnection($"provider=Microsoft.Jet.OLEDB.4.0;data source={sFilename};Extended Properties='Excel 8.0;IMEX=1;HDR=YES'");
        this.da = new OleDbDataAdapter(selectCommandText, this.cn);
        this.cn.Open();
        dataSet = new DataSet();
        this.da.Fill(dataSet);
        this.cn.Close();
      }
      else
      {
        this.cn = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;data Source={sFilename} ;Extended Properties=\"Excel 12.0 Xml;IMEX=1;HDR=YES\"");
        ExcelOpenXmlReader openXmlReader = (ExcelOpenXmlReader) ExcelReaderFactory.CreateOpenXmlReader((Stream) new FileStream(sFilename, FileMode.Open, FileAccess.Read));
        openXmlReader.IsFirstRowAsColumnNames = true;
        dataSet = openXmlReader.AsDataSet();
      }
      System.Data.DataTable table = dataSet.Tables[0];
      {
        foreach (DataRow row in table.Rows)
                    this.InsertNewProductRecord(Conversions.ToString(modMain.sNullTest(ref row.ItemArray[0])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[1])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[2])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[3])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[4])), modMain.iNullTest(ref row.ItemArray[5]), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[6])), modMain.dNullTest(ref row.ItemArray[7]), modMain.dNullTest(ref row.ItemArray[8]), modMain.dNullTest(ref row.ItemArray[9]), modMain.dNullTest(ref row.ItemArray[10]), modMain.dNullTest(ref row.ItemArray[11]), modMain.dNullTest(ref row.ItemArray[12]), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[13])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[14])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[15])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[16 /*0x10*/])), modMain.dNullTest(ref row.ItemArray[17]), modMain.dNullTest(ref row.ItemArray[18]), modMain.dNullTest(ref row.ItemArray[19]), modMain.dNullTest(ref row.ItemArray[20]), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[21])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[22])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[23])), modMain.iNullTest(ref row.ItemArray[24]), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[25])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[26])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[27])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[28])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[29])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[30])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[31 /*0x1F*/])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[32 /*0x20*/])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[33])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[34])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[35])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[36])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[37])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[38])));
                //this.InsertNewProductRecord(Conversions.ToString(modMain.sNullTest(ref row.ItemArray[0])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[1])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[2])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[3])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[4])), modMain.iNullTest(ref row.ItemArray[5]), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[6])), modMain.dNullTest(ref row.ItemArray[7]), modMain.dNullTest(ref row.ItemArray[8]), modMain.dNullTest(ref row.ItemArray[9]), modMain.dNullTest(ref row.ItemArray[10]), modMain.dNullTest(ref row.ItemArray[11]), modMain.dNullTest(ref row.ItemArray[12]), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[13])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[14])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[15])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[16 /*0x10*/])), modMain.dNullTest(ref row.ItemArray[17]), modMain.dNullTest(ref row.ItemArray[18]), modMain.dNullTest(ref row.ItemArray[19]), modMain.dNullTest(ref row.ItemArray[20]), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[21])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[22])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[23])), modMain.iNullTest(ref row.ItemArray[24]), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[25])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[26])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[27])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[28])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[29])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[30])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[31 /*0x1F*/])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[32 /*0x20*/])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[33])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[34])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[35])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[36])), Conversions.ToString(modMain.sNullTest(ref row.ItemArray[37])));
            }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      this.Cursor = Cursors.Default;
      modMain.mgBox("Error in ImportNewProductFile: " + exception.Message, true);
      this.cn.Close();
      this.cn = (OleDbConnection) null;
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  public bool InsertNewProductRecord(
    string Code,
    string ProductGroup,
    string Subgroup,
    string Description,
    string IssueUnit,
    int IssueQty,
    string ProductType,
    double CostPrice,
    double SellingPrice,
    double VATPercent,
    double RetailPrice,
    double MarkupPercent,
    double RetailMarkupPercent,
    string ReportCode,
    string FloorCode,
    string PreferredSupplier,
    string ExternalCode,
    double ExternalPrice,
    double ListPrice,
    double NetPrice,
    double SupplierDiscount,
    string NetOrGross,
    string Currency,
    string Number,
    int PurchaseInQty,
    string Barcode,
    string CatalogSection,
    string Index,
    string Organic,
    string NominalCode,
    string GlutenFree,
    string Orgainic,
    string FairTrade,
    string WheatFree,
    string DairyFree,
    string NoAddedSugar,
    string Vegan,
    string Irish,
    string CommodityCode)
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
      command.CommandText = "NewProducts_Insert";
      SqlParameter sqlParameter1 = command.Parameters.Add(new SqlParameter("@Code", SqlDbType.VarChar, 20));
      object oInput1 = (object) Code;
      object obj1 = modMain.sNullTest(ref oInput1);
      Code = Conversions.ToString(oInput1);
      object objectValue1 = RuntimeHelpers.GetObjectValue(obj1);
      sqlParameter1.Value = objectValue1;
      SqlParameter sqlParameter2 = command.Parameters.Add(new SqlParameter("@ProductGroup", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput2 = (object) ProductGroup;
      object obj2 = modMain.sNullTest(ref oInput2);
      ProductGroup = Conversions.ToString(oInput2);
      object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
      sqlParameter2.Value = objectValue2;
      SqlParameter sqlParameter3 = command.Parameters.Add(new SqlParameter("@SubGroup", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput3 = (object) Subgroup;
      object obj3 = modMain.sNullTest(ref oInput3);
      Subgroup = Conversions.ToString(oInput3);
      object objectValue3 = RuntimeHelpers.GetObjectValue(obj3);
      sqlParameter3.Value = objectValue3;
      SqlParameter sqlParameter4 = command.Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar, 40));
      object oInput4 = (object) Description;
      object obj4 = modMain.sNullTest(ref oInput4);
      Description = Conversions.ToString(oInput4);
      object objectValue4 = RuntimeHelpers.GetObjectValue(obj4);
      sqlParameter4.Value = objectValue4;
      SqlParameter sqlParameter5 = command.Parameters.Add(new SqlParameter("@IssueUnit", SqlDbType.VarChar, 10));
      object oInput5 = (object) IssueUnit;
      object obj5 = modMain.sNullTest(ref oInput5);
      IssueUnit = Conversions.ToString(oInput5);
      object objectValue5 = RuntimeHelpers.GetObjectValue(obj5);
      sqlParameter5.Value = objectValue5;
      SqlParameter sqlParameter6 = command.Parameters.Add(new SqlParameter("@IssueQty", SqlDbType.Int));
      object oInput6 = (object) IssueQty;
      int num1 = modMain.iNullTest(ref oInput6);
      IssueQty = Conversions.ToInteger(oInput6);
      sqlParameter6.Value = (object) num1;
      SqlParameter sqlParameter7 = command.Parameters.Add(new SqlParameter("@ProductType", SqlDbType.Char, 1));
      object oInput7 = (object) ProductType;
      object obj6 = modMain.sNullTest(ref oInput7);
      ProductType = Conversions.ToString(oInput7);
      object objectValue6 = RuntimeHelpers.GetObjectValue(obj6);
      sqlParameter7.Value = objectValue6;
      SqlParameter sqlParameter8 = command.Parameters.Add(new SqlParameter("@CostPrice", SqlDbType.Money));
      object oInput8 = (object) CostPrice;
      double num2 = modMain.dNullTest(ref oInput8);
      CostPrice = Conversions.ToDouble(oInput8);
      sqlParameter8.Value = (object) num2;
      SqlParameter sqlParameter9 = command.Parameters.Add(new SqlParameter("@SellingPrice", SqlDbType.Money));
      object oInput9 = (object) SellingPrice;
      double num3 = modMain.dNullTest(ref oInput9);
      SellingPrice = Conversions.ToDouble(oInput9);
      sqlParameter9.Value = (object) num3;
      SqlParameter sqlParameter10 = command.Parameters.Add(new SqlParameter("@VATPercent", SqlDbType.Money));
      object oInput10 = (object) VATPercent;
      double num4 = modMain.dNullTest(ref oInput10);
      VATPercent = Conversions.ToDouble(oInput10);
      sqlParameter10.Value = (object) num4;
      SqlParameter sqlParameter11 = command.Parameters.Add(new SqlParameter("@RetailPrice", SqlDbType.Money));
      object oInput11 = (object) RetailPrice;
      double num5 = modMain.dNullTest(ref oInput11);
      RetailPrice = Conversions.ToDouble(oInput11);
      sqlParameter11.Value = (object) num5;
      SqlParameter sqlParameter12 = command.Parameters.Add(new SqlParameter("@MarkupPercent", SqlDbType.Money));
      object oInput12 = (object) MarkupPercent;
      double num6 = modMain.dNullTest(ref oInput12);
      MarkupPercent = Conversions.ToDouble(oInput12);
      sqlParameter12.Value = (object) num6;
      SqlParameter sqlParameter13 = command.Parameters.Add(new SqlParameter("@RetailMarkupPercent", SqlDbType.Money));
      object oInput13 = (object) RetailMarkupPercent;
      double num7 = modMain.dNullTest(ref oInput13);
      RetailMarkupPercent = Conversions.ToDouble(oInput13);
      sqlParameter13.Value = (object) num7;
      SqlParameter sqlParameter14 = command.Parameters.Add(new SqlParameter("@ReportCode", SqlDbType.VarChar, 20));
      object oInput14 = (object) ReportCode;
      object obj7 = modMain.sNullTest(ref oInput14);
      ReportCode = Conversions.ToString(oInput14);
      object objectValue7 = RuntimeHelpers.GetObjectValue(obj7);
      sqlParameter14.Value = objectValue7;
      SqlParameter sqlParameter15 = command.Parameters.Add(new SqlParameter("@FloorCode", SqlDbType.VarChar, 100));
      object oInput15 = (object) FloorCode;
      object obj8 = modMain.sNullTest(ref oInput15);
      FloorCode = Conversions.ToString(oInput15);
      object objectValue8 = RuntimeHelpers.GetObjectValue(obj8);
      sqlParameter15.Value = objectValue8;
      SqlParameter sqlParameter16 = command.Parameters.Add(new SqlParameter("@PreferredSupplier", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput16 = (object) PreferredSupplier;
      object obj9 = modMain.sNullTest(ref oInput16);
      PreferredSupplier = Conversions.ToString(oInput16);
      object objectValue9 = RuntimeHelpers.GetObjectValue(obj9);
      sqlParameter16.Value = objectValue9;
      SqlParameter sqlParameter17 = command.Parameters.Add(new SqlParameter("@ExternalCode", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput17 = (object) ExternalCode;
      object obj10 = modMain.sNullTest(ref oInput17);
      ExternalCode = Conversions.ToString(oInput17);
      object objectValue10 = RuntimeHelpers.GetObjectValue(obj10);
      sqlParameter17.Value = objectValue10;
      SqlParameter sqlParameter18 = command.Parameters.Add(new SqlParameter("@ExternalPrice", SqlDbType.Money));
      object oInput18 = (object) ExternalPrice;
      double num8 = modMain.dNullTest(ref oInput18);
      ExternalPrice = Conversions.ToDouble(oInput18);
      sqlParameter18.Value = (object) num8;
      SqlParameter sqlParameter19 = command.Parameters.Add(new SqlParameter("@ListPrice", SqlDbType.Money));
      object oInput19 = (object) ListPrice;
      double num9 = modMain.dNullTest(ref oInput19);
      ListPrice = Conversions.ToDouble(oInput19);
      sqlParameter19.Value = (object) num9;
      SqlParameter sqlParameter20 = command.Parameters.Add(new SqlParameter("@NetPrice", SqlDbType.Money));
      object oInput20 = (object) NetPrice;
      double num10 = modMain.dNullTest(ref oInput20);
      NetPrice = Conversions.ToDouble(oInput20);
      sqlParameter20.Value = (object) num10;
      SqlParameter sqlParameter21 = command.Parameters.Add(new SqlParameter("@SupplierDiscount", SqlDbType.Money));
      object oInput21 = (object) SupplierDiscount;
      double num11 = modMain.dNullTest(ref oInput21);
      SupplierDiscount = Conversions.ToDouble(oInput21);
      sqlParameter21.Value = (object) num11;
      SqlParameter sqlParameter22 = command.Parameters.Add(new SqlParameter("@NetOrGross", SqlDbType.VarChar, 10));
      object oInput22 = (object) NetOrGross;
      object obj11 = modMain.sNullTest(ref oInput22);
      NetOrGross = Conversions.ToString(oInput22);
      object objectValue11 = RuntimeHelpers.GetObjectValue(obj11);
      sqlParameter22.Value = objectValue11;
      SqlParameter sqlParameter23 = command.Parameters.Add(new SqlParameter("@Currency", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput23 = (object) Currency;
      object obj12 = modMain.sNullTest(ref oInput23);
      Currency = Conversions.ToString(oInput23);
      object objectValue12 = RuntimeHelpers.GetObjectValue(obj12);
      sqlParameter23.Value = objectValue12;
      SqlParameter sqlParameter24 = command.Parameters.Add(new SqlParameter("@085", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput24 = (object) Number;
      object obj13 = modMain.sNullTest(ref oInput24);
      Number = Conversions.ToString(oInput24);
      object objectValue13 = RuntimeHelpers.GetObjectValue(obj13);
      sqlParameter24.Value = objectValue13;
      SqlParameter sqlParameter25 = command.Parameters.Add(new SqlParameter("@PurchaseInQty", SqlDbType.Int));
      object oInput25 = (object) PurchaseInQty;
      int num12 = modMain.iNullTest(ref oInput25);
      PurchaseInQty = Conversions.ToInteger(oInput25);
      sqlParameter25.Value = (object) num12;
      SqlParameter sqlParameter26 = command.Parameters.Add(new SqlParameter("@Barcode", SqlDbType.VarChar, 20));
      object oInput26 = (object) Barcode;
      object obj14 = modMain.sNullTest(ref oInput26);
      Barcode = Conversions.ToString(oInput26);
      object objectValue14 = RuntimeHelpers.GetObjectValue(obj14);
      sqlParameter26.Value = objectValue14;
      SqlParameter sqlParameter27 = command.Parameters.Add(new SqlParameter("@CatalogSection", SqlDbType.VarChar, 100));
      object oInput27 = (object) CatalogSection;
      object obj15 = modMain.sNullTest(ref oInput27);
      CatalogSection = Conversions.ToString(oInput27);
      object objectValue15 = RuntimeHelpers.GetObjectValue(obj15);
      sqlParameter27.Value = objectValue15;
      SqlParameter sqlParameter28 = command.Parameters.Add(new SqlParameter("@Index", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput28 = (object) Index;
      object obj16 = modMain.sNullTest(ref oInput28);
      Index = Conversions.ToString(oInput28);
      object objectValue16 = RuntimeHelpers.GetObjectValue(obj16);
      sqlParameter28.Value = objectValue16;
      SqlParameter sqlParameter29 = command.Parameters.Add(new SqlParameter("@Organic", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput29 = (object) Organic;
      object obj17 = modMain.sNullTest(ref oInput29);
      Organic = Conversions.ToString(oInput29);
      object objectValue17 = RuntimeHelpers.GetObjectValue(obj17);
      sqlParameter29.Value = objectValue17;
      SqlParameter sqlParameter30 = command.Parameters.Add(new SqlParameter("@NominalCode", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput30 = (object) NominalCode;
      object obj18 = modMain.sNullTest(ref oInput30);
      NominalCode = Conversions.ToString(oInput30);
      object objectValue18 = RuntimeHelpers.GetObjectValue(obj18);
      sqlParameter30.Value = objectValue18;
      SqlParameter sqlParameter31 = command.Parameters.Add(new SqlParameter("@GlutenFree", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput31 = (object) GlutenFree;
      object obj19 = modMain.sNullTest(ref oInput31);
      GlutenFree = Conversions.ToString(oInput31);
      object objectValue19 = RuntimeHelpers.GetObjectValue(obj19);
      sqlParameter31.Value = objectValue19;
      SqlParameter sqlParameter32 = command.Parameters.Add(new SqlParameter("@Orgainic", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput32 = (object) Orgainic;
      object obj20 = modMain.sNullTest(ref oInput32);
      Orgainic = Conversions.ToString(oInput32);
      object objectValue20 = RuntimeHelpers.GetObjectValue(obj20);
      sqlParameter32.Value = objectValue20;
      SqlParameter sqlParameter33 = command.Parameters.Add(new SqlParameter("@FairTrade", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput33 = (object) FairTrade;
      object obj21 = modMain.sNullTest(ref oInput33);
      FairTrade = Conversions.ToString(oInput33);
      object objectValue21 = RuntimeHelpers.GetObjectValue(obj21);
      sqlParameter33.Value = objectValue21;
      SqlParameter sqlParameter34 = command.Parameters.Add(new SqlParameter("@WheatFree", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput34 = (object) WheatFree;
      object obj22 = modMain.sNullTest(ref oInput34);
      WheatFree = Conversions.ToString(oInput34);
      object objectValue22 = RuntimeHelpers.GetObjectValue(obj22);
      sqlParameter34.Value = objectValue22;
      SqlParameter sqlParameter35 = command.Parameters.Add(new SqlParameter("@DairyFree", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput35 = (object) DairyFree;
      object obj23 = modMain.sNullTest(ref oInput35);
      DairyFree = Conversions.ToString(oInput35);
      object objectValue23 = RuntimeHelpers.GetObjectValue(obj23);
      sqlParameter35.Value = objectValue23;
      SqlParameter sqlParameter36 = command.Parameters.Add(new SqlParameter("@NoAddedSugar", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput36 = (object) NoAddedSugar;
      object obj24 = modMain.sNullTest(ref oInput36);
      NoAddedSugar = Conversions.ToString(oInput36);
      object objectValue24 = RuntimeHelpers.GetObjectValue(obj24);
      sqlParameter36.Value = objectValue24;
      SqlParameter sqlParameter37 = command.Parameters.Add(new SqlParameter("@Vegan", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput37 = (object) Vegan;
      object obj25 = modMain.sNullTest(ref oInput37);
      Vegan = Conversions.ToString(oInput37);
      object objectValue25 = RuntimeHelpers.GetObjectValue(obj25);
      sqlParameter37.Value = objectValue25;
      SqlParameter sqlParameter38 = command.Parameters.Add(new SqlParameter("@Irish", SqlDbType.VarChar, (int) byte.MaxValue));
      object oInput38 = (object) Irish;
      object obj26 = modMain.sNullTest(ref oInput38);
      Irish = Conversions.ToString(oInput38);
      object objectValue26 = RuntimeHelpers.GetObjectValue(obj26);
      sqlParameter38.Value = objectValue26;
      SqlParameter sqlParameter39 = command.Parameters.Add(
      new SqlParameter("@CommodityCode", SqlDbType.VarChar, 50));
      object oInput39 = (object)CommodityCode;
      object obj27 = modMain.sNullTest(ref oInput39);
      CommodityCode = Conversions.ToString(oInput39);
      object objectValue27 = RuntimeHelpers.GetObjectValue(obj27);
      sqlParameter39.Value = objectValue27;
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in InsertNewProductRecord: " + ex.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      flag = true;
      modMain.mgBox("Error in InsertNewProductRecord: " + exception.Message, true);
      ProjectData.ClearProjectError();
    }
    return !flag;
  }

  public void ShowLastNewProductImportDate()
  {
    SqlConnection sqlConnection = new SqlConnection();
    sqlConnection.ConnectionString = modMain.gsAppConnection;
    sqlConnection.Open();
    SqlCommand command = sqlConnection.CreateCommand();
    command.CommandType = CommandType.Text;
    string str = "Select top 1 ImportNewProducts from LastActionTimes";
    command.CommandText = str;
    try
    {
      SqlDataReader sqlDataReader = command.ExecuteReader();
      if (!sqlDataReader.HasRows)
        return;
      while (sqlDataReader.Read())
        this.lblNewProductsLastImported.Text = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader["ImportNewProducts"])) ? Strings.FormatDateTime(Conversions.ToDate(sqlDataReader["ImportNewProducts"]), DateFormat.ShortDate) : "Never";
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in ShowLastNewProductImportDate: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void UpdateNewProducts()
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = "Exec UpdateNewProducts";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in UpdateNewProducts: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in UpdateNewProducts: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  public void ShowMappingResults()
  {
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    this.cmdUpdateProducts.Visible = false;
    this.cmdResolve.Visible = true;
        this.cmdResolveClear.Visible = true; // Added by Zeljko
        try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.StoredProcedure;
      command.CommandText = "GetNewProductMappingResults";
      command.Parameters.Add(new SqlParameter("@TotalRecords", SqlDbType.Int)).Value = (object) 0;
      command.Parameters.Add(new SqlParameter("@MappedProductGroups", SqlDbType.Int)).Value = (object) 0;
      command.Parameters.Add(new SqlParameter("@MappedSubGroups", SqlDbType.Int)).Value = (object) 0;
      command.Parameters.Add(new SqlParameter("@MappedSuppliers", SqlDbType.Int)).Value = (object) 0;
      command.Parameters.Add(new SqlParameter("@IndexCount", SqlDbType.Int)).Value = (object) 0;
      command.Parameters.Add(new SqlParameter("@MappedIndex", SqlDbType.Int)).Value = (object) 0;
      command.Parameters.Add(new SqlParameter("@MappedPriceList", SqlDbType.Int)).Value = (object) 0;
      command.Parameters.Add(new SqlParameter("@SupplierCount", SqlDbType.Int)).Value = (object) 0;
      command.Parameters["@TotalRecords"].Direction = ParameterDirection.Output;
      command.Parameters["@MappedProductGroups"].Direction = ParameterDirection.Output;
      command.Parameters["@MappedSubGroups"].Direction = ParameterDirection.Output;
      command.Parameters["@IndexCount"].Direction = ParameterDirection.Output;
      command.Parameters["@MappedSuppliers"].Direction = ParameterDirection.Output;
      command.Parameters["@MappedIndex"].Direction = ParameterDirection.Output;
      command.Parameters["@MappedPriceList"].Direction = ParameterDirection.Output;
      command.Parameters["@SupplierCount"].Direction = ParameterDirection.Output;
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
        SqlParameter parameter1 = command.Parameters["@TotalRecords"];
        object objectValue = RuntimeHelpers.GetObjectValue(parameter1.Value);
        int num1 = modMain.iNullTest(ref objectValue);
        parameter1.Value = RuntimeHelpers.GetObjectValue(objectValue);
        int num2 = num1;
        SqlParameter parameter2 = command.Parameters["@MappedProductGroups"];
        objectValue = RuntimeHelpers.GetObjectValue(parameter2.Value);
        int num3 = modMain.iNullTest(ref objectValue);
        parameter2.Value = RuntimeHelpers.GetObjectValue(objectValue);
        int num4 = num3;
        SqlParameter parameter3 = command.Parameters["@MappedSubGroups"];
        objectValue = RuntimeHelpers.GetObjectValue(parameter3.Value);
        int num5 = modMain.iNullTest(ref objectValue);
        parameter3.Value = RuntimeHelpers.GetObjectValue(objectValue);
        int num6 = num5;
        SqlParameter parameter4 = command.Parameters["@MappedSuppliers"];
        objectValue = RuntimeHelpers.GetObjectValue(parameter4.Value);
        int num7 = modMain.iNullTest(ref objectValue);
        parameter4.Value = RuntimeHelpers.GetObjectValue(objectValue);
        int num8 = num7;
        SqlParameter parameter5 = command.Parameters["@IndexCount"];
        objectValue = RuntimeHelpers.GetObjectValue(parameter5.Value);
        modMain.iNullTest(ref objectValue);
        parameter5.Value = RuntimeHelpers.GetObjectValue(objectValue);
        SqlParameter parameter6 = command.Parameters["@MappedIndex"];
        objectValue = RuntimeHelpers.GetObjectValue(parameter6.Value);
        int num9 = modMain.iNullTest(ref objectValue);
        parameter6.Value = RuntimeHelpers.GetObjectValue(objectValue);
        int num10 = num9;
        SqlParameter parameter7 = command.Parameters["@MappedPriceList"];
        objectValue = RuntimeHelpers.GetObjectValue(parameter7.Value);
        int num11 = modMain.iNullTest(ref objectValue);
        parameter7.Value = RuntimeHelpers.GetObjectValue(objectValue);
        int num12 = num11;
        SqlParameter parameter8 = command.Parameters["@SupplierCount"];
        objectValue = RuntimeHelpers.GetObjectValue(parameter8.Value);
        int num13 = modMain.iNullTest(ref objectValue);
        parameter8.Value = RuntimeHelpers.GetObjectValue(objectValue);
        int num14 = num13;
        this.lblMappedProductGroups.Text = $"Mapped Product Groups {Conversions.ToString(num4)} of {Conversions.ToString(num2)}";
        this.lblMappedSubGroups.Text = $"Mapped Sub Groups {Conversions.ToString(num6)} of {Conversions.ToString(num2)}";
        this.lblMappedSuppliers.Text = $"Mapped Suppliers {Conversions.ToString(num8)} of {Conversions.ToString(num14)}";
        this.lblMappedINdex.Text = $"Mapped Index {Conversions.ToString(num10)} of {Conversions.ToString(num2)}";
        this.lblMappedPriceLists.Text = $"Mapped Price Lists {Conversions.ToString(num12)} of {Conversions.ToString(num2)}";
        this.cmdUpdateProducts.Visible = true;
        if (num4 == num2)
        {
          this.lblMappedProductGroups.ForeColor = Color.DarkGreen;
          this.radResolveProdGroups.Visible = false;
        }
        else
        {
          this.lblMappedProductGroups.ForeColor = Color.DarkRed;
          this.radResolveProdGroups.Visible = true;
          this.cmdUpdateProducts.Visible = false;
        }
        if (num6 == num2)
        {
          this.lblMappedSubGroups.ForeColor = Color.DarkGreen;
          this.radResolveSubGroups.Visible = false;
        }
        else
        {
          this.lblMappedSubGroups.ForeColor = Color.DarkRed;
          this.radResolveSubGroups.Visible = true;
          this.cmdUpdateProducts.Visible = false;
        }
        if (num8 == num14)
        {
          this.lblMappedSuppliers.ForeColor = Color.DarkGreen;
          this.radResolveSuppliers.Visible = false;
        }
        else
        {
          this.lblMappedSuppliers.ForeColor = Color.DarkRed;
          this.radResolveSuppliers.Visible = true;
          this.cmdUpdateProducts.Visible = false;
        }
        if (num10 == num2)
        {
          this.lblMappedINdex.ForeColor = Color.DarkGreen;
          this.radResolveIndex.Visible = false;
        }
        else
        {
          this.lblMappedINdex.ForeColor = Color.DarkRed;
          this.radResolveIndex.Visible = true;
        }
        if (num12 == num2)
          this.lblMappedPriceLists.ForeColor = Color.DarkGreen;
        else
          this.lblMappedPriceLists.ForeColor = Color.DarkRed;
        if (!(this.lblMappedProductGroups.ForeColor == Color.DarkGreen & this.lblMappedSubGroups.ForeColor == Color.DarkGreen & this.lblMappedSuppliers.ForeColor == Color.DarkGreen))
          return;
        this.cmdUpdateProducts.Visible = true;
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in ShowMappingResults: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      modMain.mgBox("Error in ShowMappingResults: " + ex.Message, true);
      ProjectData.ClearProjectError();
    }
  }

  private void cmdExportAll_Click(object sender, EventArgs e)
  {
    if (!modMain.mgBox("Are you sure you want to export ALL Templates?", bYesNo: true))
      return;
    this.ExportAllTemplates();
  }

  public object ExportAllTemplates()
  {
    int count = this.lstExport.Items.Count;
    object obj = null;
    if (count == 0)
    {
      obj = (object) true;
    }
    else
    {
      int num1 = 0;
      this.Cursor = Cursors.AppStarting;
      try
      {
        int index = 0;
        string lastExportPath = null;
        while (index <= checked (count - 1))
        {
          this.lblExportTemplateName.Text = ((DataRowView) this.lstExport.Items[index]).Row[0].ToString();
          this.SetExportFileName(this.lblExportTemplateName.Text);
          this.lblEmail.Text = this.GeteMail(this.lblExportTemplateName.Text);
          System.Windows.Forms.Application.DoEvents();
          if (this.ExportTemplateData(this.lblExportTemplateName.Text, this.lblExportFile.Text))
          {
            checked { ++num1; }
            this.UpdateExportedFlag(this.lblExportTemplateName.Text, true);
            lastExportPath = this.lblExportFile.Text;
            /* Original: e-mail each export via SendMail; disabled — see NotifyExportFileCreatedAndOfferOpen.
            if (this.SendMail(this.lblExportFile.Text, this.lblEmail.Text))
            {
              checked { ++num2; }
              this.UpdateExportedFlag(this.lblExportTemplateName.Text, true);
            }
            */
          }
          checked { ++index; }
          this.lblInfo.Text = $"{Conversions.ToString(num1)} Excel file(s) created — {Conversions.ToString(checked (count - index))} template(s) still to process";
          System.Windows.Forms.Application.DoEvents();
        }
        this.RefreshExportViews();
        this.Cursor = Cursors.Default;
        this.lblExportTemplateName.Text = "";
        this.lblEmail.Text = "";
        this.lblExportFile.Text = "";
        if (num1 > 0 && !string.IsNullOrEmpty(lastExportPath))
          this.NotifyExportFileCreatedAndOfferOpen(
            lastExportPath,
            $"Export complete. {Conversions.ToString(num1)} file(s) created.\n\nLast export file:");
        else
          modMain.mgBox("Export Complete");
        obj = (object) true;
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        modMain.mgBox("Error in ExportAllTemplates: " + ex.Message, true);
        ProjectData.ClearProjectError();
      }
    }
    return obj;
  }

  public void SpamCoolDown()
  {
    this.pbarSpam.Value = 0;
    this.pbarSpam.Maximum = checked (modMain.iCooldown * 10);
    this.lblSpam.Visible = true;
    this.pbarSpam.Visible = true;
    while (this.pbarSpam.Value < this.pbarSpam.Maximum)
    {
      Thread.Sleep(100);
      checked { ++this.pbarSpam.Value; }
      System.Windows.Forms.Application.DoEvents();
    }
    this.lblSpam.Visible = false;
    this.pbarSpam.Visible = false;
  }

  private void lstExport_SelectedIndexChanged(object sender, EventArgs e)
  {
  }

  private void cmdResolve_Click(object sender, EventArgs e)
  {
    if (this.radResolveProdGroups.Checked)
    {
      int num = (int) new frmResolveProdugtGroups().ShowDialog();
      this.UpdateNewProducts();
    }
    if (this.radResolveSubGroups.Checked)
    {
      int num1 = (int) new frmResolveSubGroups().ShowDialog();
    }
    if (this.radResolveSuppliers.Checked)
    {
      int num2 = (int) new frmResolveSupplier().ShowDialog();
    }
    if (this.radResolveIndex.Checked)
    {
      int num3 = (int) new frmResolveIndex().ShowDialog();
    }
    this.ShowMappingResults();
  }
    // Added by Zeljko
    private void cmdResolveClear_Click(object sender, EventArgs e)
    {
        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(modMain.gsAppConnection))
            using (SqlCommand command = new SqlCommand("Truncate table NewProducts", sqlConnection))
            {
                sqlConnection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Cleared data!", "Message", MessageBoxButtons.OK);
            } // Both connection and command are automatically closed/disposed here

            this.naviBar1.ActiveBand = this.nbImport;
            System.Windows.Forms.Application.DoEvents();
            this.naviBar1.ActiveBand = this.nbNewProducts;
            System.Windows.Forms.Application.DoEvents();
            /*ZVEplanation frm = new ZVEplanation();
        frm.ShowDialog();*/
}
        catch (System.Exception ex)
        {
            modMain.mgBox("Error in Clearing Data: " + ex.Message, true);
        }
    }

    private void cmdUpdateProducts_Click(object sender, EventArgs e)
  {
    if (!modMain.mgBox("Are you sure you want to update New Products to ISM?", bYesNo: true))
      return;
    this.lblUpdateInfo.Visible = true;
    this.CreateStockCodes();
    this.UpdateTaxCodes();
    this.CreateNominals();
    this.UpdateProductParameters();
    this.CreateProductListItems();
    this.InsertPendingPriceRecords();
    this.CreatePriceBandRecords();
    this.CreateIndexRecords();
    this.UpdateNominals();
    this.lblUpdateInfo.Text = "New Product Update Proceessing Completed";
  }

  public void CreateIndexRecords()
  {
    this.Cursor = Cursors.AppStarting;
    this.lblUpdateInfo.Text = "Creating Product Index Analysis Records for New Products (Step 8 of 9)";
    System.Windows.Forms.Application.DoEvents();
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    bool flag = false;
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = "NewProducts_CreateIndexRecords";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        System.Exception exception = ex;
        this.Cursor = Cursors.Default;
        modMain.mgBox("Error in CreateIndexRecords: " + exception.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      this.Cursor = Cursors.Default;
      modMain.mgBox("Error in CreateIndexRecords: " + exception.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    if (!flag)
    {
      this.lblCreateIndexRecords.Text = "Product Index Analysis Records Created OK";
      this.lblCreateIndexRecords.ForeColor = Color.DarkGreen;
    }
    else
    {
      this.lblCreateIndexRecords.Text = "Error Creating Product Index Analysis Records";
      this.lblCreateIndexRecords.ForeColor = Color.DarkRed;
    }
    this.lblCreateIndexRecords.Visible = true;
    System.Windows.Forms.Application.DoEvents();
    this.Cursor = Cursors.Default;
  }

  public void UpdateNominals()
  {
    this.Cursor = Cursors.AppStarting;
    this.lblUpdateInfo.Text = "Updating Nominal Codes (Step 9 of 9)";
    System.Windows.Forms.Application.DoEvents();
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    bool flag = false;
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = "NewProducts_UpdateNominals";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        System.Exception exception = ex;
        this.Cursor = Cursors.Default;
        modMain.mgBox("Error in UpdateNominals: " + exception.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      this.Cursor = Cursors.Default;
      modMain.mgBox("Error in UpdateNominals: " + exception.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    if (!flag)
    {
      this.lblUpdateNominals.Text = "Nominal Codes Updated OK";
      this.lblUpdateNominals.ForeColor = Color.DarkGreen;
    }
    else
    {
      this.lblUpdateNominals.Text = "Error Updating Nominal COdes";
      this.lblUpdateNominals.ForeColor = Color.DarkRed;
    }
    this.lblUpdateNominals.Visible = true;
    System.Windows.Forms.Application.DoEvents();
    this.Cursor = Cursors.Default;
  }

  public void CreatePriceBandRecords()
  {
    this.Cursor = Cursors.AppStarting;
    this.lblUpdateInfo.Text = "Creating Price Band Records for New Products (Step 7 of 9)";
    System.Windows.Forms.Application.DoEvents();
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    bool flag = false;
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = "NewProducts_CreatePriceBands";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        System.Exception exception = ex;
        this.Cursor = Cursors.Default;
        modMain.mgBox("Error in CreatePriceBandRecords: " + exception.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      this.Cursor = Cursors.Default;
      modMain.mgBox("Error in CreatePriceBandRecords: " + exception.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    if (!flag)
    {
      this.lblCreatePriceBands.Text = "Price Band Records Created OK";
      this.lblCreatePriceBands.ForeColor = Color.DarkGreen;
    }
    else
    {
      this.lblCreatePriceBands.Text = "Error Creating Price Band Records";
      this.lblCreatePriceBands.ForeColor = Color.DarkRed;
    }
    this.lblCreatePriceBands.Visible = true;
    System.Windows.Forms.Application.DoEvents();
    this.Cursor = Cursors.Default;
  }

  public void InsertPendingPriceRecords()
  {
    this.Cursor = Cursors.AppStarting;
    this.lblUpdateInfo.Text = "Inserting Pending Price Records for New Products (Step 6 of 9)";
    System.Windows.Forms.Application.DoEvents();
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    bool flag = false;
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = "NewProducts_InsertPendingPriceRecords";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        System.Exception exception = ex;
        this.Cursor = Cursors.Default;
        modMain.mgBox("Error in InsertPendingPriceRecords: " + exception.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      this.Cursor = Cursors.Default;
      modMain.mgBox("Error in InsertPendingPriceRecords: " + exception.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    if (!flag)
    {
      this.lblUpdateNominals.Text = "Pending Price Records Created OK";
      this.lblUpdateNominals.ForeColor = Color.DarkGreen;
    }
    else
    {
      this.lblUpdateNominals.Text = "Error Creating Pending Price Records";
      this.lblUpdateNominals.ForeColor = Color.DarkRed;
    }
    this.lblUpdateNominals.Visible = true;
    System.Windows.Forms.Application.DoEvents();
    this.Cursor = Cursors.Default;
  }

  public void CreateProductListItems()
  {
    this.Cursor = Cursors.AppStarting;
    this.lblUpdateInfo.Text = "Creating Product List Items for New Products (Step 5 of 9)";
    System.Windows.Forms.Application.DoEvents();
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    bool flag = false;
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = "NewProducts_CreateProductListItems";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        System.Exception exception = ex;
        this.Cursor = Cursors.Default;
        modMain.mgBox("Error in CreateProductListItems: " + exception.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      this.Cursor = Cursors.Default;
      modMain.mgBox("Error in CreateProductListItems: " + exception.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    if (!flag)
    {
      this.lblCreateProdultListItems.Text = "Product List Item Records Created OK";
      this.lblCreateProdultListItems.ForeColor = Color.DarkGreen;
    }
    else
    {
      this.lblCreateProdultListItems.Text = "Error Creating Product List Item Records";
      this.lblCreateProdultListItems.ForeColor = Color.DarkRed;
    }
    this.lblCreateProdultListItems.Visible = true;
    System.Windows.Forms.Application.DoEvents();
    this.Cursor = Cursors.Default;
  }

  public void UpdateProductParameters()
  {
    this.Cursor = Cursors.AppStarting;
    this.lblUpdateInfo.Text = "Updating Parameter Records for New Products (Step 4 of 9)";
    System.Windows.Forms.Application.DoEvents();
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    bool flag = false;
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = "NewProducts_UpdateParameters";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        System.Exception exception = ex;
        this.Cursor = Cursors.Default;
        modMain.mgBox("Error in UpdateProductParameters: " + exception.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      this.Cursor = Cursors.Default;
      modMain.mgBox("Error in UpdateProductParameters: " + exception.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    if (!flag)
    {
      this.lblUpdateParams.Text = "Product Parameters Updated OK";
      this.lblUpdateParams.ForeColor = Color.DarkGreen;
    }
    else
    {
      this.lblUpdateParams.Text = "Error Updating Product Parameters";
      this.lblUpdateParams.ForeColor = Color.DarkRed;
    }
    this.lblUpdateParams.Visible = true;
    System.Windows.Forms.Application.DoEvents();
    this.Cursor = Cursors.Default;
  }

  public void CreateNominals()
  {
    this.Cursor = Cursors.AppStarting;
    this.lblUpdateInfo.Text = "Creating Nominal Records Codes for New Products (Step 3 of 9)";
    System.Windows.Forms.Application.DoEvents();
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    bool flag = false;
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = "NewProducts_CreateNominals";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        System.Exception exception = ex;
        this.Cursor = Cursors.Default;
        modMain.mgBox("Error in CreateNominals: " + exception.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      this.Cursor = Cursors.Default;
      modMain.mgBox("Error in CreateNominals: " + exception.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    if (!flag)
    {
      this.lblCreateNominals.Text = "Nominal Records Created OK";
      this.lblCreateNominals.ForeColor = Color.DarkGreen;
    }
    else
    {
      this.lblCreateNominals.Text = "Error Creating Nominal Records";
      this.lblCreateNominals.ForeColor = Color.DarkRed;
    }
    this.lblCreateNominals.Visible = true;
    System.Windows.Forms.Application.DoEvents();
    this.Cursor = Cursors.Default;
  }

  public void UpdateTaxCodes()
  {
    this.Cursor = Cursors.AppStarting;
    this.lblUpdateInfo.Text = "Updating Tax Codes for New Products (Step 2 of 9)";
    System.Windows.Forms.Application.DoEvents();
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    bool flag = false;
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = "NewProducts_UpdateTaxCodes";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        System.Exception exception = ex;
        this.Cursor = Cursors.Default;
        modMain.mgBox("Error in UpdateTaxCodes: " + exception.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      this.Cursor = Cursors.Default;
      modMain.mgBox("Error in UpdateTaxCodes: " + exception.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    if (!flag)
    {
      this.lblUpdateTaxCodes.Text = "Tax Codes Updated OK";
      this.lblUpdateTaxCodes.ForeColor = Color.DarkGreen;
    }
    else
    {
      this.lblUpdateTaxCodes.Text = "Error Updating Tax Codes";
      this.lblUpdateTaxCodes.ForeColor = Color.DarkRed;
    }
    this.lblUpdateTaxCodes.Visible = true;
    System.Windows.Forms.Application.DoEvents();
    this.Cursor = Cursors.Default;
  }

  public void CreateStockCodes()
  {
    this.Cursor = Cursors.AppStarting;
    this.lblUpdateInfo.Text = "Generating Stock Codes and Posting to ISM (Step 1 of 9)";
    System.Windows.Forms.Application.DoEvents();
    SqlConnection sqlConnection = new SqlConnection();
    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
    bool flag = false;
    try
    {
      SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
      sqlConnection.ConnectionString = modMain.gsAppConnection;
      SqlCommand command = sqlConnection.CreateCommand();
      command.CommandType = CommandType.Text;
      command.CommandText = "Exec NewProducts_CreateStockCodes";
      sqlDataAdapter2.SelectCommand = command;
      command.CommandTimeout = 0;
      try
      {
        sqlConnection.Open();
        command.ExecuteNonQuery();
      }
      catch (System.Exception ex)
      {
        ProjectData.SetProjectError(ex);
        System.Exception exception = ex;
        this.Cursor = Cursors.Default;
        modMain.mgBox("Error in CreateStockCodes: " + exception.Message, true);
        flag = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        sqlConnection?.Close();
      }
    }
    catch (System.Exception ex)
    {
      ProjectData.SetProjectError(ex);
      System.Exception exception = ex;
      this.Cursor = Cursors.Default;
      modMain.mgBox("Error in CreateStockCodes: " + exception.Message, true);
      flag = true;
      ProjectData.ClearProjectError();
    }
    if (!flag)
    {
      this.lblCreateStockCodes.Text = "Stock Codes Created OK";
      this.lblCreateStockCodes.ForeColor = Color.DarkGreen;
    }
    else
    {
      this.lblCreateStockCodes.Text = "Error Creating Stock Codes";
      this.lblCreateStockCodes.ForeColor = Color.DarkRed;
    }
    this.lblCreateStockCodes.Visible = true;
    System.Windows.Forms.Application.DoEvents();
    this.Cursor = Cursors.Default;
  }

  private object SpinningProgress1() => throw new NotImplementedException();

  private void tpNewProducts_Click(object sender, EventArgs e)
  {
  }

  private void tpManage_Click(object sender, EventArgs e)
  {
  }

  private void cmdProductMaint_Click(object sender, EventArgs e)
  {
    if (!modMain.mgBox("Are you sure you want to Process Selected Product Maintenance Actions?", bYesNo: true))
      return;
    this.Cursor = Cursors.AppStarting;
    if (this.chkDuplicateProducts.Checked)
    {
      if (this.chkIncludeDeleted.Checked)
        this.ResetImportedProductsDeletedFlag();
      this.chkDuplicateProducts.Text = "Preparing Duplicates....";
      System.Windows.Forms.Application.DoEvents();
      this.BuildDupProductsTable();
      int num = (int) new frmDuplicateProductsV2().ShowDialog();
      this.chkDuplicateProducts.Text = "Review Duplicate Products";
      System.Windows.Forms.Application.DoEvents();
    }
    if (this.chkCopyPending.Checked)
    {
      if (this.AnyDuplicates())
        modMain.mgBox("There are Duplicate Products - Cannot Copy To Pending File");
      else if (this.CopyProductsToPending())
        this.chkCopyPending.ForeColor = Color.DarkGreen;
      else
        this.chkCopyPending.ForeColor = Color.DarkRed;
    }
    this.Cursor = Cursors.Default;
    modMain.mgBox("Processing Complete");
    this.chkDuplicateProducts.Checked = false;
    this.chkIncludeDeleted.Checked = false;
    this.chkCopyPending.Checked = false;
    this.ShowLastManageRunTimes();
  }
}
