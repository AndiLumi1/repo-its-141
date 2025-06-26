namespace LibCalcolatrice
{
    public class Calcolatrice 

    {
        public int Somma(int addendo1, int addendo2)
        {
           return addendo1 + addendo2;
        }
        public int Differenza(int a, int b)
        {
            return a - b;
        }

        public int Prodotto(int a, int b)
        {
            return a * b;
        }

        public int Divisione(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Impossibile dividere per zero.");
            return a / b;
        }
    }
}
