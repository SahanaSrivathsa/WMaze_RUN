using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMazeLibrary
{
    /// <summary>
    /// Rat Model with details of Rat Name, Age, Weight, %, HealthNotes
    /// </summary>
    public class RatModel
    {
        public string RatName { get; set; }
        public string RatAge { get; set; }
        public string RatWeight { get; set; }
        public int WeightPercent { get; set; }
        public string RatHealthNotes { get; set; }

        
    }
}
