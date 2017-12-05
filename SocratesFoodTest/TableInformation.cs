using System;
using System.Collections.Generic;
using System.Linq;

namespace SocratesFoodTest
{
    internal class TableInformation
    {
        
        private IList<Table> tableComposition;

       

        public TableInformation(IList<Table> tableComposition)
        {
            this.tableComposition = tableComposition;
        }

        public TableInformation ObtainTableWith(string identifiant)
        {
           return new TableInformation(new List<Table>(tableComposition.Where(c => c.Identifiant.Equals(identifiant))));
        }



        public int ObtainNumberFor(string food) => tableComposition.Where(table => table.Meal.Equals(food)).Count();

        

        internal List<TableMealsNumbers> ObtainMealNumberForAllTheTables(Dictionary<string, int> dictionaryMealAllowed)
        {
            var items = tableComposition.OrderBy(table => table.Identifiant).GroupBy(table => table.Identifiant);
            var tableMealsNumbersElements = new List<TableMealsNumbers>();
            string tableName = "";
            foreach (var item in items)
            {
                foreach (var element in item)
                {
                    if (dictionaryMealAllowed.ContainsKey(element.Meal))
                    {
                        dictionaryMealAllowed[element.Meal]++;
                    }
                    tableName = element.Identifiant;
                }
                tableMealsNumbersElements.Add(new TableMealsNumbers(tableName, dictionaryMealAllowed));
                dictionaryMealAllowed = dictionaryMealAllowed.ToDictionary(p => p.Key, p => 0);
            }
            return tableMealsNumbersElements;

        }
    }
}