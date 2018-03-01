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
    /// Emit an encrypted signature / key identifying this system. PLEASE NOTE: This protocol has been kept simple, so transmitting the key requires an encrypted channel for true safety.
    /// </summary>
    /// <remarks>
    /// AUTH_KEY
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.AuthKey, Name="AUTH_KEY", Description="Emit an encrypted signature / key identifying this system. PLEASE NOTE: This prot" +
        "ocol has been kept simple, so transmitting the key requires an encrypted channel" +
        " for true safety.")]
    public class AuthKeyMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// key
        /// </summary>
        /// <remarks>
        /// key
        /// </remarks>
        private char[] _key = new char[32];
        
        public AuthKeyMessage() : 
                base(MavLink4Net.Messages.MavMessageType.AuthKey, 119)
        {
        }
        
        /// <summary>
        /// key
        /// </summary>
        [MessageFieldMetadata(Name="key", Type="char[32]", Description="key")]
        public char[] Key
        {
            get
            {
                return this._key;
            }
            set
            {
                this._key = value;
            }
        }
    }
}