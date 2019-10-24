namespace RestCoinService.Model
{
    public class Coin
    {
        private int _id;
        private string _genstand;
        private int _bud;
        private string _navn;


        //blank constructor for REST årsager
        public Coin()
        {
            
        }

        public Coin(int newid, string newgenstand, int newbud, string newnavn)
        {
            Id = newid;
            Genstand = newgenstand;
            Bud = newbud;
            Navn = newnavn;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Genstand
        {
            get { return _genstand; }
            set { _genstand = value; }
        }

        public int Bud
        {
            get { return _bud; }
            set { _bud = value; }
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
    }
}