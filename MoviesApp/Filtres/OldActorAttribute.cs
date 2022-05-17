using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace MoviesApp.Filtres
{
    public class OldActorAttribute:ValidationAttribute
    {
        public int Year { get; }
        public OldActorAttribute(int year)
        {
            Year = year;
        }

        public string GetErrorMessage() => $"The actor's year of birth must be at least than {Year}.";
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var yearBirth = ((DateTime) value).Year;
            if (yearBirth < Year)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }
    }
}