﻿namespace SandBox
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("null", -50);

            var result = Validator
                .TryValidateObject(person, new ValidationContext(person), new List<ValidationResult>());
        }
    }
}
