using System.Collections.Generic;

namespace SocratesFoodTest.OrganizeMealForTable
{
    internal class MenuInformationOut
    {
        public string TableName { get; private set; }
        public string Name { get; private set; }
        public string Firstname { get; private set; }
        public Menu Menu { get; private set; }

        public MenuInformationOut(string tableName, string name, string firstname, Menu menu)
        {
            this.TableName = tableName;
            this.Name = name;
            this.Firstname = firstname;
            this.Menu = menu;
        }

        public override bool Equals(object obj)
        {
            var @out = obj as MenuInformationOut;
            return @out != null &&
                   TableName == @out.TableName &&
                   Name == @out.Name &&
                   Firstname == @out.Firstname &&
                   EqualityComparer<Menu>.Default.Equals(Menu, @out.Menu);
        }

        public override int GetHashCode()
        {
            var hashCode = -1930087002;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TableName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Firstname);
            hashCode = hashCode * -1521134295 + EqualityComparer<Menu>.Default.GetHashCode(Menu);
            return hashCode;
        }
    }
}