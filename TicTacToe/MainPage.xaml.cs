using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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

        //initialise turn, player 1 & plaler 2 score to 0
        private int turn = 1;
        private int player1 = 0;
        private int player2 = 0;


        //when a square is tapped, check whos turn it is and set
        //the content to either X or O
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
            checkForWinner();
        }

        //display whos turn it is
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

        //call all checking methods to see if someone has won
        public void checkForWinner()
        {
            checkRows();
            checkColumns();
            checkDiagonal1();
            checkDiagonal2();

            saveScore();
        }

        //check all rows to see if there is a winner
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

        //check all columns to see if there is a winner
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

        //check diagonal going down to the bottom right to see if there is a winner
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

        //check diagonal going up to the top left to see if there is a winner
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

        //clear the grid
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
            Application.Current.Exit(); //exit the game is the exit button is tapped
        }

        //reset the scores to 0and the grid to blank
        private void resetGame(object sender, TappedRoutedEventArgs e)
        {
            player1 = 0;
            player2 = 0;

            score1.Text = "";
            score2.Text = "";
            cleargame();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //read the settings
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            try
            {
                score1.Text = localSettings.Values["score1Setting"].ToString();

            }
            catch
            {
                player1 = 0;
                score1.Text = "";
            }

            base.OnNavigatedTo(e); //dont delete
        }

       private void saveScore()
        {
             ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            String score1Setting, score2Setting;

            score1Setting = localSettings.Values["player1"].ToString();
            score2Setting = localSettings.Values["player2"].ToString();



        }


    }
}
