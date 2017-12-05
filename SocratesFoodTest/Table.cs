using System;
using System.Collections.Generic;

namespace SocratesFoodTest
{
    public class Table
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

        public static Table Of(string identifiant, string name, string firstname, string meal, MealAllowed mealAllowed)
        {
            if (!mealAllowed.Had(meal))
            {
                throw new GiveTheChoiceException($"The meal {meal} don't respect the meal allowed");
            }
            return new Table(identifiant, name, firstname, meal);
        }

        public override bool Equals(object obj)
        {
            var table = obj as Table;
            return table != null &&
                   Identifiant == table.Identifiant &&
                   name == table.name &&
                   firstname == table.firstname &&
                   Meal == table.Meal;
        }

        public override int GetHashCode()
        {
            var hashCode = -1473146696;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Identifiant);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(firstname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Meal);
            return hashCode;
        }
    }
}