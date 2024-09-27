// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.Clear();
int Length = new Random().Next(3,11);
int[] massiv = new int[Length];
int sum = 0;
int min = 0;
int max = 0;
void RandomMassiv(int[] collect){
    int random = 0;
    for(int i = 0;i<collect.Length;i++){
        random = new Random().Next(1,101);
        collect[i] = random;
    }
}
void PrintMassiv(int[] print){
    for(int i = 0; i<print.Length;i++){
        Console.WriteLine(print[i]);
    }
}
void SumBetweenMinMax(int[] scan){
    min = scan[0];
    max = scan[0];
    for(int i = 0;i<scan.Length;i++){
        if(scan[i]<min){
            min = scan[i];
        }
        if(scan[i]>max){
            max = scan[i];
        }
        sum = max - min;
    }
}
RandomMassiv(massiv);
PrintMassiv(massiv);
SumBetweenMinMax(massiv);
Console.WriteLine($"Разница между min и max = {max} - {min} = {sum} " );