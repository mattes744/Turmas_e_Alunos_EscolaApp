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

namespace Turmas_e_Alunos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TurmaWindow w = new TurmaWindow();
            w.ShowDialog();
            //Só usando o "W.Show" cria diversos objetos sem parar
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            AlunoWindow w = new AlunoWindow();
            w.ShowDialog();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            MatriculaWindow w = new MatriculaWindow();
            w.ShowDialog();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            DiarioWindow w = new DiarioWindow(); ;
            w.ShowDialog();
        }
    }
}
