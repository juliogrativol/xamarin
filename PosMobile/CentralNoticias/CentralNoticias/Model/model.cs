using System.Collections.Generic;

namespace CentralNoticias.Model
{
    class ListaNoticias
    {
        public List<Noticia> noticias { get; set; }
    }

    class Noticia
    {
        public string noticia { get; set; }
        public string autor { get; set; }
        public string titulo { get; set; }
        public string id { get; set; }
        public string informativo { get; set; }
        public string data { get; set; }
    }
}
