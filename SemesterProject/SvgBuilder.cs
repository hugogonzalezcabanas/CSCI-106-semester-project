namespace SemesterProject;

public interface ISvgBuilder
{
    /// <summary>
    /// Builds an SVG containing any shapes that were added.
    /// </summary>
    /// <returns>The built SVG.</returns>
    string Build();

    /// <summary>
    /// Adds a rectangle to the SVG being built.
    /// </summary>
    /// <param name="x">The distance from the left bound.</param>
    /// <param name="y">The distance from the top bound.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="color">The color of the rectangle.</param>
    /// <returns>This SVG builder.</returns>
    ISvgBuilder AddRectangle(int x, int y, int width, int height, string color);
}

public class SvgBuilder : ISvgBuilder
{
    private const string SVG_HEADER_TEMPLATE = "<svg width=\"{0}\" height=\"{1}\" xmlns=\"http://www.w3.org/2000/svg\">";
    private const string SVG_FOOTER = "</svg>";
    private const string RECT_TEMPLATE = "<rect x=\"{0}\" y=\"{1}\" width=\"{2}\" height=\"{3}\" style=\"fill:{4}\" />";

    private readonly int Width;
    private readonly int Height;

    private string Buffer;

    public SvgBuilder(int width, int height)
    {
        Width = width;
        Height = height;
        Buffer = string.Empty;
    }

    public string Build() =>
        string.Format(SVG_HEADER_TEMPLATE, Width, Height)
            + Buffer
            + SVG_FOOTER;

    public ISvgBuilder AddRectangle(int x, int y, int width, int height, string color)
    {
        // Replace this line with your code
        throw new NotImplementedException();

        // Don't remove this!
        return this;
    }
}
