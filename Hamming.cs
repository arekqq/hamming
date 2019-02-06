using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        Validation(firstStrand, secondStrand);

        int Difference = 0;

        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (firstStrand[i] != secondStrand[i])
                Difference++;
        }
            return Difference;
    }

    private static void Validation(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
            throw new ArgumentException("Different length of Strands");
    }
}