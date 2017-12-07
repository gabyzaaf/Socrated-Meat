using NFluent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocratesFoodTest.OrganizeMealForTable
{
    class MenuOrganiserTest
    {
        [Test]
        public void Should_Group_The_Menu_By_Table()
        {

            var menuInformation = new List<MenuInformation>();
            menuInformation.Add(new MenuInformation("Table-1","Dani","Durant","Carot","Meat","Chocolate"));
            menuInformation.Add(new MenuInformation("Table-1", "Johnny", "Halliday", "Carot", "Meat", "Chocolate"));
            menuInformation.Add(new MenuInformation("Table-2", "David", "Halliday", "Carot", "Fish", "Chocolate"));

            var menuInformationAttended = new List<MenuInformation>();
            MenuOrganizer organizer = new MenuOrganizer(menuInformation);
            var datasExpected = organizer.ObtainsAllTheTables();
            Check.That(datasExpected).IsEqualTo(menuInformationAttended);
        }
    }
}
