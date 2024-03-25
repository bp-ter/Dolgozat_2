using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Ember
    {
        public int id {  get; set; }
        public string nev {  get; set; }
        public string? epulet { get; set; }
        public string? iranyitoszam { get; set; }
        public string? pozicio { get; set; }
        public string? szallitas { get; set; }

        public Ember()
        {
        }

        public Ember(string sor)
        {
            var s = sor.Split(';');
            nev = s[0];
            epulet = s[1];
            iranyitoszam = s[2];    
            pozicio = s[3];
            szallitas = s[4];
        }


    public override string? ToString()
        {
            return $"Személy neve: {this.nev}; Poziciója: {pozicio}; Épület ahol tartózkodik: {epulet}; Épület irányítószáma: {iranyitoszam}; Szállítás módja: {szallitas}";
        }
    }
}
