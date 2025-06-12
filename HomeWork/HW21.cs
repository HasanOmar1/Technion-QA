namespace HomeWork
{
    public class HW21
    {

        public static bool letterCounter(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                int letterCounter = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                        letterCounter++;
                }

                if (letterCounter % 2 != 0)
                    return false;

            }

            return true;
        }

        public static bool isSpecial(string str)
        {
            if (str == null || str.Length == 0 || str.Length % 2 != 0) return false;

            // checks if a char is not a letter
            for (int i = 0; i < str.Length; i++)
                if (!char.IsLetter(str[i]))
                    return false;

            bool isSmall = true;
            bool isBig = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                    isSmall = false;

                if (char.IsLower(str[i]))
                    isBig = false;
            }


            // string contains big and small letters
            if (!isSmall && !isBig)
                return false;

            // string contains only small letters
            if (isSmall && !isBig)
            {
                if (!letterCounter(str))
                    return false;
            }
            else if (isBig && !isSmall)
            // string contains only big letters
            {
                if (!letterCounter(str))
                    return false;
            }




            return true;
        }
    }
}
