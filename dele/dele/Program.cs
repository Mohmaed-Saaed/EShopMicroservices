namespace dele
{
    internal class Program
    {
        delegate int del(int x, int y);
        delegate string HiToName (string name);
        delegate void sayMyName(string name);
        delegate void sayHello();
        static void Main(string[] args)
        {
            //del del = delegate (int x, int y) { return x + y; }; // This is called anynymous method

            //HiToName hiTo =  (string name) => "hi " + name;

            //del del2 = (int x, int y) => x - y;
            //This is the lmbda expression for anynmous method

            //HiToName hi = new HiToName(sayHi);

            // Func alweays return a datatype takes up to 17 parameter
            // action doesn't return a type 
            // Predicate takes only one parameter and returns true or false.


            Func<double> name =  () => 10 / 2;
            Action<int> action = (int ac) => Console.WriteLine(ac);

            //Predicate<int> predicate = (int x) => x % 2 == 0;
            Func<int, bool> predicate = (int x) => x % 2 == 0;

            Console.WriteLine(predicate(2));

            //lambda expression is abbreviation for anynoums method method without a name;
            //delegates allows us to paramatrize code to send a function into a parameter and call it inside.


            //sayHello();
        }

        //public static void SayName(string name)
        //{
        //    Console.WriteLine(name);
        //}
    }
}
