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
    /// The attitude in the aeronautical frame (right-handed, Z-down, X-front, Y-right).
    /// </summary>
    /// <remarks>
    /// ATTITUDE
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.Attitude, Name="ATTITUDE", Description="The attitude in the aeronautical frame (right-handed, Z-down, X-front, Y-right).")]
    public class AttitudeMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp (milliseconds since system boot)
        /// </summary>
        /// <remarks>
        /// time_boot_ms
        /// </remarks>
        private uint _timeBootMs;
        
        /// <summary>
        /// Roll angle (rad, -pi..+pi)
        /// </summary>
        /// <remarks>
        /// roll
        /// </remarks>
        private float _roll;
        
        /// <summary>
        /// Pitch angle (rad, -pi..+pi)
        /// </summary>
        /// <remarks>
        /// pitch
        /// </remarks>
        private float _pitch;
        
        /// <summary>
        /// Yaw angle (rad, -pi..+pi)
        /// </summary>
        /// <remarks>
        /// yaw
        /// </remarks>
        private float _yaw;
        
        /// <summary>
        /// Roll angular speed (rad/s)
        /// </summary>
        /// <remarks>
        /// rollspeed
        /// </remarks>
        private float _rollspeed;
        
        /// <summary>
        /// Pitch angular speed (rad/s)
        /// </summary>
        /// <remarks>
        /// pitchspeed
        /// </remarks>
        private float _pitchspeed;
        
        /// <summary>
        /// Yaw angular speed (rad/s)
        /// </summary>
        /// <remarks>
        /// yawspeed
        /// </remarks>
        private float _yawspeed;
        
        public AttitudeMessage() : 
                base(MavLink4Net.Messages.MavMessageType.Attitude, 39)
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
        /// Roll angle (rad, -pi..+pi)
        /// </summary>
        [MessageFieldMetadata(Name="roll", Type="float", Units="rad", Description="Roll angle (rad, -pi..+pi)")]
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
        /// Pitch angle (rad, -pi..+pi)
        /// </summary>
        [MessageFieldMetadata(Name="pitch", Type="float", Units="rad", Description="Pitch angle (rad, -pi..+pi)")]
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
        /// Yaw angle (rad, -pi..+pi)
        /// </summary>
        [MessageFieldMetadata(Name="yaw", Type="float", Units="rad", Description="Yaw angle (rad, -pi..+pi)")]
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
        /// Roll angular speed (rad/s)
        /// </summary>
        [MessageFieldMetadata(Name="rollspeed", Type="float", Units="rad/s", Description="Roll angular speed (rad/s)")]
        public float Rollspeed
        {
            get
            {
                return this._rollspeed;
            }
            set
            {
                this._rollspeed = value;
            }
        }
        
        /// <summary>
        /// Pitch angular speed (rad/s)
        /// </summary>
        [MessageFieldMetadata(Name="pitchspeed", Type="float", Units="rad/s", Description="Pitch angular speed (rad/s)")]
        public float Pitchspeed
        {
            get
            {
                return this._pitchspeed;
            }
            set
            {
                this._pitchspeed = value;
            }
        }
        
        /// <summary>
        /// Yaw angular speed (rad/s)
        /// </summary>
        [MessageFieldMetadata(Name="yawspeed", Type="float", Units="rad/s", Description="Yaw angular speed (rad/s)")]
        public float Yawspeed
        {
            get
            {
                return this._yawspeed;
            }
            set
            {
                this._yawspeed = value;
            }
        }
    }
}
