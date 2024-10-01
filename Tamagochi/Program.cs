Tamagochi tamagochi = new();

Console.WriteLine("Select a name for your tamagochi: ");
tamagochi.name = Console.ReadLine();

while(true){
    Console.WriteLine("\nVad vill du göra? \n\nA) Lära ett nytt ord \nB) Hälsa \nC) Mata \nD) Ingenting \n\nSkriv motsvarande bokstav för att välja");
    
    if (Console.ReadLine().ToUpper() == "A"){
        Console.WriteLine("Vad vill du lära din tamagochi?");
        string i = Console.ReadLine();
        tamagochi.Teach(i);
    }
    else if (Console.ReadLine().ToUpper() == "B"){
        tamagochi.Hi();
    }
    else if (Console.ReadLine().ToUpper() == "C"){
        tamagochi.Feed();
    }

    tamagochi.PrintStats();
}