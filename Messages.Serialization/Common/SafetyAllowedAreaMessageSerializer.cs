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
    
    
    public class SafetyAllowedAreaMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.SafetyAllowedAreaMessage tMessage = message as MavLink4Net.Messages.Common.SafetyAllowedAreaMessage;
            writer.Write(tMessage.P1x);
            writer.Write(tMessage.P1y);
            writer.Write(tMessage.P1z);
            writer.Write(tMessage.P2x);
            writer.Write(tMessage.P2y);
            writer.Write(tMessage.P2z);
            writer.Write(((byte)(tMessage.Frame)));
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.SafetyAllowedAreaMessage message = new MavLink4Net.Messages.Common.SafetyAllowedAreaMessage();
            message.P1x = reader.ReadSingle();
            message.P1y = reader.ReadSingle();
            message.P1z = reader.ReadSingle();
            message.P2x = reader.ReadSingle();
            message.P2y = reader.ReadSingle();
            message.P2z = reader.ReadSingle();
            message.Frame = ((MavLink4Net.Messages.Common.Frame)(reader.ReadByte()));
            return message;
        }
    }
}
