using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.Data.MCFCData
{
    public class ItemNodeInfo
    {
        /// <summary>
        /// 参数名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 参数描述信息
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 单位信息
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 可用值信息
        /// </summary>
        public string AvailableValue { get; set; }

        /// <summary>
        /// 参数设置范围信息
        /// </summary>
        public string Range { get; set; }

        /// <summary>
        /// 值精度
        /// </summary>
        public byte Precision { get; set; }

        /// <summary>
        /// 默认值信息
        /// </summary>
        public string DefaultValue { get; set; }

        public List<ItemNodeInfo> ChildrenItems { get; set; }

        public ItemNodeInfo()
        {
            ChildrenItems = new List<ItemNodeInfo>();
        }
    }
}
