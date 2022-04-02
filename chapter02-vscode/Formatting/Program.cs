
int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

string formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

Console.WriteLine(formatted);

Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:c}");

const string firstname = "Virgo";
const string lastname = "Coachman";
const string fullname = $"{firstname} {lastname}";

Console.WriteLine($"My name is : {fullname}");

