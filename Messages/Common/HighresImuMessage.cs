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
    /// The IMU readings in SI units in NED body frame
    /// </summary>
    /// <remarks>
    /// HIGHRES_IMU
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.HighresImu, Name="HIGHRES_IMU", Description="The IMU readings in SI units in NED body frame")]
    public class HighresImuMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp (microseconds, synced to UNIX time or since system boot)
        /// </summary>
        /// <remarks>
        /// time_usec
        /// </remarks>
        private ulong _timeUsec;
        
        /// <summary>
        /// X acceleration (m/s^2)
        /// </summary>
        /// <remarks>
        /// xacc
        /// </remarks>
        private float _xacc;
        
        /// <summary>
        /// Y acceleration (m/s^2)
        /// </summary>
        /// <remarks>
        /// yacc
        /// </remarks>
        private float _yacc;
        
        /// <summary>
        /// Z acceleration (m/s^2)
        /// </summary>
        /// <remarks>
        /// zacc
        /// </remarks>
        private float _zacc;
        
        /// <summary>
        /// Angular speed around X axis (rad / sec)
        /// </summary>
        /// <remarks>
        /// xgyro
        /// </remarks>
        private float _xgyro;
        
        /// <summary>
        /// Angular speed around Y axis (rad / sec)
        /// </summary>
        /// <remarks>
        /// ygyro
        /// </remarks>
        private float _ygyro;
        
        /// <summary>
        /// Angular speed around Z axis (rad / sec)
        /// </summary>
        /// <remarks>
        /// zgyro
        /// </remarks>
        private float _zgyro;
        
        /// <summary>
        /// X Magnetic field (Gauss)
        /// </summary>
        /// <remarks>
        /// xmag
        /// </remarks>
        private float _xmag;
        
        /// <summary>
        /// Y Magnetic field (Gauss)
        /// </summary>
        /// <remarks>
        /// ymag
        /// </remarks>
        private float _ymag;
        
        /// <summary>
        /// Z Magnetic field (Gauss)
        /// </summary>
        /// <remarks>
        /// zmag
        /// </remarks>
        private float _zmag;
        
        /// <summary>
        /// Absolute pressure in millibar
        /// </summary>
        /// <remarks>
        /// abs_pressure
        /// </remarks>
        private float _absPressure;
        
        /// <summary>
        /// Differential pressure in millibar
        /// </summary>
        /// <remarks>
        /// diff_pressure
        /// </remarks>
        private float _diffPressure;
        
        /// <summary>
        /// Altitude calculated from pressure
        /// </summary>
        /// <remarks>
        /// pressure_alt
        /// </remarks>
        private float _pressureAlt;
        
        /// <summary>
        /// Temperature in degrees celsius
        /// </summary>
        /// <remarks>
        /// temperature
        /// </remarks>
        private float _temperature;
        
        /// <summary>
        /// Bitmask for fields that have updated since last message, bit 0 = xacc, bit 12: temperature
        /// </summary>
        /// <remarks>
        /// fields_updated
        /// </remarks>
        private ushort _fieldsUpdated;
        
        public HighresImuMessage() : 
                base(MavLink4Net.Messages.MavMessageType.HighresImu, 93)
        {
        }
        
        /// <summary>
        /// Timestamp (microseconds, synced to UNIX time or since system boot)
        /// </summary>
        [MessageFieldMetadata(Name="time_usec", Type="uint64_t", Units="us", Description="Timestamp (microseconds, synced to UNIX time or since system boot)")]
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
        /// X acceleration (m/s^2)
        /// </summary>
        [MessageFieldMetadata(Name="xacc", Type="float", Units="m/s/s", Description="X acceleration (m/s^2)")]
        public float Xacc
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
        /// Y acceleration (m/s^2)
        /// </summary>
        [MessageFieldMetadata(Name="yacc", Type="float", Units="m/s/s", Description="Y acceleration (m/s^2)")]
        public float Yacc
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
        /// Z acceleration (m/s^2)
        /// </summary>
        [MessageFieldMetadata(Name="zacc", Type="float", Units="m/s/s", Description="Z acceleration (m/s^2)")]
        public float Zacc
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
        
        /// <summary>
        /// Angular speed around X axis (rad / sec)
        /// </summary>
        [MessageFieldMetadata(Name="xgyro", Type="float", Units="rad/s", Description="Angular speed around X axis (rad / sec)")]
        public float Xgyro
        {
            get
            {
                return this._xgyro;
            }
            set
            {
                this._xgyro = value;
            }
        }
        
        /// <summary>
        /// Angular speed around Y axis (rad / sec)
        /// </summary>
        [MessageFieldMetadata(Name="ygyro", Type="float", Units="rad/s", Description="Angular speed around Y axis (rad / sec)")]
        public float Ygyro
        {
            get
            {
                return this._ygyro;
            }
            set
            {
                this._ygyro = value;
            }
        }
        
        /// <summary>
        /// Angular speed around Z axis (rad / sec)
        /// </summary>
        [MessageFieldMetadata(Name="zgyro", Type="float", Units="rad/s", Description="Angular speed around Z axis (rad / sec)")]
        public float Zgyro
        {
            get
            {
                return this._zgyro;
            }
            set
            {
                this._zgyro = value;
            }
        }
        
        /// <summary>
        /// X Magnetic field (Gauss)
        /// </summary>
        [MessageFieldMetadata(Name="xmag", Type="float", Units="gauss", Description="X Magnetic field (Gauss)")]
        public float Xmag
        {
            get
            {
                return this._xmag;
            }
            set
            {
                this._xmag = value;
            }
        }
        
        /// <summary>
        /// Y Magnetic field (Gauss)
        /// </summary>
        [MessageFieldMetadata(Name="ymag", Type="float", Units="gauss", Description="Y Magnetic field (Gauss)")]
        public float Ymag
        {
            get
            {
                return this._ymag;
            }
            set
            {
                this._ymag = value;
            }
        }
        
        /// <summary>
        /// Z Magnetic field (Gauss)
        /// </summary>
        [MessageFieldMetadata(Name="zmag", Type="float", Units="gauss", Description="Z Magnetic field (Gauss)")]
        public float Zmag
        {
            get
            {
                return this._zmag;
            }
            set
            {
                this._zmag = value;
            }
        }
        
        /// <summary>
        /// Absolute pressure in millibar
        /// </summary>
        [MessageFieldMetadata(Name="abs_pressure", Type="float", Units="mbar", Description="Absolute pressure in millibar")]
        public float AbsPressure
        {
            get
            {
                return this._absPressure;
            }
            set
            {
                this._absPressure = value;
            }
        }
        
        /// <summary>
        /// Differential pressure in millibar
        /// </summary>
        [MessageFieldMetadata(Name="diff_pressure", Type="float", Units="mbar", Description="Differential pressure in millibar")]
        public float DiffPressure
        {
            get
            {
                return this._diffPressure;
            }
            set
            {
                this._diffPressure = value;
            }
        }
        
        /// <summary>
        /// Altitude calculated from pressure
        /// </summary>
        [MessageFieldMetadata(Name="pressure_alt", Type="float", Description="Altitude calculated from pressure")]
        public float PressureAlt
        {
            get
            {
                return this._pressureAlt;
            }
            set
            {
                this._pressureAlt = value;
            }
        }
        
        /// <summary>
        /// Temperature in degrees celsius
        /// </summary>
        [MessageFieldMetadata(Name="temperature", Type="float", Units="degC", Description="Temperature in degrees celsius")]
        public float Temperature
        {
            get
            {
                return this._temperature;
            }
            set
            {
                this._temperature = value;
            }
        }
        
        /// <summary>
        /// Bitmask for fields that have updated since last message, bit 0 = xacc, bit 12: temperature
        /// </summary>
        [MessageFieldMetadata(Name="fields_updated", Type="uint16_t", Display="bitmask", Description="Bitmask for fields that have updated since last message, bit 0 = xacc, bit 12: te" +
            "mperature")]
        public ushort FieldsUpdated
        {
            get
            {
                return this._fieldsUpdated;
            }
            set
            {
                this._fieldsUpdated = value;
            }
        }
    }
}