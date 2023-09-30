namespace DSA5.Entities.Welt.Modifikatoren;

public interface INachteilModifikator
{
    Nachteil Nachteil { get; }
    int Stufe { get;}
    Eigenschaft? Eigenschaft { get; }
    Talent? Talent { get; }
}