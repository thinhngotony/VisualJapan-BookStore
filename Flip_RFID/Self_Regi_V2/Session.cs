using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SelfRegi_V2.Front;

namespace SelfRegi_V2
{
    class Session
    {

        //RFID//////RFID//////RFID//////RFID//////RFID//////RFID//////RFID//////RFID//////RFID//////RFID//////RFID//
        public static AxOPOSRFIDLib.AxOPOSRFID OPOSRFID1 = new AxOPOSRFIDLib.AxOPOSRFID();
        public static Front front;
        public static string device_name = "";
        public static string rfidcode = "";
        //E280689400005017E3139C39
        //E280689400004017E313F439
        public static string barcode = "";
        //9784003102787
        public static int rT = 500;
        public static bool force_update = true;

        //API//////API//////API//////API//////API//////API//////API//////API//////API//////API//////API//////API////
        public static string address_api = "";
        public static string rfmaster_sub = "";
        public static string rfmaster_sub_delete = "";
        public static string rfmaster_sub_rfids_to_jans = "";
        public static string rfmaster_key = "";

        public static string image_api = "";
        public static string image_sub = "";

        public static string sub_set_smart_self_setting = "";
        public static string sub_get_smart_self_setting = "";



        public static string bquery_api = "";
        public static string bquery_sub = "";
        public static string bquery_key = "";

        public static string SHOPCD = "";
        public static string reload = "";

        public static string sync_api = "";
        public static string sync_sub = "";
        //readCSV//////readCSV//////readCSV//////readCSV//////readCSV//////readCSV//////readCSV//////readCSV////
        public static string path = "";


        public static string scanner_name = "";

        public static ProductData product = new ProductData();

        public static Dictionary<string, ProductPos> productPos = new Dictionary<string, ProductPos>();


        public static Dictionary<string, (int row, int col)> positionPos = new Dictionary<string, (int, int)>()
        {
            { "pictureBox_1_1" , (1,1) },
            { "pictureBox_1_2" , (1,2) },
            { "pictureBox_1_3" , (1,3) },
            { "pictureBox_1_4" , (1,4) },
            { "pictureBox_1_5" , (1,5) },
            { "pictureBox_1_6" , (1,6) },
            { "pictureBox_2_1" , (2,1) },
            { "pictureBox_2_2" , (2,2) },
            { "pictureBox_2_3" , (2,3) },
            { "pictureBox_2_4" , (2,4) },
            { "pictureBox_2_5" , (2,5) },
            { "pictureBox_2_6" , (2,6) },
            { "pictureBox_3_1" , (3,1) },
            { "pictureBox_3_2" , (3,2) },
            { "pictureBox_3_3" , (3,3) },
            { "pictureBox_3_4" , (3,4) },
            { "pictureBox_3_5" , (3,5) },
            { "pictureBox_3_6" , (3,6) },
            { "pictureBox_4_1" , (4,1) },
            { "pictureBox_4_2" , (4,2) },
            { "pictureBox_4_3" , (4,3) },
            { "pictureBox_4_4" , (4,4) },
            { "pictureBox_4_5" , (4,5) },
            { "pictureBox_4_6" , (4,6) }

        };

        //BarcodeFormat//////BarcodeFormat//////BarcodeFormat//////BarcodeFormat//////BarcodeFormat//////BarcodeFormat////
        public static int JanLen = 13;
    }
}
