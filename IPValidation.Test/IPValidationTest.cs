
using IPValidation.Utilities;

namespace IPValidation.Test
{
    public class IPValidationTest
    {
        [Fact]
        public void IPValidate_Case_Valid()
        {
            var ip = "192.168.0.1";
            var result = Validator.IsValidIP(ip);
            Assert.True(result);
        }



        [Theory]
        [InlineData("192.168.0.1")]
        [InlineData("192.168.123.1")]
        [InlineData("192.1.1.1")]
        [InlineData("192.255.0.255")]
        [InlineData("192.168.255.21")]
        public void IPValidate_Case_Valid_Many_IP(string ip)
        {            
            var result = Validator.IsValidIP(ip);
            Assert.True(result);
        }

        [Fact]
        public void IPValidate_Case_Invalid_Leading_0()
        {
            var ip = "192.08.12.100";
            var result = Validator.IsValidIP(ip);
            Assert.False(result);
        }

        [Fact]
        public void IPValidate_Case_Invalid_Less_Octets()
        {
            var ip = "192.18.12";
            var result = Validator.IsValidIP(ip);
            Assert.False(result);
        }

        [Fact]
        public void IPValidate_Case_Invalid_More_Octets()
        {
            var ip = "192.18.12.12.34";
            var result = Validator.IsValidIP(ip);
            Assert.False(result);
        }

        [Fact]
        public void IPValidate_Case_Invalid_With_Letters()
        {
            var ip = "192.18.12.12.34";
            var result = Validator.IsValidIP(ip);
            Assert.False(result);
        }
    }
}