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
}
