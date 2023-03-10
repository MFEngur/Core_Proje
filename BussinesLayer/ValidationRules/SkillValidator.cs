using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
    public class SkillValidator:AbstractValidator<Skill>
    {
        public SkillValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Yetenek Başlığı Boş geçilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Yetenek Değeri Boş geçilemez");

        }
    }
}
