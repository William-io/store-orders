using FluentValidation;

namespace Store.Domain.Commands
{
    public class CreateCustomerCommand : ICommand
    {
        //Faltando implementar no Controller
        public CreateCustomerCommand()
        {
            RuleFor(x => x.Name)
            .NotNull().WithMessage("Name is required")
            .MinimumLength(5).WithMessage("Name must be at least 3 characters long")
            .MaximumLength(50).WithMessage("Name must be at most 50 characters long");

        }
    }

}