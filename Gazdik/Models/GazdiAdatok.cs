using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gazdik.Models
{
    public class GazdiAdatok
    {
        public int Id { get; set; }
        public int GazdiId { get; set; }
        public string Nev { get; set; }
        public string Cim { get; set; }

        public int Telefonszam { get; set; }
        public string Email { get; set; }

        /*public GazdiAdatok()
        {

        }

        public GazdiAdatok(string sor)
        {
            string[] adat = sor.Split(";");

            GazdiId = Convert.ToInt32(adat[0]);
            Nev = adat[1];
            Cim = adat[2];
            Telefonszam = Convert.ToInt32(adat[3]);
            Email = adat[0];
           }*/
    }
}
