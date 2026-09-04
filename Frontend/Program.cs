//using Backend;

//var stack = new StackUsingArray<string>(10);

//    var option = string.Empty;
//    do
//    {
//        option = Menu();
//        try
//        {
//            switch (option)
//            {
//                case "1":
//                    Console.Write("Digite elemento: ");
//                    stack.Push(Console.ReadLine()!);
//                    break;
//                case "2":
//                    Console.WriteLine($"Elemento desapilado: {stack.Pop()} ");
//                    break;
//                case "3":
//                    Console.WriteLine($"Elemento en tope de pila: {stack.Peak()} ");
//                    break;
//                default:
//                    Console.WriteLine("Opción no valida: ");
//                    break;
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine(ex.Message);
//        Console.ForegroundColor = ConsoleColor.White;
//    }
//    } while (option != "0");


//    string Menu()
//    {
//        Console.WriteLine("1. Apilar.");
//        Console.WriteLine("2. Desapilar.");
//        Console.WriteLine("3. Ver tope de la pila.");
//        Console.WriteLine("0. Salir");
//        Console.Write("Digite su opción: ");
//        return Console.ReadLine()!;
//    }


using Backend;

var stack = new StackUsingList<int>();

var random = new Random();

while(true)

{
    stack.Push(random.Next());
    Console.WriteLine(stack.Peak());
}

//var option = string.Empty;
//do
//{
//    option = Menu();
//    try
//    {
//        switch (option)
//        {
//            case "1":
//                Console.Write("Digite elemento: ");
//                stack.Push(Console.ReadLine()!);
//                break;
//            case "2":
//                Console.WriteLine($"Elemento desapilado: {stack.Pop()} ");
//                break;
//            case "3":
//                Console.WriteLine($"Elemento en tope de pila: {stack.Peak()} ");
//                break;
//            default:
//                Console.WriteLine("Opción no valida: ");
//                break;
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine(ex.Message);
//        Console.ForegroundColor = ConsoleColor.White;
//    }
//} while (option != "0");


//string Menu()
//{
//    Console.WriteLine("1. Apilar.");
//    Console.WriteLine("2. Desapilar.");
//    Console.WriteLine("3. Ver tope de la pila.");
//    Console.WriteLine("0. Salir");
//    Console.Write("Digite su opción: ");
//    return Console.ReadLine()!;
//}
