using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace MMForm
{
    public partial class Form1 : Form
    {
        public List<GundataInfo> listGun = new List<GundataInfo>();
        private string tempheader = string.Empty;
        private string _gunCsv = "";
        private string _playerdatafile = "";
        private string _mapFolderPath = "";
        private PlayerData _player;
        private MapData mapdata;

        public Form1()
        {
            InitializeComponent();
            InitGunOlv();
            InitPlayerSaveDataLv();
            InitMapOlv();
            WindowState = FormWindowState.Maximized;

            _gunCsv = ConfigurationManager.AppSettings["gunpath"];
            _playerdatafile = ConfigurationManager.AppSettings["playerpath"];
            _mapFolderPath = ConfigurationManager.AppSettings["mappath"];
            gunPathData_tbx.Text = _gunCsv;
            playerdatafile_tbx.Text = _playerdatafile;
            mapFolder_tbx.Text = _mapFolderPath;
        }

        private void InitMapOlv()
        {
            ObjectListViewHelper.AddColumnForOlv(typeof(BotInfo), bot_olv);
            bot_olv.ShowGroups = false;
            bot_olv.GridLines = true;
            bot_olv.FullRowSelect = true;
            var lColumn = ReflectionUtils.PropertysFromType(new BotInfo());
            botColumn_cbx.Items.Clear();
            foreach (var propertyInfo in lColumn)
            {
                botColumn_cbx.Items.Add(propertyInfo.Name);
            }
            ObjectListViewHelper.AddColumnForOlv(typeof(ItemInfo), item_olv);
            item_olv.ShowGroups = false;
            item_olv.GridLines = true;
            item_olv.FullRowSelect = true;
            itemmap_cbx.Items.AddRange(listItemTemplate);
        }

        private void InitPlayerSaveDataLv()
        {
            ObjectListViewHelper.AddColumnForOlv(typeof(MapSaveData), playersaveObjec_lv);
            playersaveObjec_lv.ShowGroups = false;
            playersaveObjec_lv.GridLines = true;
            playersaveObjec_lv.FullRowSelect = true;
        }

        private void InitGun_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var num = int.Parse(value_tbx.Text);
                listGun.Clear();
                for (int i = 0; i < num; i++)
                {
                    var item = new GundataInfo();
                    item.Id = i;
                    item.Name = "Gun" + i;
                    listGun.Add(item);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Text value is not valid");
            }


        }

        private void InitGunOlv()
        {
            var lColumn = ReflectionUtils.PropertysFromType(new GundataInfo());
            var i = 0;
            nameGun_cbx.Items.Clear();
            #region colum with image
            //var colImage = new BrightIdeasSoftware.OLVColumn();
            //colImage.AspectToStringConverter = delegate(Object obj) { return string.Empty; };
            //colImage.AspectGetter = delegate(Object obj)
            //{
            //    var gun = obj as GundataInfo;
            //    return (gun.Name + ".png").ToLower();
            //};
            //colImage.ImageGetter = delegate(Object obj)
            //{
            //    var gun = obj as GundataInfo;
            //    if (imageList1.Images.ContainsKey((gun.Name + ".png").ToLower()))
            //    {

            //        return (gun.Name + ".png").ToLower();
            //    }
            //    return string.Empty;

            //};
            //colImage.IsEditable = false;
            //colImage.Renderer=new ImageRenderer(false);
            ////colImage.ImageList = imageList1;
            ////gunListView.LargeImageList = imageList1;
            ////gunListView.SmallImageList = imageList1;
            ////gunListView.OwnerDraw = true;
            //gunListView.AllColumns.Add(colImage);
            //gunListView.Columns.Add(colImage);
            #endregion
            //lColumn = lColumn.OrderByDescending(o => o.Name).ToArray();
            foreach (var colN in lColumn)
            {
                var col = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
                col.AspectName = colN.Name;
                col.DisplayIndex = i++;
                col.Text = colN.Name;
                col.IsEditable = true;
                if (colN.PropertyType.FullName == "System.Boolean")
                {
                    col.CheckBoxes = true;
                }
                if (colN.PropertyType.FullName == "System.Single")
                {
                    var colName = colN.Name;
                    col.AspectPutter = delegate(Object row, Object newvalue)
                    {
                        ReflectionUtils.SetPropertyInternal(row, colName, float.Parse(newvalue.ToString()));
                    };
                }
                nameGun_cbx.Items.Add(colN.Name);
                gunListView.AllColumns.Add(col);
                gunListView.Columns.Add(col);
            }

            gunListView.ShowGroups = false;
            gunListView.GridLines = true;
            gunListView.FullRowSelect = true;
            gunListView.SetObjects(listGun);
        }

        void LoadGunFile()
        {
            if (File.Exists(_gunCsv))
            {
                var data = File.ReadAllLines(_gunCsv);
                var tempList = new List<GundataInfo>();
                var errorindex = 0;
                var index = 0;
                tempheader = "";
                foreach (var line in data)
                {
                    var item = new GundataInfo();
                    try
                    {
                        if (line.StartsWith("#") || line.StartsWith("|"))
                        {
                            tempheader += line + "\r\n";
                            continue;
                        }
                        item = new GundataInfo();
                        var gdata = line.Split(',');
                        index = 0;
                        item.Id = int.Parse(gdata[index++]);
                        errorindex = item.Id;
                        item.Name = gdata[index++];
                        item.Sx = float.Parse(gdata[index++]);
                        item.Sy = float.Parse(gdata[index++]);
                        item.TimeShootLimit = float.Parse(gdata[index++]);
                        item.Cx = float.Parse(gdata[index++]);
                        item.Cy = float.Parse(gdata[index++]);
                        item.BulletQuantity = int.Parse(gdata[index++]);
                        item.BulletType = int.Parse(gdata[index++]);
                        item.BulletPrefTab = int.Parse(gdata[index++]);
                        item.ShootEffectType = int.Parse(gdata[index++]);
                        item.ShootSpecialEffectType = int.Parse(gdata[index++]);
                        item.Damage = float.Parse(gdata[index++]);
                        item.Force = float.Parse(gdata[index++]);
                        item.IsGun = int.Parse(gdata[index++]) == 1;
                        item.OneShotNumBullet = int.Parse(gdata[index++]);
                        item.AngleChange = float.Parse(gdata[index++]);
                        item.DelayEffect = float.Parse(gdata[index++]);
                        item.BeatDistance = float.Parse(gdata[index++]);
                        item.WeaponRadius = float.Parse(gdata[index++]);
                        item.ReloadBulletTime = float.Parse(gdata[index++]);
                        item.BulletRadius = float.Parse(gdata[index++]);
                        item.SoundId = gdata[index++];
                    }
                    catch (Exception)
                    {
                        LogText("Gun Error in " + errorindex);
                        //throw;
                    }
                    finally
                    {
                        tempList.Add(item);
                    }


                }
                listGun.Clear();
                listGun.AddRange(tempList);
                gunListView.SetObjects(listGun);

            }

        }

        void SaveGunFile()
        {

            var stringBuilder = new StringBuilder();
            stringBuilder.Append(tempheader);
            var index = 0;
            var errorindex = 0;
            foreach (var item in listGun)
            {
                try
                {
                    var gdata = new List<string>();
                    errorindex = item.Id;
                    gdata.Add(item.Id.ToString());
                    gdata.Add(item.Name.ToString());
                    gdata.Add(item.Sx.ToString());
                    gdata.Add(item.Sy.ToString());
                    gdata.Add(item.TimeShootLimit.ToString());
                    gdata.Add(item.Cx.ToString());
                    gdata.Add(item.Cy.ToString());
                    gdata.Add(item.BulletQuantity.ToString());
                    gdata.Add(item.BulletType.ToString());
                    gdata.Add(item.BulletPrefTab.ToString());
                    gdata.Add(item.ShootEffectType.ToString());
                    gdata.Add(item.ShootSpecialEffectType.ToString());
                    gdata.Add(item.Damage.ToString());
                    gdata.Add(item.Force.ToString());
                    gdata.Add(item.IsGun ? "1" : "0");
                    gdata.Add(item.OneShotNumBullet.ToString());
                    gdata.Add(item.AngleChange.ToString());
                    gdata.Add(item.DelayEffect.ToString());
                    gdata.Add(item.BeatDistance.ToString());
                    gdata.Add(item.WeaponRadius.ToString());
                    gdata.Add(item.ReloadBulletTime.ToString());
                    gdata.Add(item.BulletRadius.ToString());
                    gdata.Add(item.SoundId);


                    stringBuilder.AppendLine(string.Join(",", gdata) + ",");
                }
                catch (Exception)
                {
                    LogText("Gun Error in " + errorindex);
                    throw;
                }
            }

            File.WriteAllText(_gunCsv, stringBuilder.ToString());
        }

        public void LogText(string message)
        {
            log_rtb.Invoke(((MethodInvoker)delegate
            {
                log_rtb.AppendText(String.Format("-{0}: \r\n", message));
            }));
        }


        protected void ClearText()
        {
            if (log_rtb != null) log_rtb.Clear();
        }

        private void SaveGun_btn_Click(object sender, EventArgs e)
        {
            SaveGunFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadGunFile();
        }

        private void gunListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunListView.SelectedObject != null)
            {
                var obj = gunListView.SelectedObject as GundataInfo;
                var path = string.Format("./image/gun{0}.png", obj.Id).ToLower();
                if (File.Exists(path))
                {
                    var image = Image.FromFile(path);

                    var g = panel1.CreateGraphics();
                    g.Clear(Color.White);
                    g.DrawImage(image, new Point(0, 0));
                }
                else
                    MessageBox.Show("Image not found");
            }
        }

        private void fillGun_btn_Click(object sender, EventArgs e)
        {

            try
            {
                var name = nameGun_cbx.SelectedItem.ToString();
                var value = value_tbx.Text.Trim();
                int tempint = 0;
                object vl = ObjectListViewHelper.ParseStringForObjectValue(value, typeof(GundataInfo), name);

                foreach (var gundataInfo in listGun)
                {
                    ReflectionUtils.SetPropertyInternal(gundataInfo, name, vl);
                }

                gunListView.SetObjects(listGun);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void addgun_btn_Click(object sender, EventArgs e)
        {
            var gun = new GundataInfo();
            listGun.Add(gun);
            gunListView.SetObjects(listGun);
        }

        private void removegun_btn_Click(object sender, EventArgs e)
        {
            if (gunListView.SelectedObject != null)
            {
                var obj = gunListView.SelectedObject as GundataInfo;
                if (listGun.Contains(obj))
                {
                    listGun.Remove(obj);
                    gunListView.SetObjects(listGun);
                }
            }
        }

        private void LoadPlaye_btn_Click(object sender, EventArgs e)
        {
            if (File.Exists(playerdatafile_tbx.Text))
            {
                var str = File.ReadAllText(playerdatafile_tbx.Text);
                _player = PlayerData.ParsePlayerData(str);
                if (_player != null)
                {

                    playersaveObjec_lv.SetObjects(_player.Mapdata);
                    player_tbx.Text = string.Format("{0},{1},{2},{3}", _player.Id, _player.PlayerName, _player.Skin,
                        _player.IsFirst);
                    setting_tbx.Text = _player.Setting;
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
        }

        private void SavePlayer_btn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(_playerdatafile, _player.GetSaveData());
        }

        private void LoadMap_btn_Click(object sender, EventArgs e)
        {
            var filePath = Path.Combine(mapFolder_tbx.Text, "map" + mapid_tbx.Text + ".txt");
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Not Found File");
                return;
            }
            var data = File.ReadAllText(filePath);
            var lData = data.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            var curData = 0;
            mapdata = new MapData();
            mapdata.BotDataItem = new List<string>();
            mapdata.ItemData = new List<string>();
            mapdata.ResourceData = new List<string>();
            foreach (var line in lData)
            {

                try
                {

                    if (string.IsNullOrEmpty(line) || line.StartsWith("##")) continue;
                    switch (line.Trim())
                    {
                        case "#map":
                            curData = 1;
                            break;
                        case "#player":
                            curData = 2;
                            break;
                        case "#bot":
                            curData = 3;
                            break;
                        case "#item":
                            curData = 4;
                            break;
                        case "#resource":
                            curData = 5;
                            break;
                        default:
                            switch (curData)
                            {
                                case 1:
                                    var smapData = line.Split(',');
                                    mapdata.MapId = int.Parse(smapData[0]);
                                    mapdata.MapName = smapData[1];
                                    mapdata.MapType = int.Parse(smapData[2]);
                                    mapdata.MapSound = smapData[3];
                                    break;
                                case 2:
                                    var index = 0;
                                    var playerData = line.Split(',');
                                    mapdata.px = float.Parse(playerData[index++]);
                                    mapdata.py = float.Parse(playerData[index++]);
                                    ;
                                    mapdata.Weaponid = int.Parse(playerData[index++]);
                                    mapdata.SecondWeaponId = int.Parse(playerData[index++]);
                                    break;
                                case 3:
                                    mapdata.BotDataItem.Add(line);
                                    break;
                                case 4:
                                    mapdata.ItemData.Add(line);
                                    break;
                                case 5:
                                    mapdata.ResourceData.Add(line);
                                    break;
                            }

                            break;
                    }
                }
                catch (Exception)
                {
                    //GameDebug.LogError(string.Format(" Map{0} error" + "line number {1} line : {2}", id, linenumber, line));
                }

                var templist = new List<BotInfo>();
                for (int i = 0; i < mapdata.BotDataItem.Count; i++)
                {
                    var bot = BotInfo.ParseBot(mapdata.BotDataItem[i]);
                    if (bot != null) templist.Add(bot);
                }
                mapdata.ListBot = templist;
                var templist2 = new List<ItemInfo>();
                for (int i = 0; i < mapdata.ItemData.Count; i++)
                {
                    var item = ItemInfo.ParseItemInfo(mapdata.ItemData[i]);
                    if (item != null) templist2.Add(item);
                }
                mapdata.ListItem = templist2;
            }
            item_olv.SetObjects(mapdata.ListItem);
            bot_olv.SetObjects(mapdata.ListBot);
            mapname_tbx.Text=mapdata.MapName ;
            maptype_tbx.Text=mapdata.MapType.ToString() ;
            mapSound_tbx.Text=mapdata.MapSound;
            playerx_tbx.Text = mapdata.px.ToString();
            playery_tbx.Text=mapdata.py.ToString();
            weapon_tbx.Text = mapdata.Weaponid.ToString();
            secondwpd_tbx.Text = mapdata.SecondWeaponId.ToString();
            playerdata_tbx.Text=mapdata.Playerdata ;
        }

        private void SaveMap_btn_Click(object sender, EventArgs e)
        {
            var filePath = Path.Combine(mapFolder_tbx.Text, "map" + mapid_tbx.Text + ".txt");
            File.WriteAllText(filePath, mapdata.GetMapForWrite());
        }

        private void fillbotColumn_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var name = botColumn_cbx.SelectedItem.ToString();
                var value = filBotValue_tbx.Text.Trim();
                object vl = ObjectListViewHelper.ParseStringForObjectValue(value, typeof(BotInfo), name);
                foreach (var bot in mapdata.ListBot)
                {
                    ReflectionUtils.SetPropertyInternal(bot, name, vl);
                }

                bot_olv.SetObjects(mapdata.ListBot);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bot_olv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bot_olv.SelectedObject != null)
            {
                try
                {
                    var obj = bot_olv.SelectedObject as BotInfo;
                    if (obj != null) mPaintPlayer(obj.Skin,obj.Weaponid.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("K0 ve~ hinh dc");
                }
            }
        }
        private string GetPath(string type, int id)
        {
            const string path = "./image/char/{0}_frame_{1}.png";
            return string.Format(path, type, id);
        }
        public void mPaintPlayer(string skin,string weaponid)
        {
            int[] lv = new[] { 77, 40, 47, 0, 82, 51, 74, 39, 81, 97, 81, 96 };
            var skinController = new SkinController();
            skinController.SetSkin(skin);
            var bodyimage = Image.FromFile(GetPath("body", skinController.CBody));
            var headimage = Image.FromFile(GetPath("head", skinController.Chead));


            var g = botskin_pnl.CreateGraphics();
            g.Clear(Color.White);
            g.DrawImage(bodyimage, new Point(lv[8], lv[9]));
            g.DrawImage(headimage, new Point(lv[0], lv[1]));

            if (skinController.Cglass >= 0)
            {
                var glassimage = Image.FromFile(GetPath("glass", skinController.Cglass));
                g.DrawImage(glassimage, new Point(lv[4], lv[5]));
            }
            if (skinController.Cshirt >= 0)
            {
                var shirtimage = Image.FromFile(GetPath("shirt", skinController.Cshirt));
                g.DrawImage(shirtimage, new Point(lv[8], lv[9]));
            }
            if (skinController.Cskirt >= 0)
            {
                var skirtimage = Image.FromFile(GetPath("skirt", skinController.Cskirt));
                //MessageBox.Show(_SkinController.Cskirt.ToString());
                g.DrawImage(skirtimage, new Point(lv[10], lv[11]));
            }
            if (skinController.Cbear >= 0)
            {
                var bearimage = Image.FromFile(GetPath("bear", skinController.Cbear));
                g.DrawImage(bearimage, new Point(lv[6], lv[7]));
            }
            if (skinController.Chat >= 0)
            {
                var hatimage = Image.FromFile(GetPath("hat", skinController.Chat));
                g.DrawImage(hatimage, new Point(lv[2], lv[3]));
            }

            var path = string.Format("./image/gun{0}.png", weaponid).ToLower();
            if (File.Exists(path))
            {
                var image = Image.FromFile(path);
                g.DrawImage(image, new Point(lv[10]-10, lv[11]+10));
            }

        }

        private void EditSkin_btn_Click(object sender, EventArgs e)
        {
            if (bot_olv.SelectedObject != null)
            {
                try
                {
                    var obj = bot_olv.SelectedObject as BotInfo;
                    var form = new FormSkinEdit();
                    form.SetSkin(obj.Skin);
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        obj.Skin = form.GetSkin();
                        mPaintPlayer(obj.Skin,obj.Weaponid.ToString());
                        bot_olv.SetObjects(mapdata.ListBot);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("K0 ve~ hinh dc");
                }
            }
        }

        private void EditCommand_btn_Click(object sender, EventArgs e)
        {
            if (bot_olv.SelectedObject != null)
            {
                try
                {
                    var obj = bot_olv.SelectedObject as BotInfo;
                    var form = new FormEditCommand();
                    form.ParseCommand(obj.Data);
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        obj.Data = form.GetCommand();
                        bot_olv.SetObjects(mapdata.ListBot);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("K0 ve~ hinh dc");
                }
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            if (mapdata.ListItem == null) return;
            if (itemmap_cbx.SelectedItem == null)
            {
                var item = new ItemInfo();
                item.Id = mapdata.ListItem.Count;
                mapdata.ListItem.Add(item);
            }
            else
            {
                var item = (itemmap_cbx.SelectedItem as ItemInfo).Clone();

                item.Id = mapdata.ListItem.Count;
                mapdata.ListItem.Add(item);
            }
            item_olv.SetObjects(mapdata.ListItem);
        }

        ItemInfo[] listItemTemplate = new ItemInfo[] { ItemInfo.WeapontemInfo(), ItemInfo.BloodItemInfo(), ItemInfo.LifeItemInfo(), ItemInfo.BulletItemInfo(), ItemInfo.FlyBagItemInfo() };
        private void RemoveItem_btn_Click(object sender, EventArgs e)
        {
            if (item_olv.SelectedObject != null)
            {
                try
                {
                    var obj = item_olv.SelectedObject as ItemInfo;
                    mapdata.ListItem.Remove(obj);
                    item_olv.SetObjects(mapdata.ListItem);
                }
                catch (Exception)
                {
                    MessageBox.Show("K0 ve~ hinh dc");
                }
            }
        }

        private void UpdateMap_btn_Click(object sender, EventArgs e)
        {
            mapdata.MapName = mapname_tbx.Text;
            mapdata.MapType = int.Parse(maptype_tbx.Text);
            mapdata.MapSound = mapSound_tbx.Text;
            mapdata.px = float.Parse(playerx_tbx.Text);
            mapdata.py = float.Parse(playery_tbx.Text);
            mapdata.Weaponid = int.Parse(weapon_tbx.Text);
            mapdata.SecondWeaponId = int.Parse(secondwpd_tbx.Text);
            mapdata.Playerdata = playerdata_tbx.Text;
        }

    }

}
