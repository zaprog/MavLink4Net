//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MavLink4Net.Messages.Metadata;
using System;
using System.ComponentModel;


namespace MavLink4Net.Messages.Common
{
    
    
    /// <summary>
    /// Message that announces the sequence number of the current active mission item. The MAV will fly towards this mission item.
    /// </summary>
    /// <remarks>
    /// MISSION_CURRENT
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.MissionCurrent, Name="MISSION_CURRENT", Description="Message that announces the sequence number of the current active mission item. Th" +
        "e MAV will fly towards this mission item.")]
    public class MissionCurrentMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Sequence
        /// </summary>
        /// <remarks>
        /// seq
        /// </remarks>
        private ushort _seq;
        
        public MissionCurrentMessage() : 
                base(MavLink4Net.Messages.MavMessageType.MissionCurrent, 28)
        {
        }
        
        /// <summary>
        /// Sequence
        /// </summary>
        [MessageFieldMetadata(Name="seq", Type="uint16_t", Description="Sequence")]
        public ushort Seq
        {
            get
            {
                return this._seq;
            }
            set
            {
                this._seq = value;
            }
        }
    }
}
