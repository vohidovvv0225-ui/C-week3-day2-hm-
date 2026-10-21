// using System;class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("=== Task 1 ===");

//         List<int> numbers1 = new List<int> { 1, 2, 3, 2, 4, 2, 5 };
//         int index = numbers1.LastIndexOf(2);

//         Console.WriteLine(index);


//         Console.WriteLine("\n=== Task 2 ===");

//         List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
//         List<int> list2 = new List<int> { 2, 4 };

//         bool containsAll = list2.All(x => list1.Contains(x));

//         Console.WriteLine(containsAll);


//         Console.WriteLine("\n=== Task 3 ===");

//         List<int> numbers3 = new List<int> { 1, 2, 3, 4, 5 };

//         numbers3.Reverse();

//         Console.WriteLine(string.Join(", ", numbers3));


//         Console.WriteLine("\n=== Task 4 ===");

//         List<int> numbers4 = new List<int>();

//         if (numbers4.Count == 0)
//             Console.WriteLine("List is empty");
//         else
//             Console.WriteLine("List is not empty");


//         Console.WriteLine("\n=== Task 5 ===");

//         List<int> numbers5 = new List<int>
//         {
//             10, 20, 30, 40, 50, 60
//         };

//         List<int> sublist = numbers5.GetRange(1, 3);

//         Console.WriteLine(string.Join(", ", sublist));


//         Console.WriteLine("\n=== Task 6 ===");

//         List<int> numbers6 = new List<int> { 5, 2, 8, 1, 3 };

//         numbers6.Sort();

//         Console.WriteLine(string.Join(", ", numbers6));


//         Console.WriteLine("\n=== Task 7 ===");

//         List<int> numbers7 = new List<int> { 1, 2, 3, 4, 5 };

//         numbers7.Clear();

//         Console.WriteLine("Count: " + numbers7.Count);


//         Console.WriteLine("\n=== Task 8 ===");

//         List<int> numbers8 = new List<int> { 15, 3, 27, 8, 1 };

//         Console.WriteLine("Max: " + numbers8.Max());
//         Console.WriteLine("Min: " + numbers8.Min());


//         Console.WriteLine("\n=== Task 9 ===");

//         List<int> numbers9 = new List<int>
//         {
//             1, 2, 3, 4, 5, 6, 7, 8
//         };

//         numbers9.RemoveAll(x => x % 2 == 0);

//         Console.WriteLine(string.Join(", ", numbers9));


//         Console.WriteLine("\n=== Task 10 ===");

//         List<int> numbers10 = new List<int>
//         {
//             1, 2, 3, 4, 5, 6, 7, 8, 9, 10
//         };

//         Random random = new Random();

//         for (int i = numbers10.Count - 1; i > 0; i--)
//         {
//             int j = random.Next(i + 1);

//             int temp = numbers10[i];
//             numbers10[i] = numbers10[j];
//             numbers10[j] = temp;
//         }

//         Console.WriteLine(string.Join(", ", numbers10));
//     }
// }
