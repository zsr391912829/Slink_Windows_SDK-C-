using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slink_Demo
{
    class Slink_Dev_Info
    {

        String dev_ID;

        int state;
        String[] key_name;
        String[] key_value;
        int key_num;

        public Slink_Dev_Info()
        {

        }
    }


    class Slink
    {
        Slink_Dev_Info[] Slink_Dev_Info;

        public Slink(int udp_port,int dev_over_time_s)
        {
            Slink_Dev_Info = new Slink_Dev_Info[12];

        }

        public int Slink_get_dev_num() {


            return 0;
        }

        public int Slink_send_to_dev(String sendstr) {

            return 0;       
        }

        public void Slink_reg_recv_cb() { 
        
        
        }

        public void Slink_get_dev_Info(int dev_ID) { 
        
        
        }

       
    }
}
