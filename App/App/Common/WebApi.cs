using System;
using System.IO;
using System.Net;

namespace App.Common
{
    public static class WebApi
    {
        public static string ExecutarResquisicaoGET(string url)
        {
            string parameters = string.Format("?User={0}&Token={1}", Program.ConfigBE.ApiUser, Program.ConfigBE.ApiToken);
            string fullUrl = Program.ConfigBE.ApiUrl + url + parameters;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(fullUrl);
            req.Method = "GET";
            req.ContentType = "application/json; charset=utf-8";

            // lê a resposta
            WebResponse webResponse = req.GetResponse();
            StreamReader rd = new StreamReader(webResponse.GetResponseStream());
            var htmlResult = rd.ReadToEnd();

            return htmlResult;
        }

        public static string ExecutarResquisicaoPOST(string url, string jsonObject)
        {
            url = Program.ConfigBE.ApiUrl + url;

            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "POST";
                req.ContentType = "application/json; charset=utf-8";

                // Dados autenticação
                req.Headers.Add("Token", Program.ConfigBE.ApiToken);
                req.Headers.Add("User", Program.ConfigBE.ApiUser);

                // Adicionao json
                using (var streamWriter = new StreamWriter(req.GetRequestStream()))
                {
                    string json = jsonObject;
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                // lê a resposta           
                WebResponse webResponse = req.GetResponse();
                StreamReader rd = new StreamReader(webResponse.GetResponseStream());
                var htmlResult = rd.ReadToEnd();

                return htmlResult;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The remote server returned an error: (417) Expectation Failed."))
                    return "SUCESSO";
                else
                    throw ex;
            }
        }
    }
}
