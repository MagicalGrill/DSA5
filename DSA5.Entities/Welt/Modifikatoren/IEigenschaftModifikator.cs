namespace DSA5.Entities.Welt.Modifikatoren;

public interface IEigenschaftModifikator
{
    Eigenschaft Eigenschaft { get; }
    int Wert { get; }
}