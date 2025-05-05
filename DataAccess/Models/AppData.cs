using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class AppData
    {
        [JsonPropertyName("Users")]
        public List<User> Users { get; set; } = new List<User>();

        [JsonPropertyName("Appointments")]
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
