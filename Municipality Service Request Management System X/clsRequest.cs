using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Municipality_Service_Request_Management_System_X;

namespace Municipality_Service_Request_Management_System_X
{
   
    namespace clsRequest
    {
        public class RequestFileGenerator
        {
            // The folder where text files will be saved (e.g., Desktop or AppData)
            private readonly string _saveDirectory;

            public RequestFileGenerator(string saveDirectory)
            {
                _saveDirectory = saveDirectory;

                // Ensure the directory exists
                if (!Directory.Exists(_saveDirectory))
                {
                    Directory.CreateDirectory(_saveDirectory);
                }
            }

            public void SaveRequestToFile(MunicipalServiceRequest request)
            {
                // 1. Generate a unique filename using the Reference Number and a Timestamp
                // This ensures a NEW file is created every time you click save.
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = $"{request.ReferenceNumber}_{timestamp}.txt";
                string filePath = Path.Combine(_saveDirectory, fileName);

                // 2. Build the text content using StringBuilder for efficiency
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("==========================================================");
                sb.AppendLine("              MUNICIPAL SERVICE REQUEST                   ");
                sb.AppendLine("==========================================================");
                sb.AppendLine();
                sb.AppendLine($"REFERENCE NO:\t\t{request.ReferenceNumber}");
                sb.AppendLine($"DATE LOGGED:\t\t{request.DateLogged:dd MMM yyyy, HH:mm}");
                sb.AppendLine($"STATUS:\t\t\t{request.CurrentStatus}");
                sb.AppendLine($"PRIORITY:\t\t{request.Priority}");
                sb.AppendLine();

                sb.AppendLine("----------------------------------------------------------");
                sb.AppendLine("1. REQUESTER DETAILS");
                sb.AppendLine("----------------------------------------------------------");
                sb.AppendLine($"NAME:\t\t\t{request.ResidentName}");
                sb.AppendLine($"CONTACT NO:\t\t{request.ContactNumber}");
               
                sb.AppendLine();

                sb.AppendLine("----------------------------------------------------------");
                sb.AppendLine("2. LOCATION DETAILS");
                sb.AppendLine("----------------------------------------------------------");
                sb.AppendLine($"STREET ADDRESS:\t\t{request.StreetAddress}");
                sb.AppendLine($"SUBURB:\t\t\t{request.Suburb}");
                sb.AppendLine($"NEAREST LANDMARK:\t{request.NearestLandmark}");
                sb.AppendLine();

                sb.AppendLine("----------------------------------------------------------");
                sb.AppendLine("3. ISSUE DETAILS");
                sb.AppendLine("----------------------------------------------------------");
                sb.AppendLine($"CATEGORY:\t\t{request.Category}");
                sb.AppendLine($"ISSUE TYPE:\t\t{request.IssueType}");
               
                sb.AppendLine();

                sb.AppendLine("----------------------------------------------------------");
                sb.AppendLine("4. PROGRESS TIMELINE");
                sb.AppendLine("----------------------------------------------------------");

                foreach (var ev in request.Timeline)
                {
                    // Formatting timeline to align nicely
                    sb.AppendLine($"[{ev.Time}] \t{ev.Title.PadRight(20)} | {ev.Status}");
              
                }
                sb.AppendLine($"PHOTO ATTACHED:\t{request.PhotoFilePath}");

                sb.AppendLine();
                sb.AppendLine("==========================================================");
                sb.AppendLine("                END OF REPORT                             ");
                sb.AppendLine("==========================================================");

                // 3. Write the file to disk
                try
                {
                    File.WriteAllText(filePath, sb.ToString());
                }
                catch (Exception ex)
                {
                    throw new Exception($"Failed to save file: {ex.Message}");
                }
            }
        }
    }
}
