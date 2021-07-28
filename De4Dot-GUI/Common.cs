using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace De4DotGUI
{
    public static class Common
    {
        /// <summary>
        /// 跨线程访问控件 在控件上执行委托
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="callback"></param>
        public static void CrossThreadCall(this Control ctrl, Action callback)
        {
            if (!ctrl.IsHandleCreated || ctrl.IsDisposed || ctrl.Disposing || callback == null) return;
            if (ctrl.InvokeRequired)
                ctrl.Invoke(callback);
            else
                callback();
        }
        /// <summary>
        /// 将版本号转换为发布时间，前提是内部版本号和修订号自动生成
        /// </summary>
        /// <param name="version">版本号</param>
        /// <returns></returns>
        public static DateTime? ToDateTime(this Version version)
        {
            if (version.Build > 100 && version.Revision > 1000)
            {
                var day = new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.Revision * 2);
                return day;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 转换为日期类型的字符串
        /// </summary>
        /// <param name="s">时间</param>
        /// <param name="format">格式</param>
        /// <returns></returns>
        public static string ToDateString(this DateTime s, string format = "yyyy-MM-dd")
        {
            return s.ToString(format);
        }
        /// <summary>
        /// 转换为日期类型的字符串
        /// </summary>
        /// <param name="s">时间</param>
        /// <param name="format">格式</param>
        /// <returns></returns>
        public static string ToDateString(this DateTime? s, string format = "yyyy-MM-dd")
        {
            return s != null ? Convert.ToDateTime(s).ToString(format) : null;
        }

        public static void AddFileContextMenuItem(string itemName, string ext, string associatedProgramFullPath)
        {
            //创建项：shell 
            RegistryKey shellKey = Registry.ClassesRoot.OpenSubKey(ext + @"\shell", true);
            if (shellKey == null)
            {
                shellKey = Registry.ClassesRoot.CreateSubKey(ext + @"\shell");
            }

            //创建项：右键显示的菜单名称
            RegistryKey rightCommondKey = shellKey.CreateSubKey(itemName);
            RegistryKey associatedProgramKey = rightCommondKey.CreateSubKey("command");

            //创建默认值：关联的程序
            associatedProgramKey.SetValue(string.Empty, associatedProgramFullPath);

            //刷新到磁盘并释放资源
            associatedProgramKey.Close();
            rightCommondKey.Close();
            shellKey.Close();
        }

        public static void AddDirectoryContextMenuItem(string itemName, string associatedProgramFullPath)
        {
            //创建项：shell 
            RegistryKey shellKey = Registry.ClassesRoot.OpenSubKey(@"directory\shell", true);
            if (shellKey == null)
            {
                shellKey = Registry.ClassesRoot.CreateSubKey(@"directory\shell");
            }

            //创建项：右键显示的菜单名称
            RegistryKey rightCommondKey = shellKey.CreateSubKey(itemName);
            RegistryKey associatedProgramKey = rightCommondKey.CreateSubKey("command");

            //创建默认值：关联的程序
            associatedProgramKey.SetValue("", associatedProgramFullPath);


            //刷新到磁盘并释放资源
            associatedProgramKey.Close();
            rightCommondKey.Close();
            shellKey.Close();
        }

        /// <summary>  
        ///     检查注册表是否存在键  
        /// </summary>  
        /// <param name="key"></param>  
        /// <returns></returns>  
        public static bool IsRegisted(string key)
        {
            try
            {
                RegistryKey hkml = Registry.ClassesRoot;
                RegistryKey subKeys = hkml.OpenSubKey(key, true);
                if (subKeys != null)
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
        /// <summary>  
        ///     删除注册表键  
        /// </summary>  
        /// <param name="key"></param>  
        public static void DeleteKey(string key)
        {
            RegistryKey hkml = Registry.ClassesRoot;
            hkml.DeleteSubKeyTree(key, true);
            hkml.Close();
        }
        /// <summary>
        /// Gets the value by registry key. If the key does not exist, return empty string.
        /// </summary>
        /// <param name="key">registry key</param>
        /// <returns>Returns the value of the specified key.</returns>
        public static string GetValue(string softwareKey, string key)
        {
            const string parameter = "key";
            if (null == key)
            {
                throw new ArgumentNullException(parameter);
            }

            string strRet = string.Empty;
            try
            {
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey(softwareKey);
                strRet = regKey.GetValue(key).ToString();
            }
            catch
            {
                strRet = "";
            }
            return strRet;
        }
        /// <summary>
        /// Saves the key and the value to registry.
        /// </summary>
        /// <param name="key">registry key</param>
        /// <param name="value">the value of the key</param>
        /// <returns>Returns true if successful, otherwise return false.</returns>
        public static bool SaveValue(string softwareKey, string key, string value)
        {
            const string parameter1 = "key";
            const string parameter2 = "value";
            if (null == key)
            {
                throw new ArgumentNullException(parameter1);
            }

            if (null == value)
            {
                throw new ArgumentNullException(parameter2);
            }

            bool bReturn = false;
            RegistryKey reg;
            reg = Registry.CurrentUser.OpenSubKey(softwareKey, true);

            if (null == reg)
            {
                reg = Registry.CurrentUser.CreateSubKey(softwareKey);
            }
            reg.SetValue(key, value);

            return bReturn;
        }
    }
}
