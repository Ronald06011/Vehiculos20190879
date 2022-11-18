using Vehiculos20190879.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculos20190879.Data.Context;

public class MyDB:DbContext,IMyDB
{
  public virtual DbSet<Vehiculos> Vehiculo {get; set;} = null!;

}


public interface IMyDB
{
    public  DbSet<Vehiculos> Vehiculo {get; set;} 


    public int SaveChanges();
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
