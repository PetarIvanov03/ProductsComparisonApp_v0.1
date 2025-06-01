namespace ProductComparisonApp.Models
{
    public class Headphones : BaseProduct
    {
        public bool IsWireless { get; set; }
        public string ConnectionType { get; set; } // Bluetooth, 3.5mm, USB, etc.
        public int BatteryLifeHours { get; set; }
        public bool HasNoiseCancelling { get; set; }
        public bool HasMicrophone { get; set; }
        public string FrequencyRange { get; set; }
        public string Impedance { get; set; }
        public string Sensitivity { get; set; }
        public string DriverSize { get; set; }
        public double WeightGrams { get; set; }
    }

}
