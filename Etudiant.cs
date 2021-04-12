﻿using System;
namespace Partie_11_Serialization_Json
{
    [Serializable]
    internal class Etudiant
    {
        public int numins { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public override string ToString()
        {
            return $"numero d'inscription : {numins} - nom : {nom} - prenom : {prenom}";
        }
    }
}