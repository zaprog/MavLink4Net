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
    
    
    public class ParamRequestReadMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.ParamRequestReadMessage tMessage = message as MavLink4Net.Messages.Common.ParamRequestReadMessage;
            writer.Write(tMessage.ParamIndex);
            writer.Write(tMessage.TargetSystem);
            writer.Write(tMessage.TargetComponent);
            writer.Write(tMessage.ParamId[0]);
            writer.Write(tMessage.ParamId[1]);
            writer.Write(tMessage.ParamId[2]);
            writer.Write(tMessage.ParamId[3]);
            writer.Write(tMessage.ParamId[4]);
            writer.Write(tMessage.ParamId[5]);
            writer.Write(tMessage.ParamId[6]);
            writer.Write(tMessage.ParamId[7]);
            writer.Write(tMessage.ParamId[8]);
            writer.Write(tMessage.ParamId[9]);
            writer.Write(tMessage.ParamId[10]);
            writer.Write(tMessage.ParamId[11]);
            writer.Write(tMessage.ParamId[12]);
            writer.Write(tMessage.ParamId[13]);
            writer.Write(tMessage.ParamId[14]);
            writer.Write(tMessage.ParamId[15]);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.ParamRequestReadMessage message = new MavLink4Net.Messages.Common.ParamRequestReadMessage();
            message.ParamIndex = reader.ReadInt16();
            message.TargetSystem = reader.ReadByte();
            message.TargetComponent = reader.ReadByte();
            message.ParamId[0] = reader.ReadChar();
            message.ParamId[1] = reader.ReadChar();
            message.ParamId[2] = reader.ReadChar();
            message.ParamId[3] = reader.ReadChar();
            message.ParamId[4] = reader.ReadChar();
            message.ParamId[5] = reader.ReadChar();
            message.ParamId[6] = reader.ReadChar();
            message.ParamId[7] = reader.ReadChar();
            message.ParamId[8] = reader.ReadChar();
            message.ParamId[9] = reader.ReadChar();
            message.ParamId[10] = reader.ReadChar();
            message.ParamId[11] = reader.ReadChar();
            message.ParamId[12] = reader.ReadChar();
            message.ParamId[13] = reader.ReadChar();
            message.ParamId[14] = reader.ReadChar();
            message.ParamId[15] = reader.ReadChar();
            return message;
        }
    }
}
