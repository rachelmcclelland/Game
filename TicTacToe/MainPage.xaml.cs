using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TicTacToe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //setUpBoard();
        }


      /*  private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Button button = (Button)sender;
            int buttonTapped = 0;
            int turn = 1;
            if (buttonTapped == 0)
            {
                if (turn % 2 != 0)
                {
                    button.Content = "X";
                }
                else
                {
                    button.Content = "O";
                }
                
            }
            else
            {
                button.Content = button.Content;
            }
           display(turn);
  //          checkit();
        }*/

        private int turn = 1;

        private void Button_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            int click1 = 0;

            if (click1 == 0)
            {
                if (turn % 2 != 0)
                {
                    button1.Content = "X";
                }
                else
                {
                    button1.Content = "O";
                }
                turn++;
                click1++;
            }
            else
            {
                button1.Content = button1.Content;
            }
            display(turn);
            checkForWinner(turn);
        }

        private void Button_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            int click2 = 0;
            
            if (click2 == 0)
            {
                if (turn % 2 != 0)
                {
                    button2.Content = "X";
                }
                else
                {
                    button2.Content = "O";
                }
                turn++;
                click2++;
            }
            else
            {
                button2.Content = button2.Content;
            }
            display(turn);
            checkForWinner(turn);
        }

        private void Button_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            int click3 = 0;
            if (click3 == 0)
            {
                if (turn % 2 != 0)
                {
                    button3.Content = "X";
                }
                else
                {
                    button3.Content = "O";
                }
                turn++;
                click3++;
            }
            else
            {
                button3.Content = button3.Content;
            }
            display(turn);
            checkForWinner(turn);
        }

        private void Button_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            int click4 = 0;
            if (click4 == 0)
            {
                if (turn % 2 != 0)
                {
                    button4.Content = "X";
                }
                else
                {
                    button4.Content = "O";
                }
                turn++;
                click4++;
            }
            else
            {
                button1.Content = button1.Content;
            }
            display(turn);
            checkForWinner(turn);
        }

        private void Button_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            int click5 = 0;
            if (click5 == 0)
            {
                if (turn % 2 != 0)
                {
                    button5.Content = "X";
                }
                else
                {
                    button5.Content = "O";
                }
                turn++;
                click5++;
            }
            else
            {
                button1.Content = button1.Content;
            }
            display(turn);
            checkForWinner(turn);
        }

        private void Button_Tapped_6(object sender, TappedRoutedEventArgs e)
        {
            int click6 = 0;
            if (click6 == 0)
            {
                if (turn % 2 != 0)
                {
                    button6.Content = "X";
                }
                else
                {
                    button6.Content = "O";
                }
                turn++;
                click6++;
            }
            else
            {
                button6.Content = button6.Content;
            }
            display(turn);
            checkForWinner(turn);
        }

        private void Button_Tapped_7(object sender, TappedRoutedEventArgs e)
        {
            int click7 = 0;
            if (click7 == 0)
            {
                if (turn % 2 != 0)
                {
                    button7.Content = "X";
                }
                else
                {
                    button7.Content = "O";
                }
                turn++;
                click7++;
            }
            else
            {
                button7.Content = button7.Content;
            }
            display(turn);
            checkForWinner(turn);
        }

        private void Button_Tapped_8(object sender, TappedRoutedEventArgs e)
        {
            int click8 = 0;
            if (click8 == 0)
            {
                if (turn % 2 != 0)
                {
                    button8.Content = "X";
                }
                else
                {
                    button8.Content = "O";
                }
                turn++;
                click8++;
            }
            else
            {
                button8.Content = button8.Content;
            }
            display(turn);
            checkForWinner(turn);
        }

        private void Button_Tapped_9(object sender, TappedRoutedEventArgs e)
        {
            int click9 = 0;
            if (click9 == 0)
            {
                if (turn % 2 != 0)
                {
                    button9.Content = "X";
                }
                else
                {
                    button9.Content = "O";
                }
                turn++;
                click9++;
            }
            else
            {
                button9.Content = button9.Content;
            }
            display(turn);
            checkForWinner(turn);
        }


        private void display(int turn)
        {
            if (turn % 2 != 0)
            {
                displayTurn.Text = "Player 1";
            }
            else
            {
                displayTurn.Text = "Player 2";
            }
        }

        public void checkForWinner(int turn)
        {
            
            if ((String)button1.Content != "" && (String) button2.Content != "" &&  (String)button3.Content != "")
            {
                if (button1.Content == button2.Content && button1.Content == button3.Content)
                {
                    if ((String)button1.Content == "X")
                    {
                        var Msg = new MessageDialog("Player 1 Wins!", "Game Over");
                   //     player1++;
                   //     player1score.Text = player1.ToString();
                    }
                    else
                    {
                        var Msg = new MessageDialog("Player 2 Wins!", "Game Over");
                 //       player2++;
                 //       player2score.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
        }

        private void cleargame()
        {
            button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";

        }

        /*  private void setUpBoard()
          {
              TextBlock tbl1 = new TextBlock();
              tbl1.Text = "Turn";
              tbl1.HorizontalAlignment = HorizontalAlignment.Center;
              tbl1.Margin = new Thickness(50);
              tbl1.VerticalAlignment = VerticalAlignment.Top;
              tbl1.for

              board.Children.Add(tbl1);
              /* int i;

               _height = (int) rootPage.ActualHeight / 9;
               _width = (int)rootPage.ActualWidth / 9;
               Grid g1 = new Grid();
               g1.Name = "board";
               g1.Height = 450;
               g1.Width = 450;
               g1.Background = new SolidColorBrush(Colors.Blue);
               g1.HorizontalAlignment = HorizontalAlignment.Left;

               rootPage.Children.Add(g1);

               for (i = 0; i < 3; i++)
               {
                   g1.RowDefinitions.Add(new RowDefinition());
                   g1.ColumnDefinitions.Add(new ColumnDefinition());
               }

               addButtons();
              } */


    }
}
