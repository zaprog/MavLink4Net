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
    
    
    public class VisionPositionEstimateMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.VisionPositionEstimateMessage tMessage = message as MavLink4Net.Messages.Common.VisionPositionEstimateMessage;
            writer.Write(tMessage.Usec);
            writer.Write(tMessage.X);
            writer.Write(tMessage.Y);
            writer.Write(tMessage.Z);
            writer.Write(tMessage.Roll);
            writer.Write(tMessage.Pitch);
            writer.Write(tMessage.Yaw);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.VisionPositionEstimateMessage message = new MavLink4Net.Messages.Common.VisionPositionEstimateMessage();
            message.Usec = reader.ReadUInt64();
            message.X = reader.ReadSingle();
            message.Y = reader.ReadSingle();
            message.Z = reader.ReadSingle();
            message.Roll = reader.ReadSingle();
            message.Pitch = reader.ReadSingle();
            message.Yaw = reader.ReadSingle();
            return message;
        }
    }
}
