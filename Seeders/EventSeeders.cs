using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleDotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace CordiSimpleDotnet.Seeders
{
    public class EventSeeders
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    Name = "feria del libro",
                    Description = "encuentro literario con escritores y editoriales locales.",
                    StartDate = new DateTime(2024, 10, 25, 9, 0, 0),
                    EndDate = new DateTime(2024, 10, 29, 18, 0, 0),
                    Location = "plaza mayor, medellín",
                    Capacity = 250,
                    OccupiedSlots = 0,
                    Status = true
                },
                new Event
                {
                    Id = 2,
                    Name = "expo tecnología",
                    Description = "exposición de avances tecnológicos y nuevas innovaciones.",
                    StartDate = new DateTime(2024, 12, 1, 10, 0, 0),
                    EndDate = new DateTime(2024, 12, 1, 18, 0, 0),
                    Location = "corferias, bogotá",
                    Capacity = 250,
                    OccupiedSlots = 0,
                    Status = true
                },
                new Event
                {
                    Id = 3,
                    Name = "exposición de arte moderno",
                    Description = "exposición de obras de arte contemporáneo de artistas colombianos.",
                    StartDate = new DateTime(2024, 11, 20, 11, 0, 0),
                    EndDate = new DateTime(2024, 11, 20, 20, 0, 0),
                    Location = "museo de arte moderno, cartagena",
                    Capacity = 250,
                    OccupiedSlots = 0,
                    Status = false
                },
                new Event
                {
                    Id = 4,
                    Name = "concierto de navidad",
                    Description = "concierto navideño con coros y orquestas locales.",
                    StartDate = new DateTime(2024, 12, 15, 19, 0, 0),
                    EndDate = new DateTime(2024, 12, 15, 21, 0, 0),
                    Location = "teatro metropolitano, medellín",
                    Capacity = 250,
                    OccupiedSlots = 0,
                    Status = true
                },
                new Event
                {
                    Id = 5,
                    Name = "festival de cine",
                    Description = "proyección de películas y charlas con cineastas colombianos.",
                    StartDate = new DateTime(2024, 10, 30, 14, 0, 0),
                    EndDate = new DateTime(2024, 11, 2, 22, 0, 0),
                    Location = "cine colombia, cali",
                    Capacity = 250,
                    OccupiedSlots = 0,
                    Status = true
                },
                new Event
                {
                    Id = 6,
                    Name = "congreso de medicina",
                    Description = "encuentro de profesionales de la salud con charlas y talleres.",
                    StartDate = new DateTime(2024, 11, 5, 8, 0, 0),
                    EndDate = new DateTime(2024, 11, 7, 17, 0, 0),
                    Location = "hotel hilton, cartagena",
                    Capacity = 250,
                    OccupiedSlots = 0,
                    Status = true
                },
                new Event
                {
                    Id = 7,
                    Name = "expo gastronómica",
                    Description = "muestra de la gastronomía colombiana con degustaciones y talleres.",
                    StartDate = new DateTime(2024, 12, 10, 10, 0, 0),
                    EndDate = new DateTime(2024, 12, 12, 19, 0, 0),
                    Location = "centro de convenciones, cali",
                    Capacity = 250,
                    OccupiedSlots = 0,
                    Status = false
                },
                new Event
                {
                    Id = 8,
                    Name = "festival de danza folclórica",
                    Description = "presentaciones de grupos de danza folclórica de diferentes regiones.",
                    StartDate = new DateTime(2024, 11, 18, 15, 0, 0),
                    EndDate = new DateTime(2024, 11, 18, 19, 0, 0),
                    Location = "plaza mayor, medellín",
                    Capacity = 250,
                    OccupiedSlots = 0,
                    Status = true
                },
                new Event
                {
                    Id = 9,
                    Name = "carrera 10k",
                    Description = "competencia de atletismo en diferentes categorías.",
                    StartDate = new DateTime(2024, 12, 20, 7, 0, 0),
                    EndDate = new DateTime(2024, 12, 20, 12, 0, 0),
                    Location = "parque simón bolívar, bogotá",
                    Capacity = 250,
                    OccupiedSlots = 0,
                    Status = true
                },
                new Event
                {
                    Id = 10,
                    Name = "festival de música",
                    Description = "un festival de música al aire libre con artistas nacionales e internacionales.",
                    StartDate = new DateTime(2024, 11, 10, 12, 0, 0),
                    EndDate = new DateTime(2024, 11, 10, 23, 59, 0),
                    Location = "parque simón bolívar, bogotá",
                    Capacity = 250,
                    OccupiedSlots = 0,
                    Status = true
                }
                );
        }
    }
}
