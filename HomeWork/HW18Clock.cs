namespace HomeWork
{
    public class HW18Clock
    {
        private int hour; // hours 0-23
        private int min; // minutes 0-59


        public HW18Clock(int hour, int min)
        {
            this.hour = hour;
            this.min = min;

        }

        public int getHour()
        {
            return this.hour;
        }

        public int getMin()
        {
            return this.min;
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


    }




}
