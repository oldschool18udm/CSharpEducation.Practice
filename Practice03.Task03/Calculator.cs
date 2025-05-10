namespace Practice03.Task03;

public class Calculator
{
    public float num1;
    public float num2;

    public float Add(float num1, float num2)
    {
        return num1 + num2;
    }

    public float Sub(float num1, float num2)
    {
        return num1 - num2;
    }

    public float Mult(float num1, float num2)
    {
        return num1 * num2;
    }

    public float Div(float num1, float num2)
    {
        if (num2 != 0)
            return num1 / num2;
        return 0;
    }
}