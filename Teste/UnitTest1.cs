using System;
using NUnit.Framework;
using Autoglass.Domain.Entities;

namespace Teste
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Produtos_CriarProduto_NaoPermitirDataFabricacaoMaiorQueValidade()
        {
            System.DateTime hoje = System.DateTime.Now;
            System.DateTime ontem = hoje.AddDays(-1);


            Assert.Throws<ArgumentException>(()=> new Produto("Produto Teste", hoje, ontem, 0) );

        }

        [Test]
        public void Produtos_CriarProduto_PermitirDataFabricacaoMenorQueValidade()
        {
            System.DateTime hoje = System.DateTime.Now;
            System.DateTime amanha = hoje.AddDays(1);


            Assert.DoesNotThrow(() => new Produto("Produto Teste", hoje, amanha, 0));

        }
    }
}