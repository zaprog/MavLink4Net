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
    
    
    public class BatteryStatusMessageSerializer : MavLink4Net.Messages.Serialization.IMessageSerializer
    {
        
        public void Serialize(System.IO.BinaryWriter writer, MavLink4Net.Messages.Message message)
        {
            MavLink4Net.Messages.Common.BatteryStatusMessage tMessage = message as MavLink4Net.Messages.Common.BatteryStatusMessage;
            writer.Write(tMessage.CurrentConsumed);
            writer.Write(tMessage.EnergyConsumed);
            writer.Write(tMessage.Temperature);
            writer.Write(tMessage.Voltages[0]);
            writer.Write(tMessage.Voltages[1]);
            writer.Write(tMessage.Voltages[2]);
            writer.Write(tMessage.Voltages[3]);
            writer.Write(tMessage.Voltages[4]);
            writer.Write(tMessage.Voltages[5]);
            writer.Write(tMessage.Voltages[6]);
            writer.Write(tMessage.Voltages[7]);
            writer.Write(tMessage.Voltages[8]);
            writer.Write(tMessage.Voltages[9]);
            writer.Write(tMessage.CurrentBattery);
            writer.Write(tMessage.Id);
            writer.Write(((byte)(tMessage.BatteryFunction)));
            writer.Write(((byte)(tMessage.Type)));
            writer.Write(tMessage.BatteryRemaining);
        }
        
        public MavLink4Net.Messages.Message Deserialize(System.IO.BinaryReader reader)
        {
            MavLink4Net.Messages.Common.BatteryStatusMessage message = new MavLink4Net.Messages.Common.BatteryStatusMessage();
            message.CurrentConsumed = reader.ReadInt32();
            message.EnergyConsumed = reader.ReadInt32();
            message.Temperature = reader.ReadInt16();
            message.Voltages[0] = reader.ReadUInt16();
            message.Voltages[1] = reader.ReadUInt16();
            message.Voltages[2] = reader.ReadUInt16();
            message.Voltages[3] = reader.ReadUInt16();
            message.Voltages[4] = reader.ReadUInt16();
            message.Voltages[5] = reader.ReadUInt16();
            message.Voltages[6] = reader.ReadUInt16();
            message.Voltages[7] = reader.ReadUInt16();
            message.Voltages[8] = reader.ReadUInt16();
            message.Voltages[9] = reader.ReadUInt16();
            message.CurrentBattery = reader.ReadInt16();
            message.Id = reader.ReadByte();
            message.BatteryFunction = ((MavLink4Net.Messages.Common.BatteryFunction)(reader.ReadByte()));
            message.Type = ((MavLink4Net.Messages.Common.BatteryType)(reader.ReadByte()));
            message.BatteryRemaining = reader.ReadSByte();
            return message;
        }
    }
}
