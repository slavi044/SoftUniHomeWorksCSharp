﻿namespace PlayersAndMonsters.Models.Cards
{
    using PlayersAndMonsters.Models.Cards.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Card : ICard
    {
        private string name;
        private int damagePoints;
        private int healthPoints;

        protected Card(string name, int damagePoints, int healthPoints)
        {
            this.Name = name;
            this.DamagePoints = damagePoints;
            this.HealthPoints = healthPoints;
        }


        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Card's name cannot be null or an empty string.");
                }

                name = value; 
            }
        }

        public int DamagePoints
        {
            get { return damagePoints; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Card's damage points cannot be less than zero.");
                }

                damagePoints = value; 
            }
        }


        public int HealthPoints 
        {
            get { return healthPoints; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Card's HP cannot be less than zero.");
                }

                healthPoints = value;
            }
        }
    }
}
