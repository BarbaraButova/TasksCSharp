// See https://aka.ms/new-console-template for more information
Console.WriteLine("start");
int FirstNumber = new Random ().Next(1,1000);
int SecondNumber = new Random ().Next(1,1000);
Console.WriteLine(FirstNumber);
Console.WriteLine(SecondNumber);
int SquareSecondNumber = SecondNumber * SecondNumber;
if (SquareSecondNumber == FirstNumber){
Console.WriteLine("Первое число является квадратом второго");  
}
else{
Console.WriteLine("Первое число НЕ является квадратом второго");
} 
Console.WriteLine("end");

