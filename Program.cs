Random dice = new Random();

int monsterAC = 18;

Console.WriteLine(" Roll your d20!");
Console.ReadLine();

int d20Roll = dice.Next(20);
Console.WriteLine("You rolled a " + Convert.ToString(d20Roll));

if(d20Roll>monsterAC) {
    Console.WriteLine("You hit the monster!");
} else{
    Console.WriteLine("Your atack missed.");
}
    

    
