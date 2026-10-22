using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipality_Service_Request_Management_System_X
{
    //Extracting details from the municipal service request form and storing them in a class for further processing 
    //Will be saved and formatted in seperate textfiles
    public class MunicipalServiceRequest
    {
            public string ReferenceNumber { get; set; }
            public DateTime DateLogged { get; set; }
            public string CurrentStatus { get; set; }
            public string Priority { get; set; }

            public string ResidentName { get; set; }
            public string ContactNumber { get; set; }
           

            public string StreetAddress { get; set; }
            public string Suburb { get; set; }
            public string NearestLandmark { get; set; }

            public string Category { get; set; }
            public string IssueType { get; set; }

        public string PhotoFilePath { get; set; }

        public List<TimelineEvent> Timeline { get; set; } = new List<TimelineEvent>();
    }

        public class TimelineEvent
        {
            public string Time { get; set; }
            public string Title { get; set; }
        
            public string Status { get; set; }
        }
}

