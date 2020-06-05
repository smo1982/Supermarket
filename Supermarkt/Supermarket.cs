using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarkt
{
    public partial class Supermarket : Form
    {
        Dictionary<string, int> productsAndValue = new Dictionary<string, int>();
        public Supermarket()
        {

            InitializeComponent();
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            string product = tbInsertProducts.Text;
            string valueProduct = tbInsertValue.Text;

            if (!string.IsNullOrEmpty(product) && !string.IsNullOrEmpty(valueProduct))
            {
                int value;
                int.TryParse(valueProduct, out value);
                for (int i = 0; i < productsAndValue.Count; i++)
                {
                    if (productsAndValue.Keys.ElementAt(i) == product)
                    {
                        int valueOfProductKey = productsAndValue.Values.ElementAt(i);
                        value += valueOfProductKey;
                        productsAndValue.Remove(product);
                    }
                }
                productsAndValue.Add(product, value);
                UpdateTranslations();
            }
        }

        private void UpdateTranslations()
        {
            List<string> productKeys = new List<string>();

            for (int i = 0; i < productsAndValue.Count; i++)
            {
                int value = productsAndValue.Values.ElementAt(i);
                string product = productsAndValue.Keys.ElementAt(i);
                Convert.ToString(value);
                string finish = ($"{product} ({value})");
                productKeys.Add(finish);
            }
            lBoxProducts.DataSource = productKeys;

        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            string product = tbInsertProducts.Text;
            string valueProduct = tbInsertValue.Text;

            if (!string.IsNullOrEmpty(product) && !string.IsNullOrEmpty(valueProduct))
            {
                int value;
                int.TryParse(valueProduct, out value);
                for (int i = 0; i < productsAndValue.Count; i++)
                {
                    if (productsAndValue.Keys.ElementAt(i) == product)
                    {
                        int valueOfProductKey = productsAndValue.Values.ElementAt(i);
                        value = valueOfProductKey - value;
                        productsAndValue.Remove(product);
                    }
                }
                productsAndValue.Add(product, value);
                UpdateTranslations();
            }
        }
    }
}
