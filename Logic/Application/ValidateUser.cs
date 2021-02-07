using BusinessObjects.User;
using Logic.Validations;

namespace Logic.Application
{
    public static class ValidateUser
    {
        public static bool Validate(IUser user)
        {
            bool usernameValidator = NewUserValidations.Username(user.Username);
            bool passwordValidator = NewUserValidations.Password(user.Password);

            if (usernameValidator == false)
            {
                StandardMessages.InvalidUsernameMessage(user.Username);
                return false;
            }
            else if (passwordValidator == false)
            {
                StandardMessages.InvalidPasswordMessage(user.Password);
                return false;
            }

            return true;
        }
    }
}