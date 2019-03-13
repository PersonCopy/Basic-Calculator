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

namespace Nutzvoller_Taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private long zwischenresultat = 0;
        private string zwischenString = "0";
        private string resToHex = "";
        private long resultat = 0;
        private char operation = '+';

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DezButton_Checked(object sender, RoutedEventArgs e)
        {
            aButton.IsEnabled = false;
            bButton.IsEnabled = false;
            cButton.IsEnabled = false;
            dButton.IsEnabled = false;
            eButton.IsEnabled = false;
            fButton.IsEnabled = false;
            one.IsEnabled = true;
            two.IsEnabled = true;
            three.IsEnabled = true;
            four.IsEnabled = true;
            five.IsEnabled = true;
            six.IsEnabled = true;
            seven.IsEnabled = true;
            eight.IsEnabled = true;
            nine.IsEnabled = true;
            displayRes();
        }

        private void HexButton_Checked(object sender, RoutedEventArgs e)
        {
            aButton.IsEnabled = true;
            bButton.IsEnabled = true;
            cButton.IsEnabled = true;
            dButton.IsEnabled = true;
            eButton.IsEnabled = true;
            fButton.IsEnabled = true;
            one.IsEnabled = true;
            two.IsEnabled = true;
            three.IsEnabled = true;
            four.IsEnabled = true;
            five.IsEnabled = true;
            six.IsEnabled = true;
            seven.IsEnabled = true;
            eight.IsEnabled = true;
            nine.IsEnabled = true;
            displayRes();
        }
        //test commit

        private void OktButton_Checked(object sender, RoutedEventArgs e)
        {
            aButton.IsEnabled = false;
            bButton.IsEnabled = false;
            cButton.IsEnabled = false;
            dButton.IsEnabled = false;
            eButton.IsEnabled = false;
            fButton.IsEnabled = false;
            one.IsEnabled = true;
            two.IsEnabled = true;
            three.IsEnabled = true;
            four.IsEnabled = true;
            five.IsEnabled = true;
            six.IsEnabled = true;
            seven.IsEnabled = true;
            eight.IsEnabled = false;
            nine.IsEnabled = false;
            displayRes();
        }

        private void BinButton_Checked(object sender, RoutedEventArgs e)
        {
            aButton.IsEnabled = false;
            bButton.IsEnabled = false;
            cButton.IsEnabled = false;
            dButton.IsEnabled = false;
            eButton.IsEnabled = false;
            fButton.IsEnabled = false;
            one.IsEnabled = true;
            two.IsEnabled = false;
            three.IsEnabled = false;
            four.IsEnabled = false;
            five.IsEnabled = false;
            six.IsEnabled = false;
            seven.IsEnabled = false;
            eight.IsEnabled = false;
            nine.IsEnabled = false;
            displayRes();
        }

        private void AButton_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 10;
            displayRes();
        }

        private void BButton_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 11;
            displayRes();
        }

        private void CButton_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 12;
            displayRes();
        }

        private void DButton_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 13;
            displayRes();
        }

        private void EButton_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 14;
            displayRes();
        }

        private void FButton_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 15;
            displayRes();
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10);
            displayRes();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 1;
            displayRes();
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 2;
            displayRes();
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 3;
            displayRes();
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 4;
            displayRes();
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 5;
            displayRes();
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 6;
            displayRes();
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 7;
            displayRes();
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 8;
            displayRes();
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = (zwischenresultat * 10) + 9;
            displayRes();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            zwischenresultat = 0;
            displayRes();
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case '+':
                    {
                        resultat += zwischenresultat;
                        break;
                    }
                case '‐':
                    {
                        resultat -= zwischenresultat;
                        break;
                    }
                case '*':
                    {
                        resultat *= zwischenresultat;
                        break;
                    }
                case '/':
                    {
                        if (zwischenresultat == 0)
                        {
                            MessageBox.Show("Achtung: Division duch 0 ist nicht erlaubt!");
                        }
                        else
                        {
                            resultat /= zwischenresultat;
                        }
                        break;
                    }
            }
            zwischenresultat = resultat;
            displayRes();
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            resultat = zwischenresultat;
            operation = '+';
            zwischenresultat = 0;
            displayRes();
        }

        private void MinButton_Click(object sender, RoutedEventArgs e)
        {
            resultat = zwischenresultat;
            operation = '-';
            zwischenresultat = 0;
            displayRes();
        }

        private void MulButton_Click(object sender, RoutedEventArgs e)
        {
            resultat = zwischenresultat;
            operation = '*';
            zwischenresultat = 0;
            displayRes();
        }

        private void DivButton_Click(object sender, RoutedEventArgs e)
        {
            resultat = zwischenresultat;
            operation = '/';
            zwischenresultat = 0;
            displayRes();
        }

        private void displayRes()
        {
            if (dezButton.IsChecked ?? false)
            {
                ResultatBox.Text = Convert.ToString(zwischenresultat);
            }
            else if (hexButton.IsChecked ?? false)
            {
                string hexvalue = zwischenresultat.ToString("X");
                ResultatBox.Text = hexvalue;
            }
            else if (oktButton.IsChecked ?? false)
            {
                string octwert = Convert.ToString(zwischenresultat, 8);
                ResultatBox.Text = octwert;
            }
            else if (binButton.IsChecked ?? false)
            {
                string binwert = Convert.ToString(zwischenresultat, 2);
                ResultatBox.Text = binwert;
            }
        }

    }
}
