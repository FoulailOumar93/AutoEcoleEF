//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoEcoleEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class lecon
    {
        public int id { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<int> idEleve { get; set; }
        public Nullable<int> heure { get; set; }
        public Nullable<int> duree { get; set; }
        public short effectueeOui_Non { get; set; }
        public string numImmaVehicule { get; set; }
    
        public virtual eleve eleve { get; set; }
        public virtual vehicule vehicule { get; set; }
    }
}
