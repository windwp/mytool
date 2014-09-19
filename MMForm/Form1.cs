using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        public Form1()
        {
            InitializeComponent();
            InitGunOlv();
            WindowState = FormWindowState.Maximized;
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
            if (File.Exists("./gun.csv"))
            {
                var data = File.ReadAllLines("./gun.csv");
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
                        item=new GundataInfo();
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
                    gdata.Add(item.IsGun?"1":"0");
                    stringBuilder.AppendLine(string.Join(",", gdata) + ",");
                }
                catch (Exception)
                {
                    LogText("Gun Error in " + errorindex);
                    throw;
                }
            }

            File.WriteAllText("./gun.csv", stringBuilder.ToString());
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
                object vl;
                if (value.Contains("f"))
                {
                    vl = float.Parse(value.Replace("f", ""));
                }
                else if (int.TryParse(value, out tempint))
                {
                    vl = int.Parse(value);
                }
                else if (value.ToLower() == "true" || value.ToLower() == "false")
                {
                    vl = value == "true";
                }
                else
                {
                    vl = value;
                }

                foreach (var gundataInfo in listGun)
                {
                    if (vl != null) ReflectionUtils.SetPropertyInternal(gundataInfo, name, vl);
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
    }

}
