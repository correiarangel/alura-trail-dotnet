class Employee(string name, string position)
{
    public string Name { get; set; } = name;
    public string Position { get; set; } = position;

    public void SetPosition(string newPosition)
    {
        if (string.Equals(newPosition, Position, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Cargo deve ser diferente do atual");
            ViewPosition();
            return;
        }
        Position = newPosition.ToUpper();
        ViewPosition();
    }

   public void ViewPosition()
    {
        Console.WriteLine($"Cargo Atual: {Position.ToUpper()}");
    }
}