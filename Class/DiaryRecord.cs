using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDiary.Class
{
    public class DiaryRecord
    {
        public int RecordID { get; set; }
        public int UserID { get; set; }
        public string Class { get; set; }
        public string Homework { get; set; }
        public int LessonID { get; set; }
        public DateTime Date { get; set; }
        public int Grade { get; set; }
    }
}
