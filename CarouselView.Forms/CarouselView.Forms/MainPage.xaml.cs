using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselView.Forms
{
	public partial class MainPage : ContentPage
	{
        public List<CarouselModel> MyDataSource { get; set; }
        private int _position;
        public int Position { get { return _position; } set { _position = value; OnPropertyChanged(); } }
        public MainPage()
		{
			InitializeComponent();
            MyDataSource = new List<CarouselModel>() { new CarouselModel() { Title = "XamSarp", Detail="Contenido de Xamarin.Forms" },
                                                        new CarouselModel() { Title = "Sigue el ", Detail="Recibe correos electrónicos" },
                                                        new CarouselModel() { Title = "Blog", Detail="Luis David" }};

            BindingContext = this;
        }
	}
}
