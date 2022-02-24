
using MVC_Lab;

bool runProgram = true;
CountryController cc = new CountryController();

while (runProgram)
{
    cc.WelcomeAction();
    cc.ChooseCountry();
    runProgram = Validator.Validator.GetContinue("Would you like to choose another country? [y] or [n]");
}