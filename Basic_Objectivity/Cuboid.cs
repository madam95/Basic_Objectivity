namespace Basic_Objectivity
{
    // Klasa to typ referencyjny
    public class Cuboid
    {
        private int a;
        private int b;
        private int h;

        // Pola statyczne sa wspoldzielone przez wszystkie obiekty stworzone w tej klasie
        public static int numCuboid = 0;

        public Cuboid()
        {
            a = 0;
            b = 0;
            h = 0;
            numCuboid++;
        }

        public Cuboid(int a, int b, int h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
            numCuboid++;
        }

        public int Volume()
        {
            return a * b * h;
        }

        public static string ShowNumCuboid()
        {
            return "Number of Cuboids: " + numCuboid.ToString();
        }

    }
}