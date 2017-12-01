namespace SocratesFoodTest
{
    public class FoodInformations
    {
        private readonly string tableName;
        private readonly string candidateName;
        private readonly string candidateFirstname;
        public  string FoodChoosen { get; private set; }
       
        
        public FoodInformations(string tableName, string candidateName, string candidateFirstname, string foodChoosen)
        {
            this.tableName = tableName;
            this.candidateName = candidateName;
            this.candidateFirstname = candidateFirstname;
            this.FoodChoosen = foodChoosen;
        }


    }
}