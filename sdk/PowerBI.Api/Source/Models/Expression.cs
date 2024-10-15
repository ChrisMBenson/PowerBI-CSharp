// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A dataset expression
    /// </summary>
    public partial class Expression
    {
        /// <summary>
        /// Initializes a new instance of the Expression class.
        /// </summary>
        public Expression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Expression class.
        /// </summary>
        /// <param name="expressionProperty">The expression value</param>
        /// <param name="name">The expression name</param>
        /// <param name="description">The expression description</param>
        public Expression(string expressionProperty, string name = default(string), string description = default(string))
        {
            ExpressionProperty = expressionProperty;
            Name = name;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the expression value
        /// </summary>
        [JsonProperty(PropertyName = "expression")]
        public string ExpressionProperty { get; set; }

        /// <summary>
        /// Gets or sets the expression name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the expression description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ExpressionProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ExpressionProperty");
            }
        }
    }
}