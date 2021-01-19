using System;
using System.Collections.Generic;
using System.Text;

namespace DoD_course
{
    class Character
    {
        public string Name;
        public int SizeInCM;
        public Attributes Attributes;

        private int sizeValueInCM = 10;
        private int sizeBaseValueInCM = 50;

        public Character(string name)
        {
            Attributes = new Attributes();
            RandomizeCharacterAttributes();
            Name = name;
        }

        public void RandomizeCharacterAttributes()
        {
            // TODO: Apply different modifiers depending on profession and race.
            Attributes.Strength = DiceT6(2);
            Attributes.Constituion = DiceT6(2);
            Attributes.Intelligence = DiceT6(2);
            Attributes.Wisdom = DiceT6(2);
            Attributes.Dexterity = DiceT6(2);
            Attributes.Charisma = DiceT6(2);
            Attributes.Size = DiceT6(2);

            SizeInCM = GetCharacterSizeinCM(Attributes.Size);
        }

        public Attributes GetCharacterAttributes()
        {
            return Attributes;
        }

        public int GetCharacterSizeinCM(int size)
        {
            return (size * sizeValueInCM) + sizeBaseValueInCM;
        }

        // TODO: Move this into a Dice class
        private int DiceT6(int dices)
        {
            var rand = new Random();
            int result = 0;
            for (int i = 0; i <= dices; i++)
            {
                int dice = rand.Next(1, 7);
                if(dice > 6 || dice < 1)
                {
                    Console.WriteLine("ERROR: Dice value is out of bounds!");
                }
                result += dice;
                // TODO: Do we want to show each dice throw?
                // Can access each dice here with another method.
            }
            return result;
        }
    }


}
