using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fifaWorldCup_app.Entities
{
    public class TeamMedical
    {
        private string ? idTeamMedical;
        private string ? nameTeamMedical;
        private string ? rolTeamMedical;
        private int ageTeamMedical;

        public string? IdTeamMedical { get => idTeamMedical; set => idTeamMedical = value; }
        public string? NameTeamMedical { get => nameTeamMedical; set => nameTeamMedical = value; }
        public string? RolTeamMedical { get => rolTeamMedical; set => rolTeamMedical = value; }
        public int AgeTeamMedical { get => ageTeamMedical; set => ageTeamMedical = value; }
    }
}