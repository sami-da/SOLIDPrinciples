namespace OCP.Exemple_02.After
{
    public class UserManager
    {
        private readonly IUserValidator _validator;
        private readonly IUserRepository _repository;
        private readonly IEmailService _emailService;

        public UserManager(IUserValidator validator, IUserRepository repository, IEmailService emailService)
        {
            _validator = validator;
            _repository = repository;
            _emailService = emailService;
        }

        public void RegisterUser(User user)
        {
            _validator.Validate(user);
            _repository.Save(user);
            _emailService.SendWelcomeEmail(user.Email);
        }
    }
}
