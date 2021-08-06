using FluentValidation;
using Store.Domain.Entities;

namespace Store.Domain.Commands
{
    public class ICommand : AbstractValidator<Customer>
    {
        
    }
}
