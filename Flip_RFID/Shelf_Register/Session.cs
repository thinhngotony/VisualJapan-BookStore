﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Shelf_Register.Front;

namespace Shelf_Register
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
        public static string sub_rfid_to_status_smart_self = ""; 
        public static string sub_get_smart_self_names = "";

        public static List <string> smart_shelf_names = new List<string>();





        public static string bquery_api = "";
        public static string bquery_sub = "";
        public static string api_key = "";

        public static string SHOPCD = "";
        public static string reload = "";

        public static string sync_api = "";
        public static string sync_sub = "";
        //readCSV//////readCSV//////readCSV//////readCSV//////readCSV//////readCSV//////readCSV//////readCSV////
        public static string path = "";

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

        public static Dictionary<string , string> mappingTextBox = new Dictionary<string, string >()
        {
            { "pictureBox_1_1" ,"textBox_1_1"},
            { "pictureBox_1_2" ,"textBox_1_2"},
            { "pictureBox_1_3" ,"textBox_1_3"},
            { "pictureBox_1_4" ,"textBox_1_4"},
            { "pictureBox_1_5" ,"textBox_1_5"},
            { "pictureBox_1_6" ,"textBox_1_6"},
            { "pictureBox_2_1" ,"textBox_2_1"},
            { "pictureBox_2_2" ,"textBox_2_2"},
            { "pictureBox_2_3" ,"textBox_2_3"},
            { "pictureBox_2_4" ,"textBox_2_4"},
            { "pictureBox_2_5" ,"textBox_2_5"},
            { "pictureBox_2_6" ,"textBox_2_6"},
            { "pictureBox_3_1" ,"textBox_3_1"},
            { "pictureBox_3_2" ,"textBox_3_2"},
            { "pictureBox_3_3" ,"textBox_3_3"},
            { "pictureBox_3_4" ,"textBox_3_4"},
            { "pictureBox_3_5" ,"textBox_3_5"},
            { "pictureBox_3_6" ,"textBox_3_6"},
            { "pictureBox_4_1" ,"textBox_4_1"},
            { "pictureBox_4_2" ,"textBox_4_2"},
            { "pictureBox_4_3" ,"textBox_4_3"},
            { "pictureBox_4_4" ,"textBox_4_4"},
            { "pictureBox_4_5" ,"textBox_4_5"},
            { "pictureBox_4_6" ,"textBox_4_6"}
        };




        //BarcodeFormat//////BarcodeFormat//////BarcodeFormat//////BarcodeFormat//////BarcodeFormat//////BarcodeFormat////
        public static int JanLen = 13;
        public static string key_drawtext = "";
        public static string display_time = "";
        public static int time = 10;
        public static bool status_mode = false;
    }
}
