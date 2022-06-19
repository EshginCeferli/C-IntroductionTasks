// See https://aka.ms/new-console-template for more information


// 1) 3 e ve 7 ye bolunen ededler

//int n = 5;
//if (n % 21 == 0)
//{
//    Console.WriteLine(" Dividable");
//}

//else Console.WriteLine("Not dividable");



//// 2) her ikisi cutdurse cemini tapin

//int n = 12;
//int m = 24;
//if (n % 2 == 0 && m % 2 == 0)
//{
//    Console.WriteLine(n + m);
//}
//else
//{
//    Console.WriteLine(" n and m are not even numbers");
//}



//// 3) n ve m arasindaki tek ededlerin cemini tapin

int n = -1;
int m = 6;
int sum = 0;
for (int i = n + 1; i < m; i++)
    if (i % 2 == 1)
        sum += i;
Console.WriteLine(sum);



//// 4) arrayin icindeki tek ededlerin cemini tapin

//int[] arr = { 1, 3, 4, 5, 14, 17, 9, 18 };
//int sum = 0;
//for (int i = 0; i < arr.Length; i++)
//    if (arr[i] % 2 == 1)
//        sum = sum + arr[i];
//Console.WriteLine(sum);



//// 5) arrayin icindeki cut ededlerin sayini tapin

//int[] arr = { 1, 3, 4, 5, 14, 17, 9, 18 };
//int count = 0;
//for (int i = 0; i < arr.Length; i++)
//    if (arr[i] % 2 == 0)
//        count++;
//Console.WriteLine(count);
