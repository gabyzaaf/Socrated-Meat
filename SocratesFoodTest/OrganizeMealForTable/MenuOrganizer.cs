using System;
using System.Collections.Generic;
using System.Linq;

namespace SocratesFoodTest.OrganizeMealForTable
{
    internal class MenuOrganizer
    {
        private List<MenuInformation> menuInformation;
        private IEnumerable<IGrouping<string, MenuInformation>> menuInformationGrouped;


        public MenuOrganizer(IEnumerable<IGrouping<string, MenuInformation>> dataTried)
        {
            this.menuInformationGrouped = dataTried;
        }

        public MenuOrganizer(List<MenuInformation> menuInformation)
        {
            this.menuInformation = menuInformation;
        }

        public MenuOrganizer ObtainsAllTheTables()
        {
           return new MenuOrganizer(menuInformation.GroupBy(t => t.TableName));
        }

        internal List<MenuInformationOut> DisplayInformations()
        {
            List<MenuInformationOut> menuInformationsOut = new List<MenuInformationOut>();

            foreach (var menuInformationGroup in menuInformationGrouped)
            {
                foreach (var menu in menuInformationGroup)
                {
                    menuInformationsOut.Add(menu.ObtainInfos());
                }
            }
            return menuInformationsOut;
        }
    }
}