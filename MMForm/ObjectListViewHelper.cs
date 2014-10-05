using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace MMForm
{
    public class ObjectListViewHelper
    {

        public static void AddColumnForOlv(Type type, ObjectListView olv)
        {
            olv.Columns.Clear();
            olv.AllColumns.Clear();
            var lColumn = ReflectionUtils.PropertysFromType(type);
            var i = 0;
            foreach (var colN in lColumn)
            {
                var col = new OLVColumn();
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
                olv.AllColumns.Add(col);
                olv.Columns.Add(col);
            }
        }

        /// <summary>
        /// Convert chuoi~ bat' ky` sang kieu du~ lieu. tuong ung cho thuoc. tinh' cua? 1 object
        /// </summary>
        /// <param name="value">Chuoi can gan' du~ lieu.</param>
        /// <param name="t">kieu du lieu cua doi' tuong</param>
        /// <param name="nameOfPropperty">ten cua? thuoc tinh' doi' tuong can` gan'</param>
        /// <returns></returns>
        public static object ParseStringForObjectValue(string value,Type t,string nameOfPropperty)
        {
            try
            {
                object result;
                var prop = t.GetProperty(nameOfPropperty);
                if (prop == null) return null;

                switch (prop.PropertyType.FullName)
                {
                    case "System.Boolean":
                         result = value.ToLower() == "true";
                        break;
                    case "System.Single":
                        result = float.Parse(value);
                        break;
                    case "System.Int32":
                        result = int.Parse(value);
                        break;
                    default:
                        result = string.Empty;
                        break;
                }
                return result;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return null;

        }
    }
}
