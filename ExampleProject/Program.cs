using GeometricObjetsLibrary;
using GeometricObjetsLibrary.Creators;
using System.IO;

if (args.Length == 1 && File.Exists(args[0]))
{
    int count = 0;
    try
    {
        List<GeometricModel> models = [];
        using (StreamReader reader = new(args[0]))
        {
            string? line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                ++count;
                if (line.Split()[0] != "#")
                {
                    var creator = ParsingObject(line, count);
                    models.Add(creator.Create());
                }
            }
        }

        foreach (var item in models)
        {
            item.Draw();
            item.Perimeter();
            item.Square();
            Console.WriteLine("------");
        }

    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message + $" in line {count}");
    }
}
else
{
    Console.WriteLine("Something went wrong. Check the way of input file and retry.");
}

static Creator ParsingObject(string line, int count)
{
    string firstWord = line.Split(' ')[0];
    Creator creator = firstWord switch
    {
        "circle" => new CircleCreator(line),
        "line" => new LineCreator(line),
        "point" => new PointCreator(line),
        "rhomb" => new RhombCreator(line),
        "rect" => new RectCreator(line),
        "square" => new SquareCreator(line),
        _ => throw new ArgumentException($"Unknown object in line {count}")
    };
    return creator;
}



