using System;
using System.ComponentModel.DataAnnotations;


namespace MoviesApp.Filtres
{
    public class NumberActorAttribute:ValidationAttribute
    {
        public int Length { get; }
        public NumberActorAttribute(int number)
        {
            Length = number;
        }
        public string GetErrorMessage() => $"The actor's name  must be at least than {Length}.";
        protected override  ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var numberName =(value as String).Length;
            if ( numberName< Length) return new ValidationResult(GetErrorMessage());
            return ValidationResult.Success;
        }

            
        }
    }

    
