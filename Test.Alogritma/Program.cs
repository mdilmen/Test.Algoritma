// See https://aka.ms/new-console-template for more information
using Test.Algoritma;

Console.WriteLine("Hello, World!");
Console.WriteLine("Input for validation : ");
string? testValue = Console.ReadLine();
Tester tester = new ();
TesterEnhanced testerEnhanced = new();

bool resultTester  = tester.IsValid(testValue);
Console.WriteLine($"Tester  --> {testValue} isValid {resultTester}");

bool resultTesterEnhanced = testerEnhanced.IsValid(testValue);
Console.WriteLine($"Tester Extra --> {testValue} isValid {resultTester}");
Console.WriteLine($"End");
Console.ReadKey();



