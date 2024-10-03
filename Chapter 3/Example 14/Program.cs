using static System.Convert;


double g = 9.8;
int h = ToInt32(g);
WriteLine($"g is {g} and h is {h}");

double[] doubles = [9.49, 9.5, 9.51, 10.49, 10.5, 10.51];

foreach (double n in doubles)
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}

foreach (double n in doubles)
{
    WriteLine(format:
    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
    arg0: n,
    arg1: Math.Round(value: n, digits: 0,
    mode: MidpointRounding.AwayFromZero));
}