namespace Vehiculos20190879.Data.Models;

public class Vehiculos
{
    public int VehiculoID { get; set; }
    public string Marca { get; set; } = null!;
    public string Modelo { get; set; } = null!;
    public int Ano { get; set; }  
    public string Color { get; set; } = null!;
}