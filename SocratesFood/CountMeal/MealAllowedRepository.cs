using System;
using System.Collections.Generic;

namespace SocratesFoodTest
{
    public class MealAllowedRepository
    {
        private IMealAllowed mealAllowed;

        public MealAllowedRepository(IMealAllowed mealAllowed)
        {
            this.mealAllowed = mealAllowed;
        }

        public MealAllowed ObtainMealAllowed()
        {
            return mealAllowed.ObtainTheMealAllowed();
        }
    }
}