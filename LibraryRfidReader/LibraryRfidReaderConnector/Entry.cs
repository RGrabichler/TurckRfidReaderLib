using System;
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace LibraryRfidReader
{
    public class Entry
    {
        public static readonly string AmsId = "5.109.28.160.1.1";

        public static LibraryRfidReaderTwinController Plc { get; } =
            new LibraryRfidReaderTwinController(Tc3ConnectorAdapter.Create(AmsId, 851, true));
    }
}
