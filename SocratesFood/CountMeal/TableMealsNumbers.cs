using System.Collections.Generic;
using System.Linq;

namespace SocratesFoodTest
{
    public class TableMealsNumbers
    {
        
       
        private string identifiant;
        private Dictionary<string, int> dictionaryMealAllowed;

        public TableMealsNumbers(string identifiant, Dictionary<string, int> dictionaryMealAllowed)
        {
            this.identifiant = identifiant;
            this.dictionaryMealAllowed = new Dictionary<string, int>(dictionaryMealAllowed);
        }

        

        public override bool Equals(object obj)
        {
            var numbers = obj as TableMealsNumbers;
            return numbers != null &&
                   identifiant == numbers.identifiant &&
                   dictionaryMealAllowed.Count == numbers.dictionaryMealAllowed.Count &&
                   dictionaryMealAllowed.OrderBy(pair => pair.Key).SequenceEqual(numbers.dictionaryMealAllowed.OrderBy(pair => pair.Key)) &&
                   dictionaryMealAllowed.OrderBy(pair => pair.Value).SequenceEqual(numbers.dictionaryMealAllowed.OrderBy(pair => pair.Value));


        }

        public override int GetHashCode()
        {
            var hashCode = -591572883;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(identifiant);
            hashCode = hashCode * -1521134295 + EqualityComparer<Dictionary<string, int>>.Default.GetHashCode(dictionaryMealAllowed);
            return hashCode;
        }
    }
}