using DSA5.Entities.Meta;
using DSA5.Entities.Meta.Korrelationen;
using DSA5.Entities.Welt;
using DSA5.Entities.Welt.Modifikatoren;
using DSA5.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DSA5.Infrastructure.Persistence.Context;

public class DsaDbContext : IdentityDbContext
{
    // Welt
    public DbSet<Anwendungsgebiet> Anwendungsgebiete { get; set; } = null!;
    public DbSet<Eigenschaft> Eigenschaften { get; set; } = null!;
    public DbSet<Kultur> Kulturen { get; set; } = null!;
    public DbSet<Kulturgruppe> Kulturgruppen { get; set; } = null!;
    public DbSet<Liturgie> Liturgien { get; set; } = null!;
    public DbSet<Nachteil> Nachteile { get; set; } = null!;
    public DbSet<Sonderfertigkeit> Sonderfertigkeiten { get; set; } = null!;
    public DbSet<Spezies> Spezies { get; set; } = null!;
    public DbSet<Steigerungsfaktor> Steigerungsfaktoren { get; set; } = null!;
    public DbSet<Talent> Talente { get; set; } = null!;
    public DbSet<Talentgruppe> Talentgruppen { get; set; } = null!;
    public DbSet<Tradition> Traditionen { get; set; } = null!;
    public DbSet<Vorteil> Vorteile { get; set; } = null!;
    public DbSet<Zauber> Zauber { get; set; } = null!;

    // Voraussetzungen
    public DbSet<SonderfertigkeitBrauchtEigenschaft> SonderfertigkeitEigenschaftVoraussetzungen { get; set; } = null!;

    public DbSet<SonderfertigkeitBrauchtSonderfertigkeit>
        SonderfertigkeitSonderfertigkeitVoraussetzungen { get; set; } = null!;

    public DbSet<SonderfertigkeitBrauchtTalent> SonderfertigkeitTalentVoraussetzungen { get; set; } = null!;
    public DbSet<SonderfertigkeitBrauchtVorteil> SonderfertigkeitVorteilVoraussetzungen { get; set; } = null!;

    // Modifikatoren
    public DbSet<SonderfertigkeitBedingtAnwendungsgebiet> SonderfertigkeitAnwendungsgebietModifikatoren { get; set; } =
        null!;

    public DbSet<SonderfertigkeitBedingtNachteil> SonderfertigkeitNachteilModifikatoren { get; set; } = null!;
    public DbSet<SpeziesBedingtEigenschaft> SpeziesEigenschaftModifikatoren { get; set; } = null!;

    // Korrelationen
    public DbSet<LiturgieVerbreitung> LiturgieVerbreitungen { get; set; } = null!;
    public DbSet<ZauberVerbreitung> ZauberVerbreitungen { get; set; } = null!;

    // Identity
    public DbSet<DsaUser> DsaUsers { get; set; } = null!;
    public DbSet<DsaRole> DsaRoles { get; set; } = null!;
    
    public DsaDbContext(DbContextOptions options) : base(options)
    {
    }
}