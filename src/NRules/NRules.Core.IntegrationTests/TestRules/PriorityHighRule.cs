﻿using System;
using NRules.Core.IntegrationTests.TestAssets;
using NRules.Dsl;

namespace NRules.Core.IntegrationTests.TestRules
{
    [RulePriority(100)]
    public class PriorityHighRule : BaseRule
    {
        public Action<BaseRule> InvocationHandler { get; set; }

        public override void Define(IDefinition definition)
        {
            definition.When()
                .If<FactType2>(f2 => f2.TestProperty == "Valid Value");
            definition.Then()
                .Do(ctx => Notifier.RuleActivated())
                .Do(ctx => InvocationHandler.Invoke(this));
        }
    }
}