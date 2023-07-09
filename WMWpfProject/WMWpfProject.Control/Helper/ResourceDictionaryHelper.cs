using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WMWpfProject.Control.Helper
{
    /// <summary>
    /// 资源查找类，用于查找资源
    /// </summary>
    public partial class ResourceDictionaryHelper : ResourceDictionary, IDisposable
    {

        //static readonly Lazy<ControlStylesResourceDictionary> Lazy_Singleton = new Lazy<ControlStylesResourceDictionary>();

        //static ControlStylesResourceDictionary Singleton => Lazy_Singleton.Value;
        //static ControlStylesResourceDictionary Singleton = new ControlStylesResourceDictionary();

        public static Style GetStyle(string key)
        {
            using (ResourceDictionaryHelper singleton = new ResourceDictionaryHelper())
            {
                var style = singleton.FindResouce(key) as Style;
                return style;
            }
        }

        public static object GetResouce(string key)
        {
            using (ResourceDictionaryHelper singleton = new ResourceDictionaryHelper())
            {
                return singleton.FindResouce(key);
            }
        }

        public void Dispose()
        {

        }

        internal ResourceDictionaryHelper()
        {


        }
    }

    public static class ResourceDictionaryEx
    {
        public static object FindResouce(this ResourceDictionary dict, string key)
        {
            object res = null;

            try
            {
                if (dict.Contains(key))
                {
                    res = dict[key];
                }
            }
            catch
            {

            }
            if (res != null)
            {
                return res;
            }
            else
            {
                foreach (var item in dict.MergedDictionaries)
                {
                    res = item.FindResouce(key);
                    if (res != null)
                    {
                        return res;
                    }
                }
            }
            return res;
        }
    }
}
