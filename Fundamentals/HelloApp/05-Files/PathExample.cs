partial class Program
{
    static void PathExamples()
    {
        // source file
        var filePath = "./05-Files/Example.txt";

        // getting file name
        var fileName = Path.GetFileName(filePath);
        WriteLine($"File path name: {fileName}");

        // getting file extension
        var fileExtension = Path.GetExtension(filePath);
        WriteLine($"File extension from file path: {fileExtension}");

        // getting directory name
        var directoryName = Path.GetDirectoryName(filePath);
        WriteLine($"Directory name from file path: {directoryName}");

        // combine paths (kinda building a path)
        var combinedPath = Path.Combine("C:", "Usuarios", "edgar", "Documents", "Example.txt");
        WriteLine($"Combined path: {combinedPath}");

        // getting absolute path from the file
        var absoluteFilePath = Path.GetFullPath(filePath);
        WriteLine($"Absolute path from file path: {absoluteFilePath}");
    }
}