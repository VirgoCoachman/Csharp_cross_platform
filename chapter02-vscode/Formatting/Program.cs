using static System.Console;

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

string formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

WriteLine(formatted);

WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:c}");

const string firstname = "Virgo";
const string lastname = "Coachman";
const string fullname = $"{firstname} {lastname}";

WriteLine($"My name is : {fullname}");

string applesText = "Apples";
int applesCount = 1234;

string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine("{0, -10} {1, 6 :N0}", "Name", "Count");
WriteLine("{0, -10} {1, 6 :N0}", applesText, applesCount);
WriteLine("{0, -10} {1, 6 :N0}", bananasText, bananasCount);


