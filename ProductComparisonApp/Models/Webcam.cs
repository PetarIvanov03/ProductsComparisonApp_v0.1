namespace ProductComparisonApp.Models
{
    public class Webcam : BaseProduct
    {
        public string Resolution { get; set; } // 720p, 1080p, 4K и т.н.
        public int FrameRateFps { get; set; } // 30, 60 и т.н.
        public double FieldOfViewDegrees { get; set; } // 60°, 78°, 90°
        public bool HasAutoFocus { get; set; }
        public bool HasMicrophone { get; set; }
        public string MicrophoneType { get; set; } // Mono, Stereo
        public bool HasPrivacyShutter { get; set; }
        public string ConnectionType { get; set; } // USB-A, USB-C, Wireless
        public bool HasLowLightCorrection { get; set; }
        public string MountType { get; set; } // Clip-on, Tripod, Magnetic
        public bool SupportsWindowsHello { get; set; }
        public double WeightGrams { get; set; }
    }
}
