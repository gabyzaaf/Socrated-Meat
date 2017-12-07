using System;
using System.Collections.Generic;
using System.Linq;

namespace SocratesFoodTest
{
    public class TableInformation
    {
        
        private IList<Table> tableComposition;

       

        public TableInformation(IList<Table> tableComposition)
        {
            this.tableComposition = tableComposition;
        }

       



       

        

        public List<TableMealsNumbers> ObtainMealNumberForAllTheTables(Dictionary<string, int> dictionaryMealAllowed)
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