// Serialization: convert an object into a string
// Deserialization: convert a string into an object (opposite to serialization) 
using System.Text.Json;

namespace ManageJsonFile
{
    partial class Program
    {
        public static void ManageJsonFile()
        {
            // Task: serialize the character to a Json
            List<Character> characters =
            [
              new Character { Id = 1, Name = "Peter Parker", Alias = "Spider", Team = "Avengers" },
              new Character { Id = 2, Name = "Tony Stark", Alias
              = "Iron Man", Team = "Avengers" },
              new Character { Id = 3, Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" }
            ];

            // ------- Serialization

            // the "Serialize" method from the "JsonSerializer" class within the "System.Text.Json" namespace, serializes the objects
            // jsonTypeInfo argument (long one) allows us to indent the json file output
            var charactersJson = JsonSerializer.Serialize(characters, new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });

            // writing the serialized objects into a file
            string filePath = "./05-Files/Characters.json";
            File.WriteAllText(filePath, charactersJson);

            // -------Deserialization

            // reading context file
            var charactersFromFile = File.ReadAllText(filePath);

            // deserialization
            var characterList = JsonSerializer.Deserialize<List<Character>>(charactersFromFile);
            if (characterList == null) return;

            // showing deserialized json into objects
            WriteLine("\tDeserialized characters");
            foreach (var character in characterList)
            {
                WriteLine($"ID: {character.Id} - Name: {character.Name} - Alias: {character.Alias}, Team: {character.Team}");
            }
        }
    }

    class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public string? Team { get; set; }
    }
}