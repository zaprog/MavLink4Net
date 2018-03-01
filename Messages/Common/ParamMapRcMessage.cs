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
    /// Bind a RC channel to a parameter. The parameter should change accoding to the RC channel value.
    /// </summary>
    /// <remarks>
    /// PARAM_MAP_RC
    /// </remarks>
    [MessageMetadata(Type=MavLink4Net.Messages.MavMessageType.ParamMapRc, Name="PARAM_MAP_RC", Description="Bind a RC channel to a parameter. The parameter should change accoding to the RC " +
        "channel value.")]
    public class ParamMapRcMessage : MavLink4Net.Messages.Message
    {
        
        /// <summary>
        /// System ID
        /// </summary>
        /// <remarks>
        /// target_system
        /// </remarks>
        private byte _targetSystem;
        
        /// <summary>
        /// Component ID
        /// </summary>
        /// <remarks>
        /// target_component
        /// </remarks>
        private byte _targetComponent;
        
        /// <summary>
        /// Onboard parameter id, terminated by NULL if the length is less than 16 human-readable chars and WITHOUT null termination (NULL) byte if the length is exactly 16 chars - applications have to provide 16+1 bytes storage if the ID is stored as string
        /// </summary>
        /// <remarks>
        /// param_id
        /// </remarks>
        private char[] _paramId = new char[16];
        
        /// <summary>
        /// Parameter index. Send -1 to use the param ID field as identifier (else the param id will be ignored), send -2 to disable any existing map for this rc_channel_index.
        /// </summary>
        /// <remarks>
        /// param_index
        /// </remarks>
        private short _paramIndex;
        
        /// <summary>
        /// Index of parameter RC channel. Not equal to the RC channel id. Typically correpsonds to a potentiometer-knob on the RC.
        /// </summary>
        /// <remarks>
        /// parameter_rc_channel_index
        /// </remarks>
        private byte _parameterRcChannelIndex;
        
        /// <summary>
        /// Initial parameter value
        /// </summary>
        /// <remarks>
        /// param_value0
        /// </remarks>
        private float _paramValue0;
        
        /// <summary>
        /// Scale, maps the RC range [-1, 1] to a parameter value
        /// </summary>
        /// <remarks>
        /// scale
        /// </remarks>
        private float _scale;
        
        /// <summary>
        /// Minimum param value. The protocol does not define if this overwrites an onboard minimum value. (Depends on implementation)
        /// </summary>
        /// <remarks>
        /// param_value_min
        /// </remarks>
        private float _paramValueMin;
        
        /// <summary>
        /// Maximum param value. The protocol does not define if this overwrites an onboard maximum value. (Depends on implementation)
        /// </summary>
        /// <remarks>
        /// param_value_max
        /// </remarks>
        private float _paramValueMax;
        
        public ParamMapRcMessage() : 
                base(MavLink4Net.Messages.MavMessageType.ParamMapRc, 78)
        {
        }
        
        /// <summary>
        /// System ID
        /// </summary>
        [MessageFieldMetadata(Name="target_system", Type="uint8_t", Description="System ID")]
        public byte TargetSystem
        {
            get
            {
                return this._targetSystem;
            }
            set
            {
                this._targetSystem = value;
            }
        }
        
        /// <summary>
        /// Component ID
        /// </summary>
        [MessageFieldMetadata(Name="target_component", Type="uint8_t", Description="Component ID")]
        public byte TargetComponent
        {
            get
            {
                return this._targetComponent;
            }
            set
            {
                this._targetComponent = value;
            }
        }
        
        /// <summary>
        /// Onboard parameter id, terminated by NULL if the length is less than 16 human-readable chars and WITHOUT null termination (NULL) byte if the length is exactly 16 chars - applications have to provide 16+1 bytes storage if the ID is stored as string
        /// </summary>
        [MessageFieldMetadata(Name="param_id", Type="char[16]", Description="Onboard parameter id, terminated by NULL if the length is less than 16 human-read" +
            "able chars and WITHOUT null termination (NULL) byte if the length is exactly 16 " +
            "chars - applications have to provide 16+1 bytes storage if the ID is stored as s" +
            "tring")]
        public char[] ParamId
        {
            get
            {
                return this._paramId;
            }
            set
            {
                this._paramId = value;
            }
        }
        
        /// <summary>
        /// Parameter index. Send -1 to use the param ID field as identifier (else the param id will be ignored), send -2 to disable any existing map for this rc_channel_index.
        /// </summary>
        [MessageFieldMetadata(Name="param_index", Type="int16_t", Description="Parameter index. Send -1 to use the param ID field as identifier (else the param " +
            "id will be ignored), send -2 to disable any existing map for this rc_channel_ind" +
            "ex.")]
        public short ParamIndex
        {
            get
            {
                return this._paramIndex;
            }
            set
            {
                this._paramIndex = value;
            }
        }
        
        /// <summary>
        /// Index of parameter RC channel. Not equal to the RC channel id. Typically correpsonds to a potentiometer-knob on the RC.
        /// </summary>
        [MessageFieldMetadata(Name="parameter_rc_channel_index", Type="uint8_t", Description="Index of parameter RC channel. Not equal to the RC channel id. Typically correpso" +
            "nds to a potentiometer-knob on the RC.")]
        public byte ParameterRcChannelIndex
        {
            get
            {
                return this._parameterRcChannelIndex;
            }
            set
            {
                this._parameterRcChannelIndex = value;
            }
        }
        
        /// <summary>
        /// Initial parameter value
        /// </summary>
        [MessageFieldMetadata(Name="param_value0", Type="float", Description="Initial parameter value")]
        public float ParamValue0
        {
            get
            {
                return this._paramValue0;
            }
            set
            {
                this._paramValue0 = value;
            }
        }
        
        /// <summary>
        /// Scale, maps the RC range [-1, 1] to a parameter value
        /// </summary>
        [MessageFieldMetadata(Name="scale", Type="float", Description="Scale, maps the RC range [-1, 1] to a parameter value")]
        public float Scale
        {
            get
            {
                return this._scale;
            }
            set
            {
                this._scale = value;
            }
        }
        
        /// <summary>
        /// Minimum param value. The protocol does not define if this overwrites an onboard minimum value. (Depends on implementation)
        /// </summary>
        [MessageFieldMetadata(Name="param_value_min", Type="float", Description="Minimum param value. The protocol does not define if this overwrites an onboard m" +
            "inimum value. (Depends on implementation)")]
        public float ParamValueMin
        {
            get
            {
                return this._paramValueMin;
            }
            set
            {
                this._paramValueMin = value;
            }
        }
        
        /// <summary>
        /// Maximum param value. The protocol does not define if this overwrites an onboard maximum value. (Depends on implementation)
        /// </summary>
        [MessageFieldMetadata(Name="param_value_max", Type="float", Description="Maximum param value. The protocol does not define if this overwrites an onboard m" +
            "aximum value. (Depends on implementation)")]
        public float ParamValueMax
        {
            get
            {
                return this._paramValueMax;
            }
            set
            {
                this._paramValueMax = value;
            }
        }
    }
}