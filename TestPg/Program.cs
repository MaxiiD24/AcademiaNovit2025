using System;
using Npgsql;

class Program
{
    static void Main()
    {
        var cs = "Host=localhost;Port=5432;Database=datos;Username=admin;Password=tivon1234";

        using var con = new NpgsqlConnection(cs);
        try
        {
            con.Open();
            Console.WriteLine("✅ Conexión exitosa a PostgreSQL");
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error al conectar:");
            Console.WriteLine(ex.Message);
        }
    }
}
