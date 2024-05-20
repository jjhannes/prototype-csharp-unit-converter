namespace prototype_csharp_unit_converter_domain;

public class FromMeter
{
    public static double ToYard(double input)
    {
        return input * 1.094d;
    }

    public static double ToInch(double input)
    {
        return input * 39.37;
    }

    public static double ToFoot(double input)
    {
        return input * 3.281d;
    }
}
