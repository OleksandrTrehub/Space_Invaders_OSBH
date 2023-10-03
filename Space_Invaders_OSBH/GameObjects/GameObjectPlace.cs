using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders_OSBH
{
    internal class GameObjectPlace
    {
        public int XCoordinate {  get; set; }
        public int YCoordinate { get; set; }


        public override bool Equals(object obj)
        {
            GameObjectPlace newObj = obj as GameObjectPlace;
            if (newObj != null &&
                this.XCoordinate == newObj.XCoordinate &&
                this.YCoordinate == newObj.YCoordinate)
            { return true; }

            return false;
            //return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



    }
}
