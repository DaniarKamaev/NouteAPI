using FluentValidation;

namespace NouteAPI.Features.Edit
{
    public class EditNouteValidator : AbstractValidator<EditNoute>
    {
        public EditNouteValidator()
        {
            RuleFor(x => x.id)
                .NotEmpty().WithMessage("Id обязателен")
                .NotEqual(Guid.Empty).WithMessage("Id не может быть пустым GUID");

            RuleFor(x => x.ounerId)
                .NotEmpty().WithMessage("OwnerId обязателен")
                .NotEqual(Guid.Empty).WithMessage("OwnerId не может быть пустым GUID");

            RuleFor(x => x.lable)
                .NotEmpty().WithMessage("Название обязательно")
                .MinimumLength(1).WithMessage("Название должно быть больше 1 символа")
                .MaximumLength(50).WithMessage("Название должно быть меньше 50 символов")
                .Matches("^[a-zA-Zа-яА-Я0-9\\s]+$").WithMessage("Название содержит недопустимые символы");

            RuleFor(x => x.text)
                .NotEmpty().WithMessage("Текст обязателен")
                .MinimumLength(1).WithMessage("Текст должен быть больше 1 символа")
                .MaximumLength(100000).WithMessage("Текст должен быть меньше 100000 символов");
        }
    }
}
