using System;
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace LibraryRfidReaderExample
{
    public class Entry
    {
        public static readonly string AmsId = "5.109.28.160.1.1";

        public static LibraryRfidReaderExampleTwinController Plc { get; } =
            new LibraryRfidReaderExampleTwinController(Tc3ConnectorAdapter.Create(AmsId, 852, true));
    }
}
