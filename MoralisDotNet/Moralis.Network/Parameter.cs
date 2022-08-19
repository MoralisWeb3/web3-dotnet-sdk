#nullable enable
using System;

namespace Moralis.Network
{
    /// <summary>
    /// A defined transfer parameter values.
    /// </summary>
    public class Parameter : IEquatable<Parameter>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
        public Parameter(string name, object? value, ParameterType type)
        {
            this.Name = name;
            this.Value = value;
            this.Type = type;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="contentType"></param>
        /// <param name="type"></param>
        public Parameter(string name, object value, string contentType, ParameterType type)
        {
            this.Name = name;
            this.Value = value;
            this.Type = type;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Parameter name.
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Value passed in the parameter.
        /// </summary>
        public object? Value { get; set; }
        /// <summary>
        /// Type represented by the parameter.
        /// </summary>
        public ParameterType Type { get; set; }
        /// <summary>
        /// Dataformat the parameter is passed in.
        /// </summary>
        public DataFormat DataFormat { get; set; }
        /// <summary>
        /// Transfer Content Type of the parameter.
        /// </summary>
        public string? ContentType { get; set; }

        /// <summary>
        /// Provides equality operation against another Parameter.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>bool</returns>
        public bool Equals(Parameter? other)
        {
            var name = this.Name;
            var value = this.Value;
            return value != null && name != null && name.Equals(other?.Name) && value.Equals(other?.Value) && this.Type.Equals(other?.Type);
        }

        /// <summary>
        /// Provides equality operation against another object.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            var name = this.Name;
            var value = this.Value;
            return value != null && name != null && obj is Parameter && name.Equals(((Parameter)obj)?.Name) && value.Equals(((Parameter)obj)?.Value) && this.Type.Equals(((Parameter)obj)?.Type);
        }

        /// <summary>
        /// Overrides the Hash code method.
        /// </summary>
        /// <returns>int</returns>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        /// <summary>
        /// Overrides the ToString function.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"Type: {this.Type}, Name: {this.Name}, Value: {this.Value}, ContentType: {this.ContentType}";
        }
    }

}
