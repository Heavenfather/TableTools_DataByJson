using System;
using System.Data;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace TableTools
{
    public class ExcelHelper
    {
        //以下的赋值需要一一对应Excel表里面的前四行
        public static int sCommentRow = 0; //字段注释 0
        public static int sFieldRow = 1; //字段名字 1
        public static int sTypeRow = 2; //字段类型 2
        public static int sExportRow = 3; //导出类型 3

        public static DataTable ImportExcelFile(string filePath)
        {
           IWorkbook hssfworkbook;     //加载工作簿Excel表
            try
            {
                using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {      
                    //实例化一个指定路径的Excel工作簿
                    hssfworkbook = new XSSFWorkbook(file);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            var sheet = hssfworkbook.GetSheetAt(0);     //取Excel表下面第一个Sheet表
            var rows = sheet.GetRowEnumerator();        //得到行数

            //实例化DataTable的类
            var dt = new DataTable();
            //拿第一行的数据进行处理
            var row0 = sheet.GetRow(0);
            for (int j = row0.FirstCellNum; j < row0.LastCellNum; j++)      //遍历所有的列
                dt.Columns.Add(row0.GetCell(j).ToString());         //向Data数据中添加列的数据

            while (rows.MoveNext())     //移到下一行,返回一个bool值，如果该行为空，则退出循环
            {
                IRow row = (XSSFRow)rows.Current;      //当前位置的元素
                var dr = dt.NewRow();

                for (var i = 0; i < row.LastCellNum; i++)
                {
                    var cell = row.GetCell(i);
                    //判断空值
                    if (cell == null)
                        dr[i] = null;
                    else
                        dr[i] = cell.ToString();
                }
                dt.Rows.Add(dr);        //向Data数据中添加行的数据
            }

            return dt;
        }

        public static MetaHelper  ParseTableMeta(string pFileName, DataTable pDT, ExportConfigType pExpType)
        {
            var meta = new MetaHelper { _tableName = pFileName };
            //字段注释 0
            //字段名字 1
            //字段类型 2
            //导出类型 3
            for (var i = 0; i < pDT.Columns.Count; i++)
            {
                //对每一列中前四行数据的处理
                var field = new TableField
                {
                    mComment = @"//" + pDT.Rows[sCommentRow].ItemArray[i],          //表中第一行的描述
                    mFieldName = pDT.Rows[sFieldRow].ItemArray[i].ToString(),       //表中第二行的描述
                    mTypeName = pDT.Rows[sTypeRow].ItemArray[i].ToString(),         //表中第三行的描述
                    mExportType = pDT.Rows[sExportRow].ItemArray[i].ToString()      //表中第四行的描述
                };

                meta.tableFields.Add(field);
            }
            return meta;
        }
    }
}