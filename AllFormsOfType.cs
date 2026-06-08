using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;

namespace MarsGardenSim2026
{
    public static class AllFormsOfType
    {
        public static IEnumerable<T> GetAllControlsOfType<T>(Control container) where T : Control
        {
            foreach (Control control in container.Controls)
            {
                if (control is T matchedControl)
                {
                    yield return matchedControl;
                }

                foreach (var child in GetAllControlsOfType<T>(control))
                {
                    yield return child;
                }
            }
        }


    }
}
