﻿using System;
using System.IO;

namespace L2RPacketReader.Parser.Pkt
{
    class PktSimpleEquipment
    {
        public static void Packet(PacketReader packet)
        {
            UInt32 ItemInfoID = packet.ReadUInt32();
            byte EnchantLevel = packet.ReadByte();
        }
    }
}