using System;
using System.Collections.Generic;

namespace arduino
{
    class ArduSerial
    {
        public ArduSerial()
        {

        }

        public static String SerialJoinProfiles(String scope, List<DataProfile> vars)
        {
            String ret = "*";
            foreach (var item in vars)
                ret += item.Id + "," + item.Name + "," + item.Delay + "," + item.HourStart + "," + item.HourEnd + "|";
            return ret + "#";
        }

        public static String SerialJoinUsers(String scope, List<DataUser> vars)
        {
            String ret = "*";
            foreach (var item in vars)
                ret += item.Id + "," + item.Name + "," + item.Pass + "," + item.Phone + "|";
            return ret + "#";
        }

        public List<DataUser> SerialSplit(String vars)
        {
            List<DataUser> ret = new List<DataUser>();
            String[] thisArray = vars.Split('|');
            foreach (var item in thisArray)
            {
                String[] otherArray = item.Split(',');
                ret.Add(new DataUser() { Id = Convert.ToInt16(otherArray[0]), Name = otherArray[1].ToString(), Pass = otherArray[2].ToString(), Phone = otherArray[3].ToString() });
            }
            return ret;
        }


        public static String SerialJoinProfile(List<DataProfile> vars)
        {
            String ret = "*";
            foreach (var item in vars)
                ret += item.Id + "," + item.Name + "," + item.Delay + "," + item.HourStart + "," + item.HourEnd + "|";
            return ret + "#";
        }

        public List<DataProfile> SerialSplitProfile(String vars)
        {
            List<DataProfile> ret = new List<DataProfile>();
            String[] thisArray = vars.Split('|');
            foreach (var item in thisArray)
            {
                String[] otherArray = item.Split(',');
                ret.Add(new DataProfile() { Id = Convert.ToInt16(otherArray[0]), Name = otherArray[1].ToString(), Delay = Convert.ToInt16(otherArray[2]), HourStart = otherArray[3].ToString(), HourEnd = otherArray[4].ToString() });
            }
            return ret;
        }

    }
}
