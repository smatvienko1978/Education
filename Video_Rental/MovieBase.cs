namespace Video_Rental
{
    public class Movie
    {
        private string name;
        private MovieType type;
        public double RentalPrice { get => (double)type; }
        public string Name { get => name; }
        public MovieType Type { get => type; }     
        protected Movie(string name, MovieType type) 
        { 
            this.name = name;
            this.type = type;
        }
        public static Movie NewRelease(string name)
        {
           return new Movie(name, MovieType.NewRelease);
        }
        public static Movie Childrens(string name)
        {
            return new Movie(name, MovieType.Childrens);
        }
        public static Movie Regular(string name)
        {
            return new Movie(name, MovieType.Regular);
        }
    }
}
