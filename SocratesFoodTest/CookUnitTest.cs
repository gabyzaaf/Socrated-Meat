using NFluent;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocratesFoodTest
{
    class CookUnitTest
    {

        private MealAllowed mealAllowed;
        [SetUp]
        public void Init()
        {
            IList<string>  mealAllowedContent = new List<string>();
            mealAllowedContent.Add("Meat");
            mealAllowedContent.Add("Fish");
            mealAllowed = new MealAllowed(mealAllowedContent);
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
        public void SHould_Obtain_An_Error_When_The_Meal_Is_Not_Specified_Inside_The_MenuAllowed()
        {
            
            Check.ThatCode(() => {
                Table.Of("Table-1", "Durant", "Damien", "Nothing",mealAllowed);
            }).Throws<GiveTheChoiceException>();
        }






    }
}
