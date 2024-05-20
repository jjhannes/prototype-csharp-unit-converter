namespace prototype_csharp_unit_converter_tests;
using Domain = prototype_csharp_unit_converter_domain;

[TestClass]
public class ToInchTester
{
    [TestMethod]
    [DataRow(1d, 36d)]
    public void FromYard(double input, double expected)
    {
        double roundedInput = Math.Round(input, Constants.Precision);
        double result = Domain.FromYard.ToInch(roundedInput);
        double roundedResult = Math.Round(result, Constants.Precision);
        double roundedExpected = Math.Round(expected, Constants.Precision);

        Assert.AreEqual(roundedExpected, roundedResult);
    }

    [TestMethod]
    [DataRow(1d, 12d)]
    public void FromFoot(double input, double expected)
    {
        double roundedInput = Math.Round(input, Constants.Precision);
        double result = Domain.FromFoot.ToInch(roundedInput);
        double roundedResult = Math.Round(result, Constants.Precision);
        double roundedExpected = Math.Round(expected, Constants.Precision);

        Assert.AreEqual(roundedExpected, roundedResult);
    }

    [TestMethod]
    [DataRow(1d, 39.3701d)]
    public void FromMeter(double input, double expected)
    {
        double roundedInput = Math.Round(input, Constants.Precision);
        double result = Domain.FromMeter.ToInch(roundedInput);
        double roundedResult = Math.Round(result, Constants.Precision);
        double roundedExpected = Math.Round(expected, Constants.Precision);

        Assert.AreEqual(roundedExpected, roundedResult);
    }
}
