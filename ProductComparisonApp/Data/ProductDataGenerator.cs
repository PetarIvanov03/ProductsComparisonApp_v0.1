using System;
using System.Collections.Generic;
using System.Linq;
using ProductComparisonApp.Models;

namespace ProductComparisonApp.Data
{
    public static class ProductDataGenerator
    {
        private static readonly Random rnd = new();

        private static List<Headphones> _cachedHeadphones;
        private static List<Mouse> _cachedMice;
        private static List<Keyboard> _cachedKeyboards;
        private static List<Models.Monitor> _cachedMonitors;
        private static List<Microphone> _cachedMicrophones;
        private static List<Webcam> _cachedWebcams;

        public static List<Headphones> GetHeadphones()
        {
            return _cachedHeadphones ??= GenerateHeadphones();
        }

        public static List<Mouse> GetMice()
        {
            return _cachedMice ??= GenerateMice();
        }

        public static List<Keyboard> GetKeyboards()
        {
            return _cachedKeyboards ??= GenerateKeyboards();
        }

        public static List<Models.Monitor> GetMonitors()
        {
            return _cachedMonitors ??= GenerateMonitors();
        }

        public static List<Microphone> GetMicrophones()
        {
            return _cachedMicrophones ??= GenerateMicrophones();
        }

        public static List<Webcam> GetWebcams()
        {
            return _cachedWebcams ??= GenerateWebcams();
        }

        private static List<Headphones> GenerateHeadphones()
        {
            var list = new List<Headphones>();
            for (int i = 1; i <= 20; i++)
            {
                list.Add(new Headphones
                {
                    Id = i,
                    Name = $"Headphones {i}",
                    Brand = $"Brand {i % 5}",
                    Price = 50 + rnd.Next(200),
                    Colour = "Black",
                    ImageUrl = "/Images/ChatGPT_Headphones.png",
                    IsWireless = i % 2 == 0,
                    ConnectionType = i % 3 == 0 ? "Bluetooth" : "3.5mm",
                    BatteryLifeHours = 10 + rnd.Next(20),
                    HasNoiseCancelling = i % 4 == 0,
                    HasMicrophone = i % 3 != 0,
                    FrequencyRange = "20Hz–20kHz",
                    Impedance = "32 Ohm",
                    Sensitivity = "98 dB",
                    DriverSize = "40 mm",
                    WeightGrams = 250 + rnd.Next(100)
                });
            }
            return list;
        }

        private static List<Mouse> GenerateMice()
        {
            var list = new List<Mouse>();
            for (int i = 1; i <= 20; i++)
            {
                list.Add(new Mouse
                {
                    Id = i,
                    Name = $"Mouse {i}",
                    Brand = $"Brand {i % 4}",
                    Price = 20 + rnd.Next(80),
                    Colour = "Gray",
                    ImageUrl = "/Images/ChatGPT_Mouse.png",
                    SensorType = i % 2 == 0 ? "Optical" : "Laser",
                    DPI = 800 + rnd.Next(9200),
                    IsWireless = i % 2 == 1,
                    ConnectionType = "USB",
                    ButtonCount = 3 + rnd.Next(4),
                    HasRGB = i % 5 == 0,
                    Shape = "Ergonomic",
                    Size = "Medium",
                    PollingRateHz = 1000,
                    WeightGrams = 90 + rnd.Next(30),
                    AdjustableWeight = i % 6 == 0,
                    IsRechargeable = i % 2 == 0,
                    BatteryLifeHours = 40 + rnd.Next(30)
                });
            }
            return list;
        }

        private static List<Keyboard> GenerateKeyboards()
        {
            var list = new List<Keyboard>();
            for (int i = 1; i <= 20; i++)
            {
                list.Add(new Keyboard
                {
                    Id = i,
                    Name = $"Keyboard {i}",
                    Brand = $"Brand {i % 3}",
                    Price = 60 + rnd.Next(140),
                    Colour = "White",
                    ImageUrl = "/Images/ChatGPT_Keyboard.png",
                    SwitchType = "Mechanical",
                    SwitchBrand = "Cherry MX",
                    IsWireless = i % 3 == 0,
                    ConnectionType = "USB",
                    Layout = i % 2 == 0 ? "ANSI" : "TKL",
                    HasRGB = i % 2 == 0,
                    IsHotSwappable = i % 4 == 0,
                    HasMediaControls = true,
                    HasWristRest = i % 5 == 0,
                    KeycapMaterial = "PBT",
                    BacklightType = "RGB",
                    IsWaterResistant = i % 6 == 0,
                    WeightGrams = 800 + rnd.Next(300)
                });
            }
            return list;
        }

        private static List<Models.Monitor> GenerateMonitors()
        {
            var list = new List<Models.Monitor>();
            for (int i = 1; i <= 20; i++)
            {
                list.Add(new Models.Monitor
                {
                    Id = i,
                    Name = $"Monitor {i}",
                    Brand = $"Brand {i % 5}",
                    Price = 150 + rnd.Next(500),
                    Colour = "Black",
                    ImageUrl = "/Images/ChatGPT_Monitor.png",
                    ScreenSizeInches = 24 + rnd.Next(10),
                    Resolution = i % 3 == 0 ? "2560x1440" : "1920x1080",
                    RefreshRateHz = i % 2 == 0 ? 144 : 60,
                    ResponseTimeMs = 1 + rnd.Next(5),
                    PanelType = "IPS",
                    HasHDR = i % 4 == 0,
                    AspectRatio = "16:9",
                    SyncTechnology = i % 2 == 0 ? "FreeSync" : "G-Sync",
                    HasSpeakers = i % 3 == 0,
                    IsCurved = i % 5 == 0,
                    MountType = "VESA",
                    InputPorts = "HDMI, DisplayPort",
                    BrightnessNits = 250 + rnd.Next(100),
                    ContrastRatio = 1000,
                    WeightKg = Math.Round(3.5 + rnd.NextDouble(), 2)
                });
            }
            return list;
        }

        private static List<Microphone> GenerateMicrophones()
        {
            var list = new List<Microphone>();
            for (int i = 1; i <= 20; i++)
            {
                list.Add(new Microphone
                {
                    Id = i,
                    Name = $"Mic {i}",
                    Brand = $"Brand {i % 4}",
                    Price = 70 + rnd.Next(150),
                    Colour = "Black",
                    ImageUrl = "/Images/ChatGPT_Microphone.png",
                    MicrophoneType = "Condenser",
                    PolarPattern = "Cardioid",
                    FrequencyResponse = "20Hz–20kHz",
                    Sensitivity = "-38 dBV/Pa",
                    Impedance = "200 Ohms",
                    HasBuiltInPopFilter = i % 2 == 0,
                    HasShockMount = i % 3 == 0,
                    HasMuteButton = i % 2 == 1,
                    IsWireless = false,
                    ConnectionType = "USB",
                    HasGainControl = true,
                    RequiresPhantomPower = false,
                    WeightGrams = 300 + rnd.Next(150),
                    HasMonitoringJack = i % 4 == 0
                });
            }
            return list;
        }

        private static List<Webcam> GenerateWebcams()
        {
            var list = new List<Webcam>();
            for (int i = 1; i <= 20; i++)
            {
                list.Add(new Webcam
                {
                    Id = i,
                    Name = $"Webcam {i}",
                    Brand = $"Brand {i % 3}",
                    Price = 40 + rnd.Next(100),
                    Colour = "Black",
                    ImageUrl = "/Images/ChatGPT_Webcam.png",
                    Resolution = i % 3 == 0 ? "4K" : "1080p",
                    FrameRateFps = i % 2 == 0 ? 60 : 30,
                    FieldOfViewDegrees = i % 2 == 0 ? 78 : 90,
                    HasAutoFocus = true,
                    HasMicrophone = true,
                    MicrophoneType = i % 2 == 0 ? "Stereo" : "Mono",
                    HasPrivacyShutter = i % 3 == 0,
                    ConnectionType = "USB",
                    HasLowLightCorrection = true,
                    MountType = "Clip-on",
                    SupportsWindowsHello = i % 4 == 0,
                    WeightGrams = 150 + rnd.Next(50)
                });
            }
            return list;
        }
    }
}
