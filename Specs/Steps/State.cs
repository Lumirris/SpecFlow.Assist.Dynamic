using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Specs.Steps
{
    public class State
    {
        public static dynamic OriginalInstance
        {
            get
            {
                return ScenarioContext.Current["OriginalInstance"];
            }
            set
            {
                ScenarioContext.Current.Add("OriginalInstance", value);
            }
        }

        public static IList<dynamic> OriginalSet
        {
            get
            {
                return ScenarioContext.Current["OriginalSet"] as IList<dynamic>;
            }
            set
            {
                ScenarioContext.Current.Add("OriginalSet", value);
            }
        }
    }
}
