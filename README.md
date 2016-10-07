# EFpasso1
Projeto criando um Banco de Dados SqlServer Local e usando Entity Framework como ORM


Console application using EF with
automatic migration

0) Create a Console App
1) install-package EntityFramework
2) create a context class that have
DbContext like your superclass

* import System.Data.Entity;

public class Contexto : DbContext
    {

    }


3) Create a POCO class
public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }

* Build your project (Ctrl+shift+b)

4.0) Create the database on server explorer and
get the connectionString

4.1) Create a constructor with calling base ("")
public Contexto(): base("***connection string***")
        {

        }

4.2) Create the DbSet<> for Aluno

5) Adicione a connection string ao app.config
    <connectionStrings>
      <add name="defaultConnection" connectionString="Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Alunos\Documents\DB1.mdf;Integrated Security=True;Connect Timeout=30" providerName="System.Data.SqlClient"/>
    </connectionStrings>
    
6) Crie um Projeto de Teste
* botão direito na solution, add new project, Test, Unit Test
* Ver solution para detalhes da classe de teste.

6.1) Instale o EntityFramework no projeto de Teste
* Não esqueça de escolher o projeto de teste antes 

de install-package EntityFramework
https://github.com/fpnav/EFpasso1.git





