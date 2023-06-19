using RentACar.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.Model
{
    public class Automobil
    {
        public int idAutomobil { get; set; }
        public string naziv { get; set; }
        public double kubikaza { get; set; }
        public string potrosnja { get; set; }
        public string gorivo { get; set; }
        public string transmisija { get; set; }
        public string godinaProizvodnje { get; set; }
        public double kapacietetRezervoara { get; set; }
        public double konjskihSnaga { get; set; }
        public int brojSjedista { get; set; }
        public double cijena { get; set; }
        public int zaduzen { get; set; }
        public string Administrator_jmb { get; set; }
        
        public string putanjaDoSlike { get; set; } = new DirectoryInfo(
            Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\" + "car.jpg"))).ToString();
    }
}
