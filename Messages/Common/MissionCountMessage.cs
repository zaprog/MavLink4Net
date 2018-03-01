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
    /// This message is emitted as response to MISSION_REQUEST_LIST by the MAV and to initiate a write transaction. The GCS can then request the individual mission item based on the knowledge of the total number of waypoints.
    /// </summary>
    /// <remarks>
    /// MISSION_COUNT
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.MissionCount, Name="MISSION_COUNT", Description="This message is emitted as response to MISSION_REQUEST_LIST by the MAV and to ini" +
        "tiate a write transaction. The GCS can then request the individual mission item " +
        "based on the knowledge of the total number of waypoints.")]
    public class MissionCountMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// System ID
        /// </summary>
        /// <remarks>
        /// target_system
        /// </remarks>
        private byte _targetSystem;
        
        /// <summary>
        /// Component ID
        /// </summary>
        /// <remarks>
        /// target_component
        /// </remarks>
        private byte _targetComponent;
        
        /// <summary>
        /// Number of mission items in the sequence
        /// </summary>
        /// <remarks>
        /// count
        /// </remarks>
        private ushort _count;
        
        /// <summary>
        /// Mission type, see MAV_MISSION_TYPE
        /// </summary>
        /// <remarks>
        /// mission_type
        /// </remarks>
        private MissionType _missionType;
        
        public MissionCountMessage() : 
                base(MavLink4Net.Messages.MavMessageType.MissionCount, 52)
        {
        }
        
        /// <summary>
        /// System ID
        /// </summary>
        [MessageFieldMetadata(Name="target_system", Type="uint8_t", Description="System ID")]
        public byte TargetSystem
        {
            get
            {
                return this._targetSystem;
            }
            set
            {
                this._targetSystem = value;
            }
        }
        
        /// <summary>
        /// Component ID
        /// </summary>
        [MessageFieldMetadata(Name="target_component", Type="uint8_t", Description="Component ID")]
        public byte TargetComponent
        {
            get
            {
                return this._targetComponent;
            }
            set
            {
                this._targetComponent = value;
            }
        }
        
        /// <summary>
        /// Number of mission items in the sequence
        /// </summary>
        [MessageFieldMetadata(Name="count", Type="uint16_t", Description="Number of mission items in the sequence")]
        public ushort Count
        {
            get
            {
                return this._count;
            }
            set
            {
                this._count = value;
            }
        }
        
        /// <summary>
        /// Mission type, see MAV_MISSION_TYPE
        /// </summary>
        [MessageFieldMetadata(Name="mission_type", Type="MAV_MISSION_TYPE enum", Description="Mission type, see MAV_MISSION_TYPE")]
        public MissionType MissionType
        {
            get
            {
                return this._missionType;
            }
            set
            {
                this._missionType = value;
            }
        }
    }
}
