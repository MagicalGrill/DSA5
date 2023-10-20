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
    public DbSet<Anwendungsgebiet> Anwendungsgebiete { get; set; }
    public DbSet<Aspekt> Aspekte { get; set; }
    public DbSet<Eigenschaft> Eigenschaften { get; set; }
    public DbSet<Fluch> Flueche { get; set; }
    public DbSet<Kampftechnik> Kampftechniken { get; set; }
    public DbSet<Kultur> Kulturen { get; set; }
    public DbSet<Kulturgruppe> Kulturgruppen { get; set; }
    public DbSet<Liturgie> Liturgien { get; set; }
    public DbSet<Merkmal> Merkmale { get; set; }
    public DbSet<Nachteil> Nachteile { get; set; }
    public DbSet<Profession> Professionen { get; set; }
    public DbSet<Schrift> Schriften { get; set; }
    public DbSet<Segnung> Segnungen { get; set; }
    public DbSet<Sonderfertigkeit> Sonderfertigkeiten { get; set; }
    public DbSet<Spezies> Spezies { get; set; }
    public DbSet<Sprache> Sprachen { get; set; }
    public DbSet<Stabzauber> Stabzauber { get; set; }
    public DbSet<Talent> Talente { get; set; }
    public DbSet<Talentgruppe> Talentgruppen { get; set; }
    public DbSet<Tradition> Traditionen { get; set; }
    public DbSet<Vorteil> Vorteile { get; set; }
    public DbSet<Zauber> Zauber { get; set; }
    public DbSet<Zaubertrick> Zaubertricks { get; set; }
    
    // Modifikatoren
    public DbSet<SonderfertigkeitBedingtAnwendungsgebiet> AnwendungsgebieteDurchSonderfertigkeiten { get; set; }
    public DbSet<SonderfertigkeitBedingtNachteil> NachteileDurchSonderfertigkeiten { get; set; }
    public DbSet<SpeziesBedingtEigenschaften> EigenschaftenDurchSpezies { get; set; }
    public DbSet<SpeziesKannEigenschaftBedingen> MoeglicheEigenschaftenDurchSpezies { get; set; }
    
    // Korrelationen
    public DbSet<KulturEmpfiehltNachteil> KulturEmpfiehltNachteile { get; set; }
    public DbSet<KulturEmpfiehltTalent> KulturEmpfiehltTalente { get; set; }
    public DbSet<KulturEmpfiehltVorteil> KulturEmpfiehltVorteile { get; set; }
    public DbSet<LiturgieVerbreitung> LiturgieVerbreitungen { get; set; }
    public DbSet<NachteilBrauchtVorteil> NachteilBrauchtVorteile { get; set; }
    public DbSet<NachteilEmpfiehltNachteil> NachteilEmpfiehltNachteile { get; set; }
    public DbSet<ProfessionEmpfiehltNachteil> ProfessionEmpfiehltNachteile { get; set; }
    public DbSet<ProfessionEmpfiehltSonderfertigkeit> ProfessionEmpfiehltSonderfertigkeiten { get; set; }
    public DbSet<ProfessionEmpfiehltVorteil> ProfessionEmpfiehltVorteile { get; set; }
    public DbSet<SonderfertigkeitBrauchtAspekt> SonderfertigkeitBrauchtAspekte { get; set; }
    public DbSet<SonderfertigkeitBrauchtEigenschaft> SonderfertigkeitBrauchtEigenschaften { get; set; }
    public DbSet<SonderfertigkeitBrauchtLeiteigenschaft> SonderfertigkeitBrauchtLeiteigenschaften { get; set; }
    public DbSet<SonderfertigkeitBrauchtMerkmal> SonderfertigkeitBrauchtMerkmale { get; set; }
    public DbSet<SonderfertigkeitBrauchtSonderfertigkeit> SonderfertigkeitBrauchtSonderfertigkeiten { get; set; }
    public DbSet<SonderfertigkeitBrauchtSpezies> SonderfertigkeitBrauchtSpezies { get; set; }
    public DbSet<SonderfertigkeitEmpfiehltSonderfertigkeit> SonderfertigkeitEmpfiehltSonderfertigkeiten { get; set; }
    public DbSet<SpeziesEmpfiehltKultur> SpeziesEmpfiehltKulturen { get; set; }
    public DbSet<SpeziesEmpfiehltNachteil> SpeziesEmpfiehltNachteile { get; set; }
    public DbSet<SpeziesEmpfiehltVorteil> SpeziesEmpfiehltVorteile { get; set; }
    public DbSet<TraditionEmpfiehltSonderfertigkeit> TraditionEmpfiehltSonderfertigkeiten { get; set; }
    public DbSet<VorteilBrauchtVorteil> VorteilBrauchtVorteile { get; set; }
    public DbSet<VorteilEmpfiehltNachteil> VorteilEmpfiehltNachteile { get; set; }
    public DbSet<ZauberVerbreitung> ZauberVerbreitungen { get; set; }
    
    // Meta
    public DbSet<Erfahrungsgrad> Erfahrungsgrade { get; set; }
    public DbSet<Steigerungsfaktor> Steigerungsfaktoren { get; set; }

    // Identity
    public DbSet<DsaUser> DsaUsers { get; set; } = null!;
    public DbSet<DsaRole> DsaRoles { get; set; } = null!;
    
    public DsaDbContext(DbContextOptions options) : base(options)
    {
    }
}