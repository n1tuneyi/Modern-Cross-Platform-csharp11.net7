int age = 50;

WriteLine($"The {nameof(age)} variable uses {sizeof(int)} bytes of memory.");


String password = "ninja";


if(password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 characters.");
}
else
{
    WriteLine("Your password is strong.");
}