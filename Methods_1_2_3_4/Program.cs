// Метод 1 не принимает никаких аргументов, ничего не возвращает.

// Описание
void Method1();
{
 Console.WriteLine("Автор   " );
}
Method1();


// Метод 2 может принять какие-то аргументы,но ничего не возвращает.

// Описание
void Method2(string msg);
{
 Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

// Описание
void Method21(string msg, int count);
{
  int i = 0;
  while (i < count)
  {
      Console.WriteLine(msg);
      i++;
  }
}
 
Method21(msg: "Текст", count:4);
//или // Method21(count:4; msg: "Новый текст");


// Метод 3 не принимает никаких аргументов,но может что-то возвращать.

// Описание
int Method3();
{
  return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// Метод 4 может принять какие-то аргументы, может что-то возвращать для дальнейшей работы.   Это метод используется чаще других.

// Описание
string Method4(int count, string text)
{
  
  int i = 0;
  string result = String.Empty;

  while (i < count)
  {
      result = result + text;
      i++;
  }
  return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);