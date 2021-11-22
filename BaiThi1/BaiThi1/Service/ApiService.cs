using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using BaiThi1.Models.Entity;
using BaiThi1.Adapter;

namespace BaiThi1.Service
{
    class ApiService
    {
        public async Task<BaiThi1.Models.Entity.DTO.Employees> GetHome()
        {
            HttpClient client = new HttpClient();
            ApiURL uRL = ApiURL.GetInstance();
            var rs = await client.GetAsync(uRL.GetApiHome());
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                var rsContent = await rs.Content.ReadAsStringAsync();
                BaiThi1.Models.Entity.DTO.Employees categories = JsonConvert.DeserializeObject<BaiThi1.Models.Entity.DTO.Employees>(rsContent);
                return categories;
            }
            return null;
        }
    }
}
