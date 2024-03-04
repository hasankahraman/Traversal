using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("This area can not be empty.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("This area can not be empty.");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("At least 50 characters needed.");
            RuleFor(x => x.Description).MinimumLength(1500).WithMessage("Can not be more than 1500 characters.");
        }
    }
}
