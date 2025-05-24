using System;

namespace HomeWork
{
    public class HW15Box
    {
        private string color;
        private int len;
        private int width;
        private int height;
        private double weight;


        public HW15Box(string color, int len, int width, int height, double weight)
        {
            this.color = String.IsNullOrEmpty(color) ? "white" : color;
            this.len = len < 1 ? 1 : len;
            this.width = width < 1 ? 1 : width;
            this.height = height < 1 ? 1 : height;
            this.weight = weight < 1 ? 1 : weight;
        }

        public HW15Box(string color, double weight)
        {
            this.color = String.IsNullOrEmpty(color) ? "white" : color;
            this.len = 1;
            this.width = 1;
            this.height = 1;
            this.weight = weight < 1 ? 1 : weight;

        }

        #region Getters
        public string GetColor()
        {
            return this.color;
        }

        public int GetLen()
        {
            return this.len;
        }

        public int GetWidth()
        {
            return this.width;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public double GetWeight()
        {
            return this.weight;
        }

        #endregion

        #region Setters

        public void SetColor(string color)
        {
            this.color = color;
        }

        public void SetLen(int len)
        {
            this.len = len;
        }

        public void SetWidth(int width)
        {
            this.width = width;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        #endregion

        public static int A(HW15Box[] box)
        {
            if (box == null || box.Length == 0)
                return -1;

            return 1;

        }

        public static HW15Box[] B(HW15Box[] box)
        {
            if (box == null)
                return null;

            if (box.Length == 0)
                return new HW15Box[] { };

            return box;

        }



    }
}
