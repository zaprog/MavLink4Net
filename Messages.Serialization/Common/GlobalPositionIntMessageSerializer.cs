//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;


namespace MavLink4Net.Messages.Serialization.Common
{
    
    
    public class GlobalPositionIntMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.GlobalPositionIntMessage tMessage = message as MavLink4Net.Messages.Common.GlobalPositionIntMessage;
            writer.Write(tMessage.TimeBootMs);
            writer.Write(tMessage.Lat);
            writer.Write(tMessage.Lon);
            writer.Write(tMessage.Alt);
            writer.Write(tMessage.RelativeAlt);
            writer.Write(tMessage.Vx);
            writer.Write(tMessage.Vy);
            writer.Write(tMessage.Vz);
            writer.Write(tMessage.Hdg);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.GlobalPositionIntMessage message = new MavLink4Net.Messages.Common.GlobalPositionIntMessage();
            message.TimeBootMs = reader.ReadUInt32();
            message.Lat = reader.ReadInt32();
            message.Lon = reader.ReadInt32();
            message.Alt = reader.ReadInt32();
            message.RelativeAlt = reader.ReadInt32();
            message.Vx = reader.ReadInt16();
            message.Vy = reader.ReadInt16();
            message.Vz = reader.ReadInt16();
            message.Hdg = reader.ReadUInt16();
            return message;
        }
    }
}
