﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhuzinaDR.Sprint4.Task6.V13.Lib
{
    public class DataService : ISprint4Task6V13
    {
        public int Calculate(string[] array)
        {
            int count = 0;
            foreach (string brand in array)
            {
                if (brand.Length > 4)
                {
                    count++;
                }
            }



            return count;
        }
    }
}