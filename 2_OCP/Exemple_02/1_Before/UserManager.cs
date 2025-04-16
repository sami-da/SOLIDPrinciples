namespace OCP.Exemple_02.Before
{
    public class UserManager
    {
        private readonly UserValidator _validator;
        private readonly UserRepository _repository;
        private readonly EmailService _emailService;

        public UserManager(UserValidator validator, UserRepository repository, EmailService emailService)
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
