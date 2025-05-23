﻿namespace Caliburn.Micro.Avalonia.Tests
{
    public class MessageBinderTests
    {
        [Fact]
        public void EvaluateParameterCaseInsensitive()
        {
            MessageBinder.SpecialValues.TryAdd("$sampleParameter", context => 42);
            var caseSensitiveValue = MessageBinder.EvaluateParameter("$sampleParameter", typeof(int), new ActionExecutionContext());

            Assert.NotEqual("$sampleParameter", caseSensitiveValue);

            var caseInsensitiveValue = MessageBinder.EvaluateParameter("$sampleparameter", typeof(int), new ActionExecutionContext());
            Assert.NotEqual("$sampleparameter", caseInsensitiveValue);
        }
    }
}
