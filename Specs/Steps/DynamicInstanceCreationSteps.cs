﻿using System;
using Should.Fluent;
using SpecFlow.Assist.Dynamic;
using TechTalk.SpecFlow;

namespace Specs.Steps
{
    [Binding]
    public class DynamicInstanceCreationSteps
    {

        [Given(@"I create a dynamic instance from this table")]
        [When(@"I create a dynamic instance from this table")]
        public void CreateDynamicInstanceFromTable(Table table)
        {
            State.OriginalInstance = table.CreateDynamicInstance();
        }

        [Then(@"the Name property should equal '(.*)'")]
        public void NameShouldBe(string expectedValue)
        {
            ((string)State.OriginalInstance.Name).Should().Equal(expectedValue);
        }

        [Then(@"the Age property should equal (\d+)")]
        public void AgeShouldBe(int expectedAge)
        {
            ((int)State.OriginalInstance.Age).Should().Equal(expectedAge);
        }

        [Then(@"the age property should equal (\d+)")]
        public void LowerCaseAgeShouldBe(int expectedAge)
        {
            ((int) State.OriginalInstance.age).Should().Equal(expectedAge);
        }

        [Then(@"the BirthDate property should equal (.*)")]
        public void BirthDateShouldBe(string expectedDate)
        {
            ((DateTime)State.OriginalInstance.BirthDate).Should().Equal(DateTime.Parse(expectedDate));
        }

        [Then(@"the LengthInMeters property should equal (\d+\.\d+)")]
        public void LengthInMeterShouldBe(double expectedDouble)
        {
            ((double)State.OriginalInstance.LengthInMeters).Should().Equal(expectedDouble);
        }

        [Then(@"the SATScore should be (\d+)")]
        public void SATTest(int expectedScore)
        {
            ((int) State.OriginalInstance.SATScore).Should().Equal(expectedScore);
        }

        [Then(@"the IsDeveloper property should equal '(.*)'")]
        public void ThenTheIsDeveloperPropertyShouldEqualTrueAndBeOfTypeBool(bool expectedValue)
        {
            ((bool) State.OriginalInstance.IsDeveloper).Should().Equal(expectedValue);
        }

    }
}
