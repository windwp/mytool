using System;
using System.Text;

namespace MMForm
{
    public class BotInfo
    {
        public int Id { get; set; }
        public bool IsWatting { get; set; }
        public float Time { get; set; }
        public float px { get; set; }
        public float py { get; set; }
        public bool Dir { get; set; }
        public int Weaponid { get; set; }
        public int SecondWeaponId { get; set; }
        public string Skin { get; set; }
        public int Aitype { get; set; }
        public float Blood { get; set; }
        public int Bullet { get; set; }
        public int Bulletstack { get; set; }
        public float Speed { get; set; }
        public float DefaultAngle { get; set; }
        public int AngleDistance { get; set; }
        public int ShootingRate { get; set; }//Ti le ban' dan.
        public string Data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="botdata"></param>
        /// <returns></returns>
        public static BotInfo ParseBot(string botdata)
        {
            try
            {
                var bot = new BotInfo();
                var sdata = botdata.Split(',');
                var index = 0;
                bot.Id = int.Parse(sdata[index++]);
                bot.IsWatting = sdata[index++] == "1";
                bot.Time = float.Parse(sdata[index++]);
                bot.px = float.Parse(sdata[index++]);
                bot.py = float.Parse(sdata[index++]);
                bot.Dir = sdata[index++] == "1";
                bot.Weaponid = int.Parse(sdata[index++]);
                bot.SecondWeaponId = int.Parse(sdata[index++]);
                bot.Skin = sdata[index++];
                bot.Aitype = int.Parse(sdata[index++]);
                bot.Blood = float.Parse(sdata[index++]);
                bot.Bullet = int.Parse(sdata[index++]);
                bot.Bulletstack = int.Parse(sdata[index++]);
                bot.Speed = float.Parse(sdata[index++]);
                bot.DefaultAngle = float.Parse(sdata[index++]);
                bot.AngleDistance = int.Parse(sdata[index++]);
                bot.ShootingRate = int.Parse(sdata[index++]);
                bot.Data = sdata[index];

                return bot;
            }
            catch (System.Exception)
            {

                return null;
            }
        }


        public static BotInfo DefaultBot()
        {
            var bot = new BotInfo();
            bot.Id = 0;
            bot.IsWatting = false;
            bot.Time = 1;
            bot.px = 1;
            bot.py = -1;
            bot.Dir = true;
            bot.Weaponid = 1;
            bot.SecondWeaponId = 66;
            bot.Skin = "0:0:-1:-1:-1:-1:-1";
            bot.Aitype = 0;
            bot.Blood = 30;
            bot.Bulletstack = 1;
            bot.DefaultAngle = 0;
            bot.AngleDistance = 10;
            bot.ShootingRate = 10;
            bot.Data = "";
            return bot;
        }

        public static BotInfo RandomBot()
        {
            var bot = new BotInfo();
            bot.Id = 0;
            bot.IsWatting = false;
            bot.Time = 1;
            bot.px = new Random().Next(0, 5);
            bot.py = new Random().Next(0, 4);
            bot.Dir = true;
            bot.Weaponid = new Random().Next(0, 5);
            bot.SecondWeaponId = new Random().Next(0, 65);
            bot.Skin = "0:0:-1:-1:-1:-1:-1";
            bot.Aitype = 0;
            bot.Blood = 30;
            bot.Bulletstack = 1;
            bot.DefaultAngle = 0;
            bot.AngleDistance = 10;
            bot.ShootingRate = 10;
            bot.Data = "";
            return bot;
        }

        public string ToSaveString()
        {

            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}", Id
                , IsWatting ? "1" : "0", Time, px, py, Dir?"1":"0"
                 , Weaponid, SecondWeaponId, Skin, Aitype
                 , Blood,Bullet, Bulletstack,Speed, DefaultAngle, AngleDistance, ShootingRate, Data
                 );
        }
    }
}
