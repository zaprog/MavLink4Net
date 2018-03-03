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
    /// The positioning status, as reported by GPS. This message is intended to display status information about each satellite visible to the receiver. See message GLOBAL_POSITION for the global position estimate. This message can contain information for up to 20 satellites.
    /// </summary>
    /// <remarks>
    /// GPS_STATUS
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.GpsStatus, Name="GPS_STATUS", Description=@"The positioning status, as reported by GPS. This message is intended to display status information about each satellite visible to the receiver. See message GLOBAL_POSITION for the global position estimate. This message can contain information for up to 20 satellites.")]
    public class GpsStatusMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Number of satellites visible
        /// </summary>
        /// <remarks>
        /// satellites_visible
        /// </remarks>
        private byte _satellitesVisible;
        
        /// <summary>
        /// Global satellite ID
        /// </summary>
        /// <remarks>
        /// satellite_prn
        /// </remarks>
        private byte[] _satellitePrn = new byte[20];
        
        /// <summary>
        /// 0: Satellite not used, 1: used for localization
        /// </summary>
        /// <remarks>
        /// satellite_used
        /// </remarks>
        private byte[] _satelliteUsed = new byte[20];
        
        /// <summary>
        /// Elevation (0: right on top of receiver, 90: on the horizon) of satellite
        /// </summary>
        /// <remarks>
        /// satellite_elevation
        /// </remarks>
        private byte[] _satelliteElevation = new byte[20];
        
        /// <summary>
        /// Direction of satellite, 0: 0 deg, 255: 360 deg.
        /// </summary>
        /// <remarks>
        /// satellite_azimuth
        /// </remarks>
        private byte[] _satelliteAzimuth = new byte[20];
        
        /// <summary>
        /// Signal to noise ratio of satellite
        /// </summary>
        /// <remarks>
        /// satellite_snr
        /// </remarks>
        private byte[] _satelliteSnr = new byte[20];
        
        public GpsStatusMessage() : 
                base(MavLink4Net.Messages.MavMessageType.GpsStatus)
        {
        }
        
        /// <summary>
        /// Number of satellites visible
        /// </summary>
        [MessageFieldMetadata(Name="satellites_visible", Type="uint8_t", Description="Number of satellites visible")]
        public byte SatellitesVisible
        {
            get
            {
                return this._satellitesVisible;
            }
            set
            {
                this._satellitesVisible = value;
            }
        }
        
        /// <summary>
        /// Global satellite ID
        /// </summary>
        [MessageFieldMetadata(Name="satellite_prn", Type="uint8_t[20]", Description="Global satellite ID")]
        public byte[] SatellitePrn
        {
            get
            {
                return this._satellitePrn;
            }
            set
            {
                this._satellitePrn = value;
            }
        }
        
        /// <summary>
        /// 0: Satellite not used, 1: used for localization
        /// </summary>
        [MessageFieldMetadata(Name="satellite_used", Type="uint8_t[20]", Description="0: Satellite not used, 1: used for localization")]
        public byte[] SatelliteUsed
        {
            get
            {
                return this._satelliteUsed;
            }
            set
            {
                this._satelliteUsed = value;
            }
        }
        
        /// <summary>
        /// Elevation (0: right on top of receiver, 90: on the horizon) of satellite
        /// </summary>
        [MessageFieldMetadata(Name="satellite_elevation", Type="uint8_t[20]", Units="deg", Description="Elevation (0: right on top of receiver, 90: on the horizon) of satellite")]
        public byte[] SatelliteElevation
        {
            get
            {
                return this._satelliteElevation;
            }
            set
            {
                this._satelliteElevation = value;
            }
        }
        
        /// <summary>
        /// Direction of satellite, 0: 0 deg, 255: 360 deg.
        /// </summary>
        [MessageFieldMetadata(Name="satellite_azimuth", Type="uint8_t[20]", Units="deg", Description="Direction of satellite, 0: 0 deg, 255: 360 deg.")]
        public byte[] SatelliteAzimuth
        {
            get
            {
                return this._satelliteAzimuth;
            }
            set
            {
                this._satelliteAzimuth = value;
            }
        }
        
        /// <summary>
        /// Signal to noise ratio of satellite
        /// </summary>
        [MessageFieldMetadata(Name="satellite_snr", Type="uint8_t[20]", Units="dB", Description="Signal to noise ratio of satellite")]
        public byte[] SatelliteSnr
        {
            get
            {
                return this._satelliteSnr;
            }
            set
            {
                this._satelliteSnr = value;
            }
        }
    }
}
