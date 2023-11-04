using HTProject.Common.Data.Vector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.Data.ProductData
{
    /// <summary>
    /// 料盘信息
    /// </summary>
    public class TrayInfo
    {
        /// <summary>
        /// 料盘尺寸XY
        /// </summary>
        public XY Size { get; set; }

        /// <summary>
        /// 料盘中物料行数
        /// </summary>
        public int RowNum { get; set; }

        /// <summary>
        /// 料盘中物料列数
        /// </summary>
        public int ColumnNum { get; set; }

        /// <summary>
        /// 料盘中物料总数
        /// </summary>
        public int TotalNum { get; set; }
    }
}
