﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokeVerse.Data;

namespace PokeVerse.Data.PokeMigrations
{
    [DbContext(typeof(PokeVerseDbContext))]
    partial class PokeVerseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PokeVerse.Models.Pokedex", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TrainerId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PokeDex");
                });

            modelBuilder.Entity("PokeVerse.Models.PokedexPokemon", b =>
                {
                    b.Property<int>("PokedexId")
                        .HasColumnType("int");

                    b.Property<int>("PokemonId")
                        .HasColumnType("int");

                    b.HasKey("PokedexId", "PokemonId");

                    b.HasIndex("PokemonId");

                    b.ToTable("PokedexPokemon");
                });

            modelBuilder.Entity("PokeVerse.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PokeNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type0")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Attack")
                        .HasColumnType("int");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

            
                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pokemon");
                });

            modelBuilder.Entity("PokeVerse.Models.PokemonType", b =>
                {
                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("PokemonId")
                        .HasColumnType("int");

                    b.HasKey("TypeId", "PokemonId");

                    b.HasIndex("PokemonId");

                    b.ToTable("PokemonTypes");
                });

            modelBuilder.Entity("PokeVerse.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("PokeVerse.Models.PokedexPokemon", b =>
                {
                    b.HasOne("PokeVerse.Models.Pokedex", "Pokedex")
                        .WithMany("PokedexPokemons")
                        .HasForeignKey("PokedexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokeVerse.Models.Pokemon", "Pokemon")
                        .WithMany("PokedexPokemon")
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PokeVerse.Models.PokemonType", b =>
                {
                    b.HasOne("PokeVerse.Models.Pokemon", "Pokemon")
                        .WithMany("PokemonTypes")
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokeVerse.Models.Type", "Type")
                        .WithMany("PokemonTypes")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
