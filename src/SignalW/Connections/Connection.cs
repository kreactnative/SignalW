﻿using System.Security.Claims;
using Spreads.SignalW.Client;

namespace Spreads.SignalW.Connections
{

    public class Connection {
        public string ConnectionId { get; set; }
        public ClaimsPrincipal User { get; set; }
        public Channel Channel { get; set; }
        public ConnectionMetadata Metadata { get; } = new ConnectionMetadata();
    }
}
