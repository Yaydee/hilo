using System;
using System.Collections.Generic;

namespace Hilo.game // Note actual namespace depends on the project name.
{
    internal class Card
    {
        int card = 0;
            // public void DrawCard()
            // {
                private int _value;

                public Card()
                {
                    ShuffleCard();
                }

                public bool IsLessThan(Card other)
                {
                    return _value < other._value;
                }
                public bool IsGreaterThan(Card other)
                {
                    return _value > other._value;
                }

                public string DisplayCard()
                {
                    return ($"{_value}");
                }

                public int ShuffleCard()
                {
                    Random random = new Random();
                    _value = random.Next(1,14);
                    return _value;
                }
            // }
        
    }
}