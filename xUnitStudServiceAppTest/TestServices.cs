using StudentServiceApplication.Services;
namespace xUnitStudServiceAppTest
{
    public class TestServices
    {
        [Theory]
        [InlineData("3126987342123")]
        [InlineData("vova123")]
        [InlineData("v")]
        [InlineData("1__31v0dav@12vv3")]
        [InlineData("ji!@#fa%^&j32")]
        [InlineData("")]
        public void bCryptHashVerifyCorrect(string password)
        {
            //Arrange(Подготовка)
            BCryptHashService bCryptHashService = new();
            //Act(Действие)
            string hashpass = bCryptHashService.HashPassword(password);
            bool isTrueVerify = bCryptHashService.VerifyPassword(password, hashpass);
            //Assert(Результат)
            Assert.True(isTrueVerify);
        }
    }
}