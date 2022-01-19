using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace RiotGames.LeagueOfLegends
{
    public interface ILeagueOfLegendsException : IRiotGamesException, ILeagueOfLegendsObject
    {
    }

    /// <summary>
    /// Provides an <see cref="Exception" /> for League of Legends based on <see cref="RiotGamesException"/> and <see cref="ILeagueOfLegendsException"/>.
    /// </summary>
    public class LeagueOfLegendsException : RiotGamesException, ILeagueOfLegendsException, ILeagueOfLegendsObject
    {
        public LeagueOfLegendsException()
        {
        }

        public LeagueOfLegendsException(string message) : base(message)
        {
        }

        public LeagueOfLegendsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LeagueOfLegendsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
