namespace MMForm
{
    public class MapSaveData
    {
        public int ID { get; set; }
        public bool IsFinish { get; set; }
        public bool IsShow { get; set; }
        public bool IsLocked{ get; set; }
        public string MapName { get; set; }
        public int MapStar { get; set; }
        public int MapPoint { get; set; }
        public string MapData { get; set; }
        public string SaveDataString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", ID, MapName, MapStar, MapPoint, IsFinish ? 1 : 0,
                IsShow ? 1 : 0, IsLocked ? 1 : 0, MapData);
        }
        /// <summary>
        /// id,name,star,point,isfinish,isshow,islocked,data
        /// string.Format("{0},{1},{2},{3},{4}",ID,IsFinish?1:0,MapName,MapStar,MapData); 
        /// </summary>
        /// <param name="mapdata"></param>
        /// <returns></returns>
        public static  MapSaveData Parse(string mapdata)
        {
            var lst = mapdata.Split(',');
            var map = new MapSaveData();
            var index = 0;
            if (lst.Length <= 6) return null;
            map.ID = int.Parse(lst[index++]);
            map.MapName = lst[index++];
            map.MapStar = int.Parse(lst[index++]);
            map.MapPoint = int.Parse(lst[index++]);
            map.IsFinish = lst[index++] == "1";
            map.IsShow = lst[index++] == "1";
            map.IsLocked = lst[index++] == "1";
            map.MapData = lst[index];
            return map;
        }
    }
}
