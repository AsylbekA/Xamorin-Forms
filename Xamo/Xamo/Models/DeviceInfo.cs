using Android.OS;
using Xamarin.Forms;
using Xamo.Interface;

[assembly: Dependency(typeof(Xamo.Models.DeviceInfo))]
namespace Xamo.Models
{
    class DeviceInfo:IDeviceInfo
    {
        public string GetInfo()
        {
            return $"Android {Build.VERSION.Release}";
        }
    }
}
