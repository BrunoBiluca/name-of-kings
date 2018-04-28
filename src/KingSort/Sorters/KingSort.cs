using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace KingSort.Sorters {
    public class KingSort : IKingSort {
        public String[] GetSortedList(String[] kings) {

            var kingsList = new List<King>();
            foreach(var king in kings) {
                kingsList.Add(new King(king));
            }
            
            var auxOrdened = kingsList.OrderBy(k => k.Name).ThenBy(k => k.NumberValue);

            var result = new List<String>();
            foreach (var king in auxOrdened) {
                result.Add(king.Name + " " + king.Number);
            }

            return result.ToArray();
        }


    }
}
