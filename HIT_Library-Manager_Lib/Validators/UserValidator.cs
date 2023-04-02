using FluentValidation;
using HIT_Library_Manager_Lib.Models;
using System.Linq;

namespace HIT_Library_Manager_Lib.Validators
{

    /// <summary>
    /// Validator for the UserModel class.
    /// </summary>
    public class UserValidator : AbstractValidator<UserModel>
    {
        /// <summary>
        /// Initializes a new instance of the UserValidator class.
        /// </summary>
        public UserValidator()
        {
            // Set the class-level cascade mode to Stop to stop validation on the first failure.
            ClassLevelCascadeMode = CascadeMode.Stop;

            // Validate the Username property.
            RuleFor(u => u.Username)
                .Cascade(CascadeMode.Stop) // Set the cascade mode for this rule to Stop.
                .NotEmpty().WithMessage("{PropertyName} is empty!") // Ensure the property is not empty.
                .Length(2, 50).WithMessage("{PropertyName} length is invalid!") // Ensure the length is between 2 and 50 characters.
                .Must(BeAValidName).WithMessage("{PropertyName} contains invalid characters!"); // Ensure the property contains only valid characters.

            // Validate the Password property.
            RuleFor(u => u.Password)
                .Cascade(CascadeMode.Stop) // Set the cascade mode for this rule to Stop.
                .NotEmpty().WithMessage("{PropertyName} is empty!") // Ensure the property is not empty.
                .Length(2, 50).WithMessage("{PropertyName} length is invalid!"); // Ensure the length is between 2 and 50 characters.
        }

        /// <summary>
        /// Validates that the username contains only letters, spaces, and dashes.
        /// </summary>
        /// <param name="username">The username to validate.</param>
        /// <returns>True if the username is valid, false otherwise.</returns>
        protected bool BeAValidName(string username)
        {
            username = username.Replace(" ", ""); // Remove spaces from the string.
            username = username.Replace("-", ""); // Remove dashes from the string.
            return username.All(char.IsLetter); // Return true if the string contains only letters, false otherwise.
        }
    }

}
