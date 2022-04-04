using static System.Console;
using static System.Convert;

double g = 9.8;
int h = ToInt32(g);
int i = (int)g;
WriteLine($"g is {g}, h is {h} and i is {i}");

// allocate array of 128 bytes
byte[] binaryObject = new byte[128];

// populate array with random bytes
(new Random()).NextBytes(binaryObject);

WriteLine("Binary object as bytes: ");

for (int index = 0; index < binaryObject.Length; index++)
{
    Write($" {binaryObject[index]:X}");
}
WriteLine();

// convert to Base64 string and output as text
string encoded = ToBase64String(binaryObject);

WriteLine($"Binary Object as Base64: {encoded}");

int age = int.Parse("27");
DateTime dateTime = DateTime.MaxValue;
DateTime birthday = DateTime.Parse("23 Janvier 1991");

WriteLine($"I was born {age} years ago.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}");
WriteLine($"The endTime is {dateTime}.");


