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
        public void Should_Obtain_Number_Of_All_The_Fish_For_All_The_Tables()
        {
            IList<Table> tableComposition = new List<Table>();
            tableComposition.Add(Table.Of("Table-1", "Durant", "Damien", "Meat"));
            tableComposition.Add(Table.Of("Table-1", "Durant", "Damien", "Meat"));
            tableComposition.Add(Table.Of("Table-1", "Durant", "Jean", "Fish"));
            tableComposition.Add(Table.Of("Table-8", "Durant", "Jean", "Fish"));
            var tableInformations = new TableInformation(tableComposition);
            Check.That(tableInformations.ObtainNumberFor("Fish")).IsEqualTo(2);

        }

        [Test]
        public void Should_Obtain_Number_Of_All_The_Meat_For_All_The_Tables()
        {
            IList<Table> tableComposition = new List<Table>();
            tableComposition.Add(Table.Of("Table-1", "Durant", "Damien", "Meat"));
            tableComposition.Add(Table.Of("Table-1", "Durant", "Damien", "Meat"));
            tableComposition.Add(Table.Of("Table-1", "Durant", "Jean", "Fish"));
            tableComposition.Add(Table.Of("Table-8", "Durant", "Jean", "Fish"));
            var tableInformations = new TableInformation(tableComposition);
            Check.That(tableInformations.ObtainNumberFor("Meat")).IsEqualTo(2);

        }






    }
}
