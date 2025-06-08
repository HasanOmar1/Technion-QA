namespace HomeWork
{
    public class HW20
    {

        public static bool IsSpecial(string str)
        {

            if (str == null || str.Length == 0) return false;

            int numOfLetters = 26;
            int[] arrOfSmallLetters = new int[numOfLetters];
            int[] arrOfBigLetters = new int[numOfLetters];

            for (int i = 0; i < numOfLetters; i++)
            {
                // start all indexes with zero
                arrOfSmallLetters[i] = 0;
                arrOfBigLetters[i] = 0;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    // a = 97 in ascii
                    int charInInt = (int)str[i] - 97;
                    arrOfSmallLetters[charInInt]++;

                }

                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    // A = 65 in ascii
                    int charInInt = (int)str[i] - 65;
                    arrOfBigLetters[charInInt]++;

                }

            }

            for (int i = 0; i < numOfLetters; i++)
                if (arrOfSmallLetters[i] != arrOfBigLetters[i])
                    return false;

            // checks if there is atleast a letter;
            bool isLetter = false;
            for (int i = 0; i < numOfLetters; i++)
                if ((arrOfSmallLetters[i] == arrOfBigLetters[i]) && arrOfSmallLetters[i] != 0)
                    isLetter = true;

            if (!isLetter) return false;

            return true;
        }
    }
}
