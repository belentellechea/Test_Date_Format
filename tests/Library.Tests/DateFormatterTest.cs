using NUnit.Framework;

namespace TestDateFormat.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void SetUp()
    {
    }

    [Test]
    public void CorrectFormatTest()
    {
        string testDate1 = "20/12/2004";
        string result = DateFormatter.ChangeFormat(testDate1);
        Assert.AreEqual("2004-12-20", result);
    }

    [Test]
    public void IncorrectFormatTest()
    {
        string testDate2 = "20/12";
        string result2 = DateFormatter.ChangeFormat(testDate2);
        Assert.AreEqual("Formato incorrecto", result2);
    }

    [Test]
    public void EmptyTest()
    {
        string testDate3 = "";
        string result3 = DateFormatter.ChangeFormat(testDate3);
        Assert.AreEqual("Formato incorrecto", result3);
    }
}