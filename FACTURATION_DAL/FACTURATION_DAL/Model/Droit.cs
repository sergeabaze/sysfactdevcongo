using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FACTURATION_DAL.Model
{
   public  class Droit
    {
       public int ID { get; set; }
       public int IProfile { get; set; }
       public int IDutilisateur { get; set; }
       public int IdVues { get; set; }
       public string LibelleVue { get; set; }
       public string LibelleSouVue { get; set; }
       public int IDSousVue { get; set; }
       public bool Lecture { get; set; }
       public bool Ecriture { get; set; }
       public bool Suppression { get; set; }
       public bool Edition { get; set; }
       public bool Validation { get; set; }
       public bool Impression { get; set; }
       public bool Super { get; set; }
       public bool Testeur { get; set; }
       public bool proprietaire { get; set; }
       public bool execution { get; set; }
       public bool developpeur { get; set; }

       List<Droit> sousDroits = new List<Droit>();

       public List<Droit> SousDroits
       {
           get { return sousDroits; }
           set { sousDroits = value; }
       }
    }
}
