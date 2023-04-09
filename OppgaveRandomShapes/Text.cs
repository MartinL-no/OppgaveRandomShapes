using System;

namespace RandomBoxes
{
    class Text : Shape
    {
        private readonly string _text;
        public Text(Random random, int maxX, int maxY, string text)
            : base(random)
        {
            X = random.Next(0, maxX - text.Length);
            Y = random.Next(0, maxY - text.Length);
            _text = text;
        }
        public override string GetCharacter(int row, int col)
        {
            // First letter
            if (row == Y && col == X) return _text[0].ToString();

            // Rest of the characters
            for (int i = 1; i < _text.Length; i++)
            {
                if (row == Y && col - i == X) return _text[i].ToString();
            }
            return null;
        }
    }
}
