using static System.Console;

WriteLine("----------------------------------------------------------------------------------------");
WriteLine($"{"Type", -8} {"Byte(s) of memory", 0} {"Min", 30 :N0} {"Max", 30 :N0}");
WriteLine("----------------------------------------------------------------------------------------");
WriteLine($"{"sbyte", -8} {sizeof(sbyte), 0} {sbyte.MinValue, 46 :N0} {sbyte.MaxValue, 30 :N0}");
WriteLine($"{"byte", -8} {sizeof(byte), 0} {byte.MinValue, 46 :N0} {byte.MaxValue, 30 :N0}");
WriteLine($"{"short", -8} {sizeof(short), 0} {short.MinValue, 46 :N0} {short.MaxValue, 30 :N0}");
WriteLine($"{"ushort", -8} {sizeof(ushort), 0} {ushort.MinValue, 46 :N0} {ushort.MaxValue, 30 :N0}");
WriteLine($"{"int", -8} {sizeof(int), 0} {int.MinValue, 46 :N0} {int.MaxValue, 30 :N0}");
WriteLine($"{"uint", -8} {sizeof(uint), 0} {uint.MinValue, 46 :N0} {uint.MaxValue, 30 :N0}");
WriteLine($"{"long", -8} {sizeof(long), 0} {long.MinValue, 46 :N0} {long.MaxValue, 30 :N0}");
WriteLine($"{"ulong", -8} {sizeof(ulong), 0} {ulong.MinValue, 46 :N0} {ulong.MaxValue, 30 :N0}");
WriteLine($"{"float", -8} {sizeof(float), 0} {float.MinValue, 46} {float.MaxValue, 30}");
WriteLine($"{"double", -8} {sizeof(double), 0} {double.MinValue, 46} {double.MaxValue, 30}");
WriteLine($"{"decimal", -8} {sizeof(decimal), 0} {decimal.MinValue, 45} {decimal.MaxValue, 30}");
WriteLine("----------------------------------------------------------------------------------------");
