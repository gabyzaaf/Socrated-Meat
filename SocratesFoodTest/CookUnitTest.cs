using NFluent;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocratesFoodTest
{
    class CookUnitTest
    {

        private MealAllowed mealAllowed;
        private Dictionary<string, int> dictionaryMealAllowed;
        [SetUp]
        public void Init()
        {
            IList<string>  mealAllowedContent = new List<string>();
            mealAllowedContent.Add("Meat");
            mealAllowedContent.Add("Fish");
            mealAllowed = new MealAllowed(mealAllowedContent);
            dictionaryMealAllowed = new Dictionary<string, int>();
            dictionaryMealAllowed.Add("Meat", 0);
            dictionaryMealAllowed.Add("Fish", 0);
        }

        [Test]
        public void Should_Obtain_Number_Of_All_The_Fish_For_All_The_Tables()
        {
            IList<Table> tableComposition = new List<Table>();
            tableComposition.Add(Table.Of("Table-1", "Durant", "Damien", "Meat", mealAllowed));
            tableComposition.Add(Table.Of("Table-1", "Durant", "Damien", "Meat", mealAllowed));
            tableComposition.Add(Table.Of("Table-1", "Durant", "Jean", "Fish", mealAllowed));
            tableComposition.Add(Table.Of("Table-8", "Durant", "Jean", "Fish", mealAllowed));
            var tableInformations = new TableInformation(tableComposition);
            Check.That(tableInformations.ObtainNumberFor("Fish")).IsEqualTo(2);

        }

        [Test]
        public void Should_Obtain_Number_Of_All_The_Meat_For_All_The_Tables()
        {
            IList<Table> tableComposition = new List<Table>();
            tableComposition.Add(Table.Of("Table-1", "Durant", "Damien", "Meat", mealAllowed));
            tableComposition.Add(Table.Of("Table-1", "Durant", "Damien", "Meat", mealAllowed));
            tableComposition.Add(Table.Of("Table-1", "Durant", "Jean", "Fish", mealAllowed));
            tableComposition.Add(Table.Of("Table-8", "Durant", "Jean", "Fish", mealAllowed));
            var tableInformations = new TableInformation(tableComposition);
            Check.That(tableInformations.ObtainNumberFor("Meat")).IsEqualTo(2);

        }

        [Test]
        public void Should_Obtain_An_Error_When_The_Meal_Is_Not_Specified_Inside_The_MenuAllowed()
        {
            
            Check.ThatCode(() => {
                Table.Of("Table-1", "Durant", "Damien", "Nothing",mealAllowed);
            }).Throws<GiveTheChoiceException>();
        }

        // TODO: Group by the tables Together with the content of Fish and Meat

        [Test]
        public void Should_Obtain_The_Tables_Food_List()
        {
            IList<Table> tableComposition = new List<Table>();
            tableComposition.Add(Table.Of("Table-1", "Durant", "Damien", "Meat", mealAllowed));
            tableComposition.Add(Table.Of("Table-2", "Lamier", "Lola", "Meat", mealAllowed));
            tableComposition.Add(Table.Of("Table-1", "Durant", "Laurent", "Fish", mealAllowed));

            IList<Table> tableCompositionEstimated = new List<Table>();
            tableCompositionEstimated.Add(Table.Of("Table-1", "Durant", "Damien", "Meat", mealAllowed));
            tableCompositionEstimated.Add(Table.Of("Table-2", "Lamier", "Lola", "Meat", mealAllowed));

            IEnumerable <IGrouping<string,Table>> listComparate = tableComposition.OrderBy(table => table.Identifiant).GroupBy(table => table.Meal);
            List<Table> tables = listComparate.ElementAt(0).ToList();
            Check.That(tables.SequenceEqual(tableCompositionEstimated) && tableCompositionEstimated.SequenceEqual(tables)).IsTrue();
        }
        
       


      [Test]
      public void Should_Obtain_Food_Counting_With_The_MealAllowed()
      {
          IList<Table> tableComposition = new List<Table>();
          tableComposition.Add(Table.Of("Table-1", "Durant", "Damien", "Meat", mealAllowed));
          tableComposition.Add(Table.Of("Table-2", "Lamier", "Lola", "Meat", mealAllowed));
          tableComposition.Add(Table.Of("Table-1", "Durant", "Laurent", "Fish", mealAllowed));
          

          var tableNumberFoodEstimated = new List<TableMealsNumbers>();
          var mealDicoEstimatedForTable1 = new Dictionary<string, int>();
          mealDicoEstimatedForTable1.Add("Meat", 1);
          mealDicoEstimatedForTable1.Add("Fish", 1);
          tableNumberFoodEstimated.Add(new TableMealsNumbers("Table-1",mealDicoEstimatedForTable1));

           var mealDicoEstimatedForTable2 = new Dictionary<string, int>();
           mealDicoEstimatedForTable2.Add("Meat", 1);
           mealDicoEstimatedForTable2.Add("Fish", 0);

            tableNumberFoodEstimated.Add(new TableMealsNumbers("Table-2", mealDicoEstimatedForTable2));

          var tableInformation = new TableInformation(tableComposition);

          List<TableMealsNumbers> tableNumberFood = tableInformation.ObtainMealNumberForAllTheTables(dictionaryMealAllowed);
          Check.That(tableNumberFood.SequenceEqual(tableNumberFoodEstimated) && tableNumberFoodEstimated.SequenceEqual(tableNumberFood)).IsTrue();
      }
      
        


        





    }
}
