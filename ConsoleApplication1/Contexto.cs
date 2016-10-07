using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("defaultConnection")
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
