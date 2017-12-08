using System;

namespace SocratesFoodTest.OrganizeMealForTable
{
    internal class MenuInformation
    {
        public string TableName { get; private set; }
        private string name;
        private string firstname;
        private string entry;
        private string meal;
        private string dessert;

        public MenuInformation(string tableName, string name, string firstname, string entry, string meal, string dessert)
        {
            this.TableName = tableName;
            this.name = name;
            this.firstname = firstname;
            this.entry = entry;
            this.meal = meal;
            this.dessert = dessert;
        }

        internal MenuInformationOut ObtainInfos()
        {
            return new MenuInformationOut(TableName, name, firstname, new Menu(entry, meal, dessert));
        }
    }
}