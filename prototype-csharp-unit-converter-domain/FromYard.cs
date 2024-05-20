namespace prototype_csharp_unit_converter_domain;

public class FromYard
{
    public static double ToMeter(double yards)
    {
        return yards / 1.094d;
    }

    public static double ToInch(double input)
    {
        return input * 36;
    }

    public static double ToFoot(double input)
    {
        return input * 3;
    }
}
