// See https://aka.ms/new-console-template for more information
public IList<string> FizzBuzz(int n) 
{
    string[] answer = new string[n];


    for (int i = 1; i <= n; i++)
    {
        bool divisibleByThree = i % 3 == 0;
        bool divisibleByFive = i % 5 == 0;

        if (divisibleByThree && divisibleByFive) 
        {
            answer[i - 1] = "FizzBuzz";
        }
        else if (divisibleByThree)
        {
            answer[i - 1] = "Fizz";
        }
        else if (divisibleByFive)
        {
            answer[i - 1] = "Buzz";
        }
        else
        {
            answer[i - 1] = i.ToString();
        }
    }        

    return answer;
}