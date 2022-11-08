internal class Program
{
    static int GCD(int a, int b){
        int t;
        while(b > 0){
            t = b;
            b = a % b;
            a = t;
        }
        return a;
    }
    private static void Main(string[] args)
    {
        int numProd = 1, denProd = 1;
        for(int digit = 1; digit <= 9; digit++)
        {
            int decDigit = 10*digit;
            for(int den1 = 2; den1 <= 9; den1++)
            {
                int den2l = decDigit + den1;
                int den2r = 10*den1 + digit; 
                for(int num1 = 1; num1 < den1; num1++)
                {
                    //num1/den1 would be a fraction less than one in value
                    int num2l = decDigit + num1;
                    int num2r = num1*10 + digit;

                    //Check all 4 possibilities
                    if(num1 * den2l == num2l * den1){
                        Console.WriteLine($"{num2l}/{den2l} == {num1}/{den1}");
                        numProd *= num2l;
                        denProd *= den2l;
                    } else if(num1 * den2r == num2l * den1){
                        Console.WriteLine($"{num2l}/{den2r} == {num1}/{den1}");
                        numProd *= num2l;
                        denProd *= den2r;
                    } else if(num1 * den2l == num2r * den1){
                        Console.WriteLine($"{num2r}/{den2l} == {num1}/{den1}");
                        numProd *= num2r;
                        denProd *= den2l;
                    } else if(num1 * den2r == num2r * den1){
                        Console.WriteLine($"{num2r}/{den2r} == {num1}/{den1}");
                        numProd *= num2r;
                        denProd *= den2r;
                    }

                }
            }
        }
        Console.WriteLine($"{numProd}/{denProd}");
        int div = GCD(denProd, numProd);
        Console.WriteLine($"{numProd/div}/{denProd/div}");
    }
}