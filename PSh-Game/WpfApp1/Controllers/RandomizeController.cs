using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using WpfApp1.Services;
using static WpfApp1.Services.RandomizeService;

namespace WpfApp1.Controllers
{
    public class RandomizeController
    {
        RandomizeService randomizeService = new RandomizeService();

        public async Task <RandomUser> GetRandomUser()
        {

            return await randomizeService.GetRandomUser();
        }

    }
}
