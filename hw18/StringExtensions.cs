
namespace hw18
{
    public static class StringExtensions
    {
        public static int WordsAmount(this string str)
        {
            int amount = 0;
            bool inWord = false;

            foreach (char c in str)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (inWord)
                    {
                        amount++;
                        inWord = false;
                    }
                }
                else
                {
                    inWord = true;
                }
            }
            if (inWord)
            {
                amount++;
            }
            return amount;
        }

        public static int LengthOfLastWord(this string str)
        {
            int length = 0;
            bool inWord = false;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ' ' || str[i] == '\t' || str[i] == '\n' || str[i] == '\r')
                {
                    if (inWord)
                    {
                        break;
                    }
                }
                else
                {
                    if (!inWord)
                    {
                        inWord = true;
                    }
                    length++;
                }
            }

            return length;
        }

        public static bool BracketsCheck(this string str)
        {
            int roundBrackets = 0;
            int curlyBrackets = 0;
            int squareBrackets = 0;

            foreach (char c in str)
            {
                switch (c)
                {
                    case '(':
                        roundBrackets++;
                        break;
                    case ')':
                        roundBrackets--;
                        if (roundBrackets < 0) return false;
                        break;
                    case '{':
                        curlyBrackets++;
                        break;
                    case '}':
                        curlyBrackets--;
                        if (curlyBrackets < 0) return false;
                        break;
                    case '[':
                        squareBrackets++;
                        break;
                    case ']':
                        squareBrackets--;
                        if (squareBrackets < 0) return false;
                        break;
                }
            }

            return roundBrackets == 0 && curlyBrackets == 0 && squareBrackets == 0;
        }
    }
}
