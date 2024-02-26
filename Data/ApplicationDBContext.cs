using Microsoft.EntityFrameworkCore;
namespace TP2_ASP_web.Data;

public class ApplicationDBContext(DbContextOptions options) : DbContext(options)
{

}
