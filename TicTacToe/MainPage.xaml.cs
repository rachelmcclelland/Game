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
            
        }

        private int turn = 1;
        private int player1 = 0;
        private int player2 = 0;

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Button button = (Button)sender;
            
            if (turn % 2 != 0)
            {
                button.Content = "X";
            }
            else if (turn % 2 ==0)
            {
                button.Content = "O";
            }
            else
            {
                button.Content = button.Content;
            }
            turn++;

            display(turn);

            int rowPos = (int) button.GetValue(Grid.RowProperty);
            checkForWinner();
        }

        #region
        /*        private int turn = 1;

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
                }*/
        #endregion


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

        public void checkForWinner()
        {
            checkRows();
            checkColumns();
            checkDiagonal1();
            checkDiagonal2();
        }

        private async void checkRows()
        {

            if ((String)button1.Content != "" && (String)button2.Content != "" && (String)button3.Content != "")
            {
                if ((button1.Content == button2.Content && button1.Content == button3.Content))
                {
                    if ((String)button1.Content == "X")
                    {
                        var Msg = new MessageDialog("Player 1 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player1++;
                        score1.Text = player1.ToString();
                    }
                    else
                    {
                        var Msg = new MessageDialog("Player 2 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player2++;
                        score2.Text = player2.ToString();
                    }
                    cleargame();
                }  
            }
            if ((String)button4.Content != "" && (String)button5.Content != "" && (String)button6.Content != "")
            {
                if ((button4.Content == button5.Content && button4.Content == button6.Content))
                {
                    if ((String)button4.Content == "X")
                    {
                        var Msg = new MessageDialog("Player 1 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player1++;
                        score1.Text = player1.ToString();
                    }
                    else
                    {
                        var Msg = new MessageDialog("Player 2 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player2++;
                        score2.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
            if ((String)button7.Content != "" && (String)button8.Content != "" && (String)button9.Content != "")
            {
                if ((button7.Content == button8.Content && button7.Content == button9.Content))
                {
                    if ((String)button7.Content == "X")
                    {
                        var Msg = new MessageDialog("Player 1 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player1++;
                        score1.Text = player1.ToString();
                    }
                    else
                    {
                        var Msg = new MessageDialog("Player 2 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player2++;
                        score2.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
        }

        private async void checkColumns()
        {
            if ((String)button1.Content != "" && (String)button4.Content != "" && (String)button7.Content != "")
            {
                if ((button1.Content == button4.Content && button1.Content == button7.Content))
                {
                    if ((String)button1.Content == "X")
                    {
                        var Msg = new MessageDialog("Player 1 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player1++;
                        score1.Text = player1.ToString();
                    }
                    else
                    {
                        var Msg = new MessageDialog("Player 2 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player2++;
                        score2.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
            if ((String)button2.Content != "" && (String)button5.Content != "" && (String)button8.Content != "")
            {
                if ((button2.Content == button5.Content && button2.Content == button8.Content))
                {
                    if ((String)button4.Content == "X")
                    {
                        var Msg = new MessageDialog("Player 1 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player1++;
                        score1.Text = player1.ToString();
                    }
                    else
                    {
                        var Msg = new MessageDialog("Player 2 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player2++;
                        score2.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
            if ((String)button3.Content != "" && (String)button6.Content != "" && (String)button9.Content != "")
            {
                if ((button3.Content == button6.Content && button3.Content == button9.Content))
                {
                    if ((String)button7.Content == "X")
                    {
                        var Msg = new MessageDialog("Player 1 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player1++;
                        score1.Text = player1.ToString();
                    }
                    else
                    {
                        var Msg = new MessageDialog("Player 2 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player2++;
                        score2.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
        }

        private async void checkDiagonal1()
        {
            if ((String)button1.Content != "" && (String)button5.Content != "" && (String)button9.Content != "")
            {
                if ((button1.Content == button5.Content && button1.Content == button9.Content))
                {
                    if ((String)button1.Content == "X")
                    {
                        var Msg = new MessageDialog("Player 1 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player1++;
                        score1.Text = player1.ToString();
                    }
                    else
                    {
                        var Msg = new MessageDialog("Player 2 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player2++;
                        score2.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
           
        }

        private async void checkDiagonal2()
        {
            if ((String)button3.Content != "" && (String)button5.Content != "" && (String)button7.Content != "")
            {
                if ((button3.Content == button5.Content && button3.Content == button7.Content))
                {
                    if ((String)button1.Content == "X")
                    {
                        var Msg = new MessageDialog("Player 1 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player1++;
                        score1.Text = player1.ToString();
                    }
                    else
                    {
                        var Msg = new MessageDialog("Player 2 Wins!", "Game Over");
                        await Msg.ShowAsync();
                        player2++;
                        score2.Text = player2.ToString();
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

        private void exitGame(object sender, TappedRoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void resetGame(object sender, TappedRoutedEventArgs e)
        {
            player1 = 0;
            player2 = 0;

            score1.Text = "";
            score2.Text = "";
            cleargame();

        }
        
    }
}
