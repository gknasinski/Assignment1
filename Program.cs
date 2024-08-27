﻿string? choice;
string file = "characterData.txt";
do
{
    // ask user a question
    Console.WriteLine("1) Read data from file.");
    Console.WriteLine("2) Create file from data.");
    Console.WriteLine("Enter any other key to exit.");
    // input response
    choice = Console.ReadLine();

    if (choice == "1")
    {
        // TODO: read data from file
    }
    else if (choice == "2")
    {
        // create file from data
        StreamWriter sw = new(file);
        for (int i = 0; i < 7; i++)
        {
            // ask a question
            Console.WriteLine("Enter a character (Y/N)?");
            // input the response
            string? resp = Console.ReadLine();
            // if the response is anything other than "Y", stop asking
            if (resp != "Y") { break; }
            // prompt for course name
            Console.WriteLine("Enter the character id.");
            // save the course name
            string? id = Console.ReadLine();
            // prompt for course grade
            Console.WriteLine("Enter the character name.");
            // save the course grade
            string? name = Console.ReadLine();

            Console.WriteLine("Enter the character relation to Mario.");
            // save the course name
            string? relation = Console.ReadLine();
            sw.WriteLine("{0}|{1}|{2}", id, name, relation);
        }
        sw.Close();
    }
} while (choice == "1" || choice == "2");