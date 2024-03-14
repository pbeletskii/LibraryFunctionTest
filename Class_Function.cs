namespace LibraryFunctionTest
{
    public class Class_Function
    {
        public double f(double x, double k, double N)
        {
            double y = -1;
            if (x == N)
                throw new DivideByZeroException("Деление на ноль");
            if (x > k)
                throw new ArgumentOutOfRangeException("Выход за диапозон значений");
            try
            {
                for (x = x; x < k && x != N; x += 0.1)
                {
                    y = 1 / (x - N);
                }
                return y;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}