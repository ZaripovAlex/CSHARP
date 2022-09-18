Console.Write("Введите номер дня недели ");
int num = Int32.Parse(Console.ReadLine());
if((num>0) && (num<6))
{
     Console.Write("Будни ");
}
else if ((num==6)||(num==7)) 
{
    Console.Write( "Выходной!!!");
}
else
{
     Console.Write("Такой хоккей нам не нужен!");
}
