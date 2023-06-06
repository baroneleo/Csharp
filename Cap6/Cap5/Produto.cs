using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap5
{
    internal class Produto
    {
        #region Exercício Produto cap. 4

        /*
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
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
        */

        #endregion

        #region Exercício remodelado com construtores

        /*
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
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
        */

        #endregion

        #region Exercício remodelado com Sobrecarga

        /*
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(string nome, double preco) 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }
        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
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
        */

        #endregion

        #region Exercício remodelado com Sobrecarga "Sintaxe alternativa"

        /*
        public string Nome;
        public double Preco;
        public int Quantidade;
        public Produto() 
        { 
        
        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
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
        */

        #endregion

        #region Exercicio remodelado referenciando um um construtor com outro construtor

        /*
        public string Nome;
        public double Preco;
        public int Quantidade;
        public Produto()
        {
            Quantidade = 10;
        }
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int Quantidade) : this(nome, preco) 
        {
            Quantidade = Quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
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
        */

        #endregion

        #region Exercício utilizando encapsulamento

        /*
        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto()
        {

        }        
        public Produto(string nome, double preco, int quantidade)
        {   
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string GetNome() 
        {
            return _nome;
        }
        public void SetNome(string nome) 
        {
            if( nome != null && nome.Length > 1 ) 
            {
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _quantidade * _preco;
        }
        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        */

        #endregion

        #region Utilização de Properties

        /*
        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;                
                }
            }
        }
        public double Preco
        {
            get { return _preco; }
        }
        public int Quantidade
        {
            get { return _quantidade; }
        }
        public double ValorTotalEmEstoque()
        {
            return _quantidade * _preco;
        }
        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        */

        #endregion

        #region Utilização de autoproperties

        /*
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade {get; private set; }
        
        public Produto()
        {

        }        
        
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }        

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        
        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }
        
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        */

        #endregion

    }
}