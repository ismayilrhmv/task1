
//Console.Write("eded daxil edin--");
//int n=int.Parse(Console.ReadLine());
//int sum = 0;

//while (n > 0)
//{
//    sum += n % 10;
//    n /= 10;
//}

//Console.WriteLine("Reqemlerin cemi: " + sum);


Console.Write("eded daxil edin--");
int num = int.Parse(Console.ReadLine());
string poli = num.ToString();
string polinom = "";
while (num > 0)
{
    polinom += num % 10;
    num /= 10;
}

if(polinom ==  poli)
{
    Console.WriteLine("polinomdur");
}
else
{
    Console.WriteLine("polinom deyil");
}

