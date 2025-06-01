namespace ProductComparisonApp.Models
{
    public class Monitor : BaseProduct
    {
        public double ScreenSizeInches { get; set; }
        public string Resolution { get; set; } // 1920x1080, 2560x1440, 3840x2160 и т.н.
        public int RefreshRateHz { get; set; }
        public int ResponseTimeMs { get; set; }
        public string PanelType { get; set; } // IPS, TN, VA, OLED
        public bool HasHDR { get; set; }
        public string AspectRatio { get; set; } // 16:9, 21:9, 4:3 и т.н.
        public string SyncTechnology { get; set; } // G-Sync, FreeSync, Adaptive-Sync
        public bool HasSpeakers { get; set; }
        public bool IsCurved { get; set; }
        public string MountType { get; set; } // VESA, Fixed, Tilt, Swivel
        public string InputPorts { get; set; } // HDMI, DisplayPort, USB-C и др.
        public double BrightnessNits { get; set; }
        public double ContrastRatio { get; set; }
        public double WeightKg { get; set; }
    }
}
