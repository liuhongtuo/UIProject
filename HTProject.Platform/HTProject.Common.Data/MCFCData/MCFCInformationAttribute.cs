using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.Data.MCFCData
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class MCFCInformationAttribute : Attribute
    {
        /// <summary>
        /// 单位信息
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 参数描述信息
        /// </summary>
        public string Description { get; set; }

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
        /// 内部参数信息(当对象是一个类时使用，目前版本不适用该功能)
        /// </summary>
        [Obsolete]
        public string Parameter { get; set; }

        /// <summary>
        /// 默认值信息
        /// </summary>
        public string DefaultValue { get; set; }

    }
}
