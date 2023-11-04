using HTProject.Common.Data.Vector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.Data.ProductData
{
    /// <summary>
    /// 物料信息
    /// </summary>
    public class MaterialInfo
    {
        /// <summary>
        /// 物料Id号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 物料尺寸XYZ
        /// </summary>
        public XYZ Size { get; set; }

        /// <summary>
        /// 物料类型
        /// </summary>
        public string MaterialType { get; set; }

        /// <summary>
        /// 物料材质
        /// </summary>
        public string MaterialTexture { get; set; }
    }
}
