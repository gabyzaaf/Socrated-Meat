namespace SocratesFoodTest
{
    public class FoodInformations
    {
        private readonly string tableName;
        private readonly string candidateName;
        private readonly string candidateFirstname;

        public string FoodChoosen { get; private set; }
        public string DessertChoosen { get; private set; }
        public  string EntryChoosen { get; private set; }
       
        
       

        public FoodInformations(string tableName, string candidateName, string candidateFirstname, string entryChoosen, string FoodChoosen, string DessertChoosen) 
        {
            this.tableName = tableName;
            this.candidateName = candidateName;
            this.candidateFirstname = candidateFirstname;
            this.EntryChoosen = entryChoosen;
            this.FoodChoosen = FoodChoosen;
            this.DessertChoosen = DessertChoosen;
        }
    }
}