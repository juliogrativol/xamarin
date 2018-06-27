using CentralNoticias.Model;
using System.Net;

namespace CentralNoticias.Service
{
    class CentralNoticiasService
    {
        public ListaNoticias listNews()
        {
            WebRequest webRequest = WebRequest.Create("https://3zg1cigkpk.execute-api.us-east-1.amazonaws.com/v1/noticias");
            var response = webRequest.GetResponseAsync();
            WebHeaderCollection header = response.Result.Headers;

            string serializedNoticia;
            using (var reader = new System.IO.StreamReader(response.Result.GetResponseStream()))
            {
                serializedNoticia = reader.ReadToEnd();
            }

            ListaNoticias noticias = Newtonsoft.Json.JsonConvert.DeserializeObject<ListaNoticias>(serializedNoticia);

            var count = noticias.noticias.Count;

            return noticias;
        }
    }
}
