// See https://aka.ms/new-console-template for more information

using System.Reflection.PortableExecutable;
using System.Threading;

var rand = new Random();

int[] flips = new int[8];
int numhead = 0;
int numtail = 0;

for (int i = 0 ; i < flips.Length;++i) {

    flips[i] = rand.Next(2);

    if (flips[i] == 0)
    {
        numtail++;
        Console.WriteLine("Flip " + i + ": t");
    }
    else {
        numhead++;
        Console.WriteLine("Flip " + i + ": h");
    }
}

Console.WriteLine("Number of heads: " + numhead);
Console.WriteLine("Number of tails: " + numtail);

double phead = Math.Round(numhead / 8.0 * 100, 2);
double ptail = Math.Round(numtail / 8.0 * 100, 2);

Console.WriteLine("Percent heads: " + phead);
Console.WriteLine("Percent tails: " + ptail);