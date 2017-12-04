using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NFluent;
using System.Collections.Generic;
using NSubstitute;

namespace SocratesFoodTest
{

    public class CookListAcceptanceTest
    {
        private MealAllowed mealAllowed;
        [SetUp]
        public void Init()
        {
            IList<string> mealAllowedContent = new List<string>();
            mealAllowedContent.Add("Meat");
            mealAllowedContent.Add("Fish");
            mealAllowed = new MealAllowed(mealAllowedContent);
        }

        [Test]
        public void Should_Obtains_The_List_For_Meat()
        {
            IList<Table> tableComposition = new List<Table>();
            tableComposition.Add(Table.Of("Table-1", "Durant", "Damien", "Meat", mealAllowed));
            tableComposition.Add(Table.Of("Table-1", "Durant", "Damien", "Meat", mealAllowed));
            tableComposition.Add(Table.Of("Table-1", "Durant", "Jean", "Fish", mealAllowed));
            var tableInformations = new TableInformation(tableComposition);
            Check.That(tableInformations.ObtainNumberFor("Fish")).IsEqualTo(1);
        }
    }
}
