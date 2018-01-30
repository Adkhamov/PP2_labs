using System;
[Serializable]
class Complex
{
    public int a, b;
    public double volue;

    public Complex() { }

    public Complex(int _a, int _b)
    {
        a = _a;
        b = _b;
        double ad = a, bd = b;
        if (a != 0 && b !=0)
        volue = ad / bd;
    }

    public override string ToString()
    {
        return a + "/" + b + "\n volue = " + volue;
    }


    public static Complex operator +(Complex c1, Complex c2)
    {
        int nom = c1.b * c2.b;
        c1.a = c1.a * c2.b;
        c2.a = c2.a * c2.b;
        Complex c = new Complex(c1.a + c2.a, nom);
        c.Simplify();
        return c;
    }

    public static Complex operator -(Complex c1, Complex c2)
    {
        int nom = c1.b * c2.b;
        c1.a = c1.a * c2.b;
        c2.a = c2.a * c2.b;
        Complex c = new Complex(c1.a - c2.a, nom);
        c.Simplify();
        return c;
    }

    public static Complex operator *(Complex c1, Complex c2)
    {
        Complex c = new Complex(c1.a * c2.a, c1.b * c2.b);
        c.Simplify();
        return c;
    }

    public static Complex operator /(Complex c1, Complex c2)
    {
        Complex c = new Complex(c1.a * c2.b, c1.b * c2.a);
        c.Simplify();
        return c;
    }

    public void Simplify()
    {
        int _a = this.a;
        int _b = this.b;
        while (_a > 0 && _b > 0)
        {
            if (_a > _b)
                _a = _a % _b;
            else
                _b = _b % _a;
        }
        int nod = _a + _b;
        a /= nod;
        b /= nod;
    }
}