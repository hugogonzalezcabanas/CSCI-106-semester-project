using Moq;

namespace SemesterProject.Tests;

public class TheGridBuilder
{
    private Mock<ISvgBuilder> SvgBuilder;

    [SetUp]
    public void Setup()
    {
        SvgBuilder = new Mock<ISvgBuilder>();
    }

    [Test]
    public void CanBeInitialized()
    {
        var gridBuilder = new GridBuilder(SvgBuilder.Object, 8);
        Assert.That(gridBuilder, Is.Not.Null);
    }

    // Add your unit tests here!
}
