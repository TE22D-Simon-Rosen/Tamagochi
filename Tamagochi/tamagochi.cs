using System.Security.Cryptography;
class Tamagochi{
    private int hunger = 0;
    private int boredom = 0;
    private List<string> words = new List<string>();
    private bool isAlive = true;
    public string name;

    public void Feed(){
        Console.WriteLine($"\n{name} säger: MMMMMMM så GOT!!!:D)D)D)D)");
        hunger = 0;
    }

    public void Hi(){
        if (words.Count == 0){
            Console.WriteLine($"\n{name}: HEJ!");
            Console.WriteLine($"{name} kan inga ord... Lär den något!");
        }
        else{
            Console.WriteLine($"\n{name}: {words[Random.Shared.Next(words.Count)]}!!! :DD");
        }
        ReduceBoredom();
    }

    public void Teach(string word){
        words.Add(word);
        Console.WriteLine($"\n{word}!!!!! :DDD");
        ReduceBoredom();
    }

    public void Tick(){
        boredom += 1;
        hunger += 1;

        if (hunger > 10 || boredom > 10){
            isAlive = false;
        }
    }

    public void PrintStats(){
        Console.WriteLine($"\n{name} stats: \nHunger: {hunger} \nBoredom: {boredom}");
    }

    public bool GetAlive(){
        return isAlive;
    }

    private void ReduceBoredom(){
        boredom = 0;
    }
}
