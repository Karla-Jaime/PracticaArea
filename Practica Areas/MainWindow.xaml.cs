using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica_Areas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }


        private void btnCalcula1_Click(object sender, RoutedEventArgs e)
        {
            //float AlturaRe = float.Parse(txtAlturaRe.Text);
            //float BaseRe = float.Parse(txtBaseRe.Text);
            //float calculoUno = AlturaRe * BaseRe;
            //txtbArea1.Text = calculoUno.ToString();
        }
        private void btnCalcula2_Click(object sender, RoutedEventArgs e)
        {
            //float AlturaTri = float.Parse(txtAlturaTri.Text);
            //float BaseTri = float.Parse(txtBaseTri.Text);
            //float calculoDos = (AlturaTri * BaseTri) / 2;
            //txtbArea2.Text = calculoDos.ToString();

        }

        private void btnCalcula3_Click(object sender, RoutedEventArgs e)
        {
            //float RadioC = float.Parse(txtRadio.Text);
            //float Pi = 3.1416F;
            //float calculoTres = Pi * (RadioC * RadioC);
            //txtbArea3.Text = calculoTres.ToString();
        }

        private void btnCalcula4_Click(object sender, RoutedEventArgs e)
        {
            //float altura = float.Parse(txtAlturaT.Text);
            //float baseM = float.Parse(txtBaseMT.Text);
            //float basem = float.Parse(txtBasemT.Text);
            //float calculoCuatro = (altura * ((baseM * basem) / 2));
            //txtbArea4.Text = calculoCuatro.ToString();
        }

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PanelConfiguracion.Children.Clear();
            switch (cbTipoFigura.SelectedIndex)
            {   
                case 0://Rectangulo
                 
                    PanelConfiguracion.Children.Add(new ControlAreaRectangulo());
                    break;

                case 1://Triangulo
                    PanelConfiguracion.Children.Add(new AreaTriangulo0());
                    break;

                case 2: //Circulo
                    PanelConfiguracion.Children.Add(new Circulo());
                    break;

                case 3: //Trapecio
                    PanelConfiguracion.Children.Add(new Trapecio());
                    break;
                default: break;
            }
        }

        private void btnCalcula2_Click_1(object sender, RoutedEventArgs e)
        {
            double area = 0.0;
            switch (cbTipoFigura.SelectedIndex)
            {
                case 0:
                    var controlAreaRectangulo = (ControlAreaRectangulo)
                    PanelConfiguracion.Children[0];

                    float BaseRec = float.Parse(controlAreaRectangulo.txtBaseRe.Text);
                    float AlturaRec = float.Parse(controlAreaRectangulo.txtAlturaRe.Text);
                    area = BaseRec * AlturaRec;
                    break;
                case 1:
                    var controlAreatriangulo = (AreaTriangulo0)PanelConfiguracion.Children[0];
                    
                    break;
                case 2:
                    var controlAreacirculo = (Circulo)PanelConfiguracion.Children[0];

                    float radio = float.Parse(controlAreacirculo.txtRadio.Text);
                    area = 3.1416f * (radio * radio);
                    break;
                case 3:

                    break;
                default:
                    break;
            }
            lblResultadoArea.Text = area.ToString();
        }
    }
}
