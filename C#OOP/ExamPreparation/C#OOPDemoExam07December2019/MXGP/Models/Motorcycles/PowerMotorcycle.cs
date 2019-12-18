﻿namespace MXGP.Models.Motorcycles
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PowerMotorcycle : Motorcycle
    {
        private const int minHP = 50;
        private const int maxHP = 69;
        private int horsePower;

        public PowerMotorcycle(string model, int horsePower)
            :base(model, horsePower, 450)
        {

        }
        public override int HorsePower 
        {
            get { return horsePower; }
            protected set 
            {
                if (value > maxHP || value < minHP)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }

                horsePower = value;
            }
        }
    }
}