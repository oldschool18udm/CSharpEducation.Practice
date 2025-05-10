namespace Practice03.Task06;

public struct Point
{
    public int x;
    public int y;

    public double Distance(Point p2)
    {
        return Math.Sqrt(Math.Pow(x - p2.x, 2) + Math.Pow(y - p2.y, 2));
    }
}