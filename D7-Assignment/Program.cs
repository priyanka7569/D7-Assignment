using System;
using System.IO;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Create File");
            Console.WriteLine("2. Read File");
            Console.WriteLine("3. Append to File");
            Console.WriteLine("4. Delete File");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter file name:");
                    string createFileName = Console.ReadLine();
                    Console.WriteLine("Enter content:");
                    string createFileContent = Console.ReadLine();
                    Console.WriteLine("Enter path to store the file:");
                    string createFilePath = Console.ReadLine();
                    CreateFile(Path.Combine(createFilePath, createFileName), createFileContent);
                    break;

                case "2":
                    Console.WriteLine("Enter file name to read:");
                    string readFile = Console.ReadLine();
                    ReadFile(readFile);
                    break;

                case "3":
                    Console.WriteLine("Enter file name to append:");
                    string appendFileName = Console.ReadLine();
                    Console.WriteLine("Enter content to append:");
                    string appendFileContent = Console.ReadLine();
                    Console.WriteLine("Enter path to the file:");
                    string appendFilePath = Console.ReadLine();
                    AppendToFile(Path.Combine(appendFilePath, appendFileName), appendFileContent);
                    break;

                case "4":
                    Console.WriteLine("Enter file name to delete:");
                    string deleteFileName = Console.ReadLine();
                    Console.WriteLine("Enter path to the file:");
                    string deleteFilePath = Console.ReadLine();
                    DeleteFile(Path.Combine(deleteFilePath, deleteFileName));
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void CreateFile(string filePath, string content)
    {
        try
        {
            File.WriteAllText(filePath, content);
            Console.WriteLine($"File '{filePath}' created successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating file: {ex.Message}");
        }
    }

    static void ReadFile(string filePath)
    {
        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine($"Content of '{filePath}':\n{content}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }

    static void AppendToFile(string filePath, string content)
    {
        try
        {
            File.AppendAllText(filePath, content);
            Console.WriteLine($"Content appended to '{filePath}' successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error appending to file: {ex.Message}");
        }
    }

    static void DeleteFile(string filePath)
    {
        try
        {
            File.Delete(filePath);
            Console.WriteLine($"File '{filePath}' deleted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting file: {ex.Message}");
        }
    }
}