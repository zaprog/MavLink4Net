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
    
    
    public class ScaledImu3MessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.ScaledImu3Message tMessage = message as MavLink4Net.Messages.Common.ScaledImu3Message;
            writer.Write(tMessage.TimeBootMs);
            writer.Write(tMessage.Xacc);
            writer.Write(tMessage.Yacc);
            writer.Write(tMessage.Zacc);
            writer.Write(tMessage.Xgyro);
            writer.Write(tMessage.Ygyro);
            writer.Write(tMessage.Zgyro);
            writer.Write(tMessage.Xmag);
            writer.Write(tMessage.Ymag);
            writer.Write(tMessage.Zmag);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.ScaledImu3Message message = new MavLink4Net.Messages.Common.ScaledImu3Message();
            message.TimeBootMs = reader.ReadUInt32();
            message.Xacc = reader.ReadInt16();
            message.Yacc = reader.ReadInt16();
            message.Zacc = reader.ReadInt16();
            message.Xgyro = reader.ReadInt16();
            message.Ygyro = reader.ReadInt16();
            message.Zgyro = reader.ReadInt16();
            message.Xmag = reader.ReadInt16();
            message.Ymag = reader.ReadInt16();
            message.Zmag = reader.ReadInt16();
            return message;
        }
    }
}
