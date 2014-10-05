namespace MMForm
{
    public class ItemInfo
    {
        public int Id{ get; set; }
        public int BotId{ get; set; }
        public int ItemType{ get; set; }
        public string Itemdata{ get; set; }
        public float Time{ get; set; }
        public float px{ get; set; }
        public float py{ get; set; }
        public string ItemName { get; set; }
        public static ItemInfo ParseItemInfo(string itemdata)
        {
            try
            {
                var item = new ItemInfo();
                var sdata = itemdata.Split(',');
                var index = 0;
                item.Id = int.Parse(sdata[index++]);
                item.BotId = int.Parse(sdata[index++]);
                item.Time = float.Parse(sdata[index++]);
                item.ItemType = int.Parse(sdata[index++]);
                item.px = float.Parse(sdata[index++]);
                item.py = float.Parse(sdata[index++]);
                if (sdata.Length > index)
                {
                    item.Itemdata = string.Join(",", sdata, index, sdata.Length - index);
                }
                return item;
            }
            catch (System.Exception)
            {

                return null;
            }
        }

        public string ToSaveString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6}", Id, BotId, Time, ItemType, px, py, Itemdata);
        }


        public static ItemInfo WeapontemInfo()
        {
            var item = new ItemInfo();
            item.ItemType = 1;
            item.Itemdata = "1:1:1";
            item.ItemName = "Weapon";
            return item;
        }
        public static ItemInfo BloodItemInfo()
        {
            var item = new ItemInfo();
            item.ItemType = 2;
            item.Itemdata = "100";
            item.ItemName = "BLood";
            return item;
        }
        public static ItemInfo LifeItemInfo()
        {
            var item = new ItemInfo();
            item.ItemType = 3;
            item.Itemdata = "1";
            item.ItemName = "Life";
            return item;
        }
        public static ItemInfo BulletItemInfo()
        {
            var item = new ItemInfo();
            item.ItemType = 4;
            item.Itemdata = "";
            item.ItemName = "Bulllet";
            return item;
        }

        public static ItemInfo FlyBagItemInfo()
        {
            var item = new ItemInfo();
            item.ItemType = 5;
            item.Itemdata = "";
            item.ItemName = "FlyBag"; 
            return item;
        }

        public ItemInfo Clone()
        {
            var item = new ItemInfo();
            item.ItemName = ItemName;
            item.ItemType = ItemType;
            item.Itemdata = Itemdata;
            item.BotId = BotId;
            item.px = px;
            item.py = py;
            item.Time = Time;
            return item;
        }

        public override string ToString()
        {
            return ItemName;
        }
    }
}