// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokemonApi.Models;

namespace PokemonApi.Migrations
{
    [DbContext(typeof(PokemonApiContext))]
    partial class PokemonApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PokemonApi.Models.Pokemon", b =>
                {
                    b.Property<int>("PokemonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("PokemonId");

                    b.ToTable("Pokemon");

                    b.HasData(
                        new
                        {
                            PokemonId = 279,
                            Description = "It is a messenger of the skies, carrying small Pokémon and eggs to safety in its bill.",
                            Name = "Pelipper"
                        },
                        new
                        {
                            PokemonId = 773,
                            Description = "A solid bond of trust between this Pokémon and its Trainer awakened the strength hidden within Silvally. It can change its type at will.",
                            Name = "Silvally"
                        },
                        new
                        {
                            PokemonId = 625,
                            Description = "It’s accompanied by a large retinue of Pawniard. Bisharp keeps a keen eye on its minions, ensuring none of them even think of double-crossing it.",
                            Name = "Bisharp"
                        },
                        new
                        {
                            PokemonId = 493,
                            Description = "According to the legends of Sinnoh, this Pokémon emerged from an egg and shaped all there is in this world.",
                            Name = "Arceus"
                        },
                        new
                        {
                            PokemonId = 90,
                            Description = "It swims facing backward by opening and closing its two-piece shell. It is surprisingly fast.",
                            Name = "Shellder"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
