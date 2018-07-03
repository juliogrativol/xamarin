using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CardChooser
{
    public partial class CardChooserPage : ContentPage
    {
        List<int> lista = new List<int>();
        int var_perdeu = 0;
        int var_ganhou= 0;

        public CardChooserPage()
        {
            InitializeComponent();
            inicia();
            Shuffle(lista);
        }

        void btn_1_Clicked(object sender, System.EventArgs e)
        {
            if (lista.IndexOf(0) == 1)
            {
                btn_1.BackgroundColor = Color.Red;
                mensagem.Text = "Perdeu!!!";
                var_perdeu++;
            }
            else
            {
                btn_1.BackgroundColor = Color.Yellow;
                mensagem.Text = "Parabéns!!!";
                var_ganhou++;
            }

            btn_start.IsEnabled = true;
            btn_1.IsEnabled = false;
            btn_2.IsEnabled = false;
            btn_3.IsEnabled = false;
            perdeu.Text = "Perdeu " + var_perdeu.ToString();
            ganhouss.Text = "Ganhou " + var_ganhou.ToString();
            perdeu.IsVisible = true;
            ganhouss.IsVisible = true;
        }

        void btn_2_Clicked(object sender, System.EventArgs e)
        {
            if (lista.IndexOf(1) == 1)
            {
                btn_2.BackgroundColor = Color.Red;
                mensagem.Text = "Perdeu!!!";
                var_perdeu++;
            }
            else
            {
                btn_2.BackgroundColor = Color.Yellow;
                mensagem.Text = "Parabéns!!!";
                var_ganhou++;
            }

            btn_start.IsEnabled = true;
            btn_1.IsEnabled = false;
            btn_2.IsEnabled = false;
            btn_3.IsEnabled = false;
            perdeu.Text = "Perdeu " + var_perdeu.ToString();
            ganhouss.Text = "Ganhou " + var_ganhou.ToString();
            perdeu.IsVisible = true;
            ganhouss.IsVisible = true;
        }

        void btn_3_Clicked(object sender, System.EventArgs e)
        {
            if (lista.IndexOf(2) == 1)
            {
                btn_3.BackgroundColor = Color.Red;
                mensagem.Text = "Perdeu!!!";
                var_perdeu++;
            }
            else
            {
                btn_3.BackgroundColor = Color.Yellow;
                mensagem.Text = "Parabéns!!!";
                var_ganhou++;
            }

            btn_start.IsEnabled = true;
            btn_1.IsEnabled = false;
            btn_2.IsEnabled = false;
            btn_3.IsEnabled = false;
            perdeu.Text = "Perdeu "+var_perdeu.ToString();
            ganhouss.Text = "Ganhou "+var_ganhou.ToString();
            perdeu.IsVisible = true;
            ganhouss.IsVisible = true;
        }

        void btn_start_Clicked(object sender, System.EventArgs e)
        {
            inicia();
        }

        public void inicia()
        {
            lista.Add(0);
            lista.Add(0);
            lista.Add(1);


            btn_1.BackgroundColor = Color.Green;
            btn_2.BackgroundColor = Color.Green;
            btn_3.BackgroundColor = Color.Green;

            btn_start.IsEnabled = false;

            mensagem.Text = "";

            btn_1.IsEnabled = true;
            btn_2.IsEnabled = true;
            btn_3.IsEnabled = true;

            Shuffle(lista);

            perdeu.IsVisible = false;
            ganhouss.IsVisible = false;
        }


        public void Shuffle(List<int> ts)
        {
            var count = ts.Count;
            var last = count-1 ;
            Random rdn = new Random();
            for (var i = 0; i < last; ++i)
            {
                var r = rdn.Next(i, ts.Count);
                var tmp = ts[i];
                ts[i] = ts[r];
                ts[r] = tmp;
            }
        }
    }
}
