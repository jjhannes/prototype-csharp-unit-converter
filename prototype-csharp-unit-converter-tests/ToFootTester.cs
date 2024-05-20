namespace prototype_csharp_unit_converter_tests;
using Domain = prototype_csharp_unit_converter_domain;

[TestClass]
public class ToFootTester
{
    [TestMethod]
    [DataRow(1d, 3d)]
    public void FromYard(double input, double expected)
    {
        double roundedInput = Math.Round(input, Constants.Precision);
        double result = Domain.FromYard.ToFoot(roundedInput);
        double roundedResult = Math.Round(result, Constants.Precision);
        double roundedExpected = Math.Round(expected, Constants.Precision);

        Assert.AreEqual(roundedExpected, roundedResult);
    }

    [TestMethod]
    [DataRow(1d, 3.28084d)]
    public void FromMeter(double input, double expected)
    {
        double roundedInput = Math.Round(input, Constants.Precision);
        double result = Domain.FromMeter.ToFoot(roundedInput);
        double roundedResult = Math.Round(result, Constants.Precision);
        double roundedExpected = Math.Round(expected, Constants.Precision);

        Assert.AreEqual(roundedExpected, roundedResult);
    }

    [TestMethod]
    [DataRow(1d, 0.08333d)]
    public void FromInch(double input, double expected)
    {
        double roundedInput = Math.Round(input, Constants.Precision);
        double result = Domain.FromInch.ToFoot(roundedInput);
        double roundedResult = Math.Round(result, Constants.Precision);
        double roundedExpected = Math.Round(expected, Constants.Precision);

        Assert.AreEqual(roundedExpected, roundedResult);
    }

}
