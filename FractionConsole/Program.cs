namespace FractionConsole
{
    class Test : ConLib.Lib
    {
        static void Main( )
        {
            int num, den;
            char ch1 = ' ';

            initialize( 120, 50);

            Promt("Type the numerator of the first fraction: ", out num);            
            Promt("Type the denominator of the first fraction: ", out den);
            Fraction a = new Fraction(num,den);
            s(" Fraction a = ", a.Num, "/", a.Den, " == ", (double)a);

            do {
                Promt("\nType the sign (+-*/) for arithmetic operation: ", out ch1);
                s("Sign is: ", ch1);
            } while ((ch1 != '+') & (ch1 != '-') & (ch1 != '*') & (ch1 != '/'));

            Promt("\nType the numerator of the second fraction: ", out num);
            Promt("Type the denominator of the second fraction: ", out den);
            Fraction b = new Fraction(num, den);
            s(" Fraction b = ", b.Num, "/", b.Den, " == ", (double)b);

            Fraction d = 1;
            Continue();

            switch (ch1)
            { 
                case '+':
                    d = a + b;
                    s(" Fraction d = a + b  == ", d.Num, "/", d.Den, " == ", (double)d);
                    break;
                case '-':
                    d = a - b;
                    s(" Fraction d = a - b  == ", d.Num, "/", d.Den, " == ", (double)d);
                    break;
                case '*':
                    d = a * b;
                    s(" Fraction d = a * b  == ", d.Num, "/", d.Den, " == ", (double)d);
                    break;
                case '/':
                    d = a / b;
                    s(" Fraction d = a / b  == ", d.Num, "/", d.Den, " == ", (double)d);
                    break;
                default:
                    s("Sign is false");
                    break;
            }   // switch (ch1) 
                        
            Exit();
        }   // Main( )
    }       // class Test 
}           // namespace FractionConsole
