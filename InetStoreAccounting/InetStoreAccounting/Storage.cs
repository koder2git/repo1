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

        public void RemoveItemByGuid(Guid id)
        {
            foreach (var items in dict)
            {
                //var result = from item in items.Value
                //             where item.ID == id
                //             select item;
                var result = items.Value.Where(item => item.ID.Equals(id));
                foreach (var res in result)
                {
                    items.Value.Remove(res);
                    break;
                }
            }
        }
    }
}
