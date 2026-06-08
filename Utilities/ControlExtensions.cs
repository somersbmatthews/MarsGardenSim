using System;
using System.Collections.Generic;
using System.Text;

namespace MarsGardenSim2026.Utilities
{
    public static class ControlExtensions
    {
        // gets all controls of a type in a container
        public static IEnumerable<T> GetAllControlsOfType<T>(this Control container) where T : Control
        {
            foreach (Control control in container.Controls)
            {
                // checks if control is of type T, the requested type, then sets it to a variable, matchedControl
                if (control is T matchedControl)
                {
                    // returns an IEnumerable of all the controls of the requested type T
                    yield return matchedControl;
                }
                // checks for the type in any child container
                foreach (var child in control.GetAllControlsOfType<T>())
                {
                    yield return child;
                }
            }
        }
    }
}
