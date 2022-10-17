// See https://aka.ms/new-console-template for more information

using Day5BasicCoreProgram;

BCP1FlipCoin flipcoin = new();
flipcoin.flipCoin(7);

BCP2LeapYear leapyear = new();
leapyear.determineLeapYear(2004);

BCP3Powerof2 power = new();
power.generatePowerOf2(34);

BCP4HarmonicNumber harmonic = new();
harmonic.computeHarmonicNum(34);

BCP5Factor primeFact = new();
primeFact.printPrimeFactor(1729);

Console.WriteLine();

BCP6QR qr = new();
qr.ComputeQuotientRemainder();

BCP7Swap swap = new();
swap.SwapNum();

BCP8EvenOdd evenOdd = new();
evenOdd.findEvenOdd(54);

BCP9VowelConsonant vowCons = new();
vowCons.checkAlpVoCons('A');
vowCons.checkAlpVoCons('Z');

BCP10LargestNumber large = new();
large.findLargestnum(34, 54, 65);