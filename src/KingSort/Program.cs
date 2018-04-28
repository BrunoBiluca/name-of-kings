using System;
using KingSort.Sorters;

namespace KingSort {
    /// <summary>
    /// Estou tratando essa função como que fosse o endpoint do serviço
    /// Assim em um API retornaria o JSON com os itens ordenados
    /// </summary>
    class Program {
        static void Main(string[] args) {

            String[] test = { "Louis IX", "Louis VIII" };

            var orderedKings = DoSort(test, new Sorters.KingSort());

            foreach (var king in orderedKings) {
                Console.WriteLine(king);    
            }

            Console.ReadKey();

        }

        // Declarar uma interface como parâmetro nos permite alterar a implementação de forma dinâmica,
        // isso pode ser interessante se as funcionalidades do sistema são alteradas constantemente
        private  static String[] DoSort(String[] kings, IKingSort sort) {
            return sort.GetSortedList(kings);
        }
    }
}
