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
            IList<Table> tableComposition = new List<Table>();
            tableComposition.Add(new Table("Table-1", "Durant", "Damien", "Meat"));
            tableComposition.Add(new Table("Table-1", "Durant", "Jean", "Fish"));
            var tableInformations = new TableInformation(tableComposition);
            Check.That(tableInformations.ObtainTableWith("Table-1").ObtainNumberFor("Fish")).IsEqualTo(1);

        }

        
        


    }
}
