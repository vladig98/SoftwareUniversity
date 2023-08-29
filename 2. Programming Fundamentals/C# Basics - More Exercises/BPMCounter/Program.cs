using System;

namespace BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int bpm = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());
            const int beatsPerBar = 4;

            double bars = beats / (double)beatsPerBar;
            bars = Math.Round(bars, 1);

            int seconds = beats * 60 / bpm;
            int minutes = seconds / 60;
            seconds -= minutes * 60;

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}
