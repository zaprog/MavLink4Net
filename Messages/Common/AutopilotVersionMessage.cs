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
    /// Version and capability of autopilot software
    /// </summary>
    /// <remarks>
    /// AUTOPILOT_VERSION
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.AutopilotVersion, Name="AUTOPILOT_VERSION", Description="Version and capability of autopilot software")]
    public class AutopilotVersionMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// bitmask of capabilities (see MAV_PROTOCOL_CAPABILITY enum)
        /// </summary>
        /// <remarks>
        /// capabilities
        /// </remarks>
        private ProtocolCapability _capabilities;
        
        /// <summary>
        /// Firmware version number
        /// </summary>
        /// <remarks>
        /// flight_sw_version
        /// </remarks>
        private uint _flightSwVersion;
        
        /// <summary>
        /// Middleware version number
        /// </summary>
        /// <remarks>
        /// middleware_sw_version
        /// </remarks>
        private uint _middlewareSwVersion;
        
        /// <summary>
        /// Operating system version number
        /// </summary>
        /// <remarks>
        /// os_sw_version
        /// </remarks>
        private uint _osSwVersion;
        
        /// <summary>
        /// HW / board version (last 8 bytes should be silicon ID, if any)
        /// </summary>
        /// <remarks>
        /// board_version
        /// </remarks>
        private uint _boardVersion;
        
        /// <summary>
        /// Custom version field, commonly the first 8 bytes of the git hash. This is not an unique identifier, but should allow to identify the commit using the main version number even for very large code bases.
        /// </summary>
        /// <remarks>
        /// flight_custom_version
        /// </remarks>
        private byte[] _flightCustomVersion = new byte[8];
        
        /// <summary>
        /// Custom version field, commonly the first 8 bytes of the git hash. This is not an unique identifier, but should allow to identify the commit using the main version number even for very large code bases.
        /// </summary>
        /// <remarks>
        /// middleware_custom_version
        /// </remarks>
        private byte[] _middlewareCustomVersion = new byte[8];
        
        /// <summary>
        /// Custom version field, commonly the first 8 bytes of the git hash. This is not an unique identifier, but should allow to identify the commit using the main version number even for very large code bases.
        /// </summary>
        /// <remarks>
        /// os_custom_version
        /// </remarks>
        private byte[] _osCustomVersion = new byte[8];
        
        /// <summary>
        /// ID of the board vendor
        /// </summary>
        /// <remarks>
        /// vendor_id
        /// </remarks>
        private ushort _vendorId;
        
        /// <summary>
        /// ID of the product
        /// </summary>
        /// <remarks>
        /// product_id
        /// </remarks>
        private ushort _productId;
        
        /// <summary>
        /// UID if provided by hardware (see uid2)
        /// </summary>
        /// <remarks>
        /// uid
        /// </remarks>
        private ulong _uid;
        
        public AutopilotVersionMessage() : 
                base(MavLink4Net.Messages.MavMessageType.AutopilotVersion, 178)
        {
        }
        
        /// <summary>
        /// bitmask of capabilities (see MAV_PROTOCOL_CAPABILITY enum)
        /// </summary>
        [MessageFieldMetadata(Name="capabilities", Type="MAV_PROTOCOL_CAPABILITY enum", Display="bitmask", Description="bitmask of capabilities (see MAV_PROTOCOL_CAPABILITY enum)")]
        public ProtocolCapability Capabilities
        {
            get
            {
                return this._capabilities;
            }
            set
            {
                this._capabilities = value;
            }
        }
        
        /// <summary>
        /// Firmware version number
        /// </summary>
        [MessageFieldMetadata(Name="flight_sw_version", Type="uint32_t", Description="Firmware version number")]
        public uint FlightSwVersion
        {
            get
            {
                return this._flightSwVersion;
            }
            set
            {
                this._flightSwVersion = value;
            }
        }
        
        /// <summary>
        /// Middleware version number
        /// </summary>
        [MessageFieldMetadata(Name="middleware_sw_version", Type="uint32_t", Description="Middleware version number")]
        public uint MiddlewareSwVersion
        {
            get
            {
                return this._middlewareSwVersion;
            }
            set
            {
                this._middlewareSwVersion = value;
            }
        }
        
        /// <summary>
        /// Operating system version number
        /// </summary>
        [MessageFieldMetadata(Name="os_sw_version", Type="uint32_t", Description="Operating system version number")]
        public uint OsSwVersion
        {
            get
            {
                return this._osSwVersion;
            }
            set
            {
                this._osSwVersion = value;
            }
        }
        
        /// <summary>
        /// HW / board version (last 8 bytes should be silicon ID, if any)
        /// </summary>
        [MessageFieldMetadata(Name="board_version", Type="uint32_t", Description="HW / board version (last 8 bytes should be silicon ID, if any)")]
        public uint BoardVersion
        {
            get
            {
                return this._boardVersion;
            }
            set
            {
                this._boardVersion = value;
            }
        }
        
        /// <summary>
        /// Custom version field, commonly the first 8 bytes of the git hash. This is not an unique identifier, but should allow to identify the commit using the main version number even for very large code bases.
        /// </summary>
        [MessageFieldMetadata(Name="flight_custom_version", Type="uint8_t[8]", Description="Custom version field, commonly the first 8 bytes of the git hash. This is not an " +
            "unique identifier, but should allow to identify the commit using the main versio" +
            "n number even for very large code bases.")]
        public byte[] FlightCustomVersion
        {
            get
            {
                return this._flightCustomVersion;
            }
            set
            {
                this._flightCustomVersion = value;
            }
        }
        
        /// <summary>
        /// Custom version field, commonly the first 8 bytes of the git hash. This is not an unique identifier, but should allow to identify the commit using the main version number even for very large code bases.
        /// </summary>
        [MessageFieldMetadata(Name="middleware_custom_version", Type="uint8_t[8]", Description="Custom version field, commonly the first 8 bytes of the git hash. This is not an " +
            "unique identifier, but should allow to identify the commit using the main versio" +
            "n number even for very large code bases.")]
        public byte[] MiddlewareCustomVersion
        {
            get
            {
                return this._middlewareCustomVersion;
            }
            set
            {
                this._middlewareCustomVersion = value;
            }
        }
        
        /// <summary>
        /// Custom version field, commonly the first 8 bytes of the git hash. This is not an unique identifier, but should allow to identify the commit using the main version number even for very large code bases.
        /// </summary>
        [MessageFieldMetadata(Name="os_custom_version", Type="uint8_t[8]", Description="Custom version field, commonly the first 8 bytes of the git hash. This is not an " +
            "unique identifier, but should allow to identify the commit using the main versio" +
            "n number even for very large code bases.")]
        public byte[] OsCustomVersion
        {
            get
            {
                return this._osCustomVersion;
            }
            set
            {
                this._osCustomVersion = value;
            }
        }
        
        /// <summary>
        /// ID of the board vendor
        /// </summary>
        [MessageFieldMetadata(Name="vendor_id", Type="uint16_t", Description="ID of the board vendor")]
        public ushort VendorId
        {
            get
            {
                return this._vendorId;
            }
            set
            {
                this._vendorId = value;
            }
        }
        
        /// <summary>
        /// ID of the product
        /// </summary>
        [MessageFieldMetadata(Name="product_id", Type="uint16_t", Description="ID of the product")]
        public ushort ProductId
        {
            get
            {
                return this._productId;
            }
            set
            {
                this._productId = value;
            }
        }
        
        /// <summary>
        /// UID if provided by hardware (see uid2)
        /// </summary>
        [MessageFieldMetadata(Name="uid", Type="uint64_t", Description="UID if provided by hardware (see uid2)")]
        public ulong Uid
        {
            get
            {
                return this._uid;
            }
            set
            {
                this._uid = value;
            }
        }
    }
}
