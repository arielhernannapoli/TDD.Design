namespace TDD.Design.Model
{
    public class Calculadora
    {
        public int Sumar(int valor1, int valor2)
        {
            return valor1+valor2;
        }

        public int Restar(int valor1, int valor2)
        {
            return valor1-valor2;
        }

        public int Multiplicar(int valor1, int valor2)
        {
            return valor1*valor2;
        }

        public object Dividir(int valor1, int valor2)
        {
            return valor1/valor2;
        }
    }
}
