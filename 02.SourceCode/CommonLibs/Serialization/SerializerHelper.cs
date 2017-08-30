using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CommonLibs
{
    public class SerializerHelper
    {
        /// <summary>
        /// 对象转换成JSON格式字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string ObjectToJSONString<T>(T t)
        {
            return JsonConvert.SerializeObject(t);
        }

        /// <summary>
        /// JSON字符串转换成指定对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public static T JSONStringToObject<T>(string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        /// <summary>
        /// 将object对象序列化成XML
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string ObjectToXMLNoNamespace<T>(T t)
        {
            return ClearSpecialChar(ObjectToXMLNoNamespace<T>(t, Encoding.UTF8));
        }

        /// <summary>
        /// 将object对象序列化成XML,带编码，无xml命名空间
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string ObjectToXMLNoNamespace<T>(T t, Encoding Coding)
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            XmlSerializer ser = new XmlSerializer(t.GetType());

            using (MemoryStream mem = new MemoryStream())
            {
                XmlTextWriter writer = new XmlTextWriter(mem, Coding);
                ser.Serialize(writer, t, ns);
                writer.Close();

                return ClearSpecialChar(Coding.GetString(mem.ToArray()));
            }
        }

        /// <summary>
        /// 清理序列化结果中的特殊符号
        /// </summary>
        /// <param name="xml">序列化结果</param>
        /// <returns></returns>
        static string ClearSpecialChar(string xml)
        {
            return Toolkit.ClearSpecialCharForXml(xml);
        }

        /// <summary>
        /// 将object对象序列化成XML
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string ObjectToXML<T>(T t)
        {
            return ClearSpecialChar(ObjectToXML<T>(t, Encoding.UTF8));
        }
        /// <summary>
        /// 将object对象序列化成XML,带编码
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string ObjectToXML<T>(T t, Encoding Coding)
        {
            XmlSerializer ser = new XmlSerializer(t.GetType());

            using (MemoryStream mem = new MemoryStream())
            {
                XmlTextWriter writer = new XmlTextWriter(mem, Coding);
                ser.Serialize(writer, t);
                writer.Close();

                return ClearSpecialChar(Coding.GetString(mem.ToArray()));
            }

        }

        /// <summary>
        /// 将XML反序列化成对象
        /// </summary>
        /// <returns></returns>
        public static T XMLToObject<T>(string source)
        {
            return XMLToObject<T>(source, Encoding.UTF8);
        }

        /// <summary>
        /// 将XML反序列化成对象,带编码
        /// </summary>
        /// <returns></returns>
        public static T XMLToObject<T>(string source, Encoding Coding)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(T));
            using (MemoryStream ms = new MemoryStream(Coding.GetBytes(source.Trim())))
            {
                using (XmlTextReader reader = new XmlTextReader(ms))
                {
                    return (T)mySerializer.Deserialize(reader);
                }
            }
        }
    }
}
