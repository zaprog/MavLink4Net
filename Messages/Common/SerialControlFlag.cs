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
    /// SERIAL_CONTROL flags (bitmask)
    /// </summary>
    /// <remarks>
    /// SERIAL_CONTROL_FLAG
    /// </remarks>
    public enum SerialControlFlag
    {
        
        /// <summary>
        /// Set if this is a reply
        /// </summary>
        /// <remarks>
        /// SERIAL_CONTROL_FLAG_REPLY
        /// </remarks>
        [Description("Set if this is a reply")]
        Reply = 1,
        
        /// <summary>
        /// Set if the sender wants the receiver to send a response as another SERIAL_CONTROL message
        /// </summary>
        /// <remarks>
        /// SERIAL_CONTROL_FLAG_RESPOND
        /// </remarks>
        [Description("Set if the sender wants the receiver to send a response as another SERIAL_CONTROL" +
            " message")]
        Respond = 2,
        
        /// <summary>
        /// Set if access to the serial port should be removed from whatever driver is currently using it, giving exclusive access to the SERIAL_CONTROL protocol. The port can be handed back by sending a request without this flag set
        /// </summary>
        /// <remarks>
        /// SERIAL_CONTROL_FLAG_EXCLUSIVE
        /// </remarks>
        [Description("Set if access to the serial port should be removed from whatever driver is curren" +
            "tly using it, giving exclusive access to the SERIAL_CONTROL protocol. The port c" +
            "an be handed back by sending a request without this flag set")]
        Exclusive = 4,
        
        /// <summary>
        /// Block on writes to the serial port
        /// </summary>
        /// <remarks>
        /// SERIAL_CONTROL_FLAG_BLOCKING
        /// </remarks>
        [Description("Block on writes to the serial port")]
        Blocking = 8,
        
        /// <summary>
        /// Send multiple replies until port is drained
        /// </summary>
        /// <remarks>
        /// SERIAL_CONTROL_FLAG_MULTI
        /// </remarks>
        [Description("Send multiple replies until port is drained")]
        Multi = 16,
    }
}