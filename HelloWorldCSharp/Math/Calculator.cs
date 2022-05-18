namespace HelloWorldCSharp
{
    public class Calculator 
    {
        public int sum = 0;
        public int Add(params int [] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            return sum;
        }
    }
}

