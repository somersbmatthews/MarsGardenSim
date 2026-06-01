using System;
using System.Collections.Generic;
using System.Text;

namespace MarsGardenSim2026.Components
{
    public class CropsInfoMap
    {
        public static readonly Dictionary<String, CropProperties> Crops =
            new()
            {
                {
                    "Potato",
                    new CropProperties()
                }
            };
    }
}
