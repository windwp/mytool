using System.Collections.Generic;
using System.Text;

namespace MMForm
{
    public class MapData
    {

        public int MapId;
        public string MapName;
        public int MapType;
        public string MapSound;
        public string MapCData;

        public float px;
        public float py;
        public int Weaponid;
        public int SecondWeaponId;
        public float Maxhp;
        public int Life;
        public string Playerdata;
        public List<string> BotDataItem;
        public List<string> ItemData;
        public List<string> ResourceData;

        public List<BotInfo> ListBot;
        public List<ItemInfo> ListItem;

        public string GetMapForWrite()
        {

            var strb = new StringBuilder();
            strb.AppendLine("#map");
            strb.AppendFormat("{0},{1},{2},{3},{4},\r\n", MapId, MapName, MapType, MapSound, MapCData);
            strb.AppendLine();
            strb.AppendLine("#player");
            strb.AppendFormat("{0},{1},{2},{3},{4},{5},{6}", px, py, Weaponid, SecondWeaponId,Maxhp,Life,Playerdata);
            strb.AppendLine();
            strb.AppendLine("#bot");
            foreach (var botitem in ListBot)
            {
                strb.Append(botitem.ToSaveString());
                strb.AppendLine();
            }
            strb.AppendLine("#item");
            foreach (var item in ListItem)
            {
                strb.Append(item.ToSaveString());
                strb.AppendLine();
            }
            strb.AppendLine("#resource");
            foreach (var resource in ResourceData)
            {
                strb.Append(resource);
                strb.AppendLine();
            }

            return strb.ToString();
        }
    }
}
