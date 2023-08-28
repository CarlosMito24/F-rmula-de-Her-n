using Microsoft.Maui.Platform;

namespace Fórmula_de_Herón;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void OnButtonClicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty (lado1.Text) && !string.IsNullOrEmpty(lado2.Text) && !string.IsNullOrEmpty(lado3.Text))
		{
			double ladouno, ladodos, ladotres, perimetro, area;
			ladouno = Convert.ToDouble(lado1.Text);
			ladodos = Convert.ToDouble(lado2.Text);
			ladotres = Convert.ToDouble(lado3.Text);
			perimetro = (ladouno + ladodos + ladotres) / 2;
			area = perimetro * ((perimetro - ladouno) * (perimetro - ladodos) * (perimetro - ladotres));
            double raizcuadrada = Math.Sqrt(area);
			string conversion;
            conversion = raizcuadrada.ToString("0.00");
            label1.Text = "El área del triángulo es: " + conversion;
		}
		else
		{
            DisplayAlert("Error", "Introduce los datos solicitados", "Ok");
			label1.Text = "El área del triángulo es:";
        }
    }
}