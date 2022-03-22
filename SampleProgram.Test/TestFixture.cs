using System;
using System.Collections.Generic;
using System.Linq;
using ChessLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleProgram.Test
{
    [TestClass]
    public class TestFixture1
    {
        [TestMethod]
        public void TestKnightMoveFromInsideBoard()
        {
            var pos = new Position(3, 3);
            var knight = new KnightMove();

            var moves = knight.ValidMovesFor(pos).ToArray();

            Assert.IsNotNull(moves);
            Assert.AreEqual(8, moves.Length);

            foreach (var move in moves)
            {
                switch (Math.Abs(move.X - pos.X))
                {
                    case 1:
                        Assert.AreEqual(2, Math.Abs(move.Y - pos.Y));
                        break;
                    case 2:
                        Assert.AreEqual(1, Math.Abs(move.Y - pos.Y));
                        break;
                    default:
                        Assert.Fail();
                        break;
                }
            }
        }

        [TestMethod]
        public void TestKnightMoveFromCorner()
        {
            var pos = new Position(1, 1);
            var knight = new KnightMove();

            var moves = new HashSet<Position>(knight.ValidMovesFor(pos));

            Assert.IsNotNull(moves);
            Assert.AreEqual(2, moves.Count);

            var possibles = new[] {new Position(2, 3), new Position(3, 2)};

            foreach (var possible in possibles)
            {
                Assert.IsTrue(moves.Contains(possible));
            }
        }

        [TestMethod]
        public void TestPosition()
        {
            var pos = new Position(1, 1);
            Assert.AreEqual(1, pos.X);
            Assert.AreEqual(1, pos.Y);

            var pos2 = new Position(1, 1);

            Assert.AreEqual(pos, pos2);
        }
    }
}
