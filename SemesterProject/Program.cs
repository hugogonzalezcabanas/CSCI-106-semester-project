namespace SemesterProject;

public static class Program
{
    public static void Main()
    {
        Console.Write("Enter input file path: ");
        var inputPath = Console.ReadLine() ?? "";

        if (!File.Exists(inputPath))
        {
            Console.WriteLine("File not found!");
            return;
        }

        var svgBuilder = new SvgBuilder(500, 500);
        int squareSize = 10; // Ajusta el tamaño como prefieras (5-20 recomendado)

        foreach (var line in File.ReadLines(inputPath))
        {
            var parts = line.Split(' ');
            if (parts.Length != 2) continue;

            var coords = parts[0].Trim('(', ')').Split(',');
            if (coords.Length != 2) continue;

            if (int.TryParse(coords[0], out int x) && int.TryParse(coords[1], out int y))
            {
                string color = parts[1];
                svgBuilder.AddRectangle(x * squareSize, y * squareSize, squareSize, squareSize, color);
            }
        }

        var svg = svgBuilder.Build();

        Console.Write("Absolute path to save SVG at: ");
        var outputPath = Console.ReadLine() ?? "";
        using var streamWriter = new StreamWriter(outputPath);
        streamWriter.WriteLine(svg);

        Console.WriteLine("SVG file created successfully!");
    }
}


