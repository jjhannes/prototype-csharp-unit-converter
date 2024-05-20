namespace prototype_csharp_unit_converter_domain;

public class FromFoot
{
    public static double ToMeter(double input)
    {
        return input / 3.281d;
    }

    public static double ToInch(double input)
    {
        return input * 12;
    }

    public static double ToYard(double input)
    {
        return input / 3;
    }
}
