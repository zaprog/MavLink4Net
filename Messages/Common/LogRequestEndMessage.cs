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
    /// Stop log transfer and resume normal logging
    /// </summary>
    /// <remarks>
    /// LOG_REQUEST_END
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.LogRequestEnd, Name="LOG_REQUEST_END", Description="Stop log transfer and resume normal logging")]
    public class LogRequestEndMessage : MavLink4Net.Messages.Message
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
        
        public LogRequestEndMessage() : 
                base(MavLink4Net.Messages.MavMessageType.LogRequestEnd, 203)
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
    }
}
