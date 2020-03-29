using System;
using System.Collections.Generic;
using System.IO;

namespace TableTools
{
    /// <summary>
    /// 自定义Excel表信息，包括表名称 表路径
    /// </summary>
    public class ExcelFilenfo
    {
        //Excel表称
        public string Name { get; set; }
        //Excel表路径
        public string Path { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    public static class FileHelper
    {
        /// <summary>
        /// 得到Excel表
        /// </summary>
        /// <param name="pPath">路径</param>
        /// <param name="pList">所有Excel表</param>
        /// <param name="pSuffix">默认表的后缀名</param>
        public static void GetExcelFiles(string pPath, List<ExcelFilenfo> pList, string pSuffix = "*.xlsx")
        {
            //确定给定路径是否是引用磁盘上现有的目录
            if (!Directory.Exists(pPath))
                return;

            pList.Clear();
            //返回指定目录中指定类型的文件 TopDirectoryOnly表示仅搜索当前目录
            var files = Directory.GetFiles(pPath, pSuffix, SearchOption.TopDirectoryOnly);
            foreach (var file in files)
            {
                //如果是隐藏文件，不做处理
                if (File.GetAttributes(file).HasFlag(FileAttributes.Hidden))
                    continue;
                //给Excel结构里面的值赋值
                var excelFile = new ExcelFilenfo { Name = Path.GetFileNameWithoutExtension(file), Path = file };
                pList.Add(excelFile);
            }
        }
    }
}
