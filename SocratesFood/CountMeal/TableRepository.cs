using System;
using System.Collections.Generic;

namespace SocratesFoodTest
{
    public class TableRepository
    {
        private ITables element;

        public TableRepository(ITables element)
        {
            this.element = element;
        }

        public List<Table> ObtainTableList()
        {
            return element.ObtainsTheTables();
        }
    }
}