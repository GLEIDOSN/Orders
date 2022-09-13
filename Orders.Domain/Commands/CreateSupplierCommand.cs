namespace Orders.Domain.Commands
{
    public class CreateSupplierCommand : SupplierCommand
    {
        public CreateSupplierCommand(string socialReason, string cnpj, string state, string email, string contact, string nameContact)
        {
            SocialReason = socialReason;
            CNPJ = cnpj;
            State = state;
            Email = email;
            Contact = contact;
            NameContact = nameContact;
        }
    }
}

