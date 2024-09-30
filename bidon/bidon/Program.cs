using System;

public class CPU
{
    public string Model { get; set; }
    public float Frequency { get; set; }

    public CPU(string model, float frequency)
    {
        Model = model;
        Frequency = frequency;
    }

    public override string ToString()
    {
        return $"CPU: {Model}, Frequency: {Frequency} GHz";
    }
}

public class Motherboard
{
    public string Model { get; set; }
    public string FormFactor { get; set; }

    public Motherboard(string model, string formFactor)
    {
        Model = model;
        FormFactor = formFactor;
    }

    public override string ToString()
    {
        return $"Motherboard: {Model}, Form Factor: {FormFactor}";
    }
}

public class RAM
{
    public int Capacity { get; set; }
    public string Type { get; set; }

    public RAM(int capacity, string type)
    {
        Capacity = capacity;
        Type = type;
    }

    public override string ToString()
    {
        return $"RAM: {Capacity} GB, Type: {Type}";
    }
}

public class Storage
{
    public int Capacity { get; set; }
    public string Type { get; set; }

    public Storage(int capacity, string type)
    {
        Capacity = capacity;
        Type = type;
    }

    public override string ToString()
    {
        return $"Storage: {Capacity} GB, Type: {Type}";
    }
}

public class GraphicsCard
{
    public string Model { get; set; }
    public int Memory { get; set; }

    public GraphicsCard(string model, int memory)
    {
        Model = model;
        Memory = memory;
    }

    public override string ToString()
    {
        return $"Graphics Card: {Model}, Memory: {Memory} GB";
    }
}

public class Computer
{
    public CPU CPU { get; set; }
    public Motherboard Motherboard { get; set; }
    public RAM RAM { get; set; }
    public Storage Storage { get; set; }
    public GraphicsCard GraphicsCard { get; set; }

    public Computer(CPU cpu, Motherboard motherboard, RAM ram, Storage storage, GraphicsCard graphicsCard)
    {
        CPU = cpu;
        Motherboard = motherboard;
        RAM = ram;
        Storage = storage;
        GraphicsCard = graphicsCard;
    }

    public override string ToString()
    {
        return $"Computer:\n{CPU}\n{Motherboard}\n{RAM}\n{Storage}\n{GraphicsCard}";
    }
}

public class ComputerBuilder
{
    private CPU cpu;
    private Motherboard motherboard;
    private RAM ram;
    private Storage storage;
    private GraphicsCard graphicsCard;

    public ComputerBuilder SetCPU(CPU cpu)
    {
        this.cpu = cpu;
        return this;
    }

    public ComputerBuilder SetMotherboard(Motherboard motherboard)
    {
        this.motherboard = motherboard;
        return this;
    }

    public ComputerBuilder SetRAM(RAM ram)
    {
        this.ram = ram;
        return this;
    }

    public ComputerBuilder SetStorage(Storage storage)
    {
        this.storage = storage;
        return this;
    }

    public ComputerBuilder SetGraphicsCard(GraphicsCard graphicsCard)
    {
        this.graphicsCard = graphicsCard;
        return this;
    }

    public Computer Build()
    {
        return new Computer(cpu, motherboard, ram, storage, graphicsCard);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите модель процессора:");
        string cpuModel = Console.ReadLine();
        Console.WriteLine("Введите частоту процессора (ГГц):");
        float cpuFrequency = float.Parse(Console.ReadLine());

        Console.WriteLine("Введите модель материнской платы:");
        string motherboardModel = Console.ReadLine();
        Console.WriteLine("Введите форм-фактор материнской платы:");
        string motherboardFormFactor = Console.ReadLine();

        Console.WriteLine("Введите объём оперативной памяти (ГБ):");
        int ramCapacity = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите тип оперативной памяти:");
        string ramType = Console.ReadLine();

        Console.WriteLine("Введите объём хранилища (ГБ):");
        int storageCapacity = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите тип хранилища:");
        string storageType = Console.ReadLine();

        Console.WriteLine("Введите модель видеокарты:");
        string graphicsCardModel = Console.ReadLine();
        Console.WriteLine("Введите объём видеопамяти (ГБ):");
        int graphicsCardMemory = int.Parse(Console.ReadLine());

        ComputerBuilder builder = new ComputerBuilder();
        builder.SetCPU(new CPU(cpuModel, cpuFrequency))
               .SetMotherboard(new Motherboard(motherboardModel, motherboardFormFactor))
               .SetRAM(new RAM(ramCapacity, ramType))
               .SetStorage(new Storage(storageCapacity, storageType))
               .SetGraphicsCard(new GraphicsCard(graphicsCardModel, graphicsCardMemory));

        Computer computer = builder.Build();

        Console.WriteLine(computer.ToString());
    }
}