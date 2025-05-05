using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class User
    {
        [JsonPropertyName("id")] // Maps the JSON 'id' key to this property
        public int Id { get; set; }

        [JsonPropertyName("name")] // Maps the JSON 'name' key
        public string Name { get; set; }

        [JsonPropertyName("telephone")] // Maps the JSON 'telephone' key
        public string Telephone { get; set; }

        [JsonPropertyName("username")] // Maps the JSON 'username' key
        public string Username { get; set; }

        // Default constructor
        public User()
        {
            // Initialize string properties to avoid null reference issues if needed
            Name = string.Empty;
            Telephone = string.Empty;
            Username = string.Empty;
        }
    }
}
