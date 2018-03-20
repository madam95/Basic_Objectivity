
namespace Basic_Objectivity
{
    public struct Point3D
    {
        // Nie mozna inicjowac domyslnych wartosci dla pol w przeciwienstwie do klas
        public double x;
        public double y;
        public double z;

        // Nie mozna stworzyc domyslnego konstruktora w strukturze
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
           

    }
}