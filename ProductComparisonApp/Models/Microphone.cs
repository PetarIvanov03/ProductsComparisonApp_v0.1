namespace ProductComparisonApp.Models
{
    public class Microphone : BaseProduct
    {
        public string MicrophoneType { get; set; } // Condenser, Dynamic, Ribbon
        public string PolarPattern { get; set; } // Cardioid, Omnidirectional, Bidirectional, etc.
        public string FrequencyResponse { get; set; } // напр. "20Hz – 20kHz"
        public string Sensitivity { get; set; } // напр. "-38 dBV/Pa"
        public string Impedance { get; set; } // напр. "200 ohms"
        public bool HasBuiltInPopFilter { get; set; }
        public bool HasShockMount { get; set; }
        public bool HasMuteButton { get; set; }
        public bool IsWireless { get; set; }
        public string ConnectionType { get; set; } // USB, XLR, 3.5mm
        public bool HasGainControl { get; set; }
        public bool RequiresPhantomPower { get; set; }
        public double WeightGrams { get; set; }
        public bool HasMonitoringJack { get; set; }
    }
}
