using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace HTProject.Plugin.Control.Helper
{
    public static class VisualTreeFindHelper
    {
        /// <summary>
        /// 寻找视觉树父级，默认搜索层数10层
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public static T FindViewTreeParent<T>(this DependencyObject obj, int level = 10) where T : DependencyObject
        {
            DependencyObject target = VisualTreeHelper.GetParent(obj);
            if (target != null)
            {
                if (target is T)
                {
                    return (T)target;
                }
                else
                {
                    if (level - 1 >= 0)
                    {
                        return FindViewTreeParent<T>(target, level - 1);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 寻找视觉树的子UI元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public static T FindViewTreeChild<T>(this DependencyObject obj) where T : DependencyObject
        {
            try
            {
                var count = VisualTreeHelper.GetChildrenCount(obj);
                for (int i = 0; i < count; i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(obj, i) as DependencyObject;
                    if (child == null)
                    {
                        continue;
                    }

                    if (child is T)
                    {
                        return (T)child;
                    }

                    T grandChild = FindViewTreeChild<T>(child);
                    if (grandChild != null)
                    {
                        return grandChild;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 寻找视觉树的子UI元素集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static IList<T> FindViewTreeItems<T>(this DependencyObject obj) where T : DependencyObject
        {
            try
            {
                var children = new List<T>();
                var count = VisualTreeHelper.GetChildrenCount(obj);
                for (int i = 0; i < count; i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(obj, i) as DependencyObject;
                    if (child == null)
                    {
                        continue;
                    }

                    if (child is T)
                    {
                        children.Add((T)child);
                    }
                }

                return children;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 寻找视觉树的子UI元素集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public static IEnumerable<T> FindViewTreeChildren<T>(this DependencyObject obj, bool isFindGrandChildren = true) where T : DependencyObject
        {
            var count = VisualTreeHelper.GetChildrenCount(obj);
            for (int i = 0; i < count; i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i) as DependencyObject;
                if (child == null)
                {
                    continue;
                }

                if (child is T)
                {
                    T element = (T)child;
                    if (isFindGrandChildren)
                    {
                        var childs = FindViewTreeChildren<T>(child);
                        if (childs != null)
                        {
                            foreach (T item in childs)
                            {
                                yield return item;
                            }
                        }
                    }
                    yield return (T)child;
                }
                else
                {
                    var childs = FindViewTreeChildren<T>(child);
                    if (childs != null)
                    {
                        foreach (T item in childs)
                        {
                            yield return item;
                        }
                    }
                }
            }
        }
    }
}
