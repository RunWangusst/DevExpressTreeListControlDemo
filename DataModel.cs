using System;
using System.Collections.ObjectModel;

namespace ChildNodesSelector
{
    public class BaseObject
    {
        public string Name { get; set; }
        public string Executor { get; set; }
        public string State { get; set; }
        public string Id { get; set; }
        public string ParentId { get; set; }

        public ObservableCollection<ProjectObject> Projects { get; set; }

        public BaseObject()
        {
            Projects = new ObservableCollection<ProjectObject>();
        }
    }

    public class ProjectObject : BaseObject
    {
        public ObservableCollection<ProjectStage> Stages { get; set; }
    }

    public class ProjectStage : BaseObject
    {
        public ObservableCollection<StageTask> Tasks { get; set; }
    }

    public class StageTask : BaseObject
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
