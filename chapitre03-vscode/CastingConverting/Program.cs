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


