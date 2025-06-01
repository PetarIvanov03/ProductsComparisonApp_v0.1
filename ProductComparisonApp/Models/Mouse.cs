using System;

namespace ProductComparisonApp.Models
{
    public class Mouse : BaseProduct
    {
        public string SensorType { get; set; } // Optical, Laser
        public int DPI { get; set; }
        public bool IsWireless { get; set; }
        public string ConnectionType { get; set; } // USB, Bluetooth, etc.
        public int ButtonCount { get; set; }
        public bool HasRGB { get; set; }
        public string Shape { get; set; } // Ergonomic, Ambidextrous, etc.
        public string Size { get; set; } // Small, Medium, Large
        public double PollingRateHz { get; set; }
        public double WeightGrams { get; set; }
        public bool AdjustableWeight { get; set; }
        public bool IsRechargeable { get; set; }
        public int BatteryLifeHours { get; set; }
    }
}

