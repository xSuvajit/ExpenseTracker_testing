
namespace ExpenseTracker_testing
{
    [TestFixture]
    class AllTesting
    {
        [SetUp]
        public void setUp()
        {
            allOtherOperations.initilizeDummyDetails();
        }
        [TestCase("suvajit@gmail.com")]
        [TestCase("deepraj@gmail.com")]
        public void test1(string email)
        {
            Assert.That(allOtherOperations.isUserPresent(email), Is.True);

        }
        [Test, Combinatorial]
        public void test2([Values("By ID")] string _choice,
            [Values("101", "102")] string _search)
        {
            BindingList<expence_Details> exp = allOtherOperations.searchResultAfterFilter(
                _choice, User_data.getUserData()[0], _search);

            Assert.Multiple(() =>
            {
                Assert.That(exp[0].ID.ToString(), Is.EqualTo(_search));
            });
        }
        [Test, Combinatorial]
        public void test3([Values("By Name")] string _choice,
            [Values("food", "wearable")] string _search)
        {
            BindingList<expence_Details> exp = allOtherOperations.searchResultAfterFilter(
                _choice, User_data.getUserData()[0], _search);

            Assert.Multiple(() =>
            {
                Assert.That(exp[0].Name, Is.EqualTo(_search));
            });
        }

    }
}
