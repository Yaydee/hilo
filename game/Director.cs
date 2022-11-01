using System;
using System.Collections.Generic;

namespace Hilo.game
{
    public class Director
    {
        private Card card1 = new Card();
        private Card card2 = new Card();
        bool _isPlaying = true;
        int _score = 300;
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }
        public void GetInputs()
        {
            Console.Write("Play Again? [y/n] ");
            string rollDice = Console.ReadLine() ?? "n";
            _isPlaying = (rollDice == "y");
        }

        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }

            Console.WriteLine($"The card is {card1.DisplayCard()}");
            Console.WriteLine("Is the next card higher or lower? [h/l] ");
            string guess = Console.ReadLine() ?? "l";

            if ((card2.IsGreaterThan(card1) && guess == "h") || (card2.IsLessThan(card1) && guess == "l"))
            {
                _score += 100;
            }
            if ((card2.IsGreaterThan(card1) && guess == "l") || (card2.IsLessThan(card1) && guess == "h"))
            {
                _score -= 75;
            }
            card1 = card2;
            card2 = new Card();
        }

        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }

            Console.WriteLine($"Your score is: {_score}\n");
            _isPlaying = (_score > 0);
        }
    }
}