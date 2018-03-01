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
    
    
    public class MissionRequestMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.MissionRequestMessage tMessage = message as MavLink4Net.Messages.Common.MissionRequestMessage;
            writer.Write(tMessage.Seq);
            writer.Write(tMessage.TargetSystem);
            writer.Write(tMessage.TargetComponent);
            writer.Write(((byte)(tMessage.MissionType)));
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.MissionRequestMessage message = new MavLink4Net.Messages.Common.MissionRequestMessage();
            message.Seq = reader.ReadUInt16();
            message.TargetSystem = reader.ReadByte();
            message.TargetComponent = reader.ReadByte();
            message.MissionType = ((MavLink4Net.Messages.Common.MissionType)(reader.ReadByte()));
            return message;
        }
    }
}
