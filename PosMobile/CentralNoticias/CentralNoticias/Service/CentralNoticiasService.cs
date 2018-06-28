using CentralNoticias.Model;
using System;
using System.IO;
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

        public String addNews(Noticia noticia)
        {
            // Create a request using a URL that can receive a post.   
            WebRequest request = WebRequest.Create("https://3zg1cigkpk.execute-api.us-east-1.amazonaws.com/v1/noticias");
            // Set the Method property of the request to POST.  
            request.Method = "POST";
            // Create POST data and convert it to a byte array.

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(noticia);

            Console.WriteLine(json);

            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(json);

            // Set the ContentType property of the WebRequest.  
            request.ContentType = "application/json";
            // Set the ContentLength property of the WebRequest.  
            request.ContentLength = byteArray.Length;
            // Get the request stream.  
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.  
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.  
            dataStream.Close();
            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.  
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content.  
            Console.WriteLine(responseFromServer);
            // Clean up the streams.  
            reader.Close();
            dataStream.Close();
            response.Close();

            return "Notícia criada com sucesso!";
        }

        public String removeNews(Noticia noticia)
        {
            // Create a request using a URL that can receive a post.   
            WebRequest request = WebRequest.Create("https://3zg1cigkpk.execute-api.us-east-1.amazonaws.com/v1/noticias");
            // Set the Method property of the request to POST.  
            request.Method = "DELETE";
            // Create POST data and convert it to a byte array.

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(noticia);

            Console.WriteLine(json);

            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(json);

            // Set the ContentType property of the WebRequest.  
            request.ContentType = "application/json";
            // Set the ContentLength property of the WebRequest.  
            request.ContentLength = byteArray.Length;
            // Get the request stream.  
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.  
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.  
            dataStream.Close();
            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.  
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();

            // Display the content.  
            Console.WriteLine(responseFromServer);
            // Clean up the streams.  
            reader.Close();
            dataStream.Close();
            response.Close();

            return "Notícia removida com sucesso!";
        }
    }
}
