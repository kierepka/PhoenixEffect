using Tizen.Applications;

using Uno.UI.Runtime.Skia;

namespace PhoenixEffect.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new PhoenixEffect.App(), args);
            host.Run();
        }
    }
}
