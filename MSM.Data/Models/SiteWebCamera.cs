using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class SiteWebCamera
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string Protocol { get; set; }
        public string CameraType { get; set; }
        public string CameraDescription { get; set; }
        public string WebCameraIp { get; set; }
        public int? WebCameraPort { get; set; }
        public string WebCameraUid { get; set; }
        public string WebCameraPwd { get; set; }
        public string QueryString { get; set; }
        public byte? CameraStatus { get; set; }

        public Site Site { get; set; }
    }
}
