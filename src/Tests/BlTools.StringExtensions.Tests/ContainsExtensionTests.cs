namespace BlTools.StringExtensions.Tests.XUnit
{
    public class ContainsExtensionTests
    {
        [Fact]
        public void ContainsFoundSubstringsWithSameCase()
        {
            var source = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. ";
            var template = "Lorem";
            var result = source.ContainsIgnoreCase(template);
            Assert.True(result, "Extension cannot find string with same case as original");
        }

        [Fact]
        public void ContainsCompareStringsUsingIgnoreCase()
        {
            var source = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. ";
            var template = "DUMMY";
            var result = source.ContainsIgnoreCase(template);
            Assert.True(result, "Extension doesn't work with ignore case option");
        }

        [Fact]
        public void ContainsReturnTrueIfValueIsEmpty()
        {
            var source = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. ";
            var template = "";
            var result = source.ContainsIgnoreCase(template);
            Assert.True(result, "Extension doesn't work empty value");
        }

        [Fact]
        public void ContainsAppliesToEmptyString()
        {
            string? source = "";
            var template = "DUMMY";
            var result = source.ContainsIgnoreCase(template);
            Assert.False(result, "Extension doesn't work with empty string");
        }

        [Fact]
        public void ContainsAppliesToNullString()
        {
            string? source = null;
            var template = "DUMMY";
            var result = source.ContainsIgnoreCase(template);
            Assert.False(result, "Extension doesn't work with null string");
        }
    }
}
