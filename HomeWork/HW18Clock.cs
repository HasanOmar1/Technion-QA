namespace HomeWork
{
    public class HW18Clock
    {
        private int hour; // hours 0-23
        private int min; // minutes 0-59


        public HW18Clock(int hour, int min)
        {
            this.hour = (hour < 0) || (hour > 23) ? 0 : hour;
            this.min = (min < 0) || (min > 59) ? 0 : min;

        }

        public int GetHour()
        {
            return this.hour;
        }

        public int GetMin()
        {
            return this.min;
        }



        public string ToString()
        {


            string hour = "";
            if (this.hour < 10)
                hour = "0" + this.hour;
            else
                hour = this.hour.ToString();

            string min = "";
            if (this.min < 10)
                min = "0" + this.min;
            else
                min = this.min.ToString();

            return hour + ":" + min;
        }

        public int GetInterval()
        {
            int TwentyFourInMinutes = 1440; // 24*60
            int currentHourInMinutes = this.hour * 60;
            int currentTimeInMinutes = currentHourInMinutes + this.min;

            if (currentTimeInMinutes > TwentyFourInMinutes)
                return 0;

            return TwentyFourInMinutes - currentTimeInMinutes;


        }

        public void Increment(int n)
        {
            int currentTimeInMinutes = this.hour * 60 + this.min;
            int newTime = currentTimeInMinutes + n;

            this.hour = newTime / 60 % 24;
            this.min = newTime % 60;

        }

        public bool IsEarlier(HW18Clock other)
        {
            int thisTimeInMinutes = this.hour * 60 + this.min;
            int otherTimeInMinutes = other.hour * 60 + other.min;

            return thisTimeInMinutes < otherTimeInMinutes;

        }

        public static HW18Clock WhichClockIsEarlier(HW18Clock[] arr)
        {
            if (arr == null || arr.Length == 0)
                return null;

            HW18Clock earlierClock = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i].IsEarlier(earlierClock))
                    earlierClock = arr[i];

            return earlierClock;
        }

    }
}
