using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_Application.Model
{
    class Assets
    {
        private List<Asset> assets = new List<Asset>();

        public Assets(int propertyId)
        {
            assets.Add(new Asset("Kitchen Sink"));
            assets.Add(new Asset("Bath Tub"));
            assets.Add(new Asset("Oven"));
        }

        public List<Asset> AssetList()
        {
            return assets;
        }
    }
}
