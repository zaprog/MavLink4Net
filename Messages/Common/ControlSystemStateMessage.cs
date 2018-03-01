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
    /// The smoothed, monotonic system state used to feed the control loops of the system.
    /// </summary>
    /// <remarks>
    /// CONTROL_SYSTEM_STATE
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.ControlSystemState, Name="CONTROL_SYSTEM_STATE", Description="The smoothed, monotonic system state used to feed the control loops of the system" +
        ".")]
    public class ControlSystemStateMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp (micros since boot or Unix epoch)
        /// </summary>
        /// <remarks>
        /// time_usec
        /// </remarks>
        private ulong _timeUsec;
        
        /// <summary>
        /// X acceleration in body frame
        /// </summary>
        /// <remarks>
        /// x_acc
        /// </remarks>
        private float _xAcc;
        
        /// <summary>
        /// Y acceleration in body frame
        /// </summary>
        /// <remarks>
        /// y_acc
        /// </remarks>
        private float _yAcc;
        
        /// <summary>
        /// Z acceleration in body frame
        /// </summary>
        /// <remarks>
        /// z_acc
        /// </remarks>
        private float _zAcc;
        
        /// <summary>
        /// X velocity in body frame
        /// </summary>
        /// <remarks>
        /// x_vel
        /// </remarks>
        private float _xVel;
        
        /// <summary>
        /// Y velocity in body frame
        /// </summary>
        /// <remarks>
        /// y_vel
        /// </remarks>
        private float _yVel;
        
        /// <summary>
        /// Z velocity in body frame
        /// </summary>
        /// <remarks>
        /// z_vel
        /// </remarks>
        private float _zVel;
        
        /// <summary>
        /// X position in local frame
        /// </summary>
        /// <remarks>
        /// x_pos
        /// </remarks>
        private float _xPos;
        
        /// <summary>
        /// Y position in local frame
        /// </summary>
        /// <remarks>
        /// y_pos
        /// </remarks>
        private float _yPos;
        
        /// <summary>
        /// Z position in local frame
        /// </summary>
        /// <remarks>
        /// z_pos
        /// </remarks>
        private float _zPos;
        
        /// <summary>
        /// Airspeed, set to -1 if unknown
        /// </summary>
        /// <remarks>
        /// airspeed
        /// </remarks>
        private float _airspeed;
        
        /// <summary>
        /// Variance of body velocity estimate
        /// </summary>
        /// <remarks>
        /// vel_variance
        /// </remarks>
        private float[] _velVariance = new float[3];
        
        /// <summary>
        /// Variance in local position
        /// </summary>
        /// <remarks>
        /// pos_variance
        /// </remarks>
        private float[] _posVariance = new float[3];
        
        /// <summary>
        /// The attitude, represented as Quaternion
        /// </summary>
        /// <remarks>
        /// q
        /// </remarks>
        private float[] _q = new float[4];
        
        /// <summary>
        /// Angular rate in roll axis
        /// </summary>
        /// <remarks>
        /// roll_rate
        /// </remarks>
        private float _rollRate;
        
        /// <summary>
        /// Angular rate in pitch axis
        /// </summary>
        /// <remarks>
        /// pitch_rate
        /// </remarks>
        private float _pitchRate;
        
        /// <summary>
        /// Angular rate in yaw axis
        /// </summary>
        /// <remarks>
        /// yaw_rate
        /// </remarks>
        private float _yawRate;
        
        public ControlSystemStateMessage() : 
                base(MavLink4Net.Messages.MavMessageType.ControlSystemState, 103)
        {
        }
        
        /// <summary>
        /// Timestamp (micros since boot or Unix epoch)
        /// </summary>
        [MessageFieldMetadata(Name="time_usec", Type="uint64_t", Units="us", Description="Timestamp (micros since boot or Unix epoch)")]
        public ulong TimeUsec
        {
            get
            {
                return this._timeUsec;
            }
            set
            {
                this._timeUsec = value;
            }
        }
        
        /// <summary>
        /// X acceleration in body frame
        /// </summary>
        [MessageFieldMetadata(Name="x_acc", Type="float", Units="m/s/s", Description="X acceleration in body frame")]
        public float XAcc
        {
            get
            {
                return this._xAcc;
            }
            set
            {
                this._xAcc = value;
            }
        }
        
        /// <summary>
        /// Y acceleration in body frame
        /// </summary>
        [MessageFieldMetadata(Name="y_acc", Type="float", Units="m/s/s", Description="Y acceleration in body frame")]
        public float YAcc
        {
            get
            {
                return this._yAcc;
            }
            set
            {
                this._yAcc = value;
            }
        }
        
        /// <summary>
        /// Z acceleration in body frame
        /// </summary>
        [MessageFieldMetadata(Name="z_acc", Type="float", Units="m/s/s", Description="Z acceleration in body frame")]
        public float ZAcc
        {
            get
            {
                return this._zAcc;
            }
            set
            {
                this._zAcc = value;
            }
        }
        
        /// <summary>
        /// X velocity in body frame
        /// </summary>
        [MessageFieldMetadata(Name="x_vel", Type="float", Units="m/s", Description="X velocity in body frame")]
        public float XVel
        {
            get
            {
                return this._xVel;
            }
            set
            {
                this._xVel = value;
            }
        }
        
        /// <summary>
        /// Y velocity in body frame
        /// </summary>
        [MessageFieldMetadata(Name="y_vel", Type="float", Units="m/s", Description="Y velocity in body frame")]
        public float YVel
        {
            get
            {
                return this._yVel;
            }
            set
            {
                this._yVel = value;
            }
        }
        
        /// <summary>
        /// Z velocity in body frame
        /// </summary>
        [MessageFieldMetadata(Name="z_vel", Type="float", Units="m/s", Description="Z velocity in body frame")]
        public float ZVel
        {
            get
            {
                return this._zVel;
            }
            set
            {
                this._zVel = value;
            }
        }
        
        /// <summary>
        /// X position in local frame
        /// </summary>
        [MessageFieldMetadata(Name="x_pos", Type="float", Units="m", Description="X position in local frame")]
        public float XPos
        {
            get
            {
                return this._xPos;
            }
            set
            {
                this._xPos = value;
            }
        }
        
        /// <summary>
        /// Y position in local frame
        /// </summary>
        [MessageFieldMetadata(Name="y_pos", Type="float", Units="m", Description="Y position in local frame")]
        public float YPos
        {
            get
            {
                return this._yPos;
            }
            set
            {
                this._yPos = value;
            }
        }
        
        /// <summary>
        /// Z position in local frame
        /// </summary>
        [MessageFieldMetadata(Name="z_pos", Type="float", Units="m", Description="Z position in local frame")]
        public float ZPos
        {
            get
            {
                return this._zPos;
            }
            set
            {
                this._zPos = value;
            }
        }
        
        /// <summary>
        /// Airspeed, set to -1 if unknown
        /// </summary>
        [MessageFieldMetadata(Name="airspeed", Type="float", Units="m/s", Description="Airspeed, set to -1 if unknown")]
        public float Airspeed
        {
            get
            {
                return this._airspeed;
            }
            set
            {
                this._airspeed = value;
            }
        }
        
        /// <summary>
        /// Variance of body velocity estimate
        /// </summary>
        [MessageFieldMetadata(Name="vel_variance", Type="float[3]", Description="Variance of body velocity estimate")]
        public float[] VelVariance
        {
            get
            {
                return this._velVariance;
            }
            set
            {
                this._velVariance = value;
            }
        }
        
        /// <summary>
        /// Variance in local position
        /// </summary>
        [MessageFieldMetadata(Name="pos_variance", Type="float[3]", Description="Variance in local position")]
        public float[] PosVariance
        {
            get
            {
                return this._posVariance;
            }
            set
            {
                this._posVariance = value;
            }
        }
        
        /// <summary>
        /// The attitude, represented as Quaternion
        /// </summary>
        [MessageFieldMetadata(Name="q", Type="float[4]", Description="The attitude, represented as Quaternion")]
        public float[] Q
        {
            get
            {
                return this._q;
            }
            set
            {
                this._q = value;
            }
        }
        
        /// <summary>
        /// Angular rate in roll axis
        /// </summary>
        [MessageFieldMetadata(Name="roll_rate", Type="float", Units="rad/s", Description="Angular rate in roll axis")]
        public float RollRate
        {
            get
            {
                return this._rollRate;
            }
            set
            {
                this._rollRate = value;
            }
        }
        
        /// <summary>
        /// Angular rate in pitch axis
        /// </summary>
        [MessageFieldMetadata(Name="pitch_rate", Type="float", Units="rad/s", Description="Angular rate in pitch axis")]
        public float PitchRate
        {
            get
            {
                return this._pitchRate;
            }
            set
            {
                this._pitchRate = value;
            }
        }
        
        /// <summary>
        /// Angular rate in yaw axis
        /// </summary>
        [MessageFieldMetadata(Name="yaw_rate", Type="float", Units="rad/s", Description="Angular rate in yaw axis")]
        public float YawRate
        {
            get
            {
                return this._yawRate;
            }
            set
            {
                this._yawRate = value;
            }
        }
    }
}
