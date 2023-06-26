using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fifaWorldCup_app.Entities
{
    public class Player
    {
        private string ? idPlayer;
        private string ? namePlayer;
        private string ? positionPlayer;
        private int agePlayer;

        public string? IdPlayer { get => idPlayer; set => idPlayer = value; }
        public string? PositionPlayer { get => positionPlayer; set => positionPlayer = value; }
        public string? NamePlayer { get => namePlayer; set => namePlayer = value; }
        public int AgePlayer { get => agePlayer; set => agePlayer = value; }

    }
}