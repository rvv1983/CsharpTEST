// C# написать программу которая из имеющегося массива строк формирует массив строк длина которых меньше либо равна 3 символа
//  1) Заполняем исходный массив
string[] array ={"Hallow","2","five","second","yes","im"};
//  2) Вводим переменные нового массива (выводящего результат)
var result = new string[array.Length];
var newSize = 0;
//  3) Вводим условия (критерии отбора) 
foreach (var value in array)
{
  if (value.Length <= 3)
  {
  result[newSize] = value;
  newSize++;
  }
}
//  4) Выводим результат построчным методом
Console.WriteLine(string.Join(Environment.NewLine, result, 0, newSize)); 
