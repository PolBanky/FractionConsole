namespace FractionConsole
{
    class Fraction
    {
        int num, den;
        
        // КОНСТРУКТОР !!! 
        public Fraction()
        {   this.num = 1;
            this.den = 1; }

        // КОНСТРУКТОР !!! 
        public Fraction(int num, int den)
        {   this.num = num;
            this.den = den;
            Cancellation();
        }
        

        // Свойства !!! 

        public int Num
        {get { return num; }}

        public int Den
        {get { return den; }}


        // метод сокращения рациональной дроби
        void Cancellation()
        {
            if (num != 0)
            {
                int m = den, n = num, ost = m % n;
                // вычисление НОД(числителя, знаменателя)
                // алгоритмом Евклида
                while (ost != 0)
                {
                    m = n;
                    n = ost;
                    ost = m % n;
                }
                int nod = n;
                if (nod != 1)
                {
                    num /= nod;
                    den /= nod;
                }
            }
        }           // void Cancellation()


        // overload operator + 
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);
        }   // Fraction operator + 

        // overload operator - 
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den - b.num * a.den, a.den * b.den);
        }   // Fraction operator - 

        // overload operator * 
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.num, a.den * b.den);
        }   // Fraction operator * 

        // overload operator / 
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den, a.den * b.num);
        }   // Fraction operator / 


        // user-defined conversion from Fraction to double
        public static implicit operator double(Fraction f)
        {
            return (double)((double)f.num / (double)f.den);
        }   // conversion from Fraction to double 

        // user-defined conversion from Fraction to double
        public static implicit operator Fraction(int d)
        {
            return new Fraction( d, d);
        }   // conversion from Fraction to double 

    }       // class Fraction
}           // namespace FractionConsole
