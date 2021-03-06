//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;


namespace MavLink4Net.Messages.Common
{
    
    
    /// <summary>
    /// Enumeration of landed detector states
    /// </summary>
    /// <remarks>
    /// MAV_LANDED_STATE
    /// </remarks>
    public enum LandedState
    {
        
        /// <summary>
        /// MAV landed state is unknown
        /// </summary>
        /// <remarks>
        /// MAV_LANDED_STATE_UNDEFINED
        /// </remarks>
        [Description("MAV landed state is unknown")]
        Undefined = 0,
        
        /// <summary>
        /// MAV is landed (on ground)
        /// </summary>
        /// <remarks>
        /// MAV_LANDED_STATE_ON_GROUND
        /// </remarks>
        [Description("MAV is landed (on ground)")]
        OnGround = 1,
        
        /// <summary>
        /// MAV is in air
        /// </summary>
        /// <remarks>
        /// MAV_LANDED_STATE_IN_AIR
        /// </remarks>
        [Description("MAV is in air")]
        InAir = 2,
        
        /// <summary>
        /// MAV currently taking off
        /// </summary>
        /// <remarks>
        /// MAV_LANDED_STATE_TAKEOFF
        /// </remarks>
        [Description("MAV currently taking off")]
        Takeoff = 3,
        
        /// <summary>
        /// MAV currently landing
        /// </summary>
        /// <remarks>
        /// MAV_LANDED_STATE_LANDING
        /// </remarks>
        [Description("MAV currently landing")]
        Landing = 4,
    }
}
