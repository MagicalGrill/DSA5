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
    public DbSet<Aspekt> Aspekte { get; set; } = null!;
    public DbSet<Eigenschaft> Eigenschaften { get; set; } = null!;
    public DbSet<Fluch> Flueche { get; set; } = null!;
    public DbSet<Kampftechnik> Kampftechniken { get; set; } = null!;
    public DbSet<Kultur> Kulturen { get; set; } = null!;
    public DbSet<Kulturgruppe> Kulturgruppen { get; set; } = null!;
    public DbSet<Liturgie> Liturgien { get; set; } = null!;
    public DbSet<Merkmal> Merkmale { get; set; } = null!;
    public DbSet<Nachteil> Nachteile { get; set; } = null!;
    public DbSet<Profession> Professionen { get; set; } = null!;
    public DbSet<Schrift> Schriften { get; set; } = null!;
    public DbSet<Segnung> Segnungen { get; set; } = null!;
    public DbSet<Sonderfertigkeit> Sonderfertigkeiten { get; set; } = null!;
    public DbSet<Spezies> Spezies { get; set; } = null!;
    public DbSet<Sprache> Sprachen { get; set; } = null!;
    public DbSet<Stabzauber> Stabzauber { get; set; } = null!;
    public DbSet<Talent> Talente { get; set; } = null!;
    public DbSet<Talentgruppe> Talentgruppen { get; set; } = null!;
    public DbSet<Tradition> Traditionen { get; set; } = null!;
    public DbSet<Vorteil> Vorteile { get; set; } = null!;
    public DbSet<Zauber> Zauber { get; set; } = null!;
    public DbSet<Zaubertrick> Zaubertricks { get; set; } = null!;

    // Modifikatoren
    public DbSet<SonderfertigkeitBedingtAnwendungsgebiet> AnwendungsgebieteDurchSonderfertigkeiten { get; set; } =
        null!;

    public DbSet<SonderfertigkeitBedingtNachteil> NachteileDurchSonderfertigkeiten { get; set; } = null!;
    public DbSet<SpeziesBedingtEigenschaften> EigenschaftenDurchSpezies { get; set; } = null!;
    public DbSet<SpeziesKannEigenschaftBedingen> MoeglicheEigenschaftenDurchSpezies { get; set; } = null!;

    // Korrelationen
    public DbSet<KulturEmpfiehltNachteil> KulturEmpfiehltNachteile { get; set; } = null!;
    public DbSet<KulturEmpfiehltTalent> KulturEmpfiehltTalente { get; set; } = null!;
    public DbSet<KulturEmpfiehltVorteil> KulturEmpfiehltVorteile { get; set; } = null!;
    public DbSet<LiturgieVerbreitung> LiturgieVerbreitungen { get; set; } = null!;
    public DbSet<NachteilBrauchtVorteil> NachteilBrauchtVorteile { get; set; } = null!;
    public DbSet<NachteilEmpfiehltNachteil> NachteilEmpfiehltNachteile { get; set; } = null!;
    public DbSet<ProfessionEmpfiehltNachteil> ProfessionEmpfiehltNachteile { get; set; } = null!;
    public DbSet<ProfessionEmpfiehltSonderfertigkeit> ProfessionEmpfiehltSonderfertigkeiten { get; set; } = null!;
    public DbSet<ProfessionEmpfiehltVorteil> ProfessionEmpfiehltVorteile { get; set; } = null!;
    public DbSet<SonderfertigkeitBrauchtAspekt> SonderfertigkeitBrauchtAspekte { get; set; } = null!;
    public DbSet<SonderfertigkeitBrauchtEigenschaft> SonderfertigkeitBrauchtEigenschaften { get; set; } = null!;
    public DbSet<SonderfertigkeitBrauchtLeiteigenschaft> SonderfertigkeitBrauchtLeiteigenschaften { get; set; } = null!;
    public DbSet<SonderfertigkeitBrauchtMerkmal> SonderfertigkeitBrauchtMerkmale { get; set; } = null!;

    public DbSet<SonderfertigkeitBrauchtSonderfertigkeit> SonderfertigkeitBrauchtSonderfertigkeiten { get; set; } =
        null!;

    public DbSet<SonderfertigkeitBrauchtSpezies> SonderfertigkeitBrauchtSpezies { get; set; } = null!;

    public DbSet<SonderfertigkeitEmpfiehltSonderfertigkeit> SonderfertigkeitEmpfiehltSonderfertigkeiten { get; set; } =
        null!;

    public DbSet<SpeziesEmpfiehltKultur> SpeziesEmpfiehltKulturen { get; set; } = null!;
    public DbSet<SpeziesEmpfiehltNachteil> SpeziesEmpfiehltNachteile { get; set; } = null!;
    public DbSet<SpeziesEmpfiehltVorteil> SpeziesEmpfiehltVorteile { get; set; } = null!;
    public DbSet<TraditionEmpfiehltSonderfertigkeit> TraditionEmpfiehltSonderfertigkeiten { get; set; } = null!;
    public DbSet<VorteilBrauchtVorteil> VorteilBrauchtVorteile { get; set; } = null!;
    public DbSet<VorteilEmpfiehltNachteil> VorteilEmpfiehltNachteile { get; set; } = null!;
    public DbSet<ZauberVerbreitung> ZauberVerbreitungen { get; set; } = null!;

    // Meta
    public DbSet<Erfahrungsgrad> Erfahrungsgrade { get; set; } = null!;
    public DbSet<Steigerungsfaktor> Steigerungsfaktoren { get; set; } = null!;

    // Identity
    public DbSet<DsaUser> DsaUsers { get; set; } = null!;
    public DbSet<DsaRole> DsaRoles { get; set; } = null!;

    public DsaDbContext()
    {
    }

    public DsaDbContext(DbContextOptions<DsaDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        const string connectionString =
            "Host=localhost;Port=5432;Database=dsa5;Username=postgres;Password=Rub!nR0t;Include Error Detail=true";
        builder.UseNpgsql(
            connectionString);
        base.OnConfiguring(builder);
    }
}