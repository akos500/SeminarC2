int number = ReadInt("Введите трехзначное число: ");
int meaning = number.ToString().Length;

if (meaning < 3 || meaning > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}


// Функция принимает сообщение для отображения в консоли
// и выводит результат введенных данных 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция вывода цифры,находящейся в середине трехзначного числа
int InCenter(int a)
{
    int result = ((a / 10) % 10);
    return result;
}
