public class Player
{
    public int RollDie(){
        System.Random random = new System.Random();
        return random.Next(1, 19);
    }

    public double GenerateSpellStrength(){
        System.Random random = new System.Random();
        return random.NextDouble() * 100;
    }
}
