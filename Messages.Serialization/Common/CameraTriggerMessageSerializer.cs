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
    
    
    public class CameraTriggerMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.CameraTriggerMessage tMessage = message as MavLink4Net.Messages.Common.CameraTriggerMessage;
            writer.Write(tMessage.TimeUsec);
            writer.Write(tMessage.Seq);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.CameraTriggerMessage message = new MavLink4Net.Messages.Common.CameraTriggerMessage();
            message.TimeUsec = reader.ReadUInt64();
            message.Seq = reader.ReadUInt32();
            return message;
        }
    }
}
