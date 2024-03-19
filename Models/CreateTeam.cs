namespace Cricket_Application.Models
{
    public class CreateTeam
    {
        public int MatchID { get; set; }

        public int TeamID { get; set; } 

        public string TeamName { get; set; }

        public string TeamLogo { get; set; }

        public string MatchDateTime { get; set; }

        public string MatchType { get; set; }

        public string OtherMatchType { get; set; }

        public string BattingTeam {  get; set; }

        public string BallingTeam { get; set; }

        
    }
}
