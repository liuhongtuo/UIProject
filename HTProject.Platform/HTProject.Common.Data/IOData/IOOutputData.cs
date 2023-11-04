using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.Data.IOData
{
    /// <summary>
    /// IO输出信息
    /// </summary>
    public class IOOutputData
    {
        /// <summary>
        /// IO模块编码名称(IO1-01)
        /// </summary>
        public string IONumberName { get; set; }

        /// <summary>
        /// IO点含义描述
        /// </summary>
        public string IODescribe { get; set; }

        /// <summary>
        /// IO点的ID号
        /// </summary>
        public int IDNumber { get; set; }

        /// <summary>
        /// IO点的状态,True表示On，False表示Off
        /// </summary>
        public bool IOState { get; set; }

        /// <summary>
        /// 关联的IO输入数据
        /// </summary>
        public List<IOInputData> RelativeIOInputDatas { get; set; }
    }
}
