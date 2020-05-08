using ENet;

namespace Valk.Networking
{
    class Network
    {
        public static void Send(ref Event netEvent, ENet.Packet packet)
        {
            netEvent.Peer.Send(Program.CHANNEL_ID, ref packet);
        }

        public static void Broadcast(ref Event netEvent, ENet.Packet packet, params Peer[] excludedPeers)
        {

        }
    }
}