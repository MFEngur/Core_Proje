using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
    public class PorfolioValidator:AbstractValidator<Portfolio>
    {
        public PorfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje İSmi Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Proje görseli boş geçilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Proje görseli boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Proje Fiyatı boş geçilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Proje Değeri boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje İsmi 5 karekterden az olamaz");
            RuleFor(x => x.Name).MaximumLength(25).WithMessage("Proje İsmi 25 karekterden fazla olamaz");


        }
    }
}
