using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TableTools
{
    public partial class Main : Form
    {
        //Excel路径
        public static string _ExcelPath = "";
        //代码路径
        public static string _CodePath = "";
        //配置路径
        public static string _ConfigPath = "";
        //导出代码类型
        public static ExportCodeType _ExportCodeType = ExportCodeType.CSharp;
        //导出配置类型
        public static ExportConfigType _ExportConfigType = ExportConfigType.Client;
        //是否导出代码
        public static bool _CanExportCode = true;
        //是否导出配置
        public static bool _CanExportConfig = true;
        public static List<ExcelFilenfo> excelFileList = new List<ExcelFilenfo>(64);

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender,EventArgs e)
        {
            RegistryHelper.InitData();

            mExcelPath.Text = _ExcelPath;
            mConfigPath.Text = _ConfigPath;
            mCodePath.Text = _CodePath;

            //不点选生成代码，点选代码不会生效
            if (!_CanExportCode)
            {
                isGenerateCode.Checked = false;
                mTsCode.Checked = false;
                mCSharpCode.Checked = false;
                mCppCode.Checked = false;
                mAsCode.Checked = false;
                mJsCode.Checked = false;
            }
            else
            {
                isGenerateCode.Checked = true;
                mCSharpCode.Checked = true;
                mTsCode.Checked = true;
                mCppCode.Checked = true;
                mAsCode.Checked = true;
                mJsCode.Checked = true;
            }

            if (!_CanExportConfig)
            {
                isGenerateConfig.Checked = false;
                mServerConfig.Enabled = false;
                mClientConfig.Enabled = false;
            }
            else
            {
                isGenerateConfig.Checked = true;
                mServerConfig.Enabled = true;
                mClientConfig.Enabled = true;
            }

            RefreshExcels();
        }

        //刷新面板上的Excel数据
        public void RefreshExcels()
        {
            checkedListConfigFile.Items.Clear();        //先清空
            var path = mExcelPath.Text;
            FileHelper.GetExcelFiles(path, excelFileList);
            RefreshAllPaths();
            
            foreach (var excelFileInfo in excelFileList)
            {
                checkedListConfigFile.Items.Add(new ExcelFilenfo
                {
                    Name = excelFileInfo.Name,
                    Path=excelFileInfo.Path
                },CheckState.Unchecked);    //添加选中的值
            }

        }

        public void RefreshAllPaths()
        {
            _ExcelPath = mExcelPath.Text;
            _ConfigPath = mConfigPath.Text;
            _CodePath = mCodePath.Text;

        }

        private void BtnSelectExcelPath_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog { Description = "选择Excel文件目录" };   //面板上的提示文字

            if (folder.ShowDialog() == DialogResult.OK)
            {
                _ExcelPath = folder.SelectedPath;
                mExcelPath.Text = _ExcelPath;
                RefreshExcels();
            }
        }

        //选择配置目录
        private void BtnSelectConfigPath_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog { Description = "选择输出配置路径" };
            if (folder.ShowDialog() == DialogResult.OK)
            {
                _ConfigPath = folder.SelectedPath;
                mConfigPath.Text = _ConfigPath;
            }
        }

        //选择输出代码目录
        private void BtnSelectCodePath_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog { Description = "选择代码目录" };
            if (folder.ShowDialog() == DialogResult.OK)
            {
                _CodePath = folder.SelectedPath;
                mCodePath.Text = _CodePath;
            }
        }

        //全部取消
        private void BtnCancelAllConfig_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < checkedListConfigFile.Items.Count; i++)
                checkedListConfigFile.SetItemChecked(i, false);
        }

        //全部选中
        private void BtnSelectAllConfig_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < checkedListConfigFile.Items.Count; i++)
                checkedListConfigFile.SetItemChecked(i, true);
        }

        //刷新配置表
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshExcels();
            AddLog("Refresh Data Successful!", false);
        }

        public void ShowLog()
        {
            AddLog("开始生成...", false);
            AddLog("");
            AddLog($"输出代码类型:[{_ExportCodeType}]");
            AddLog($"导出配置类型:[{_ExportConfigType}]");
        }

        public void AddLog(string pLog,bool pAppend = true)
        {
            if (pAppend)
                textBoxLog.AppendText(pLog + "\r\n");
            else
                textBoxLog.Text = pLog;
        }

        //点选是否生成代码 默认选中
        private void IsGenerateCode_CheckedChanged(object sender, EventArgs e)
        {
            if (isGenerateCode.Checked)
            {
                _CanExportCode = true;
                mCSharpCode.Enabled = true;
                mCppCode.Enabled = true;
                mTsCode.Enabled = true;
                mAsCode.Enabled = true;
                mJsCode.Enabled = true;
                if (_ExportCodeType == ExportCodeType.CSharp)
                    mCSharpCode.Checked = true;
                else if (_ExportCodeType == ExportCodeType.Cpp)
                    mCppCode.Checked = true;
                else if (_ExportCodeType == ExportCodeType.ActionScript)
                    mAsCode.Checked = true;
                else if (_ExportCodeType == ExportCodeType.JavaScript)
                    mJsCode.Checked = true;
                else if (_ExportCodeType == ExportCodeType.TypeScript)
                    mTsCode.Checked = true;
            }
            else
            {
                _CanExportCode = false;
                mCSharpCode.Enabled = false;
                mCppCode.Enabled = false;
                mTsCode.Enabled = false;
                mAsCode.Enabled = false;
                mJsCode.Enabled = false;

            }


        }

        //点选生成配置
        private void IsGenerateConfig_CheckedChanged(object sender, EventArgs e)
        {
            if (isGenerateConfig.Checked)
            {
                _CanExportConfig = true;
                mServerConfig.Enabled = true;
                mClientConfig.Enabled = true;
                if (_ExportConfigType == ExportConfigType.Client)
                    mClientConfig.Checked = true;
                else
                    mServerConfig.Checked = true;
            }
            else
            {
                _CanExportConfig = false;
                mServerConfig.Enabled = false;
                mClientConfig.Enabled = false;
            }
        }

        private void MCSharpCode_CheckedChanged(object sender, EventArgs e)
        {
            _ExportCodeType = ExportCodeType.CSharp;
            RegistryHelper.SaveData();
        }

        private void MCppCode_CheckedChanged(object sender, EventArgs e)
        {
            _ExportCodeType = ExportCodeType.Cpp;
            RegistryHelper.SaveData();
        }

        private void MAsCode_CheckedChanged(object sender, EventArgs e)
        {
            _ExportCodeType = ExportCodeType.ActionScript;
            RegistryHelper.SaveData();
        }

        private void MJsCode_CheckedChanged(object sender, EventArgs e)
        {
            _ExportCodeType = ExportCodeType.JavaScript;
            RegistryHelper.SaveData();
        }

        private void MTsCode_CheckedChanged(object sender, EventArgs e)
        {
            _ExportCodeType = ExportCodeType.TypeScript;
            RegistryHelper.SaveData();
        }

        private void MServerConfig_CheckedChanged(object sender, EventArgs e)
        {
            _ExportConfigType = ExportConfigType.Server;
        }

        private void MClientConfig_CheckedChanged(object sender, EventArgs e)
        {
            _ExportConfigType = ExportConfigType.Client;
        }

        private void BtnStartGenerate_Click(object sender, EventArgs e)
        {
            RefreshAllPaths();
            ShowLog();

            for(var i = 0; i < checkedListConfigFile.Items.Count; i++)
            {
                //是否被选中
                if (checkedListConfigFile.GetItemCheckState(i) != CheckState.Checked)
                    continue;

                var excelFileInfo = checkedListConfigFile.Items[i] as ExcelFilenfo;

                var data = ExcelHelper.ImportExcelFile(excelFileInfo.Path);
                var meta = ExcelHelper.ParseTableMeta(excelFileInfo.Name, data, ExportConfigType.Client);
                //生成代码
                if (_CanExportCode)
                {
                    try
                    {
                        AddLog($"开始生成[{meta._tableName}]代码");
                        GenerateCodeHelper.GenerateCode(meta, _CodePath, _ExportCodeType, _ExportConfigType);
                        AddLog($"生成[{meta._tableName}]代码成功");
                    }
                    catch (Exception exp)
                    {

                        AddLog($"生成[{meta._tableName}]代码异常=>{ exp.Message}");
                    }
                }

                //生成配置
                if (_CanExportConfig)
                {
                    try
                    {
                        AddLog($"开始生成[{meta._tableName}]配置");
                        ConfigHelper.GenerateConfig(data, _ConfigPath, meta, _ExportConfigType);
                        AddLog($"生成[{meta._tableName}]配置成功");
                    }
                    catch (Exception exp)
                    {
                        AddLog($"生成[{meta._tableName}]配置出现异常=>{exp.Message}");
                    }
                }

                AddLog("");

            }
            RegistryHelper.SaveData();
        }

        private void GenerateTableManager_Click(object sender, EventArgs e)
        {
            RefreshAllPaths();

            //先拿到文件夹里面有多少张表
            var path = mExcelPath.Text;
            FileHelper.GetExcelFiles(path, excelFileList);

            List<string> allTableName = new List<string>();
            for (int i = 0; i < checkedListConfigFile.Items.Count; i++)
            {
                var excelFileInfo = checkedListConfigFile.Items[i] as ExcelFilenfo;
                allTableName.Add(excelFileInfo.Name);
            }

            if (allTableName.Count >= excelFileList.Count)
            {
                GenerateCodeHelper.GenerateCSharpTableManager(_CodePath, allTableName);
                AddLog("生成TableManager类成功");
            }
            else
            {
                AddLog("生成TableManager类失败，数据源区没有任何数据");
            }
        }
    }
}
