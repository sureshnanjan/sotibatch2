using System;
using TechTalk.SpecFlow;
using Soti.Training.Batch2.Application;
using FluentAssertions;

namespace Soti.Training.Batch2.UserAcceptanceTests.Steps
{
    [Binding]
    public class BinarySearcherSteps
    {
        int[] inputArray;
        int result;
        [Given(@"A Sorted Array has these elements (.*),(.*),(.*),(.*)")]
        public void GivenASortedArrayHasTheseElements(int p0, int p1,int p2,int p3)
        {
            inputArray = new int[] {p0,p1,p2,p3 };
        }

        [When(@"I search for (.*)")]
        public void WhenISearchFor(int p0)
        {
            result = BinarySearcher.BinarySearch(inputArray, p0);
        }

        [Then(@"the search result should be (.*)")]
        public void ThenTheSearchResultShouldBe(int p0)
        {
            result.Should().Be(p0);
        }

        [Then(@"the search result should be complement of (.*)")]
        public void ThenTheSearchResultShouldBeComplement(int p0)
        {
            result.Should().Be(~p0);           
        }
    }
}
