using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvatradeTests.Model;
using AvatradeTests.Utils;

namespace AvatradeTests.Service
{
    public class CreatorUser
    {
        public static User JoiningMyAccountFromProperty()
        {
            return TestDataParametr<User>.GetParametrs();
        }
    }
}
