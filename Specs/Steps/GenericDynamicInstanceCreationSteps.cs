using System;
using Should.Fluent;
using SpecFlow.Assist.Dynamic;
using TechTalk.SpecFlow;

namespace Specs.Steps
{
    [Binding]
    public class GenericDynamicInstanceCreationSteps
    {
        [When(@"I create a generic dynamic instance from this table of type '(.*)'")]
        public void WhenICreateAGenericDynamicInstanceFromThisTable(string type, Table table)
        {
            switch (type)
            {
                case "string":
                    State.OriginalInstance = table.CreateDynamicInstance<string>();
                    break;
                case "int":
                    State.OriginalInstance = table.CreateDynamicInstance<int>();
                    break;
                case "double":
                    State.OriginalInstance = table.CreateDynamicInstance<double>();
                    break;
                case "DateTime":
                    State.OriginalInstance = table.CreateDynamicInstance<DateTime>();
                    break;
                case "bool":
                    State.OriginalInstance = table.CreateDynamicInstance<bool>();
                    break;
                default:
                    throw new ApplicationException("Unhandled value type");
            }         
        }

        [Then(@"the Name property should be of type '(.*)' and equal '(.*)'")]
        public void ThenTheNamePropertyShouldBe(string valueType, object value)
        {
            switch (valueType)
            {
                case "string":
                    ((object)State.OriginalInstance.Name).Should().Be.OfType<string>();
                    break;
                case "int":
                    ((object)State.OriginalInstance.Name).Should().Be.OfType<int>();
                    break;
                case "double":
                    ((object)State.OriginalInstance.Name).Should().Be.OfType<double>();
                    break;
                case "DateTime":
                    ((object)State.OriginalInstance.Name).Should().Be.OfType<DateTime>();
                    break;
                case "bool":
                    ((object)State.OriginalInstance.Name).Should().Be.OfType<bool>();
                    break;
                default:
                    throw new ApplicationException("Unhandled value type");
            }
            ((object)State.OriginalInstance.Name).Should().Equal(value);
        }

        [Then(@"the Age property should be of type '(.*)' and equal '(.*)'")]
        public void ThenTheAgePropertyShouldBe(string valueType, object value)
        {
            switch (valueType)
            {
                case "string":
                    ((object)State.OriginalInstance.Age).Should().Be.OfType<string>();
                    break;
                case "int":
                    ((object)State.OriginalInstance.Age).Should().Be.OfType<int>();
                    break;
                case "double":
                    ((object)State.OriginalInstance.Age).Should().Be.OfType<double>();
                    break;
                case "DateTime":
                    ((object)State.OriginalInstance.Age).Should().Be.OfType<DateTime>();
                    break;
                case "bool":
                    ((object)State.OriginalInstance.Age).Should().Be.OfType<bool>();
                    break;
                default:
                    throw new ApplicationException("Unhandled value type");
            }
            ((object)State.OriginalInstance.Age).Should().Equal(value);
        }

        [Then(@"the BirthDate property should be of type '(.*)' and equal '(.*)'")]
        public void ThenTheBirthDatePropertyShouldBe(string valueType, object value)
        {
            switch (valueType)
            {
                case "string":
                    ((object)State.OriginalInstance.BirthDate).Should().Be.OfType<string>();
                    break;
                case "int":
                    ((object)State.OriginalInstance.BirthDate).Should().Be.OfType<int>();
                    break;
                case "double":
                    ((object)State.OriginalInstance.BirthDate).Should().Be.OfType<double>();
                    break;
                case "DateTime":
                    ((object)State.OriginalInstance.BirthDate).Should().Be.OfType<DateTime>();
                    break;
                case "bool":
                    ((object)State.OriginalInstance.BirthDate).Should().Be.OfType<bool>();
                    break;
                default:
                    throw new ApplicationException("Unhandled value type");
            }
            ((object)State.OriginalInstance.BirthDate).Should().Equal(value);
        }

        [Then(@"the LengthInMeters property should be of type '(.*)' and equal '(.*)'")]
        public void ThenTheLengthInMetersPropertyShouldBe(string valueType, object value)
        {
            switch (valueType)
            {
                case "string":
                    ((object)State.OriginalInstance.LengthInMeters).Should().Be.OfType<string>();
                    break;
                case "int":
                    ((object)State.OriginalInstance.LengthInMeters).Should().Be.OfType<int>();
                    break;
                case "double":
                    ((object)State.OriginalInstance.LengthInMeters).Should().Be.OfType<double>();
                    break;
                case "DateTime":
                    ((object)State.OriginalInstance.LengthInMeters).Should().Be.OfType<DateTime>();
                    break;
                case "bool":
                    ((object)State.OriginalInstance.LengthInMeters).Should().Be.OfType<bool>();
                    break;
                default:
                    throw new ApplicationException("Unhandled value type");
            }
            ((object)State.OriginalInstance.LengthInMeters).Should().Equal(value);
        }

        [Then(@"the IsDeveloper property should be of type '(.*)' and equal '(.*)'")]
        public void ThenTheIsDeveloperPropertyShouldBe(string valueType, object value)
        {
            switch (valueType)
            {
                case "string":
                    ((object)State.OriginalInstance.IsDeveloper).Should().Be.OfType<string>();
                    break;
                case "int":
                    ((object)State.OriginalInstance.IsDeveloper).Should().Be.OfType<int>();
                    break;
                case "double":
                    ((object)State.OriginalInstance.IsDeveloper).Should().Be.OfType<double>();
                    break;
                case "DateTime":
                    ((object)State.OriginalInstance.IsDeveloper).Should().Be.OfType<DateTime>();
                    break;
                case "bool":
                    ((object)State.OriginalInstance.IsDeveloper).Should().Be.OfType<bool>();
                    break;
                default:
                    throw new ApplicationException("Unhandled value type");
            }
            ((object)State.OriginalInstance.IsDeveloper).Should().Equal(value);
        }
    }
}