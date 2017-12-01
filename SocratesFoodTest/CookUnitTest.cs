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
        [Test]
        public void Should_Create_Informations_And_Valid_Contain_Fish()
        {
            var foodChoice = new List<string>();
            foodChoice.Add("Meat");
            foodChoice.Add("Fish");


            var foodInformation = new List<FoodInformations>();
            foodInformation.Add(new FoodInformations("Table-1", "Damien", "Durant", "Fish"));
            foodInformation.Add(new FoodInformations("Table-1", "Florence", "Dutartre", "Meat"));
            foodInformation.Add(new FoodInformations("Table-1", "Florence", "Dutartre", "Meat"));
            foodInformation.Add(new FoodInformations("Table-2", "Ludovic", "Bretono", "Fish"));
            foodInformation.Add(new FoodInformations("Table-2", "Ludovic", "Bretono", "Nothing"));


            var infos = Substitute.For<IcandidatPlacementFood>();
            infos.ObtainsInformations().Returns(foodInformation);
            FoodManager foodManager = new FoodManager(infos.ObtainsInformations());
            Check.That(foodManager.IsValid(foodChoice)).IsTrue();
        }


    }
}
