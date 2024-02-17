using System;


namespace CalculatorProject
{

    class clsCalculator
    {
        private double _Result = 0;
        private string _Operation = string.Empty;
        private double _Value;
        public void Add(double value)
        {
            _Value = value;
            this._Result += value;
            _Operation = "Add";
        }

        public void Divide(double value)
        {
            _Value = value;
            this._Result /= value == 0 ? 1 : value;
            _Operation = "Divide";
        }

        public void Sub(double value)
        {
            _Value = value;
            this._Result -= value;
            _Operation = "Subtracting";
        }

        public void Mul(double value)
        {
            _Value = value;
            this._Result *= value;
            _Operation = "Multiplying";
        }
        public void PrintResult()
        {
            Console.WriteLine("_Result After {0} {1} is : {2}", this._Operation, _Value, this._Result);
        }

        public void Clear()
        {
            _Operation = string.Empty;
            _Result = 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsCalculator Calculator = new clsCalculator();
            
            Calculator.Clear();
            Calculator.PrintResult();


            Calculator.Add(10);
            Calculator.PrintResult();

            Calculator.Divide(0);
            Calculator.PrintResult();

            Calculator.Sub(1);
            Calculator.PrintResult();

            Calculator.Mul(55);
            Calculator.PrintResult();

        }


    }
}