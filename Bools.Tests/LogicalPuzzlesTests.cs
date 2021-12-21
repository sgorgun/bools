namespace Bools.Tests
{
    [TestFixture]
    public class LogicalPuzzlesTests
    {
        [TestCase(false, false, ExpectedResult = true)]
        [TestCase(true, false, ExpectedResult = false)]
        [TestCase(false, true, ExpectedResult = true)]
        [TestCase(true, true, ExpectedResult = true)]
        public bool Puzzle1_ReturnBool(bool b1, bool b2)
        {
            return LogicalPuzzles.Puzzle1(b1, b2);
        }

        [TestCase(false, false, ExpectedResult = false)]
        [TestCase(true, false, ExpectedResult = false)]
        [TestCase(false, true, ExpectedResult = true)]
        [TestCase(true, true, ExpectedResult = false)]
        public bool Puzzle2_ReturnBool(bool b1, bool b2)
        {
            return LogicalPuzzles.Puzzle2(b1, b2);
        }

        [TestCase(false, false, ExpectedResult = true)]
        [TestCase(true, false, ExpectedResult = true)]
        [TestCase(false, true, ExpectedResult = false)]
        [TestCase(true, true, ExpectedResult = true)]
        public bool Puzzle3_ReturnBool(bool b1, bool b2)
        {
            return LogicalPuzzles.Puzzle3(b1, b2);
        }

        [TestCase(false, false, ExpectedResult = false)]
        [TestCase(true, false, ExpectedResult = true)]
        [TestCase(false, true, ExpectedResult = false)]
        [TestCase(true, true, ExpectedResult = false)]
        public bool Puzzle4_ReturnBool(bool b1, bool b2)
        {
            return LogicalPuzzles.Puzzle4(b1, b2);
        }

        [TestCase(false, false, ExpectedResult = true)]
        [TestCase(true, false, ExpectedResult = false)]
        [TestCase(false, true, ExpectedResult = false)]
        [TestCase(true, true, ExpectedResult = false)]
        public bool Puzzle5_ReturnBool(bool b1, bool b2)
        {
            return LogicalPuzzles.Puzzle5(b1, b2);
        }

        [TestCase(false, false, ExpectedResult = true)]
        [TestCase(true, false, ExpectedResult = true)]
        [TestCase(false, true, ExpectedResult = true)]
        [TestCase(true, true, ExpectedResult = false)]
        public bool Puzzle6_ReturnBool(bool b1, bool b2)
        {
            return LogicalPuzzles.Puzzle6(b1, b2);
        }

        [TestCase(false, false, ExpectedResult = true)]
        [TestCase(true, false, ExpectedResult = false)]
        [TestCase(false, true, ExpectedResult = false)]
        [TestCase(true, true, ExpectedResult = true)]
        public bool Puzzle7_ReturnBool(bool b1, bool b2)
        {
            return LogicalPuzzles.Puzzle7(b1, b2);
        }

        //[TestCase(false, false, false, ExpectedResult = false)]
        //[TestCase(true, false, false, ExpectedResult = false)]
        //[TestCase(false, true, false, ExpectedResult = true)]
        //[TestCase(false, false, true, ExpectedResult = false)]
        //[TestCase(true, true, false, ExpectedResult = false)]
        //[TestCase(true, false, true, ExpectedResult = true)]
        //[TestCase(false, true, true, ExpectedResult = false)]
        //[TestCase(true, true, true, ExpectedResult = false)]
        //public bool Puzzle8_ReturnBool(bool b1, bool b2, bool b3)
        //{
        //    return LogicTasks.Task8(b1, b2, b3);
        //}

        //[TestCase(false, false, false, ExpectedResult = false)]
        //[TestCase(true, false, false, ExpectedResult = false)]
        //[TestCase(false, true, false, ExpectedResult = true)]
        //[TestCase(false, false, true, ExpectedResult = false)]
        //[TestCase(true, true, false, ExpectedResult = false)]
        //[TestCase(true, false, true, ExpectedResult = true)]
        //[TestCase(false, true, true, ExpectedResult = false)]
        //[TestCase(true, true, true, ExpectedResult = false)]
        //public bool Puzzle9_ReturnBool(bool b1, bool b2)
        //{
        //    return LogicTasks.Task9(b1, b2);
        //}
    }
}
