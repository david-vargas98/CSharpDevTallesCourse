partial class Program
{
    static void DirectoryExample()
    {
        // path from we are going to create the directory
        var directoryPath = "./05-Files/";

        // directory creation
        Directory.CreateDirectory($"{directoryPath}/DirExample");

        // subdirectory creation
        Directory.CreateDirectory($"{directoryPath}/DirExample/AnotherDir");

        // validate if a directory exists
        if (Directory.Exists($"{directoryPath}/DirExample/AnotherDir"))
        {
            WriteLine("The directory already exists.");
        }

        // delete a directory
        //Directory.Delete($"{directoryPath}/DirExample/AnotherDir");

        Directory.Delete($"{directoryPath}/DirExample", recursive: true); // 'recursive' deletes parent directories
    }
}