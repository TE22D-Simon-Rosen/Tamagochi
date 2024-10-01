using System.Security.Cryptography;
class Tamagochi{
    private int hunger = 0;
    private int boredom = 0;
    private List<string> words = new List<string>();
    private bool isAlive = true;
    public string name;

    public void Feed(){
        Console.WriteLine($"{name} säger: MMMMMMM så GOT!!!:D)D)D)D)");
        hunger = 0;
    }

    public void Hi(){
        Console.WriteLine($"{name} säger: {words[Random.Shared.Next(0, words.Count() - 1)]}!!! :DD");
        ReduceBoredom();
    }

    public void Teach(string word){
        words.Add(word);
        Console.WriteLine($"{word}!!!!! :DDD");
    }

    public void Tick(){
        boredom += 1;
        hunger += 1;

        if (hunger > 10 || boredom > 10){
            isAlive = false;
        }
    }

    public void PrintStats(){
        Console.WriteLine($"\nHunger: {hunger} \nBoredom: {boredom}");
    }

    public bool GetAlive(){
        return isAlive;
    }

    private void ReduceBoredom(){
        boredom = 0;
    }
}
