using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Linq;

namespace HelloWorld
{
    /*
    // Print Hello
    public class Hello
    {
        static void Main()
        {
            Console.WriteLine("Hello World");
        }
    }
    */


    /*
    // Types of Variables
    public class Variables
    {
        public static void Main()
        {
            int x = 4;
            double y = 3.3;
            char t = 'a';
            const int FREQUENCIA = 60;

            double area = x * y;

            Console.WriteLine($"Area é igual a: {area}");
            Console.WriteLine("Frequencia é igual a: " + FREQUENCIA);
            Console.WriteLine("Exemplo de char: " + t);
        }
    }
    */


    /*
    // Implicity and Explicit conversion
    public class Converter
    {
        public static void Main()
        {
            
            //Implicita
            int x = 4;
            double y = x;
            Console.WriteLine(y);

            //Explicita
            double nota = 8.6;
            int decresimo = 2;
            int nota_real = (int)nota - decresimo;
            Console.WriteLine(nota_real);

            Console.WriteLine("Digite o Número da sua casa:");
            string num_casa = Console.ReadLine();
            int numero = int.Parse(num_casa);
            Console.WriteLine("Número da sua casa é {0}", numero);
            numero = Convert.ToInt32(num_casa);
            Console.WriteLine(numero);
        }
    }
    */


    /*
    // Format String
    class Formatacao
    {
        public static void Main()
        {
            double x = 20.368;
            Console.WriteLine(x.ToString("F1"));    //1 Casa Decimal
            Console.WriteLine(x.ToString("C"));     //Em Real R$
            Console.WriteLine(x.ToString("P"));     //Porcentagem
        }
    }
    */


    /*
    // Print and Read User console
    class Usuario
    {
        public static void Main()
        {
            Console.WriteLine("Qual o seu Nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu nome é {0} e sua idade é {1}", nome, idade);
        }
    }
    */


    /*
    // Print Variables
    class Inferencia
    {
        public static void Main()
        {
            var nome = "Guilherme";
            var idade = 22;
            Console.WriteLine("Seu nome é {0} e sua idade é {1}", nome, idade);
        }
    }
    */


    /*
    // Pow Method
    public class Potencia
    {
        static void Main()
        {
            Console.WriteLine("Insira o Número que será Elevado ao Quadrado: ");
            int number = int.Parse(Console.ReadLine());
            double powRes = Math.Pow(number, 2);
            Console.WriteLine($"O número {number} elevado ao quadrado é igual a: {powRes}");
        }
    }
    */


    /*
    // Get remainder 
    public class Resto
    {
        static void Main()
        {
            double res1 = 10 % 5;
            double res2 = 9 % 5;
            Console.WriteLine($"Resto 10/5: {res1}");
            Console.WriteLine($"Resto 9/5: {res2}");
        }
    }
    */


    /*
    // Relational Operators (<, >, =, !=, ==, <=, >=)
    public class OperadoresRelacionais
    {
        static void Main()
        {
            Console.WriteLine("Insira sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            Console.WriteLine("Nota menor do que 7 : {0}", nota < 7);
            Console.WriteLine("Nota maior do que 7 : {0}", nota > 7);
            Console.WriteLine("Nota igual a 7 : {0}", nota == 7);
            Console.WriteLine("Nota diferente de 7 : {0}", nota != 7);
        }
    }
    */


    /*
    // Logical Operators (||, &&, !)
    public class OperadorLogicos
    {
        static void Main()
        {
            bool atividade1 = true;
            bool atividade2 = false;

            Console.WriteLine("Ambas atividades foram feitas? {0}", atividade1 && atividade2);
            Console.WriteLine("Uma atividade foi feita? {0}", atividade1 || atividade2);
            Console.WriteLine("Atividade 2 não foi feita? {0}", !atividade2);
        }
    }
    */


    /*
    // Unit Operators (--, ++, false, true, !)
    public class OperadoresUnarios
    {
        static void Main()
        {
            bool x = false;
            int n1 = 6;
            int n2 = 5;
            int n3 = 7;
            int n4 = 8;

            Console.WriteLine(!x);
            n1--;
            Console.WriteLine(n1);
            n2++;
            Console.WriteLine(n2);
            Console.WriteLine(n3 == ++n2);
            Console.WriteLine(--n4 == n1);
        }
    }
    */


    /*
    // Conditions (if/else, while, switch, for)
    public class Condicionais
    {
        static void Main()
        {
            //IfElse(10, 5);
            //SwitchCon();
            //WhileZero(10);
            ForReatZero(10);
        }

        static void IfElse(int n1, int n2)
        {
            if (n1 < n2)
            {
                Console.WriteLine($" {nameof(n1)} < {nameof(n2)}");

            } else if (n1 > n2)
            {
                Console.WriteLine($" {nameof(n1)} > {nameof(n2)}");

            } else
            {
                Console.WriteLine($" {nameof(n1)} == {nameof(n2)}");
            }
        }

        static void SwitchCon()
        {
            Console.WriteLine("Qual nota você daria para este prato 0, 5 ou 10?");
            int nota = int.Parse(Console.ReadLine());

            switch(nota)
            {
                case 0: Console.WriteLine("Horrivel!");
                    break;
                case 5: Console.WriteLine("Comestivel!");
                    break;
                case 10: Console.WriteLine("SUBARASHII");
                    break;
                default: Console.WriteLine("Sem Nota!");
                    break;
            }
        }

        static void WhileZero(int limit)
        {
            while(limit >= 0)
            {
                Console.WriteLine(limit);
                limit--;
            }
        }

        static void ForReatZero(int limit)
        {
            for (int i = 0; i<=limit; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    */


    /*
    // Exercise 1
    public class Aprovacao
    {
        static void Main()
        {
            Console.WriteLine("Qual a primeria Nota?");
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a segunda Nota?");
            int nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a terceira Nota?");
            int nota3 = int.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if (media < 7)
            {
                Console.WriteLine($"Aluno de Recuperação com nota {media}");
            }
            else if (media > 7)
            {
                Console.WriteLine($"Aluno Aprovado com nota {media}");
            }
            else
            {
                Console.WriteLine($"Aluno raspou com nota {media}");
            }
        }
    }
    */


    /*
    // Exercise 1
    public class SumCalculator
    {
        static void Main()
        {
            Console.WriteLine("Insira o primeiro número: ");
            int init = int.Parse(Console.ReadLine());

            bool saida = false;

            while (saida == false)
            {
                Console.WriteLine("Insira o segundo número que vai somar com o primeiro: ");
                int secondNum = int.Parse(Console.ReadLine());

                init += secondNum;

                Console.WriteLine($"A soma até o momento é de {init}");
                Console.WriteLine("Deseja continuar a soma? 1 - sim e 2 - não");

                switch (Console.ReadLine())
                {
                    case "1": Console.WriteLine("Continuar Soma...");
                        break;
                    case "2": Console.WriteLine("Saindo do Programa...");
                        saida = true;
                        break;
                    default: Console.WriteLine("Número invalido");
                        break;
                }

            }
        }
    }
    */


    /*
    // Classes, methods, proprerties
    class Aluno
    {
        public string Nome;
        public int Idade;
        public int Serie;

        public string Retorno()
        {
            return string.Format($"Aluno {Nome}, tem {Idade} anos e está na {Serie} série");
        }

        public void RetornoConsole()
        {
            Console.WriteLine(Retorno());
        }
    }
    
    class Program
    {
        static void Main()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Guilherme";
            aluno.Idade = 22;
            aluno.Serie = 0;

            aluno.RetornoConsole();
        }
    }
    */


    /*
    // Constructor
    class Carro
    {
        public string Name;
        public string Model;
        public double Strength;

        public Carro(string name, string model, double strength)
        {
            Name = name;
            Model = model;
            Strength = strength;
        }

        public Carro() { }
    }

    class Contructor
    {
        static void Main()
        {
            Carro car1 = new Carro();

            car1.Name = "Camaro";
            car1.Model = "Chevrolet";
            car1.Strength = 2.1;

            Console.WriteLine($"carro {car1.Name} da marca {car1.Model} com potência de {car1.Strength}");

            Carro car2 = new Carro("Uno", "Fiat", 1.6);

            Console.WriteLine($"carro {car2.Name} da marca {car2.Model} com potência de {car2.Strength}");
        }
    }
    */


    /*
    // Static
    class StaticMethods
    {
        public static int sum(int x, int y)
        {
            return x + y;
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }

        public static void Main()
        {
            int result = StaticMethods.sum(5,6);
            Console.WriteLine("SUM: " + result);

            StaticMethods method = new StaticMethods();
            Console.WriteLine("Multiply: " + method.multiply(5, 6));
        }
    }
    */


    /*
    // Variable Params
    class Params
    {
        public static void Farewell(params string[] alunos)
        {
            foreach(var aluno in alunos)
            {
                Console.WriteLine($"Tchau, {aluno}");
            }
        }

        public static void Main()
        {
            Farewell("Guilherme", "Rayane", "Antonio");
        }
    }
    */


    /*
    // Get and Set Private
    class Car
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != "Palho")
                {
                    _name = value;

                } else
                {
                    Console.WriteLine("Only Palho Car");
                }
            }
        }

        public Car(string name)
        {
            Name = name;
        }
    }

    class Program2
    {
        public static void Main()
        {
            Car car = new Car("Palho");
            Console.WriteLine(car.Name);

            car.Name = "Uno";
        }
    }
    */


    /*
    // Enum
    class EnumType
    {
        public enum Genero { Terror, Documentario, Suspense}

        class Movie
        {
            public string Name;
            public Genero Type;
        }

        public static void Main()
        {
            int cod = (int)Genero.Terror;
            Console.WriteLine(cod);
        }
    }
    */


    /*
    // Struct vs Class
    class Structclass
    {
        public struct Points
        {
            public int X;
            public int Y;
        }

        public class Pointc
        {
            public int X;
            public int Y;
        }

        public static void Main()
        {
            Points points = new Points();
            Points points2 = points;
            points.X = 2;

            Console.WriteLine($"points X: {points.X}, points2 X: {points2.X}");

            Pointc pointc = new Pointc();
            Pointc pointc2 = pointc;
            pointc.X = 2;

            Console.WriteLine($"pointc X: {pointc.X}, pointc2 X: {pointc2.X}");
        }
    }
    */


    // Params (ref and default)
    /*
    class ParamsRef
    {
        public static void SunFive(int number)
        {
            number = number + 5;
        }

        public static void SunFiveRef(ref int number)
        {
            number = number + 5;
        }

        public static void SunFiveDefault(int x = 5)
        {
            Console.WriteLine(x + 5);
        }

        public static void Main()
        {
            int x = 8;
            SunFive(x);
            Console.WriteLine(x);

            int y = 8;
            SunFiveRef(ref y);
            Console.WriteLine(y);

            SunFiveDefault();
            SunFiveDefault(x);
        }
    }
    */


    /*
    // Inheritance 
    class Professor
    {
        protected readonly float SalarioMax;
        public float SalarioAtual;

        public Professor(float salarioMax)
        {
            SalarioMax = salarioMax;
        }

        protected float ModifySalary(float modify)
        {
            float newSalary = SalarioAtual + modify;

            if (newSalary < 0)
            {
                SalarioAtual = 0;

            } else if (newSalary > SalarioMax)
            {
                SalarioAtual = SalarioMax;

            } else
            {
                SalarioAtual = newSalary;
            }

            return SalarioAtual;
        }

        public float IncriseSalary()
        {
            return ModifySalary(+500);
        }

        public float DecriseSalary()
        {
            return ModifySalary(-500);
        }

        class Prof : Professor
        {
            public Prof(): base(1400){}
        }

        public static void Main()
        {
            Console.WriteLine("Professor 1: ");
            Prof prof1 = new Prof();
            Console.WriteLine(prof1.IncriseSalary());
            Console.WriteLine(prof1.IncriseSalary());
        }
    }
    */


    /*
    // Polimorfism and Encapsulation
        //internal - only inside the project
        //public - visible for everyone
        //private - only inside the class
        //protected - only heritage
        //virtual - method where any derived class may choose to reimplement
        //override - keyword used to define a new method implementation

    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction (decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Notes = note;
        }
    }

    public class Bankacount
    {
        private List<Transaction> allTransactions = new List<Transaction>();
        private readonly decimal _minimumBalance;
        private static int accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach (Transaction transaction in allTransactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }
        }

        public Bankacount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }

        public Bankacount (string name, decimal initialBalance, decimal minimumBalance)
        {
            Owner = name;

            Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            _minimumBalance = minimumBalance;
            if (initialBalance > 0)
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <=0)
            {
                throw new ArgumentException(nameof(amount), "Amount of withdrawal must be positive");
            }
            Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
            Transaction? withdrawal = new(-amount, date, note);
            allTransactions.Add(withdrawal);
            if (overdraftTransaction != null)
                allTransactions.Add(overdraftTransaction);
        }

        protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
        {
            if (isOverdrawn)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else
            {
                return default;
            }
        }

        public string GetAccountHistory()
        {
            decimal balance = 0;
            var report = new System.Text.StringBuilder();
            report.AppendLine("Date\t\tAmount\tBalance\tNote");

            foreach (var transaction in allTransactions)
            {
                balance += transaction.Amount;
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{balance}\t{transaction.Notes}");
            }

            return report.ToString();
        }

        public virtual void PerformMonthEndTransactions() { }
    }

    public class InterestEarningAccount : Bankacount
    {
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance) { }

        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                decimal interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }
    }

    public class LineOfCreditAccount : Bankacount
    {
        public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit) { }

        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                decimal interest = -Balance * 0.07m;
                MakeDeposit(interest, DateTime.Now, "Charge monthly interest");
            }
        }

        protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
            isOverdrawn
            ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
            : default;
    }

    public class GiftCardAccount : Bankacount
    {
        private readonly decimal _monthDeposit = 0m;

        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit) : base(name, initialBalance) => _monthDeposit = monthlyDeposit;

        public override void PerformMonthEndTransactions()
        {
            if (_monthDeposit != 0)
            {
                MakeDeposit(_monthDeposit, DateTime.Now, "Add monthly deposit");
            }
        }
    }


    class RunCode
    {
        public static void Main()
        {
            
            //Part One
            try
            {
                Bankacount bank = new Bankacount("Guilherme", 80000);
                Console.WriteLine($"Owner = {bank.Owner} and Balance = {bank.Balance}");

                bank.MakeWithdrawal(50000, DateTime.Now, "Rent payment");
                Console.WriteLine("Balance: " + bank.Balance);

                bank.MakeDeposit(1000, DateTime.Now, "salary");
                Console.WriteLine("Balance: " + bank.Balance);

                
                //bank.MakeWithdrawal(40000, DateTime.Now, "Buy a car");
                //Console.WriteLine(bank.Balance);

                //bank.MakeDeposit(-1000, DateTime.Now, "health plan");
                //Console.WriteLine(bank.Balance);
                

                Console.WriteLine(bank.GetAccountHistory());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //////////////////////////////////////////

            var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
            giftCard.PerformMonthEndTransactions();

            giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());

            var savings = new InterestEarningAccount("savings account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PerformMonthEndTransactions();
            Console.WriteLine(savings.GetAccountHistory());

            var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransactions();
            Console.WriteLine(lineOfCredit.GetAccountHistory());
        }
    }
    */


    /*
    // Abstract and sealed class
        // abstract - when a hereby class will override it
        // sealed - dont want hereby

    public abstract class Telefone
    {
        public abstract string Tipo();
    }
    public class Xiomi : Telefone
    {
        public override string Tipo()
        {
            return "Note 8 Pro";
        }
    }
    sealed class Smartphone { }
    */



    /*
    // LAMBDA
        // action - function without return
        // func - function with return

    class Lambda
    {
        static void Main()
        {
            Action showConsole = () => Console.WriteLine("LAMBDA Action");
            showConsole();

            Func<int> sorteio = () =>
            {
                Random random = new Random();
                return random.Next(1, 101);
            };

            Console.WriteLine(sorteio());
        }
    }
    */


    /*
    // Delegate
        // é um ponteiro para outra função que vc executa através dele e consegue gerenciar os erros como um callback, posso adicionar varios delegate em um e ver onde o erro ocorreu.

    class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);

        class Calculadora
        {
            public static double soma(double x, double y)
            {
                return x + y;
            }
        }

        static void Main()
        {
            double a = 10;
            double b = 20;

            BinaryNumericOperation operacao = Calculadora.soma;
            Console.WriteLine(operacao(a, b));
        }
    }
    */


    /*
    // LINQ
        // linquagem para consulta de diversos dados

    class Program
    {
        static void Main()
        {
            int[] numeros = { 4, 5, 7, 8 };

            var operacao = numeros.Where(x => x % 2 == 0);

            foreach (int x in operacao)
            {
                Console.WriteLine(x);
            }

            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            foreach (int num in numQuery)
            {
                Console.WriteLine("{0,1} ", num);
            }
        }
    }
    */


    /*
    // Extension Method
    public static class calculadoraExtensao
    {
        public static double Soma(this double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {

        static void Main()
        {
            double x = 3;

            Console.WriteLine(x.Soma(7));
            Console.WriteLine(9.2.Soma(7));
        }
    }
    */


    //Hello World Example
    /*
    class Hello 
    {
      static void Main()
      {
        Console.WriteLine("Hello World");
      }
    }
    */


    //Variable Type Example
    /*
    public struct Mutable
    {
      public int X;
      public int Y;

      public Mutable(int x, int y) => (X, Y) = (x, y);

      public override string ToString() => $"({X}, {Y})";
    }

    public class Program
    {
      public static void Main()
      {
        var p1 = new Mutable(1, 5);
        var p2 = p1;
        p2.Y = 10;
        Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
        Console.WriteLine($"{nameof(p2)}: {p2}");

        MuteMutable(p2);
        Console.WriteLine($"After passing a method: {p2}");
      }

      public static void MuteMutable(Mutable p)
      {
        p.X = 7;
        Console.WriteLine($"Point muted in a method: {p}");
      }
    }
    */


    //Reference Type Example
    /*
    public struct TaggetInteger
    {
      public int Number;
      private List<string> tags;

      public TaggetInteger(int n)
      {
        Number = n;
        tags = new List<string>();
      }

      public void AddTag(string tag) => tags.Add(tag);

      public override string ToString() => $"{Number} [{string.Join(", ", tags)}]";
    }

    public class Program
    {
      public static void Main()
      {
        var n1 = new TaggetInteger(0);
        n1.AddTag("A");
        Console.WriteLine($"{nameof(n1)}: {n1}");

        var n2 = n1;
        n2.Number = 7;
        n2.AddTag("B");

        Console.WriteLine($"{nameof(n1)}: {n1}");
        Console.WriteLine($"{nameof(n2)}: {n2}");
      }
    }
    */


    /*
    // Namespace Example
    namespace MyNamespace
    {
      class SampleNamespace
      {
        public void SampleMethod()
        {
          System.Console.WriteLine("Sample Method");
        }
      }
    }
    */


    /*
    //Class Example
    var p1 = new Point(0,0);
    var p2 = new Point(10,20);

    var pair = new Pair<int, string>(1, "exemplo");
    int i = pair.First;
    string s = pair.Second;

    Point a = new Point(10,20);
    Point b = new Point3D(10,20,30);


    public class Point
    {
      public int X {get;}
      public int Y {get;}

      public Point(int x, int y) => (X, Y) = (x, y);
    }

    public class Pair<TFirst, TSecond>
    {
      public TFirst First {get;}
      public TSecond Second {get;}

      public Pair(TFirst first, TSecond second) => (First, Second) = (first, second);
    }

    public class Point3D : Point
    {
      public int Z {get; set;}

      public Point3D(int x, int y, int z) : base(x,y) => Z = z;
    }
    */


    /*
    //Struct Example
    var point = new Point(10,20);

    public struct Point
    {
      public double X {get;}
      public double Y {get;}

      public Point(double x, double y) => (X, Y) = (x, y);
    }
    */


    /*
    // Interface Example
    EditBox editBox = new();
    IControl control = editBox;
    IDataBound dataBound = editBox;

    interface IControl
    {
      void Paint();
    }
    interface ITextBox : IControl
    {
      void SetText(string text);
    }
    interface IListBox : IControl
    {
      void SetItems(string[] items);
    }
    interface IComboBox : ITextBox, IListBox {}

    interface IDataBound
    {
      void Bind(string b);
    }

    public class EditBox : IControl, IDataBound
    {
      public void Paint() {}
      public void Bind(string b) {}
    }
    */


    /*
    // Enum Example
    var turnip = SomeRootVegetables.Turnip;
    var spring = Seasons.Spring;
    var startOnEquinox = Seasons.Spring | Seasons.Autumn;
    var theYear = Seasons.Seasons;

    public enum SomeRootVegetables
    {
      HorseRadish,
      Radish,
      Turnip
    }

    [Flags]
    public enum Seasons
    {
      None = 0,
      Summer = 1,
      Autumn = 2,
      Winter = 3,
      Spring = 4,
      Seasons = Summer | Autumn | Winter | Spring
    }
    */


    /*
    // Nullable Example
    int? optionalInt = default;
    optionalInt = 5;
    string? optionalText = default;
    optionalText = "Hello World";
    */


    /*
    //Tubles Example
    (double Sum, int Count) t2 = (4.5, 3);
    Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
    */


    // Parameters Example 
    /*
    //value parameter
    int x = 1;
    int y = 2;

    ValueExample(x,y);

    Console.WriteLine($"value input ex: x={x} e y={y}");

    static void ValueExample(int x, int y)
    {
      x++;
      y++;
      Console.WriteLine($"value input ex: x={x} e y={y}");
    }
    */


    /*
    // Reference parameter 
    SwapExample();

    static void Swap(ref int x, ref int y)
    {
      int temp = x;
      x = y;
      y = temp;
    }

    static void SwapExample()
    {
      int i = 1, j = 2;
      Console.WriteLine($"i={i}, j={j}");
      Swap(ref i, ref j);
      Console.WriteLine($"i={i}, j={j}");
    }
    */


    /*
    // Output parameter
    OutUsage();

    static void Divide(int x, int y, out int result, out int remainder)
    {
      result = x / y;
      remainder = x % y;
    }

    static void OutUsage()
    {
      Divide(10, 3, out int res, out int rem);
      Console.WriteLine($"res={res}, rem={rem}");
    }
    */


    /*
    // Array parameter
    int x = 1;
    int y = 2;
    MyConsole.Log("meus parâmetros", x, y);
    public class MyConsole
    {
      public static void Log(string fmt, params object[] args)
      {
        Console.WriteLine(fmt, args);
      }
    }

    public class Console
    {
        public static void Write(string fmt, params object[] args) { }
        public static void WriteLine(string fmt, params object[] args) { }
        // ...
    }

    int x, y, z;
    x = 3;
    y = 4;
    z = 5;
    Console.WriteLine("x={0} y={1} z={2}", x, y, z);
    */


    /*
    var numbers = new int[] {10,20,30};
    Console.WriteLine(GetSourceLabel(numbers));

    var letters = new List<char> {'a','b','c'};
    Console.WriteLine(GetSourceLabel(letters));

    static int GetSourceLabel<T>(IEnumerable<T> source) => source switch
    {
      Array array => 1,
      ICollection<T> collection => 2,
      _ => 3
    };
    */

}