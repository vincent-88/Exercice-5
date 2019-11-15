using System;
using System.ComponentModel.DataAnnotations;

namespace PoolSaison2019.Models
{
    public class Participant : Entity
    {
        public string Nom { get; set; }
        public string Rang { get; set; }
        public string LastWeekRank { get; set; }
        public int Gains { get; set; }
    }
}
