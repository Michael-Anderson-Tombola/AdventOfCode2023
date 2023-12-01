using Day1.Question1;

//get file 
//var fileText = File.ReadAllLines("../../../Data/example.txt");
//var fileText = File.ReadAllLines("../../../Data/example2.txt");
var fileText = File.ReadAllLines("../../../Data/input.txt");

Console.WriteLine($"Question 1: {Answer.Question1(fileText)}");
Console.WriteLine($"Question 2: {Answer.QuestionTwo(fileText)}");
