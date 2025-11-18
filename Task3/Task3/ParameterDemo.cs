namespace Task3;

public class ParameterDemo
{
    
    // ref: increases the number by 10
    public void Increase(ref int number)
    {
        number = number + 10;
    }
    
    //out: assigns fullname to out parameter
    public void GetFullName(out string fullname)
    {
        fullname = "Raul Lama";
    }

    //params: accept multiple numbers
    public int SumAll(params int[] numbers)
    {
        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }

        return sum;
    }
}
