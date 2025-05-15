using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW14Human
    {
        private string name;
        private string eyesColor;
        private string skinColor;

        public HW14Human(string name, string eyesColor, string skinColor)
        {
            this.name = name == null ? "anonymous" : name;
            this.eyesColor = eyesColor == null ? "brown" : eyesColor;
            this.skinColor = skinColor == null ? "green" : skinColor;
        }

        public HW14Human(string name , string eyesColor)
        {
            this.name = name == null  ? "anonymous" : name;
            this.eyesColor = eyesColor == null ? "brown" : eyesColor;
            this.skinColor = "green";
        }

        #region Getters
        public string getName()
        {
            return this.name;
        }

        public string getEyesColor()
        {
            return this.eyesColor;
        }

        public string getSkinColor()
        {
            return this.skinColor;
        }

        #endregion
    }


}
