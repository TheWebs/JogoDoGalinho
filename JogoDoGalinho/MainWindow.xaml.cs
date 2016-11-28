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
using MahApps.Metro.Controls;

namespace JogoDoGalinho
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        Jogo teste;
        public MainWindow()
        {
            InitializeComponent();
            teste = new Jogo();
            teste.preencheQuadro();
            teste.startGame();
            teste.print();
        }

        private void b_1_Click(object sender, RoutedEventArgs e)
        {
            if (teste.verificaOcupacao(0, 0) != true)
            {
                teste.ocupaEspaco(0, 0);
                teste.print();
                b_1.Content = teste.marca();
                if (teste.checkWin() != 'C')
                {
                    MessageBox.Show("O jogador " + teste.checkWin() + " ganhou!");
                }
            }

        }

        private void b_2_Click(object sender, RoutedEventArgs e)
        {
            if (teste.verificaOcupacao(1, 0) != true)
            {
                teste.ocupaEspaco(1, 0);
                teste.print();
                b_2.Content = teste.marca();
                if (teste.checkWin() != 'C')
                {
                    MessageBox.Show("O jogador " + teste.checkWin() + " ganhou!");
                }
            }
        }

        private void b_3_Click(object sender, RoutedEventArgs e)
        {
            if (teste.verificaOcupacao(2, 0) != true)
            {
                teste.ocupaEspaco(2, 0);
                teste.print();
                b_3.Content = teste.marca();
                if (teste.checkWin() != 'C')
                {
                    MessageBox.Show("O jogador " + teste.checkWin() + " ganhou!");
                }
            }
        }

        private void b_4_Click(object sender, RoutedEventArgs e)
        {
            if (teste.verificaOcupacao(0, 1) != true)
            {
                teste.ocupaEspaco(0, 1);
                teste.print();
                b_4.Content = teste.marca();
                if (teste.checkWin() != 'C')
                {
                    MessageBox.Show("O jogador " + teste.checkWin() + " ganhou!");
                }
            }
        }

        private void b_5_Click(object sender, RoutedEventArgs e)
        {
            if (teste.verificaOcupacao(1, 1) != true)
            {
                teste.ocupaEspaco(1, 1);
                teste.print();
                b_5.Content = teste.marca();
                if (teste.checkWin() != 'C')
                {
                    MessageBox.Show("O jogador " + teste.checkWin() + " ganhou!");
                }
            }
        }

        private void b_6_Click(object sender, RoutedEventArgs e)
        {
            if (teste.verificaOcupacao(2, 1) != true)
            {
                teste.ocupaEspaco(2, 1);
                teste.print();
                b_6.Content = teste.marca();
                if (teste.checkWin() != 'C')
                {
                    MessageBox.Show("O jogador " + teste.checkWin() + " ganhou!");
                }
            }
        }

        private void b_7_Click(object sender, RoutedEventArgs e)
        {
            if (teste.verificaOcupacao(0, 2) != true)
            {
                teste.ocupaEspaco(0, 2);
                teste.print();
                b_7.Content = teste.marca();
                if (teste.checkWin() != 'C')
                {
                    MessageBox.Show("O jogador " + teste.checkWin() + " ganhou!");
                }
            }
        }

        private void b_8_Click(object sender, RoutedEventArgs e)
        {
            if (teste.verificaOcupacao(1, 2) != true)
            {
                teste.ocupaEspaco(1, 2);
                teste.print();
                b_8.Content = teste.marca();
                if (teste.checkWin() != 'C')
                {
                    MessageBox.Show("O jogador " + teste.checkWin() + " ganhou!");
                }
            }
        }

        private void b_9_Click(object sender, RoutedEventArgs e)
        {
            if (teste.verificaOcupacao(2, 2) != true)
            {
                teste.ocupaEspaco(2, 2);
                teste.print();
                b_9.Content = teste.marca();
                if (teste.checkWin() != 'C')
                {
                    MessageBox.Show("O jogador " + teste.checkWin() + " ganhou!");
                }
            }
        }
    }
}