namespace Basic_Objectivity
{
    
    public static class Aritmetics
    {
        // Jesli w klasie znajduje sie statyczny kosntruktor, zostanie on wywolany przed utworzeniem jakiegokolwiek egzemplarza klasy
        // Nie mozna dokladnie okreslic momentu wywolania konstruktora statycznego, ale wiadomo, ze ma to miejsce po uruchomieniu programu,
        // ale przed utworzeniem egzemplarza tej klasy. Konstruktor statyczny nie moze miec zadnego modyfikatora dostepu.

        // Const tez jest polem statycznym, ale jego wartosc nigdy nie ulegnie zmianie
        public const double PI = 3.14;

        // Statyczna metoda nie moze korzystac z zadnych pol w klasie, chyba ze tez sa statyczne. Niestatyczne wymagaja utworzenia obiektu.
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }
    }
}