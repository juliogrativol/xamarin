using CentralNoticias.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            service.listNews();
        }
    }
}
