using System;
using System.Linq;
using NUnit.Framework;
using Should.Fluent;
using SpecFlow.Assist.Dynamic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Specs.Steps
{
    [Binding]
    public class DynamicSetCreationSteps
    {
        private static dynamic GetItem(int itemNumber)
        {
            return State.OriginalSet[itemNumber - 1];
        }

        [Given(@"I create a set of dynamic instances from this table")]
        [When(@"I create a set of dynamic instances from this table")]
        public void WithMethodBInding(Table table)
        {
            State.OriginalSet = table.CreateDynamicSet().ToList();   
        }

        [Given(@"I create a set of dynamic instances from this table of type '(.*)'")]
        [When(@"I create a set of dynamic instances from this table of type '(.*)'")]
        public void WithMethodBinding(string valueType, Table table)
        {
            switch (valueType)
            {
                case "string":
                    State.OriginalSet = table.CreateDynamicSet<string>().ToList();
                    break;
                case "int":
                    State.OriginalSet = table.CreateDynamicSet<int>().ToList();
                    break;
                case "double":
                    State.OriginalSet = table.CreateDynamicSet<double>().ToList();
                    break;
                case "DateTime":
                    State.OriginalSet = table.CreateDynamicSet<DateTime>().ToList();
                    break;
                case "bool":
                    State.OriginalSet = table.CreateDynamicSet<bool>().ToList();
                    break;
                default:
                    throw new ApplicationException("Unhandled value type");
            }
        }

        [Then(@"I should have a list of (\d+) dynamic objects")]
        public void ShouldContain(int expectedNumberOfItems)
        {
            State.OriginalSet.Count.Should().Equal(expectedNumberOfItems);
        }

        [Then(@"the (\d+) item should have BirthDate equal to '(.*)'")]
        public void ItemInSetShouldHaveExpectedBirthDate(int itemNumber, string expectedBirthDate)
        {
            Assert.AreEqual(DateTime.Parse(expectedBirthDate), GetItem(itemNumber).BirthDate);
        }

        [Then(@"the (\d+) item should have Age equal to '(\d+)'")]
        public void ItemInSetShouldHaveExpectedAge(int itemNumber, int expectedAge)
        {
            Assert.AreEqual(expectedAge, GetItem(itemNumber).Age);
        }

        [Then(@"the (\d+) item should have Name equal to '(.*)'")]
        public void ItemInSetShouldHaveExpectedName(int itemNumber, string expectedName)
        {
            Assert.AreEqual(expectedName, GetItem(itemNumber).Name);
        }

        [Then(@"the (\d+) item should have LengthInMeters equal to '(\d+\.\d+)'")]
        public void ItemInSetShouldHaveExpectedLenghtInMeters(int itemNumber, double expectedLengthInMetersItem)
        {
            Assert.AreEqual(expectedLengthInMetersItem, GetItem(itemNumber).LengthInMeters);
        }
        
        [Then(@"each item should be of type '(.*)'")]
        public void EachItemInSetShouldBeOfType(string valueType)
        {
            foreach (var dyn in State.OriginalSet)
            {
                var property1 = (object) dyn.Property1;
                switch (valueType)
                {
                    case "string":
                        property1.Should().Be.OfType<string>();
                        break;
                    case "int":
                        property1.Should().Be.OfType<int>();
                        break;
                    case "double":
                        property1.Should().Be.OfType<double>();
                        break;
                    case "DateTime":
                        property1.Should().Be.OfType<DateTime>();
                        break;
                    case "bool":
                        property1.Should().Be.OfType<bool>();
                        break;
                    default:
                        throw new ApplicationException("Unhandled value type");
                }

                var property2 = (object)dyn.Property2;
                switch (valueType)
                {
                    case "string":
                        property2.Should().Be.OfType<string>();
                        break;
                    case "int":
                        property2.Should().Be.OfType<int>();
                        break;
                    case "double":
                        property2.Should().Be.OfType<double>();
                        break;
                    case "DateTime":
                        property2.Should().Be.OfType<DateTime>();
                        break;
                    case "bool":
                        property2.Should().Be.OfType<bool>();
                        break;
                    default:
                        throw new ApplicationException("Unhandled value type");
                }

                var property3 = (object)dyn.Property3;
                switch (valueType)
                {
                    case "string":
                        property3.Should().Be.OfType<string>();
                        break;
                    case "int":
                        property3.Should().Be.OfType<int>();
                        break;
                    case "double":
                        property3.Should().Be.OfType<double>();
                        break;
                    case "DateTime":
                        property3.Should().Be.OfType<DateTime>();
                        break;
                    case "bool":
                        property3.Should().Be.OfType<bool>();
                        break;
                    default:
                        throw new ApplicationException("Unhandled value type");
                }

                var property4 = (object)dyn.Property4;
                switch (valueType)
                {
                    case "string":
                        property4.Should().Be.OfType<string>();
                        break;
                    case "int":
                        property4.Should().Be.OfType<int>();
                        break;
                    case "double":
                        property4.Should().Be.OfType<double>();
                        break;
                    case "DateTime":
                        property4.Should().Be.OfType<DateTime>();
                        break;
                    case "bool":
                        property4.Should().Be.OfType<bool>();
                        break;
                    default:
                        throw new ApplicationException("Unhandled value type");
                }

            }
        }

        //[Then(@"the (\d+) item should have Name be of type '(.*)' and equal '(.*)'")]
        //public void ThenTheItemShouldHaveNameTypeEqualTo(int itemNumber, string valueType, object value)
        //{
        //    object item = GetItem(itemNumber).Name;
        //    switch (valueType)
        //    {
        //        case "string":
        //            item.Should().Be.OfType<string>();
        //            break;
        //        case "int":
        //            item.Should().Be.OfType<int>();
        //            break;
        //        case "double":
        //            item.Should().Be.OfType<double>();
        //            break;
        //        case "DateTime":
        //            item.Should().Be.OfType<DateTime>();
        //            break;
        //        case "bool":
        //            item.Should().Be.OfType<bool>();
        //            break;
        //        default:
        //            throw new ApplicationException("Unhandled value type");
        //    }
        //    item.Should().Equal(value);
        //}

        //[Then(@"the (\d+) item should have Age be of type '(.*)' and equal '(.*)'")]
        //public void ThenTheItemShouldHaveAgeTypeEqualTo(int itemNumber, string valueType, object value)
        //{
        //    object item = GetItem(itemNumber).Age;
        //    switch (valueType)
        //    {
        //        case "string":
        //            item.Should().Be.OfType<string>();
        //            break;
        //        case "int":
        //            item.Should().Be.OfType<int>();
        //            break;
        //        case "double":
        //            item.Should().Be.OfType<double>();
        //            break;
        //        case "DateTime":
        //            item.Should().Be.OfType<DateTime>();
        //            break;
        //        case "bool":
        //            item.Should().Be.OfType<bool>();
        //            break;
        //        default:
        //            throw new ApplicationException("Unhandled value type");
        //    }
        //    item.Should().Equal(value);
        //}

        //[Then(@"the (\d+) item should have BirthDate be of type '(.*)' and equal '(.*)'")]
        //public void ThenTheItemShouldHaveBirthDateTypeEqualTo(int itemNumber, string valueType, object value)
        //{
        //    object item = GetItem(itemNumber).BirthDate;
        //    switch (valueType)
        //    {
        //        case "string":
        //            item.Should().Be.OfType<string>();
        //            break;
        //        case "int":
        //            item.Should().Be.OfType<int>();
        //            break;
        //        case "double":
        //            item.Should().Be.OfType<double>();
        //            break;
        //        case "DateTime":
        //            item.Should().Be.OfType<DateTime>();
        //            break;
        //        case "bool":
        //            item.Should().Be.OfType<bool>();
        //            break;
        //        default:
        //            throw new ApplicationException("Unhandled value type");
        //    }
        //    item.Should().Equal(value);
        //}

        //[Then(@"the (\d+) item should have LengthInMeters be of type '(.*)' and equal '(.*)'")]
        //public void ThenTheItemShouldHaveLengthInMetersTypeEqualTo(int itemNumber, string valueType, object value)
        //{
        //    object item = GetItem(itemNumber).LengthInMeters;
        //    switch (valueType)
        //    {
        //        case "string":
        //            item.Should().Be.OfType<string>();
        //            break;
        //        case "int":
        //            item.Should().Be.OfType<int>();
        //            break;
        //        case "double":
        //            item.Should().Be.OfType<double>();
        //            break;
        //        case "DateTime":
        //            item.Should().Be.OfType<DateTime>();
        //            break;
        //        case "bool":
        //            item.Should().Be.OfType<bool>();
        //            break;
        //        default:
        //            throw new ApplicationException("Unhandled value type");
        //    }
        //    item.Should().Equal(value);
        //}
    }
}
