using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.File.UtilHelper
{
    /// <summary>
    /// 枚举转换类
    /// </summary>
    public class EnumUtil
    {
        /// <summary>
        /// 根据枚举值获取Description
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="description"></param>
        /// <returns></returns>
        public static string GetDescriptionByEnum(Enum enumValue)
        {
            string value = enumValue.ToString();
            FieldInfo field = enumValue.GetType().GetField(value);
            //获取描述属性
            object[] objs = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            //当描述属性没有时，直接返回名称
            if (objs.Length == 0)
                return value;
            DescriptionAttribute descriptionAttribute = (DescriptionAttribute)objs[0];
            return descriptionAttribute.Description;
        }

        /// <summary>
        /// 根据Description获取枚举值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="description"></param>
        /// <returns></returns>
        public static T GetEnumNameByDescription<T>(string description)
        {
            Type _type = typeof(T);
            FieldInfo[] fields = _type.GetFields();
            foreach (var field in fields)
            {
                //获取描述属性
                object[] objs = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (objs.Length > 0 && (objs[0] as DescriptionAttribute).Description == description)
                {
                    return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException(string.Format("{0}未能找到对应的枚举，", description), "Description");
        }
    }
}
