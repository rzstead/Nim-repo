using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NimTester
{
    using Nim;
    using Nim.CpuVsCpu;
    using Nim.Players;
    using System.Collections.Generic;
    [TestClass]
    public class NimTests
    {
        [TestMethod]
        public void CheckProperAISelection()
        {
            char[][] visualEdit = new char[3][]
        {
            new char[] {'o', 'o', 'o'},
            new char[] {'x', 'x', 'x', 'o', 'o'},
            new char[] {'o', 'o', 'o', 'o', 'o', 'o', 'o'}
        };
            char[][] visual = new char[3][]
{
            new char[] {'o', 'o', 'o'},
            new char[] {'o', 'o', 'o', 'o', 'o'},
            new char[] {'o', 'o', 'o', 'o', 'o', 'o', 'o'}
};
            int[] move = { 2, 3 };
            State state = new State(move, .5, visualEdit);
            List<State> prevStates = new List<State>();

            Player p = new LearnCPU(visual);
            ((LearnCPU)p).AddMove(state);
            p.ChooseMove();


        }
    }
}
