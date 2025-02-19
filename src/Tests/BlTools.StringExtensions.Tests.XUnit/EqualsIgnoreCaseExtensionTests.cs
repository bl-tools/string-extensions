namespace BlTools.StringExtensions.Tests.XUnit
{
    public class EqualsIgnoreCaseExtensionTests
    {
        [Fact]
        public void EqualsFoundSubstringsWithSameCase()
        {
            var source = "LOREM IPSUM";
            var template = "LOREM IPSUM";
            var result = source.EqualsIgnoreCase(template);
            Assert.True(result, "Extension cannot find string with same case as original");
        }

        [Fact]
        public void EqualsReturnTrueIfSourceUpper()
        {
            var source = "LOREM IPSUM";
            var template = "Lorem Ipsum";
            var result = source.EqualsIgnoreCase(template);
            Assert.True(result, "Extension cannot find string with same case as original");
        }

        [Fact]
        public void EqualsReturnTrueIfSourceLower()
        {
            var source = "Lorem Ipsum";
            var template = "LOREM IPSUM";
            var result = source.EqualsIgnoreCase(template);
            Assert.True(result, "Extension doesn't work with ignore case option");
        }

        [Fact]
        public void EqualsReturnFalseIfValueIsEmpty()
        {
            var source = "Lorem Ipsum";
            var template = "";
            var result = source.EqualsIgnoreCase(template);
            Assert.False(result, "Extension doesn't work empty value");
        }

        [Fact]
        public void EqualsAppliesToEmptyString()
        {
            var source = string.Empty;
            var template = "Lorem Ipsum";
            var result = source.EqualsIgnoreCase(template);
            Assert.False(result, "Extension doesn't work with empty string");
        }

        [Fact]
        public void EqualsAppliesToNullString()
        {
            string? source = null;
            var template = "Lorem Ipsum";
            var result = source.EqualsIgnoreCase(template);
            Assert.False(result, "Extension doesn't work with null string");
        }

        [Fact]
        public void EqualsReturnsTrueForNullStrings()
        {
            string? source = null;
            string? template = null;
            var result = source.EqualsIgnoreCase(template);
            Assert.True(result, "Extension doesn't work with null string");
        }

        [Fact]
        public void EqualsReturnsTrueForEmptyStrings()
        {
            string? source = string.Empty;
            string template = string.Empty;
            var result = source.EqualsIgnoreCase(template);
            Assert.True(result, "Extension doesn't work with null string");
        }
    }
}
