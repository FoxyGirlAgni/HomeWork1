Console.WriteLine("Введите число: ");
int num = Int32.Parse(Console.ReadLine());

while(num > 2)
{
if(num % 2 == 0)
{
   Console.Write(num + ",");    
}
    num--;
}
if(num == 2)
{
   Console.Write("num");
}
else 
{ 
   Console.Write("Нет чётных чисел");
}
