using System;

namespace NovoPrograma
{
    class Class12
    {

       public  string Nome { get; private set; }
        public double Preco { get; private set; }
        private int _quantidade;


        public Class12(string nome, double preco, int Quantidade)
        {
            Nome = nome;
            Preco = preco;
            _quantidade = Quantidade;
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value > 0)
                {
                    _quantidade = value;

                }
            }
        }
        public double QuantidadeTotal()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return $"Nome:{Nome}\nPreço:R${Preco}\nQuantidade:{_quantidade}";
        }

    }

}
