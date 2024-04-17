using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rangeur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rangeur.DAL.Data.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(p => p.PseudoUser).IsUnique(); //Ajout d'un index sur la colonne Pseudo

            /*builder.Property(u => u.IdUser).ValueGeneratedOnAdd(); *///Id auto-incrémentés

           builder.Property(p => p.IdUser).ValueGeneratedNever(); // retirer l'auto-incrémentation


            builder.HasData(
                new User
                {
                    IdUser = 1,
                    PseudoUser = "ArianaGrande",
                    Role = "Standard",
                    Nom = "Grande",
                    Prenom = "Ariana",
                    DateNaissance = new DateTime(1993, 6, 26),
                    Email = "ariana.grande@example.com",
                    Telephone = 123456789,
                    Password = "password123",
                    DateDerniereConnexion = DateTime.Now,
                    Score = 100
                },
                new User
                {
                    IdUser = 2,
                    PseudoUser = "EdSheeran",
                    Role = "Standard",
                    Nom = "Sheeran",
                    Prenom = "Ed",
                    DateNaissance = new DateTime(1991, 2, 17),
                    Email = "ed.sheeran@example.com",
                    Telephone = 987654321,
                    Password = "password456",
                    DateDerniereConnexion = DateTime.Now,
                    Score = 150
                },
                new User
                {
                    IdUser = 3,
                    PseudoUser = "Beyonce",
                    Role = "Standard",
                    Nom = "Knowles",
                    Prenom = "Beyoncé",
                    DateNaissance = new DateTime(1981, 9, 4),
                    Email = "beyonce.knowles@example.com",
                    Telephone = 555555555,
                    Password = "password789",
                    DateDerniereConnexion = DateTime.Now,
                    Score = 200
                },
                new User
                {   
                    IdUser = 4,
                    PseudoUser = "TomHanks",
                    Role = "Standard",
                    Nom = "Hanks",
                    Prenom = "Tom",
                    DateNaissance = new DateTime(1956, 7, 9),
                    Email = "tom.hanks@example.com",
                    Telephone = 123456789,
                    Password = "password123",
                    DateDerniereConnexion = DateTime.Now,
                    Score = 100
                },
                new User
                {
                    IdUser = 5,
                    PseudoUser = "JenniferLawrence",
                    Role = "Standard",
                    Nom = "Lawrence",
                    Prenom = "Jennifer",
                    DateNaissance = new DateTime(1990, 8, 15),
                    Email = "jennifer.lawrence@example.com",
                    Telephone = 987654321,
                    Password = "password456",
                    DateDerniereConnexion = DateTime.Now,
                    Score = 150
                },
                new User
                {
                    IdUser = 6,
                    PseudoUser = "LeonardoDiCaprio",
                    Role = "Standard",
                    Nom = "DiCaprio",
                    Prenom = "Leonardo",
                    DateNaissance = new DateTime(1974, 11, 11),
                    Email = "leonardo.dicaprio@example.com",
                    Telephone = 555555555,
                    Password = "password789",
                    DateDerniereConnexion = DateTime.Now,
                    Score = 200
                },
                new User
                {
                    IdUser = 7,
                    PseudoUser = "BradPitt",
                    Role = "Standard",
                    Nom = "Pitt",
                    Prenom = "Brad",
                    DateNaissance = new DateTime(1963, 12, 18),
                    Email = "brad.pitt@example.com",
                    Telephone = 111222333,
                    Password = "password123",
                    DateDerniereConnexion = DateTime.Now,
                    Score = 180
                },
                new User
                {
                    IdUser = 8,
                    PseudoUser = "ScarlettJohansson",
                    Role = "Standard",
                    Nom = "Johansson",
                    Prenom = "Scarlett",
                    DateNaissance = new DateTime(1984, 11, 22),
                    Email = "scarlett.johansson@example.com",
                    Telephone = 444555666,
                    Password = "password456",
                    DateDerniereConnexion = DateTime.Now,
                    Score = 220
                },
                new User
                {
                    IdUser = 9,
                    PseudoUser = "DenzelWashington",
                    Role = "Standard",
                    Nom = "Washington",
                    Prenom = "Denzel",
                    DateNaissance = new DateTime(1954, 12, 28),
                    Email = "denzel.washington@example.com",
                    Telephone = 777888999,
                    Password = "password789",
                    DateDerniereConnexion = DateTime.Now,
                    Score = 250
                },

                new User
                {
                    IdUser = 10,
                    PseudoUser = "Lucie",
                    Role = "Admin",
                    Nom = "Tonelli",
                    Prenom = "Lucie",
                    DateNaissance = new DateTime(1982, 03, 10),
                    Email = "lucietonelli@gmail.com",
                    Telephone = 777888999,
                    Password = "password123",
                    DateDerniereConnexion = DateTime.Now,
                    Score = 250
                }
            );


        }
    }
}
