int uInput = 0;
int counter = 0;

float pool = 0;
float avg = 0;

while (true)
{
    uInput = int.Parse(Console.ReadLine());
    counter++;
    pool += uInput;
    avg = pool / counter;

    //This part is just a copy so that it is able to take two user defined numbers and find the average.
    //If this algorythm is removed, you will just end up with a program that will infinitely calculate the average as long as the user inputs new numbers.
    //The program will continue to find the average of EVERY number input, while adding it to the pool. 
    uInput = int.Parse(Console.ReadLine());
    counter++;
    pool += uInput;
    avg = pool / counter;

    //This part's purpose is to restart the code after the average of two numbers is found.
    //While restarting, it also resets the variables to avoid finding the average on behalf of previous iterations in the current session.
    Console.WriteLine(avg);
    Console.WriteLine("New numbers?");
    Console.ReadLine();
    Console.Clear();

    uInput = 0;
    counter = 0;

    pool = 0;
    avg = 0;
}