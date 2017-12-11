using System.Collections.Generic;

namespace udemy_csharp_intermediate.Interface
{
    public class Workflow
    {
        public List<IActivity> Activities { get; }

        public Workflow(List<IActivity> activities)
        {
            Activities = activities;
        }
    }
}