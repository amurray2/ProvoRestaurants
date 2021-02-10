using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoRestaurants.Models
{
    public class SuggestionStorage
    {
        public static List<Suggestions> Suggestions = new List<Suggestions>();

        public static IEnumerable<Suggestions> suggestionList => Suggestions;

        public static void AddSuggestion(Suggestions myObject)
        {
            Suggestions.Add(myObject);
        }
    }
}
