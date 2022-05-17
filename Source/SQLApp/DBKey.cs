using System;
using System.Collections.Generic;
using System.Text;

namespace SQLApp
{
    /// <summary>
    /// 数据库联合主键
    /// </summary>
    public class DBKey
    {
        public string YG_NO
        {
            get;
            set;
        }
        public string PRD_NO
        {
            get;
            set;
        }
        public DateTime FJ_DD
        {
            get;
            set;
        }
        public string ZC_NO
        {
            get;
            set;
        }

    }
}
