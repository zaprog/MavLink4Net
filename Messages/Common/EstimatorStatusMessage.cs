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
    /// Estimator status message including flags, innovation test ratios and estimated accuracies. The flags message is an integer bitmask containing information on which EKF outputs are valid. See the ESTIMATOR_STATUS_FLAGS enum definition for further information. The innovaton test ratios show the magnitude of the sensor innovation divided by the innovation check threshold. Under normal operation the innovaton test ratios should be below 0.5 with occasional values up to 1.0. Values greater than 1.0 should be rare under normal operation and indicate that a measurement has been rejected by the filter. The user should be notified if an innovation test ratio greater than 1.0 is recorded. Notifications for values in the range between 0.5 and 1.0 should be optional and controllable by the user.
    /// </summary>
    /// <remarks>
    /// ESTIMATOR_STATUS
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.EstimatorStatus, Name="ESTIMATOR_STATUS", Description=@"Estimator status message including flags, innovation test ratios and estimated accuracies. The flags message is an integer bitmask containing information on which EKF outputs are valid. See the ESTIMATOR_STATUS_FLAGS enum definition for further information. The innovaton test ratios show the magnitude of the sensor innovation divided by the innovation check threshold. Under normal operation the innovaton test ratios should be below 0.5 with occasional values up to 1.0. Values greater than 1.0 should be rare under normal operation and indicate that a measurement has been rejected by the filter. The user should be notified if an innovation test ratio greater than 1.0 is recorded. Notifications for values in the range between 0.5 and 1.0 should be optional and controllable by the user.")]
    public class EstimatorStatusMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// Timestamp (micros since boot or Unix epoch)
        /// </summary>
        /// <remarks>
        /// time_usec
        /// </remarks>
        private ulong _timeUsec;
        
        /// <summary>
        /// Integer bitmask indicating which EKF outputs are valid. See definition for ESTIMATOR_STATUS_FLAGS.
        /// </summary>
        /// <remarks>
        /// flags
        /// </remarks>
        private MavLink4Net.Messages.Common.EstimatorStatusFlags _flags;
        
        /// <summary>
        /// Velocity innovation test ratio
        /// </summary>
        /// <remarks>
        /// vel_ratio
        /// </remarks>
        private float _velRatio;
        
        /// <summary>
        /// Horizontal position innovation test ratio
        /// </summary>
        /// <remarks>
        /// pos_horiz_ratio
        /// </remarks>
        private float _posHorizRatio;
        
        /// <summary>
        /// Vertical position innovation test ratio
        /// </summary>
        /// <remarks>
        /// pos_vert_ratio
        /// </remarks>
        private float _posVertRatio;
        
        /// <summary>
        /// Magnetometer innovation test ratio
        /// </summary>
        /// <remarks>
        /// mag_ratio
        /// </remarks>
        private float _magRatio;
        
        /// <summary>
        /// Height above terrain innovation test ratio
        /// </summary>
        /// <remarks>
        /// hagl_ratio
        /// </remarks>
        private float _haglRatio;
        
        /// <summary>
        /// True airspeed innovation test ratio
        /// </summary>
        /// <remarks>
        /// tas_ratio
        /// </remarks>
        private float _tasRatio;
        
        /// <summary>
        /// Horizontal position 1-STD accuracy relative to the EKF local origin (m)
        /// </summary>
        /// <remarks>
        /// pos_horiz_accuracy
        /// </remarks>
        private float _posHorizAccuracy;
        
        /// <summary>
        /// Vertical position 1-STD accuracy relative to the EKF local origin (m)
        /// </summary>
        /// <remarks>
        /// pos_vert_accuracy
        /// </remarks>
        private float _posVertAccuracy;
        
        public EstimatorStatusMessage() : 
                base(MavLink4Net.Messages.MavMessageType.EstimatorStatus)
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
        /// Integer bitmask indicating which EKF outputs are valid. See definition for ESTIMATOR_STATUS_FLAGS.
        /// </summary>
        [MessageFieldMetadata(Name="flags", Type="ESTIMATOR_STATUS_FLAGS enum", Display="bitmask", Description="Integer bitmask indicating which EKF outputs are valid. See definition for ESTIMA" +
            "TOR_STATUS_FLAGS.")]
        public MavLink4Net.Messages.Common.EstimatorStatusFlags Flags
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
        
        /// <summary>
        /// Velocity innovation test ratio
        /// </summary>
        [MessageFieldMetadata(Name="vel_ratio", Type="float", Description="Velocity innovation test ratio")]
        public float VelRatio
        {
            get
            {
                return this._velRatio;
            }
            set
            {
                this._velRatio = value;
            }
        }
        
        /// <summary>
        /// Horizontal position innovation test ratio
        /// </summary>
        [MessageFieldMetadata(Name="pos_horiz_ratio", Type="float", Description="Horizontal position innovation test ratio")]
        public float PosHorizRatio
        {
            get
            {
                return this._posHorizRatio;
            }
            set
            {
                this._posHorizRatio = value;
            }
        }
        
        /// <summary>
        /// Vertical position innovation test ratio
        /// </summary>
        [MessageFieldMetadata(Name="pos_vert_ratio", Type="float", Description="Vertical position innovation test ratio")]
        public float PosVertRatio
        {
            get
            {
                return this._posVertRatio;
            }
            set
            {
                this._posVertRatio = value;
            }
        }
        
        /// <summary>
        /// Magnetometer innovation test ratio
        /// </summary>
        [MessageFieldMetadata(Name="mag_ratio", Type="float", Description="Magnetometer innovation test ratio")]
        public float MagRatio
        {
            get
            {
                return this._magRatio;
            }
            set
            {
                this._magRatio = value;
            }
        }
        
        /// <summary>
        /// Height above terrain innovation test ratio
        /// </summary>
        [MessageFieldMetadata(Name="hagl_ratio", Type="float", Description="Height above terrain innovation test ratio")]
        public float HaglRatio
        {
            get
            {
                return this._haglRatio;
            }
            set
            {
                this._haglRatio = value;
            }
        }
        
        /// <summary>
        /// True airspeed innovation test ratio
        /// </summary>
        [MessageFieldMetadata(Name="tas_ratio", Type="float", Description="True airspeed innovation test ratio")]
        public float TasRatio
        {
            get
            {
                return this._tasRatio;
            }
            set
            {
                this._tasRatio = value;
            }
        }
        
        /// <summary>
        /// Horizontal position 1-STD accuracy relative to the EKF local origin (m)
        /// </summary>
        [MessageFieldMetadata(Name="pos_horiz_accuracy", Type="float", Units="m", Description="Horizontal position 1-STD accuracy relative to the EKF local origin (m)")]
        public float PosHorizAccuracy
        {
            get
            {
                return this._posHorizAccuracy;
            }
            set
            {
                this._posHorizAccuracy = value;
            }
        }
        
        /// <summary>
        /// Vertical position 1-STD accuracy relative to the EKF local origin (m)
        /// </summary>
        [MessageFieldMetadata(Name="pos_vert_accuracy", Type="float", Units="m", Description="Vertical position 1-STD accuracy relative to the EKF local origin (m)")]
        public float PosVertAccuracy
        {
            get
            {
                return this._posVertAccuracy;
            }
            set
            {
                this._posVertAccuracy = value;
            }
        }
    }
}
