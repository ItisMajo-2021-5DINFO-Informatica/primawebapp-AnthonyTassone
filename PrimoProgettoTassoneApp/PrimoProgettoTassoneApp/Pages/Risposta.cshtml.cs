using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PrimoProgettoTassoneApp.Pages
{
    public class RispostaModel : PageModel
    {
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Testo { get; set; }
        public void OnGet(string cognome, string nome, string testo)
        {
            Cognome = cognome;
            Nome = nome;
            Testo = testo;
        }

      
        
    }
}
