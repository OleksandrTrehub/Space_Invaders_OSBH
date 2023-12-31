﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders_OSBH.GameObjectFactories
{
    internal class PlayerShipFactory : GameObjectFactory
    {
        public PlayerShipFactory(GameSettings gameSettings)
            :base(gameSettings)
        {
            
        }
        public  override GameObject GetGameObject(GameObjectPlace objectPlace)
        {
            
            GameObject gameObject = new PlayerShip() { Figure = GameSettings.PlayerShip, GameObjectPlace = objectPlace, GameObjectType = GameObjectType.PlayerShip };
            return gameObject;
        }

        public GameObject GetGameObject() {
            GameObjectPlace place = new GameObjectPlace() { XCoordinate = GameSettings.PlayerShipStartXCoordinate, YCoordinate = GameSettings.PlayerShipStartYCoordinate };
            GameObject gameObject =  GetGameObject(place);
            return gameObject;
        }
    }
}
