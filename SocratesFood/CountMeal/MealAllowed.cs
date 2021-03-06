﻿using System;
using System.Collections.Generic;

namespace SocratesFoodTest
{
    public class MealAllowed
    {
        private IList<string> mealAllowedContent;

        public MealAllowed(IList<string> mealAllowedContent)
        {
            this.mealAllowedContent = mealAllowedContent;
        }

        internal bool Had(string meal)
        {
            return mealAllowedContent.Contains(meal);
        }
    }
}