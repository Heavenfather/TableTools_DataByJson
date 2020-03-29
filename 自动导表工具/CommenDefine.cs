using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTools
{
    
        //字段类型
        public enum TableFileType
        {
            TABLE_int = 0,
            TABLE_float = 1,
            TABLE_string=2,
            TABLE_bool=3,
            TABLE_intList=4,
            TABLE_floatList=5,
            TABLE_stringList=6
        }

        //导出配置类型
        public enum ExportConfigType
        {
            Client,
            Server
        }

        //导出代码类型
        public enum ExportCodeType
        {
            CSharp,
            TypeScript,
            JavaScript,
            ActionScript,
            Cpp
        }

    
}
