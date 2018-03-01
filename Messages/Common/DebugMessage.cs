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
    /// Send a debug value. The index is used to discriminate between values. These values show up in the plot of QGroundControl as DEBUG N.
    /// </summary>
    /// <remarks>
    /// DEBUG
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.Debug, Name="DEBUG", Description="Send a debug value. The index is used to discriminate between values. These value" +
        "s show up in the plot of QGroundControl as DEBUG N.")]
    public class DebugMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp (milliseconds since system boot)
        /// </summary>
        /// <remarks>
        /// time_boot_ms
        /// </remarks>
        private uint _timeBootMs;
        
        /// <summary>
        /// index of debug variable
        /// </summary>
        /// <remarks>
        /// ind
        /// </remarks>
        private byte _ind;
        
        /// <summary>
        /// DEBUG value
        /// </summary>
        /// <remarks>
        /// value
        /// </remarks>
        private float _value;
        
        public DebugMessage() : 
                base(MavLink4Net.Messages.MavMessageType.Debug, 46)
        {
        }
        
        /// <summary>
        /// Timestamp (milliseconds since system boot)
        /// </summary>
        [MessageFieldMetadata(Name="time_boot_ms", Type="uint32_t", Units="ms", Description="Timestamp (milliseconds since system boot)")]
        public uint TimeBootMs
        {
            get
            {
                return this._timeBootMs;
            }
            set
            {
                this._timeBootMs = value;
            }
        }
        
        /// <summary>
        /// index of debug variable
        /// </summary>
        [MessageFieldMetadata(Name="ind", Type="uint8_t", Description="index of debug variable")]
        public byte Ind
        {
            get
            {
                return this._ind;
            }
            set
            {
                this._ind = value;
            }
        }
        
        /// <summary>
        /// DEBUG value
        /// </summary>
        [MessageFieldMetadata(Name="value", Type="float", Description="DEBUG value")]
        public float Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}