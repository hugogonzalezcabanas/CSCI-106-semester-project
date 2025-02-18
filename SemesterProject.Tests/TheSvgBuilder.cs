namespace SemesterProject.Tests;

public class TheSvgBuilder
{
    [Test]
    public void BuildsSvgsWithTheCorrectSize()
    {
        var width = 123;
        var height = 456;

        var svg = new SvgBuilder(width, height).Build();

        Assert.That(svg, Contains.Substring($"width=\"{width}\""));
        Assert.That(svg, Contains.Substring($"height=\"{height}\""));
    }

    [Test]
    public void AddsRectangles()
    {
        var svgSize = 500;
        var rectX = 12;
        var rectY = 34;
        var rectWidth = 56;
        var rectHeight = 78;
        var rectColor = "#abc987";

        var svg = new SvgBuilder(svgSize, svgSize)
            .AddRectangle(rectX, rectY, rectWidth, rectHeight, rectColor)
            .Build();

        Assert.That(svg, Contains.Substring($"x=\"{rectX}\""));
        Assert.That(svg, Contains.Substring($"y=\"{rectY}\""));
        Assert.That(svg, Contains.Substring($"width=\"{rectWidth}\""));
        Assert.That(svg, Contains.Substring($"height=\"{rectHeight}\""));
        Assert.That(svg, Contains.Substring($"fill:{rectColor}"));
    }

    [Test]
    public void ReadsInputFileAndCreatesSvg()
    {
        var svgSize = 500;
        var inputData = new string[] { "(1,2) #ff0000", "(3,4) #00ff00" };
        var expectedRects = new string[]
        {
            "<rect x=\"10\" y=\"20\" width=\"10\" height=\"10\" style=\"fill:#ff0000\" />",
            "<rect x=\"30\" y=\"40\" width=\"10\" height=\"10\" style=\"fill:#00ff00\" />"
        };

        var svgBuilder = new SvgBuilder(svgSize, svgSize);
        int squareSize = 10;

        foreach (var line in inputData)
        {
            var parts = line.Split(' ');
            var coords = parts[0].Trim('(', ')').Split(',');
            int x = int.Parse(coords[0]) * squareSize;
            int y = int.Parse(coords[1]) * squareSize;
            string color = parts[1];

            svgBuilder.AddRectangle(x, y, squareSize, squareSize, color);
        }

        var svg = svgBuilder.Build();

        foreach (var expected in expectedRects)
        {
            Assert.That(svg, Contains.Substring(expected));
        }
    }
}
