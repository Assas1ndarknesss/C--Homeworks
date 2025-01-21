
System.Console.Write("FirstNumber: ");
double firstnumber = Convert.ToDouble(Console.ReadLine());
System.Console.Write("SecondNumber: ");
double secondnumber = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Choose simbole -> (+, -, *, /):  ");
string? alomat = Console.ReadLine();
System.Console.Write("Result:");
Calculator calc = new Calculator(firstnumber, secondnumber);
switch (alomat)
{
    case "+":
        System.Console.WriteLine(calc.Sum());
        break;
    case "-":
        System.Console.WriteLine(calc.Subtract());
        break;
    case "*":
        System.Console.WriteLine(calc.Multiplication());
        break;
    case "/":
        System.Console.WriteLine(calc.Division());
        break;
}

class Calculator
{
    private double FirstNumber;
    private double SecondNumber;
    public Calculator(double firstNum, double secondNum)
    {
        this.FirstNumber = firstNum;
        this.SecondNumber = secondNum;
    }


    public double Sum()
    {
        return FirstNumber + SecondNumber;
    }

    public double Subtract()
    {
        return FirstNumber - SecondNumber;
    }
    public double Multiplication()
    {
        return FirstNumber * SecondNumber;
    }
    public double Division()
    {

        if (SecondNumber == 0)
        { return 0; }

        else
        {
            return FirstNumber / SecondNumber;
        }
    }

}
