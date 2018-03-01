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
    /// Sent from simulation to autopilot. The RAW values of the RC channels received. The standard PPM modulation is as follows: 1000 microseconds: 0%, 2000 microseconds: 100%. Individual receivers/transmitters might violate this specification.
    /// </summary>
    /// <remarks>
    /// HIL_RC_INPUTS_RAW
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.HilRcInputsRaw, Name="HIL_RC_INPUTS_RAW", Description="Sent from simulation to autopilot. The RAW values of the RC channels received. Th" +
        "e standard PPM modulation is as follows: 1000 microseconds: 0%, 2000 microsecond" +
        "s: 100%. Individual receivers/transmitters might violate this specification.")]
    public class HilRcInputsRawMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp (microseconds since UNIX epoch or microseconds since system boot)
        /// </summary>
        /// <remarks>
        /// time_usec
        /// </remarks>
        private ulong _timeUsec;
        
        /// <summary>
        /// RC channel 1 value, in microseconds
        /// </summary>
        /// <remarks>
        /// chan1_raw
        /// </remarks>
        private ushort _chan1Raw;
        
        /// <summary>
        /// RC channel 2 value, in microseconds
        /// </summary>
        /// <remarks>
        /// chan2_raw
        /// </remarks>
        private ushort _chan2Raw;
        
        /// <summary>
        /// RC channel 3 value, in microseconds
        /// </summary>
        /// <remarks>
        /// chan3_raw
        /// </remarks>
        private ushort _chan3Raw;
        
        /// <summary>
        /// RC channel 4 value, in microseconds
        /// </summary>
        /// <remarks>
        /// chan4_raw
        /// </remarks>
        private ushort _chan4Raw;
        
        /// <summary>
        /// RC channel 5 value, in microseconds
        /// </summary>
        /// <remarks>
        /// chan5_raw
        /// </remarks>
        private ushort _chan5Raw;
        
        /// <summary>
        /// RC channel 6 value, in microseconds
        /// </summary>
        /// <remarks>
        /// chan6_raw
        /// </remarks>
        private ushort _chan6Raw;
        
        /// <summary>
        /// RC channel 7 value, in microseconds
        /// </summary>
        /// <remarks>
        /// chan7_raw
        /// </remarks>
        private ushort _chan7Raw;
        
        /// <summary>
        /// RC channel 8 value, in microseconds
        /// </summary>
        /// <remarks>
        /// chan8_raw
        /// </remarks>
        private ushort _chan8Raw;
        
        /// <summary>
        /// RC channel 9 value, in microseconds
        /// </summary>
        /// <remarks>
        /// chan9_raw
        /// </remarks>
        private ushort _chan9Raw;
        
        /// <summary>
        /// RC channel 10 value, in microseconds
        /// </summary>
        /// <remarks>
        /// chan10_raw
        /// </remarks>
        private ushort _chan10Raw;
        
        /// <summary>
        /// RC channel 11 value, in microseconds
        /// </summary>
        /// <remarks>
        /// chan11_raw
        /// </remarks>
        private ushort _chan11Raw;
        
        /// <summary>
        /// RC channel 12 value, in microseconds
        /// </summary>
        /// <remarks>
        /// chan12_raw
        /// </remarks>
        private ushort _chan12Raw;
        
        /// <summary>
        /// Receive signal strength indicator, 0: 0%, 255: 100%
        /// </summary>
        /// <remarks>
        /// rssi
        /// </remarks>
        private byte _rssi;
        
        public HilRcInputsRawMessage() : 
                base(MavLink4Net.Messages.MavMessageType.HilRcInputsRaw, 54)
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
        /// RC channel 1 value, in microseconds
        /// </summary>
        [MessageFieldMetadata(Name="chan1_raw", Type="uint16_t", Units="us", Description="RC channel 1 value, in microseconds")]
        public ushort Chan1Raw
        {
            get
            {
                return this._chan1Raw;
            }
            set
            {
                this._chan1Raw = value;
            }
        }
        
        /// <summary>
        /// RC channel 2 value, in microseconds
        /// </summary>
        [MessageFieldMetadata(Name="chan2_raw", Type="uint16_t", Units="us", Description="RC channel 2 value, in microseconds")]
        public ushort Chan2Raw
        {
            get
            {
                return this._chan2Raw;
            }
            set
            {
                this._chan2Raw = value;
            }
        }
        
        /// <summary>
        /// RC channel 3 value, in microseconds
        /// </summary>
        [MessageFieldMetadata(Name="chan3_raw", Type="uint16_t", Units="us", Description="RC channel 3 value, in microseconds")]
        public ushort Chan3Raw
        {
            get
            {
                return this._chan3Raw;
            }
            set
            {
                this._chan3Raw = value;
            }
        }
        
        /// <summary>
        /// RC channel 4 value, in microseconds
        /// </summary>
        [MessageFieldMetadata(Name="chan4_raw", Type="uint16_t", Units="us", Description="RC channel 4 value, in microseconds")]
        public ushort Chan4Raw
        {
            get
            {
                return this._chan4Raw;
            }
            set
            {
                this._chan4Raw = value;
            }
        }
        
        /// <summary>
        /// RC channel 5 value, in microseconds
        /// </summary>
        [MessageFieldMetadata(Name="chan5_raw", Type="uint16_t", Units="us", Description="RC channel 5 value, in microseconds")]
        public ushort Chan5Raw
        {
            get
            {
                return this._chan5Raw;
            }
            set
            {
                this._chan5Raw = value;
            }
        }
        
        /// <summary>
        /// RC channel 6 value, in microseconds
        /// </summary>
        [MessageFieldMetadata(Name="chan6_raw", Type="uint16_t", Units="us", Description="RC channel 6 value, in microseconds")]
        public ushort Chan6Raw
        {
            get
            {
                return this._chan6Raw;
            }
            set
            {
                this._chan6Raw = value;
            }
        }
        
        /// <summary>
        /// RC channel 7 value, in microseconds
        /// </summary>
        [MessageFieldMetadata(Name="chan7_raw", Type="uint16_t", Units="us", Description="RC channel 7 value, in microseconds")]
        public ushort Chan7Raw
        {
            get
            {
                return this._chan7Raw;
            }
            set
            {
                this._chan7Raw = value;
            }
        }
        
        /// <summary>
        /// RC channel 8 value, in microseconds
        /// </summary>
        [MessageFieldMetadata(Name="chan8_raw", Type="uint16_t", Units="us", Description="RC channel 8 value, in microseconds")]
        public ushort Chan8Raw
        {
            get
            {
                return this._chan8Raw;
            }
            set
            {
                this._chan8Raw = value;
            }
        }
        
        /// <summary>
        /// RC channel 9 value, in microseconds
        /// </summary>
        [MessageFieldMetadata(Name="chan9_raw", Type="uint16_t", Units="us", Description="RC channel 9 value, in microseconds")]
        public ushort Chan9Raw
        {
            get
            {
                return this._chan9Raw;
            }
            set
            {
                this._chan9Raw = value;
            }
        }
        
        /// <summary>
        /// RC channel 10 value, in microseconds
        /// </summary>
        [MessageFieldMetadata(Name="chan10_raw", Type="uint16_t", Units="us", Description="RC channel 10 value, in microseconds")]
        public ushort Chan10Raw
        {
            get
            {
                return this._chan10Raw;
            }
            set
            {
                this._chan10Raw = value;
            }
        }
        
        /// <summary>
        /// RC channel 11 value, in microseconds
        /// </summary>
        [MessageFieldMetadata(Name="chan11_raw", Type="uint16_t", Units="us", Description="RC channel 11 value, in microseconds")]
        public ushort Chan11Raw
        {
            get
            {
                return this._chan11Raw;
            }
            set
            {
                this._chan11Raw = value;
            }
        }
        
        /// <summary>
        /// RC channel 12 value, in microseconds
        /// </summary>
        [MessageFieldMetadata(Name="chan12_raw", Type="uint16_t", Units="us", Description="RC channel 12 value, in microseconds")]
        public ushort Chan12Raw
        {
            get
            {
                return this._chan12Raw;
            }
            set
            {
                this._chan12Raw = value;
            }
        }
        
        /// <summary>
        /// Receive signal strength indicator, 0: 0%, 255: 100%
        /// </summary>
        [MessageFieldMetadata(Name="rssi", Type="uint8_t", Description="Receive signal strength indicator, 0: 0%, 255: 100%")]
        public byte Rssi
        {
            get
            {
                return this._rssi;
            }
            set
            {
                this._rssi = value;
            }
        }
    }
}