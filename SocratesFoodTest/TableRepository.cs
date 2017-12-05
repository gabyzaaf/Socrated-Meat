using System;
using System.Collections.Generic;

namespace SocratesFoodTest
{
    internal class TableRepository
    {
        private ITables element;

        public TableRepository(ITables element)
        {
            this.element = element;
        }

        internal List<Table> ObtainTableList()
        {
            return element.ObtainsTheTables();
        }
    }
}