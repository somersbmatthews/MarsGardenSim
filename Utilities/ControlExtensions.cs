using System;
using System.Collections.Generic;
using System.Text;

namespace MarsGardenSim2026.Utilities
{
    public static class ControlExtensions
    {
        public static IEnumerable<T> GetAllControlsOfType<T>(this Control container) where T : Control
        {
            foreach (Control control in container.Controls)
            {
                if (control is T matchedControl)
                {
                    yield return matchedControl;
                }

                foreach (var child in control.GetAllControlsOfType<T>())
                {
                    yield return child;
                }
            }
        }
    }
}
