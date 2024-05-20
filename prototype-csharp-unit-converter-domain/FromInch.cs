namespace prototype_csharp_unit_converter_domain;

public class FromInch
{
    public static double ToYard(double input)
    {
        return input / 36;
    }

    public static double ToMeter(double input)
    {
        return input / 39.37;
    }

    public static double ToFoot(double input)
    {
        return input / 12;
    }
}
