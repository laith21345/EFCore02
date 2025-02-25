using Program.DbContexts;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext context = new ITIDbContext();
        }
    }
}
