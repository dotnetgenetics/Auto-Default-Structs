namespace AutoDefaultStructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Instructor instructor = new Instructor("Greg Esguerra");

            //by default, age will be zero
            Console.WriteLine($"Instructor's name is {instructor.Name}, Age is: {instructor.Age}");

            Console.ReadLine();
        }
    }
}
