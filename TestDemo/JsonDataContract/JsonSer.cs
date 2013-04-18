using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace JsonDataContract
{
    public class JsonSer<T>
    {
        /// <summary>
        /// 对象序列化json数据格式
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string SerJson(object s)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                ser.WriteObject(memoryStream, s);
                memoryStream.Position = 0;
                StreamReader sr = new StreamReader(memoryStream);
                String ss = sr.ReadToEnd();
                return ss;
            }
            catch (Exception e)
            {
                throw new Exception("对象序列化失败"+e.ToString());
            }
            return "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public object DeSerJson(string str)
        {
            try
            {
                //之前使用 System.Text.Encoding.ASCII对于中文的操作显示乱码 修改
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(str);
                MemoryStream memoryStream = new MemoryStream(bytes);
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                object p2 = (object)ser.ReadObject(memoryStream);
                return p2;
            }
            catch (Exception e)
            {
                throw new Exception("对象反序列化失败"+e.ToString());
            }
            return null;
        }

    }
}
