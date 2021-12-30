using System;
namespace Ohtic.Challenge.Console.StarkAnalyzer
{
    public class AnalyzerResponse
    {
        public AnalyzerResponse()
        {
        }

        public int XParticles { get; set; }
        public int YParticles { get; set; }
        public int ZParticles { get; set; }
        public int RExclusions { get; set; }
    }
}
