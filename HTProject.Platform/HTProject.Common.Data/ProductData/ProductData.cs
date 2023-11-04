using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.Data.ProductData
{
    /// <summary>
    /// 产品信息
    /// </summary>
    public class ProductData
    {
        /// <summary>
        /// 物料信息集合
        /// </summary>
        public List<MaterialInfo> MaterialDatas { get; set; }

        /// <summary>
        /// 料盘信息
        /// </summary>
        public TrayInfo TrayData { get; set; }

        /// <summary>
        /// 载具信息
        /// </summary>
        public CarrierInfo CarrierData { get; set; }
    }
}