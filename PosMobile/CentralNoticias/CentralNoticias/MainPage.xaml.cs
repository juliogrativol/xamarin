using CentralNoticias.Model;
using CentralNoticias.Service;
using Xamarin.Forms;

namespace CentralNoticias
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
            listNews();
        }

        public void listNews()
        {
            CentralNoticiasService service = new CentralNoticiasService();

            foreach (Noticia noticia in service.listNews().noticias)
            {
                Label label = new Label()
                {
                    Text = noticia.titulo
                };

                StackLayoutNoticias.Children.Add(label);
            }
        }

        public void addNews()
        {
            CentralNoticiasService service = new CentralNoticiasService();

            Noticia noticia = new Noticia();

            noticia.noticia = "Teste de notícia";
            noticia.titulo = "Teste de título";
            noticia.informativo = "Teste de informativo";
            noticia.data = "01/01/2018";
            noticia.autor = "Teste de autor";

            service.addNews(noticia);
        }

        public void removeNews()
        {
            CentralNoticiasService service = new CentralNoticiasService();

            Noticia noticia = new Noticia();

            noticia.noticia = "Teste de notícia";
            noticia.titulo = "Teste de título";
            noticia.informativo = "Teste de informativo";
            noticia.data = "01/01/2018";
            noticia.autor = "Teste de autor";

            service.addNews(noticia);
        }
    }
}
