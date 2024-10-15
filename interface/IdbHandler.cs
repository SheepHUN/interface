using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface 
{
    interface IdbHandler
    {
        void ReadAll();
        void InsertOne(User user);

        void DeleteOne(User user);

        void DeleteAll();

        void UpdateOne(User oneUser);
    }
}
