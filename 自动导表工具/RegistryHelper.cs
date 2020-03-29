using System;
using System.Text;
using Microsoft.Win32;
using Newtonsoft.Json;


namespace TableTools
{
    /// <summary>
    /// 注册表相关
    /// 作用记录路径等配置
    /// </summary>
    public class RegistryHelper
    {
        /// <summary>
        /// 初始化数据
        /// </summary>
        public static void InitData()
        {
            var registerData= GetRegistryData("TableTool", "Heaven");
            if (registerData == null)
            {
                var data = new RegistryData();
                data.GetData();
                var serialize = JsonConvert.SerializeObject(data);
                SetRegistryData("TableTool", "Heaven",Encoding.UTF8.GetBytes(serialize));
            }
            else
            {
                var deserialize = JsonConvert.DeserializeObject<RegistryData>(Encoding.UTF8.GetString(registerData));
                deserialize.GetData();
            }
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        public static void SaveData()
        {
            var data = new RegistryData();
            data.SetData();
            var serialize = JsonConvert.SerializeObject(data);
            SetRegistryData("TableTool", "Heaven", Encoding.UTF8.GetBytes(serialize));
        }

        /// <summary>
        /// 注册表标识
        /// </summary>
        /// <param name="pSubKey"></param>
        /// <param name="pName"></param>
        private static void SetRegistryData(string pSubKey, string pName,byte[] pValue)
        {
            var myKey = Registry.CurrentUser.CreateSubKey(pSubKey);
            myKey?.SetValue(pName, pValue);
        }

        /// <summary>
        /// 读取指定名称的注册表
        /// </summary>
        /// <param name="pSubKey"></param>
        /// <param name="pName"></param>
        /// <returns></returns>
        public static byte[] GetRegistryData(string pSubKey, string pName)
        {
            byte[] data = null;
            var myKey = Registry.CurrentUser.OpenSubKey(pSubKey, true);
            if (myKey != null)
                data =(byte[])myKey.GetValue(pName);

            return data;
        }
    }

    public class RegistryData
    {
        //是否导出代码
        public static bool mCanExportCode = true;
        //是否导出配置
        public static bool mCanExportConfig = true;
        //配置路径
        public string mConfigPath="c:";
        //代码路径
        public string mCodePath = "c:";
        //文件路径
        public string mExcelPath = "c:";
        //导出代码类型
        public ExportCodeType mExportCodeType = ExportCodeType.CSharp;
        //导出配置类型
        public ExportConfigType mExportconfigType = ExportConfigType.Client;

        public void GetData()
        {
            Main._ExcelPath = mExcelPath;
            Main._CodePath = mCodePath;
            Main._ConfigPath = mConfigPath;
            Main._CanExportCode = mCanExportCode;
            Main._CanExportConfig = mCanExportConfig;
            Main._ExportCodeType = mExportCodeType;
            Main._ExportConfigType = mExportconfigType;
        }

        public void SetData()
        {            
            mExcelPath = Main._ExcelPath;
            mCodePath = Main._CodePath;
            mConfigPath = Main._ConfigPath;
            mCanExportCode = Main._CanExportCode;
            mCanExportConfig = Main._CanExportConfig;
            mExportCodeType = Main._ExportCodeType;
            mExportconfigType = Main._ExportConfigType;
        }

    }
}
