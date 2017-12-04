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

        internal List<TableMealsNumbers> ObtainMealNumberForAllTheTables()
        {
            var items = tableComposition.OrderBy(table => table.Identifiant).GroupBy(table => table.Identifiant);
            string tableName = "";
            int numbersMeat = 0;
            int numbersFish = 0;
            var tableMealsNumbersElements = new List<TableMealsNumbers>();

            foreach (var item in items)
            {
               
                foreach(var element in item)
                {
                    if (element.Meal.Equals("Fish"))
                    {
                        numbersFish++;
                    }
                    else if(element.Meal.Equals("Meat"))
                    {
                        numbersMeat++;
                    }
                    tableName = element.Identifiant;
                }
                tableMealsNumbersElements.Add(new TableMealsNumbers(tableName, numbersMeat, numbersFish));
                numbersFish = 0;
                numbersMeat = 0;
            }

            return tableMealsNumbersElements;
           
        }
    }
}