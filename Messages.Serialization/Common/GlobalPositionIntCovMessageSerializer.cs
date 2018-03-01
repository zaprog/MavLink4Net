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
    
    
    public class GlobalPositionIntCovMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.GlobalPositionIntCovMessage tMessage = message as MavLink4Net.Messages.Common.GlobalPositionIntCovMessage;
            writer.Write(tMessage.TimeUsec);
            writer.Write(tMessage.Lat);
            writer.Write(tMessage.Lon);
            writer.Write(tMessage.Alt);
            writer.Write(tMessage.RelativeAlt);
            writer.Write(tMessage.Vx);
            writer.Write(tMessage.Vy);
            writer.Write(tMessage.Vz);
            writer.Write(tMessage.Covariance[0]);
            writer.Write(tMessage.Covariance[1]);
            writer.Write(tMessage.Covariance[2]);
            writer.Write(tMessage.Covariance[3]);
            writer.Write(tMessage.Covariance[4]);
            writer.Write(tMessage.Covariance[5]);
            writer.Write(tMessage.Covariance[6]);
            writer.Write(tMessage.Covariance[7]);
            writer.Write(tMessage.Covariance[8]);
            writer.Write(tMessage.Covariance[9]);
            writer.Write(tMessage.Covariance[10]);
            writer.Write(tMessage.Covariance[11]);
            writer.Write(tMessage.Covariance[12]);
            writer.Write(tMessage.Covariance[13]);
            writer.Write(tMessage.Covariance[14]);
            writer.Write(tMessage.Covariance[15]);
            writer.Write(tMessage.Covariance[16]);
            writer.Write(tMessage.Covariance[17]);
            writer.Write(tMessage.Covariance[18]);
            writer.Write(tMessage.Covariance[19]);
            writer.Write(tMessage.Covariance[20]);
            writer.Write(tMessage.Covariance[21]);
            writer.Write(tMessage.Covariance[22]);
            writer.Write(tMessage.Covariance[23]);
            writer.Write(tMessage.Covariance[24]);
            writer.Write(tMessage.Covariance[25]);
            writer.Write(tMessage.Covariance[26]);
            writer.Write(tMessage.Covariance[27]);
            writer.Write(tMessage.Covariance[28]);
            writer.Write(tMessage.Covariance[29]);
            writer.Write(tMessage.Covariance[30]);
            writer.Write(tMessage.Covariance[31]);
            writer.Write(tMessage.Covariance[32]);
            writer.Write(tMessage.Covariance[33]);
            writer.Write(tMessage.Covariance[34]);
            writer.Write(tMessage.Covariance[35]);
            writer.Write(((byte)(tMessage.EstimatorType)));
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.GlobalPositionIntCovMessage message = new MavLink4Net.Messages.Common.GlobalPositionIntCovMessage();
            message.TimeUsec = reader.ReadUInt64();
            message.Lat = reader.ReadInt32();
            message.Lon = reader.ReadInt32();
            message.Alt = reader.ReadInt32();
            message.RelativeAlt = reader.ReadInt32();
            message.Vx = reader.ReadSingle();
            message.Vy = reader.ReadSingle();
            message.Vz = reader.ReadSingle();
            message.Covariance[0] = reader.ReadSingle();
            message.Covariance[1] = reader.ReadSingle();
            message.Covariance[2] = reader.ReadSingle();
            message.Covariance[3] = reader.ReadSingle();
            message.Covariance[4] = reader.ReadSingle();
            message.Covariance[5] = reader.ReadSingle();
            message.Covariance[6] = reader.ReadSingle();
            message.Covariance[7] = reader.ReadSingle();
            message.Covariance[8] = reader.ReadSingle();
            message.Covariance[9] = reader.ReadSingle();
            message.Covariance[10] = reader.ReadSingle();
            message.Covariance[11] = reader.ReadSingle();
            message.Covariance[12] = reader.ReadSingle();
            message.Covariance[13] = reader.ReadSingle();
            message.Covariance[14] = reader.ReadSingle();
            message.Covariance[15] = reader.ReadSingle();
            message.Covariance[16] = reader.ReadSingle();
            message.Covariance[17] = reader.ReadSingle();
            message.Covariance[18] = reader.ReadSingle();
            message.Covariance[19] = reader.ReadSingle();
            message.Covariance[20] = reader.ReadSingle();
            message.Covariance[21] = reader.ReadSingle();
            message.Covariance[22] = reader.ReadSingle();
            message.Covariance[23] = reader.ReadSingle();
            message.Covariance[24] = reader.ReadSingle();
            message.Covariance[25] = reader.ReadSingle();
            message.Covariance[26] = reader.ReadSingle();
            message.Covariance[27] = reader.ReadSingle();
            message.Covariance[28] = reader.ReadSingle();
            message.Covariance[29] = reader.ReadSingle();
            message.Covariance[30] = reader.ReadSingle();
            message.Covariance[31] = reader.ReadSingle();
            message.Covariance[32] = reader.ReadSingle();
            message.Covariance[33] = reader.ReadSingle();
            message.Covariance[34] = reader.ReadSingle();
            message.Covariance[35] = reader.ReadSingle();
            message.EstimatorType = ((MavLink4Net.Messages.Common.EstimatorType)(reader.ReadByte()));
            return message;
        }
    }
}
