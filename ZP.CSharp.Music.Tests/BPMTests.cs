using System;
using Xunit;
using ZP.CSharp.Music;
using ZP.CSharp.Music.Tests.BPMTests;
namespace ZP.CSharp.Music.Tests.BPMTests
{
    public class Assignments
    {
        [Theory]
        [InlineData(123, Duration.Crotchet, 123)]
        [InlineData(456, Duration.Minim, 912)]
        [InlineData(7890, Duration.Minim | Duration.Crotchet, 23670)]
        public void BPMValueScalesWithNoteValue(double suppliedBPM, Duration duration, double scaledBPM)
        {
            var bpm = new BPM(suppliedBPM);
            Assert.Equal(scaledBPM, bpm.Value);
        }
    }
}