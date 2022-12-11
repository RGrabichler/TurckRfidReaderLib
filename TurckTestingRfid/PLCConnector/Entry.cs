using PLC;
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace PLCConnector
{
    public class Entry
    {
        public static readonly string AmsId = "192.168.1.8.1.1";
        private const int Port = 851;

        public static PLCTwinController Plc { get; } =
            new PLCTwinController(Tc3ConnectorAdapter.Create(AmsId, Port, true));
    }
}
