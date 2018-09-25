﻿using System;
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
            float AlturaRe = float.Parse(txtAlturaRe.Text);
            float BaseRe = float.Parse(txtBaseRe.Text);
            float calculoUno = AlturaRe * BaseRe;
            txtbArea1.Text = calculoUno.ToString();
        }
        private void btnCalcula2_Click(object sender, RoutedEventArgs e)
        {
            float AlturaTri = float.Parse(txtAlturaTri.Text);
            float BaseTri = float.Parse(txtBaseTri.Text);
            float calculoDos = (AlturaTri * BaseTri) / 2;
            txtbArea2.Text = calculoDos.ToString();

        }

        private void btnCalcula3_Click(object sender, RoutedEventArgs e)
        {
            float RadioC = float.Parse(txtRadio.Text);
            float Pi = 3.1416F;
            float calculoTres = Pi * (RadioC * RadioC);
            txtbArea3.Text = calculoTres.ToString();
        }

        private void btnCalcula4_Click(object sender, RoutedEventArgs e)
        {
            float altura = float.Parse(txtAlturaT.Text);
            float baseM = float.Parse(txtBaseMT.Text);
            float basem = float.Parse(txtBasemT.Text);
            float calculoCuatro = (altura * ((baseM * basem) / 2));
            txtbArea4.Text = calculoCuatro.ToString();
        }
    }
}