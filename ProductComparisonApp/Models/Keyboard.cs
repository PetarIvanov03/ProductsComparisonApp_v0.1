namespace ProductComparisonApp.Models
{
    public class Keyboard : BaseProduct
    {
        public string SwitchType { get; set; } // Mechanical, Membrane, Optical
        public string SwitchBrand { get; set; } // Cherry MX, Razer, Romer-G, etc.
        public bool IsWireless { get; set; }
        public string ConnectionType { get; set; } // USB, Bluetooth, 2.4GHz
        public string Layout { get; set; } // ISO, ANSI, TKL, 60%, Full Size
        public bool HasRGB { get; set; }
        public bool IsHotSwappable { get; set; }
        public bool HasMediaControls { get; set; }
        public bool HasWristRest { get; set; }
        public string KeycapMaterial { get; set; } // ABS, PBT
        public string BacklightType { get; set; } // RGB, Single-color, None
        public bool IsWaterResistant { get; set; }
        public double WeightGrams { get; set; }
    }
}
