using System.Collections.Generic;

namespace SocratesFoodTest.OrganizeMealForTable
{
    internal class Menu
    {
        public string Entry { get; private set; }
        public string Meal { get; private set; }
        public string Dessert { get; private set; }

        public Menu(string entry, string meal, string dessert)
        {
            this.Entry = entry;
            this.Meal = meal;
            this.Dessert = dessert;
        }

        public override bool Equals(object obj)
        {
            var menu = obj as Menu;
            return menu != null &&
                   Entry == menu.Entry &&
                   Meal == menu.Meal &&
                   Dessert == menu.Dessert;
        }

        public override int GetHashCode()
        {
            var hashCode = 591089238;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Entry);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Meal);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dessert);
            return hashCode;
        }
    }
}