using System;

namespace AkashicRecorder
{
    public class ClearData
    {
        public string event_id;
        public string start_time;   // UTC yyyy-MM-dd HH:mm:ss.fff
        public string end_time;     // UTC yyyy-MM-dd HH:mm:ss.fff
        public string event_name;
        public string rank_num;
        public string wallet_address;
    }
}