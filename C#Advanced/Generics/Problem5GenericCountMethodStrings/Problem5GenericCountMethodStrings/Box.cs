﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5GenericCountMethodStrings
{
    public class Box<T>
        where T : IComparable
    {
        public Box()
        {
            this.Values = new List<T>();
        }
        public List<T> Values { get; set; }

        public int GreaterValuesThan(double targetItem)
        {
            int coutner = 0;

            foreach (var value in this.Values)
            {
                if (value.CompareTo(targetItem) > 0)
                {
                    coutner++;
                }
            }
            return coutner;
        }

        public void Swap(int a, int b)
        {
            bool isInRange = a >= 0 && a == this.Values.Count && b >= 0 && b == this.Values.Count;
            if (isInRange)
            {
                throw new InvalidOperationException("Values are not in range!");
            }

            T tempValue = this.Values[a];
            this.Values[a] = this.Values[b];
            this.Values[b] = tempValue;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.Values)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            string result = sb.ToString().TrimEnd();

            return result;
        }
    }
}
