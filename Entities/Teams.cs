using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fifaWorldCup_app.Entities
{
    public class Teams
    {
        private string ? idTeam;
        private string ? nameTeam;
        private Player[] ? players;
        private TeamTechnical[] ? technicals;
        private TeamMedical[] ? medicals;
        private BoardItems ? boardTeam;

        public string? IdTeam { get => idTeam; set => idTeam = value; }
        public string? NameTeam { get => nameTeam; set => nameTeam = value; }
        public Player[]? Players { get => players; set => players = value; }
        public TeamTechnical[]? Technicals { get => technicals; set => technicals = value; }
        public TeamMedical[]? Medicals { get => medicals; set => medicals = value; }
        public BoardItems? BoardTeam { get => boardTeam; set => boardTeam = value; }

    }
}