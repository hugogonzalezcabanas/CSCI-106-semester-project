namespace SemesterProject;

public interface IGridBuilder
{
    /// <summary>
    /// Parses a line with the format `([x], [y]) [color]` and add it to the
    /// SVG builder as a rectangle.
    /// </summary>
    /// <param name="line">The line to parse.</param>
    public void Parse(string line);
}

public class GridBuilder : IGridBuilder
{
    /// <summary>
    /// A reference to an SVG builder. We keep this so that we can add
    /// rectangles to it without having to constantly pass it around.
    /// </summary>
    private readonly ISvgBuilder SvgBuilder;

    /// <summary>
    /// The size of the grid to build. For example, a grid size of 8 will
    /// result in individual grid cells being 8 by 8 units.
    /// </summary>
    private readonly int GridSize;

    /// <summary>
    /// Initialize a new grid builder.
    /// </summary>
    /// <param name="svgBuilder">The SVG builder to reference later.</param>
    /// <param name="gridSize">The size of the grid.</param>
    public GridBuilder(ISvgBuilder svgBuilder, int gridSize)
    {
        SvgBuilder = svgBuilder;
        GridSize = gridSize;
    }

    public void Parse(string line)
    {
        // Replace this line with your code!
        throw new NotImplementedException();
    }
}
