namespace OperatorOverloading;

public class Fraction
{
    private readonly int _numerator; // 1/2
    private readonly int _denominator; // 3/4

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // + -  / *

    public static Fraction operator +(Fraction a, Fraction b) //1/2 + 3/4
    {
        int tmp = LCM(a._denominator, b._denominator);
        int tmpRes1 = tmp / a._denominator * a._numerator;
        int tmpRes2 = tmp / b._denominator * b._numerator;

        return new Fraction(tmpRes1 + tmpRes2, tmp);
    }

    public static Fraction operator -(Fraction a, Fraction b) //1/2 + 3/4
    {
        int tmp = LCM(a._denominator, b._denominator);
        int tmpRes1 = tmp / a._denominator * a._numerator;
        int tmpRes2 = tmp / b._denominator * b._numerator;

        return new Fraction(tmpRes1 - tmpRes2, tmp);
    }

    public static Fraction operator *(Fraction a, Fraction b) //1/2 * 3/4
    {
        return new Fraction(a._numerator * b._numerator,
            a._denominator * b._denominator);
    }

    public static Fraction operator /(Fraction a, Fraction b) //1/2 / 3/4
    {
        return new Fraction(a._numerator * b._denominator,
            a._denominator * b._numerator);
    }

    public static bool operator ==(Fraction a, Fraction b) //2/4 1/2
    {
       return a._numerator * b._denominator == a._denominator * b._numerator;
    }

    public static bool operator !=(Fraction a, Fraction b)
    {
        return a._numerator * b._denominator != a._denominator * b._numerator;
    }
   
    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }

    private static int LCM(int a, int b)
    {
        int mx = b, mn = a;
        if (a > b)
        {
            mx = a;
            mn = b;
        }

        for (int i = 1; i <= mx; i++)
        {
            if (i * mn % mx == 0)
            {
                return i * mn;
            }
        }

        return mx * mn;
    }
}