using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Dictionary<string, int> shoppingList = new Dictionary<string, int>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = tbProduct.Text;
           
            int.TryParse(tbAmount.Text, out var amount);

            if (!string.IsNullOrEmpty(item) && (amount > 0))
            {
                if (shoppingList.ContainsKey(item))
                {
                    shoppingList[item] += amount;
                }
                else
                {
                    shoppingList.Add(item, amount);
                }
            }
            updateShoppinglist();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string item = tbProduct.Text;
            int.TryParse(tbAmount.Text, out var amount);

            if (!string.IsNullOrEmpty(item) && (amount > 0))
            {
                if (shoppingList.ContainsKey(item))
                {                   

                    if (amount >= shoppingList[item])
                    {
                        shoppingList.Remove(item);
                    } else
                    {
                        shoppingList[item] -= amount;
                    }
                }
            }
            updateShoppinglist();
        }

        private void updateShoppinglist()
        {
            shoppingList = SortDictionary(shoppingList);
            string[] list = new string[shoppingList.Count];
            int counter = 0;
            foreach (KeyValuePair<string, int> entry in shoppingList)
            {
                string item = entry.Value.ToString() + "x " + entry.Key;
                list[counter] = item;
                counter++;
            }
            lbItems.DataSource = list.ToList();
        }

        private Dictionary<string, int> SortDictionary(Dictionary<string, int> dictionary)
        {
            List<string> items = new List<string>(dictionary.Keys);
            items.Sort();
            Dictionary<string, int> orderedDictionary = new Dictionary<string, int>();

            foreach (var key in items)
            {
                orderedDictionary.Add(key, dictionary[key]);
            }
            return orderedDictionary;
        }
    }   
}

