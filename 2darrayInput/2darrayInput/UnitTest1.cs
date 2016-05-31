using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2darrayInput
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateBoard()
        {
            TicTacToe ttt = new TicTacToe();
            ttt.DisplayBoard();

        }
    }
}
