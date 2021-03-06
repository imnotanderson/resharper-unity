﻿using NUnit.Framework;

namespace JetBrains.ReSharper.Plugins.Unity.Tests.Feature.Services.Descriptions
{
    [TestUnity]
    public class IdentifierTooltipTest : IdentifierTooltipTestBase
    {
        protected override string RelativeTestDataPath => @"daemon\IdentifierTooltip";

        [Test] public void EventFunction01() { DoNamedTest(); }
        [Test] public void EventFunction02() { DoNamedTest(); }
        [Test] public void EventFunctionParameter01() { DoNamedTest(); }
        [Test] public void EventFunctionParameter02() { DoNamedTest(); }
    }
}