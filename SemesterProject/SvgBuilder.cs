namespace SemesterProject;

public class SvgBuilder
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

    public SvgBuilder AddRectangle(int x, int y, int width, int height, string color)
    {
        // Replace this line with your code
        throw new NotImplementedException();

        // Don't remove this!
        return this;
    }
}
