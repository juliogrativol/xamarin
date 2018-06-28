using CentralNoticias.Model;
using CentralNoticias.Service;
using System;
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

            StackLayout stackLayout;

            Label textoPrincipal = new Label()
            {
                Text = "Central de Notícias",
                Font = Font.SystemFontOfSize(25),
                HorizontalOptions = LayoutOptions.Center
            };

            stackLayout = new StackLayout();

            stackLayout.Children.Add(textoPrincipal);

            Button novo = new Button()
            {
                Text = "Novo",
                Font = Font.SystemFontOfSize(10),
                HorizontalOptions = LayoutOptions.Start,
                BackgroundColor = Color.Transparent
            };

            novo.Clicked += new EventHandler(BtnNovaNoticia_Clicked);

            StackLayoutNoticias.Children.Add(stackLayout);
            StackLayoutNoticias.Children.Add(novo);

            foreach (Noticia noticia in service.listNews().noticias)
            {
                stackLayout = new StackLayout()
                {
                    BackgroundColor = Color.Azure,
                    Padding = 10
                };

                Label titulo = new Label()
                {
                    Text = "Novo caso de lavajato",
                    Font = Font.SystemFontOfSize(20),
                    HorizontalOptions = LayoutOptions.Center
                };

                Label mensagem = new Label()
                {
                    Text = "Novo caso de lavajato foi apurado no centro do rio de janeiro, onde foram presas 500 pessoas.",
                    Font = Font.SystemFontOfSize(15),
                    HorizontalOptions = LayoutOptions.Center
                };

                Label autor = new Label()
                {
                    Text = "Autor - Julio Grativol",
                    Font = Font.SystemFontOfSize(14),
                    HorizontalOptions = LayoutOptions.Center
                };

                Label data = new Label()
                {
                    Text = "28/06/2018",
                    Font = Font.SystemFontOfSize(14),
                    HorizontalOptions = LayoutOptions.End
                };

                Button excluir = new Button()
                {
                    Text = "Excluir",
                    Font = Font.SystemFontOfSize(10),
                    HorizontalOptions = LayoutOptions.Start,
                    BackgroundColor = Color.Transparent
                };


                stackLayout.Children.Add(titulo);
                stackLayout.Children.Add(mensagem);
                stackLayout.Children.Add(autor);
                stackLayout.Children.Add(data);
                stackLayout.Children.Add(excluir);

                StackLayoutNoticias.Children.Add(stackLayout);
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

        private void BtnNovaNoticia_Clicked(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new NovaNoticia());
        }
    }
}
