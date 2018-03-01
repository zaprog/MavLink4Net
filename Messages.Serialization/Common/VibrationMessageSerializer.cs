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
    
    
    public class VibrationMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.VibrationMessage tMessage = message as MavLink4Net.Messages.Common.VibrationMessage;
            writer.Write(tMessage.TimeUsec);
            writer.Write(tMessage.VibrationX);
            writer.Write(tMessage.VibrationY);
            writer.Write(tMessage.VibrationZ);
            writer.Write(tMessage.Clipping0);
            writer.Write(tMessage.Clipping1);
            writer.Write(tMessage.Clipping2);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.VibrationMessage message = new MavLink4Net.Messages.Common.VibrationMessage();
            message.TimeUsec = reader.ReadUInt64();
            message.VibrationX = reader.ReadSingle();
            message.VibrationY = reader.ReadSingle();
            message.VibrationZ = reader.ReadSingle();
            message.Clipping0 = reader.ReadUInt32();
            message.Clipping1 = reader.ReadUInt32();
            message.Clipping2 = reader.ReadUInt32();
            return message;
        }
    }
}
