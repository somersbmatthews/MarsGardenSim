using MarsGardenSim2026.Components;

namespace MarsGardenSim2026
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //SimulatorState simulatorState = SimulatorState.Instance;

            //CropsInfoMap cropsInfoMap = new CropsInfoMap();

            //string[] crops = cropsInfoMap.Crops.Keys.ToArray();

            //foreach (string crop in crops)
            //{
            //    SimulatorState.Instance.CropsOutput.Add(crop, 0);
            //}

            Application.Run(new Main());
        }
    }
}