// THIS IS MY BEST PROGRAM EVER
//ITS SO GOOD
//YOU SHOULD TRY IT NOW

Console.WriteLine("Write minutes");
int minutes = Convert.ToInt32(Console.ReadLine());
int sixty = 60;

int first = (minutes / sixty);
int second = (minutes % sixty);

Console.WriteLine($"{first}:{second}");
