using System;

namespace AzureBlobStorageSas
{
    public class PatientRecord
    {
        public string name { get; set; }

        public string imageURI { get; set; }

        public string sasToken { get; set; }
    }
}
