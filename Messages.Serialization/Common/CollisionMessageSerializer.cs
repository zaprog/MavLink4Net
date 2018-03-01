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
    
    
    public class CollisionMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.CollisionMessage tMessage = message as MavLink4Net.Messages.Common.CollisionMessage;
            writer.Write(tMessage.Id);
            writer.Write(tMessage.TimeToMinimumDelta);
            writer.Write(tMessage.AltitudeMinimumDelta);
            writer.Write(tMessage.HorizontalMinimumDelta);
            writer.Write(((byte)(tMessage.Src)));
            writer.Write(((byte)(tMessage.Action)));
            writer.Write(((byte)(tMessage.ThreatLevel)));
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.CollisionMessage message = new MavLink4Net.Messages.Common.CollisionMessage();
            message.Id = reader.ReadUInt32();
            message.TimeToMinimumDelta = reader.ReadSingle();
            message.AltitudeMinimumDelta = reader.ReadSingle();
            message.HorizontalMinimumDelta = reader.ReadSingle();
            message.Src = ((MavLink4Net.Messages.Common.CollisionSrc)(reader.ReadByte()));
            message.Action = ((MavLink4Net.Messages.Common.CollisionAction)(reader.ReadByte()));
            message.ThreatLevel = ((MavLink4Net.Messages.Common.CollisionThreatLevel)(reader.ReadByte()));
            return message;
        }
    }
}
