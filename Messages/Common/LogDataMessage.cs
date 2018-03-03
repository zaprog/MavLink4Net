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
    /// Reply to LOG_REQUEST_DATA
    /// </summary>
    /// <remarks>
    /// LOG_DATA
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.LogData, Name="LOG_DATA", Description="Reply to LOG_REQUEST_DATA")]
    public class LogDataMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Log id (from LOG_ENTRY reply)
        /// </summary>
        /// <remarks>
        /// id
        /// </remarks>
        private ushort _id;
        
        /// <summary>
        /// Offset into the log
        /// </summary>
        /// <remarks>
        /// ofs
        /// </remarks>
        private uint _ofs;
        
        /// <summary>
        /// Number of bytes (zero for end of log)
        /// </summary>
        /// <remarks>
        /// count
        /// </remarks>
        private byte _count;
        
        /// <summary>
        /// log data
        /// </summary>
        /// <remarks>
        /// data
        /// </remarks>
        private byte[] _data = new byte[90];
        
        public LogDataMessage() : 
                base(MavLink4Net.Messages.MavMessageType.LogData)
        {
        }
        
        /// <summary>
        /// Log id (from LOG_ENTRY reply)
        /// </summary>
        [MessageFieldMetadata(Name="id", Type="uint16_t", Description="Log id (from LOG_ENTRY reply)")]
        public ushort Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        /// <summary>
        /// Offset into the log
        /// </summary>
        [MessageFieldMetadata(Name="ofs", Type="uint32_t", Description="Offset into the log")]
        public uint Ofs
        {
            get
            {
                return this._ofs;
            }
            set
            {
                this._ofs = value;
            }
        }
        
        /// <summary>
        /// Number of bytes (zero for end of log)
        /// </summary>
        [MessageFieldMetadata(Name="count", Type="uint8_t", Units="bytes", Description="Number of bytes (zero for end of log)")]
        public byte Count
        {
            get
            {
                return this._count;
            }
            set
            {
                this._count = value;
            }
        }
        
        /// <summary>
        /// log data
        /// </summary>
        [MessageFieldMetadata(Name="data", Type="uint8_t[90]", Description="log data")]
        public byte[] Data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }
    }
}
