class Ninja : Human
{
    public Ninja(string name) : base(name)
    {
        Name = name;
        Dexterity = 175;
    }
        public void Steal(Human target)
    {
        target.Health -= 5;
        Health += 5;
        Console.WriteLine($"{Name} has healed stolen 5 HP from {target.Name}!");
    }
    public override int Attack(Human target)
    {
        int dmg = Dexterity * 5;
        Random rnd = new Random();
        int chance = rnd.Next(5);
        if (chance == 4)
        {
            dmg += 10;
        }
        target.Health -= dmg;
        Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage, they are now at {target.Health} HP.");
        return dmg;
    }
}