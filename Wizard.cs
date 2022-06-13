class Wizard : Human
{
    public Wizard(string name) : base(name)
    {
        Name = name;
        Intelligence = 25;
        Health = 50;
    }
    public override int Attack(Human target)
    {
        int dmg = Intelligence * 5;
        target.Health -= dmg;
        Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage, they are now at {target.Health} HP.");
        Console.WriteLine($"{Name} healed himself for {dmg}, they are now at {Health} HP.");
        return target.Health;
    }
    public void Heal(Human target)
    {
        target.Health += Intelligence * 10;
        Console.WriteLine($"{Name} has healed {target.Name}! They are now at {target.Health} HP.");
    }
}