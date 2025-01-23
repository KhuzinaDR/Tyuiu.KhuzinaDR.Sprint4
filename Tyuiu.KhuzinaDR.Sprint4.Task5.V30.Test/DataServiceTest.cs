using Tyuiu.KhuzinaDR.Sprint4.Task5.V30.Lib;

namespace Tyuiu.KhuzinaDR.Sprint4.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,] { {-1,-1,-1,-1,-1 },
                                         {-1,-1,-1,-1,-1 },
                                         {-1,-1,-1,-1,-1 },
                                         {-1,-1,-1,-1,-1 },
                                         {-1,-1,-1,-1,4 }
                                            };

            int res = ds.Calculate(matrix);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}