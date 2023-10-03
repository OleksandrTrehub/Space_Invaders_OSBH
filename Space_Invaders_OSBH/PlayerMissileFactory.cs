using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders_OSBH.GameObjectFactories
{
    internal class PlayerMissileFactory
    {
        public PlayerMissileFactory()

        {
            
        }
        public GameObject GetGameObject(GameObjectPlace objectPlace)
        {
            GameObjectPlace missilePlace = new GameObjectPlace() {XCoordinate = objectPlace.XCoordinate, YCoordinate = objectPlace.YCoordinate-1 };
            GameObject missile = new PlayerMissile() {Figure = '0', GameObjectPlace = missilePlace};

            return missile;



        }
    }
}
