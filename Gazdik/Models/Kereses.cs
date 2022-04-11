using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Gazdik.Models
{
    public class Kereses
    {
        public int IdKeres { get; set; }
        public string NevKeres { get; set; }

        public SelectList NevLista { get; set; }
        public List<GazdiAdatok> GazdiLista { get; set; }
    }
}
