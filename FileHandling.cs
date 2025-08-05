using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetbasics
{
    internal class FileHandling
    {

       
        // example of a method that could handle file operations
        public void ReadFile(string filePath)
        {
            try
            {
                if (!System.IO.File.Exists(filePath))
                {
                    System.IO.File.WriteAllText(filePath, "This is the initial content of the file.");
                    Console.WriteLine("File created and initial content written successfully.");
                }
                else
                {
                    // check the file and read its content
                    string content = System.IO.File.ReadAllText(filePath);
                    Console.WriteLine("File content read successfully.");
                    Console.WriteLine(content);

                    // append the content to the file
                    string appendText = "\nThis is appended text.";
                    System.IO.File.AppendAllText(filePath, appendText);
                    content = System.IO.File.ReadAllText(filePath);
                    Console.WriteLine("Text appended successfully.>>>" + content);

                    // remove the content from the file
                    //System.IO.File.WriteAllText(filePath, string.Empty);
                    content = System.IO.File.ReadAllText(filePath);
                    Console.WriteLine("File content removed successfully.>>>" + content);


                    // if file is not present then create and then append text 



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
        }

    }
}
