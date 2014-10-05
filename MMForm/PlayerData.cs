using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MMForm
{
    public class PlayerData
    {

        public string DataVersion { get; set; }
        public string PlayerName { get; set; }
        public string Id { get; set; }
        public string Data { get; set; }
        public string Setting { get; set; }
        public string Skin { get; set; }
        public bool IsFirst { get; set; }

        public List<MapSaveData> Mapdata;



        public string GetSaveData()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine(DataVersion);
            strBuilder.AppendLine("#player");
            strBuilder.AppendFormat("{0},{1},{2},{3},{4}", Id, PlayerName, Skin, IsFirst?"1":"0", Data);
            strBuilder.AppendLine();
            strBuilder.AppendLine("#setting");
            strBuilder.AppendLine(Setting);
            strBuilder.AppendLine("#mapdata");
            foreach (var mapSaveData in Mapdata)
            {
                strBuilder.AppendFormat(mapSaveData.SaveDataString());
                strBuilder.AppendLine();
            }
            return strBuilder.ToString();
        }

        private static PlayerData parseV1(string data)
        {
            var reader = new StringReader(data);
            var player = new PlayerData();
            player.Mapdata = new List<MapSaveData>();
            var pdata = reader.ReadLine();

            if (pdata != null)
            {
                pdata = pdata.Trim();
                player.DataVersion = pdata;
            }
            var index = 0;
            player.Mapdata = new List<MapSaveData>();
            var curdata = -1;
            while (index < 200)
            {
                pdata = reader.ReadLine();
                index += 1;
                if(string.IsNullOrEmpty(pdata))continue;;
                pdata = pdata.Trim();
                switch (pdata)
                {
                    case "#player":
                        curdata = 1;
                        break;
                    case "#setting":
                        curdata = 2;
                        break;
                    case "#mapdata":
                        curdata = 3;
                        break;
                    default:

                        switch (curdata)
                        {
                            case 1:
                                //read player
                                var dindex = 0;
                                var sdata = pdata.Split(',');
                                if (sdata.Length > 3)
                                {
                                    player.Id = sdata[dindex++];
                                    player.PlayerName = sdata[dindex++];
                                    player.Skin = sdata[dindex++];
                                    player.IsFirst = sdata[dindex++] == "1";
                                    player.Data = sdata[dindex++];
                                }
                                break;
                            case 2:
                                player.Setting = pdata;
                                break;
                            case 3:
                                var map = MapSaveData.Parse(pdata);
                                player.Mapdata.Add(map);
                                break;
                        }
                        break;
                }
            }
            if (index > 100)
            {
            }
            return player;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <exception cref="FormatException"></exception>
        /// <returns></returns>
        public static PlayerData ParsePlayerData(string data)
        {
            try
            {
                var reader = new StringReader(data);
                
                var pdata = reader.ReadLine();
                if (pdata != null)
                {
                    pdata = pdata.Trim();
                    string version = pdata;
                    if (version == "1.0.0")
                    {
                        var obj = parseV1(data);
                        return obj;
                    }
                }
                
            }
            catch (Exception)
            {
               //TODO add debug log
                return null;
            }
            return null;
        }


        public static PlayerData InitPlayerData()
        {
            var player = new PlayerData();
            player.Skin = "0:0:0:0:0:0:0";
            var listmap = new List<MapSaveData>();
            for (int i = 0; i < 10; i++)
            {
                listmap.Add(MapSaveData.Parse(string.Format("{0},{1},{2},{3},{4}", i, 1, i, 2, i)));
            }
            player.Mapdata = listmap;
            return player;
        }
    }
}
