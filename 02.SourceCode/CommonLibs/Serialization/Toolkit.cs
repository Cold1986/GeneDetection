using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CommonLibs
{
    public class Toolkit
    {
        /// <summary>
        /// 清理HTTP请求或响应字符串前后的多余引号
        /// </summary>
        /// <param name="xml">待处理的字符串</param>
        /// <returns></returns>
        /// <remarks> add by grs at 2012-10-17 </remarks>
        public static string ClearSpecialCharForReq(string sourceString)
        {
            if (string.IsNullOrEmpty(sourceString))
            {
                return string.Empty;
            }

            return sourceString.Trim(new char[] { '"' });
        }
        /// <summary>
        /// 清理XML字符串左尖括号前面的多余字符
        /// </summary>
        /// <param name="xml">待处理的XML字符串</param>
        /// <returns></returns>
        /// <remarks> add by grs at 2012-10-16 </remarks>
        public static string ClearSpecialCharForXml(string xml)
        {
            if (string.IsNullOrEmpty(xml))
            {
                return string.Empty;
            }

            return System.Text.RegularExpressions.Regex.Replace(xml, "^[^<]*", "");
        }
        /// <summary>
        /// 获得Url或表单参数的值, 先判断Url参数是否为空字符串, 如为True则返回表单参数的值
        /// </summary>
        /// <param name="strName">参数</param>
        /// <returns>Url或表单参数的值</returns>
        public static string GetString(string strName)
        {
            if ("".Equals(GetQueryString(strName)))
            {
                return GetFormString(strName);
            }
            else
            {
                return GetQueryString(strName);
            }
        }
        /// <summary>
        /// 获得指定Url参数的值
        /// </summary>
        /// <param name="strName">Url参数</param>
        /// <returns>Url参数的值</returns>
        public static string GetQueryString(string strName)
        {
            if (HttpContext.Current.Request.QueryString[strName] == null)
            {
                return "";
            }
            return HttpContext.Current.Request.QueryString[strName].Trim();
        }
        /// <summary>
        /// 获得指定表单参数的值
        /// </summary>
        /// <param name="strName">表单参数</param>
        /// <returns>表单参数的值</returns>
        public static string GetFormString(string strName)
        {
            if (HttpContext.Current.Request.Form[strName] == null)
            {
                return "";
            }
            return HttpContext.Current.Request.Form[strName].Trim();
        }
    }
}
