using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsParteUm.Entidades
{
     class ServicoPrint<T> 
    {
        private T[] _arr = new T[10];
        private int _count = 0;
        public List<T> FA = new List<T>();


        public void AdicionarValor(T valor)
        {
        
            if(_count == 10)
            {
                throw new InvalidOperationException("Print ja esta cheio");
            }
            _arr[_count] = valor;
            _count++;
        }
        public T Primeiro()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Não existe número nesta lista");
            }
            return _arr[0];
        }

        public T Max<T>(List<T> list) where T : IComparable
        {
            T teste = list[0];
            if (list[2].CompareTo(teste) > 10)
            {
                return teste;
            }
            return teste;
        }
        public void Ler()
        {
            Console.Write("[");
            for(int i = 0; i < _count - 1; i++)
            {
                Console.Write(_arr[i]+ ", ");
            }
            if(_count > 0)
            {
                Console.Write(_arr[_count -1]);
            }
            Console.WriteLine(" ]");
            
        }

    }
}
