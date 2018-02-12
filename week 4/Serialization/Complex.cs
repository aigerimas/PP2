[Serializable]
class Complex
{
    public int a;
    public int b;
    public Complex() { }
    public Complex(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public static Complex operator +(Complex c1, Complex c2)
    {
        int lcm = Math.Max(c1.b, c2.b);
        bool b = true;
        while (b)
        {
            if (!(lcm % c1.b == 0 && lcm % c2.b == 0))
                lcm++;
            else
                b = false;
        }
        int numerator = lcm / c1.b * c1.a + lcm / c2.b * c2.a;
        Complex c = new Complex(numerator, lcm);
        return c;
    }
    public override string ToString()
    {
        return a + "/" + b;
    }
}
