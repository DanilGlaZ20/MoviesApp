using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Filtres
{
    public class LittleSurnameActorAttribute:ValidationAttribute
    {
        public int Length { get; }
            public LittleSurnameActorAttribute(int number)
            {
                Length = number;
            }
            public string GetErrorMessage() => $"The actor's surname  must be at least than {Length}.";
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                var numberName =(value as String).Length;
                if ( numberName< Length) return new ValidationResult(GetErrorMessage());
                return ValidationResult.Success;
            }

            
        }
    }
    
