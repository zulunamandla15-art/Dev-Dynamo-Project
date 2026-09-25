using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Dynamo_Project
{
    internal class WasteCollection
    {
        public string BusinessName { get; set; }
        public string WasteType { get; set; } // Plastic, Paper, Glass, Cans
        public double WeightKG { get; set; }
        public string CollectionDate { get; set; }
        public string ProofImagePath { get; set; } // where the proof photo is saved
    }
}
