using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTools
{
    /// <summary>
    /// 生成配置文件帮助类
    /// </summary>
    class ConfigHelper
    {
        public static string JsonHead = "{";
        public static string JsonTail = "}";
        public static string JsonDataBegin = @"  {";
        public static string JsonDataEnd = @"  }";

        public static string JsonDataName_1 = " \"mDataMap\":{";    //以Map形式保存
        public static string JsonDataName_2 = "\"mDataList\":[";    //以List形式保存

        public static void GenerateConfig(DataTable pDataTable,string pPath,MetaHelper pTableMeta,ExportConfigType pConfigType)
        {
            var _Path = Path.Combine(pPath, pTableMeta.ClassName + ".json");        //生成Json格式文件
            var isMap = pTableMeta.CheckTypeIsMap();    //是否是Map的形式保存的判断
            using (var fs = new FileStream(_Path, FileMode.Create, FileAccess.Write))
            {
                using (var sw=new StreamWriter(fs, Encoding.UTF8))
                {
                    //规定好写入的文件内容形式（json）
                    sw.WriteLine(JsonHead);
                    sw.WriteLine(isMap ? JsonDataName_1 : JsonDataName_2);
                    
                    //规定表里面的数据从第四行开始
                    for(var iRow = 4; iRow < pDataTable.Rows.Count; iRow++)
                    {
                        if (isMap)
                            sw.WriteLine("  \"{0}\":", pDataTable.Rows[iRow].ItemArray[0]);

                        sw.WriteLine(JsonDataBegin);
                        for(var iCol = 0; iCol < pDataTable.Columns.Count; iCol++)      //列
                        {
                            if (!pTableMeta.tableFields[iCol].IsExportField(pConfigType))
                            {
                                continue;
                            }

                            if (iCol != 0)
                                sw.WriteLine(",");

                            sw.Write("    \"{0}\":", pTableMeta.tableFields[iCol].mFieldName);
                            var data = pDataTable.Rows[iRow].ItemArray[iCol].ToString();

                            if (pTableMeta.tableFields[iCol].mTypeName == "int")
                                sw.Write(ParseInt(data));
                            else if (pTableMeta.tableFields[iCol].mTypeName == "float")
                                sw.Write(ParseFloat(data));
                            else if (pTableMeta.tableFields[iCol].mTypeName == "bool")
                                sw.Write(ParseBool(data));
                            else if (pTableMeta.tableFields[iCol].mTypeName == "int[]")
                                sw.Write(ParseIntList(data));
                            else if (pTableMeta.tableFields[iCol].mTypeName == "float[]")
                                sw.Write(ParseFloatList(data));
                            else if (pTableMeta.tableFields[iCol].mTypeName == "string[]")
                                sw.Write(ParseStringList(data));
                            else if (pTableMeta.tableFields[iCol].mTypeName == "string")
                                sw.Write(ParseString(data));

                        }

                        sw.WriteLine();
                        sw.Write(JsonDataEnd);      //Json文件书写完毕

                        if (iRow != pDataTable.Rows.Count - 1)
                            sw.WriteLine(",");
                        else
                            sw.WriteLine();

                    }

                    //尾部处理
                    sw.WriteLine(isMap ? "   }" : "  ]");
                    sw.WriteLine(JsonTail);

                }
            }
        }


        public static string ParseInt(object pObj)
        {
            return pObj.ToString();
        }

        public static string ParseFloat(object pObj)
        {
            return pObj.ToString();
        }

        public static string ParseString(object pObj)
        {
            return $"\"{pObj}\"";
        }

        public static string ParseBool(object pObj)
        {
            if (pObj.ToString() == "0")
                return "false";
            return "true";
        }

        public static string ParseIntList(object pObj)
        {
            var strTemp = pObj.ToString().Replace("\n", "");
            if (strTemp.Trim().Length <= 0)
                return "null";

            var strData = "[\r\n";
            strData += "         ";
            var endWithSem = false;
            var laseDel = strTemp.LastIndexOf(";"); //用于判断是否是最后一个数值
            if (laseDel == strTemp.Length - 1)
                endWithSem = true;

            for(var i = 0; i < strTemp.Length; ++i)
            {
                if (strTemp[i] == ';')
                {
                    if (endWithSem && i == laseDel)
                    {

                    }
                    else
                    {
                        strData += ",\r\n";
                        strData += "          ";
                    }
                }
                else
                {
                    strData += strTemp[i];
                }
            }

            strData += "\r\n          ]";
            return strData;


        }

        public static string ParseFloatList(object pObj)
        {
            return ParseIntList(pObj);
        }

        public static string ParseStringList(object pObj)
        {
            var strData = "[\r\n";
            var strTemp = pObj.ToString().Replace("\n", "");
            if (strTemp.Trim().Length <= 0)
                return "null";
            //数据需要以‘;’为分隔符进行区分元素
            var strArray = strTemp.Split(';');
            for (var i = 0; i < strArray.Length; ++i)
                if (strArray[i].Trim().Length > 0)
                {
                    if (i != 0)
                        strData += ",\r\n";

                    strData += "            \"" + strArray[i] + "\"";
                }

            strData += "\r\n         ]";
            return strData;
        }



    }
}
