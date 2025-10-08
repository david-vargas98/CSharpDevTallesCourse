partial class Program
{
    static void FileExample()
    {
        string filePath = "./05-Files/Example.txt";

        // reading all the file content
        WriteLine("ReadAllText:");
        string fileContent = File.ReadAllText(filePath);
        WriteLine(fileContent);

        // reading all the file content and each line will be an array element
        WriteLine("ReadAllLines:");
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            WriteLine($"New line - {line}");
        }

        // getting a specific line by using its index as a normal array
        WriteLine($"\nSpecific line: {lines[1]}");

        // copying a file
        string filePathDest = "./05-Files/Example_copy.txt";

        File.Copy(filePath, filePathDest, overwrite: true);

        // delete a file (copied file)
        File.Delete(filePathDest);
    }
}