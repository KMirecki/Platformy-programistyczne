using Problem;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("TestProject")]
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCountElements()
        {
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int n in sizes)
            {
                Plecak problem = new Plecak(n, 1);
                Assert.AreEqual(n, problem.items.Count);
            }

        }

        [TestMethod]
        public void TestResultForOneElement()
        {
            Plecak problem = new(0, 1);
            problem.items.Add(new Item(0, 8, 4));
            Assert.IsTrue(problem.Solve(10).taken_items.Count()>0);

        }
        [TestMethod]
        public void TestIfResultIsEmptyWhenNoMatch()
        {
            Plecak problem = new(0, 1);
            problem.items.Add(new Item(0, 8, 4));
            Assert.IsTrue(problem.Solve(3).taken_items.Count() == 0);
        }

        [TestMethod]
        public void TestResultOrder()
        {
            Plecak problem = new(10, 1);
            Plecak problem2 = problem;
            problem2.items.Reverse();
            Assert.AreEqual(problem.Solve(20).ToString(), problem2.Solve(20).ToString());
            
        }

        [TestMethod]
        public void TestResultForSpecificProblem()
        {
            Plecak problem = new(0, 1);
            problem.items.Add(new Item(0, 3, 2));
            problem.items.Add(new Item(1, 5, 8));
            problem.items.Add(new Item(2, 7, 5));
            Result result = new Result();
            result.takeItem(new Item(0, 3, 2));
            result.takeItem(new Item(2, 7, 5));
            Assert.AreEqual(problem.Solve(10).ToString(), result.ToString());
        }

        [TestMethod]
        public void TestCheckExecutionForManyItems()
        {
            try
            {
                Plecak problem = new(10000, 1);
                problem.Solve(10000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Failed compilation");
            }

        }

        [TestMethod]
        public void TestAddingNegativeItems()
        {
            Plecak problem = new Plecak(-5, 1);
            Assert.AreEqual(0, problem.items.Count);
        }

        [TestMethod]
        public void TestNegativeCapacity()
        {
            Plecak problem = new Plecak(10, 1);
            Assert.AreEqual(problem.Solve(0).ToString(), problem.Solve(-1).ToString());
        }

        [TestMethod]
        public void TestIfValidType()
        {
            try
            {
                Plecak problem = new('a', 1);
            }
            catch (FormatException ex)
            {
                Assert.Fail("Ivalid data type");
            }
        }

        [TestMethod]
        public void TestSeedResult()
        {
            Plecak problem = new Plecak(10, 1);
            Plecak problem2 = new Plecak(10, 1);
            Assert.AreEqual(problem.Solve(20).ToString(), problem2.Solve(20).ToString());
        }

        [TestMethod]
        public void TestSolveAglorithms()
        {
            Plecak problem = new Plecak(10, 1);
            Assert.IsTrue(problem.Solve(20).total_value <= problem.Solve2(20).total_value);
        }
    }
}