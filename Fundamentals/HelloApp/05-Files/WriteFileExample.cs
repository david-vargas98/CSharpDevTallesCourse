partial class Program
{
    static void WriteFileExample()
    {
        // path for our file
        var filePath = "./05-Files/WritingExample.txt";

        // content file
        //var content = "This is what we can write out into a file";
        var content = "Instead of the other line, I want this one to be the first line!"; // overwrites the content by default

        // used to write text on files
        var streamWriter = new StreamWriter(filePath, append: true); // (if we want to append the content we set the parameter "append" to true)

        // we write the content variable into the streamWriter instance which holds the file
        streamWriter.WriteLine(content);

        // writing current time on file
        streamWriter.WriteLine($"Current time: {DateTime.Now.ToString("HH:mm:ss")}");

        // release or dispose resources (closing the file)
        streamWriter.Dispose();

        // message for the user
        WriteLine("The file was created successfully");
    }
}