using WorkingWithCSV.Models;

namespace WorkingWithCSV
{
    class Program
    {

        static void Main()
        {
            string[] data = File.ReadAllLines(@"../../../mock_data.csv");

            /// check if it works
            User parsedData = User.ParseWordData("10,Haydon,Barnshaw,hbarnshaw9@google.nl,152.111.235.194");
        }
    }
}