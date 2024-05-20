namespace prototype_csharp_unit_converter_tests;
using Domain = prototype_csharp_unit_converter_domain;

[TestClass]
public class ToMeterTester
{
    [TestMethod]
    [DataRow(1d, 0.9144d)]
    public void FromYard(double input, double expected)
    {
        double roundedInput = Math.Round(input, Constants.Precision);
        double result = Domain.FromYard.ToMeter(roundedInput);
        double roundedResult = Math.Round(result, Constants.Precision);
        double roundedExpected = Math.Round(expected, Constants.Precision);

        Assert.AreEqual(roundedExpected, roundedResult);
    }

    [TestMethod]
    [DataRow(1d, 0.3048d)]
    public void FromFoot(double input, double expected)
    {
        double roundedInput = Math.Round(input, Constants.Precision);
        double result = Domain.FromFoot.ToMeter(roundedInput);
        double roundedResult = Math.Round(result, Constants.Precision);
        double roundedExpected = Math.Round(expected, Constants.Precision);

        Assert.AreEqual(roundedExpected, roundedResult);
    }

    [TestMethod]
    [DataRow(1d, 0.0254d)]
    public void FromInch(double input, double expected)
    {
        double roundedInput = Math.Round(input, Constants.Precision);
        double result = Domain.FromInch.ToMeter(roundedInput);
        double roundedResult = Math.Round(result, Constants.Precision);
        double roundedExpected = Math.Round(expected, Constants.Precision);

        Assert.AreEqual(roundedExpected, roundedResult);
    }
    
}
