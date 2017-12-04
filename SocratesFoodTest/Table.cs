﻿using System;

namespace SocratesFoodTest
{
    internal class Table
    {
        public string Identifiant { get; set; }
        private string name;
        private string firstname;
        public string Meal { get; set; }

        private Table(string identifiant, string name, string firstname, string meal)
        {
            this.Identifiant = identifiant;
            this.name = name;
            this.firstname = firstname;
            this.Meal = meal;
        }

        public static Table Of(string identifiant, string name, string firstname, string meal)
        {
            return new Table(identifiant, name, firstname, meal);
        }
    }
}