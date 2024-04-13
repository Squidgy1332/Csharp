using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Auther: Liam Morton
 * Date: 2024-04-13
 * File: Class1.cs
 * Purpose: to store pokemon data to display in a data grid
 */
namespace Intorface
{
    //object to hold pokemon data in a data grid
    public class PokemonTableRow
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string T1 { get; set; }
        public string T2 { get; set; }
        public string A1 { get; set; }
        public string A2 { get; set; }
        public string HA { get; set; }
    }
}
