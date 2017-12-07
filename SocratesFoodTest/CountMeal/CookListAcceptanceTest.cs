using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NFluent;
using System.Collections.Generic;
using NSubstitute;
using System.Linq;

namespace SocratesFoodTest
{

    public class CookListAcceptanceTest
    {
        private MealAllowed mealAllowed;
        private Dictionary<string, int> dictionaryMealAllowed = new Dictionary<string, int>();
        private List<TableMealsNumbers> tableNumberFoodEstimated = new List<TableMealsNumbers>();


        [SetUp]
        public void Init()
        {
            IList<string> mealAllowedContent = new List<string>();
            mealAllowedContent.Add("Meat");
            mealAllowedContent.Add("Fish");
            mealAllowed = new MealAllowed(mealAllowedContent);
            dictionaryMealAllowed.Add("Meat", 0);
            dictionaryMealAllowed.Add("Fish", 0);

            
            var mealDicoEstimatedForTable1 = new Dictionary<string, int>();
            mealDicoEstimatedForTable1.Add("Meat", 1);
            mealDicoEstimatedForTable1.Add("Fish", 1);
            tableNumberFoodEstimated.Add(new TableMealsNumbers("Table-1", mealDicoEstimatedForTable1));

            var mealDicoEstimatedForTable2 = new Dictionary<string, int>();
            mealDicoEstimatedForTable2.Add("Meat", 1);
            mealDicoEstimatedForTable2.Add("Fish", 0);
            tableNumberFoodEstimated.Add(new TableMealsNumbers("Table-2", mealDicoEstimatedForTable2));
        }

        [Test]
        public void Should_Create_Your_Composition_With_The_Abstraction_For_The_MealEstimated()
        {
            var element = NSubstitute.Substitute.For<ITables>();

            var mealAllowedAbstraction = NSubstitute.Substitute.For<IMealAllowed>();

            mealAllowedAbstraction.ObtainTheMealAllowed().Returns(mealAllowed);

            var listReturned = new List<Table>();

            var mealAllowedRepository = new MealAllowedRepository(mealAllowedAbstraction);

            listReturned.Add(Table.Of("Table-1", "Durant", "Damien", "Meat", mealAllowedRepository.ObtainMealAllowed()));
            listReturned.Add(Table.Of("Table-2", "Lamier", "Lola", "Meat", mealAllowedRepository.ObtainMealAllowed()));
            listReturned.Add(Table.Of("Table-1", "Durant", "Laurent", "Fish", mealAllowedRepository.ObtainMealAllowed()));

            


            element.ObtainsTheTables().Returns(listReturned);
            var tableRepository = new TableRepository(element);
            List<Table> tableInformations = tableRepository.ObtainTableList();
            var tableInformation = new TableInformation(tableInformations);
            List<TableMealsNumbers> tableNumberFood = tableInformation.ObtainMealNumberForAllTheTables(dictionaryMealAllowed);
            Check.That(tableNumberFood.SequenceEqual(tableNumberFoodEstimated) && tableNumberFoodEstimated.SequenceEqual(tableNumberFood)).IsTrue();
        }

    }
}
