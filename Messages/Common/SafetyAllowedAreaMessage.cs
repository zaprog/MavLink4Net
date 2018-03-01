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
    /// Read out the safety zone the MAV currently assumes.
    /// </summary>
    /// <remarks>
    /// SAFETY_ALLOWED_AREA
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.SafetyAllowedArea, Name="SAFETY_ALLOWED_AREA", Description="Read out the safety zone the MAV currently assumes.")]
    public class SafetyAllowedAreaMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Coordinate frame, as defined by MAV_FRAME enum in mavlink_types.h. Can be either global, GPS, right-handed with Z axis up or local, right handed, Z axis down.
        /// </summary>
        /// <remarks>
        /// frame
        /// </remarks>
        private Frame _frame;
        
        /// <summary>
        /// x position 1 / Latitude 1
        /// </summary>
        /// <remarks>
        /// p1x
        /// </remarks>
        private float _p1x;
        
        /// <summary>
        /// y position 1 / Longitude 1
        /// </summary>
        /// <remarks>
        /// p1y
        /// </remarks>
        private float _p1y;
        
        /// <summary>
        /// z position 1 / Altitude 1
        /// </summary>
        /// <remarks>
        /// p1z
        /// </remarks>
        private float _p1z;
        
        /// <summary>
        /// x position 2 / Latitude 2
        /// </summary>
        /// <remarks>
        /// p2x
        /// </remarks>
        private float _p2x;
        
        /// <summary>
        /// y position 2 / Longitude 2
        /// </summary>
        /// <remarks>
        /// p2y
        /// </remarks>
        private float _p2y;
        
        /// <summary>
        /// z position 2 / Altitude 2
        /// </summary>
        /// <remarks>
        /// p2z
        /// </remarks>
        private float _p2z;
        
        public SafetyAllowedAreaMessage() : 
                base(MavLink4Net.Messages.MavMessageType.SafetyAllowedArea, 3)
        {
        }
        
        /// <summary>
        /// Coordinate frame, as defined by MAV_FRAME enum in mavlink_types.h. Can be either global, GPS, right-handed with Z axis up or local, right handed, Z axis down.
        /// </summary>
        [MessageFieldMetadata(Name="frame", Type="MAV_FRAME enum", Description="Coordinate frame, as defined by MAV_FRAME enum in mavlink_types.h. Can be either " +
            "global, GPS, right-handed with Z axis up or local, right handed, Z axis down.")]
        public Frame Frame
        {
            get
            {
                return this._frame;
            }
            set
            {
                this._frame = value;
            }
        }
        
        /// <summary>
        /// x position 1 / Latitude 1
        /// </summary>
        [MessageFieldMetadata(Name="p1x", Type="float", Units="m", Description="x position 1 / Latitude 1")]
        public float P1x
        {
            get
            {
                return this._p1x;
            }
            set
            {
                this._p1x = value;
            }
        }
        
        /// <summary>
        /// y position 1 / Longitude 1
        /// </summary>
        [MessageFieldMetadata(Name="p1y", Type="float", Units="m", Description="y position 1 / Longitude 1")]
        public float P1y
        {
            get
            {
                return this._p1y;
            }
            set
            {
                this._p1y = value;
            }
        }
        
        /// <summary>
        /// z position 1 / Altitude 1
        /// </summary>
        [MessageFieldMetadata(Name="p1z", Type="float", Units="m", Description="z position 1 / Altitude 1")]
        public float P1z
        {
            get
            {
                return this._p1z;
            }
            set
            {
                this._p1z = value;
            }
        }
        
        /// <summary>
        /// x position 2 / Latitude 2
        /// </summary>
        [MessageFieldMetadata(Name="p2x", Type="float", Units="m", Description="x position 2 / Latitude 2")]
        public float P2x
        {
            get
            {
                return this._p2x;
            }
            set
            {
                this._p2x = value;
            }
        }
        
        /// <summary>
        /// y position 2 / Longitude 2
        /// </summary>
        [MessageFieldMetadata(Name="p2y", Type="float", Units="m", Description="y position 2 / Longitude 2")]
        public float P2y
        {
            get
            {
                return this._p2y;
            }
            set
            {
                this._p2y = value;
            }
        }
        
        /// <summary>
        /// z position 2 / Altitude 2
        /// </summary>
        [MessageFieldMetadata(Name="p2z", Type="float", Units="m", Description="z position 2 / Altitude 2")]
        public float P2z
        {
            get
            {
                return this._p2z;
            }
            set
            {
                this._p2z = value;
            }
        }
    }
}