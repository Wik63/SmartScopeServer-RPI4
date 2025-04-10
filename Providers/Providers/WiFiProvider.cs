using System;
using LabNation.DeviceInterface.Provider;

namespace LabNation.DeviceInterface.Hardware
{
    public class WiFiProvider : IDeviceInterfaceProvider
    {
        public string Name => "WiFi";

        public void Start()
        {
            Console.WriteLine("[WiFiProvider] Started.");
        }

        public void Stop()
        {
            Console.WriteLine("[WiFiProvider] Stopped.");
        }
    }
}
