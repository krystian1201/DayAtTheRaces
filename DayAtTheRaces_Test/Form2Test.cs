using System;
using Dzień_na_wyścigach;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DayAtTheRaces_Test
{
    [TestClass]
    public class Form2Test
    {
        [TestMethod]
        public void AddingPlayerShouldHandleEmptyRow()
        {
            Form2 form = new Form2();
            
            form.buttonAddPlayer_Click(null, null);

            
        }
    }
}
