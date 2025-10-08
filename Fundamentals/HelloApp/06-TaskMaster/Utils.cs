namespace TaskMaster
{
    public class Utils
    {
        public static string GenerateId()
        {
            return Guid.NewGuid().ToString("N")[..7]; // returns a string without dashes ("N") and only the first 7 characters ([..7])
        }
    }
}