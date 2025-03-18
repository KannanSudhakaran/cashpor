namespace CalcuBusinessLogicLib
{
    public class Calculator

    {

        public int Add(int a, int b)
        {
            if(a < 0 || b < 0)
            {
                throw new ArgumentException("Only positive numbers are allowed");
            }
            return a + b;
        }

    }
}
