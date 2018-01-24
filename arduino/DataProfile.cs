using System;

namespace arduino
{
    class DataProfile
    {
        private int id = 0;
        private String name;
        private int delay;
        private String hourStart;
        private String hourEnd;
        public int Id { get; set; }
        public String Name { get; set; }
        public int Delay { get; set; }
        public String HourStart { get; set; }
        public String HourEnd { get; set; }
    }
}
