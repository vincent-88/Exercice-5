﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PoolSaison2019.Models
{
    public class Joueur : Entity
    {
        public string Nom { get; set; }
        public string Equipe { get; set; }
        public string Position { get; set; }
        public int Salaire { get; set; }
    }
}
