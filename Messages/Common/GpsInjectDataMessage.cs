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
    /// data for injecting into the onboard GPS (used for DGPS)
    /// </summary>
    /// <remarks>
    /// GPS_INJECT_DATA
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.GpsInjectData, Name="GPS_INJECT_DATA", Description="data for injecting into the onboard GPS (used for DGPS)")]
    public class GpsInjectDataMessage : MavLink4Net.Messages.Message
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
        /// data length
        /// </summary>
        /// <remarks>
        /// len
        /// </remarks>
        private byte _len;
        
        /// <summary>
        /// raw data (110 is enough for 12 satellites of RTCMv2)
        /// </summary>
        /// <remarks>
        /// data
        /// </remarks>
        private byte[] _data = new byte[110];
        
        public GpsInjectDataMessage() : 
                base(MavLink4Net.Messages.MavMessageType.GpsInjectData, 250)
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
        /// data length
        /// </summary>
        [MessageFieldMetadata(Name="len", Type="uint8_t", Units="bytes", Description="data length")]
        public byte Len
        {
            get
            {
                return this._len;
            }
            set
            {
                this._len = value;
            }
        }
        
        /// <summary>
        /// raw data (110 is enough for 12 satellites of RTCMv2)
        /// </summary>
        [MessageFieldMetadata(Name="data", Type="uint8_t[110]", Description="raw data (110 is enough for 12 satellites of RTCMv2)")]
        public byte[] Data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }
    }
}
