// using System.Globalization;

// ulong num = 761000;
// ulong x;
// ulong cnt=0;
// for(ulong i =0; i <= num; i++)
// {
//     if (i % 2 == 1)
//     {

//         x = i*i;
//         cnt+=x;
//     }
// }
// Console.WriteLine(cnt);
using System.ComponentModel.DataAnnotations;

bool isPrime(long n)
{
    for(long i=2; i< Math.Sqrt(n); i++)
    {
        if(n%i == 0)
        {
            return false;
        }
    }
    return true;
}

long problem1(long n)
{
    long counter = 0;
    for(long i =1; i<n; i++)
    {
        if(i%3==0 || i % 5 == 0)
        {
            counter +=i;
        }
    }
    return counter;
}
Console.WriteLine(problem1(1000));

long problem2(long n)
{
    long even_sum = 0;
    long term1 = 1;
    long term2 = 2;
    long temp = 0;
    while (term1 < n)
    {
        term1=term1+term2;
        temp = term1;
        term1 = term2;
        term2 = temp;
        if(term1%2== 0)
        {
            even_sum+=term1;
        }
    }
    return even_sum;
}
Console.WriteLine(problem2(4000000));
long problem3(long n)
{
    
    for(long i =2; i<n; i++)
    {
        if(n%i == 0)
        {
            if (isPrime(n / i))
            {
              return n/i;  
            } 
        }
    }
    return 0;

}
Console.WriteLine(problem3(600851475143));

long problem4()
{
    int first = 999;
    int second = 999;
    while (true)
    {
        string multiplied = (first*second).ToString();
        if(multiplied.Length %2 == 0)
        {
            if(multiplied[:9])
        }
    }
}
// long problem14(long n)
// {
//     int count = 0;
//     while ()
// }