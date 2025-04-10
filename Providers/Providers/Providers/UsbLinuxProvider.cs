using System;
using LabNation.DeviceInterface.Provider;

namespace LabNation.DeviceInterface.Hardware
{
    public class UsbLinuxProvider : IDeviceInterfaceProvider
    {
        public string Name => "UsbLinux";

        public void Start() 
        {
            Console.WriteLine("[UsbLinuxProvider] Started.");
        }

        public void Stop() 
        {
            Console.WriteLine("[UsbLinuxProvider] Stopped.");
        }
    }
}
