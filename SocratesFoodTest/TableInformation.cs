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
    }
}