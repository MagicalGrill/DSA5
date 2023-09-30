namespace DSA5.Entities.Welt.Modifikatoren;

public interface IVorteilModifikator
{
    Vorteil Vorteil { get; }
    int Stufe { get;}
    Eigenschaft? Eigenschaft { get; }
    Talent? Talent { get; }
}