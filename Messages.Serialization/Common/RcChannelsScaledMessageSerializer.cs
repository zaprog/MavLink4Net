//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------


namespace MavLink4Net.Messages.Serialization.Common
{
    
    
    public class RcChannelsScaledMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.IMessage message)
        {
            MavLink4Net.Messages.Common.RcChannelsScaledMessage tMessage = message as MavLink4Net.Messages.Common.RcChannelsScaledMessage;
            writer.Write(tMessage.TimeBootMs);
            writer.Write(tMessage.Chan1Scaled);
            writer.Write(tMessage.Chan2Scaled);
            writer.Write(tMessage.Chan3Scaled);
            writer.Write(tMessage.Chan4Scaled);
            writer.Write(tMessage.Chan5Scaled);
            writer.Write(tMessage.Chan6Scaled);
            writer.Write(tMessage.Chan7Scaled);
            writer.Write(tMessage.Chan8Scaled);
            writer.Write(tMessage.Port);
            writer.Write(tMessage.Rssi);
        }
        
        public MavLink4Net.Messages.IMessage Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.RcChannelsScaledMessage message = new MavLink4Net.Messages.Common.RcChannelsScaledMessage();
            message.TimeBootMs = reader.ReadUInt32();
            message.Chan1Scaled = reader.ReadInt16();
            message.Chan2Scaled = reader.ReadInt16();
            message.Chan3Scaled = reader.ReadInt16();
            message.Chan4Scaled = reader.ReadInt16();
            message.Chan5Scaled = reader.ReadInt16();
            message.Chan6Scaled = reader.ReadInt16();
            message.Chan7Scaled = reader.ReadInt16();
            message.Chan8Scaled = reader.ReadInt16();
            message.Port = reader.ReadByte();
            message.Rssi = reader.ReadByte();
            return message;
        }
    }
}
