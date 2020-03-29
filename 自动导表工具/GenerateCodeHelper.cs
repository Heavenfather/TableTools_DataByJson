using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTools
{
    /// <summary>
    /// 自动生成代码帮助类
    /// </summary>
    class GenerateCodeHelper
    {
        public static void GenerateCode(MetaHelper pTableMeta, string pPath, ExportCodeType pType, ExportConfigType pCfgType)
        {
            //暂时写到生成C#
            if (pType == ExportCodeType.CSharp)
                GenerateCSharpCode(pTableMeta, pPath, pCfgType);
        }

        public static void GenerateCSharpTableManager(string pPath, List<string> tablesName)
        {
            var _Path = Path.Combine(pPath, "TableManager.cs");
            using (var fs = new FileStream(_Path, FileMode.Create, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine("using System.Collections.Generic;");
                    sw.WriteLine("using UnityEngine;");
                    sw.WriteLine("using System;");
                    sw.WriteLine("");

                    sw.WriteLine("namespace TableConfigs");
                    sw.WriteLine("{");
                    sw.WriteLine("    public class TableManager");
                    sw.WriteLine("    {");
                    sw.WriteLine("");
                    sw.WriteLine("       public static Dictionary<string,object> _dicTableDatas = new Dictionary<string, object>();");
                    sw.WriteLine("       public static Dictionary<string, List<int>> _allIds = new Dictionary<string, List<int>>();");
                    sw.WriteLine("       public static Dictionary<string, Dictionary<int, object>> _dicData = new Dictionary<string, Dictionary<int, object>>();");
                    sw.WriteLine("");
                    for (int i = 0; i < tablesName.Count; i++)
                    {
                        sw.WriteLine("       private Table_{0}_BeanJsonDatas table_{1}_Bean;", tablesName[i], tablesName[i]);
                    }
                    sw.WriteLine("       private static TableManager _instance;");
                    sw.WriteLine("       public static TableManager GetInstance()");
                    sw.WriteLine("       {");
                    sw.WriteLine("          if (_instance == null)");
                    sw.WriteLine("          {");
                    sw.WriteLine("             _instance = new TableManager();");
                    sw.WriteLine("          }");
                    sw.WriteLine("          return _instance;");
                    sw.WriteLine("       }");
                    sw.WriteLine("       private TableManager(){}");
                    sw.WriteLine("");
                    sw.WriteLine("       public void InitTableData()");
                    sw.WriteLine("       {");
                    for (int i = 0; i < tablesName.Count; i++)
                    {
                        sw.WriteLine("         table_{0}_Bean = new Table_{1}_BeanJsonDatas(GetTablePathByName(\"{2}\"));", tablesName[i], tablesName[i], tablesName[i]);
                    }
                    sw.WriteLine("       }");
                    sw.WriteLine("");
                    sw.WriteLine("       public string GetTablePathByName(string name)");
                    sw.WriteLine("       {");
                    sw.WriteLine("          string path = Application.streamingAssetsPath+\"/Table_\"+name+\"_Bean.json\";");
                    sw.WriteLine("          return path;");
                    sw.WriteLine("       }");
                    sw.WriteLine("");
                    sw.WriteLine("       /// <summary>");
                    sw.WriteLine("       /// 根据表名返回全部的ID");
                    sw.WriteLine("       /// </summary>");
                    sw.WriteLine("       ///<param name=\"tableName\">表名</param>");
                    sw.WriteLine("       public List<int> GetAllIds(string tableName)");
                    sw.WriteLine("       {");
                    sw.WriteLine("          string realName = \"Table_\"+tableName+\"_Bean\";");
                    sw.WriteLine("          List<int> ids;");
                    sw.WriteLine("          _allIds.TryGetValue(realName, out ids);");
                    sw.WriteLine("          return ids;");
                    sw.WriteLine("       }");
                    sw.WriteLine("");
                    sw.WriteLine("       /// <summary>");
                    sw.WriteLine("       /// 指定表名和id返回数据结果");
                    sw.WriteLine("       /// </summary>");
                    sw.WriteLine("       ///<param name=\"tableName\">表名</param>");
                    sw.WriteLine("       ///<param name=\"id\">需查询的ID</param>");
                    sw.WriteLine("       public object GetDataById(string tableName,int id)");
                    sw.WriteLine("       {");
                    sw.WriteLine("          string realName = \"Table_\"+tableName+\"_Bean\";");
                    sw.WriteLine("          Dictionary<int, object> tableData;");
                    sw.WriteLine("          _dicData.TryGetValue(realName, out tableData);");
                    sw.WriteLine("          object data;");
                    sw.WriteLine("          tableData.TryGetValue(id, out data);");
                    sw.WriteLine("          if (data != null)");
                    sw.WriteLine("          {");
                    sw.WriteLine("             return data;");
                    sw.WriteLine("          }");
                    sw.WriteLine("          Debug.LogError(tableName+\"表里没有 id=\"+id);");
                    sw.WriteLine("          return null;");
                    sw.WriteLine("       }");
                    sw.WriteLine("    }");
                    sw.WriteLine("}");
                }
            }
        }

        //生成C#代码
        private static void GenerateCSharpCode(MetaHelper pTableMeta, string pPath, ExportConfigType pCfgType)
        {
            var _Path = Path.Combine(pPath, pTableMeta.ClassName + ".cs");
            using (var fs = new FileStream(_Path, FileMode.Create, FileAccess.Write))           //Create模式：指定操作系统应创建一个新的文件。 如果该文件已存在，则会覆盖它。   Write形式： 对文件的写入访问权限。 数据可以写入该文件
            {
                using (var sw = new StreamWriter(fs, Encoding.UTF8))            //为通过使用指定的编码及默认的缓冲区大小指定的流的类。
                {
                    sw.WriteLine("/*");
                    sw.WriteLine("* 此类由导表工具自动生成 Build By Tanhaiwen");
                    sw.WriteLine("* copy right 2019");
                    sw.WriteLine("*/");
                    //引入命名空间，项目中需要先添加Newtonsoft.Json的引用或向Unity的项目中导入Newtonsoft.Json.dll文件
                    sw.WriteLine("using System.Collections.Generic;");
                    sw.WriteLine("");
                    sw.WriteLine("using Newtonsoft.Json;");
                    sw.WriteLine("");
                    sw.WriteLine("using System.IO;");
                    sw.WriteLine("");
                    sw.WriteLine("namespace TableConfigs");
                    sw.WriteLine("{");

                    //生成外部拿的数据
                    sw.WriteLine("    public class {0}", pTableMeta.ClassName + "JsonDatas");
                    sw.WriteLine("    {");
                    sw.WriteLine("         public {0}", pTableMeta.ClassName + "JsonDatas(string jsonPath)");
                    sw.WriteLine("         {");
                    sw.WriteLine("            var json = File.ReadAllText(jsonPath);");
                    sw.WriteLine("            var datas = JsonConvert.DeserializeObject<{0}>(json);", pTableMeta.ClassName);
                    sw.WriteLine("            TableManager._dicTableDatas.Add(\"{0}\", datas);", pTableMeta.ClassName);
                    sw.WriteLine("            List<int> ids = new List<int>();");
                    sw.WriteLine("            Dictionary<int, object> data = new Dictionary<int, object>();");
                    sw.WriteLine("            foreach (var item in datas.mDataMap)");
                    sw.WriteLine("            {");
                    sw.WriteLine("               ids.Add(item.Value.ID);");
                    sw.WriteLine("               data.Add(item.Value.ID, item.Value);");
                    sw.WriteLine("            }");
                    sw.WriteLine("            TableManager._allIds.Add(\"{0}\",ids);", pTableMeta.ClassName);
                    sw.WriteLine("            TableManager._dicData.Add(\"{0}\",data);", pTableMeta.ClassName);
                    sw.WriteLine("         }");
                    sw.WriteLine("    }");

                    sw.WriteLine("    public class {0}", pTableMeta.ClassName);
                    sw.WriteLine("    {");
                    if (pTableMeta.CheckTypeIsMap())
                        sw.WriteLine("        public Dictionary<string, {0}> mDataMap;", pTableMeta.DataName);
                    else
                        sw.WriteLine("        public List<{0}> mDataList;", pTableMeta.DataName);

                    sw.WriteLine("    }");
                    sw.WriteLine();
                    sw.WriteLine("    public class {0}", pTableMeta.DataName);
                    sw.WriteLine("    {");
                    foreach (var field in pTableMeta.tableFields)
                    {
                        if (!field.IsExportField(pCfgType))
                            continue;

                        sw.WriteLine("        " + field.mComment);
                        sw.WriteLine("        public {0} {1};", field.GetFieldTypeName(ExportCodeType.CSharp), field.mFieldName);
                    }
                    sw.WriteLine("    }");
                    sw.WriteLine("}");
                }
            }
        }

        //生成AS3代码
        private static void GenerateActionScript3Code(MetaHelper pTableMeta, string pPath, ExportConfigType pCfgType)
        {

        }
    }
}
