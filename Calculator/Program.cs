
using System.Diagnostics.CodeAnalysis;

static void Soma() {
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float segundoValor = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    Console.WriteLine($"{primeiroValor} + {segundoValor} = {primeiroValor + segundoValor}");

    Console.ReadKey();
    Menu();

}

static void Subtracao () {
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());

    Console.WriteLine("Primeiro valor: ");
    float segundoValor = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine($"{primeiroValor} - {segundoValor} = {primeiroValor - segundoValor}");
    Console.ReadKey();
    Menu();

}   

static void Divisao () {
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor");
    float segundoValor = float.Parse(Console.ReadLine());

    Console.WriteLine();

    Console.WriteLine($"{primeiroValor} / {segundoValor} = {primeiroValor / segundoValor}");
    
    Console.ReadKey();
    Menu();

}

static void Multiplicacao () {
    Console.Clear();

    Console.WriteLine("Primeiro valor");
    float primeiroValor = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor");
    float segundoValor = float.Parse(Console.ReadLine());

    Console.WriteLine();

    Console.WriteLine($"{primeiroValor} * {segundoValor} = {primeiroValor * segundoValor}");

    Console.ReadKey();
    Menu();

}

static void Menu () {
    Console.Clear();

    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine(" 1 - Soma");
    Console.WriteLine(" 2 - Subtração");
    Console.WriteLine(" 3 - Divisão");
    Console.WriteLine(" 4 - Multiplicação");
    Console.WriteLine(" 5 - Sair");

    Console.WriteLine("---------------------------");
    Console.WriteLine("Selecione uma opção: ");

    short resultado = short.Parse(Console.ReadLine());

    switch (resultado) {
        case 1: Soma ();
            break;

        case 2: Subtracao ();
            break;

        case 3: Divisao ();
            break;

        case 4: Multiplicacao ();
            break;

        case 5: System.Environment.Exit(9);
            break;
        
        default: Menu();
            break;

    }
}

Menu();