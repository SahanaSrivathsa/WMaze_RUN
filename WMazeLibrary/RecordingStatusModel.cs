using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMazeLibrary
{
    /// <summary>
    /// Ephys recording status and name of Netcom connection client to Cheetah
    /// </summary>
    public class RecordingStatusModel
    {
        public bool RecordingStatus { get; set; }

        public string NetComClient { get; set; }
    }
}
