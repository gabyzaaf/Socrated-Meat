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
        public void Should_Obtains_The_List_For_Meat()
        {
            IList<Table> tableComposition = new List<Table>();
            tableComposition.Add(Table.Of("Table-1", "Durant", "Damien", "Meat"));
            tableComposition.Add(Table.Of("Table-1", "Durant", "Damien", "Meat"));
            tableComposition.Add(Table.Of("Table-1", "Durant", "Jean", "Fish"));
            var tableInformations = new TableInformation(tableComposition);
            Check.That(tableInformations.ObtainNumberFor("Fish")).IsEqualTo(1);



        }
    }
}
