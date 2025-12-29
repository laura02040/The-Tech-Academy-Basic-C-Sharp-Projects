using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game
    {
        private Player Player;
        public TwentyOneGame(Player player)
        {
            this.Player = player;
        }
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            {
                Dealer = new TwentyOneDealer();
                foreach (Player player in Players)
                {
                    player.Hand = new List<Card>();
                    player.Stay = false;
                }

                Dealer.Hand = new List<Card>();
                Dealer.Stay = false;
                Dealer.Deck = new Deck();
                Dealer.Deck = Dealer.Shuffle();

                Console.WriteLine("Place your bet!");
                foreach (Player player in Players)
                {
                    bool validBet = false;
                    while (!validBet)
                    {
                        Console.Write($"{player.Name}, enter your bet: ");
                        if (int.TryParse(Console.ReadLine(), out int bet))
                        {
                            if (bet > 0 && bet <= player.Balance)
                            {
                                if (player.Bet(bet))
                                {
                                    Bets[player] = bet;
                                    validBet = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid bet. Please try again.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid bet amount. Please enter a bet between 1 and your balance.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                }

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Dealing...");
                    foreach (Player player in Players)
                    {
                        Console.Write($"{player.Name}: ");
                        Dealer.Deal(player.Hand);
                        if (i == 1)
                        {
                            bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                            if (blackJack)
                            {
                                Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);
                                player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                                Bets.Remove(player);
                                player.isActivelyPlaying = false;
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.Write("Dealer: ");
                    Dealer.Deal(Dealer.Hand);
                    Console.WriteLine();

                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Dealer has Black Jack! Everyone loses!");
                            foreach (KeyValuePair<Player, int> entry in Bets)
                            {
                                Dealer.Balance += entry.Value;
                            }
                            return;
                        }
                    }
                }

                foreach (Player player in Players.ToList())
                {
                    while (!player.Stay)
                    {
                        Console.WriteLine("Your cards are:");
                        foreach (Card card in player.Hand)
                        {
                            Console.Write($"{card} ");
                        }
                        Console.WriteLine();

                        Console.WriteLine("\n\nHit or Stay?");
                        string answer = Console.ReadLine().ToLower();
                        if (answer == "stay")
                        {
                            player.Stay = true;
                            break;
                        }
                        else if (answer == "hit")
                        {
                            Dealer.Deal(player.Hand);
                            bool busted = TwentyOneRules.IsBusted(player.Hand);
                            if (busted)
                            {
                                Dealer.Balance += Bets[player];
                                Console.WriteLine($"{player.Name} Busted! You lose your bet of {Bets[player]}. Your Balance is now {player.Balance}.");
                                Console.WriteLine("Do you want to play again?");
                                answer = Console.ReadLine().ToLower();
                                if (answer == "yes" || answer == "yeah")
                                {
                                    player.isActivelyPlaying = true;
                                }
                                else
                                {
                                    player.isActivelyPlaying = false;
                                }
                                Bets.Remove(player);
                                break;
                            }
                        }
                    }
                }

                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
                while (!Dealer.Stay && !Dealer.isBusted)
                {
                    Console.Write("Dealer is hitting...");
                    Dealer.Deal(Dealer.Hand);
                    Console.WriteLine();
                    Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                    Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
                }

                if (Dealer.Stay)
                {
                    Console.WriteLine("Dealer is staying.");
                }

                if (Dealer.isBusted)
                {
                    Console.WriteLine("Dealer Busted!");
                    foreach (KeyValuePair<Player, int> entry in Bets.ToList())
                    {
                        Console.WriteLine($"{entry.Key.Name} won {entry.Value}!");
                        Players.First(x => x.Name == entry.Key.Name).Balance += (entry.Value * 2);
                        Dealer.Balance -= entry.Value;
                    }
                    return;
                }

                foreach (Player player in Players.ToList())
                {
                    if (Bets.ContainsKey(player))
                    {
                        bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                        if (playerWon == null)
                        {
                            Console.WriteLine("Push! No one wins.");
                            player.Balance += Bets[player];
                        }
                        else if (playerWon == true)
                        {
                            Console.WriteLine($"{player.Name} won {Bets[player]}!");
                            player.Balance += (Bets[player] * 2);
                            Dealer.Balance -= Bets[player];
                        }
                        else
                        {
                            Console.WriteLine($"Dealer wins {Bets[player]}!");
                            Dealer.Balance += Bets[player];
                        }
                        Console.WriteLine("Play again?");
                        string answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                        }
                        Bets.Remove(player);
                    }
                }
            }
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
    internal class TwentyOneDealer : Deck.TwentyOneDealer
    {

    }
}
