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
    
    
    public class AuthKeyMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.IMessage message)
        {
            MavLink4Net.Messages.Common.AuthKeyMessage tMessage = message as MavLink4Net.Messages.Common.AuthKeyMessage;
            writer.Write(tMessage.Key[0]);
            writer.Write(tMessage.Key[1]);
            writer.Write(tMessage.Key[2]);
            writer.Write(tMessage.Key[3]);
            writer.Write(tMessage.Key[4]);
            writer.Write(tMessage.Key[5]);
            writer.Write(tMessage.Key[6]);
            writer.Write(tMessage.Key[7]);
            writer.Write(tMessage.Key[8]);
            writer.Write(tMessage.Key[9]);
            writer.Write(tMessage.Key[10]);
            writer.Write(tMessage.Key[11]);
            writer.Write(tMessage.Key[12]);
            writer.Write(tMessage.Key[13]);
            writer.Write(tMessage.Key[14]);
            writer.Write(tMessage.Key[15]);
            writer.Write(tMessage.Key[16]);
            writer.Write(tMessage.Key[17]);
            writer.Write(tMessage.Key[18]);
            writer.Write(tMessage.Key[19]);
            writer.Write(tMessage.Key[20]);
            writer.Write(tMessage.Key[21]);
            writer.Write(tMessage.Key[22]);
            writer.Write(tMessage.Key[23]);
            writer.Write(tMessage.Key[24]);
            writer.Write(tMessage.Key[25]);
            writer.Write(tMessage.Key[26]);
            writer.Write(tMessage.Key[27]);
            writer.Write(tMessage.Key[28]);
            writer.Write(tMessage.Key[29]);
            writer.Write(tMessage.Key[30]);
            writer.Write(tMessage.Key[31]);
        }
        
        public MavLink4Net.Messages.IMessage Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.AuthKeyMessage message = new MavLink4Net.Messages.Common.AuthKeyMessage();
            message.Key[0] = reader.ReadChar();
            message.Key[1] = reader.ReadChar();
            message.Key[2] = reader.ReadChar();
            message.Key[3] = reader.ReadChar();
            message.Key[4] = reader.ReadChar();
            message.Key[5] = reader.ReadChar();
            message.Key[6] = reader.ReadChar();
            message.Key[7] = reader.ReadChar();
            message.Key[8] = reader.ReadChar();
            message.Key[9] = reader.ReadChar();
            message.Key[10] = reader.ReadChar();
            message.Key[11] = reader.ReadChar();
            message.Key[12] = reader.ReadChar();
            message.Key[13] = reader.ReadChar();
            message.Key[14] = reader.ReadChar();
            message.Key[15] = reader.ReadChar();
            message.Key[16] = reader.ReadChar();
            message.Key[17] = reader.ReadChar();
            message.Key[18] = reader.ReadChar();
            message.Key[19] = reader.ReadChar();
            message.Key[20] = reader.ReadChar();
            message.Key[21] = reader.ReadChar();
            message.Key[22] = reader.ReadChar();
            message.Key[23] = reader.ReadChar();
            message.Key[24] = reader.ReadChar();
            message.Key[25] = reader.ReadChar();
            message.Key[26] = reader.ReadChar();
            message.Key[27] = reader.ReadChar();
            message.Key[28] = reader.ReadChar();
            message.Key[29] = reader.ReadChar();
            message.Key[30] = reader.ReadChar();
            message.Key[31] = reader.ReadChar();
            return message;
        }
    }
}
