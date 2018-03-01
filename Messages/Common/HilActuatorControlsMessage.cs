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
    /// Sent from autopilot to simulation. Hardware in the loop control outputs (replacement for HIL_CONTROLS)
    /// </summary>
    /// <remarks>
    /// HIL_ACTUATOR_CONTROLS
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.HilActuatorControls, Name="HIL_ACTUATOR_CONTROLS", Description="Sent from autopilot to simulation. Hardware in the loop control outputs (replacem" +
        "ent for HIL_CONTROLS)")]
    public class HilActuatorControlsMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp (microseconds since UNIX epoch or microseconds since system boot)
        /// </summary>
        /// <remarks>
        /// time_usec
        /// </remarks>
        private ulong _timeUsec;
        
        /// <summary>
        /// Control outputs -1 .. 1. Channel assignment depends on the simulated hardware.
        /// </summary>
        /// <remarks>
        /// controls
        /// </remarks>
        private float[] _controls = new float[16];
        
        /// <summary>
        /// System mode (MAV_MODE), includes arming state.
        /// </summary>
        /// <remarks>
        /// mode
        /// </remarks>
        private Mode _mode;
        
        /// <summary>
        /// Flags as bitfield, reserved for future use.
        /// </summary>
        /// <remarks>
        /// flags
        /// </remarks>
        private ulong _flags;
        
        public HilActuatorControlsMessage() : 
                base(MavLink4Net.Messages.MavMessageType.HilActuatorControls, 47)
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
        /// Control outputs -1 .. 1. Channel assignment depends on the simulated hardware.
        /// </summary>
        [MessageFieldMetadata(Name="controls", Type="float[16]", Description="Control outputs -1 .. 1. Channel assignment depends on the simulated hardware.")]
        public float[] Controls
        {
            get
            {
                return this._controls;
            }
            set
            {
                this._controls = value;
            }
        }
        
        /// <summary>
        /// System mode (MAV_MODE), includes arming state.
        /// </summary>
        [MessageFieldMetadata(Name="mode", Type="MAV_MODE enum", Description="System mode (MAV_MODE), includes arming state.")]
        public Mode Mode
        {
            get
            {
                return this._mode;
            }
            set
            {
                this._mode = value;
            }
        }
        
        /// <summary>
        /// Flags as bitfield, reserved for future use.
        /// </summary>
        [MessageFieldMetadata(Name="flags", Type="uint64_t", Display="bitmask", Description="Flags as bitfield, reserved for future use.")]
        public ulong Flags
        {
            get
            {
                return this._flags;
            }
            set
            {
                this._flags = value;
            }
        }
    }
}
