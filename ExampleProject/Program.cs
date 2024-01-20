using GeometryObjectsShared;
using System.Globalization;
using System.IO;
using System.Text;

if (args.Length == 1 && File.Exists(args[0]))
{
    int count = 0;
    try
    {
        List<IGeometricObject> models = [];

        using (StreamReader reader = new(args[0]))
        {
            string? line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                ++count;
                if (line.Split()[0] != "#")
                {
                    models.Add(Creator.CreateObject(line));
                }
            }
        }
        // чтобы в консоль выводилась точка как разделитель десятичных чисел
        CultureInfo.CurrentCulture = new CultureInfo("en-US");
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

static void PrintObjectsInformation(List<IGeometricObject> models)
{
    foreach (var item in models)
    {
        item.Draw();
        item.Perimeter();
        item.Square();
        Console.WriteLine("------");
    }
}

static void FindDuplicates(List<IGeometricObject> models)
{
    Console.WriteLine("***Duplicates:");
    List<IGeometricObject> evenModels = [];
    List<IGeometricObject> oddModels = [];
    for (int i = 0; i < models.Count; i++)
    {
        if (i % 2 == 0)
            evenModels.Add(models[i]);
        else
            oddModels.Add(models[i]);
    }

    IEnumerable<IGeometricObject> duplicates = evenModels.Intersect(oddModels);
    foreach (var item in duplicates)
        Console.WriteLine(item.ToString());
}


