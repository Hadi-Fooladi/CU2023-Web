namespace XO
{
    public class Game
    {
        public const char X = 'X', O = 'O', B = 'B';


        public Game()
        {
            for (var i = 0; i < 9; i++)
                _a[i] = B;
        }

        public Game(string s)
        {
            if (s.Length != 9)
                throw new ArgumentException();

            for (var i = 0; i < 9; i++)
                _a[i] = s[i];
        }

        readonly char[] _a = new char[9];

        public char this[int row, int col] => _a[row * 3 + col];
    }
}
