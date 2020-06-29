﻿using Arts.Application.DataTransfer;
using Arts.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arts.Implementation.Validators
{
    public class LikeValidator: AbstractValidator<LikeDto>
    {
        public LikeValidator()
        {
            RuleFor(x => x.PieceOfArtId).NotEmpty();

            RuleFor(x => x.UserId).NotEmpty();

            RuleFor(x => x.Status)
                .NotEmpty()
                .Must(y => Enum.IsDefined(typeof(LikeStatus), y))
                .WithMessage("Status can only be like or dislike");
        }
    }
}
