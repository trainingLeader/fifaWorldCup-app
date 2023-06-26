using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fifaWorldCup_app.Entities
{
    public class TeamTechnical
    {
        private string ? idTeamTechnical;
        private string ? nameTeamTechnical;
        private string ? rolTeamTechnical;
        private int ageTeamTechnical;

        public string? IdTeamTechnical { get => idTeamTechnical; set => idTeamTechnical = value; }
        public string? NameTeamTechnical { get => nameTeamTechnical; set => nameTeamTechnical = value; }
        public int AgeTeamTechnical { get => ageTeamTechnical; set => ageTeamTechnical = value; }
        public string? RolTeamTechnical { get => rolTeamTechnical; set => rolTeamTechnical = value; }
    }
}