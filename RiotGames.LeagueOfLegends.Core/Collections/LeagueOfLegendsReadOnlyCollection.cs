using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace RiotGames.LeagueOfLegends
{
    [JsonReadOnlyCollection, DebuggerDisplay("Count = {Count}")]
    public class LeagueOfLegendsReadOnlyCollection<TValue> : RiotGamesReadOnlyCollection<TValue>, ILeagueOfLegendsObject
    {
        public LeagueOfLegendsReadOnlyCollection(IList<TValue> list) : base(list)
        {
        }
    }
}
