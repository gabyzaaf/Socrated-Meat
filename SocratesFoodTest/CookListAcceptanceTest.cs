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
        [Test]
        public void Should_Obtains_The_List_For_Meat_And_Fish()
        {
            var foodChoice = new List<string>();
            foodChoice.Add("Meat");
            foodChoice.Add("Fish");


            var foodInformation = new List<FoodInformations>();
            foodInformation.Add(new FoodInformations("Table-1", "Damien", "Durant", "Carote", "Fish", "Chocolate"));
            foodInformation.Add(new FoodInformations("Table-1", "Florence", "Dutartre", "Carote", "Meat", "Chocolate"));
            foodInformation.Add(new FoodInformations("Table-1", "Florence", "Dutartre", "Carote", "Meat", "Chcolate"));
            foodInformation.Add(new FoodInformations("Table-2", "Ludovic", "Bretono", "Carote", "Fish", "Chocolate"));
            //foodInformation.Add(new FoodInformations("Table-2", "Ludovic", "Bretono", "Carote", "Nothing", "Chocolate"));



            var infos = Substitute.For<IcandidatPlacementFood>();
            infos.ObtainsInformations().Returns(foodInformation);
            FoodManager foodManager = new FoodManager(infos.ObtainsInformations());
            Check.That(foodManager.IsValid(foodChoice)).IsTrue();


        }
    }
}
