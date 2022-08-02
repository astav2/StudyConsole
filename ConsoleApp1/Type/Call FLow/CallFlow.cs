//using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.Call_FLow
{
  public  class CallFlow
    {
        public void CreateWOTasksWithFlow()
        {
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("https://prod-23.australiasoutheast.logic.azure.com:443/workflows/71b0b2090c5e44febc2af69373064162/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=HV1aDBiXHxiV2BNC8HTdQdyDyCMu9p98J-VO1amoZnk");
                webRequest.Method = "POST";
                webRequest.ContentType = "application / json";
                var data = new WOTaskRequestBody() { WorkOrderId = "d4ebc93e-a27a-ec11-8d21-00224812d01c" };
                var dataContent = Encoding.UTF8.GetBytes(Serializer.SerializeToJson(data));
                using (var stream = webRequest.GetRequestStream())
                {
                    stream.Write(dataContent, 0, dataContent.Length);
                }
                Stream response = ((HttpWebResponse)webRequest.GetResponse()).GetResponseStream();
                using (var sr = new StreamReader(response))
                {
                    // this will be a JSON array containing the list of newly created contact GUID’s
                    var result = sr.ReadToEnd();
                    var dresult = Serializer.DeserializeFromJson<WOTaskResponseBody>(result);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

    }
    [DataContract]
    public class WOTaskRequestBody
    {
        [DataMember]
        public string WorkOrderId { get; set; }
    }
    public class WOTaskResponseBody
    {
        public bool isSuccess { get; set; }
    }
    public static class Serializer
    {
        /// <summary>
        /// Serialize an object to JSON
        /// </summary>
        /// <typeparam name="T">Object type to serialize</typeparam>
        /// <param name="thingy">Object to get</param>
        /// <returns>serialized string</returns>
        public static string SerializeToJson<T>(T thingy)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                serializer.WriteObject(memoryStream, thingy);
                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }



        /// <summary>
        /// Deserialize an object from JSON
        /// </summary>
        /// <typeparam name="T">Object type to deserialize to</typeparam>
        /// <param name="json">String to deserialize</param>
        /// <returns>Stream to return</returns>
        public static T DeserializeFromJson<T>(string json)
        {
            try
            {
                if (string.IsNullOrEmpty(json))
                {
                    return default(T);
                }
                using (Stream memoryStream = StreamFromString(json))
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                    T result = (T)serializer.ReadObject(memoryStream);
                    return result;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error while Deserialisation." + ex.Message + "||" + ex.InnerException.Message);
            }
        }



        /// <summary>
        /// Get stream from a string, helper function to Serializer class
        /// </summary>
        /// <param name="s">string to get stream from</param>
        /// <returns>Stream to return</returns>
        private static Stream StreamFromString(string s)
        {
            Stream stream = null;
            Stream tempStream = null;
            try
            {
                stream = new MemoryStream();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(s);
                writer.Flush();
                stream.Position = 0;
                tempStream = stream;
                stream = null;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }



            return tempStream;
        }
    }
}
