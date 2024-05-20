namespace prototype_csharp_unit_converter_tests;
using Domain = prototype_csharp_unit_converter_domain;

[TestClass]
public class ToYardTester
{
    [TestMethod]
    [DataRow(1d, 0.3333d)]
    public void FromFoot(double input, double expected)
    {
        double roundedInput = Math.Round(input, Constants.Precision);
        double result = Domain.FromFoot.ToYard(roundedInput);
        double roundedResult = Math.Round(result, Constants.Precision);
        double roundedExpected = Math.Round(expected, Constants.Precision);

        Assert.AreEqual(roundedExpected, roundedResult);
    }

    [TestMethod]
    [DataRow(1d, 1.09361d)]
    public void FromMeter(double input, double expected)
    {
        double roundedInput = Math.Round(input, Constants.Precision);
        double result = Domain.FromMeter.ToYard(roundedInput);
        double roundedResult = Math.Round(result, Constants.Precision);
        double roundedExpected = Math.Round(expected, Constants.Precision);

        Assert.AreEqual(roundedExpected, roundedResult);
    }

    [TestMethod]
    [DataRow(1d, 0.027778d)]
    public void FromInch(double input, double expected)
    {
        double roundedInput = Math.Round(input, Constants.Precision);
        double result = Domain.FromInch.ToYard(roundedInput);
        double roundedResult = Math.Round(result, Constants.Precision);
        double roundedExpected = Math.Round(expected, Constants.Precision);

        Assert.AreEqual(roundedExpected, roundedResult);
    }

}
