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
    
    
    public class FollowTargetMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.FollowTargetMessage tMessage = message as MavLink4Net.Messages.Common.FollowTargetMessage;
            writer.Write(tMessage.Timestamp);
            writer.Write(tMessage.CustomState);
            writer.Write(tMessage.Lat);
            writer.Write(tMessage.Lon);
            writer.Write(tMessage.Alt);
            writer.Write(tMessage.Vel[0]);
            writer.Write(tMessage.Vel[1]);
            writer.Write(tMessage.Vel[2]);
            writer.Write(tMessage.Acc[0]);
            writer.Write(tMessage.Acc[1]);
            writer.Write(tMessage.Acc[2]);
            writer.Write(tMessage.AttitudeQ[0]);
            writer.Write(tMessage.AttitudeQ[1]);
            writer.Write(tMessage.AttitudeQ[2]);
            writer.Write(tMessage.AttitudeQ[3]);
            writer.Write(tMessage.Rates[0]);
            writer.Write(tMessage.Rates[1]);
            writer.Write(tMessage.Rates[2]);
            writer.Write(tMessage.PositionCov[0]);
            writer.Write(tMessage.PositionCov[1]);
            writer.Write(tMessage.PositionCov[2]);
            writer.Write(tMessage.EstCapabilities);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.FollowTargetMessage message = new MavLink4Net.Messages.Common.FollowTargetMessage();
            message.Timestamp = reader.ReadUInt64();
            message.CustomState = reader.ReadUInt64();
            message.Lat = reader.ReadInt32();
            message.Lon = reader.ReadInt32();
            message.Alt = reader.ReadSingle();
            message.Vel[0] = reader.ReadSingle();
            message.Vel[1] = reader.ReadSingle();
            message.Vel[2] = reader.ReadSingle();
            message.Acc[0] = reader.ReadSingle();
            message.Acc[1] = reader.ReadSingle();
            message.Acc[2] = reader.ReadSingle();
            message.AttitudeQ[0] = reader.ReadSingle();
            message.AttitudeQ[1] = reader.ReadSingle();
            message.AttitudeQ[2] = reader.ReadSingle();
            message.AttitudeQ[3] = reader.ReadSingle();
            message.Rates[0] = reader.ReadSingle();
            message.Rates[1] = reader.ReadSingle();
            message.Rates[2] = reader.ReadSingle();
            message.PositionCov[0] = reader.ReadSingle();
            message.PositionCov[1] = reader.ReadSingle();
            message.PositionCov[2] = reader.ReadSingle();
            message.EstCapabilities = reader.ReadByte();
            return message;
        }
    }
}
