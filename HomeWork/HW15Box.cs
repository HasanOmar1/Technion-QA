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
            this.color = color;
            this.len = 1;
            this.width = 1;
            this.height = 1;
            this.weight = weight;

        }


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




    }
}
