//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int number =  int.Parse(Console.ReadLine()!);
string Number= Convert.ToString(number);
Console.WriteLine (number);
int [] array= new int[Number.Length];
int i;
for (i=0; i<Number.Length; i++)
{
    array[i]= Convert.ToInt32(Number[i].ToString());
}
if (Number.Length<=2)
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{
    Console.Write(array[2]);
}