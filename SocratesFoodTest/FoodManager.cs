using System;
using System.Collections.Generic;

namespace SocratesFoodTest
{
    internal class FoodManager
    {
        private List<FoodInformations> obtainsInformations;

        public FoodManager(List<FoodInformations> obtainsInformations)
        {
            this.obtainsInformations = obtainsInformations;
        }

     

        public bool IsValid(List<string> foodChoice)
        {
            var founded = obtainsInformations.Find(c => !foodChoice.Contains(c.FoodChoosen));
            
            return founded == null;
        }
    }
}