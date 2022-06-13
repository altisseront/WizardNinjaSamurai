class Samurai : Human
{
    public Samurai(string name) : base(name)
    {
        Name = name;
        Health = 200;
    }
    public override int Attack(Human target)
    {
        int dmg = Strength * 3;
        
        target.Health -= dmg;

        if (target.Health < 50){
            target.Health = 0;
            Console.WriteLine($"{target.Name} has been executed!");
        }
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        
        return target.Health;
    }
        public void Meditate(Human target)
    {
        Health = 200;
        Console.WriteLine($"{Name} has healed {target.Name}! They are now at {target.Health} HP.");
    }
}