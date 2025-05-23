using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class HW15Box
    {
        private string color;
        private int len;
        private int width;
        private int height;
        private double weight;

        public HW15Box(string color,int len ,int width, int height , double weight)
        {
            this.color = color;
            this.len = len;
            this.width = width;
            this.height = height;
            this.weight = weight;
        }

        public HW15Box(string color , double weight)
        { 
            this.color = color;
            this.weight = weight;

        }


    }
}
