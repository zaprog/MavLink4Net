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
    
    
    public class AttitudeQuaternionCovMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.AttitudeQuaternionCovMessage tMessage = message as MavLink4Net.Messages.Common.AttitudeQuaternionCovMessage;
            writer.Write(tMessage.TimeUsec);
            writer.Write(tMessage.Q[0]);
            writer.Write(tMessage.Q[1]);
            writer.Write(tMessage.Q[2]);
            writer.Write(tMessage.Q[3]);
            writer.Write(tMessage.Rollspeed);
            writer.Write(tMessage.Pitchspeed);
            writer.Write(tMessage.Yawspeed);
            writer.Write(tMessage.Covariance[0]);
            writer.Write(tMessage.Covariance[1]);
            writer.Write(tMessage.Covariance[2]);
            writer.Write(tMessage.Covariance[3]);
            writer.Write(tMessage.Covariance[4]);
            writer.Write(tMessage.Covariance[5]);
            writer.Write(tMessage.Covariance[6]);
            writer.Write(tMessage.Covariance[7]);
            writer.Write(tMessage.Covariance[8]);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.AttitudeQuaternionCovMessage message = new MavLink4Net.Messages.Common.AttitudeQuaternionCovMessage();
            message.TimeUsec = reader.ReadUInt64();
            message.Q[0] = reader.ReadSingle();
            message.Q[1] = reader.ReadSingle();
            message.Q[2] = reader.ReadSingle();
            message.Q[3] = reader.ReadSingle();
            message.Rollspeed = reader.ReadSingle();
            message.Pitchspeed = reader.ReadSingle();
            message.Yawspeed = reader.ReadSingle();
            message.Covariance[0] = reader.ReadSingle();
            message.Covariance[1] = reader.ReadSingle();
            message.Covariance[2] = reader.ReadSingle();
            message.Covariance[3] = reader.ReadSingle();
            message.Covariance[4] = reader.ReadSingle();
            message.Covariance[5] = reader.ReadSingle();
            message.Covariance[6] = reader.ReadSingle();
            message.Covariance[7] = reader.ReadSingle();
            message.Covariance[8] = reader.ReadSingle();
            return message;
        }
    }
}
