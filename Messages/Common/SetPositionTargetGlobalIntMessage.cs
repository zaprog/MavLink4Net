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
    /// Sets a desired vehicle position, velocity, and/or acceleration in a global coordinate system (WGS84). Used by an external controller to command the vehicle (manual controller or other system).
    /// </summary>
    /// <remarks>
    /// SET_POSITION_TARGET_GLOBAL_INT
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.SetPositionTargetGlobalInt, Name="SET_POSITION_TARGET_GLOBAL_INT", Description="Sets a desired vehicle position, velocity, and/or acceleration in a global coordi" +
        "nate system (WGS84). Used by an external controller to command the vehicle (manu" +
        "al controller or other system).")]
    public class SetPositionTargetGlobalIntMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp in milliseconds since system boot. The rationale for the timestamp in the setpoint is to allow the system to compensate for the transport delay of the setpoint. This allows the system to compensate processing latency.
        /// </summary>
        /// <remarks>
        /// time_boot_ms
        /// </remarks>
        private uint _timeBootMs;
        
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
        /// Valid options are: MAV_FRAME_GLOBAL_INT = 5, MAV_FRAME_GLOBAL_RELATIVE_ALT_INT = 6, MAV_FRAME_GLOBAL_TERRAIN_ALT_INT = 11
        /// </summary>
        /// <remarks>
        /// coordinate_frame
        /// </remarks>
        private MavLink4Net.Messages.Common.Frame _coordinateFrame;
        
        /// <summary>
        /// Bitmask to indicate which dimensions should be ignored by the vehicle: a value of 0b0000000000000000 or 0b0000001000000000 indicates that none of the setpoint dimensions should be ignored. If bit 10 is set the floats afx afy afz should be interpreted as force instead of acceleration. Mapping: bit 1: x, bit 2: y, bit 3: z, bit 4: vx, bit 5: vy, bit 6: vz, bit 7: ax, bit 8: ay, bit 9: az, bit 10: is force setpoint, bit 11: yaw, bit 12: yaw rate
        /// </summary>
        /// <remarks>
        /// type_mask
        /// </remarks>
        private ushort _typeMask;
        
        /// <summary>
        /// X Position in WGS84 frame in 1e7 * degrees
        /// </summary>
        /// <remarks>
        /// lat_int
        /// </remarks>
        private int _latInt;
        
        /// <summary>
        /// Y Position in WGS84 frame in 1e7 * degrees
        /// </summary>
        /// <remarks>
        /// lon_int
        /// </remarks>
        private int _lonInt;
        
        /// <summary>
        /// Altitude in meters in AMSL altitude, not WGS84 if absolute or relative, above terrain if GLOBAL_TERRAIN_ALT_INT
        /// </summary>
        /// <remarks>
        /// alt
        /// </remarks>
        private float _alt;
        
        /// <summary>
        /// X velocity in NED frame in meter / s
        /// </summary>
        /// <remarks>
        /// vx
        /// </remarks>
        private float _vx;
        
        /// <summary>
        /// Y velocity in NED frame in meter / s
        /// </summary>
        /// <remarks>
        /// vy
        /// </remarks>
        private float _vy;
        
        /// <summary>
        /// Z velocity in NED frame in meter / s
        /// </summary>
        /// <remarks>
        /// vz
        /// </remarks>
        private float _vz;
        
        /// <summary>
        /// X acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N
        /// </summary>
        /// <remarks>
        /// afx
        /// </remarks>
        private float _afx;
        
        /// <summary>
        /// Y acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N
        /// </summary>
        /// <remarks>
        /// afy
        /// </remarks>
        private float _afy;
        
        /// <summary>
        /// Z acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N
        /// </summary>
        /// <remarks>
        /// afz
        /// </remarks>
        private float _afz;
        
        /// <summary>
        /// yaw setpoint in rad
        /// </summary>
        /// <remarks>
        /// yaw
        /// </remarks>
        private float _yaw;
        
        /// <summary>
        /// yaw rate setpoint in rad/s
        /// </summary>
        /// <remarks>
        /// yaw_rate
        /// </remarks>
        private float _yawRate;
        
        public SetPositionTargetGlobalIntMessage() : 
                base(MavLink4Net.Messages.MavMessageType.SetPositionTargetGlobalInt)
        {
        }
        
        /// <summary>
        /// Timestamp in milliseconds since system boot. The rationale for the timestamp in the setpoint is to allow the system to compensate for the transport delay of the setpoint. This allows the system to compensate processing latency.
        /// </summary>
        [MessageFieldMetadata(Name="time_boot_ms", Type="uint32_t", Units="ms", Description="Timestamp in milliseconds since system boot. The rationale for the timestamp in t" +
            "he setpoint is to allow the system to compensate for the transport delay of the " +
            "setpoint. This allows the system to compensate processing latency.")]
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
        /// Valid options are: MAV_FRAME_GLOBAL_INT = 5, MAV_FRAME_GLOBAL_RELATIVE_ALT_INT = 6, MAV_FRAME_GLOBAL_TERRAIN_ALT_INT = 11
        /// </summary>
        [MessageFieldMetadata(Name="coordinate_frame", Type="MAV_FRAME enum", Description="Valid options are: MAV_FRAME_GLOBAL_INT = 5, MAV_FRAME_GLOBAL_RELATIVE_ALT_INT = " +
            "6, MAV_FRAME_GLOBAL_TERRAIN_ALT_INT = 11")]
        public MavLink4Net.Messages.Common.Frame CoordinateFrame
        {
            get
            {
                return this._coordinateFrame;
            }
            set
            {
                this._coordinateFrame = value;
            }
        }
        
        /// <summary>
        /// Bitmask to indicate which dimensions should be ignored by the vehicle: a value of 0b0000000000000000 or 0b0000001000000000 indicates that none of the setpoint dimensions should be ignored. If bit 10 is set the floats afx afy afz should be interpreted as force instead of acceleration. Mapping: bit 1: x, bit 2: y, bit 3: z, bit 4: vx, bit 5: vy, bit 6: vz, bit 7: ax, bit 8: ay, bit 9: az, bit 10: is force setpoint, bit 11: yaw, bit 12: yaw rate
        /// </summary>
        [MessageFieldMetadata(Name="type_mask", Type="uint16_t", Display="bitmask", Description=@"Bitmask to indicate which dimensions should be ignored by the vehicle: a value of 0b0000000000000000 or 0b0000001000000000 indicates that none of the setpoint dimensions should be ignored. If bit 10 is set the floats afx afy afz should be interpreted as force instead of acceleration. Mapping: bit 1: x, bit 2: y, bit 3: z, bit 4: vx, bit 5: vy, bit 6: vz, bit 7: ax, bit 8: ay, bit 9: az, bit 10: is force setpoint, bit 11: yaw, bit 12: yaw rate")]
        public ushort TypeMask
        {
            get
            {
                return this._typeMask;
            }
            set
            {
                this._typeMask = value;
            }
        }
        
        /// <summary>
        /// X Position in WGS84 frame in 1e7 * degrees
        /// </summary>
        [MessageFieldMetadata(Name="lat_int", Type="int32_t", Units="degE7", Description="X Position in WGS84 frame in 1e7 * degrees")]
        public int LatInt
        {
            get
            {
                return this._latInt;
            }
            set
            {
                this._latInt = value;
            }
        }
        
        /// <summary>
        /// Y Position in WGS84 frame in 1e7 * degrees
        /// </summary>
        [MessageFieldMetadata(Name="lon_int", Type="int32_t", Units="degE7", Description="Y Position in WGS84 frame in 1e7 * degrees")]
        public int LonInt
        {
            get
            {
                return this._lonInt;
            }
            set
            {
                this._lonInt = value;
            }
        }
        
        /// <summary>
        /// Altitude in meters in AMSL altitude, not WGS84 if absolute or relative, above terrain if GLOBAL_TERRAIN_ALT_INT
        /// </summary>
        [MessageFieldMetadata(Name="alt", Type="float", Units="m", Description="Altitude in meters in AMSL altitude, not WGS84 if absolute or relative, above ter" +
            "rain if GLOBAL_TERRAIN_ALT_INT")]
        public float Alt
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
        /// X velocity in NED frame in meter / s
        /// </summary>
        [MessageFieldMetadata(Name="vx", Type="float", Units="m/s", Description="X velocity in NED frame in meter / s")]
        public float Vx
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
        /// Y velocity in NED frame in meter / s
        /// </summary>
        [MessageFieldMetadata(Name="vy", Type="float", Units="m/s", Description="Y velocity in NED frame in meter / s")]
        public float Vy
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
        /// Z velocity in NED frame in meter / s
        /// </summary>
        [MessageFieldMetadata(Name="vz", Type="float", Units="m/s", Description="Z velocity in NED frame in meter / s")]
        public float Vz
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
        /// X acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N
        /// </summary>
        [MessageFieldMetadata(Name="afx", Type="float", Units="m/s/s", Description="X acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s" +
            "^2 or N")]
        public float Afx
        {
            get
            {
                return this._afx;
            }
            set
            {
                this._afx = value;
            }
        }
        
        /// <summary>
        /// Y acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N
        /// </summary>
        [MessageFieldMetadata(Name="afy", Type="float", Units="m/s/s", Description="Y acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s" +
            "^2 or N")]
        public float Afy
        {
            get
            {
                return this._afy;
            }
            set
            {
                this._afy = value;
            }
        }
        
        /// <summary>
        /// Z acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s^2 or N
        /// </summary>
        [MessageFieldMetadata(Name="afz", Type="float", Units="m/s/s", Description="Z acceleration or force (if bit 10 of type_mask is set) in NED frame in meter / s" +
            "^2 or N")]
        public float Afz
        {
            get
            {
                return this._afz;
            }
            set
            {
                this._afz = value;
            }
        }
        
        /// <summary>
        /// yaw setpoint in rad
        /// </summary>
        [MessageFieldMetadata(Name="yaw", Type="float", Units="rad", Description="yaw setpoint in rad")]
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
        /// yaw rate setpoint in rad/s
        /// </summary>
        [MessageFieldMetadata(Name="yaw_rate", Type="float", Units="rad/s", Description="yaw rate setpoint in rad/s")]
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
