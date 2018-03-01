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
    /// Sent from simulation to autopilot, avoids in contrast to HIL_STATE singularities. This packet is useful for high throughput applications such as hardware in the loop simulations.
    /// </summary>
    /// <remarks>
    /// HIL_STATE_QUATERNION
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.HilStateQuaternion, Name="HIL_STATE_QUATERNION", Description="Sent from simulation to autopilot, avoids in contrast to HIL_STATE singularities." +
        " This packet is useful for high throughput applications such as hardware in the " +
        "loop simulations.")]
    public class HilStateQuaternionMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp (microseconds since UNIX epoch or microseconds since system boot)
        /// </summary>
        /// <remarks>
        /// time_usec
        /// </remarks>
        private ulong _timeUsec;
        
        /// <summary>
        /// Vehicle attitude expressed as normalized quaternion in w, x, y, z order (with 1 0 0 0 being the null-rotation)
        /// </summary>
        /// <remarks>
        /// attitude_quaternion
        /// </remarks>
        private float[] _attitudeQuaternion = new float[4];
        
        /// <summary>
        /// Body frame roll / phi angular speed (rad/s)
        /// </summary>
        /// <remarks>
        /// rollspeed
        /// </remarks>
        private float _rollspeed;
        
        /// <summary>
        /// Body frame pitch / theta angular speed (rad/s)
        /// </summary>
        /// <remarks>
        /// pitchspeed
        /// </remarks>
        private float _pitchspeed;
        
        /// <summary>
        /// Body frame yaw / psi angular speed (rad/s)
        /// </summary>
        /// <remarks>
        /// yawspeed
        /// </remarks>
        private float _yawspeed;
        
        /// <summary>
        /// Latitude, expressed as degrees * 1E7
        /// </summary>
        /// <remarks>
        /// lat
        /// </remarks>
        private int _lat;
        
        /// <summary>
        /// Longitude, expressed as degrees * 1E7
        /// </summary>
        /// <remarks>
        /// lon
        /// </remarks>
        private int _lon;
        
        /// <summary>
        /// Altitude in meters, expressed as * 1000 (millimeters)
        /// </summary>
        /// <remarks>
        /// alt
        /// </remarks>
        private int _alt;
        
        /// <summary>
        /// Ground X Speed (Latitude), expressed as cm/s
        /// </summary>
        /// <remarks>
        /// vx
        /// </remarks>
        private short _vx;
        
        /// <summary>
        /// Ground Y Speed (Longitude), expressed as cm/s
        /// </summary>
        /// <remarks>
        /// vy
        /// </remarks>
        private short _vy;
        
        /// <summary>
        /// Ground Z Speed (Altitude), expressed as cm/s
        /// </summary>
        /// <remarks>
        /// vz
        /// </remarks>
        private short _vz;
        
        /// <summary>
        /// Indicated airspeed, expressed as cm/s
        /// </summary>
        /// <remarks>
        /// ind_airspeed
        /// </remarks>
        private ushort _indAirspeed;
        
        /// <summary>
        /// True airspeed, expressed as cm/s
        /// </summary>
        /// <remarks>
        /// true_airspeed
        /// </remarks>
        private ushort _trueAirspeed;
        
        /// <summary>
        /// X acceleration (mg)
        /// </summary>
        /// <remarks>
        /// xacc
        /// </remarks>
        private short _xacc;
        
        /// <summary>
        /// Y acceleration (mg)
        /// </summary>
        /// <remarks>
        /// yacc
        /// </remarks>
        private short _yacc;
        
        /// <summary>
        /// Z acceleration (mg)
        /// </summary>
        /// <remarks>
        /// zacc
        /// </remarks>
        private short _zacc;
        
        public HilStateQuaternionMessage() : 
                base(MavLink4Net.Messages.MavMessageType.HilStateQuaternion, 4)
        {
        }
        
        /// <summary>
        /// Timestamp (microseconds since UNIX epoch or microseconds since system boot)
        /// </summary>
        [MessageFieldMetadata(Name="time_usec", Type="uint64_t", Units="us", Description="Timestamp (microseconds since UNIX epoch or microseconds since system boot)")]
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
        /// Vehicle attitude expressed as normalized quaternion in w, x, y, z order (with 1 0 0 0 being the null-rotation)
        /// </summary>
        [MessageFieldMetadata(Name="attitude_quaternion", Type="float[4]", Description="Vehicle attitude expressed as normalized quaternion in w, x, y, z order (with 1 0" +
            " 0 0 being the null-rotation)")]
        public float[] AttitudeQuaternion
        {
            get
            {
                return this._attitudeQuaternion;
            }
            set
            {
                this._attitudeQuaternion = value;
            }
        }
        
        /// <summary>
        /// Body frame roll / phi angular speed (rad/s)
        /// </summary>
        [MessageFieldMetadata(Name="rollspeed", Type="float", Units="rad/s", Description="Body frame roll / phi angular speed (rad/s)")]
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
        /// Body frame pitch / theta angular speed (rad/s)
        /// </summary>
        [MessageFieldMetadata(Name="pitchspeed", Type="float", Units="rad/s", Description="Body frame pitch / theta angular speed (rad/s)")]
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
        /// Body frame yaw / psi angular speed (rad/s)
        /// </summary>
        [MessageFieldMetadata(Name="yawspeed", Type="float", Units="rad/s", Description="Body frame yaw / psi angular speed (rad/s)")]
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
        
        /// <summary>
        /// Latitude, expressed as degrees * 1E7
        /// </summary>
        [MessageFieldMetadata(Name="lat", Type="int32_t", Units="degE7", Description="Latitude, expressed as degrees * 1E7")]
        public int Lat
        {
            get
            {
                return this._lat;
            }
            set
            {
                this._lat = value;
            }
        }
        
        /// <summary>
        /// Longitude, expressed as degrees * 1E7
        /// </summary>
        [MessageFieldMetadata(Name="lon", Type="int32_t", Units="degE7", Description="Longitude, expressed as degrees * 1E7")]
        public int Lon
        {
            get
            {
                return this._lon;
            }
            set
            {
                this._lon = value;
            }
        }
        
        /// <summary>
        /// Altitude in meters, expressed as * 1000 (millimeters)
        /// </summary>
        [MessageFieldMetadata(Name="alt", Type="int32_t", Units="mm", Description="Altitude in meters, expressed as * 1000 (millimeters)")]
        public int Alt
        {
            get
            {
                return this._alt;
            }
            set
            {
                this._alt = value;
            }
        }
        
        /// <summary>
        /// Ground X Speed (Latitude), expressed as cm/s
        /// </summary>
        [MessageFieldMetadata(Name="vx", Type="int16_t", Units="cm/s", Description="Ground X Speed (Latitude), expressed as cm/s")]
        public short Vx
        {
            get
            {
                return this._vx;
            }
            set
            {
                this._vx = value;
            }
        }
        
        /// <summary>
        /// Ground Y Speed (Longitude), expressed as cm/s
        /// </summary>
        [MessageFieldMetadata(Name="vy", Type="int16_t", Units="cm/s", Description="Ground Y Speed (Longitude), expressed as cm/s")]
        public short Vy
        {
            get
            {
                return this._vy;
            }
            set
            {
                this._vy = value;
            }
        }
        
        /// <summary>
        /// Ground Z Speed (Altitude), expressed as cm/s
        /// </summary>
        [MessageFieldMetadata(Name="vz", Type="int16_t", Units="cm/s", Description="Ground Z Speed (Altitude), expressed as cm/s")]
        public short Vz
        {
            get
            {
                return this._vz;
            }
            set
            {
                this._vz = value;
            }
        }
        
        /// <summary>
        /// Indicated airspeed, expressed as cm/s
        /// </summary>
        [MessageFieldMetadata(Name="ind_airspeed", Type="uint16_t", Units="cm/s", Description="Indicated airspeed, expressed as cm/s")]
        public ushort IndAirspeed
        {
            get
            {
                return this._indAirspeed;
            }
            set
            {
                this._indAirspeed = value;
            }
        }
        
        /// <summary>
        /// True airspeed, expressed as cm/s
        /// </summary>
        [MessageFieldMetadata(Name="true_airspeed", Type="uint16_t", Units="cm/s", Description="True airspeed, expressed as cm/s")]
        public ushort TrueAirspeed
        {
            get
            {
                return this._trueAirspeed;
            }
            set
            {
                this._trueAirspeed = value;
            }
        }
        
        /// <summary>
        /// X acceleration (mg)
        /// </summary>
        [MessageFieldMetadata(Name="xacc", Type="int16_t", Units="mG", Description="X acceleration (mg)")]
        public short Xacc
        {
            get
            {
                return this._xacc;
            }
            set
            {
                this._xacc = value;
            }
        }
        
        /// <summary>
        /// Y acceleration (mg)
        /// </summary>
        [MessageFieldMetadata(Name="yacc", Type="int16_t", Units="mG", Description="Y acceleration (mg)")]
        public short Yacc
        {
            get
            {
                return this._yacc;
            }
            set
            {
                this._yacc = value;
            }
        }
        
        /// <summary>
        /// Z acceleration (mg)
        /// </summary>
        [MessageFieldMetadata(Name="zacc", Type="int16_t", Units="mG", Description="Z acceleration (mg)")]
        public short Zacc
        {
            get
            {
                return this._zacc;
            }
            set
            {
                this._zacc = value;
            }
        }
    }
}
