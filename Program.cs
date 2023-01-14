//Задача 1
//Console.WriteLine("Введите трехзначное число");
//int A = int.Parse(Console.ReadLine()!) ;
//int B = (A%100)/10;
//if (A>99 && A<1000)
//{
//    Console.WriteLine($"{A}->{B}"); 
//}
//else {
//    Console.WriteLine ($"Число {A} не является трехзначным");
//}


// Задача 2 
//Console.WriteLine ("Введите число");
//int S = int.Parse(Console.ReadLine()!);
//int D = S%10;
//int B = (S%100)/10;
//int C = (S%1000)/100;
//if (S>1 && S<100){
//    Console.WriteLine($"число не имеет третьей цифры");
//}
//if(S>99 && S<1000){
//    Console.WriteLine($"{S}->{D}");
//} 
//if (S>999 && S<10000){
//    Console.WriteLine($"{S}->{B}");
//}
//if (S>9999 && S<100000)
//{
//    Console.WriteLine($"{S}->{C}");
//}


// Задача 3

Console.WriteLine ("Введите число, которое соответствует дню недели");
int Z =  int.Parse(Console.ReadLine()!);
if( Z==6 || Z==7){
Console.WriteLine($"Да, выходной");
}
else {
    Console.WriteLine($"Нет");
}

