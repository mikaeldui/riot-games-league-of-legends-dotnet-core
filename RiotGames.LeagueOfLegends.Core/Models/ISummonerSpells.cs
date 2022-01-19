namespace RiotGames.LeagueOfLegends
{
    public interface ISummonerSpells : ILeagueOfLegendsObject
    {
        public byte Spell1Id { get; set; }
        public byte Spell2Id { get; set; }
    }
}
