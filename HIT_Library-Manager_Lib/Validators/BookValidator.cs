using FluentValidation;
using HIT_Library_Manager_Lib.Models;
using System;
using System.Globalization;
using System.Linq;

namespace HIT_Library_Manager_Lib.Validators
{
    public class BookValidator : AbstractValidator<BookModel>
    {

        public BookValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;

            // Validate the Username property.
            RuleFor(b => b.Title)
                .Cascade(CascadeMode.Stop) // Set the cascade mode for this rule to Stop.
                .NotEmpty().WithMessage("{PropertyName} is empty!") // Ensure the property is not empty.
                .Length(2, 50).WithMessage("{PropertyName} length is invalid!") // Ensure the length is between 2 and 50 characters.
                .Must(BeAValidString).WithMessage("{PropertyName} contains invalid characters!"); // Ensure the property contains only valid characters.

            RuleFor(b => b.Author)
                .Cascade(CascadeMode.Stop) // Set the cascade mode for this rule to Stop.
                .NotEmpty().WithMessage("{PropertyName} is empty!") // Ensure the property is not empty.
                .Length(2, 50).WithMessage("{PropertyName} length is invalid!") // Ensure the length is between 2 and 50 characters.
                .Must(BeAValidString).WithMessage("{PropertyName} contains invalid characters!");

            RuleFor(b => b.Publisher)
                .Cascade(CascadeMode.Stop) // Set the cascade mode for this rule to Stop.
                .NotEmpty().WithMessage("{PropertyName} is empty!") // Ensure the property is not empty.
                .Length(2, 50).WithMessage("{PropertyName} length is invalid!") // Ensure the length is between 2 and 50 characters.
                .Must(BeAValidString).WithMessage("{PropertyName} contains invalid characters!");

            RuleFor(b => b.PublicationYear)
                .Cascade(CascadeMode.Stop) // Set the cascade mode for this rule to Stop.
                .NotEmpty().WithMessage("{PropertyName} is empty!") // Ensure the property is not empty.
                .Length(0, 4).WithMessage("{PropertyName} length is invalid!") // Ensure the length is between 2 and 50 characters.
                .Must(BeAValidYear).WithMessage("{PropertyName} invalid year!");//Esure the property is a valid year


            RuleFor(b => b.Genre)
               .Cascade(CascadeMode.Stop) // Set the cascade mode for this rule to Stop.
               .NotEmpty().WithMessage("{PropertyName} is empty!") // Ensure the property is not empty.
               .Length(2, 50).WithMessage("{PropertyName} length is invalid!") // Ensure the length is between 2 and 50 characters.
               .Must(BeAValidString).WithMessage("{PropertyName} contains invalid characters!");

            RuleFor(b => b.ISBN)
                  .Cascade(CascadeMode.Stop) // Set the cascade mode for this rule to Stop.
                  .NotEmpty().WithMessage("{PropertyName} is empty!")// Ensure the length is between 2 and 50 characters.; // Ensure the property is not empty.
                  .Length(16, 16).WithMessage("{PropertyName} length is invalid!(16 characters)");// Ensure the length is 16 characters

        }
        protected bool BeAValidString(string inputstring)
        {
            inputstring = inputstring.Replace(" ", ""); // Remove spaces from the string.
            inputstring = inputstring.Replace("-", ""); // Remove dashes from the string.
            return inputstring.All(char.IsLetter); // Return true if the string contains only letters, false otherwise.
        }

        protected bool BeAValidYear(string year)
        {

            bool isValidYear = DateTime.TryParseExact(year, "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result);

            if (isValidYear)
            {
                return true;
            }
            return false;
        }

        protected bool BeAValidISBN(int isbn)
        {

            return true;
            //ToDo validate isbn
        }
    }
}
