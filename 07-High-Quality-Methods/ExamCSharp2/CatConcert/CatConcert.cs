/* Not fully implemented!!! */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CatConcert
{
    static void Main()
    {
        const int catNumberPosition = 1;
        const int songNumberPosition = 4;

        string catsString = Console.ReadLine();
        string[] catWords = catsString.Split(' ');
        int cats = int.Parse(catWords[0]);

        string songsString = Console.ReadLine();
        string[] songWords = songsString.Split(' ');
        int songs = int.Parse(songWords[0]);

        bool[,] concertMatrix = new bool[cats, songs];

        for (int cat = 0; cat < cats; cat++)
            for (int song = 0; song < songs; song++)
            {
                concertMatrix[cat, song] = false;
            }

        string line = Console.ReadLine();

        while (line != "Mew!")
        {
            string[] words = line.Split(' ');
            int cat = int.Parse(words[catNumberPosition]);
            int song = int.Parse(words[songNumberPosition]);
            concertMatrix[cat - 1, song - 1] = true;
            line = Console.ReadLine();
        }

        CatSongsCount(concertMatrix);
    }

    static void CatSongsCount(bool[,] concertMatrix)
    {
        int cats = concertMatrix.GetLength(0);
        int songs = concertMatrix.GetLength(1);

        int songsCount;
        bool gotConcert;

        for (int cat = 0; cat < cats; cat++)
        {
            gotConcert = false;
            int song;
            for (song = 0; song < songs; song++)
            {
                if (concertMatrix[cat, song] == true)
                {
                    gotConcert = true;
                    break;
                }
            }

            if (!gotConcert)
            {
                songsCount = 0;
                Console.WriteLine("No concert!");
                return;
            }
        }

        bool allCatsHaveOneSong;
 
        for (int j = 0; j < songs; j++)
        {
            allCatsHaveOneSong = true;
            int i;
            for (i = 0; i < cats; i++)
            {
                if (concertMatrix[i, j] == false)
                {
                    allCatsHaveOneSong = false;
                    break;
                } 
            }

            if (allCatsHaveOneSong)
            {
                songsCount = 1;
                Console.WriteLine(songsCount);
                return;
            }

        }

        songsCount = Math.Min(cats, songs);
        bool[] catHasSong = new bool[cats];

        for (int song = 0; song < songs; song++)
        {
            int tempCount = 0;
            for (int cat = 0; cat < cats; cat++)
            {

                if (concertMatrix[cat, song] == true && !catHasSong[cat])
                {
                    tempCount++;
                    catHasSong[cat] = true;
                }

            }

            if (tempCount > 1)
                songsCount = songsCount - tempCount;
            if (songsCount <= 1)
                break;
            tempCount = 0;
        }

        if (songsCount > 0)
            Console.WriteLine(songsCount);
    }
}

