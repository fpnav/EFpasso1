using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PodeInserirUmAlunoNaBase()
        {
            Aluno aluno = new Aluno();
            aluno.Id = 1;
            aluno.Nome = "John";
            aluno.Email = "john@teste.com";
            Contexto db = new Contexto();
            db.Alunos.Add(aluno);
            db.SaveChanges();

            var alunoFromDb = db.Alunos.Find(1);
            Assert.IsNotNull(alunoFromDb);
        }
    }
}
