using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   // Print "Academy of Learning Career College" to the console
            Console.WriteLine("Academy of Learning Career College");v
            // Print "Student Daily Report" to the console
            Console.WriteLine("Student Daily Report");
            // Print "What is your name?" to the consol
            Console.WriteLine("What is your name?");
            // Read user input from the console and store it in the 'name' variable
            string name = Console.ReadLine();
            // Print "What course are you on?" to the console
            Console.WriteLine("What course are you on?");
            // Read user input from the console and store it in the 'course' variable
            string course = Console.ReadLine();
            // Print "What page number?" to the console
            Console.WriteLine("What page number?");
            // Read user input from the console, convert it to an integer, and store it in the 'pageNum' variable
            int pageNum = Convert.ToInt32(Console.ReadLine());
            // Print a prompt asking if the user needs help, with specific response options, to the console
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            // Read user input from the console and store it in the 'needHelp' variable
            string needHelp = Console.ReadLine();
            // Convert the string input to a boolean and store it in the 'needHelpBool' variable
            bool needHelpBool = bool.Parse(needHelp);
            // Print a prompt asking for any positive experiences to the console
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            // Read user input from the console and store it in the 'positiveExperiences' variable
            string positiveExperiences = Console.ReadLine();
            // Print a prompt asking for any additional feedback to the console
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            // Read user input from the console and store it in the 'feedback' variable
            string feedback = Console.ReadLine();
            // Print "How many hours did you study today?" to the console
            Console.WriteLine("How many hours did you study today?");
            // Read user input from the console and store it in the 'studyHours' variable
            string studyHours = Console.ReadLine();
            // Convert the string input to an integer and store it in the 'studyHoursNum' variable
            int studyHoursNum = Convert.ToInt32(studyHours);
            // Print a thank you message to the console
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            // Read user input from the console (this is typically used to keep the console window open)
            Console.ReadLine();
        }
    }
}
