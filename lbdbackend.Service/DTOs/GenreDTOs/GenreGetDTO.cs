﻿using FluentValidation;

namespace lbdbackend.Service.DTOs.GenreDTOs {
    public class GenreGetDTO {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class GenreGetValidator : AbstractValidator<GenreGetDTO> {
        public GenreGetValidator() {
            RuleFor(r => r.Name)
                .MaximumLength(25).WithMessage("Maximum length is 25 symbols.")
                .NotEmpty().WithMessage("Cannot be empty.");
        }
    }
}