using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTools
{
    /// <summary>
    /// 定义表里面的字段信息
    /// </summary>
    public class TableField
    {
        public static string[] TypeScript_TypeNames =
        {
            "number","string","boolean","number[]","string[]"
        };

        public static string[] CSharp_TypeNames =
        {
            "int","float","string","bool","List<int>","List<float>","List<string>"
        };

        public static string[] Cpp_TypeNames =
        {
            "int","float","char","double","bool"
        };

        public static string[] ActionScript3_TypeNames =
        {
            "Number","Boolean","Array","String","int","Object"
        };

        public static string[] JavaScript_TypeNames =
        {
            "String","Number","Boolean","Object","Array"
        };


        public string mComment;             //描述
        public string mExportType;          //导出类型
        public string mFieldName;           //字段名字
        public string mTypeName;            //类类型

        /// <summary>
        /// 得到字段名称
        /// </summary>
        /// <param name="pType"></param>
        /// <returns></returns>
        public string GetFieldTypeName(ExportCodeType pType)
        {
            var _type = TableFileType.TABLE_int;

            if (mTypeName == "int")
                _type = TableFileType.TABLE_int;
            else if (mTypeName == "float")
                _type = TableFileType.TABLE_float;
            else if (mTypeName == "string")
                _type = TableFileType.TABLE_string;
            else if (mTypeName == "bool")
                _type = TableFileType.TABLE_bool;
            else if (mTypeName == "int[]")
                _type = TableFileType.TABLE_intList;
            else if (mTypeName == "float[]")
                _type = TableFileType.TABLE_floatList;
            else if (mTypeName == "string[]")
                _type = TableFileType.TABLE_stringList;

            if (pType == ExportCodeType.ActionScript)
                return ActionScript3_TypeNames[(int)_type];
            if (pType == ExportCodeType.TypeScript)
                return TypeScript_TypeNames[(int)_type];
            if (pType == ExportCodeType.CSharp)
                return CSharp_TypeNames[(int)_type];
            if (pType == ExportCodeType.TypeScript)
                return TypeScript_TypeNames[(int)_type];
            if (pType == ExportCodeType.JavaScript)
                return JavaScript_TypeNames[(int)_type];

            return null;
        }

        public bool IsExportField(ExportConfigType pExpType)
        {
            if (mExportType == "all")
                return true;

            if ((pExpType == ExportConfigType.Server && (mExportType == "client")))
                return true;

            if ((pExpType == ExportConfigType.Server && mExportType == "server"))
                return true;
            return false;
        }

    }

    public class MetaHelper
    {
        public List<TableField> tableFields = new List<TableField>();
        public string _tableName;

        public string ClassName
        {
            get
            {
                return "Table_" + _tableName + "_Bean";
            }
        }

        public string DataName
        {
            get
            {
                return "Table_"+_tableName + "_DefineData";
            }
        }

        //Dictionary形式还是List形式 
        public bool CheckTypeIsMap()
        {
            return tableFields[0].mFieldName.ToUpper() == "ID";
        }

    }
}
