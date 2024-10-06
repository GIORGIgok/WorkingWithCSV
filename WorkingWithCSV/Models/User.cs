using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCSV.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string IpAdress { get; set; } = null!;

        public static User ParseWordData(string data)
        {
            string[] separatedData = data.Split(',');

            if (separatedData.Length != 5)
            {
                throw new FormatException($"Invalid data {data}");
            }

            User user = new User
            {
                Id = int.Parse(separatedData[0]),
                FirstName = separatedData[1],
                LastName = separatedData[2],
                Email = separatedData[3],
                IpAdress = separatedData[4]
            };
            return user;
        }
    }
}
