using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsPhoneGame4.GameElements;

namespace WindowsPhoneGame4.CollisionManager
{
    public delegate void DeveloperPCCollDelegate(GameElement obj1, GameElement obj2);

    public class CollisionManager
    {
        private List<GameElement> gameElements;
        private GameElement developer;
        private GameElement pc;

        public event DeveloperPCCollDelegate DeveloperPcCollEvent;
        public event DeveloperPCCollDelegate DeveloperEnemyCollEvent;

        public CollisionManager()
        {
            this.gameElements = new List<GameElement>();
        }

        public void AddToManager(GameElement newElement)
        {
            if (!this.gameElements.Contains(newElement))
            {
                this.gameElements.Add(newElement);
            }
        }

        public void RemoveFromManager(GameElement elementToRemove)
        {
            if (this.gameElements.Contains(elementToRemove))
            {
                this.gameElements.Remove(elementToRemove);
            }
        }

        public void DetectCollisions()
        {
            if (developer.DestRect.Intersects(pc.DestRect))
            {
                if (this.DeveloperPcCollEvent != null)
                {
                    this.DeveloperPcCollEvent.Invoke(this.developer, this.pc);
                }
            }

            foreach (var gameElement in this.gameElements)
            {
                if(this.developer.DestRect.Intersects(gameElement.DestRect))
                {
                    if (this.DeveloperEnemyCollEvent != null)
                    {
                        this.DeveloperEnemyCollEvent.Invoke(this.developer, gameElement);
                    }
                }
            }
        }
    }
}
