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
    
    
    public class AttitudeQuaternionMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.AttitudeQuaternionMessage tMessage = message as MavLink4Net.Messages.Common.AttitudeQuaternionMessage;
            writer.Write(tMessage.TimeBootMs);
            writer.Write(tMessage.Q1);
            writer.Write(tMessage.Q2);
            writer.Write(tMessage.Q3);
            writer.Write(tMessage.Q4);
            writer.Write(tMessage.Rollspeed);
            writer.Write(tMessage.Pitchspeed);
            writer.Write(tMessage.Yawspeed);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.AttitudeQuaternionMessage message = new MavLink4Net.Messages.Common.AttitudeQuaternionMessage();
            message.TimeBootMs = reader.ReadUInt32();
            message.Q1 = reader.ReadSingle();
            message.Q2 = reader.ReadSingle();
            message.Q3 = reader.ReadSingle();
            message.Q4 = reader.ReadSingle();
            message.Rollspeed = reader.ReadSingle();
            message.Pitchspeed = reader.ReadSingle();
            message.Yawspeed = reader.ReadSingle();
            return message;
        }
    }
}
