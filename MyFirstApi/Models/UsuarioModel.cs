using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApi.Models
{
    public class UsuarioModel
    {
        public int co_usr { get; set; }

        public string tx_nom { get; set; }

        public string tx_ape { get; set; }

        public string tx_corr { get; set; }
    }
}