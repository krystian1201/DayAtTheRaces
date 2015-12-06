using System;
using System.Windows.Forms;
using Dzień_na_wyścigach;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DayAtTheRaces_Test
{
    [TestClass]
    public class Form2Test
    {
        private Form2 _form;

        [TestInitialize()]
        public void Startup()
        {
            _form = new Form2
            {
                MessageBoxService = new Mock<IMessageBoxService>().Object
            };
        }

        [TestMethod]
        public void AddingPlayerShouldHandleEmptyRow()
        {
            _form.buttonAddPlayer_Click(null, null);

            //just shouldn't throw exception
        }

        [TestMethod]
        public void RowShouldBeMadeReadonlyAfterAddingPlayerSuccessfuly()
        {
            _form.dataGridViewPlayers.Rows.Add(new DataGridViewRow());
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerNameColumn"].Value = "Player";
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerMoneyColumn"].Value = "10";

            Assert.IsFalse(_form.dataGridViewPlayers.Rows[0].ReadOnly);

            _form.buttonAddPlayer_Click(null, null);

            Assert.IsTrue(_form.dataGridViewPlayers.Rows[0].ReadOnly);
        }

        [TestMethod]
        public void RowShouldNotBeMadeReadonlyAfterAddingPlayerUnsuccessfuly()
        {

            _form.dataGridViewPlayers.Rows.Add(new DataGridViewRow());
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerNameColumn"].Value = "Player";
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerMoneyColumn"].Value = "abc";

            Assert.IsFalse(_form.dataGridViewPlayers.Rows[0].ReadOnly);

            _form.buttonAddPlayer_Click(null, null);

            Assert.IsFalse(_form.dataGridViewPlayers.Rows[0].ReadOnly);
        }

        [TestMethod]
        public void AddPlayerButtonShouldBeDisabledAfterAddingPlayerSuccessfuly()
        {

            _form.dataGridViewPlayers.Rows.Add(new DataGridViewRow());
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerNameColumn"].Value = "Player";
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerMoneyColumn"].Value = "10";

            _form.dataGridViewPlayers_RowLeave(null, null);

            Assert.IsTrue(_form.buttonAddPlayer.Enabled);

            _form.buttonAddPlayer_Click(null, null);

            Assert.IsFalse(_form.buttonAddPlayer.Enabled);
        }

        [TestMethod]
        public void AddPlayerButtonShouldBeEnabledAfterAddingPlayerUnsuccessfuly()
        {
            _form.dataGridViewPlayers.Rows.Add(new DataGridViewRow());
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerNameColumn"].Value = "Player";
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerMoneyColumn"].Value = "asd";

            _form.dataGridViewPlayers_RowLeave(null, null);

            Assert.IsTrue(_form.buttonAddPlayer.Enabled);

            _form.buttonAddPlayer_Click(null, null);

            Assert.IsTrue(_form.buttonAddPlayer.Enabled);
        }

        [TestMethod]
        public void AddPlayerButtonShouldBeDisabledByDefault()
        {
            Assert.IsFalse(_form.buttonAddPlayer.Enabled);
        }


        [TestMethod]
        public void AddPlayerButtonShouldBeEnabledAfterMovingToAnotherRow()
        {
            _form.dataGridViewPlayers.Rows.Add(new DataGridViewRow());
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerNameColumn"].Value = "Player";
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerMoneyColumn"].Value = "10";

            _form.buttonAddPlayer_Click(null, null);

            Assert.IsFalse(_form.buttonAddPlayer.Enabled);

            _form.dataGridViewPlayers_RowLeave(null, null);

            Assert.IsTrue(_form.buttonAddPlayer.Enabled);
        }

        [TestMethod]
        public void ShouldNotEnableAddPlayerButtonIfMoneyColumnOrPlayerNameColumnIsEmpty()
        {
            _form.dataGridViewPlayers.Rows.Add(new DataGridViewRow());
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerNameColumn"].Value = "";
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerMoneyColumn"].Value = "10";

            _form.dataGridViewPlayers_RowLeave(null, null);

            Assert.IsFalse(_form.buttonAddPlayer.Enabled);


            _form.dataGridViewPlayers.Rows.Clear();

            _form.dataGridViewPlayers.Rows.Add(new DataGridViewRow());
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerNameColumn"].Value = "Player";
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerMoneyColumn"].Value = "";

            _form.dataGridViewPlayers_RowLeave(null, null);

            Assert.IsFalse(_form.buttonAddPlayer.Enabled);
        }

        [TestMethod]
        public void ShouldBeAbleToAddMultiplePlayersAtOnce()
        {
            _form.dataGridViewPlayers.Rows.Add(new DataGridViewRow());
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerNameColumn"].Value = "Player1";
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerMoneyColumn"].Value = "10";

            _form.dataGridViewPlayers_RowLeave(null, null);

            _form.dataGridViewPlayers.Rows.Add(new DataGridViewRow());
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerNameColumn"].Value = "Player1";
            _form.dataGridViewPlayers.Rows[0].Cells["PlayerMoneyColumn"].Value = "10";

            _form.dataGridViewPlayers_RowLeave(null, null);

            _form.buttonAddPlayer_Click(null, null);


            //Assert.AreEqual();
        }

    }
}
