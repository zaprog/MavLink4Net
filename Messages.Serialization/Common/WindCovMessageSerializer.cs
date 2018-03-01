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
    
    
    public class WindCovMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.WindCovMessage tMessage = message as MavLink4Net.Messages.Common.WindCovMessage;
            writer.Write(tMessage.TimeUsec);
            writer.Write(tMessage.WindX);
            writer.Write(tMessage.WindY);
            writer.Write(tMessage.WindZ);
            writer.Write(tMessage.VarHoriz);
            writer.Write(tMessage.VarVert);
            writer.Write(tMessage.WindAlt);
            writer.Write(tMessage.HorizAccuracy);
            writer.Write(tMessage.VertAccuracy);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.WindCovMessage message = new MavLink4Net.Messages.Common.WindCovMessage();
            message.TimeUsec = reader.ReadUInt64();
            message.WindX = reader.ReadSingle();
            message.WindY = reader.ReadSingle();
            message.WindZ = reader.ReadSingle();
            message.VarHoriz = reader.ReadSingle();
            message.VarVert = reader.ReadSingle();
            message.WindAlt = reader.ReadSingle();
            message.HorizAccuracy = reader.ReadSingle();
            message.VertAccuracy = reader.ReadSingle();
            return message;
        }
    }
}
