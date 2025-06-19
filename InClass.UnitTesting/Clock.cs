namespace Objects
{
    public class Clock
    {
        // Private variables
        private int hour;  // 0-23
        private int min;   // 0-59


        // Getters
        public int getHour()
        {
            return hour;
        }

        public int getMin()
        {
            return min;
        }


        //Ctor
        // אם ספרת השעות או הדקות - אינן חוקיות יש להחשיבן כאפס
        // new Clock(15, 16) ===> hour=15 , min=16
        // new Clock(158, 16) ===> hour=0 , min=16
        // new Clock(2, -416) ===> hour=2 , min=0
        // new Clock(3242, 453534) ===> hour=0 , min=0
        public Clock(int hour, int min)
        {
            this.hour = (hour < 0 || hour > 23) ? 0 : hour;
            this.min = (min < 0 || min > 59) ? 0 : min;
        }


        // Calc the number of min till midnight
        // if the time is 23:59 ====> 1 min left till midnight
        // if the time is 20:45 ====> 195 min left till midnight
        // if the time is 18:00 ====> 360 min left till midnight
        public int calcNumOfMinTillMidnight()
        {
            return (24 * 60 - (hour * 60 + min));
        }


        // הפעולה מקבלת מערך של שעונים, ובנוסף שעון התחלה ושעון סיום.
        // צריך לספור את מספר השעונים שנמצאים בטווח הנתון כולל קצוות.
        // למשל:
        // אם השעונים הנתונים הם: 
        // new Clock[]{ new Clock(16, 2), new Clock(23, 13), new Clock(32423, 32432) , new Clock(0, 7) }
        // ונניח ששעון ההתחלה הוא 
        // new Clock(0, 0)
        // ונניח ששעון הסיום הוא 
        // new Clock(1, 2)
        // במצב שכזה הפלט אמור להיות 2

        // If one of the inputs are null- the method should return 0
        public static int countNumberOfClocksInInputInterval(Clock[] clocks,
                                                             Clock start,
                                                             Clock end)
        {
            return -1; // כרגע אין מימוש
        }

        public static Clock getEarliestClock(Clock[] clocks)
        {
            return null; // כרגע אין מימוש
        }


        public bool isEarlier(Clock other)
        {
            return false; // כרגע אין מימוש
        }


        public void modifyTime(int n)
        {
            // כרגע אין מימוש
        }

    }
}
