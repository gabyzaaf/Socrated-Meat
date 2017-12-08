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
        List<MenuInformation> menuInformation = new List<MenuInformation>();
        [SetUp]
        public void Init()
        {
            menuInformation = new List<MenuInformation>();
            menuInformation.Add(new MenuInformation("Table-1", "Dani", "Durant", "Carot", "Meat", "Chocolate"));
            menuInformation.Add(new MenuInformation("Table-1", "Johnny", "Halliday", "Carot", "Meat", "Chocolate"));
            menuInformation.Add(new MenuInformation("Table-2", "David", "Halliday", "Carot", "Fish", "Chocolate"));
        }

        [Test]
        public void Should_Group_The_Menu_By_Table()
        {
            var menuInformationAttended = new List<MenuInformationOut>();
            menuInformationAttended.Add(new MenuInformationOut("Table-1", "Dani", "Durant",new Menu("Carot", "Meat", "Chocolate")));
            menuInformationAttended.Add(new MenuInformationOut("Table-1", "Johnny", "Halliday", new Menu("Carot", "Meat", "Chocolate")));
            menuInformationAttended.Add(new MenuInformationOut("Table-2", "David", "Halliday", new Menu("Carot", "Fish", "Chocolate")));
            MenuOrganizer organizer = new MenuOrganizer(menuInformation);
            var datasExpected = organizer.ObtainsAllTheTables();
            var mio = datasExpected.DisplayInformations();


            Check.That(mio.SequenceEqual(menuInformationAttended) && menuInformationAttended.SequenceEqual(mio)).IsTrue();
        }
    }
}
