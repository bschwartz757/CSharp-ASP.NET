using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RandomSeed
/// </summary>
public class RandomSeed
{
		
    public int GetSeed()
    {
        Random rand = new Random();
        return rand.Next(1000000, 9999999);
    }
}


