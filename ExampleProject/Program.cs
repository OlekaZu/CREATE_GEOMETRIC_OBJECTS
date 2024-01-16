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
                    var creator = ParsingObject(line);
                    models.Add(creator.Create());
                }
            }
        }
        PrintObjectsInformation(models);
        FindDuplicates(models);
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

static Creator ParsingObject(string line)
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
        _ => throw new ArgumentException($"Unknown object")
    };
    return creator;
}

static void PrintObjectsInformation(List<GeometricModel> models)
{
    foreach (var item in models)
    {
        item.Draw();
        item.Perimeter();
        item.Square();
        Console.WriteLine("------");
    }
}

static void FindDuplicates(List<GeometricModel> models)
{
    Console.WriteLine("***Duplicates:");
    List<GeometricModel> evenModels = [];
    List<GeometricModel> oddModels = [];
    for (int i = 0; i < models.Count; i++)
    {
        if (i % 2 == 0)
            evenModels.Add(models[i]);
        else
            oddModels.Add(models[i]);
    }

    IEnumerable<GeometricModel> duplicates = evenModels.Intersect(oddModels);
    foreach (var item in duplicates)
        Console.WriteLine(item.ToString());
}


