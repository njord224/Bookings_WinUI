namespace DataAccess
{
    public static class DataHelper
    {
        public static IEnumerable<Models.User> Users { get; set; } = new List<Models.User>();
        public static IEnumerable<Models.Appointment> Appointments { get; set; } = new List<Models.Appointment>();

        public static void ProcessJSON()
        {
            if(Users==null || !Users.Any() || Appointments == null || !Appointments.Any())
            {
                string jsonData = @"{
                                ""Users"": [
                                    {
                                    ""id"": 1,
                                    ""name"": ""Alice Wonderland"",
                                    ""telephone"": ""+34 611 223 344"",
                                    ""username"": ""aliceW""
                                    },
                                    {
                                    ""id"": 2,
                                    ""name"": ""Bob The Builder"",
                                    ""telephone"": ""+34 655 667 788"",
                                    ""username"": ""bobB""
                                    },
                                    {
                                    ""id"": 3,
                                    ""name"": ""Charlie Chaplin"",
                                    ""telephone"": ""+34 699 001 122"",
                                    ""username"": ""charlieC""
                                    }
                                ],
                                ""Appointments"": [
                                    {
                                    ""id"": 101,
                                    ""userId"": 1,
                                    ""date"": ""2025-06-02"",
                                    ""time"": ""10:00"",
                                    ""title"": ""Consultation Meeting""
                                    },
                                    {
                                    ""id"": 102,
                                    ""userId"": 2,
                                    ""date"": ""2025-06-02"",
                                    ""time"": ""14:30"",
                                    ""title"": ""Project Review""
                                    },
                                    {
                                    ""id"": 103,
                                    ""userId"": 1,
                                    ""date"": ""2025-06-05"",
                                    ""time"": ""11:15"",
                                    ""title"": ""Follow-up Call""
                                    },
                                    {
                                    ""id"": 104,
                                    ""userId"": 3,
                                    ""date"": ""2025-06-09"",
                                    ""time"": ""09:00"",
                                    ""title"": ""Introductory Session""
                                    },
                                    {
                                    ""id"": 105,
                                    ""userId"": 2,
                                    ""date"": ""2025-06-11"",
                                    ""time"": ""16:00"",
                                    ""title"": ""Team Sync""
                                    },
                                    {
                                    ""id"": 106,
                                    ""userId"": 1,
                                    ""date"": ""2025-06-16"",
                                    ""time"": ""10:30"",
                                    ""title"": ""Check-in""
                                    },
                                    {
                                    ""id"": 107,
                                    ""userId"": 3,
                                    ""date"": ""2025-06-18"",
                                    ""time"": ""13:00"",
                                    ""title"": ""Workshop Prep""
                                    },
                                    {
                                    ""id"": 108,
                                    ""userId"": 2,
                                    ""date"": ""2025-06-20"",
                                    ""time"": ""09:45"",
                                    ""title"": ""Client Demo""
                                    },
                                    {
                                    ""id"": 109,
                                    ""userId"": 3,
                                    ""date"": ""2025-06-24"",
                                    ""time"": ""15:00"",
                                    ""title"": ""Planning Meeting""
                                    },
                                    {
                                    ""id"": 110,
                                    ""userId"": 1,
                                    ""date"": ""2025-06-27"",
                                    ""time"": ""11:00"",
                                    ""title"": ""Final Review""
                                    },
                                    {
                                    ""id"": 111,
                                    ""userId"": 2,
                                    ""date"": ""2025-06-30"",
                                    ""time"": ""14:00"",
                                    ""title"": ""Wrap-up Session""
                                    }
                                ]
                                }";

                var appData = System.Text.Json.JsonSerializer.Deserialize<Models.AppData>(jsonData);

                if (appData != null)
                {
                    Users = appData.Users ?? new List<Models.User>();
                    Appointments = appData.Appointments ?? new List<Models.Appointment>();
                }
            }
        }

        public static IEnumerable<Models.User> GetUsers()
        {
            ProcessJSON();
            return Users;
        }
        public static IEnumerable<Models.Appointment> GetAppointments()
        {
            ProcessJSON();
            return Appointments;
        }
        public static Models.User GetUser(int id)
        {
            ProcessJSON();
            return Users.FirstOrDefault(x=>x.Id == id);
        }
        public static Models.Appointment GetAppointment(int id)
        {
            ProcessJSON();
            return Appointments.FirstOrDefault(x=>x.Id==id);
        }

    }
}
