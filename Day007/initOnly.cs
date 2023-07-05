namespace initOnly
{
    class Transaction : object
    {
        public string From {get;set;}
        public string To { get;set;}
        public string Amount { get;set;}

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Transaction tr1 = new Transaction { From = "Alice", To = "Bob", Amount = "100" };
            Transaction tr2 = new Transaction { From = "Bob", To = "Charlie", Amount = "50" };
            Transaction tr3 = new Transaction { From = "Charlie", To = "Alice", Amount = "30" };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr3);

        }
    }

}
