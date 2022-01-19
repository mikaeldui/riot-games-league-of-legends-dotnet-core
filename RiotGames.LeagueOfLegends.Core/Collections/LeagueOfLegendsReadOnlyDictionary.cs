using System.Diagnostics;
using System.Text.Json.Serialization;

namespace RiotGames.LeagueOfLegends
{
    [JsonReadOnlyDictionary, DebuggerDisplay("Count = {Count}")]
    public class LeagueOfLegendsReadOnlyDictionary<TKey, TValue> : RiotGamesReadOnlyDictionary<TKey, TValue>, ILeagueOfLegendsObject
        where TKey : notnull
    {
        public LeagueOfLegendsReadOnlyDictionary(IDictionary<TKey, TValue> dictionary) : base(dictionary)
        {
        }
    }
}
