using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Appointment
    {
        [JsonPropertyName("id")] // Maps the JSON 'id' key
        public int Id { get; set; }

        [JsonPropertyName("userId")] // Maps the JSON 'userId' key
        public int UserId { get; set; }

        // These properties help in deserializing the separate date and time from JSON
        [JsonPropertyName("date")]
        public string DateString { get; set; } = string.Empty; // Store the raw date string

        [JsonPropertyName("time")]
        public string TimeString { get; set; } = string.Empty; // Store the raw time string

        /// <summary>
        /// Represents the combined date and time of the appointment.
        /// This property is not directly mapped from JSON but calculated after deserialization.
        /// </summary>
        [JsonIgnore] // Prevents trying to serialize/deserialize this property directly
        public DateTime AppointmentDateTime
        {
            get
            {
                // Attempt to parse the date and time strings into a DateTime object
                if (DateTime.TryParse($"{DateString} {TimeString}", out DateTime result))
                {
                    return result;
                }
                // Return a default value or handle error if parsing fails
                return DateTime.MinValue;
            }
            set
            {
                // Update the string properties when this DateTime is set
                DateString = value.ToString("yyyy-MM-dd");
                TimeString = value.ToString("HH:mm");
            }
        }

        [JsonPropertyName("title")] // Maps the JSON 'title' key
        public string Title { get; set; }

        // Default constructor
        public Appointment()
        {
            // Initialize string property
            Title = string.Empty;
        }
    }
}
