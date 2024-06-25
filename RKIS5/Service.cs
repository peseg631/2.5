using RKIS5.Models;

namespace RKIS5;

public class Service
{
    private static PesegContext? _db;
    public static PesegContext  GetDbContext()
    {
        if (_db == null)
        {
            _db = new PesegContext();
        }
        return _db;
    }
}