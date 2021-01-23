using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    //U:Ürün
    //A:Adet
    class Dictionary<U>  //Generic Class
    {
        U[] items;

        // class new olunca MyList otomatik çalışır
        public Dictionary()
        {
            items = new U[0];
           }

        public void Add(U item)
        {
            U[] tempItem = items;
            items = new U[items.Length + 1];
            for (int i = 0; i < tempItem.Length; i++)
            {
                items[i] = tempItem[i];
            }
            items[items.Length - 1] = item;

        }
        public U[] Items
        {
            get { return items; }
        }

    }
}
