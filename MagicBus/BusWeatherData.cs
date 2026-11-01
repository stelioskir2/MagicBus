using System;

namespace MagicBus
{
    public static class BusWeatherData
    {
        private static readonly Random random = new Random();

        public static int Temperature { get; set; } =
            random.Next(15, 34);

        public static string Condition { get; set; } =
            new[] { "Ηλιοφάνεια", "Συννεφιά", "Βροχή" }[
                random.Next(3)];

        public static bool RoofOpen { get; set; } =
            Condition == "Ηλιοφάνεια";

        public static bool IsRaining => Condition == "Βροχή";
    }
}