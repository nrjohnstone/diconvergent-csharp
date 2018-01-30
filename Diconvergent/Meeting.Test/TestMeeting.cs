using System;
using Xunit;

namespace Diconvergent.Meeting.Tests
{
    public class TestMeeting
    {
        [Fact]
        public void TestThatValidMeetingsCanBeInstantiated()
        {
            var meeting = new Meeting(
                System.Guid.NewGuid(),
                "(Di|con)vergent mob refactoring",
                "This is a silly workshop, don't come",
                new DateTime(2018, 2, 1, 14, 30, 0),
                new DateTime(2018, 2, 1, 16, 30, 0),
                new Program(new ProgramSlot[] {
                    new ProgramSlot(
                        new DateTime(2018, 2, 1, 14, 30, 0),
                        new DateTime(2018, 2, 1, 15, 30, 0),
                        "Divergence",
                        "Room 5"
                    ),
                    new ProgramSlot(
                        new DateTime(2018, 2, 1, 15, 30, 0),
                        new DateTime(2018, 2, 1, 16, 30, 0),
                        "Divergence",
                        "Room 5"
                    ),
                })
            );
            Assert.IsType<Meeting>(meeting);
        }
    }
}