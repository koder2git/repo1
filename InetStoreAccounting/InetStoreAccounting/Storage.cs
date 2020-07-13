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
            foreach (var item in dict)
            {
                foreach (var itm in item.Value)
                {
                    if (itm.ID.Equals(id))
                    {
                        itm.Print();
                        item.Value.Remove(itm);
                        break;
                    }
                }
            }
        }
    }
}
