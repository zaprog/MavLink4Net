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
    /// Setpoint in roll, pitch, yaw and thrust from the operator
    /// </summary>
    /// <remarks>
    /// MANUAL_SETPOINT
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.ManualSetpoint, Name="MANUAL_SETPOINT", Description="Setpoint in roll, pitch, yaw and thrust from the operator")]
    public class ManualSetpointMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp in milliseconds since system boot
        /// </summary>
        /// <remarks>
        /// time_boot_ms
        /// </remarks>
        private uint _timeBootMs;
        
        /// <summary>
        /// Desired roll rate in radians per second
        /// </summary>
        /// <remarks>
        /// roll
        /// </remarks>
        private float _roll;
        
        /// <summary>
        /// Desired pitch rate in radians per second
        /// </summary>
        /// <remarks>
        /// pitch
        /// </remarks>
        private float _pitch;
        
        /// <summary>
        /// Desired yaw rate in radians per second
        /// </summary>
        /// <remarks>
        /// yaw
        /// </remarks>
        private float _yaw;
        
        /// <summary>
        /// Collective thrust, normalized to 0 .. 1
        /// </summary>
        /// <remarks>
        /// thrust
        /// </remarks>
        private float _thrust;
        
        /// <summary>
        /// Flight mode switch position, 0.. 255
        /// </summary>
        /// <remarks>
        /// mode_switch
        /// </remarks>
        private byte _modeSwitch;
        
        /// <summary>
        /// Override mode switch position, 0.. 255
        /// </summary>
        /// <remarks>
        /// manual_override_switch
        /// </remarks>
        private byte _manualOverrideSwitch;
        
        public ManualSetpointMessage() : 
                base(MavLink4Net.Messages.MavMessageType.ManualSetpoint, 106)
        {
        }
        
        /// <summary>
        /// Timestamp in milliseconds since system boot
        /// </summary>
        [MessageFieldMetadata(Name="time_boot_ms", Type="uint32_t", Units="ms", Description="Timestamp in milliseconds since system boot")]
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
        /// Desired roll rate in radians per second
        /// </summary>
        [MessageFieldMetadata(Name="roll", Type="float", Units="rad/s", Description="Desired roll rate in radians per second")]
        public float Roll
        {
            get
            {
                return this._roll;
            }
            set
            {
                this._roll = value;
            }
        }
        
        /// <summary>
        /// Desired pitch rate in radians per second
        /// </summary>
        [MessageFieldMetadata(Name="pitch", Type="float", Units="rad/s", Description="Desired pitch rate in radians per second")]
        public float Pitch
        {
            get
            {
                return this._pitch;
            }
            set
            {
                this._pitch = value;
            }
        }
        
        /// <summary>
        /// Desired yaw rate in radians per second
        /// </summary>
        [MessageFieldMetadata(Name="yaw", Type="float", Units="rad/s", Description="Desired yaw rate in radians per second")]
        public float Yaw
        {
            get
            {
                return this._yaw;
            }
            set
            {
                this._yaw = value;
            }
        }
        
        /// <summary>
        /// Collective thrust, normalized to 0 .. 1
        /// </summary>
        [MessageFieldMetadata(Name="thrust", Type="float", Description="Collective thrust, normalized to 0 .. 1")]
        public float Thrust
        {
            get
            {
                return this._thrust;
            }
            set
            {
                this._thrust = value;
            }
        }
        
        /// <summary>
        /// Flight mode switch position, 0.. 255
        /// </summary>
        [MessageFieldMetadata(Name="mode_switch", Type="uint8_t", Description="Flight mode switch position, 0.. 255")]
        public byte ModeSwitch
        {
            get
            {
                return this._modeSwitch;
            }
            set
            {
                this._modeSwitch = value;
            }
        }
        
        /// <summary>
        /// Override mode switch position, 0.. 255
        /// </summary>
        [MessageFieldMetadata(Name="manual_override_switch", Type="uint8_t", Description="Override mode switch position, 0.. 255")]
        public byte ManualOverrideSwitch
        {
            get
            {
                return this._manualOverrideSwitch;
            }
            set
            {
                this._manualOverrideSwitch = value;
            }
        }
    }
}