static void Menu () {
    Console.Clear();
    Console.WriteLine("S = Segundo => 10s = 10 segundos");
    Console.WriteLine("N = Minuto => 1m = 1 minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar? ");

    string data = Console.ReadLine().ToUpper();
    Console.WriteLine(data);
}

static void Start (int timer) {
    int currentTime = 0;

    while (timer > currentTime) {
        Console.Clear();

        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("StopWatch finalizado...");
    Thread.Sleep(2500);
}

//Start(6);
Menu();