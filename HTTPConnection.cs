using System;
using System.IO;
using System.Net;

namespace CSharp
{
    class Files
    {
        static void Main(string[] args)
        {
            string url = "https://www.google.com";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET"; //POST....
            request.ContentType = "application/json"; // 다른 것도 많음.

            request.Headers.Add("Header name", "DATA");
            request.Headers.Add("KEY", "VALUE");


            StreamWriter reqStream = new StreamWriter(request.GetRequestStream());

            /* 
             * Make Json object
             * newton Json
             * 
             * JObject item = new JObject();
             * item.Add("Key", "value");
             * 
             */
            reqStream.Write(item);
            reqStream.Close();

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader respStream = new StreamReader(response.GetResponseStream());
                string resp = respStream.ReadToEnd();
                respStream.Close();

                /*
                 *  JObject ret = JObject.Parse(resp);
                 *  
                 *  Access to json object(ret)
                 */

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
                

        }
    }
}
