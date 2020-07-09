using System;
using System.Linq;
using System.Collections.Generic;

namespace InetStoreAccounting
{
    class Storage
    {
        Dictionary<Type, List<Item>> dict = new Dictionary<Type, List<Item>>();

        public void AddItem(Item item)
        {
            //todo
            //ask if type already added - just add to collection
            //else add type to collection and create list for items
            if (dict.ContainsKey(item.GetType()))
            {
                dict[item.GetType()].Add(item);
            } 
            else
            {
                List<Item> listItems = new List<Item>();
                listItems.Add(item);
                dict.Add(item.GetType(), listItems);
            }
        }
        
        public IEnumerable<Item> GetItemByType(Type type)
        {
            return dict[type];
        }
    }
}
