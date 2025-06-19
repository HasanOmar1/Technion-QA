namespace Objects
{
    public class Clock
    {
        private string color; // צבע השעון
        private int hour; //0-23
        private int min; // 0-59

        // Ctor
        // new Clock(8, 32) ---> hour=8 , min = 32, color = "White!"
        // new Clock(8, -32) ---> hour=8 , min = 0, color = "White!"
        // new Clock(-4, 32) ---> hour=0 , min = 32, color = "White!"
        public Clock(int hour, int min)
        {
            this.hour = (hour < 0 || hour > 23) ? 0 : hour;
            this.min = (min < 0 || min > 59) ? 0 : min;
            this.color = "White!";
        }

        // Same as above, simply gets also the color
        // in case the color is null or empty- we should consider it as "White!"
        public Clock(string color, int hour, int min)
        {
            this.color = string.IsNullOrEmpty(color) ? "White!" : color;
            this.hour = (hour < 0 || hour > 23) ? 0 : hour;
            this.min = (min < 0 || min > 59) ? 0 : min;
        }

        public string getColor()
        {
            return color;
        }

        public int getHour()
        {
            return hour;
        }

        public int getMin()
        {
            return min;
        }



        public static object[] getInfo(Clock clock)
        {
            if (clock == null) return null;

            object[] result = { clock.getColor(), clock.getHour(), clock.getMin() };
            return result;
        }


    }
}
