﻿namespace Infrastructure.Persistence
{
    public class Settings
    {
        public static string PostgreSQLConnectionString { get; set; }

        public static string RabbitMQConnectionString { get; set; }
    }
}
