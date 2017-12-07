using System;
using System.Collections.Generic;
using System.Linq;

namespace SocratesFoodTest.OrganizeMealForTable
{
    internal class MenuOrganizer
    {
        private List<MenuInformation> menuInformation;

        public MenuOrganizer(List<MenuInformation> menuInformation)
        {
            this.menuInformation = menuInformation;
        }

        internal IEnumerable<IGrouping<string, MenuInformation>> ObtainsAllTheTables()
        {
           return menuInformation.GroupBy(t => t.TableName);
        }
    }
}