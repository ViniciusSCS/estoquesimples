using System.ComponentModel;
using System;
using System.Globalization;

namespace Estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            double valorTotalEmEstoque = Preco * Quantidade;
            return valorTotalEmEstoque;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade 
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}