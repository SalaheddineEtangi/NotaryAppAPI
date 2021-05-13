using System;
using System.Collections.Generic;

namespace NotaryAppAPI.Models
{
    public partial class Client
    {
        public int Id { get; set; }
        public string NCin { get; set; }
        public string NomComplet { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public string PrenomMere { get; set; }
        public string PrenomPere { get; set; }
        public string SatatMatrimoniale { get; set; }
        public string NomConjoint { get; set; }
        public DateTime? DateMariage { get; set; }
        public string LieuMariage { get; set; }
        public string AdresseHabitat { get; set; }
        public string AdresseCin { get; set; }
        public string NumTel { get; set; }
        public string Email { get; set; }
        public string Profession { get; set; }
    }
}
